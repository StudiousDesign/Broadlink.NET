namespace Broadlink.WinApp.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnLogClean = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmbDevices = new System.Windows.Forms.ToolStripComboBox();
            this.btnConnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMenuOgren = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnIR_Learn = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRF_Learn = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLearnCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnKomutGonder = new System.Windows.Forms.ToolStripButton();
            this.cmbKomutListe = new System.Windows.Forms.ToolStripComboBox();
            this.txtIRCount = new System.Windows.Forms.ToolStripTextBox();
            this.btnKomutlariKaydet = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnIceAktar = new System.Windows.Forms.ToolStripButton();
            this.timerSicaklik = new System.Windows.Forms.Timer(this.components);
            this.txtLog = new BetterRichTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLogClean,
            this.toolStripSeparator2,
            this.cmbDevices,
            this.btnConnect,
            this.toolStripSeparator3,
            this.btnMenuOgren,
            this.toolStripSeparator1,
            this.btnKomutGonder,
            this.cmbKomutListe,
            this.txtIRCount,
            this.btnKomutlariKaydet,
            this.toolStripSeparator4,
            this.btnIceAktar});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // btnLogClean
            // 
            this.btnLogClean.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.btnLogClean, "btnLogClean");
            this.btnLogClean.Name = "btnLogClean";
            this.btnLogClean.Click += new System.EventHandler(this.btnLogClean_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // cmbDevices
            // 
            this.cmbDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDevices.Name = "cmbDevices";
            resources.ApplyResources(this.cmbDevices, "cmbDevices");
            // 
            // btnConnect
            // 
            this.btnConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.btnConnect, "btnConnect");
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // btnMenuOgren
            // 
            this.btnMenuOgren.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMenuOgren.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIR_Learn,
            this.btnRF_Learn,
            this.btnLearnCancel});
            resources.ApplyResources(this.btnMenuOgren, "btnMenuOgren");
            this.btnMenuOgren.Name = "btnMenuOgren";
            // 
            // btnIR_Learn
            // 
            this.btnIR_Learn.Name = "btnIR_Learn";
            resources.ApplyResources(this.btnIR_Learn, "btnIR_Learn");
            this.btnIR_Learn.Click += new System.EventHandler(this.btnIR_Learn_Click);
            // 
            // btnRF_Learn
            // 
            this.btnRF_Learn.Name = "btnRF_Learn";
            resources.ApplyResources(this.btnRF_Learn, "btnRF_Learn");
            this.btnRF_Learn.Click += new System.EventHandler(this.btnRF_Learn_Click);
            // 
            // btnLearnCancel
            // 
            this.btnLearnCancel.Name = "btnLearnCancel";
            resources.ApplyResources(this.btnLearnCancel, "btnLearnCancel");
            this.btnLearnCancel.Click += new System.EventHandler(this.btnLearnCancel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // btnKomutGonder
            // 
            this.btnKomutGonder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.btnKomutGonder, "btnKomutGonder");
            this.btnKomutGonder.Name = "btnKomutGonder";
            this.btnKomutGonder.Click += new System.EventHandler(this.btnKomutGonder_Click);
            // 
            // cmbKomutListe
            // 
            this.cmbKomutListe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKomutListe.DropDownWidth = 200;
            resources.ApplyResources(this.cmbKomutListe, "cmbKomutListe");
            this.cmbKomutListe.Name = "cmbKomutListe";
            // 
            // txtIRCount
            // 
            resources.ApplyResources(this.txtIRCount, "txtIRCount");
            this.txtIRCount.Name = "txtIRCount";
            // 
            // btnKomutlariKaydet
            // 
            this.btnKomutlariKaydet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.btnKomutlariKaydet, "btnKomutlariKaydet");
            this.btnKomutlariKaydet.Name = "btnKomutlariKaydet";
            this.btnKomutlariKaydet.Click += new System.EventHandler(this.btnKomutlariKaydet_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // btnIceAktar
            // 
            this.btnIceAktar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.btnIceAktar, "btnIceAktar");
            this.btnIceAktar.Name = "btnIceAktar";
            this.btnIceAktar.Click += new System.EventHandler(this.btnIceAktar_Click);
            // 
            // timerSicaklik
            // 
            this.timerSicaklik.Interval = 10000;
            this.timerSicaklik.Tick += new System.EventHandler(this.timerSicaklik_Tick);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.txtLog, "txtLog");
            this.txtLog.ForeColor = System.Drawing.Color.White;
            this.txtLog.Name = "txtLog";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Tag = "Broadlink .NET | Oda sıcaklığı : {0}°C";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnConnect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnKomutGonder;
        private System.Windows.Forms.ToolStripComboBox cmbKomutListe;
        private BetterRichTextBox txtLog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnLogClean;
        private System.Windows.Forms.Timer timerSicaklik;
        private System.Windows.Forms.ToolStripComboBox cmbDevices;
        private System.Windows.Forms.ToolStripButton btnKomutlariKaydet;
        private System.Windows.Forms.ToolStripDropDownButton btnMenuOgren;
        private System.Windows.Forms.ToolStripMenuItem btnIR_Learn;
        private System.Windows.Forms.ToolStripMenuItem btnRF_Learn;
        private System.Windows.Forms.ToolStripMenuItem btnLearnCancel;
        private System.Windows.Forms.ToolStripTextBox txtIRCount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnIceAktar;
    }
}