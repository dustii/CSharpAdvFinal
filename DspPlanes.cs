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
    public partial class DspPlanes : Form
    {
        iDB2Connection conn;
        iDB2Command comm;
        iDB2DataReader reader;
        string SQL;
        string connString;

        public DspPlanes()
        {
            //Establish a connection with GTC flight library
            connString = "DataSource=deathstar.gtc.edu;DefaultCollection=FLIGHT2019";
            conn = new iDB2Connection(connString);
            InitializeComponent();
        }

        private void DspPlane_Click(object sender, EventArgs e)
        {
            try
            {
                //Select everything within the AIRPLANE table
                SQL = "Select * FROM AIRPLANE";
                
                comm = new iDB2Command(SQL, conn);
                conn.Open();

                reader = comm.ExecuteReader();
                while (reader.Read())
                    //Use reader and the listbox to display all non null values in the table 
                    DisplayPlane.Items.Add("Plane#:  " + reader.GetString(0) + "  Max Flight Dist:  " 
                        + reader.GetString(1) + "  FClass:  " + reader.GetString(2) + "  CClass:  " 
                        + reader.GetString(3)  + "  PAvail:  " + reader.GetString(4) + "  MaintMiles:  " 
                        + reader.GetString(5) + "  PlaneModel:  " + reader.GetString(6) + "  PlaneMake:  " 
                        + reader.GetString(7) + "  APARCD:  " + reader.GetString(8) + "  Date Maintenence:  "
                        + reader.GetString(12));

                conn.Close();
            }
            //Any DB error catches 
            catch (iDB2Exception ie)
            {
                DisplayPlane.Items.Add(ie.Message);
            }
            catch (Exception ex)
            {
                DisplayPlane.Items.Add(ex.Message);
            }
        }
    }
}
