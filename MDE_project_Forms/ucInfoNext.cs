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
    public partial class ucInfoNext : UserControl
    {
        public ucInfoNext()
        {
            InitializeComponent();
        }
        public string OutputDeviceCategory2
        {
            set { outputDeviceCategory2.Text = value; }
        }
        public string OutputDeviceName2
        {
            set { outputDeviceName2.Text = value; }
        }
        public string OutputModellNumber2
        {
            set { outputModellNumber2.Text = value; }
        }
        public string OutputSerialNumber2
        {
            set { outputSerialNumber2.Text = value; }
        }
        public string OutputMaintenanceDate2
        {
            set { outputMaintenanceDate2.Text = value; }
        }
        public string OutputLotNumber2
        {
            set { outputLotNumber2.Text = value; }
        }
        private void ucInfoNext_Load(object sender, EventArgs e)
        {

        }
    }
}
