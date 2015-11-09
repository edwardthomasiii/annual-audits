namespace annual_audit_executive_summary
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.trans_histBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterdataset = new annual_audit_executive_summary.masterdataset();
            this.app_infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onhandtableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionshourcountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.progressselectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RechooseTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compstatsvehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.batteryruntimesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recommendationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.firstdate = new System.Windows.Forms.DateTimePicker();
            this.lastdate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trans_histTableAdapter = new annual_audit_executive_summary.masterdatasetTableAdapters.trans_histTableAdapter();
            this.app_infoTableAdapter = new annual_audit_executive_summary.masterdatasetTableAdapters.app_infoTableAdapter();
            this.onhandtableTableAdapter = new annual_audit_executive_summary.masterdatasetTableAdapters.onhandtableTableAdapter();
            this.transactionshourcountTableAdapter = new annual_audit_executive_summary.masterdatasetTableAdapters.transactionshourcountTableAdapter();
            this.progressselectionTableAdapter = new annual_audit_executive_summary.masterdatasetTableAdapters.progressselectionTableAdapter();
            this.RechooseTableTableAdapter = new annual_audit_executive_summary.masterdatasetTableAdapters.RechooseTableTableAdapter();
            this.compstatsvehicleTableAdapter = new annual_audit_executive_summary.masterdatasetTableAdapters.compstatsvehicleTableAdapter();
            this.batteryruntimesTableAdapter = new annual_audit_executive_summary.masterdatasetTableAdapters.batteryruntimesTableAdapter();
            this.recommendationsTableAdapter = new annual_audit_executive_summary.masterdatasetTableAdapters.recommendationsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.trans_histBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterdataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.app_infoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onhandtableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionshourcountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressselectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RechooseTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compstatsvehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batteryruntimesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recommendationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // trans_histBindingSource
            // 
            this.trans_histBindingSource.DataMember = "trans_hist";
            this.trans_histBindingSource.DataSource = this.masterdataset;
            // 
            // masterdataset
            // 
            this.masterdataset.DataSetName = "masterdataset";
            this.masterdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // app_infoBindingSource
            // 
            this.app_infoBindingSource.DataMember = "app_info";
            this.app_infoBindingSource.DataSource = this.masterdataset;
            // 
            // onhandtableBindingSource
            // 
            this.onhandtableBindingSource.DataMember = "onhandtable";
            this.onhandtableBindingSource.DataSource = this.masterdataset;
            // 
            // transactionshourcountBindingSource
            // 
            this.transactionshourcountBindingSource.DataMember = "transactionshourcount";
            this.transactionshourcountBindingSource.DataSource = this.masterdataset;
            // 
            // progressselectionBindingSource
            // 
            this.progressselectionBindingSource.DataMember = "progressselection";
            this.progressselectionBindingSource.DataSource = this.masterdataset;
            // 
            // RechooseTableBindingSource
            // 
            this.RechooseTableBindingSource.DataMember = "RechooseTable";
            this.RechooseTableBindingSource.DataSource = this.masterdataset;
            // 
            // compstatsvehicleBindingSource
            // 
            this.compstatsvehicleBindingSource.DataMember = "compstatsvehicle";
            this.compstatsvehicleBindingSource.DataSource = this.masterdataset;
            // 
            // batteryruntimesBindingSource
            // 
            this.batteryruntimesBindingSource.DataMember = "batteryruntimes";
            this.batteryruntimesBindingSource.DataSource = this.masterdataset;
            // 
            // recommendationsBindingSource
            // 
            this.recommendationsBindingSource.DataMember = "recommendations";
            this.recommendationsBindingSource.DataSource = this.masterdataset;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportViewer1.BackgroundImage = global::annual_audit_executive_summary.Properties.Resources.smallmtclogo;
            this.reportViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reportViewer1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.IsDocumentMapWidthFixed = true;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.trans_histBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.app_infoBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.onhandtableBindingSource;
            reportDataSource4.Name = "hourcount";
            reportDataSource4.Value = this.transactionshourcountBindingSource;
            reportDataSource5.Name = "chargecoolreadystats";
            reportDataSource5.Value = this.progressselectionBindingSource;
            reportDataSource6.Name = "Recosenbatteries";
            reportDataSource6.Value = this.RechooseTableBindingSource;
            reportDataSource7.Name = "vehiclestats";
            reportDataSource7.Value = this.compstatsvehicleBindingSource;
            reportDataSource8.Name = "batteryruntimes";
            reportDataSource8.Value = this.batteryruntimesBindingSource;
            reportDataSource9.Name = "recommendations";
            reportDataSource9.Value = this.recommendationsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "annual_audit_executive_summary.Executive_Summary.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 16, 3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Padding = new System.Windows.Forms.Padding(0, 45, 0, 0);
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowPageNavigationControls = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(872, 673);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // firstdate
            // 
            this.firstdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.firstdate.Location = new System.Drawing.Point(303, 21);
            this.firstdate.Name = "firstdate";
            this.firstdate.Size = new System.Drawing.Size(112, 20);
            this.firstdate.TabIndex = 1;
            this.firstdate.Value = new System.DateTime(2014, 10, 30, 0, 0, 0, 0);
            // 
            // lastdate
            // 
            this.lastdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.lastdate.Location = new System.Drawing.Point(503, 21);
            this.lastdate.Name = "lastdate";
            this.lastdate.Size = new System.Drawing.Size(112, 20);
            this.lastdate.TabIndex = 2;
            this.lastdate.Value = new System.DateTime(2015, 10, 30, 0, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Run Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "End Date";
            // 
            // trans_histTableAdapter
            // 
            this.trans_histTableAdapter.ClearBeforeFill = true;
            // 
            // app_infoTableAdapter
            // 
            this.app_infoTableAdapter.ClearBeforeFill = true;
            // 
            // onhandtableTableAdapter
            // 
            this.onhandtableTableAdapter.ClearBeforeFill = true;
            // 
            // transactionshourcountTableAdapter
            // 
            this.transactionshourcountTableAdapter.ClearBeforeFill = true;
            // 
            // progressselectionTableAdapter
            // 
            this.progressselectionTableAdapter.ClearBeforeFill = true;
            // 
            // RechooseTableTableAdapter
            // 
            this.RechooseTableTableAdapter.ClearBeforeFill = true;
            // 
            // compstatsvehicleTableAdapter
            // 
            this.compstatsvehicleTableAdapter.ClearBeforeFill = true;
            // 
            // batteryruntimesTableAdapter
            // 
            this.batteryruntimesTableAdapter.ClearBeforeFill = true;
            // 
            // recommendationsTableAdapter
            // 
            this.recommendationsTableAdapter.ClearBeforeFill = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 673);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lastdate);
            this.Controls.Add(this.firstdate);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Executive Audit Report Program";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trans_histBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterdataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.app_infoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onhandtableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionshourcountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressselectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RechooseTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compstatsvehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batteryruntimesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recommendationsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource app_infoBindingSource;
        private masterdataset masterdataset;
        private System.Windows.Forms.DateTimePicker firstdate;
        private System.Windows.Forms.DateTimePicker lastdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource progressselectionBindingSource;
        private System.Windows.Forms.BindingSource batteryruntimesBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource trans_histBindingSource;
        private System.Windows.Forms.BindingSource onhandtableBindingSource;
        private System.Windows.Forms.BindingSource transactionshourcountBindingSource;
        private System.Windows.Forms.BindingSource RechooseTableBindingSource;
        private System.Windows.Forms.BindingSource compstatsvehicleBindingSource;
        private System.Windows.Forms.BindingSource recommendationsBindingSource;
        private masterdatasetTableAdapters.trans_histTableAdapter trans_histTableAdapter;
        private masterdatasetTableAdapters.app_infoTableAdapter app_infoTableAdapter;
        private masterdatasetTableAdapters.onhandtableTableAdapter onhandtableTableAdapter;
        private masterdatasetTableAdapters.transactionshourcountTableAdapter transactionshourcountTableAdapter;
        private masterdatasetTableAdapters.progressselectionTableAdapter progressselectionTableAdapter;
        private masterdatasetTableAdapters.RechooseTableTableAdapter RechooseTableTableAdapter;
        private masterdatasetTableAdapters.compstatsvehicleTableAdapter compstatsvehicleTableAdapter;
        private masterdatasetTableAdapters.batteryruntimesTableAdapter batteryruntimesTableAdapter;
        private masterdatasetTableAdapters.recommendationsTableAdapter recommendationsTableAdapter;
       
      
      
       
       
      
      
    }
}

