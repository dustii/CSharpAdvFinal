using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void cbxPlaneNo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbxTaskID.Items.Clear();
            string planeNo = cbxPlaneNo.SelectedValue.ToString();
            cbxTaskID.Items.AddRange(new object[]
            {

            });
        }
    }
}
