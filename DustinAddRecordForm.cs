using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Data.DB2.iSeries;

namespace CSharpAdvFinal
{
    public partial class DustinAddRecordForm : Form
    {
        public DustinAddRecordForm()
        {
            InitializeComponent();
        }

        private void DWAddARecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'deathstarDataSet.TASKS' table. You can move, or remove it, as needed.
            this.tASKSTableAdapter.Fill(this.deathstarDataSet.TASKS);
            // TODO: This line of code loads data into the 'deathstarDataSet.AIRPLANE' table. You can move, or remove it, as needed.
            this.aIRPLANETableAdapter.Fill(this.deathstarDataSet.AIRPLANE);

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newRow = deathstarDataSet.WORKORDER.NewRow();
                newRow["orderID"] = txtWrkOrdID.Text;
                newRow["planeNo"] = cbxPlaneNo.Text;
                newRow["taskID"] = cbxTaskID.Text;
                newRow["strDat"] = dteStart.Text;
                newRow["endDat"] = dteEnd.Text;
                newRow["woStat"] = txtStatus.Text;
                newRow["partsLbr"] = numCost.Text;
                newRow["lbrHours"] = numLabor.Text;

                deathstarDataSet.WORKORDER.AddWORKORDERRow((DeathstarDataSet.WORKORDERRow) newRow);
                deathstarDataSet.WORKORDER.AcceptChanges();
                iDB2DataAdapter dataAdapter = new iDB2DataAdapter();
                dataAdapter.Update(deathstarDataSet.WORKORDER);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
