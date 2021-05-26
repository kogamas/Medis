using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDE_project_Forms
{
    public partial class ucAdd : UserControl
    {
        public ucAdd()
        {
            InitializeComponent();
        }
        public string InputDeviceCategory
        {
            get { return inputDeviceCategory.Text; }           
        }
        public string InputDeviceName
        {
            get { return inputDeviceName.Text; }           
        }
        public string InputModellNumber
        {
            get { return inputModellNumber.Text; }
        }
        public string InputSerialNumber
        {
            get { return inputSerialNumber.Text; }
        }

        public string InputLotNumber
        {
            get { return inputLotNumber.Text; }
        }
        public string InputMaintenanceDay
        {
            get { return inputMaintenanceDay.Text; }
        }
        public string InputMaintenanceMonth
        {
            get { return inputMaintenanceMonth.Text; }
        }
        public string InputMaintenanceYear
        {
            get { return inputMaintenanceYear.Text; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.Instance.changeUserControlAddToNext();
        }
        

        private void ucAdd_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void inputDeviceCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConditionallyEnableButton();
        }

        private void inputDeviceName_TextChanged(object sender, EventArgs e)
        {
            ConditionallyEnableButton();
        }

        private void inputModellNumber_TextChanged(object sender, EventArgs e)
        {
            ConditionallyEnableButton();
        }

        private void inputSerialNumber_TextChanged(object sender, EventArgs e)
        {
            ConditionallyEnableButton();
        }

        private void inputLotNumber_TextChanged(object sender, EventArgs e)
        {
            ConditionallyEnableButton();
        }
        public void ConditionallyEnableButton()
        {
            if (string.IsNullOrEmpty(InputDeviceCategory) == false  && InputDeviceName != String.Empty && InputModellNumber != String.Empty 
                && InputSerialNumber != String.Empty && InputLotNumber != String.Empty){

                button1.Enabled = true;

                //String.Empty    string.IsNullOrEmpty(comboBox1.Text)
                //InputDeviceCategory != String.Empty && InputDeviceName != String.Empty && InputModellNumber != String.Empty 
                //&& InputSerialNumber != String.Empty && InputMainteinanceDate != String.Empty)
            }
            else
            {
                button1.Enabled = false;
            }
            
        }

       
    }
}
