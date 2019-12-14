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


/*************************************************************************
 * IBM .NET Enterprise Final Project 
 * Author: Truman Smith
 * Date: November 1st, 2019
 * 
 * Form for user to view a work order id's task description.
 *************************************************************************/

namespace CSharpAdvFinal
{
    public partial class MaintenanceLogs : Form
    {
        //iDB2Connection connection;
       // iDB2Command command;
       // iDB2DataReader reader;

        private void btnGetmtnLog_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new iDB2Connection("DataSource=deathstar.gtc.edu");

                command = connection.CreateCommand();
                command.CommandText = "SELECT taskDesc " +
                    "FROM Tasks T JOIN WorkOrder WO ON T.taskId = WO.taskId " +
                    "WHERE WO.orderId = '" + txtWorkOrder.Text.ToUpper() + "'";

                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    txtMtnLog.Text = reader.GetString(0);
                }
                else
                {
                    txtMtnLog.Text = "No results found for specified work order id.";
                }

                reader.Close();

            }
            catch (Exception ex) { txtMtnLog.Text = ex.Message; }

        }

        // Button disabled if textbox is empty
        private void txtMtnLog_TextChanged(object sender, EventArgs e)
        {
            btnGetTask.Enabled = (txtMtnLog.TextLength > 0);
        }

        private void DspWorkMtnLog_Load(object sender, EventArgs e)
        {

        }
    }
}
