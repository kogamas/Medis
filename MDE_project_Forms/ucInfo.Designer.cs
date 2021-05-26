namespace MDE_project_Forms
{
    partial class ucInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonDeviceName = new System.Windows.Forms.RadioButton();
            this.radioButtonDeviceCategory = new System.Windows.Forms.RadioButton();
            this.radioButtonModellNumber = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonFindInfoList = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonFindInfoDevice = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find Device Information";
            // 
            // radioButtonDeviceName
            // 
            this.radioButtonDeviceName.AutoSize = true;
            this.radioButtonDeviceName.Location = new System.Drawing.Point(162, 208);
            this.radioButtonDeviceName.Name = "radioButtonDeviceName";
            this.radioButtonDeviceName.Size = new System.Drawing.Size(90, 17);
            this.radioButtonDeviceName.TabIndex = 2;
            this.radioButtonDeviceName.TabStop = true;
            this.radioButtonDeviceName.Text = "Device Name";
            this.radioButtonDeviceName.UseVisualStyleBackColor = true;
            // 
            // radioButtonDeviceCategory
            // 
            this.radioButtonDeviceCategory.AutoSize = true;
            this.radioButtonDeviceCategory.Location = new System.Drawing.Point(162, 162);
            this.radioButtonDeviceCategory.Name = "radioButtonDeviceCategory";
            this.radioButtonDeviceCategory.Size = new System.Drawing.Size(104, 17);
            this.radioButtonDeviceCategory.TabIndex = 3;
            this.radioButtonDeviceCategory.TabStop = true;
            this.radioButtonDeviceCategory.Text = "Device Category";
            this.radioButtonDeviceCategory.UseVisualStyleBackColor = true;
            // 
            // radioButtonModellNumber
            // 
            this.radioButtonModellNumber.AutoSize = true;
            this.radioButtonModellNumber.Location = new System.Drawing.Point(162, 185);
            this.radioButtonModellNumber.Name = "radioButtonModellNumber";
            this.radioButtonModellNumber.Size = new System.Drawing.Size(94, 17);
            this.radioButtonModellNumber.TabIndex = 4;
            this.radioButtonModellNumber.TabStop = true;
            this.radioButtonModellNumber.Text = "Model Number";
            this.radioButtonModellNumber.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Choose search criteria\r\n to find devices";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(162, 231);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(133, 20);
            this.textBoxInput.TabIndex = 7;
            // 
            // buttonFindInfoList
            // 
            this.buttonFindInfoList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(179)))), ((int)(((byte)(29)))));
            this.buttonFindInfoList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFindInfoList.Location = new System.Drawing.Point(162, 257);
            this.buttonFindInfoList.Name = "buttonFindInfoList";
            this.buttonFindInfoList.Size = new System.Drawing.Size(133, 33);
            this.buttonFindInfoList.TabIndex = 8;
            this.buttonFindInfoList.Text = "OK";
            this.buttonFindInfoList.UseVisualStyleBackColor = false;
            this.buttonFindInfoList.Click += new System.EventHandler(this.buttonFindInfoList_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(376, 166);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(133, 147);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonFindInfoDevice
            // 
            this.buttonFindInfoDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(179)))), ((int)(((byte)(29)))));
            this.buttonFindInfoDevice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFindInfoDevice.Location = new System.Drawing.Point(376, 319);
            this.buttonFindInfoDevice.Name = "buttonFindInfoDevice";
            this.buttonFindInfoDevice.Size = new System.Drawing.Size(133, 33);
            this.buttonFindInfoDevice.TabIndex = 10;
            this.buttonFindInfoDevice.Text = "Find Device Information";
            this.buttonFindInfoDevice.UseVisualStyleBackColor = false;
            this.buttonFindInfoDevice.Click += new System.EventHandler(this.buttonFindInfoDevice_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(156)))));
            this.panel2.Location = new System.Drawing.Point(72, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(70, 4);
            this.panel2.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(373, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 32);
            this.label3.TabIndex = 38;
            this.label3.Text = "Choose a device to \r\ndisplay information";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ucInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonFindInfoDevice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.radioButtonDeviceCategory);
            this.Controls.Add(this.buttonFindInfoList);
            this.Controls.Add(this.radioButtonDeviceName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.radioButtonModellNumber);
            this.Name = "ucInfo";
            this.Size = new System.Drawing.Size(713, 417);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonDeviceName;
        private System.Windows.Forms.RadioButton radioButtonDeviceCategory;
        private System.Windows.Forms.RadioButton radioButtonModellNumber;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonFindInfoList;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFindInfoDevice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}
