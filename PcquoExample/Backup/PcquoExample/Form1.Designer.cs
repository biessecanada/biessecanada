namespace PcquoExample
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtHostName = new System.Windows.Forms.TextBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.btSendRowDstn = new System.Windows.Forms.Button();
            this.txtLbl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPiece = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProg2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btSendProg = new System.Windows.Forms.Button();
            this.txtComm = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrg = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dllPath = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.textDstnName = new System.Windows.Forms.TextBox();
            this.textInfoDstnResult = new System.Windows.Forms.TextBox();
            this.textDstnInfoRow = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.textSetPosRow = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textSetPosResult = new System.Windows.Forms.TextBox();
            this.btSetPosDstn = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.textStartDstn = new System.Windows.Forms.TextBox();
            this.btStartDstn = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.textMacInRun = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textDstnActive = new System.Windows.Forms.TextBox();
            this.textDstnSt = new System.Windows.Forms.TextBox();
            this.textAuto = new System.Windows.Forms.TextBox();
            this.btDstnSt = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.RowCountGet = new System.Windows.Forms.TextBox();
            this.RowQtyGet = new System.Windows.Forms.TextBox();
            this.InfoRowGet = new System.Windows.Forms.TextBox();
            this.RowNumberGet = new System.Windows.Forms.TextBox();
            this.btGetInfoRiga = new System.Windows.Forms.Button();
            this.labelCountRow = new System.Windows.Forms.Label();
            this.labelQtyRow = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textCountRow = new System.Windows.Forms.TextBox();
            this.textQtyRow = new System.Windows.Forms.TextBox();
            this.textSetRowResult = new System.Windows.Forms.TextBox();
            this.textNRow = new System.Windows.Forms.TextBox();
            this.buttonSetRow = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textDelRowResult = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textNumRow = new System.Windows.Forms.TextBox();
            this.buttonDelRow = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host name or Ip address";
            // 
            // txtHostName
            // 
            this.txtHostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHostName.Location = new System.Drawing.Point(247, 82);
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Size = new System.Drawing.Size(201, 22);
            this.txtHostName.TabIndex = 1;
            // 
            // btConnect
            // 
            this.btConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConnect.Location = new System.Drawing.Point(20, 133);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(184, 23);
            this.btConnect.TabIndex = 2;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(300, 20);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(126, 20);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Not connected";
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(264, 133);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(184, 23);
            this.btClose.TabIndex = 4;
            this.btClose.Text = "CloseConnection";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btSendRowDstn
            // 
            this.btSendRowDstn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSendRowDstn.Location = new System.Drawing.Point(34, 272);
            this.btSendRowDstn.Name = "btSendRowDstn";
            this.btSendRowDstn.Size = new System.Drawing.Size(184, 23);
            this.btSendRowDstn.TabIndex = 7;
            this.btSendRowDstn.Text = "SendRowDstn";
            this.btSendRowDstn.UseVisualStyleBackColor = true;
            this.btSendRowDstn.Click += new System.EventHandler(this.btSendRowDstn_Click);
            // 
            // txtLbl
            // 
            this.txtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLbl.Location = new System.Drawing.Point(247, 37);
            this.txtLbl.Name = "txtLbl";
            this.txtLbl.Size = new System.Drawing.Size(185, 22);
            this.txtLbl.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Label to send";
            // 
            // txtProg
            // 
            this.txtProg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProg.Location = new System.Drawing.Point(247, 72);
            this.txtProg.Name = "txtProg";
            this.txtProg.Size = new System.Drawing.Size(185, 22);
            this.txtProg.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Program to send";
            // 
            // txtQt
            // 
            this.txtQt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQt.Location = new System.Drawing.Point(247, 145);
            this.txtQt.Name = "txtQt";
            this.txtQt.Size = new System.Drawing.Size(185, 22);
            this.txtQt.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantity to send";
            // 
            // txtPiece
            // 
            this.txtPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPiece.Location = new System.Drawing.Point(247, 182);
            this.txtPiece.Name = "txtPiece";
            this.txtPiece.Size = new System.Drawing.Size(185, 22);
            this.txtPiece.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Piece counter to send";
            // 
            // txtComment
            // 
            this.txtComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.Location = new System.Drawing.Point(247, 225);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(185, 22);
            this.txtComment.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Comment to send";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtProg2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btSendRowDstn);
            this.groupBox1.Controls.Add(this.txtComment);
            this.groupBox1.Controls.Add(this.txtLbl);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPiece);
            this.groupBox1.Controls.Add(this.txtProg);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtQt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 316);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SenRowDstn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(277, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = " 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Program 2 to send";
            // 
            // txtProg2
            // 
            this.txtProg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProg2.Location = new System.Drawing.Point(247, 109);
            this.txtProg2.Name = "txtProg2";
            this.txtProg2.Size = new System.Drawing.Size(185, 22);
            this.txtProg2.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtHostName);
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.btClose);
            this.groupBox2.Controls.Add(this.btConnect);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 182);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btSendProg);
            this.groupBox3.Controls.Add(this.txtComm);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtPrg);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 337);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(454, 316);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SenProgDstn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(267, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = " 0";
            // 
            // btSendProg
            // 
            this.btSendProg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSendProg.Location = new System.Drawing.Point(34, 241);
            this.btSendProg.Name = "btSendProg";
            this.btSendProg.Size = new System.Drawing.Size(184, 23);
            this.btSendProg.TabIndex = 7;
            this.btSendProg.Text = "SendProgDstn";
            this.btSendProg.UseVisualStyleBackColor = true;
            this.btSendProg.Click += new System.EventHandler(this.btSendProg_Click);
            // 
            // txtComm
            // 
            this.txtComm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComm.Location = new System.Drawing.Point(247, 194);
            this.txtComm.Name = "txtComm";
            this.txtComm.Size = new System.Drawing.Size(185, 22);
            this.txtComm.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Comment to send";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Program to send";
            // 
            // txtPrg
            // 
            this.txtPrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrg.Location = new System.Drawing.Point(247, 72);
            this.txtPrg.Name = "txtPrg";
            this.txtPrg.Size = new System.Drawing.Size(185, 22);
            this.txtPrg.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(466, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(552, 229);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // dllPath
            // 
            this.dllPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dllPath.AutoSize = true;
            this.dllPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dllPath.ForeColor = System.Drawing.Color.Green;
            this.dllPath.Location = new System.Drawing.Point(3, 222);
            this.dllPath.Name = "dllPath";
            this.dllPath.Size = new System.Drawing.Size(81, 20);
            this.dllPath.TabIndex = 20;
            this.dllPath.Text = "Dll found";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(503, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "The PcQuoDll must be in the same directory of the application";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1029, 641);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.dllPath);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1021, 615);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connection";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1021, 615);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Send Program";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.label28);
            this.tabPage3.Controls.Add(this.label29);
            this.tabPage3.Controls.Add(this.label30);
            this.tabPage3.Controls.Add(this.textDstnName);
            this.tabPage3.Controls.Add(this.textInfoDstnResult);
            this.tabPage3.Controls.Add(this.textDstnInfoRow);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label27);
            this.tabPage3.Controls.Add(this.textSetPosRow);
            this.tabPage3.Controls.Add(this.label26);
            this.tabPage3.Controls.Add(this.textSetPosResult);
            this.tabPage3.Controls.Add(this.btSetPosDstn);
            this.tabPage3.Controls.Add(this.label25);
            this.tabPage3.Controls.Add(this.textStartDstn);
            this.tabPage3.Controls.Add(this.btStartDstn);
            this.tabPage3.Controls.Add(this.label24);
            this.tabPage3.Controls.Add(this.textMacInRun);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.textDstnActive);
            this.tabPage3.Controls.Add(this.textDstnSt);
            this.tabPage3.Controls.Add(this.textAuto);
            this.tabPage3.Controls.Add(this.btDstnSt);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.RowCountGet);
            this.tabPage3.Controls.Add(this.RowQtyGet);
            this.tabPage3.Controls.Add(this.InfoRowGet);
            this.tabPage3.Controls.Add(this.RowNumberGet);
            this.tabPage3.Controls.Add(this.btGetInfoRiga);
            this.tabPage3.Controls.Add(this.labelCountRow);
            this.tabPage3.Controls.Add(this.labelQtyRow);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.textCountRow);
            this.tabPage3.Controls.Add(this.textQtyRow);
            this.tabPage3.Controls.Add(this.textSetRowResult);
            this.tabPage3.Controls.Add(this.textNRow);
            this.tabPage3.Controls.Add(this.buttonSetRow);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.textDelRowResult);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.textNumRow);
            this.tabPage3.Controls.Add(this.buttonDelRow);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1021, 615);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Various";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(345, 474);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(98, 20);
            this.label28.TabIndex = 57;
            this.label28.Text = "Dstn Name";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(571, 474);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(136, 20);
            this.label29.TabIndex = 56;
            this.label29.Text = "Function Result";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(221, 474);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(111, 20);
            this.label30.TabIndex = 55;
            this.label30.Text = "Row Number";
            // 
            // textDstnName
            // 
            this.textDstnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDstnName.Location = new System.Drawing.Point(349, 498);
            this.textDstnName.Name = "textDstnName";
            this.textDstnName.Size = new System.Drawing.Size(220, 22);
            this.textDstnName.TabIndex = 54;
            // 
            // textInfoDstnResult
            // 
            this.textInfoDstnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInfoDstnResult.Location = new System.Drawing.Point(575, 497);
            this.textInfoDstnResult.Name = "textInfoDstnResult";
            this.textInfoDstnResult.Size = new System.Drawing.Size(284, 22);
            this.textInfoDstnResult.TabIndex = 53;
            // 
            // textDstnInfoRow
            // 
            this.textDstnInfoRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDstnInfoRow.Location = new System.Drawing.Point(225, 497);
            this.textDstnInfoRow.Name = "textDstnInfoRow";
            this.textDstnInfoRow.Size = new System.Drawing.Size(107, 22);
            this.textDstnInfoRow.TabIndex = 52;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 23);
            this.button1.TabIndex = 51;
            this.button1.Text = "GetInfoDstn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(218, 398);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(111, 20);
            this.label27.TabIndex = 50;
            this.label27.Text = "Row Number";
            // 
            // textSetPosRow
            // 
            this.textSetPosRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSetPosRow.Location = new System.Drawing.Point(222, 421);
            this.textSetPosRow.Name = "textSetPosRow";
            this.textSetPosRow.Size = new System.Drawing.Size(107, 22);
            this.textSetPosRow.TabIndex = 49;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(568, 398);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(136, 20);
            this.label26.TabIndex = 48;
            this.label26.Text = "Function Result";
            // 
            // textSetPosResult
            // 
            this.textSetPosResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSetPosResult.Location = new System.Drawing.Point(572, 421);
            this.textSetPosResult.Name = "textSetPosResult";
            this.textSetPosResult.Size = new System.Drawing.Size(284, 22);
            this.textSetPosResult.TabIndex = 47;
            // 
            // btSetPosDstn
            // 
            this.btSetPosDstn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSetPosDstn.Location = new System.Drawing.Point(6, 421);
            this.btSetPosDstn.Name = "btSetPosDstn";
            this.btSetPosDstn.Size = new System.Drawing.Size(184, 23);
            this.btSetPosDstn.TabIndex = 46;
            this.btSetPosDstn.Text = "SetPosDstn";
            this.btSetPosDstn.UseVisualStyleBackColor = true;
            this.btSetPosDstn.Click += new System.EventHandler(this.btSetPosDstn_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(568, 324);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(136, 20);
            this.label25.TabIndex = 45;
            this.label25.Text = "Function Result";
            // 
            // textStartDstn
            // 
            this.textStartDstn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStartDstn.Location = new System.Drawing.Point(572, 347);
            this.textStartDstn.Name = "textStartDstn";
            this.textStartDstn.Size = new System.Drawing.Size(284, 22);
            this.textStartDstn.TabIndex = 44;
            // 
            // btStartDstn
            // 
            this.btStartDstn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStartDstn.Location = new System.Drawing.Point(6, 347);
            this.btStartDstn.Name = "btStartDstn";
            this.btStartDstn.Size = new System.Drawing.Size(184, 23);
            this.btStartDstn.TabIndex = 43;
            this.btStartDstn.Text = "StartDstn";
            this.btStartDstn.UseVisualStyleBackColor = true;
            this.btStartDstn.Click += new System.EventHandler(this.btStartDstn_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(458, 246);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(104, 20);
            this.label24.TabIndex = 42;
            this.label24.Text = "Mac. in Run";
            // 
            // textMacInRun
            // 
            this.textMacInRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMacInRun.Location = new System.Drawing.Point(462, 269);
            this.textMacInRun.Name = "textMacInRun";
            this.textMacInRun.Size = new System.Drawing.Size(107, 22);
            this.textMacInRun.TabIndex = 41;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(342, 245);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(96, 20);
            this.label21.TabIndex = 40;
            this.label21.Text = "DstnActive";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(568, 245);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(136, 20);
            this.label22.TabIndex = 39;
            this.label22.Text = "Function Result";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(218, 245);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(90, 20);
            this.label23.TabIndex = 38;
            this.label23.Text = "Automatic";
            // 
            // textDstnActive
            // 
            this.textDstnActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDstnActive.Location = new System.Drawing.Point(349, 269);
            this.textDstnActive.Name = "textDstnActive";
            this.textDstnActive.Size = new System.Drawing.Size(107, 22);
            this.textDstnActive.TabIndex = 37;
            // 
            // textDstnSt
            // 
            this.textDstnSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDstnSt.Location = new System.Drawing.Point(575, 268);
            this.textDstnSt.Name = "textDstnSt";
            this.textDstnSt.Size = new System.Drawing.Size(284, 22);
            this.textDstnSt.TabIndex = 36;
            // 
            // textAuto
            // 
            this.textAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAuto.Location = new System.Drawing.Point(225, 268);
            this.textAuto.Name = "textAuto";
            this.textAuto.Size = new System.Drawing.Size(107, 22);
            this.textAuto.TabIndex = 35;
            // 
            // btDstnSt
            // 
            this.btDstnSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDstnSt.Location = new System.Drawing.Point(6, 268);
            this.btDstnSt.Name = "btDstnSt";
            this.btDstnSt.Size = new System.Drawing.Size(184, 23);
            this.btDstnSt.TabIndex = 34;
            this.btDstnSt.Text = "GetDstnState";
            this.btDstnSt.UseVisualStyleBackColor = true;
            this.btDstnSt.Click += new System.EventHandler(this.btDstnSt_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(455, 167);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 20);
            this.label17.TabIndex = 33;
            this.label17.Text = "Counter";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(342, 167);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 20);
            this.label18.TabIndex = 32;
            this.label18.Text = "Quantity";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(568, 167);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(136, 20);
            this.label19.TabIndex = 31;
            this.label19.Text = "Function Result";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(218, 167);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(111, 20);
            this.label20.TabIndex = 30;
            this.label20.Text = "Row Number";
            // 
            // RowCountGet
            // 
            this.RowCountGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RowCountGet.Location = new System.Drawing.Point(459, 190);
            this.RowCountGet.Name = "RowCountGet";
            this.RowCountGet.Size = new System.Drawing.Size(107, 22);
            this.RowCountGet.TabIndex = 29;
            // 
            // RowQtyGet
            // 
            this.RowQtyGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RowQtyGet.Location = new System.Drawing.Point(346, 191);
            this.RowQtyGet.Name = "RowQtyGet";
            this.RowQtyGet.Size = new System.Drawing.Size(107, 22);
            this.RowQtyGet.TabIndex = 28;
            // 
            // InfoRowGet
            // 
            this.InfoRowGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoRowGet.Location = new System.Drawing.Point(572, 190);
            this.InfoRowGet.Name = "InfoRowGet";
            this.InfoRowGet.Size = new System.Drawing.Size(284, 22);
            this.InfoRowGet.TabIndex = 27;
            // 
            // RowNumberGet
            // 
            this.RowNumberGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RowNumberGet.Location = new System.Drawing.Point(222, 190);
            this.RowNumberGet.Name = "RowNumberGet";
            this.RowNumberGet.Size = new System.Drawing.Size(107, 22);
            this.RowNumberGet.TabIndex = 26;
            // 
            // btGetInfoRiga
            // 
            this.btGetInfoRiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGetInfoRiga.Location = new System.Drawing.Point(3, 190);
            this.btGetInfoRiga.Name = "btGetInfoRiga";
            this.btGetInfoRiga.Size = new System.Drawing.Size(184, 23);
            this.btGetInfoRiga.TabIndex = 25;
            this.btGetInfoRiga.Text = "GetQtyCount";
            this.btGetInfoRiga.UseVisualStyleBackColor = true;
            this.btGetInfoRiga.Click += new System.EventHandler(this.btGetInfoRiga_Click);
            // 
            // labelCountRow
            // 
            this.labelCountRow.AutoSize = true;
            this.labelCountRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountRow.Location = new System.Drawing.Point(455, 85);
            this.labelCountRow.Name = "labelCountRow";
            this.labelCountRow.Size = new System.Drawing.Size(73, 20);
            this.labelCountRow.TabIndex = 24;
            this.labelCountRow.Text = "Counter";
            // 
            // labelQtyRow
            // 
            this.labelQtyRow.AutoSize = true;
            this.labelQtyRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQtyRow.Location = new System.Drawing.Point(342, 85);
            this.labelQtyRow.Name = "labelQtyRow";
            this.labelQtyRow.Size = new System.Drawing.Size(76, 20);
            this.labelQtyRow.TabIndex = 23;
            this.labelQtyRow.Text = "Quantity";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(568, 85);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(136, 20);
            this.label16.TabIndex = 22;
            this.label16.Text = "Function Result";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(218, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 20);
            this.label15.TabIndex = 21;
            this.label15.Text = "Row Number";
            // 
            // textCountRow
            // 
            this.textCountRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCountRow.Location = new System.Drawing.Point(459, 108);
            this.textCountRow.Name = "textCountRow";
            this.textCountRow.Size = new System.Drawing.Size(107, 22);
            this.textCountRow.TabIndex = 20;
            // 
            // textQtyRow
            // 
            this.textQtyRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textQtyRow.Location = new System.Drawing.Point(346, 109);
            this.textQtyRow.Name = "textQtyRow";
            this.textQtyRow.Size = new System.Drawing.Size(107, 22);
            this.textQtyRow.TabIndex = 19;
            // 
            // textSetRowResult
            // 
            this.textSetRowResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSetRowResult.Location = new System.Drawing.Point(572, 108);
            this.textSetRowResult.Name = "textSetRowResult";
            this.textSetRowResult.Size = new System.Drawing.Size(284, 22);
            this.textSetRowResult.TabIndex = 18;
            // 
            // textNRow
            // 
            this.textNRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNRow.Location = new System.Drawing.Point(222, 108);
            this.textNRow.Name = "textNRow";
            this.textNRow.Size = new System.Drawing.Size(107, 22);
            this.textNRow.TabIndex = 17;
            // 
            // buttonSetRow
            // 
            this.buttonSetRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetRow.Location = new System.Drawing.Point(3, 108);
            this.buttonSetRow.Name = "buttonSetRow";
            this.buttonSetRow.Size = new System.Drawing.Size(184, 23);
            this.buttonSetRow.TabIndex = 16;
            this.buttonSetRow.Text = "SetQtyCount";
            this.buttonSetRow.UseVisualStyleBackColor = true;
            this.buttonSetRow.Click += new System.EventHandler(this.buttonSetRow_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(568, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 20);
            this.label14.TabIndex = 15;
            this.label14.Text = "Function Result";
            // 
            // textDelRowResult
            // 
            this.textDelRowResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDelRowResult.Location = new System.Drawing.Point(572, 32);
            this.textDelRowResult.Name = "textDelRowResult";
            this.textDelRowResult.Size = new System.Drawing.Size(284, 22);
            this.textDelRowResult.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(218, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "Row Number";
            // 
            // textNumRow
            // 
            this.textNumRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumRow.Location = new System.Drawing.Point(222, 31);
            this.textNumRow.Name = "textNumRow";
            this.textNumRow.Size = new System.Drawing.Size(107, 22);
            this.textNumRow.TabIndex = 12;
            // 
            // buttonDelRow
            // 
            this.buttonDelRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelRow.Location = new System.Drawing.Point(3, 31);
            this.buttonDelRow.Name = "buttonDelRow";
            this.buttonDelRow.Size = new System.Drawing.Size(184, 23);
            this.buttonDelRow.TabIndex = 3;
            this.buttonDelRow.Text = "DelRow";
            this.buttonDelRow.UseVisualStyleBackColor = true;
            this.buttonDelRow.Click += new System.EventHandler(this.buttonDelRow_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1053, 660);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Pcquo use example";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHostName;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btSendRowDstn;
        private System.Windows.Forms.TextBox txtLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPiece;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btSendProg;
        private System.Windows.Forms.TextBox txtComm;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPrg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label dllPath;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProg2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textNumRow;
        private System.Windows.Forms.Button buttonDelRow;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textDelRowResult;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textQtyRow;
        private System.Windows.Forms.TextBox textSetRowResult;
        private System.Windows.Forms.TextBox textNRow;
        private System.Windows.Forms.Button buttonSetRow;
        private System.Windows.Forms.Label labelCountRow;
        private System.Windows.Forms.Label labelQtyRow;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textCountRow;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox RowCountGet;
        private System.Windows.Forms.TextBox RowQtyGet;
        private System.Windows.Forms.TextBox InfoRowGet;
        private System.Windows.Forms.TextBox RowNumberGet;
        private System.Windows.Forms.Button btGetInfoRiga;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textMacInRun;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textDstnActive;
        private System.Windows.Forms.TextBox textDstnSt;
        private System.Windows.Forms.TextBox textAuto;
        private System.Windows.Forms.Button btDstnSt;
        private System.Windows.Forms.Button btStartDstn;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textStartDstn;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textSetPosResult;
        private System.Windows.Forms.Button btSetPosDstn;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textSetPosRow;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textDstnName;
        private System.Windows.Forms.TextBox textInfoDstnResult;
        private System.Windows.Forms.TextBox textDstnInfoRow;
        private System.Windows.Forms.Button button1;
    }
}

