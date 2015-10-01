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
            // get customer info query
            this.app_infoTableAdapter.Fill(this.masterdataset.app_info); 
            //get what was used during this timeframe
            this.trans_histTableAdapter.Fill(this.masterdataset.trans_hist, firstdate.Value, lastdate.Value);
            //get what is listed in the system as available based on the last day or report
            this.onhandtableTableAdapter.Fill(this.masterdataset.onhandtable, lastdate.Value);
            //get the transactions by day per group
            this.transperdayTableAdapter.Fill(this.masterdataset.transperday, firstdate.Value, lastdate.Value);
            // TODO: This line of code loads data into the 'masterdataset.batterystatus' table. You can move, or remove it, as needed.
            this.batterystatusTableAdapter.Fill(this.masterdataset.batterystatus, firstdate.Value, lastdate.Value);
            // TODO: This line of code loads data into the 'masterdataset.batterycooling' table. You can move, or remove it, as needed.
            //is.batterycoolingTableAdapter.Fill(this.masterdataset.batterycooling,firstdate.Value,lastdate.Value);
            // TODO: This line of code loads data into the 'masterdataset.batterycharging' table. You can move, or remove it, as needed.
            //is.batterychargingTableAdapter.Fill(this.masterdataset.batterycharging,firstdate.Value,lastdate.Value);
         
            //pulls the report into the viewer
            this.reportViewer1.RefreshReport();
        }
    }
}