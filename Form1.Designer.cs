namespace Oneckup
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TimerBox = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.StartupBox = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolSync = new System.Windows.Forms.ToolStripMenuItem();
            this.toolOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolExit = new System.Windows.Forms.ToolStripMenuItem();
            this.SyncButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SyncTimer = new System.Windows.Forms.Timer(this.components);
            this.destBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informazioniSuDckupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.DayCheck = new System.Windows.Forms.CheckBox();
            this.numDayHour = new System.Windows.Forms.NumericUpDown();
            this.numDayMinute = new System.Windows.Forms.NumericUpDown();
            this.DailyTimer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.searchDest = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.remButton = new System.Windows.Forms.Button();
            this.Bidirectional = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDayHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDayMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // TimerBox
            // 
            this.TimerBox.AutoSize = true;
            this.TimerBox.Location = new System.Drawing.Point(33, 284);
            this.TimerBox.Name = "TimerBox";
            this.TimerBox.Size = new System.Drawing.Size(172, 17);
            this.TimerBox.TabIndex = 1;
            this.TimerBox.Text = "Esegui la sincronizzazione ogni";
            this.TimerBox.UseVisualStyleBackColor = true;
            this.TimerBox.CheckedChanged += new System.EventHandler(this.TimerBox_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "secondi",
            "minuti",
            "ore"});
            this.comboBox1.Location = new System.Drawing.Point(255, 283);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // StartupBox
            // 
            this.StartupBox.AutoSize = true;
            this.StartupBox.Location = new System.Drawing.Point(33, 261);
            this.StartupBox.Name = "StartupBox";
            this.StartupBox.Size = new System.Drawing.Size(157, 17);
            this.StartupBox.TabIndex = 3;
            this.StartupBox.Text = "Esegui all\'avvio di Windows";
            this.StartupBox.UseVisualStyleBackColor = true;
            this.StartupBox.CheckedChanged += new System.EventHandler(this.StartupBox_CheckedChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Oneckup © - In esecuzione";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSync,
            this.toolOpen,
            this.toolExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 92);
            // 
            // toolSync
            // 
            this.toolSync.Name = "toolSync";
            this.toolSync.Size = new System.Drawing.Size(152, 22);
            this.toolSync.Text = "Backup";
            this.toolSync.Click += new System.EventHandler(this.toolSync_Click);
            // 
            // toolOpen
            // 
            this.toolOpen.Enabled = false;
            this.toolOpen.Name = "toolOpen";
            this.toolOpen.Size = new System.Drawing.Size(152, 22);
            this.toolOpen.Text = "Ripristina";
            this.toolOpen.Click += new System.EventHandler(this.toolOpen_Click);
            // 
            // toolExit
            // 
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(152, 22);
            this.toolExit.Text = "Chiudi";
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
            // 
            // SyncButton
            // 
            this.SyncButton.Location = new System.Drawing.Point(211, 227);
            this.SyncButton.Name = "SyncButton";
            this.SyncButton.Size = new System.Drawing.Size(165, 51);
            this.SyncButton.TabIndex = 4;
            this.SyncButton.Text = "Backup";
            this.SyncButton.UseVisualStyleBackColor = true;
            this.SyncButton.Click += new System.EventHandler(this.SyncButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(33, 78);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(343, 143);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.DoubleClick += new System.EventHandler(this.richTextBox1_DoubleClick);
            // 
            // SyncTimer
            // 
            this.SyncTimer.Interval = 10000;
            // 
            // destBox
            // 
            this.destBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.destBox.Location = new System.Drawing.Point(104, 34);
            this.destBox.Name = "destBox";
            this.destBox.ReadOnly = true;
            this.destBox.Size = new System.Drawing.Size(202, 20);
            this.destBox.TabIndex = 6;
            this.destBox.Text = "C:\\Upload";
            this.destBox.Leave += new System.EventHandler(this.destBox_Leave);
            this.destBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.destBox_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Destinazione";
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(212, 284);
            this.timeBox.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(38, 20);
            this.timeBox.TabIndex = 8;
            this.timeBox.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.timeBox.ValueChanged += new System.EventHandler(this.timeBox_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(409, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripSeparator1,
            this.toolStripMenuItem4});
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.aToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem2.Text = "Salva impostazioni";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem3.Text = "...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem4.Text = "Esci";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informazioniSuDckupToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // informazioniSuDckupToolStripMenuItem
            // 
            this.informazioniSuDckupToolStripMenuItem.Name = "informazioniSuDckupToolStripMenuItem";
            this.informazioniSuDckupToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.informazioniSuDckupToolStripMenuItem.Text = "Informazioni su Oneckup";
            this.informazioniSuDckupToolStripMenuItem.Click += new System.EventHandler(this.informazioniSuDckupToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 362);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(409, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "asd";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(129, 17);
            this.toolStripStatusLabel1.Text = "Oneckup © - In esecuzione";
            // 
            // DayCheck
            // 
            this.DayCheck.AutoSize = true;
            this.DayCheck.Location = new System.Drawing.Point(33, 307);
            this.DayCheck.Name = "DayCheck";
            this.DayCheck.Size = new System.Drawing.Size(168, 17);
            this.DayCheck.TabIndex = 11;
            this.DayCheck.Text = "Esegui la sincronizzazione alle";
            this.DayCheck.UseVisualStyleBackColor = true;
            this.DayCheck.CheckedChanged += new System.EventHandler(this.DayCheck_CheckedChanged);
            // 
            // numDayHour
            // 
            this.numDayHour.Location = new System.Drawing.Point(211, 307);
            this.numDayHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numDayHour.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numDayHour.Name = "numDayHour";
            this.numDayHour.Size = new System.Drawing.Size(38, 20);
            this.numDayHour.TabIndex = 12;
            this.numDayHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numDayHour.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numDayHour.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numDayHour.ValueChanged += new System.EventHandler(this.numDayHour_ValueChanged);
            // 
            // numDayMinute
            // 
            this.numDayMinute.Location = new System.Drawing.Point(248, 307);
            this.numDayMinute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numDayMinute.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numDayMinute.Name = "numDayMinute";
            this.numDayMinute.Size = new System.Drawing.Size(38, 20);
            this.numDayMinute.TabIndex = 13;
            this.numDayMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numDayMinute.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numDayMinute.ValueChanged += new System.EventHandler(this.numDayMinute_ValueChanged);
            // 
            // DailyTimer
            // 
            this.DailyTimer.Interval = 10000;
            this.DailyTimer.Tick += new System.EventHandler(this.SyncDailyTimer);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cartelle da sincronizzare";
            // 
            // searchDest
            // 
            this.searchDest.Location = new System.Drawing.Point(312, 33);
            this.searchDest.Name = "searchDest";
            this.searchDest.Size = new System.Drawing.Size(63, 21);
            this.searchDest.TabIndex = 16;
            this.searchDest.Text = "Sfoglia";
            this.searchDest.UseVisualStyleBackColor = true;
            this.searchDest.Click += new System.EventHandler(this.searchDest_Click);
            // 
            // addButton
            // 
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Location = new System.Drawing.Point(33, 227);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(86, 22);
            this.addButton.TabIndex = 17;
            this.addButton.Text = "Aggiungi";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // remButton
            // 
            this.remButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.remButton.Location = new System.Drawing.Point(118, 227);
            this.remButton.Name = "remButton";
            this.remButton.Size = new System.Drawing.Size(83, 22);
            this.remButton.TabIndex = 18;
            this.remButton.Text = "Rimuovi";
            this.remButton.UseVisualStyleBackColor = true;
            this.remButton.Click += new System.EventHandler(this.remButton_Click);
            // 
            // Bidirectional
            // 
            this.Bidirectional.AutoSize = true;
            this.Bidirectional.Location = new System.Drawing.Point(33, 330);
            this.Bidirectional.Name = "Bidirectional";
            this.Bidirectional.Size = new System.Drawing.Size(124, 17);
            this.Bidirectional.TabIndex = 19;
            this.Bidirectional.Text = "Backup bidirezionale";
            this.Bidirectional.UseVisualStyleBackColor = true;
            this.Bidirectional.CheckedChanged += new System.EventHandler(this.Bidirectional_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 384);
            this.Controls.Add(this.Bidirectional);
            this.Controls.Add(this.searchDest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.numDayMinute);
            this.Controls.Add(this.numDayHour);
            this.Controls.Add(this.DayCheck);
            this.Controls.Add(this.remButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.destBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.SyncButton);
            this.Controls.Add(this.StartupBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TimerBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.Text = "Oneckup";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timeBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDayHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDayMinute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox TimerBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox StartupBox;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button SyncButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer SyncTimer;
        private System.Windows.Forms.TextBox destBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown timeBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem informazioniSuDckupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.CheckBox DayCheck;
        private System.Windows.Forms.NumericUpDown numDayHour;
        private System.Windows.Forms.NumericUpDown numDayMinute;
        private System.Windows.Forms.Timer DailyTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchDest;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button remButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolOpen;
        private System.Windows.Forms.ToolStripMenuItem toolExit;
        private System.Windows.Forms.ToolStripMenuItem toolSync;
        private System.Windows.Forms.CheckBox Bidirectional;
    }
}

