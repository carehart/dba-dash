﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBADashGUI.Changes
{
    public partial class JobDDLHistory : UserControl
    {
        public JobDDLHistory()
        {
            InitializeComponent();
        }

        public int InstanceID { get; set; }
        public Guid JobID { get; set; }

        public DataTable GetDDLHistory()
        {
            using(var cn = new SqlConnection(Common.ConnectionString))
            using(var cmd = new SqlCommand("dbo.JobDDLHistory_Get", cn) { CommandType = CommandType.StoredProcedure })
            using(var da = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("InstanceID", InstanceID);
                cmd.Parameters.AddWithValue("JobID", JobID);
                var dt = new DataTable();
                da.Fill(dt);
                Common.ConvertUTCToLocal(ref dt);
                return dt;

            }
        }

        public void RefreshData()
        {
            diffControl1.OldText = "";
            diffControl1.NewText = "";
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = GetDDLHistory();
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                var row = (DataRowView)dgv.SelectedRows[0].DataBoundItem;
                long DDLID = (long)row["DDLID"];
                long DDLIDold = row["PreviousDDLID"] == DBNull.Value ? -1 : (long)row["PreviousDDLID"];

                string newText = Common.DDL(DDLID);
                string oldText = DDLIDold > 0 ? Common.DDL(DDLIDold) : "";

                diffControl1.OldText = oldText;
                diffControl1.NewText = newText;
                if (string.IsNullOrEmpty(oldText))
                {
                    diffControl1.Mode = DiffControl.ViewMode.Code;
                }
                else
                {
                    diffControl1.Mode = DiffControl.ViewMode.Diff;
                }
            }
        }
    }
}
