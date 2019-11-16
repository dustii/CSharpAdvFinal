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
    public partial class DWAddARecord : Form
    {
        public DWAddARecord()
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
                string insertStatement = "INSERT INTO ITPA400.WorkOrder " +
                    "(orderID, planeNo, taskID, strDat, endDat, woStat, partsLbr, lbrHours) " +
                    "VALUES (?, ?, ?, ?, ?, ?, ?, ?)";

                iDB2Connection connection = new iDB2Connection("DataSource=deathstar.gtc.edu");
                iDB2Command command = new iDB2Command(insertStatement, connection);

                command.Parameters.Add(new iDB2Parameter("orderID", iDB2DbType.iDB2Char, 10));
                command.Parameters.Add(new iDB2Parameter("planeNo", iDB2DbType.iDB2Char, 10));
                command.Parameters.Add(new iDB2Parameter("taskID", iDB2DbType.iDB2Char, 10));
                command.Parameters.Add(new iDB2Parameter("strDat", iDB2DbType.iDB2Date));
                command.Parameters.Add(new iDB2Parameter("endDat", iDB2DbType.iDB2Date));
                command.Parameters.Add(new iDB2Parameter("woStat", iDB2DbType.iDB2Char, 10));
                command.Parameters.Add(new iDB2Parameter("partsLbr", iDB2DbType.iDB2Decimal, 10));
                command.Parameters.Add(new iDB2Parameter("lbrHours", iDB2DbType.iDB2Decimal, 7));

                command.Parameters["orderID"].Value = txtWrkOrdID.Text;
                command.Parameters["planeNo"].Value = cbxPlaneNo.Text;
                command.Parameters["taskID"].Value = cbxTaskID.Text;
                command.Parameters["strDat"].Value = dteStart.Value;
                command.Parameters["endDat"].Value = dteEnd.Checked ? dteEnd.Value : iDB2Date.Null;
                command.Parameters["woStat"].Value = txtStatus.Text;
                command.Parameters["partsLbr"].Value = numCost.Value;
                command.Parameters["lbrHours"].Value = numHours.Value;

                command.Connection.Open();

                if ( command.ExecuteNonQuery() == 1 )
                {
                    labelResult.Visible = true;
                    labelResult.Text = "Row successfully inserted";
                    labelResult.ForeColor = Color.Green;
                }
                else
                {
                    labelResult.Visible = true;
                    labelResult.Text = "Row insertion failed";
                    labelResult.ForeColor = Color.Red;
                }

                connection.Close();
            }

            catch (iDB2Exception ex)
            {
                MessageBox.Show(ex.MessageDetails);
            }
        }

    }
}
