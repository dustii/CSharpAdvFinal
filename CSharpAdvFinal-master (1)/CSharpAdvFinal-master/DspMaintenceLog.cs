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
 * Date: December 13th, 2019
 * 
 * Form for user to view a Planes maintence logs
 *************************************************************************/
namespace CSharpAdvFinal
{
    public partial class DspMaintenceLog : Form
    {
        iDB2Connection connection;
        iDB2Command command;
        iDB2DataReader dataReader;
        public DspMaintenceLog()
        {
            InitializeComponent();
        }

        private void DspMaintenceLog_Load(object sender, EventArgs e)
        {
        }

        private void btnGetLog_Click(object sender, EventArgs e)
        {
            //ceonnect to the database
            try
            {
                connection = new iDB2Connection("DataSource=deathstar.gtc.edu;DefaultCollection=FLIGHT2019");
                command = connection.CreateCommand();

              //grab the data  
                command.CommandText = "SELECT * FROM MAINTLOG " 
                    + "WHERE PLANENO = '" + txtPlaneNum.Text.ToUpper() +"'"; 
                connection.Open();
                dataReader = command.ExecuteReader();
                //Display to listbox
                if (dataReader.Read())
                {
                    listBox1.Items.Add("Log Number: " + dataReader.GetString(1));
                    listBox1.Items.Add("Task ID: " + dataReader.GetString(2));
                    listBox1.Items.Add("Maintence Start Date: " + dataReader.GetString(3));
                    listBox1.Items.Add("Maintence End Date: " + dataReader.GetString(4));
                    listBox1.Items.Add("Status: " + dataReader.GetString(5));
                    listBox1.Items.Add("Maintence Cost: " + dataReader.GetString(6));


                }
                else
                {
                    txtPlaneNum.Text = "No results found for specified Plane Number id.";
                }

                dataReader.Close();
            }

            catch (Exception ex) { txtPlaneNum.Text = ex.Message; }
        }
    }
}
