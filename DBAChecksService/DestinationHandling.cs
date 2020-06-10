﻿using Amazon.S3.Model;
using DBAChecks;
using Microsoft.SqlServer.Management.Smo;
using Newtonsoft.Json;
using Quartz;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using Topshelf;
using Topshelf.Quartz;
using static DBAChecks.DBAChecksConnection;

namespace DBAChecksService
{
    public class DestinationHandling
    {

        public static void Write(DataSet ds, string destination, string fileName, string AWSProfile, string AccessKey, string SecretKey, ConnectionType destinationType)
        {
            switch (destinationType)
            {
                case ConnectionType.AWSS3:
                    WriteS3(ds, destination, fileName, AWSProfile, AccessKey, SecretKey);
                    break;
                case ConnectionType.Directory:
                    WriteFolder(ds, destination, fileName);
                    break;
                case ConnectionType.SQL:
                    WriteDB(ds, destination);
                    break;
            }

        }

        public static void WriteS3(DataSet ds, string destination, string fileName, string AWSProfile, string AccessKey, string SecretKey)
        {
            Console.WriteLine("Upload to S3");
            var uri = new Amazon.S3.Util.AmazonS3Uri(destination);
            var s3Cli = AWSTools.GetAWSClient(AWSProfile, AccessKey, SecretKey, uri);
            var r = new Amazon.S3.Model.PutObjectRequest();

            if (System.IO.Path.GetExtension(fileName) == "bin")
            {

                ds.RemotingFormat = SerializationFormat.Binary;
                BinaryFormatter fmt = new BinaryFormatter();
                MemoryStream ms = new MemoryStream();
                fmt.Serialize(ms, ds);
                r.InputStream = ms;
            }
            else
            {
                string json = JsonConvert.SerializeObject(ds, Formatting.None);
                r.ContentBody = json;
                r.BucketName = uri.Bucket;
            }
            r.BucketName = uri.Bucket;
            r.Key = (uri.Key + "/" + fileName).Replace("//", "/");
            s3Cli.PutObject(r);

        }

        public static void WriteFolder(DataSet ds, string destination, string fileName)
        {
            if (System.IO.Directory.Exists(destination))
            {
                string filePath = Path.Combine(destination, fileName);
                Console.WriteLine("Write to " + filePath);
                if (System.IO.Path.GetExtension(fileName) == "bin")
                {
                    ds.RemotingFormat = SerializationFormat.Binary;
                    BinaryFormatter fmt = new BinaryFormatter();
                    using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                    {
                        fmt.Serialize(fs, ds);
                    }
                }
                else
                {
                    string json = JsonConvert.SerializeObject(ds, Formatting.None);
                    File.WriteAllText(filePath, json);
                }
            }
            else
            {
                Console.WriteLine("Destination Folder doesn't exist");
            }
        }

        public static void WriteDB(DataSet ds, string destination)
        {
            var importer = new DBImporter();
            Console.WriteLine("Update DBAChecks DB");
            importer.Update(destination, ds);
        }
    }
}
