namespace Ekobit.Ekoship.SmartHome.Desktop.Web
{
    partial class FormSmartHomeWeb
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlSmartHome = new TabControl();
            tabPageHome = new TabPage();
            dataGridViewHomes = new DataGridView();
            tabPageDevice = new TabPage();
            dataGridViewDevices = new DataGridView();
            tabPageAddress = new TabPage();
            dataGridViewAddresses = new DataGridView();
            tabPageDeviceType = new TabPage();
            dataGridViewDeviceTypes = new DataGridView();
            tabPageUnit = new TabPage();
            dataGridViewUnits = new DataGridView();
            tabControlSmartHome.SuspendLayout();
            tabPageHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHomes).BeginInit();
            tabPageDevice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDevices).BeginInit();
            tabPageAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAddresses).BeginInit();
            tabPageDeviceType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDeviceTypes).BeginInit();
            tabPageUnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUnits).BeginInit();
            SuspendLayout();
            // 
            // tabControlSmartHome
            // 
            tabControlSmartHome.Controls.Add(tabPageHome);
            tabControlSmartHome.Controls.Add(tabPageDevice);
            tabControlSmartHome.Controls.Add(tabPageAddress);
            tabControlSmartHome.Controls.Add(tabPageDeviceType);
            tabControlSmartHome.Controls.Add(tabPageUnit);
            tabControlSmartHome.Dock = DockStyle.Fill;
            tabControlSmartHome.Location = new Point(0, 0);
            tabControlSmartHome.Name = "tabControlSmartHome";
            tabControlSmartHome.SelectedIndex = 0;
            tabControlSmartHome.Size = new Size(800, 450);
            tabControlSmartHome.TabIndex = 0;
            // 
            // tabPageHome
            // 
            tabPageHome.Controls.Add(dataGridViewHomes);
            tabPageHome.Location = new Point(4, 24);
            tabPageHome.Name = "tabPageHome";
            tabPageHome.Padding = new Padding(3);
            tabPageHome.Size = new Size(792, 422);
            tabPageHome.TabIndex = 0;
            tabPageHome.Text = "Homes";
            tabPageHome.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHomes
            // 
            dataGridViewHomes.AllowUserToAddRows = false;
            dataGridViewHomes.AllowUserToDeleteRows = false;
            dataGridViewHomes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHomes.Dock = DockStyle.Fill;
            dataGridViewHomes.Location = new Point(3, 3);
            dataGridViewHomes.Name = "dataGridViewHomes";
            dataGridViewHomes.ReadOnly = true;
            dataGridViewHomes.RowTemplate.Height = 25;
            dataGridViewHomes.Size = new Size(786, 416);
            dataGridViewHomes.TabIndex = 0;
            // 
            // tabPageDevice
            // 
            tabPageDevice.Controls.Add(dataGridViewDevices);
            tabPageDevice.Location = new Point(4, 24);
            tabPageDevice.Name = "tabPageDevice";
            tabPageDevice.Padding = new Padding(3);
            tabPageDevice.Size = new Size(792, 422);
            tabPageDevice.TabIndex = 1;
            tabPageDevice.Text = "Devices";
            tabPageDevice.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDevices
            // 
            dataGridViewDevices.AllowUserToAddRows = false;
            dataGridViewDevices.AllowUserToDeleteRows = false;
            dataGridViewDevices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDevices.Dock = DockStyle.Fill;
            dataGridViewDevices.Location = new Point(3, 3);
            dataGridViewDevices.Name = "dataGridViewDevices";
            dataGridViewDevices.ReadOnly = true;
            dataGridViewDevices.RowTemplate.Height = 25;
            dataGridViewDevices.Size = new Size(786, 416);
            dataGridViewDevices.TabIndex = 0;
            // 
            // tabPageAddress
            // 
            tabPageAddress.Controls.Add(dataGridViewAddresses);
            tabPageAddress.Location = new Point(4, 24);
            tabPageAddress.Name = "tabPageAddress";
            tabPageAddress.Padding = new Padding(3);
            tabPageAddress.Size = new Size(792, 422);
            tabPageAddress.TabIndex = 2;
            tabPageAddress.Text = "Addresses";
            tabPageAddress.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAddresses
            // 
            dataGridViewAddresses.AllowUserToAddRows = false;
            dataGridViewAddresses.AllowUserToDeleteRows = false;
            dataGridViewAddresses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAddresses.Dock = DockStyle.Fill;
            dataGridViewAddresses.Location = new Point(3, 3);
            dataGridViewAddresses.Name = "dataGridViewAddresses";
            dataGridViewAddresses.ReadOnly = true;
            dataGridViewAddresses.RowTemplate.Height = 25;
            dataGridViewAddresses.Size = new Size(786, 416);
            dataGridViewAddresses.TabIndex = 0;
            // 
            // tabPageDeviceType
            // 
            tabPageDeviceType.Controls.Add(dataGridViewDeviceTypes);
            tabPageDeviceType.Location = new Point(4, 24);
            tabPageDeviceType.Name = "tabPageDeviceType";
            tabPageDeviceType.Padding = new Padding(3);
            tabPageDeviceType.Size = new Size(792, 422);
            tabPageDeviceType.TabIndex = 3;
            tabPageDeviceType.Text = "Device Types";
            tabPageDeviceType.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDeviceTypes
            // 
            dataGridViewDeviceTypes.AllowUserToAddRows = false;
            dataGridViewDeviceTypes.AllowUserToDeleteRows = false;
            dataGridViewDeviceTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDeviceTypes.Dock = DockStyle.Fill;
            dataGridViewDeviceTypes.Location = new Point(3, 3);
            dataGridViewDeviceTypes.Name = "dataGridViewDeviceTypes";
            dataGridViewDeviceTypes.ReadOnly = true;
            dataGridViewDeviceTypes.RowTemplate.Height = 25;
            dataGridViewDeviceTypes.Size = new Size(786, 416);
            dataGridViewDeviceTypes.TabIndex = 0;
            // 
            // tabPageUnit
            // 
            tabPageUnit.Controls.Add(dataGridViewUnits);
            tabPageUnit.Location = new Point(4, 24);
            tabPageUnit.Name = "tabPageUnit";
            tabPageUnit.Padding = new Padding(3);
            tabPageUnit.Size = new Size(792, 422);
            tabPageUnit.TabIndex = 4;
            tabPageUnit.Text = "Units";
            tabPageUnit.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUnits
            // 
            dataGridViewUnits.AllowUserToAddRows = false;
            dataGridViewUnits.AllowUserToDeleteRows = false;
            dataGridViewUnits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUnits.Dock = DockStyle.Fill;
            dataGridViewUnits.Location = new Point(3, 3);
            dataGridViewUnits.Name = "dataGridViewUnits";
            dataGridViewUnits.ReadOnly = true;
            dataGridViewUnits.RowTemplate.Height = 25;
            dataGridViewUnits.Size = new Size(786, 416);
            dataGridViewUnits.TabIndex = 0;
            // 
            // FormSmartHomeWeb
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlSmartHome);
            Name = "FormSmartHomeWeb";
            Text = "Smart Home Web";
            tabControlSmartHome.ResumeLayout(false);
            tabPageHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewHomes).EndInit();
            tabPageDevice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDevices).EndInit();
            tabPageAddress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAddresses).EndInit();
            tabPageDeviceType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDeviceTypes).EndInit();
            tabPageUnit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUnits).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlSmartHome;
        private TabPage tabPageHome;
        private TabPage tabPageDevice;
        private TabPage tabPageAddress;
        private TabPage tabPageDeviceType;
        private TabPage tabPageUnit;
        private DataGridView dataGridViewHomes;
        private DataGridView dataGridViewDevices;
        private DataGridView dataGridViewAddresses;
        private DataGridView dataGridViewDeviceTypes;
        private DataGridView dataGridViewUnits;
    }
}