using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace annual_audit_executive_summary
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
  
         
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            
            //used to bring in the dates of the report
           
            ReportParameter[] parameters = new ReportParameter[2];

            parameters[0] = new ReportParameter("firstdate", firstdate.Text);


            parameters[1] = new ReportParameter("lastdate", lastdate.Text);
            //MessageBox.Show("Loading Parameters for Audit Dates");
           
            this.reportViewer1.LocalReport.SetParameters(parameters);
            // TODO: This line of code loads data into the 'masterdataset.trans_hist' table. You can move, or remove it, as needed.
            this.trans_histTableAdapter.Fill(this.masterdataset.trans_hist, firstdate.Value, lastdate.Value);
            //MessageBox.Show("Loading History");
            // TODO: This line of code loads data into the 'masterdataset.app_info' table. You can move, or remove it, as needed.
            this.app_infoTableAdapter.Fill(this.masterdataset.app_info);
           // MessageBox.Show("Figuring Out Who You Are");
            // TODO: This line of code loads data into the 'masterdataset.onhandtable' table. You can move, or remove it, as needed.
            this.onhandtableTableAdapter.Fill(this.masterdataset.onhandtable);
           // MessageBox.Show("Finding out what you have on hand");
            // TODO: This line of code loads data into the 'masterdataset.transactionshourcount' table. You can move, or remove it, as needed.
            this.transactionshourcountTableAdapter.Fill(this.masterdataset.transactionshourcount, firstdate.Value, lastdate.Value);
           // MessageBox.Show("Figuring the Days Worked");
            // TODO: This line of code loads data into the 'masterdataset.progressselection' table. You can move, or remove it, as needed.
            this.progressselectionTableAdapter.Fill(this.masterdataset.progressselection, firstdate.Value, lastdate.Value);
           // MessageBox.Show("Loading up your effective use of the batteries");
            // TODO: This line of code loads data into the 'masterdataset.RechooseTable' table. You can move, or remove it, as needed.
            this.RechooseTableTableAdapter.Fill(this.masterdataset.RechooseTable, firstdate.Value, lastdate.Value);
           // MessageBox.Show("figuring out the Rechoose Reasons");
            // TODO: This line of code loads data into the 'masterdataset.compstatsvehicle' table. You can move, or remove it, as needed.
            this.compstatsvehicleTableAdapter.Fill(this.masterdataset.compstatsvehicle, firstdate.Value, lastdate.Value);
          //  MessageBox.Show("Figuring out your Statistics");
            // TODO: This line of code loads data into the 'masterdataset.batteryruntimes' table. You can move, or remove it, as needed.
            this.batteryruntimesTableAdapter.Fill(this.masterdataset.batteryruntimes, firstdate.Value, lastdate.Value);
          //  MessageBox.Show("Figuring out your Battery Runtimes");
            // TODO: This line of code loads data into the 'masterdataset.recommendations' table. You can move, or remove it, as needed.
            this.recommendationsTableAdapter.Fill(this.masterdataset.recommendations, firstdate.Value, lastdate.Value);
           // MessageBox.Show("Figuring out some Recommendations for you to improve on");
          

            //pulls the report into the viewer
            this.reportViewer1.RefreshReport();
        }

        private DateTime ReportParameter()
        {
            throw new NotImplementedException();
        }
    }
}