namespace MDE_project_Forms
{
    partial class ucAdd
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAddNewDevice = new System.Windows.Forms.Label();
            this.inputDeviceName = new System.Windows.Forms.TextBox();
            this.inputModellNumber = new System.Windows.Forms.TextBox();
            this.inputSerialNumber = new System.Windows.Forms.TextBox();
            this.inputDeviceCategory = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDeviceName = new System.Windows.Forms.Label();
            this.labelModellNumber = new System.Windows.Forms.Label();
            this.labelSerialNumber = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelDeviceCategory = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.inputMaintenanceYear = new System.Windows.Forms.TextBox();
            this.inputMaintenanceMonth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.inputMaintenanceDay = new System.Windows.Forms.TextBox();
            this.inputLotNumber = new System.Windows.Forms.TextBox();
            this.labelLotNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAddNewDevice
            // 
            this.labelAddNewDevice.AutoSize = true;
            this.labelAddNewDevice.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddNewDevice.Location = new System.Drawing.Point(67, 46);
            this.labelAddNewDevice.Name = "labelAddNewDevice";
            this.labelAddNewDevice.Size = new System.Drawing.Size(201, 27);
            this.labelAddNewDevice.TabIndex = 0;
            this.labelAddNewDevice.Text = "Add new Device:";
            // 
            // inputDeviceName
            // 
            this.inputDeviceName.Location = new System.Drawing.Point(161, 154);
            this.inputDeviceName.Name = "inputDeviceName";
            this.inputDeviceName.Size = new System.Drawing.Size(121, 20);
            this.inputDeviceName.TabIndex = 1;
            this.inputDeviceName.TextChanged += new System.EventHandler(this.inputDeviceName_TextChanged);
            // 
            // inputModellNumber
            // 
            this.inputModellNumber.Location = new System.Drawing.Point(161, 179);
            this.inputModellNumber.Name = "inputModellNumber";
            this.inputModellNumber.Size = new System.Drawing.Size(121, 20);
            this.inputModellNumber.TabIndex = 2;
            this.inputModellNumber.TextChanged += new System.EventHandler(this.inputModellNumber_TextChanged);
            // 
            // inputSerialNumber
            // 
            this.inputSerialNumber.Location = new System.Drawing.Point(161, 204);
            this.inputSerialNumber.Name = "inputSerialNumber";
            this.inputSerialNumber.Size = new System.Drawing.Size(121, 20);
            this.inputSerialNumber.TabIndex = 3;
            this.inputSerialNumber.TextChanged += new System.EventHandler(this.inputSerialNumber_TextChanged);
            // 
            // inputDeviceCategory
            // 
            this.inputDeviceCategory.FormattingEnabled = true;
            this.inputDeviceCategory.Items.AddRange(new object[] {
            "Thermometer",
            "Pulsoximeter",
            "Infusionpump",
            "Patientmonitor"});
            this.inputDeviceCategory.Location = new System.Drawing.Point(161, 129);
            this.inputDeviceCategory.Name = "inputDeviceCategory";
            this.inputDeviceCategory.Size = new System.Drawing.Size(121, 21);
            this.inputDeviceCategory.TabIndex = 14;
            this.inputDeviceCategory.Tag = "";
            this.inputDeviceCategory.SelectedIndexChanged += new System.EventHandler(this.inputDeviceCategory_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(156)))));
            this.panel2.Location = new System.Drawing.Point(72, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(70, 4);
            this.panel2.TabIndex = 36;
            // 
            // labelDeviceName
            // 
            this.labelDeviceName.AutoSize = true;
            this.labelDeviceName.BackColor = System.Drawing.Color.Transparent;
            this.labelDeviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeviceName.Location = new System.Drawing.Point(48, 155);
            this.labelDeviceName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDeviceName.Name = "labelDeviceName";
            this.labelDeviceName.Size = new System.Drawing.Size(91, 16);
            this.labelDeviceName.TabIndex = 30;
            this.labelDeviceName.Text = "Device Name";
            // 
            // labelModellNumber
            // 
            this.labelModellNumber.AutoSize = true;
            this.labelModellNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelModellNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModellNumber.Location = new System.Drawing.Point(42, 180);
            this.labelModellNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelModellNumber.Name = "labelModellNumber";
            this.labelModellNumber.Size = new System.Drawing.Size(97, 16);
            this.labelModellNumber.TabIndex = 31;
            this.labelModellNumber.Text = "Model Number";
            // 
            // labelSerialNumber
            // 
            this.labelSerialNumber.AutoSize = true;
            this.labelSerialNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSerialNumber.Location = new System.Drawing.Point(45, 205);
            this.labelSerialNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSerialNumber.Name = "labelSerialNumber";
            this.labelSerialNumber.Size = new System.Drawing.Size(94, 16);
            this.labelSerialNumber.TabIndex = 32;
            this.labelSerialNumber.Text = "Serial Number";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(179)))), ((int)(((byte)(29)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(444, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 20);
            this.button1.TabIndex = 15;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelDeviceCategory
            // 
            this.labelDeviceCategory.AutoSize = true;
            this.labelDeviceCategory.BackColor = System.Drawing.Color.Transparent;
            this.labelDeviceCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeviceCategory.Location = new System.Drawing.Point(30, 130);
            this.labelDeviceCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDeviceCategory.Name = "labelDeviceCategory";
            this.labelDeviceCategory.Size = new System.Drawing.Size(109, 16);
            this.labelDeviceCategory.TabIndex = 34;
            this.labelDeviceCategory.Text = "Device Category";
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.BackColor = System.Drawing.Color.Transparent;
            this.labelMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonth.Location = new System.Drawing.Point(355, 158);
            this.labelMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(77, 16);
            this.labelMonth.TabIndex = 48;
            this.labelMonth.Text = "Month (MM)";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.BackColor = System.Drawing.Color.Transparent;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYear.Location = new System.Drawing.Point(348, 183);
            this.labelYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(84, 16);
            this.labelYear.TabIndex = 47;
            this.labelYear.Text = "Year (YYYY)";
            // 
            // inputMaintenanceYear
            // 
            this.inputMaintenanceYear.Location = new System.Drawing.Point(444, 180);
            this.inputMaintenanceYear.Name = "inputMaintenanceYear";
            this.inputMaintenanceYear.Size = new System.Drawing.Size(121, 20);
            this.inputMaintenanceYear.TabIndex = 46;
            // 
            // inputMaintenanceMonth
            // 
            this.inputMaintenanceMonth.Location = new System.Drawing.Point(444, 155);
            this.inputMaintenanceMonth.Name = "inputMaintenanceMonth";
            this.inputMaintenanceMonth.Size = new System.Drawing.Size(121, 20);
            this.inputMaintenanceMonth.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Maintenance Date";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.BackColor = System.Drawing.Color.Transparent;
            this.labelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay.Location = new System.Drawing.Point(368, 131);
            this.labelDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(64, 16);
            this.labelDay.TabIndex = 43;
            this.labelDay.Text = "Day (DD)";
            // 
            // inputMaintenanceDay
            // 
            this.inputMaintenanceDay.Location = new System.Drawing.Point(444, 130);
            this.inputMaintenanceDay.Name = "inputMaintenanceDay";
            this.inputMaintenanceDay.Size = new System.Drawing.Size(121, 20);
            this.inputMaintenanceDay.TabIndex = 42;
            // 
            // inputLotNumber
            // 
            this.inputLotNumber.Location = new System.Drawing.Point(161, 230);
            this.inputLotNumber.Name = "inputLotNumber";
            this.inputLotNumber.Size = new System.Drawing.Size(121, 20);
            this.inputLotNumber.TabIndex = 50;
            this.inputLotNumber.TextChanged += new System.EventHandler(this.inputLotNumber_TextChanged);
            // 
            // labelLotNumber
            // 
            this.labelLotNumber.AutoSize = true;
            this.labelLotNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelLotNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLotNumber.Location = new System.Drawing.Point(62, 230);
            this.labelLotNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLotNumber.Name = "labelLotNumber";
            this.labelLotNumber.Size = new System.Drawing.Size(77, 16);
            this.labelLotNumber.TabIndex = 49;
            this.labelLotNumber.Text = "Lot Number";
            // 
            // ucAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.inputLotNumber);
            this.Controls.Add(this.labelLotNumber);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.inputMaintenanceYear);
            this.Controls.Add(this.inputMaintenanceMonth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.inputMaintenanceDay);
            this.Controls.Add(this.labelDeviceCategory);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelDeviceName);
            this.Controls.Add(this.labelModellNumber);
            this.Controls.Add(this.labelSerialNumber);
            this.Controls.Add(this.inputDeviceCategory);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelAddNewDevice);
            this.Controls.Add(this.inputSerialNumber);
            this.Controls.Add(this.inputModellNumber);
            this.Controls.Add(this.inputDeviceName);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ucAdd";
            this.Size = new System.Drawing.Size(713, 417);
            this.Load += new System.EventHandler(this.ucAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddNewDevice;
        private System.Windows.Forms.TextBox inputDeviceName;
        private System.Windows.Forms.TextBox inputModellNumber;
        private System.Windows.Forms.TextBox inputSerialNumber;
        private System.Windows.Forms.ComboBox inputDeviceCategory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelDeviceName;
        private System.Windows.Forms.Label labelModellNumber;
        private System.Windows.Forms.Label labelSerialNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelDeviceCategory;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox inputMaintenanceYear;
        private System.Windows.Forms.TextBox inputMaintenanceMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.TextBox inputMaintenanceDay;
        private System.Windows.Forms.TextBox inputLotNumber;
        private System.Windows.Forms.Label labelLotNumber;
    }
}
