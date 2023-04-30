namespace Ekobit.Ekoship.SmartHome.Desktop
{
    partial class FormSmartHome
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
            tabControlMain = new TabControl();
            tabPageHome = new TabPage();
            tabPageDevice = new TabPage();
            tabPageAddress = new TabPage();
            tabPageDeviceType = new TabPage();
            tabPageUnit = new TabPage();
            dataGridViewUnits = new DataGridView();
            dataGridViewDeviceTypes = new DataGridView();
            dataGridViewAddresses = new DataGridView();
            dataGridViewDevices = new DataGridView();
            dataGridViewHomes = new DataGridView();
            tabControlMain.SuspendLayout();
            tabPageHome.SuspendLayout();
            tabPageDevice.SuspendLayout();
            tabPageAddress.SuspendLayout();
            tabPageDeviceType.SuspendLayout();
            tabPageUnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUnits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDeviceTypes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAddresses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDevices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHomes).BeginInit();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageHome);
            tabControlMain.Controls.Add(tabPageDevice);
            tabControlMain.Controls.Add(tabPageAddress);
            tabControlMain.Controls.Add(tabPageDeviceType);
            tabControlMain.Controls.Add(tabPageUnit);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(800, 447);
            tabControlMain.TabIndex = 0;
            // 
            // tabPageHome
            // 
            tabPageHome.Controls.Add(dataGridViewHomes);
            tabPageHome.Location = new Point(4, 24);
            tabPageHome.Name = "tabPageHome";
            tabPageHome.Padding = new Padding(3);
            tabPageHome.Size = new Size(792, 419);
            tabPageHome.TabIndex = 0;
            tabPageHome.Text = "Homes";
            tabPageHome.UseVisualStyleBackColor = true;
            // 
            // tabPageDevice
            // 
            tabPageDevice.Controls.Add(dataGridViewDevices);
            tabPageDevice.Location = new Point(4, 24);
            tabPageDevice.Name = "tabPageDevice";
            tabPageDevice.Padding = new Padding(3);
            tabPageDevice.Size = new Size(792, 419);
            tabPageDevice.TabIndex = 1;
            tabPageDevice.Text = "Devices";
            tabPageDevice.UseVisualStyleBackColor = true;
            // 
            // tabPageAddress
            // 
            tabPageAddress.Controls.Add(dataGridViewAddresses);
            tabPageAddress.Location = new Point(4, 24);
            tabPageAddress.Name = "tabPageAddress";
            tabPageAddress.Padding = new Padding(3);
            tabPageAddress.Size = new Size(792, 419);
            tabPageAddress.TabIndex = 2;
            tabPageAddress.Text = "Addresses";
            tabPageAddress.UseVisualStyleBackColor = true;
            // 
            // tabPageDeviceType
            // 
            tabPageDeviceType.Controls.Add(dataGridViewDeviceTypes);
            tabPageDeviceType.Location = new Point(4, 24);
            tabPageDeviceType.Name = "tabPageDeviceType";
            tabPageDeviceType.Padding = new Padding(3);
            tabPageDeviceType.Size = new Size(792, 419);
            tabPageDeviceType.TabIndex = 3;
            tabPageDeviceType.Text = "Device Types";
            tabPageDeviceType.UseVisualStyleBackColor = true;
            // 
            // tabPageUnit
            // 
            tabPageUnit.Controls.Add(dataGridViewUnits);
            tabPageUnit.Location = new Point(4, 24);
            tabPageUnit.Name = "tabPageUnit";
            tabPageUnit.Padding = new Padding(3);
            tabPageUnit.Size = new Size(792, 419);
            tabPageUnit.TabIndex = 4;
            tabPageUnit.Text = "Units";
            tabPageUnit.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUnits
            // 
            dataGridViewUnits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUnits.Dock = DockStyle.Fill;
            dataGridViewUnits.Location = new Point(3, 3);
            dataGridViewUnits.Name = "dataGridViewUnits";
            dataGridViewUnits.RowTemplate.Height = 25;
            dataGridViewUnits.Size = new Size(786, 413);
            dataGridViewUnits.TabIndex = 0;
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
            dataGridViewDeviceTypes.Size = new Size(786, 413);
            dataGridViewDeviceTypes.TabIndex = 0;
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
            dataGridViewAddresses.Size = new Size(786, 413);
            dataGridViewAddresses.TabIndex = 0;
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
            dataGridViewDevices.Size = new Size(786, 413);
            dataGridViewDevices.TabIndex = 0;
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
            dataGridViewHomes.Size = new Size(786, 413);
            dataGridViewHomes.TabIndex = 0;
            // 
            // FormSmartHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 447);
            Controls.Add(tabControlMain);
            Name = "FormSmartHome";
            Text = "Smart Home";
            tabControlMain.ResumeLayout(false);
            tabPageHome.ResumeLayout(false);
            tabPageDevice.ResumeLayout(false);
            tabPageAddress.ResumeLayout(false);
            tabPageDeviceType.ResumeLayout(false);
            tabPageUnit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUnits).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDeviceTypes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAddresses).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDevices).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHomes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPageHome;
        private TabPage tabPageDevice;
        private TabPage tabPageAddress;
        private TabPage tabPageDeviceType;
        private TabPage tabPageUnit;
        private DataGridView dataGridViewUnits;
        private DataGridView dataGridViewDeviceTypes;
        private DataGridView dataGridViewDevices;
        private DataGridView dataGridViewAddresses;
        private DataGridView dataGridViewHomes;
    }
}