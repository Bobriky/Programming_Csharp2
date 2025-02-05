
namespace ArduinoSerial
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPush = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.novýToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.otevřítToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.uložitToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tiskToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cmbCOM = new System.Windows.Forms.ToolStripComboBox();
            this.btnReadCOM = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cmbBaudRate = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.btnConnect = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtSerialCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otevřítToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.uložitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uložitjakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tiskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.náhledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ukončitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zpětToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.znovuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.vyjmoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopírovatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vložitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.vybratvšeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nápovědaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obsahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hledatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.oproduktuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nástrojeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.přizpůsobitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.možnostiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtArduinoOutputMemory = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.myPort = new System.IO.Ports.SerialPort(this.components);
            this.txtNumbers = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblCounter2 = new System.Windows.Forms.Label();
            this.lblCounter8 = new System.Windows.Forms.Label();
            this.lblCounter7 = new System.Windows.Forms.Label();
            this.lblCounter6 = new System.Windows.Forms.Label();
            this.lblCounter5 = new System.Windows.Forms.Label();
            this.lblCounter4 = new System.Windows.Forms.Label();
            this.lblCounter3 = new System.Windows.Forms.Label();
            this.lblCounter9 = new System.Windows.Forms.Label();
            this.lblCounter1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.radRepeat = new System.Windows.Forms.RadioButton();
            this.radNoRepeat = new System.Windows.Forms.RadioButton();
            this.chkInfinity = new System.Windows.Forms.CheckBox();
            this.nmRepeatCount = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nmArduinoInput = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblLuckyNumber = new System.Windows.Forms.Label();
            this.lblAverageNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCounter0 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmRepeatCount)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmArduinoInput)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPush
            // 
            this.btnPush.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPush.Location = new System.Drawing.Point(68, 31);
            this.btnPush.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(181, 30);
            this.btnPush.TabIndex = 1;
            this.btnPush.Text = "ODESLAT PŘÍKAZ";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novýToolStripButton,
            this.otevřítToolStripButton,
            this.uložitToolStripButton,
            this.tiskToolStripButton,
            this.toolStripSeparator8,
            this.toolStripLabel1,
            this.cmbCOM,
            this.btnReadCOM,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.cmbBaudRate,
            this.toolStripSeparator,
            this.btnConnect});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(752, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // novýToolStripButton
            // 
            this.novýToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.novýToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("novýToolStripButton.Image")));
            this.novýToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.novýToolStripButton.Name = "novýToolStripButton";
            this.novýToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.novýToolStripButton.Text = "&Nový";
            // 
            // otevřítToolStripButton
            // 
            this.otevřítToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.otevřítToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("otevřítToolStripButton.Image")));
            this.otevřítToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.otevřítToolStripButton.Name = "otevřítToolStripButton";
            this.otevřítToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.otevřítToolStripButton.Text = "&Otevřít";
            // 
            // uložitToolStripButton
            // 
            this.uložitToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uložitToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("uložitToolStripButton.Image")));
            this.uložitToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uložitToolStripButton.Name = "uložitToolStripButton";
            this.uložitToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.uložitToolStripButton.Text = "&Uložit";
            // 
            // tiskToolStripButton
            // 
            this.tiskToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tiskToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("tiskToolStripButton.Image")));
            this.tiskToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tiskToolStripButton.Name = "tiskToolStripButton";
            this.tiskToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.tiskToolStripButton.Text = "&Tisk";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 25);
            this.toolStripLabel1.Text = "COM";
            // 
            // cmbCOM
            // 
            this.cmbCOM.Name = "cmbCOM";
            this.cmbCOM.Size = new System.Drawing.Size(121, 28);
            this.cmbCOM.Sorted = true;
            // 
            // btnReadCOM
            // 
            this.btnReadCOM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReadCOM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnReadCOM.Image = ((System.Drawing.Image)(resources.GetObject("btnReadCOM.Image")));
            this.btnReadCOM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReadCOM.Name = "btnReadCOM";
            this.btnReadCOM.Size = new System.Drawing.Size(80, 25);
            this.btnReadCOM.Text = "ReadCOM";
            this.btnReadCOM.Click += new System.EventHandler(this.btnReadCOM_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(73, 25);
            this.toolStripLabel2.Text = "BaudRate";
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "76800"});
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(92, 28);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 28);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnConnect.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.Image")));
            this.btnConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.btnConnect.Size = new System.Drawing.Size(80, 25);
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txtSerialCounter});
            this.statusStrip1.Location = new System.Drawing.Point(0, 485);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(752, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(183, 20);
            this.toolStripStatusLabel1.Text = "Počet proběhlých přenosů:";
            // 
            // txtSerialCounter
            // 
            this.txtSerialCounter.Name = "txtSerialCounter";
            this.txtSerialCounter.Size = new System.Drawing.Size(17, 20);
            this.txtSerialCounter.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.souborToolStripMenuItem,
            this.upravitToolStripMenuItem,
            this.nápovědaToolStripMenuItem,
            this.nástrojeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(752, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // souborToolStripMenuItem
            // 
            this.souborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novýToolStripMenuItem,
            this.otevřítToolStripMenuItem,
            this.toolStripSeparator2,
            this.uložitToolStripMenuItem,
            this.uložitjakoToolStripMenuItem,
            this.toolStripSeparator3,
            this.tiskToolStripMenuItem,
            this.náhledToolStripMenuItem,
            this.toolStripSeparator4,
            this.ukončitToolStripMenuItem});
            this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            this.souborToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.souborToolStripMenuItem.Text = "&Soubor";
            // 
            // novýToolStripMenuItem
            // 
            this.novýToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("novýToolStripMenuItem.Image")));
            this.novýToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.novýToolStripMenuItem.Name = "novýToolStripMenuItem";
            this.novýToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.novýToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.novýToolStripMenuItem.Text = "&Nový";
            // 
            // otevřítToolStripMenuItem
            // 
            this.otevřítToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("otevřítToolStripMenuItem.Image")));
            this.otevřítToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.otevřítToolStripMenuItem.Name = "otevřítToolStripMenuItem";
            this.otevřítToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.otevřítToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.otevřítToolStripMenuItem.Text = "&Otevřít";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(187, 6);
            // 
            // uložitToolStripMenuItem
            // 
            this.uložitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("uložitToolStripMenuItem.Image")));
            this.uložitToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uložitToolStripMenuItem.Name = "uložitToolStripMenuItem";
            this.uložitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.uložitToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.uložitToolStripMenuItem.Text = "&Uložit";
            // 
            // uložitjakoToolStripMenuItem
            // 
            this.uložitjakoToolStripMenuItem.Name = "uložitjakoToolStripMenuItem";
            this.uložitjakoToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.uložitjakoToolStripMenuItem.Text = "Uložit j&ako";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(187, 6);
            // 
            // tiskToolStripMenuItem
            // 
            this.tiskToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tiskToolStripMenuItem.Image")));
            this.tiskToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tiskToolStripMenuItem.Name = "tiskToolStripMenuItem";
            this.tiskToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tiskToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.tiskToolStripMenuItem.Text = "&Tisk";
            // 
            // náhledToolStripMenuItem
            // 
            this.náhledToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("náhledToolStripMenuItem.Image")));
            this.náhledToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.náhledToolStripMenuItem.Name = "náhledToolStripMenuItem";
            this.náhledToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.náhledToolStripMenuItem.Text = "&Náhled";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(187, 6);
            // 
            // ukončitToolStripMenuItem
            // 
            this.ukončitToolStripMenuItem.Name = "ukončitToolStripMenuItem";
            this.ukončitToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.ukončitToolStripMenuItem.Text = "U&končit";
            // 
            // upravitToolStripMenuItem
            // 
            this.upravitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zpětToolStripMenuItem,
            this.znovuToolStripMenuItem,
            this.toolStripSeparator5,
            this.vyjmoutToolStripMenuItem,
            this.kopírovatToolStripMenuItem,
            this.vložitToolStripMenuItem,
            this.toolStripSeparator6,
            this.vybratvšeToolStripMenuItem});
            this.upravitToolStripMenuItem.Name = "upravitToolStripMenuItem";
            this.upravitToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.upravitToolStripMenuItem.Text = "&Upravit";
            // 
            // zpětToolStripMenuItem
            // 
            this.zpětToolStripMenuItem.Name = "zpětToolStripMenuItem";
            this.zpětToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.zpětToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.zpětToolStripMenuItem.Text = "&Zpět";
            // 
            // znovuToolStripMenuItem
            // 
            this.znovuToolStripMenuItem.Name = "znovuToolStripMenuItem";
            this.znovuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.znovuToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.znovuToolStripMenuItem.Text = "&Znovu";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(205, 6);
            // 
            // vyjmoutToolStripMenuItem
            // 
            this.vyjmoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vyjmoutToolStripMenuItem.Image")));
            this.vyjmoutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.vyjmoutToolStripMenuItem.Name = "vyjmoutToolStripMenuItem";
            this.vyjmoutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.vyjmoutToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.vyjmoutToolStripMenuItem.Text = "&Vyjmout";
            // 
            // kopírovatToolStripMenuItem
            // 
            this.kopírovatToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kopírovatToolStripMenuItem.Image")));
            this.kopírovatToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kopírovatToolStripMenuItem.Name = "kopírovatToolStripMenuItem";
            this.kopírovatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopírovatToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.kopírovatToolStripMenuItem.Text = "&Kopírovat";
            // 
            // vložitToolStripMenuItem
            // 
            this.vložitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vložitToolStripMenuItem.Image")));
            this.vložitToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.vložitToolStripMenuItem.Name = "vložitToolStripMenuItem";
            this.vložitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.vložitToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.vložitToolStripMenuItem.Text = "&Vložit";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(205, 6);
            // 
            // vybratvšeToolStripMenuItem
            // 
            this.vybratvšeToolStripMenuItem.Name = "vybratvšeToolStripMenuItem";
            this.vybratvšeToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.vybratvšeToolStripMenuItem.Text = "&Vybrat vše";
            // 
            // nápovědaToolStripMenuItem
            // 
            this.nápovědaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obsahToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.hledatToolStripMenuItem,
            this.toolStripSeparator7,
            this.oproduktuToolStripMenuItem});
            this.nápovědaToolStripMenuItem.Name = "nápovědaToolStripMenuItem";
            this.nápovědaToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.nápovědaToolStripMenuItem.Text = "&Nápověda";
            // 
            // obsahToolStripMenuItem
            // 
            this.obsahToolStripMenuItem.Name = "obsahToolStripMenuItem";
            this.obsahToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.obsahToolStripMenuItem.Text = "&Obsah";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // hledatToolStripMenuItem
            // 
            this.hledatToolStripMenuItem.Name = "hledatToolStripMenuItem";
            this.hledatToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.hledatToolStripMenuItem.Text = "&Hledat";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(173, 6);
            // 
            // oproduktuToolStripMenuItem
            // 
            this.oproduktuToolStripMenuItem.Name = "oproduktuToolStripMenuItem";
            this.oproduktuToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.oproduktuToolStripMenuItem.Text = "&O produktu...";
            // 
            // nástrojeToolStripMenuItem
            // 
            this.nástrojeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.přizpůsobitToolStripMenuItem,
            this.možnostiToolStripMenuItem});
            this.nástrojeToolStripMenuItem.Name = "nástrojeToolStripMenuItem";
            this.nástrojeToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.nástrojeToolStripMenuItem.Text = "&Nástroje";
            // 
            // přizpůsobitToolStripMenuItem
            // 
            this.přizpůsobitToolStripMenuItem.Name = "přizpůsobitToolStripMenuItem";
            this.přizpůsobitToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.přizpůsobitToolStripMenuItem.Text = "&Přizpůsobit";
            // 
            // možnostiToolStripMenuItem
            // 
            this.možnostiToolStripMenuItem.Name = "možnostiToolStripMenuItem";
            this.možnostiToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.možnostiToolStripMenuItem.Text = "&Možnosti";
            // 
            // txtArduinoOutputMemory
            // 
            this.txtArduinoOutputMemory.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtArduinoOutputMemory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtArduinoOutputMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtArduinoOutputMemory.ForeColor = System.Drawing.SystemColors.Window;
            this.txtArduinoOutputMemory.Location = new System.Drawing.Point(3, 22);
            this.txtArduinoOutputMemory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArduinoOutputMemory.Multiline = true;
            this.txtArduinoOutputMemory.Name = "txtArduinoOutputMemory";
            this.txtArduinoOutputMemory.ReadOnly = true;
            this.txtArduinoOutputMemory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtArduinoOutputMemory.Size = new System.Drawing.Size(485, 143);
            this.txtArduinoOutputMemory.TabIndex = 5;
            this.txtArduinoOutputMemory.Text = "Čísla: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(5, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "[0] - generování čísla 0 - 9";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(5, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "[1] - generování čísla 0 - 99";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(5, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "[2] - generování čísla 0 - 999";
            // 
            // myPort
            // 
            this.myPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.myPort_DataReceived);
            // 
            // txtNumbers
            // 
            this.txtNumbers.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumbers.Location = new System.Drawing.Point(279, 92);
            this.txtNumbers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumbers.Name = "txtNumbers";
            this.txtNumbers.ReadOnly = true;
            this.txtNumbers.Size = new System.Drawing.Size(223, 84);
            this.txtNumbers.TabIndex = 17;
            this.txtNumbers.Text = "0000";
            this.txtNumbers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(7, 40);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "Počet 1:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(7, 197);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "Počet 9:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(7, 79);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 20);
            this.label14.TabIndex = 21;
            this.label14.Text = "Počet 3:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(7, 99);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 20);
            this.label15.TabIndex = 22;
            this.label15.Text = "Počet 4:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(7, 119);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 20);
            this.label16.TabIndex = 23;
            this.label16.Text = "Počet 5:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(7, 138);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 20);
            this.label17.TabIndex = 24;
            this.label17.Text = "Počet 6:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.Location = new System.Drawing.Point(7, 159);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 20);
            this.label18.TabIndex = 25;
            this.label18.Text = "Počet 7:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.Location = new System.Drawing.Point(7, 178);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 20);
            this.label19.TabIndex = 26;
            this.label19.Text = "Počet 8:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.Location = new System.Drawing.Point(7, 59);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 20);
            this.label20.TabIndex = 27;
            this.label20.Text = "Počet 2:";
            // 
            // lblCounter2
            // 
            this.lblCounter2.AutoSize = true;
            this.lblCounter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCounter2.Location = new System.Drawing.Point(85, 59);
            this.lblCounter2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCounter2.Name = "lblCounter2";
            this.lblCounter2.Size = new System.Drawing.Size(19, 20);
            this.lblCounter2.TabIndex = 1;
            this.lblCounter2.Text = "0";
            // 
            // lblCounter8
            // 
            this.lblCounter8.AutoSize = true;
            this.lblCounter8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCounter8.Location = new System.Drawing.Point(85, 178);
            this.lblCounter8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCounter8.Name = "lblCounter8";
            this.lblCounter8.Size = new System.Drawing.Size(19, 20);
            this.lblCounter8.TabIndex = 7;
            this.lblCounter8.Text = "0";
            // 
            // lblCounter7
            // 
            this.lblCounter7.AutoSize = true;
            this.lblCounter7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCounter7.Location = new System.Drawing.Point(85, 159);
            this.lblCounter7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCounter7.Name = "lblCounter7";
            this.lblCounter7.Size = new System.Drawing.Size(19, 20);
            this.lblCounter7.TabIndex = 6;
            this.lblCounter7.Text = "0";
            // 
            // lblCounter6
            // 
            this.lblCounter6.AutoSize = true;
            this.lblCounter6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCounter6.Location = new System.Drawing.Point(85, 138);
            this.lblCounter6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCounter6.Name = "lblCounter6";
            this.lblCounter6.Size = new System.Drawing.Size(19, 20);
            this.lblCounter6.TabIndex = 5;
            this.lblCounter6.Text = "0";
            // 
            // lblCounter5
            // 
            this.lblCounter5.AutoSize = true;
            this.lblCounter5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCounter5.Location = new System.Drawing.Point(85, 119);
            this.lblCounter5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCounter5.Name = "lblCounter5";
            this.lblCounter5.Size = new System.Drawing.Size(19, 20);
            this.lblCounter5.TabIndex = 4;
            this.lblCounter5.Text = "0";
            // 
            // lblCounter4
            // 
            this.lblCounter4.AutoSize = true;
            this.lblCounter4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCounter4.Location = new System.Drawing.Point(85, 99);
            this.lblCounter4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCounter4.Name = "lblCounter4";
            this.lblCounter4.Size = new System.Drawing.Size(19, 20);
            this.lblCounter4.TabIndex = 3;
            this.lblCounter4.Text = "0";
            // 
            // lblCounter3
            // 
            this.lblCounter3.AutoSize = true;
            this.lblCounter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCounter3.Location = new System.Drawing.Point(85, 79);
            this.lblCounter3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCounter3.Name = "lblCounter3";
            this.lblCounter3.Size = new System.Drawing.Size(19, 20);
            this.lblCounter3.TabIndex = 2;
            this.lblCounter3.Text = "0";
            // 
            // lblCounter9
            // 
            this.lblCounter9.AutoSize = true;
            this.lblCounter9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCounter9.Location = new System.Drawing.Point(85, 197);
            this.lblCounter9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCounter9.Name = "lblCounter9";
            this.lblCounter9.Size = new System.Drawing.Size(19, 20);
            this.lblCounter9.TabIndex = 8;
            this.lblCounter9.Text = "0";
            // 
            // lblCounter1
            // 
            this.lblCounter1.AutoSize = true;
            this.lblCounter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCounter1.Location = new System.Drawing.Point(85, 40);
            this.lblCounter1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCounter1.Name = "lblCounter1";
            this.lblCounter1.Size = new System.Drawing.Size(19, 20);
            this.lblCounter1.TabIndex = 0;
            this.lblCounter1.Text = "0";
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReset.Location = new System.Drawing.Point(3, 359);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(225, 46);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStop.Location = new System.Drawing.Point(283, 183);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(72, 46);
            this.btnStop.TabIndex = 38;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // radRepeat
            // 
            this.radRepeat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radRepeat.AutoSize = true;
            this.radRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radRepeat.Location = new System.Drawing.Point(5, 66);
            this.radRepeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radRepeat.Name = "radRepeat";
            this.radRepeat.Size = new System.Drawing.Size(100, 24);
            this.radRepeat.TabIndex = 2;
            this.radRepeat.TabStop = true;
            this.radRepeat.Text = "Opakovat";
            this.radRepeat.UseVisualStyleBackColor = true;
            this.radRepeat.CheckedChanged += new System.EventHandler(this.radRepeat_CheckedChanged);
            // 
            // radNoRepeat
            // 
            this.radNoRepeat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radNoRepeat.AutoSize = true;
            this.radNoRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radNoRepeat.Location = new System.Drawing.Point(120, 66);
            this.radNoRepeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radNoRepeat.Name = "radNoRepeat";
            this.radNoRepeat.Size = new System.Drawing.Size(117, 24);
            this.radNoRepeat.TabIndex = 3;
            this.radNoRepeat.TabStop = true;
            this.radNoRepeat.Text = "Neopakovat";
            this.radNoRepeat.UseVisualStyleBackColor = true;
            this.radNoRepeat.CheckedChanged += new System.EventHandler(this.radRepeat_CheckedChanged);
            // 
            // chkInfinity
            // 
            this.chkInfinity.AutoSize = true;
            this.chkInfinity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chkInfinity.Location = new System.Drawing.Point(59, 94);
            this.chkInfinity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkInfinity.Name = "chkInfinity";
            this.chkInfinity.Size = new System.Drawing.Size(47, 29);
            this.chkInfinity.TabIndex = 5;
            this.chkInfinity.Text = "∞";
            this.chkInfinity.UseVisualStyleBackColor = true;
            // 
            // nmRepeatCount
            // 
            this.nmRepeatCount.Location = new System.Drawing.Point(5, 95);
            this.nmRepeatCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmRepeatCount.Name = "nmRepeatCount";
            this.nmRepeatCount.Size = new System.Drawing.Size(49, 27);
            this.nmRepeatCount.TabIndex = 4;
            this.nmRepeatCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nmArduinoInput);
            this.groupBox1.Controls.Add(this.chkInfinity);
            this.groupBox1.Controls.Add(this.nmRepeatCount);
            this.groupBox1.Controls.Add(this.btnPush);
            this.groupBox1.Controls.Add(this.radNoRepeat);
            this.groupBox1.Controls.Add(this.radRepeat);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.MaximumSize = new System.Drawing.Size(260, 137);
            this.groupBox1.MinimumSize = new System.Drawing.Size(260, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(260, 137);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vstup do Arduina";
            // 
            // nmArduinoInput
            // 
            this.nmArduinoInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nmArduinoInput.Location = new System.Drawing.Point(5, 31);
            this.nmArduinoInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmArduinoInput.Name = "nmArduinoInput";
            this.nmArduinoInput.Size = new System.Drawing.Size(56, 30);
            this.nmArduinoInput.TabIndex = 0;
            this.nmArduinoInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(12, 206);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.MaximumSize = new System.Drawing.Size(260, 91);
            this.groupBox2.MinimumSize = new System.Drawing.Size(260, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(260, 91);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seznam příkazů:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.txtArduinoOutputMemory);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(12, 302);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(491, 167);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pamět Arduina";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(316, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Náhodné číslo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.lblCounter0);
            this.groupBox4.Controls.Add(this.lblLuckyNumber);
            this.groupBox4.Controls.Add(this.lblAverageNumber);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.btnReset);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.lblCounter2);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.lblCounter8);
            this.groupBox4.Controls.Add(this.lblCounter1);
            this.groupBox4.Controls.Add(this.lblCounter7);
            this.groupBox4.Controls.Add(this.lblCounter9);
            this.groupBox4.Controls.Add(this.lblCounter6);
            this.groupBox4.Controls.Add(this.lblCounter3);
            this.groupBox4.Controls.Add(this.lblCounter5);
            this.groupBox4.Controls.Add(this.lblCounter4);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(509, 62);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.MinimumSize = new System.Drawing.Size(220, 281);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(231, 407);
            this.groupBox4.TabIndex = 48;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Statistika čísel";
            // 
            // lblLuckyNumber
            // 
            this.lblLuckyNumber.AutoSize = true;
            this.lblLuckyNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLuckyNumber.Location = new System.Drawing.Point(147, 246);
            this.lblLuckyNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLuckyNumber.Name = "lblLuckyNumber";
            this.lblLuckyNumber.Size = new System.Drawing.Size(19, 20);
            this.lblLuckyNumber.TabIndex = 10;
            this.lblLuckyNumber.Text = "0";
            // 
            // lblAverageNumber
            // 
            this.lblAverageNumber.AutoSize = true;
            this.lblAverageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAverageNumber.Location = new System.Drawing.Point(119, 226);
            this.lblAverageNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAverageNumber.Name = "lblAverageNumber";
            this.lblAverageNumber.Size = new System.Drawing.Size(19, 20);
            this.lblAverageNumber.TabIndex = 9;
            this.lblAverageNumber.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(7, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Nejčastější číslo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(7, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Průměr čísel:";
            // 
            // lblCounter0
            // 
            this.lblCounter0.AutoSize = true;
            this.lblCounter0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCounter0.Location = new System.Drawing.Point(85, 20);
            this.lblCounter0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCounter0.Name = "lblCounter0";
            this.lblCounter0.Size = new System.Drawing.Size(19, 20);
            this.lblCounter0.TabIndex = 40;
            this.lblCounter0.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(7, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Počet 0:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 511);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumbers);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(767, 548);
            this.Name = "Form1";
            this.Text = "Arduino Kostky";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmRepeatCount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmArduinoInput)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton novýToolStripButton;
        private System.Windows.Forms.ToolStripButton otevřítToolStripButton;
        private System.Windows.Forms.ToolStripButton uložitToolStripButton;
        private System.Windows.Forms.ToolStripButton tiskToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cmbCOM;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cmbBaudRate;
        private System.Windows.Forms.ToolStripButton btnConnect;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem souborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otevřítToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem uložitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uložitjakoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tiskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem náhledToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ukončitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upravitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zpětToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem znovuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem vyjmoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopírovatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vložitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem vybratvšeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nápovědaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obsahToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hledatToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem oproduktuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nástrojeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem přizpůsobitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem možnostiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton btnReadCOM;
        private System.Windows.Forms.TextBox txtArduinoOutputMemory;
        private System.Windows.Forms.ToolStripStatusLabel txtSerialCounter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.IO.Ports.SerialPort myPort;
        private System.Windows.Forms.TextBox txtNumbers;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblCounter2;
        private System.Windows.Forms.Label lblCounter8;
        private System.Windows.Forms.Label lblCounter7;
        private System.Windows.Forms.Label lblCounter6;
        private System.Windows.Forms.Label lblCounter5;
        private System.Windows.Forms.Label lblCounter4;
        private System.Windows.Forms.Label lblCounter3;
        private System.Windows.Forms.Label lblCounter9;
        private System.Windows.Forms.Label lblCounter1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.RadioButton radRepeat;
        private System.Windows.Forms.RadioButton radNoRepeat;
        private System.Windows.Forms.CheckBox chkInfinity;
        private System.Windows.Forms.NumericUpDown nmRepeatCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nmArduinoInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblLuckyNumber;
        private System.Windows.Forms.Label lblAverageNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCounter0;
    }
}

