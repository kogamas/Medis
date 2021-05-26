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
    public partial class ucAddNext : UserControl
    {
        CommunicationInterface comm = new Communicator("https://fhir.ls.technikum-wien.at/fhir");
        public ucAddNext()
        {
            InitializeComponent();
            labelDeviceSaved.Visible = false;
            
        }
        public string OutputDeviceCategory
        {
            set { outputDeviceCategory.Text = value; }
        }
        public string OutputDeviceName
        {
            set { outputDeviceName.Text = value; }
        }
        public string OutputModellNumber
        {
            set { outputModellNumber.Text = value; }
        }
        public string OutputSerialNumber
        {
            set { outputSerialNumber.Text = value; }
        }
        public string OutputLotNumber
        {
            set { outputLotNumber.Text = value; }
        }
        public string OutputMaintenanceDay
        {
            set { outputMaintenanceDay.Text = value; }
        }
        public string OutputMaintenanceMonth
        {
            set { outputMaintenanceMonth.Text = value; }
        }
        public string OutputMaintenanceYear
        {
            set { outputMaintenanceYear.Text = value; }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            labelDeviceSaved.Visible = true;
            labelDeviceSaved.Text = "Device sucessfully saved";
            Form1.Instance.BackButton.Visible = false;
            buttonSaveDevice.Visible = false;

            int day = Convert.ToInt32(outputMaintenanceDay.Text);
            int month = Convert.ToInt32(outputMaintenanceMonth.Text);
            int year = Convert.ToInt32(outputMaintenanceYear.Text);

            comm.addDevice(outputDeviceName.Text, outputDeviceCategory.Text, new DateTime(year, month, day), outputModellNumber.Text, outputLotNumber.Text, outputSerialNumber.Text); ;
        }
        public void displayInput(string one, string two, string three)
        {
            outputDeviceCategory.Text = one;
            outputDeviceName.Text = two;
            outputModellNumber.Text = three;
        }

        private void labelDeviceSaved_Click(object sender, EventArgs e)
        {
            
        }

        private void labelLotNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
