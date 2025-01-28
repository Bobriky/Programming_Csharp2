
namespace DirectoryTestFromel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstSubfolders = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSearch = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLblCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.txtInside = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.novýToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.otevřítToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.uložitToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tiskToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.vyjmoutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.kopírovatToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.vložitToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.nápovědaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSubfolders
            // 
            this.lstSubfolders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstSubfolders.FormattingEnabled = true;
            this.lstSubfolders.Location = new System.Drawing.Point(21, 73);
            this.lstSubfolders.Name = "lstSubfolders";
            this.lstSubfolders.Size = new System.Drawing.Size(724, 368);
            this.lstSubfolders.TabIndex = 0;
            this.lstSubfolders.SelectedIndexChanged += new System.EventHandler(this.lstSubfolders_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(773, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 20);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Vyhledat";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusLblCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 459);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLblCount
            // 
            this.statusLblCount.Name = "statusLblCount";
            this.statusLblCount.Size = new System.Drawing.Size(13, 17);
            this.statusLblCount.Text = "0";
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(21, 31);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(724, 20);
            this.txtDirectory.TabIndex = 4;
            // 
            // txtInside
            // 
            this.txtInside.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInside.Location = new System.Drawing.Point(773, 72);
            this.txtInside.Multiline = true;
            this.txtInside.Name = "txtInside";
            this.txtInside.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInside.Size = new System.Drawing.Size(399, 374);
            this.txtInside.TabIndex = 5;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novýToolStripButton,
            this.otevřítToolStripButton,
            this.uložitToolStripButton,
            this.tiskToolStripButton,
            this.toolStripSeparator,
            this.vyjmoutToolStripButton,
            this.kopírovatToolStripButton,
            this.vložitToolStripButton,
            this.toolStripSeparator1,
            this.nápovědaToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1184, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // novýToolStripButton
            // 
            this.novýToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.novýToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("novýToolStripButton.Image")));
            this.novýToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.novýToolStripButton.Name = "novýToolStripButton";
            this.novýToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.novýToolStripButton.Text = "&Nový";
            // 
            // otevřítToolStripButton
            // 
            this.otevřítToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.otevřítToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("otevřítToolStripButton.Image")));
            this.otevřítToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.otevřítToolStripButton.Name = "otevřítToolStripButton";
            this.otevřítToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.otevřítToolStripButton.Text = "&Otevřít";
            // 
            // uložitToolStripButton
            // 
            this.uložitToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uložitToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("uložitToolStripButton.Image")));
            this.uložitToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uložitToolStripButton.Name = "uložitToolStripButton";
            this.uložitToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.uložitToolStripButton.Text = "&Uložit";
            // 
            // tiskToolStripButton
            // 
            this.tiskToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tiskToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("tiskToolStripButton.Image")));
            this.tiskToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tiskToolStripButton.Name = "tiskToolStripButton";
            this.tiskToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.tiskToolStripButton.Text = "&Tisk";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // vyjmoutToolStripButton
            // 
            this.vyjmoutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vyjmoutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("vyjmoutToolStripButton.Image")));
            this.vyjmoutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.vyjmoutToolStripButton.Name = "vyjmoutToolStripButton";
            this.vyjmoutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.vyjmoutToolStripButton.Text = "&Vyjmout";
            // 
            // kopírovatToolStripButton
            // 
            this.kopírovatToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kopírovatToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("kopírovatToolStripButton.Image")));
            this.kopírovatToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kopírovatToolStripButton.Name = "kopírovatToolStripButton";
            this.kopírovatToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.kopírovatToolStripButton.Text = "&Kopírovat";
            // 
            // vložitToolStripButton
            // 
            this.vložitToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vložitToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("vložitToolStripButton.Image")));
            this.vložitToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.vložitToolStripButton.Name = "vložitToolStripButton";
            this.vložitToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.vložitToolStripButton.Text = "&Vložit";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // nápovědaToolStripButton
            // 
            this.nápovědaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nápovědaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("nápovědaToolStripButton.Image")));
            this.nápovědaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nápovědaToolStripButton.Name = "nápovědaToolStripButton";
            this.nápovědaToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.nápovědaToolStripButton.Text = "&Nápověda";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(97, 17);
            this.toolStripStatusLabel1.Text = "POČET POLOŽEK";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 481);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtInside);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lstSubfolders);
            this.MinimumSize = new System.Drawing.Size(1200, 520);
            this.Name = "Form1";
            this.Text = "Prohlížeč SQL souborů";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSubfolders;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLblCount;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.TextBox txtInside;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton novýToolStripButton;
        private System.Windows.Forms.ToolStripButton otevřítToolStripButton;
        private System.Windows.Forms.ToolStripButton uložitToolStripButton;
        private System.Windows.Forms.ToolStripButton tiskToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton vyjmoutToolStripButton;
        private System.Windows.Forms.ToolStripButton kopírovatToolStripButton;
        private System.Windows.Forms.ToolStripButton vložitToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton nápovědaToolStripButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

