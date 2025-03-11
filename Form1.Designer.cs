namespace TopUpTool
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LblIP = new System.Windows.Forms.Label();
            this.LblUSERNAME = new System.Windows.Forms.Label();
            this.LblDBNAME = new System.Windows.Forms.Label();
            this.TxtBIP = new System.Windows.Forms.TextBox();
            this.TxtBDBNAME = new System.Windows.Forms.TextBox();
            this.TxtBUSERNAME = new System.Windows.Forms.TextBox();
            this.TxtBPASSWORD = new System.Windows.Forms.TextBox();
            this.LblPASSWORD = new System.Windows.Forms.Label();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnTopup = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.BtnTopup2 = new System.Windows.Forms.Button();
            this.LLbl1 = new System.Windows.Forms.LinkLabel();
            this.TxtBAccDB = new System.Windows.Forms.TextBox();
            this.LblACCDB = new System.Windows.Forms.Label();
            this.TxtBTOPUP270 = new System.Windows.Forms.TextBox();
            this.LblTOPUP270Amount = new System.Windows.Forms.Label();
            this.TxtBTOPUO1380 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblLoadingPercentage = new System.Windows.Forms.Label();
            this.LblTotalEP270 = new System.Windows.Forms.Label();
            this.LblTotalEP1380 = new System.Windows.Forms.Label();
            this.BtnDisconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblIP
            // 
            this.LblIP.AutoSize = true;
            this.LblIP.Location = new System.Drawing.Point(59, 13);
            this.LblIP.Name = "LblIP";
            this.LblIP.Size = new System.Drawing.Size(20, 13);
            this.LblIP.TabIndex = 0;
            this.LblIP.Text = "IP:";
            // 
            // LblUSERNAME
            // 
            this.LblUSERNAME.AutoSize = true;
            this.LblUSERNAME.Location = new System.Drawing.Point(13, 49);
            this.LblUSERNAME.Name = "LblUSERNAME";
            this.LblUSERNAME.Size = new System.Drawing.Size(71, 13);
            this.LblUSERNAME.TabIndex = 2;
            this.LblUSERNAME.Text = "USERNAME:";
            // 
            // LblDBNAME
            // 
            this.LblDBNAME.AutoSize = true;
            this.LblDBNAME.Location = new System.Drawing.Point(214, 13);
            this.LblDBNAME.Name = "LblDBNAME";
            this.LblDBNAME.Size = new System.Drawing.Size(56, 13);
            this.LblDBNAME.TabIndex = 3;
            this.LblDBNAME.Text = "DBNAME:";
            // 
            // TxtBIP
            // 
            this.TxtBIP.Location = new System.Drawing.Point(85, 10);
            this.TxtBIP.Name = "TxtBIP";
            this.TxtBIP.Size = new System.Drawing.Size(114, 20);
            this.TxtBIP.TabIndex = 2;
            // 
            // TxtBDBNAME
            // 
            this.TxtBDBNAME.Location = new System.Drawing.Point(273, 10);
            this.TxtBDBNAME.Name = "TxtBDBNAME";
            this.TxtBDBNAME.Size = new System.Drawing.Size(114, 20);
            this.TxtBDBNAME.TabIndex = 4;
            // 
            // TxtBUSERNAME
            // 
            this.TxtBUSERNAME.Location = new System.Drawing.Point(85, 46);
            this.TxtBUSERNAME.Name = "TxtBUSERNAME";
            this.TxtBUSERNAME.Size = new System.Drawing.Size(114, 20);
            this.TxtBUSERNAME.TabIndex = 6;
            // 
            // TxtBPASSWORD
            // 
            this.TxtBPASSWORD.Location = new System.Drawing.Point(85, 80);
            this.TxtBPASSWORD.Name = "TxtBPASSWORD";
            this.TxtBPASSWORD.Size = new System.Drawing.Size(114, 20);
            this.TxtBPASSWORD.TabIndex = 10;
            // 
            // LblPASSWORD
            // 
            this.LblPASSWORD.AutoSize = true;
            this.LblPASSWORD.Location = new System.Drawing.Point(13, 83);
            this.LblPASSWORD.Name = "LblPASSWORD";
            this.LblPASSWORD.Size = new System.Drawing.Size(73, 13);
            this.LblPASSWORD.TabIndex = 8;
            this.LblPASSWORD.Text = "PASSWORD:";
            // 
            // BtnConnect
            // 
            this.BtnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConnect.ImageIndex = 0;
            this.BtnConnect.ImageList = this.imageList1;
            this.BtnConnect.Location = new System.Drawing.Point(393, 10);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(208, 59);
            this.BtnConnect.TabIndex = 11;
            this.BtnConnect.Text = "CONNECT";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "9004756_wireless_wifi_internet_connection_icon.png");
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(393, 157);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(208, 23);
            this.ProgressBar.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select a user:";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(85, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // BtnTopup
            // 
            this.BtnTopup.Enabled = false;
            this.BtnTopup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTopup.ImageIndex = 0;
            this.BtnTopup.ImageList = this.imageList2;
            this.BtnTopup.Location = new System.Drawing.Point(16, 150);
            this.BtnTopup.Name = "BtnTopup";
            this.BtnTopup.Size = new System.Drawing.Size(118, 30);
            this.BtnTopup.TabIndex = 14;
            this.BtnTopup.Text = "TOP UP 270";
            this.BtnTopup.UseVisualStyleBackColor = true;
            this.BtnTopup.Click += new System.EventHandler(this.BtnTopup_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "n99aeegjgv4cvdnm9tr54119eh-acc82c58625790c96e3f6582a2fc5634.png");
            this.imageList2.Images.SetKeyName(1, "SeekPng.com_pile-of-coins-png_2898717.png");
            // 
            // BtnTopup2
            // 
            this.BtnTopup2.Enabled = false;
            this.BtnTopup2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTopup2.ImageIndex = 1;
            this.BtnTopup2.ImageList = this.imageList2;
            this.BtnTopup2.Location = new System.Drawing.Point(16, 186);
            this.BtnTopup2.Name = "BtnTopup2";
            this.BtnTopup2.Size = new System.Drawing.Size(118, 30);
            this.BtnTopup2.TabIndex = 15;
            this.BtnTopup2.Text = "TOP UP 1380";
            this.BtnTopup2.UseVisualStyleBackColor = true;
            this.BtnTopup2.Click += new System.EventHandler(this.BtnTopup2_Click);
            // 
            // LLbl1
            // 
            this.LLbl1.AutoSize = true;
            this.LLbl1.Location = new System.Drawing.Point(514, 203);
            this.LLbl1.Name = "LLbl1";
            this.LLbl1.Size = new System.Drawing.Size(87, 13);
            this.LLbl1.TabIndex = 16;
            this.LLbl1.TabStop = true;
            this.LLbl1.Text = "Created by MW2";
            this.LLbl1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLbl1_LinkClicked);
            // 
            // TxtBAccDB
            // 
            this.TxtBAccDB.Location = new System.Drawing.Point(273, 42);
            this.TxtBAccDB.Name = "TxtBAccDB";
            this.TxtBAccDB.Size = new System.Drawing.Size(114, 20);
            this.TxtBAccDB.TabIndex = 8;
            // 
            // LblACCDB
            // 
            this.LblACCDB.AutoSize = true;
            this.LblACCDB.Location = new System.Drawing.Point(221, 46);
            this.LblACCDB.Name = "LblACCDB";
            this.LblACCDB.Size = new System.Drawing.Size(46, 13);
            this.LblACCDB.TabIndex = 17;
            this.LblACCDB.Text = "ACCDB:";
            // 
            // TxtBTOPUP270
            // 
            this.TxtBTOPUP270.Location = new System.Drawing.Point(194, 156);
            this.TxtBTOPUP270.MaxLength = 2;
            this.TxtBTOPUP270.Name = "TxtBTOPUP270";
            this.TxtBTOPUP270.Size = new System.Drawing.Size(21, 20);
            this.TxtBTOPUP270.TabIndex = 20;
            this.TxtBTOPUP270.Text = "1";
            this.TxtBTOPUP270.TextChanged += new System.EventHandler(this.TxtBTOPUP270_TextChanged);
            this.TxtBTOPUP270.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly);
            // 
            // LblTOPUP270Amount
            // 
            this.LblTOPUP270Amount.AutoSize = true;
            this.LblTOPUP270Amount.Location = new System.Drawing.Point(146, 160);
            this.LblTOPUP270Amount.Name = "LblTOPUP270Amount";
            this.LblTOPUP270Amount.Size = new System.Drawing.Size(46, 13);
            this.LblTOPUP270Amount.TabIndex = 19;
            this.LblTOPUP270Amount.Text = "Amount:";
            // 
            // TxtBTOPUO1380
            // 
            this.TxtBTOPUO1380.Location = new System.Drawing.Point(194, 192);
            this.TxtBTOPUO1380.MaxLength = 2;
            this.TxtBTOPUO1380.Name = "TxtBTOPUO1380";
            this.TxtBTOPUO1380.Size = new System.Drawing.Size(21, 20);
            this.TxtBTOPUO1380.TabIndex = 22;
            this.TxtBTOPUO1380.Text = "1";
            this.TxtBTOPUO1380.TextChanged += new System.EventHandler(this.TxtBTOPUO1380_TextChanged);
            this.TxtBTOPUO1380.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Amount:";
            // 
            // LblLoadingPercentage
            // 
            this.LblLoadingPercentage.AutoSize = true;
            this.LblLoadingPercentage.BackColor = System.Drawing.Color.Transparent;
            this.LblLoadingPercentage.Location = new System.Drawing.Point(397, 141);
            this.LblLoadingPercentage.Name = "LblLoadingPercentage";
            this.LblLoadingPercentage.Size = new System.Drawing.Size(112, 13);
            this.LblLoadingPercentage.TabIndex = 23;
            this.LblLoadingPercentage.Text = "Database Loaded: 0%";
            // 
            // LblTotalEP270
            // 
            this.LblTotalEP270.AutoSize = true;
            this.LblTotalEP270.ForeColor = System.Drawing.Color.Red;
            this.LblTotalEP270.Location = new System.Drawing.Point(221, 160);
            this.LblTotalEP270.Name = "LblTotalEP270";
            this.LblTotalEP270.Size = new System.Drawing.Size(79, 13);
            this.LblTotalEP270.TabIndex = 24;
            this.LblTotalEP270.Text = "Total: 270 EPS";
            // 
            // LblTotalEP1380
            // 
            this.LblTotalEP1380.AutoSize = true;
            this.LblTotalEP1380.ForeColor = System.Drawing.Color.Red;
            this.LblTotalEP1380.Location = new System.Drawing.Point(221, 196);
            this.LblTotalEP1380.Name = "LblTotalEP1380";
            this.LblTotalEP1380.Size = new System.Drawing.Size(85, 13);
            this.LblTotalEP1380.TabIndex = 25;
            this.LblTotalEP1380.Text = "Total: 1380 EPS";
            // 
            // BtnDisconnect
            // 
            this.BtnDisconnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDisconnect.ImageIndex = 0;
            this.BtnDisconnect.ImageList = this.imageList1;
            this.BtnDisconnect.Location = new System.Drawing.Point(393, 72);
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.Size = new System.Drawing.Size(208, 59);
            this.BtnDisconnect.TabIndex = 26;
            this.BtnDisconnect.Text = "DISCONNECT";
            this.BtnDisconnect.UseVisualStyleBackColor = true;
            this.BtnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 234);
            this.Controls.Add(this.BtnDisconnect);
            this.Controls.Add(this.LblTotalEP1380);
            this.Controls.Add(this.LblTotalEP270);
            this.Controls.Add(this.LblLoadingPercentage);
            this.Controls.Add(this.TxtBTOPUO1380);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBTOPUP270);
            this.Controls.Add(this.LblTOPUP270Amount);
            this.Controls.Add(this.TxtBAccDB);
            this.Controls.Add(this.LblACCDB);
            this.Controls.Add(this.LLbl1);
            this.Controls.Add(this.BtnTopup2);
            this.Controls.Add(this.BtnTopup);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.TxtBPASSWORD);
            this.Controls.Add(this.LblPASSWORD);
            this.Controls.Add(this.TxtBUSERNAME);
            this.Controls.Add(this.TxtBDBNAME);
            this.Controls.Add(this.TxtBIP);
            this.Controls.Add(this.LblDBNAME);
            this.Controls.Add(this.LblUSERNAME);
            this.Controls.Add(this.LblIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Top up tool by MW2 (old DB)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblIP;
        private System.Windows.Forms.Label LblUSERNAME;
        private System.Windows.Forms.Label LblDBNAME;
        private System.Windows.Forms.TextBox TxtBIP;
        private System.Windows.Forms.TextBox TxtBDBNAME;
        private System.Windows.Forms.TextBox TxtBUSERNAME;
        private System.Windows.Forms.TextBox TxtBPASSWORD;
        private System.Windows.Forms.Label LblPASSWORD;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BtnTopup;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button BtnTopup2;
        private System.Windows.Forms.LinkLabel LLbl1;
        private System.Windows.Forms.TextBox TxtBAccDB;
        private System.Windows.Forms.Label LblACCDB;
        private System.Windows.Forms.TextBox TxtBTOPUP270;
        private System.Windows.Forms.Label LblTOPUP270Amount;
        private System.Windows.Forms.TextBox TxtBTOPUO1380;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblLoadingPercentage;
        private System.Windows.Forms.Label LblTotalEP270;
        private System.Windows.Forms.Label LblTotalEP1380;
        private System.Windows.Forms.Button BtnDisconnect;
    }
}

