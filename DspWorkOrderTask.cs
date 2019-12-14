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
 * Author: Dustin Webber
 * Date: October 26th, 2019
 * 
 * Form for user to view a work order id's task description.
 *************************************************************************/

namespace CSharpAdvFinal
{
    public partial class DspWorkOrderTask : Form
    {
        iDB2Connection connection;
        iDB2Command command;
        iDB2DataReader reader;

        public DspWorkOrderTask()
        {
            InitializeComponent();
        }

        private void btnGetTask_Click(object sender, EventArgs e)
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
                    txtTask.Text = reader.GetString(0);
                }
                else
                {
                    txtTask.Text = "No results found for specified work order id.";
                }

                reader.Close();

            }
            catch (Exception ex) { txtTask.Text = ex.Message; }

        }

        // Button disabled if textbox is empty
        private void txtWorkOrder_TextChanged(object sender, EventArgs e)
        {
            btnGetTask.Enabled = (txtWorkOrder.TextLength > 0); 
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            new DWAddARecord().ShowDialog();
        }
    }
}
