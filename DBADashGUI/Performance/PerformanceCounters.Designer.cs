﻿namespace DBADashGUI.Performance
{
    partial class PerformanceCounters
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chart1 = new LiveCharts.WinForms.CartesianChart();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsDateGrouping = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsAgg = new System.Windows.Forms.ToolStripDropDownButton();
            this.totalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sampleCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 31);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(1299, 763);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "cartesianChart1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsDateGrouping,
            this.tsAgg});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1299, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsDateGrouping
            // 
            this.tsDateGrouping.Image = global::DBADashGUI.Properties.Resources.Time_16x;
            this.tsDateGrouping.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDateGrouping.Name = "tsDateGrouping";
            this.tsDateGrouping.Size = new System.Drawing.Size(120, 28);
            this.tsDateGrouping.Text = "Date Group";
            // 
            // tsAgg
            // 
            this.tsAgg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalToolStripMenuItem,
            this.minToolStripMenuItem,
            this.maxToolStripMenuItem,
            this.avgToolStripMenuItem,
            this.sampleCountToolStripMenuItem});
            this.tsAgg.Image = global::DBADashGUI.Properties.Resources.AddComputedField_16x;
            this.tsAgg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAgg.Name = "tsAgg";
            this.tsAgg.Size = new System.Drawing.Size(69, 28);
            this.tsAgg.Text = "Avg";
            // 
            // totalToolStripMenuItem
            // 
            this.totalToolStripMenuItem.Name = "totalToolStripMenuItem";
            this.totalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.totalToolStripMenuItem.Tag = "Value_Total";
            this.totalToolStripMenuItem.Text = "Total";
            this.totalToolStripMenuItem.Click += new System.EventHandler(this.tsAgg_Click);
            // 
            // minToolStripMenuItem
            // 
            this.minToolStripMenuItem.Name = "minToolStripMenuItem";
            this.minToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.minToolStripMenuItem.Tag = "Value_Min";
            this.minToolStripMenuItem.Text = "Min";
            this.minToolStripMenuItem.Click += new System.EventHandler(this.tsAgg_Click);
            // 
            // maxToolStripMenuItem
            // 
            this.maxToolStripMenuItem.Name = "maxToolStripMenuItem";
            this.maxToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.maxToolStripMenuItem.Tag = "Value_Max";
            this.maxToolStripMenuItem.Text = "Max";
            this.maxToolStripMenuItem.Click += new System.EventHandler(this.tsAgg_Click);
            // 
            // avgToolStripMenuItem
            // 
            this.avgToolStripMenuItem.Checked = true;
            this.avgToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.avgToolStripMenuItem.Name = "avgToolStripMenuItem";
            this.avgToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.avgToolStripMenuItem.Tag = "Value_Avg";
            this.avgToolStripMenuItem.Text = "Avg";
            this.avgToolStripMenuItem.Click += new System.EventHandler(this.tsAgg_Click);
            // 
            // sampleCountToolStripMenuItem
            // 
            this.sampleCountToolStripMenuItem.Name = "sampleCountToolStripMenuItem";
            this.sampleCountToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sampleCountToolStripMenuItem.Tag = "SampleCount";
            this.sampleCountToolStripMenuItem.Text = "Sample Count";
            this.sampleCountToolStripMenuItem.Click += new System.EventHandler(this.tsAgg_Click);
            // 
            // PerformanceCounters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "PerformanceCounters";
            this.Size = new System.Drawing.Size(1299, 794);
            this.Load += new System.EventHandler(this.PerformanceCounters_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart chart1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsDateGrouping;
        private System.Windows.Forms.ToolStripDropDownButton tsAgg;
        private System.Windows.Forms.ToolStripMenuItem totalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sampleCountToolStripMenuItem;
    }
}
