using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using static Hl7.Fhir.Model.Device;

namespace MDE_project_Forms
{
    public partial class ucDeleteNext : UserControl
    {
        CommunicationInterface comm = new Communicator("https://fhir.ls.technikum-wien.at/fhir");
        public ucDeleteNext()
        {
            InitializeComponent();
            labelDeviceDeleted.Visible = false;
        }
        

        public string OutputDeviceCategory3
        {
            set { outputDeviceCategory3.Text = value; }
        }
        public string OutputDeviceName3
        {
            set { outputDeviceName3.Text = value; }
        }
        public string OutputModellNumber3
        {
            set { outputModellNumber3.Text = value; }
        }
        public string OutputSerialNumber3
        {
            set { outputSerialNumber3.Text = value; }
        }
        public string OutputMaintenanceDate3
        {
            set { outputMaintenanceDate3.Text = value; }
        }
        public string OutputLotNumber3
        {
            set { outputLotNumber3.Text = value; }
        }
        private void ucDeleteNext_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comm.deleteDeviceByName(outputDeviceName3.Text);
            labelDeviceDeleted.Visible = true;
            Form1.Instance.BackButton.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
