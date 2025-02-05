
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
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.txtSerialCmdOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSerialCmdInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.myPort = new System.IO.Ports.SerialPort(this.components);
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(74, 90);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(140, 30);
            this.btnPush.TabIndex = 0;
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
            this.toolStrip1.Size = new System.Drawing.Size(732, 28);
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
            "1200",
            "153600",
            "19200",
            "2400",
            "300",
            "38400",
            "4800",
            "600",
            "76800",
            "9600"});
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(121, 28);
            this.cmbBaudRate.Sorted = true;
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 28);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnConnect.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.Image")));
            this.btnConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConnect.Name = "btnConnect";
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 407);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(732, 26);
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(520, 191);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 200);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.menuStrip1.Size = new System.Drawing.Size(732, 28);
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
            // txtSerialCmdOutput
            // 
            this.txtSerialCmdOutput.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSerialCmdOutput.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSerialCmdOutput.Location = new System.Drawing.Point(12, 317);
            this.txtSerialCmdOutput.Multiline = true;
            this.txtSerialCmdOutput.Name = "txtSerialCmdOutput";
            this.txtSerialCmdOutput.ReadOnly = true;
            this.txtSerialCmdOutput.Size = new System.Drawing.Size(281, 74);
            this.txtSerialCmdOutput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sériová konzole - výstup Arduina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vstup do Arduina";
            // 
            // txtSerialCmdInput
            // 
            this.txtSerialCmdInput.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSerialCmdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSerialCmdInput.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSerialCmdInput.Location = new System.Drawing.Point(12, 90);
            this.txtSerialCmdInput.Name = "txtSerialCmdInput";
            this.txtSerialCmdInput.Size = new System.Drawing.Size(56, 30);
            this.txtSerialCmdInput.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Seznam příkazů:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(15, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "[0] - generování čísla 0 - 10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(15, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "[1] - generování čísla 0 - 100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(15, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "[2] - generování čísla 0 - 1000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(15, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "[5] - zapnutí hraní SPORTKY";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(15, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "[4] - zapnutí hraní KOSTEK";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(15, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(230, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "[3] - generování čísla 0,0 - 1,0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(15, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "[6] - zapnutí hraní RULETY";
            // 
            // myPort
            // 
            this.myPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.myPort_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 433);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSerialCmdInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSerialCmdOutput);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnPush);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "Form1";
            this.Text = "Arduino Kostky";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.TextBox txtSerialCmdOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSerialCmdInput;
        private System.Windows.Forms.ToolStripStatusLabel txtSerialCounter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.IO.Ports.SerialPort myPort;
    }
}

