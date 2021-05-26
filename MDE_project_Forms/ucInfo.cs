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
    public partial class ucInfo : UserControl
    {
        CommunicationInterface comm = new Communicator("https://fhir.ls.technikum-wien.at/fhir");
        List<Device> currentData;
        int index;
        string DeviceCategory;
        string DeviceName;
        string ModelNumber;
        string SerialNumber;
        string MaintenanceDate;
        string LotNumber;

        public ucInfo()
        {
            InitializeComponent();
        }
        public string InputDeviceCategory2
        {
            get { return DeviceCategory; }
        }
        public string InputDeviceName2
        {
            get { return DeviceName; }
        }
        public string InputModellNumber2
        {
            get { return ModelNumber; }
        }
        public string InputSerialNumber2
        {
            get { return SerialNumber; }
        }
        public string InputMaintenanceDate2
        {
            get { return MaintenanceDate; }
        }
        public string InputLotNumber2
        {
            get { return LotNumber; }
        }



        private void UserControl2_Load(object sender, EventArgs e)
        {

        }
   
        private void buttonFindInfoDevice_Click(object sender, EventArgs e)
        {
            Device searchedData = currentData[index];
            DeviceCategory = searchedData.Type.Text;
            DeviceName = searchedData.DeviceName[0].Name;
            ModelNumber = searchedData.ModelNumber;
            SerialNumber = searchedData.SerialNumber;
            MaintenanceDate = searchedData.ExpirationDate;
            LotNumber = searchedData.LotNumber;
            Form1.Instance.changeUserControlInfoToNext();  
        }

        private void buttonFindInfoList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (radioButtonDeviceCategory.Checked)
            {
                currentData = comm.getDevicesByType(textBoxInput.Text);
                foreach (Device dev in currentData)
                {
                    listBox1.Items.Add(dev.DeviceName[0].Name);
                }
            }
            else if (radioButtonModellNumber.Checked)
            {
                currentData = comm.getDevicesByModelNumber(textBoxInput.Text);
                foreach (Device dev in currentData)
                {
                    listBox1.Items.Add(dev.DeviceName[0].Name);
                }
            }
            else if (radioButtonDeviceName.Checked)
            {
                currentData = comm.getDevicesByName(textBoxInput.Text);
                foreach (Device dev in currentData)
                {
                    listBox1.Items.Add(dev.DeviceName[0].Name);
                }
            }
            /*else if (radioButtonSerialNumber.Checked)
            {
                //suche nach SN fehlt
                //List<Device> list = comm.getDevicesByName(textBoxInput.Text);
                foreach (Device dev in currentData)
                {
                    listBox1.Items.Add(dev.DeviceName[0].Name);
                }
            }*/

            /*else if (radioButtonMaintenanceDate.Checked)
            {
                currentData = comm.getDevicesByExpirationDate(new DateTime());
                foreach (Device dev in currentData)
                {
                    listBox1.Items.Add(dev.DeviceName[0].Name);
                }
            }*/
            else
            {
                listBox1.Items.Add("Pls choose one of the following criterias.");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string search = listBox1.SelectedItem.ToString();
            index = listBox1.FindString(search);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
