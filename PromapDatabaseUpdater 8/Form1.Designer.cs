namespace PromapDatabaseUpdater_8
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ECUsList = new System.Windows.Forms.DataGridView();
            this.HardwareCode_txt = new System.Windows.Forms.TextBox();
            this.HardwareCode_lbl = new System.Windows.Forms.Label();
            this.Comment_txt = new System.Windows.Forms.TextBox();
            this.Comment_lbl = new System.Windows.Forms.Label();
            this.UserID_txt = new System.Windows.Forms.TextBox();
            this.UserID_lbl = new System.Windows.Forms.Label();
            this.ProductNumber_txt = new System.Windows.Forms.TextBox();
            this.ProductNumber_lbl = new System.Windows.Forms.Label();
            this.ConnectionID_txt = new System.Windows.Forms.TextBox();
            this.ConnectionID_lbl = new System.Windows.Forms.Label();
            this.Type1_AddressRemap_txt = new System.Windows.Forms.TextBox();
            this.Type1_AddressRemap_lbl = new System.Windows.Forms.Label();
            this.Type2_TableRemap_txt = new System.Windows.Forms.TextBox();
            this.Type2_TableRemap_lbl = new System.Windows.Forms.Label();
            this.CRC_Address_txt = new System.Windows.Forms.TextBox();
            this.CRC_Address_lbl = new System.Windows.Forms.Label();
            this.type2Cryption_txt = new System.Windows.Forms.TextBox();
            this.type2Cryption_lbl = new System.Windows.Forms.Label();
            this.binCryption_txt = new System.Windows.Forms.TextBox();
            this.binCryption_lbl = new System.Windows.Forms.Label();
            this.crcCryption_txt = new System.Windows.Forms.TextBox();
            this.crcCryption_lbl = new System.Windows.Forms.Label();
            this.type1Cryption_txt = new System.Windows.Forms.TextBox();
            this.type1Cryption_lbl = new System.Windows.Forms.Label();
            this.Calibration_txt = new System.Windows.Forms.TextBox();
            this.Calibration_lbl = new System.Windows.Forms.Label();
            this.BinFileName_txt = new System.Windows.Forms.TextBox();
            this.BinFileName_lbl = new System.Windows.Forms.Label();
            this.BaudRate_txt = new System.Windows.Forms.TextBox();
            this.BaudRate_lbl = new System.Windows.Forms.Label();
            this.SoftRef_txt = new System.Windows.Forms.TextBox();
            this.SoftRef_lbl = new System.Windows.Forms.Label();
            this.DeviceName_txt = new System.Windows.Forms.TextBox();
            this.DeviceName_lbl = new System.Windows.Forms.Label();
            this.Type_txt = new System.Windows.Forms.TextBox();
            this.Type_lbl = new System.Windows.Forms.Label();
            this.BootRef_txt = new System.Windows.Forms.TextBox();
            this.BootRef_lbl = new System.Windows.Forms.Label();
            this.Manufacturer_txt = new System.Windows.Forms.TextBox();
            this.Manufacturer_lbl = new System.Windows.Forms.Label();
            this.AddECU_btn = new System.Windows.Forms.Button();
            this.EditECU_btn = new System.Windows.Forms.Button();
            this.DeleteECU_btn = new System.Windows.Forms.Button();
            this.ID_txt = new System.Windows.Forms.TextBox();
            this.ID_lbl = new System.Windows.Forms.Label();
            this.ShowTable_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ECUsList)).BeginInit();
            this.SuspendLayout();
            // 
            // ECUsList
            // 
            this.ECUsList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(168)))), ((int)(((byte)(169)))));
            this.ECUsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ECUsList.Location = new System.Drawing.Point(12, 8);
            this.ECUsList.Name = "ECUsList";
            this.ECUsList.Size = new System.Drawing.Size(1028, 332);
            this.ECUsList.TabIndex = 0;
            this.ECUsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ecusListCellClick);
            // 
            // HardwareCode_txt
            // 
            this.HardwareCode_txt.Location = new System.Drawing.Point(463, 541);
            this.HardwareCode_txt.Name = "HardwareCode_txt";
            this.HardwareCode_txt.Size = new System.Drawing.Size(175, 20);
            this.HardwareCode_txt.TabIndex = 116;
            // 
            // HardwareCode_lbl
            // 
            this.HardwareCode_lbl.AutoSize = true;
            this.HardwareCode_lbl.Location = new System.Drawing.Point(332, 544);
            this.HardwareCode_lbl.Name = "HardwareCode_lbl";
            this.HardwareCode_lbl.Size = new System.Drawing.Size(78, 13);
            this.HardwareCode_lbl.TabIndex = 115;
            this.HardwareCode_lbl.Text = "HardwareCode";
            // 
            // Comment_txt
            // 
            this.Comment_txt.Location = new System.Drawing.Point(463, 567);
            this.Comment_txt.Name = "Comment_txt";
            this.Comment_txt.Size = new System.Drawing.Size(175, 20);
            this.Comment_txt.TabIndex = 114;
            // 
            // Comment_lbl
            // 
            this.Comment_lbl.AutoSize = true;
            this.Comment_lbl.Location = new System.Drawing.Point(332, 570);
            this.Comment_lbl.Name = "Comment_lbl";
            this.Comment_lbl.Size = new System.Drawing.Size(51, 13);
            this.Comment_lbl.TabIndex = 113;
            this.Comment_lbl.Text = "Comment";
            // 
            // UserID_txt
            // 
            this.UserID_txt.Location = new System.Drawing.Point(463, 593);
            this.UserID_txt.Name = "UserID_txt";
            this.UserID_txt.Size = new System.Drawing.Size(175, 20);
            this.UserID_txt.TabIndex = 112;
            // 
            // UserID_lbl
            // 
            this.UserID_lbl.AutoSize = true;
            this.UserID_lbl.Location = new System.Drawing.Point(332, 596);
            this.UserID_lbl.Name = "UserID_lbl";
            this.UserID_lbl.Size = new System.Drawing.Size(40, 13);
            this.UserID_lbl.TabIndex = 111;
            this.UserID_lbl.Text = "UserID";
            // 
            // ProductNumber_txt
            // 
            this.ProductNumber_txt.Location = new System.Drawing.Point(463, 515);
            this.ProductNumber_txt.Name = "ProductNumber_txt";
            this.ProductNumber_txt.Size = new System.Drawing.Size(175, 20);
            this.ProductNumber_txt.TabIndex = 110;
            // 
            // ProductNumber_lbl
            // 
            this.ProductNumber_lbl.AutoSize = true;
            this.ProductNumber_lbl.Location = new System.Drawing.Point(332, 518);
            this.ProductNumber_lbl.Name = "ProductNumber_lbl";
            this.ProductNumber_lbl.Size = new System.Drawing.Size(81, 13);
            this.ProductNumber_lbl.TabIndex = 109;
            this.ProductNumber_lbl.Text = "ProductNumber";
            // 
            // ConnectionID_txt
            // 
            this.ConnectionID_txt.Location = new System.Drawing.Point(463, 437);
            this.ConnectionID_txt.Name = "ConnectionID_txt";
            this.ConnectionID_txt.Size = new System.Drawing.Size(175, 20);
            this.ConnectionID_txt.TabIndex = 108;
            // 
            // ConnectionID_lbl
            // 
            this.ConnectionID_lbl.AutoSize = true;
            this.ConnectionID_lbl.Location = new System.Drawing.Point(332, 440);
            this.ConnectionID_lbl.Name = "ConnectionID_lbl";
            this.ConnectionID_lbl.Size = new System.Drawing.Size(72, 13);
            this.ConnectionID_lbl.TabIndex = 107;
            this.ConnectionID_lbl.Text = "ConnectionID";
            // 
            // Type1_AddressRemap_txt
            // 
            this.Type1_AddressRemap_txt.Location = new System.Drawing.Point(463, 463);
            this.Type1_AddressRemap_txt.Name = "Type1_AddressRemap_txt";
            this.Type1_AddressRemap_txt.Size = new System.Drawing.Size(175, 20);
            this.Type1_AddressRemap_txt.TabIndex = 106;
            // 
            // Type1_AddressRemap_lbl
            // 
            this.Type1_AddressRemap_lbl.AutoSize = true;
            this.Type1_AddressRemap_lbl.Location = new System.Drawing.Point(332, 466);
            this.Type1_AddressRemap_lbl.Name = "Type1_AddressRemap_lbl";
            this.Type1_AddressRemap_lbl.Size = new System.Drawing.Size(115, 13);
            this.Type1_AddressRemap_lbl.TabIndex = 105;
            this.Type1_AddressRemap_lbl.Text = "Type1_AddressRemap";
            // 
            // Type2_TableRemap_txt
            // 
            this.Type2_TableRemap_txt.Location = new System.Drawing.Point(463, 492);
            this.Type2_TableRemap_txt.Name = "Type2_TableRemap_txt";
            this.Type2_TableRemap_txt.Size = new System.Drawing.Size(175, 20);
            this.Type2_TableRemap_txt.TabIndex = 104;
            // 
            // Type2_TableRemap_lbl
            // 
            this.Type2_TableRemap_lbl.AutoSize = true;
            this.Type2_TableRemap_lbl.Location = new System.Drawing.Point(332, 492);
            this.Type2_TableRemap_lbl.Name = "Type2_TableRemap_lbl";
            this.Type2_TableRemap_lbl.Size = new System.Drawing.Size(104, 13);
            this.Type2_TableRemap_lbl.TabIndex = 103;
            this.Type2_TableRemap_lbl.Text = "Type2_TableRemap";
            // 
            // CRC_Address_txt
            // 
            this.CRC_Address_txt.Location = new System.Drawing.Point(463, 411);
            this.CRC_Address_txt.Name = "CRC_Address_txt";
            this.CRC_Address_txt.Size = new System.Drawing.Size(175, 20);
            this.CRC_Address_txt.TabIndex = 102;
            // 
            // CRC_Address_lbl
            // 
            this.CRC_Address_lbl.AutoSize = true;
            this.CRC_Address_lbl.Location = new System.Drawing.Point(332, 414);
            this.CRC_Address_lbl.Name = "CRC_Address_lbl";
            this.CRC_Address_lbl.Size = new System.Drawing.Size(73, 13);
            this.CRC_Address_lbl.TabIndex = 101;
            this.CRC_Address_lbl.Text = "CRC_Address";
            // 
            // type2Cryption_txt
            // 
            this.type2Cryption_txt.Location = new System.Drawing.Point(791, 437);
            this.type2Cryption_txt.Name = "type2Cryption_txt";
            this.type2Cryption_txt.Size = new System.Drawing.Size(175, 20);
            this.type2Cryption_txt.TabIndex = 100;
            // 
            // type2Cryption_lbl
            // 
            this.type2Cryption_lbl.AutoSize = true;
            this.type2Cryption_lbl.Location = new System.Drawing.Point(660, 440);
            this.type2Cryption_lbl.Name = "type2Cryption_lbl";
            this.type2Cryption_lbl.Size = new System.Drawing.Size(71, 13);
            this.type2Cryption_lbl.TabIndex = 99;
            this.type2Cryption_lbl.Text = "type2Cryption";
            // 
            // binCryption_txt
            // 
            this.binCryption_txt.Location = new System.Drawing.Point(791, 463);
            this.binCryption_txt.Name = "binCryption_txt";
            this.binCryption_txt.Size = new System.Drawing.Size(175, 20);
            this.binCryption_txt.TabIndex = 98;
            // 
            // binCryption_lbl
            // 
            this.binCryption_lbl.AutoSize = true;
            this.binCryption_lbl.Location = new System.Drawing.Point(660, 466);
            this.binCryption_lbl.Name = "binCryption_lbl";
            this.binCryption_lbl.Size = new System.Drawing.Size(59, 13);
            this.binCryption_lbl.TabIndex = 97;
            this.binCryption_lbl.Text = "binCryption";
            // 
            // crcCryption_txt
            // 
            this.crcCryption_txt.Location = new System.Drawing.Point(791, 489);
            this.crcCryption_txt.Name = "crcCryption_txt";
            this.crcCryption_txt.Size = new System.Drawing.Size(175, 20);
            this.crcCryption_txt.TabIndex = 96;
            // 
            // crcCryption_lbl
            // 
            this.crcCryption_lbl.AutoSize = true;
            this.crcCryption_lbl.Location = new System.Drawing.Point(660, 492);
            this.crcCryption_lbl.Name = "crcCryption_lbl";
            this.crcCryption_lbl.Size = new System.Drawing.Size(60, 13);
            this.crcCryption_lbl.TabIndex = 95;
            this.crcCryption_lbl.Text = "crcCryption";
            // 
            // type1Cryption_txt
            // 
            this.type1Cryption_txt.Location = new System.Drawing.Point(791, 411);
            this.type1Cryption_txt.Name = "type1Cryption_txt";
            this.type1Cryption_txt.Size = new System.Drawing.Size(175, 20);
            this.type1Cryption_txt.TabIndex = 94;
            // 
            // type1Cryption_lbl
            // 
            this.type1Cryption_lbl.AutoSize = true;
            this.type1Cryption_lbl.Location = new System.Drawing.Point(660, 414);
            this.type1Cryption_lbl.Name = "type1Cryption_lbl";
            this.type1Cryption_lbl.Size = new System.Drawing.Size(71, 13);
            this.type1Cryption_lbl.TabIndex = 93;
            this.type1Cryption_lbl.Text = "type1Cryption";
            // 
            // Calibration_txt
            // 
            this.Calibration_txt.Location = new System.Drawing.Point(139, 541);
            this.Calibration_txt.Name = "Calibration_txt";
            this.Calibration_txt.Size = new System.Drawing.Size(175, 20);
            this.Calibration_txt.TabIndex = 92;
            // 
            // Calibration_lbl
            // 
            this.Calibration_lbl.AutoSize = true;
            this.Calibration_lbl.Location = new System.Drawing.Point(8, 544);
            this.Calibration_lbl.Name = "Calibration_lbl";
            this.Calibration_lbl.Size = new System.Drawing.Size(56, 13);
            this.Calibration_lbl.TabIndex = 91;
            this.Calibration_lbl.Text = "Calibration";
            // 
            // BinFileName_txt
            // 
            this.BinFileName_txt.Location = new System.Drawing.Point(139, 567);
            this.BinFileName_txt.Name = "BinFileName_txt";
            this.BinFileName_txt.Size = new System.Drawing.Size(175, 20);
            this.BinFileName_txt.TabIndex = 90;
            // 
            // BinFileName_lbl
            // 
            this.BinFileName_lbl.AutoSize = true;
            this.BinFileName_lbl.Location = new System.Drawing.Point(8, 570);
            this.BinFileName_lbl.Name = "BinFileName_lbl";
            this.BinFileName_lbl.Size = new System.Drawing.Size(66, 13);
            this.BinFileName_lbl.TabIndex = 89;
            this.BinFileName_lbl.Text = "BinFileName";
            // 
            // BaudRate_txt
            // 
            this.BaudRate_txt.Location = new System.Drawing.Point(139, 593);
            this.BaudRate_txt.Name = "BaudRate_txt";
            this.BaudRate_txt.Size = new System.Drawing.Size(175, 20);
            this.BaudRate_txt.TabIndex = 88;
            // 
            // BaudRate_lbl
            // 
            this.BaudRate_lbl.AutoSize = true;
            this.BaudRate_lbl.Location = new System.Drawing.Point(8, 596);
            this.BaudRate_lbl.Name = "BaudRate_lbl";
            this.BaudRate_lbl.Size = new System.Drawing.Size(55, 13);
            this.BaudRate_lbl.TabIndex = 87;
            this.BaudRate_lbl.Text = "BaudRate";
            // 
            // SoftRef_txt
            // 
            this.SoftRef_txt.Location = new System.Drawing.Point(139, 515);
            this.SoftRef_txt.Name = "SoftRef_txt";
            this.SoftRef_txt.Size = new System.Drawing.Size(175, 20);
            this.SoftRef_txt.TabIndex = 86;
            // 
            // SoftRef_lbl
            // 
            this.SoftRef_lbl.AutoSize = true;
            this.SoftRef_lbl.Location = new System.Drawing.Point(8, 518);
            this.SoftRef_lbl.Name = "SoftRef_lbl";
            this.SoftRef_lbl.Size = new System.Drawing.Size(43, 13);
            this.SoftRef_lbl.TabIndex = 85;
            this.SoftRef_lbl.Text = "SoftRef";
            // 
            // DeviceName_txt
            // 
            this.DeviceName_txt.Location = new System.Drawing.Point(139, 437);
            this.DeviceName_txt.Name = "DeviceName_txt";
            this.DeviceName_txt.Size = new System.Drawing.Size(175, 20);
            this.DeviceName_txt.TabIndex = 84;
            // 
            // DeviceName_lbl
            // 
            this.DeviceName_lbl.AutoSize = true;
            this.DeviceName_lbl.Location = new System.Drawing.Point(8, 440);
            this.DeviceName_lbl.Name = "DeviceName_lbl";
            this.DeviceName_lbl.Size = new System.Drawing.Size(69, 13);
            this.DeviceName_lbl.TabIndex = 83;
            this.DeviceName_lbl.Text = "DeviceName";
            // 
            // Type_txt
            // 
            this.Type_txt.Location = new System.Drawing.Point(139, 463);
            this.Type_txt.Name = "Type_txt";
            this.Type_txt.Size = new System.Drawing.Size(175, 20);
            this.Type_txt.TabIndex = 82;
            // 
            // Type_lbl
            // 
            this.Type_lbl.AutoSize = true;
            this.Type_lbl.Location = new System.Drawing.Point(8, 466);
            this.Type_lbl.Name = "Type_lbl";
            this.Type_lbl.Size = new System.Drawing.Size(31, 13);
            this.Type_lbl.TabIndex = 81;
            this.Type_lbl.Text = "Type";
            // 
            // BootRef_txt
            // 
            this.BootRef_txt.Location = new System.Drawing.Point(139, 489);
            this.BootRef_txt.Name = "BootRef_txt";
            this.BootRef_txt.Size = new System.Drawing.Size(175, 20);
            this.BootRef_txt.TabIndex = 80;
            // 
            // BootRef_lbl
            // 
            this.BootRef_lbl.AutoSize = true;
            this.BootRef_lbl.Location = new System.Drawing.Point(8, 492);
            this.BootRef_lbl.Name = "BootRef_lbl";
            this.BootRef_lbl.Size = new System.Drawing.Size(46, 13);
            this.BootRef_lbl.TabIndex = 79;
            this.BootRef_lbl.Text = "BootRef";
            // 
            // Manufacturer_txt
            // 
            this.Manufacturer_txt.Location = new System.Drawing.Point(139, 411);
            this.Manufacturer_txt.Name = "Manufacturer_txt";
            this.Manufacturer_txt.Size = new System.Drawing.Size(175, 20);
            this.Manufacturer_txt.TabIndex = 78;
            // 
            // Manufacturer_lbl
            // 
            this.Manufacturer_lbl.AutoSize = true;
            this.Manufacturer_lbl.Location = new System.Drawing.Point(8, 414);
            this.Manufacturer_lbl.Name = "Manufacturer_lbl";
            this.Manufacturer_lbl.Size = new System.Drawing.Size(70, 13);
            this.Manufacturer_lbl.TabIndex = 77;
            this.Manufacturer_lbl.Text = "Manufacturer";
            // 
            // AddECU_btn
            // 
            this.AddECU_btn.BackColor = System.Drawing.Color.Teal;
            this.AddECU_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AddECU_btn.ForeColor = System.Drawing.Color.Black;
            this.AddECU_btn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddECU_btn.Location = new System.Drawing.Point(791, 521);
            this.AddECU_btn.Name = "AddECU_btn";
            this.AddECU_btn.Size = new System.Drawing.Size(175, 36);
            this.AddECU_btn.TabIndex = 117;
            this.AddECU_btn.Text = "Add ECU";
            this.AddECU_btn.UseVisualStyleBackColor = false;
            this.AddECU_btn.Click += new System.EventHandler(this.addEcuBtnClick);
            // 
            // EditECU_btn
            // 
            this.EditECU_btn.BackColor = System.Drawing.Color.Yellow;
            this.EditECU_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.EditECU_btn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EditECU_btn.Location = new System.Drawing.Point(791, 563);
            this.EditECU_btn.Name = "EditECU_btn";
            this.EditECU_btn.Size = new System.Drawing.Size(175, 36);
            this.EditECU_btn.TabIndex = 118;
            this.EditECU_btn.Text = "Edit ECU";
            this.EditECU_btn.UseVisualStyleBackColor = false;
            this.EditECU_btn.Click += new System.EventHandler(this.editEcuBtnClick);
            // 
            // DeleteECU_btn
            // 
            this.DeleteECU_btn.BackColor = System.Drawing.Color.Red;
            this.DeleteECU_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DeleteECU_btn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DeleteECU_btn.Location = new System.Drawing.Point(791, 605);
            this.DeleteECU_btn.Name = "DeleteECU_btn";
            this.DeleteECU_btn.Size = new System.Drawing.Size(175, 36);
            this.DeleteECU_btn.TabIndex = 119;
            this.DeleteECU_btn.Text = "Delete ECU";
            this.DeleteECU_btn.UseVisualStyleBackColor = false;
            this.DeleteECU_btn.Click += new System.EventHandler(this.deleteEcuBtnClick);
            // 
            // ID_txt
            // 
            this.ID_txt.Location = new System.Drawing.Point(44, 364);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.Size = new System.Drawing.Size(78, 20);
            this.ID_txt.TabIndex = 121;
            // 
            // ID_lbl
            // 
            this.ID_lbl.AutoSize = true;
            this.ID_lbl.Location = new System.Drawing.Point(8, 367);
            this.ID_lbl.Name = "ID_lbl";
            this.ID_lbl.Size = new System.Drawing.Size(18, 13);
            this.ID_lbl.TabIndex = 120;
            this.ID_lbl.Text = "ID";
            // 
            // ShowTable_btn
            // 
            this.ShowTable_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(168)))), ((int)(((byte)(169)))));
            this.ShowTable_btn.Location = new System.Drawing.Point(408, 354);
            this.ShowTable_btn.Name = "ShowTable_btn";
            this.ShowTable_btn.Size = new System.Drawing.Size(117, 38);
            this.ShowTable_btn.TabIndex = 122;
            this.ShowTable_btn.Text = "ShowTable";
            this.ShowTable_btn.UseVisualStyleBackColor = false;
            this.ShowTable_btn.Click += new System.EventHandler(this.showTableBtnClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 648);
            this.Controls.Add(this.ShowTable_btn);
            this.Controls.Add(this.ID_txt);
            this.Controls.Add(this.ID_lbl);
            this.Controls.Add(this.DeleteECU_btn);
            this.Controls.Add(this.EditECU_btn);
            this.Controls.Add(this.AddECU_btn);
            this.Controls.Add(this.HardwareCode_txt);
            this.Controls.Add(this.HardwareCode_lbl);
            this.Controls.Add(this.Comment_txt);
            this.Controls.Add(this.Comment_lbl);
            this.Controls.Add(this.UserID_txt);
            this.Controls.Add(this.UserID_lbl);
            this.Controls.Add(this.ProductNumber_txt);
            this.Controls.Add(this.ProductNumber_lbl);
            this.Controls.Add(this.ConnectionID_txt);
            this.Controls.Add(this.ConnectionID_lbl);
            this.Controls.Add(this.Type1_AddressRemap_txt);
            this.Controls.Add(this.Type1_AddressRemap_lbl);
            this.Controls.Add(this.Type2_TableRemap_txt);
            this.Controls.Add(this.Type2_TableRemap_lbl);
            this.Controls.Add(this.CRC_Address_txt);
            this.Controls.Add(this.CRC_Address_lbl);
            this.Controls.Add(this.type2Cryption_txt);
            this.Controls.Add(this.type2Cryption_lbl);
            this.Controls.Add(this.binCryption_txt);
            this.Controls.Add(this.binCryption_lbl);
            this.Controls.Add(this.crcCryption_txt);
            this.Controls.Add(this.crcCryption_lbl);
            this.Controls.Add(this.type1Cryption_txt);
            this.Controls.Add(this.type1Cryption_lbl);
            this.Controls.Add(this.Calibration_txt);
            this.Controls.Add(this.Calibration_lbl);
            this.Controls.Add(this.BinFileName_txt);
            this.Controls.Add(this.BinFileName_lbl);
            this.Controls.Add(this.BaudRate_txt);
            this.Controls.Add(this.BaudRate_lbl);
            this.Controls.Add(this.SoftRef_txt);
            this.Controls.Add(this.SoftRef_lbl);
            this.Controls.Add(this.DeviceName_txt);
            this.Controls.Add(this.DeviceName_lbl);
            this.Controls.Add(this.Type_txt);
            this.Controls.Add(this.Type_lbl);
            this.Controls.Add(this.BootRef_txt);
            this.Controls.Add(this.BootRef_lbl);
            this.Controls.Add(this.Manufacturer_txt);
            this.Controls.Add(this.Manufacturer_lbl);
            this.Controls.Add(this.ECUsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ECUsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ECUsList;
        private System.Windows.Forms.Label type2Cryption_lbl;
        private System.Windows.Forms.TextBox HardwareCode_txt;
        private System.Windows.Forms.Label HardwareCode_lbl;
        private System.Windows.Forms.TextBox Comment_txt;
        private System.Windows.Forms.Label Comment_lbl;
        private System.Windows.Forms.TextBox UserID_txt;
        private System.Windows.Forms.Label UserID_lbl;
        private System.Windows.Forms.TextBox ProductNumber_txt;
        private System.Windows.Forms.Label ProductNumber_lbl;
        private System.Windows.Forms.TextBox ConnectionID_txt;
        private System.Windows.Forms.Label ConnectionID_lbl;
        private System.Windows.Forms.TextBox Type1_AddressRemap_txt;
        private System.Windows.Forms.Label Type1_AddressRemap_lbl;
        private System.Windows.Forms.TextBox Type2_TableRemap_txt;
        private System.Windows.Forms.Label Type2_TableRemap_lbl;
        private System.Windows.Forms.TextBox CRC_Address_txt;
        private System.Windows.Forms.Label CRC_Address_lbl;
        private System.Windows.Forms.TextBox type2Cryption_txt;
        private System.Windows.Forms.TextBox binCryption_txt;
        private System.Windows.Forms.Label binCryption_lbl;
        private System.Windows.Forms.TextBox crcCryption_txt;
        private System.Windows.Forms.Label crcCryption_lbl;
        private System.Windows.Forms.TextBox type1Cryption_txt;
        private System.Windows.Forms.Label type1Cryption_lbl;
        private System.Windows.Forms.TextBox Calibration_txt;
        private System.Windows.Forms.Label Calibration_lbl;
        private System.Windows.Forms.TextBox BinFileName_txt;
        private System.Windows.Forms.Label BinFileName_lbl;
        private System.Windows.Forms.TextBox BaudRate_txt;
        private System.Windows.Forms.Label BaudRate_lbl;
        private System.Windows.Forms.TextBox SoftRef_txt;
        private System.Windows.Forms.Label SoftRef_lbl;
        private System.Windows.Forms.TextBox DeviceName_txt;
        private System.Windows.Forms.Label DeviceName_lbl;
        private System.Windows.Forms.TextBox Type_txt;
        private System.Windows.Forms.Label Type_lbl;
        private System.Windows.Forms.TextBox BootRef_txt;
        private System.Windows.Forms.Label BootRef_lbl;
        private System.Windows.Forms.TextBox Manufacturer_txt;
        private System.Windows.Forms.Label Manufacturer_lbl;
        private System.Windows.Forms.Button AddECU_btn;
        private System.Windows.Forms.Button EditECU_btn;
        private System.Windows.Forms.Button DeleteECU_btn;
        private System.Windows.Forms.TextBox ID_txt;
        private System.Windows.Forms.Label ID_lbl;
        private System.Windows.Forms.Button ShowTable_btn;
    }
}

