using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDE_project_Forms
{
    public partial class Form1 : Form
    {
        public Panel pnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }
        public Button BackButton
        {
            get { return buttonBack; }
            set { buttonBack = value; }
        }

        static Form1 _obj;
        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }

        public Form1()
        {
            InitializeComponent();           
        }

        public ucHome UserControlHome
        {
            get { return ucHome1; }
            set { ucHome1 = value; }
        }
        public ucAdd UserControlAdd
        {
            get { return ucAdd1; }
            set { ucAdd1 = value; }
        }
        public ucAddNext UserControlAddNext
        {
            get { return ucAddNext1; }
            set { ucAddNext1 = value; }
        }
        public ucFind UserControlFind
        {
            get { return ucFind1; }
            set { ucFind1 = value; }
        }
        public ucInfo UserControlInfo
        {
            get { return ucInfo1; }
            set { ucInfo1 = value; }
        }
        public ucInfoNext UserControlInfoNext
        {
            get { return ucInfoNext1; }
            set { ucInfoNext1 = value; }
        }
        public ucStart UserControlStart
        {
            get { return ucStart1; }
            set { ucStart1 = value; }
        }
        public ucDelete UserControlDelete
        {
            get { return ucDelete1; }
            set { ucDelete1 = value; }
        }
        public ucDeleteNext UserControlDeleteNext
        {
            get { return ucDeleteNext1; }
            set { ucDeleteNext1 = value; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            buttonBack.Visible = false;
            _obj = this;
           showUserControl(UserControlHome);
            showPictureBoxAsClicked(pictureBoxHome);
        }

        private void pictureBoxAdd_Click(object sender, EventArgs e)
        {
            UserControlAdd = new ucAdd();
            showUserControl(UserControlAdd);          
            showPictureBoxAsClicked(pictureBoxAdd);
            BackButton.Visible = false;        
        }
        private void pictureBoxFind_Click(object sender, EventArgs e)
        {
            UserControlFind = new ucFind();
            showUserControl(UserControlFind);           
            showPictureBoxAsClicked(pictureBoxFind);
            BackButton.Visible = false;
        }
        private void pictureBoxInfo_Click(object sender, EventArgs e)
        {
            UserControlInfo = new ucInfo();
            showUserControl(UserControlInfo);        
            showPictureBoxAsClicked(pictureBoxShow);
            BackButton.Visible = false;
        }
        private void pictureBoxHome_Click(object sender, EventArgs e)
        {           
            showUserControl(UserControlHome);         
            showPictureBoxAsClicked(pictureBoxHome);
            BackButton.Visible = false;
        }
        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {
            UserControlDelete = new ucDelete();
            showUserControl(UserControlDelete);
            showPictureBoxAsClicked(pictureBoxDelete);
            BackButton.Visible = false;
        }
       
        public void showPictureBoxAsClicked(PictureBox pictureBox)
        {
            pictureBoxAdd.BorderStyle = BorderStyle.None;
            pictureBoxFind.BorderStyle = BorderStyle.None;
            pictureBoxShow.BorderStyle = BorderStyle.None;
            pictureBoxHome.BorderStyle = BorderStyle.None;
            pictureBoxDelete.BorderStyle = BorderStyle.None;
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
        }
        public void changeUserControlAddToNext()
        {         
            UserControlAddNext = new ucAddNext();
            UserControlAddNext.OutputDeviceCategory = UserControlAdd.InputDeviceCategory;
            UserControlAddNext.OutputDeviceName = UserControlAdd.InputDeviceName;
            UserControlAddNext.OutputModellNumber = UserControlAdd.InputModellNumber;
            UserControlAddNext.OutputSerialNumber = UserControlAdd.InputSerialNumber;
            UserControlAddNext.OutputLotNumber = UserControlAdd.InputLotNumber;
            UserControlAddNext.OutputMaintenanceDay = UserControlAdd.InputMaintenanceDay;
            UserControlAddNext.OutputMaintenanceMonth = UserControlAdd.InputMaintenanceMonth;
            UserControlAddNext.OutputMaintenanceYear = UserControlAdd.InputMaintenanceYear;

            showUserControl(UserControlAddNext);
            BackButton.Visible = true;
        }
        public void changeUserControlInfoToNext()
        {           
            UserControlInfoNext = new ucInfoNext();
            showUserControl(UserControlInfoNext);

            UserControlInfoNext.OutputDeviceCategory2 = UserControlInfo.InputDeviceCategory2;
            UserControlInfoNext.OutputDeviceName2 = UserControlInfo.InputDeviceName2;
            UserControlInfoNext.OutputModellNumber2 = UserControlInfo.InputModellNumber2;
            UserControlInfoNext.OutputSerialNumber2 = UserControlInfo.InputSerialNumber2;
            UserControlInfoNext.OutputMaintenanceDate2 = UserControlInfo.InputMaintenanceDate2;
            UserControlInfoNext.OutputLotNumber2 = UserControlInfo.InputLotNumber2;

            BackButton.Visible = true;
        }

        public void changeUserControlDeleteToNext()
        {
            UserControlDeleteNext = new ucDeleteNext();
            showUserControl(UserControlDeleteNext);

            UserControlDeleteNext.OutputDeviceCategory3 = UserControlDelete.InputDeviceCategory3;
            UserControlDeleteNext.OutputDeviceName3 = UserControlDelete.InputDeviceName3;
            UserControlDeleteNext.OutputModellNumber3 = UserControlDelete.InputModellNumber3;
            UserControlDeleteNext.OutputSerialNumber3 = UserControlDelete.InputSerialNumber3;
            UserControlDeleteNext.OutputMaintenanceDate3 = UserControlDelete.InputMaintenanceDate3;
            UserControlDeleteNext.OutputLotNumber3 = UserControlDelete.InputLotNumber3;

            BackButton.Visible = true;
        }
        
        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (panelContainer.Controls.ContainsKey("ucAddNext"))
            {
                showUserControl(ucAdd1);
                ucAdd1.ConditionallyEnableButton();
            }
            else if (panelContainer.Controls.ContainsKey("ucInfoNext"))
            {
                showUserControl(ucInfo1);
                
            }
            else if (panelContainer.Controls.ContainsKey("ucDeleteNext"))
            {
                showUserControl(ucDelete1);
                
            }
            buttonBack.Visible = false;
        }
        public void showUserControl(Control control)
        {
            panelContainer.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            panelContainer.Controls.Add(control);
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       

      

        
    }
}
