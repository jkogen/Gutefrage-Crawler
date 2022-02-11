namespace GuteFrage_Crawler
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nudStartSite = new System.Windows.Forms.NumericUpDown();
            this.nudEndSite = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gboxControl = new System.Windows.Forms.GroupBox();
            this.tlPanelStart = new System.Windows.Forms.TableLayoutPanel();
            this.cboxSaveLog = new System.Windows.Forms.CheckBox();
            this.cboxProxy = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSearchUser = new System.Windows.Forms.TextBox();
            this.tbSearchUrl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.gboxLog = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gboxStatistics = new System.Windows.Forms.GroupBox();
            this.tlPanelStatistics = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblConnected = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblHits = new System.Windows.Forms.Label();
            this.Treffer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRequests = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.llblExceptions = new System.Windows.Forms.LinkLabel();
            this.tlPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlPanelSecondMain = new System.Windows.Forms.TableLayoutPanel();
            this.timerUpdateControls = new System.Windows.Forms.Timer(this.components);
            this.bgWorkerWebRequests = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartSite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndSite)).BeginInit();
            this.gboxControl.SuspendLayout();
            this.tlPanelStart.SuspendLayout();
            this.gboxLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gboxStatistics.SuspendLayout();
            this.tlPanelStatistics.SuspendLayout();
            this.tlPanelMain.SuspendLayout();
            this.tlPanelSecondMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudStartSite
            // 
            this.nudStartSite.AutoSize = true;
            this.nudStartSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudStartSite.Location = new System.Drawing.Point(112, 3);
            this.nudStartSite.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudStartSite.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStartSite.Name = "nudStartSite";
            this.nudStartSite.Size = new System.Drawing.Size(289, 20);
            this.nudStartSite.TabIndex = 0;
            this.nudStartSite.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStartSite.ValueChanged += new System.EventHandler(this.nudStartSite_ValueChanged);
            // 
            // nudEndSite
            // 
            this.nudEndSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudEndSite.Location = new System.Drawing.Point(112, 25);
            this.nudEndSite.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudEndSite.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEndSite.Name = "nudEndSite";
            this.nudEndSite.Size = new System.Drawing.Size(289, 20);
            this.nudEndSite.TabIndex = 1;
            this.nudEndSite.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEndSite.ValueChanged += new System.EventHandler(this.nudEndSite_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start-Seite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "End-Seite";
            // 
            // gboxControl
            // 
            this.gboxControl.AutoSize = true;
            this.gboxControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gboxControl.Controls.Add(this.tlPanelStart);
            this.gboxControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxControl.Location = new System.Drawing.Point(3, 3);
            this.gboxControl.Name = "gboxControl";
            this.gboxControl.Size = new System.Drawing.Size(304, 153);
            this.gboxControl.TabIndex = 4;
            this.gboxControl.TabStop = false;
            this.gboxControl.Text = "Steuerung";
            // 
            // tlPanelStart
            // 
            this.tlPanelStart.AutoSize = true;
            this.tlPanelStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlPanelStart.ColumnCount = 2;
            this.tlPanelStart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlPanelStart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlPanelStart.Controls.Add(this.cboxSaveLog, 1, 2);
            this.tlPanelStart.Controls.Add(this.cboxProxy, 1, 3);
            this.tlPanelStart.Controls.Add(this.label2, 0, 1);
            this.tlPanelStart.Controls.Add(this.nudStartSite, 1, 0);
            this.tlPanelStart.Controls.Add(this.nudEndSite, 1, 1);
            this.tlPanelStart.Controls.Add(this.label8, 0, 2);
            this.tlPanelStart.Controls.Add(this.label7, 0, 5);
            this.tlPanelStart.Controls.Add(this.tbSearchUser, 1, 5);
            this.tlPanelStart.Controls.Add(this.tbSearchUrl, 1, 4);
            this.tlPanelStart.Controls.Add(this.label5, 0, 4);
            this.tlPanelStart.Controls.Add(this.label9, 0, 3);
            this.tlPanelStart.Controls.Add(this.label1, 0, 0);
            this.tlPanelStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPanelStart.Location = new System.Drawing.Point(3, 16);
            this.tlPanelStart.Name = "tlPanelStart";
            this.tlPanelStart.RowCount = 6;
            this.tlPanelStart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlPanelStart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlPanelStart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlPanelStart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlPanelStart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlPanelStart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlPanelStart.Size = new System.Drawing.Size(298, 134);
            this.tlPanelStart.TabIndex = 5;
            // 
            // cboxSaveLog
            // 
            this.cboxSaveLog.Dock = System.Windows.Forms.DockStyle.Left;
            this.cboxSaveLog.Location = new System.Drawing.Point(112, 47);
            this.cboxSaveLog.Name = "cboxSaveLog";
            this.cboxSaveLog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboxSaveLog.Size = new System.Drawing.Size(15, 16);
            this.cboxSaveLog.TabIndex = 5;
            this.cboxSaveLog.UseVisualStyleBackColor = true;
            // 
            // cboxProxy
            // 
            this.cboxProxy.Location = new System.Drawing.Point(112, 69);
            this.cboxProxy.Name = "cboxProxy";
            this.cboxProxy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboxProxy.Size = new System.Drawing.Size(15, 14);
            this.cboxProxy.TabIndex = 12;
            this.cboxProxy.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Log.csv speichern";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nutzer suchen";
            // 
            // tbSearchUser
            // 
            this.tbSearchUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSearchUser.Location = new System.Drawing.Point(112, 113);
            this.tbSearchUser.Name = "tbSearchUser";
            this.tbSearchUser.Size = new System.Drawing.Size(289, 20);
            this.tbSearchUser.TabIndex = 9;
            this.tbSearchUser.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // tbSearchUrl
            // 
            this.tbSearchUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSearchUrl.Location = new System.Drawing.Point(112, 91);
            this.tbSearchUrl.Name = "tbSearchUrl";
            this.tbSearchUrl.Size = new System.Drawing.Size(289, 20);
            this.tbSearchUrl.TabIndex = 7;
            this.tbSearchUrl.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "URL suchen";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(3, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Proxy";
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStart.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.Location = new System.Drawing.Point(313, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(149, 153);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Suchen";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // gboxLog
            // 
            this.gboxLog.AutoSize = true;
            this.gboxLog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gboxLog.Controls.Add(this.dataGridView1);
            this.gboxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxLog.Location = new System.Drawing.Point(3, 3);
            this.gboxLog.Name = "gboxLog";
            this.gboxLog.Size = new System.Drawing.Size(777, 487);
            this.gboxLog.TabIndex = 5;
            this.gboxLog.TabStop = false;
            this.gboxLog.Text = "Log";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.column1,
            this.Column2,
            this.Column5});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(771, 468);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 80F;
            this.Column3.HeaderText = "URL";
            this.Column3.Name = "Column3";
            // 
            // column1
            // 
            this.column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column1.FillWeight = 10F;
            this.column1.HeaderText = "Seite";
            this.column1.Name = "column1";
            this.column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 20F;
            this.Column2.HeaderText = "Nutzer";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.FillWeight = 10F;
            this.Column5.HeaderText = "Frage";
            this.Column5.Name = "Column5";
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // gboxStatistics
            // 
            this.gboxStatistics.AutoSize = true;
            this.gboxStatistics.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gboxStatistics.Controls.Add(this.tlPanelStatistics);
            this.gboxStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxStatistics.Location = new System.Drawing.Point(468, 3);
            this.gboxStatistics.Name = "gboxStatistics";
            this.gboxStatistics.Size = new System.Drawing.Size(306, 153);
            this.gboxStatistics.TabIndex = 6;
            this.gboxStatistics.TabStop = false;
            this.gboxStatistics.Text = "Statistiken";
            // 
            // tlPanelStatistics
            // 
            this.tlPanelStatistics.AutoSize = true;
            this.tlPanelStatistics.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlPanelStatistics.ColumnCount = 2;
            this.tlPanelStatistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlPanelStatistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlPanelStatistics.Controls.Add(this.label11, 0, 4);
            this.tlPanelStatistics.Controls.Add(this.label10, 0, 5);
            this.tlPanelStatistics.Controls.Add(this.lblConnected, 1, 5);
            this.tlPanelStatistics.Controls.Add(this.lblStart, 1, 0);
            this.tlPanelStatistics.Controls.Add(this.lblEnd, 1, 1);
            this.tlPanelStatistics.Controls.Add(this.lblHits, 1, 3);
            this.tlPanelStatistics.Controls.Add(this.Treffer, 0, 3);
            this.tlPanelStatistics.Controls.Add(this.label3, 0, 0);
            this.tlPanelStatistics.Controls.Add(this.lblRequests, 1, 2);
            this.tlPanelStatistics.Controls.Add(this.label4, 0, 1);
            this.tlPanelStatistics.Controls.Add(this.label6, 0, 2);
            this.tlPanelStatistics.Controls.Add(this.llblExceptions, 1, 4);
            this.tlPanelStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPanelStatistics.Location = new System.Drawing.Point(3, 16);
            this.tlPanelStatistics.Name = "tlPanelStatistics";
            this.tlPanelStatistics.RowCount = 6;
            this.tlPanelStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlPanelStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlPanelStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlPanelStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlPanelStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlPanelStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlPanelStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlPanelStatistics.Size = new System.Drawing.Size(300, 134);
            this.tlPanelStatistics.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Exceptions";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Internetverbindung";
            // 
            // lblConnected
            // 
            this.lblConnected.AutoSize = true;
            this.lblConnected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnected.ForeColor = System.Drawing.Color.Black;
            this.lblConnected.Location = new System.Drawing.Point(105, 110);
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(68, 13);
            this.lblConnected.TabIndex = 10;
            this.lblConnected.Text = "Verbunden";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(105, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(49, 13);
            this.lblStart.TabIndex = 3;
            this.lblStart.Text = "00:00:00";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(105, 22);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(49, 13);
            this.lblEnd.TabIndex = 4;
            this.lblEnd.Text = "00:00:00";
            // 
            // lblHits
            // 
            this.lblHits.AutoSize = true;
            this.lblHits.Location = new System.Drawing.Point(105, 66);
            this.lblHits.Name = "lblHits";
            this.lblHits.Size = new System.Drawing.Size(13, 13);
            this.lblHits.TabIndex = 8;
            this.lblHits.Text = "0";
            // 
            // Treffer
            // 
            this.Treffer.AutoSize = true;
            this.Treffer.Location = new System.Drawing.Point(3, 66);
            this.Treffer.Name = "Treffer";
            this.Treffer.Size = new System.Drawing.Size(38, 13);
            this.Treffer.TabIndex = 9;
            this.Treffer.Text = "Treffer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Startzeit";
            // 
            // lblRequests
            // 
            this.lblRequests.AutoSize = true;
            this.lblRequests.Location = new System.Drawing.Point(105, 44);
            this.lblRequests.Name = "lblRequests";
            this.lblRequests.Size = new System.Drawing.Size(13, 13);
            this.lblRequests.TabIndex = 7;
            this.lblRequests.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Endzeit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Seiten-Anfragen";
            // 
            // llblExceptions
            // 
            this.llblExceptions.AutoSize = true;
            this.llblExceptions.Location = new System.Drawing.Point(105, 88);
            this.llblExceptions.Name = "llblExceptions";
            this.llblExceptions.Size = new System.Drawing.Size(13, 13);
            this.llblExceptions.TabIndex = 13;
            this.llblExceptions.TabStop = true;
            this.llblExceptions.Text = "0";
            this.llblExceptions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // tlPanelMain
            // 
            this.tlPanelMain.AutoSize = true;
            this.tlPanelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlPanelMain.ColumnCount = 1;
            this.tlPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPanelMain.Controls.Add(this.tlPanelSecondMain, 0, 1);
            this.tlPanelMain.Controls.Add(this.gboxLog, 0, 0);
            this.tlPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tlPanelMain.Name = "tlPanelMain";
            this.tlPanelMain.RowCount = 2;
            this.tlPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlPanelMain.Size = new System.Drawing.Size(783, 658);
            this.tlPanelMain.TabIndex = 7;
            // 
            // tlPanelSecondMain
            // 
            this.tlPanelSecondMain.AutoSize = true;
            this.tlPanelSecondMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlPanelSecondMain.ColumnCount = 3;
            this.tlPanelSecondMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlPanelSecondMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlPanelSecondMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlPanelSecondMain.Controls.Add(this.gboxStatistics, 0, 0);
            this.tlPanelSecondMain.Controls.Add(this.btnStart, 0, 0);
            this.tlPanelSecondMain.Controls.Add(this.gboxControl, 0, 0);
            this.tlPanelSecondMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPanelSecondMain.Location = new System.Drawing.Point(3, 496);
            this.tlPanelSecondMain.Name = "tlPanelSecondMain";
            this.tlPanelSecondMain.RowCount = 1;
            this.tlPanelSecondMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPanelSecondMain.Size = new System.Drawing.Size(777, 159);
            this.tlPanelSecondMain.TabIndex = 8;
            // 
            // timerUpdateControls
            // 
            this.timerUpdateControls.Interval = 700;
            this.timerUpdateControls.Tick += new System.EventHandler(this.timerUpdateControls_Tick);
            // 
            // bgWorkerWebRequests
            // 
            this.bgWorkerWebRequests.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerWebRequests_DoWork);
            this.bgWorkerWebRequests.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerWebRequests_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 658);
            this.Controls.Add(this.tlPanelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Form1";
            this.Text = "GuteFrage-Crawler";
            ((System.ComponentModel.ISupportInitialize)(this.nudStartSite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndSite)).EndInit();
            this.gboxControl.ResumeLayout(false);
            this.gboxControl.PerformLayout();
            this.tlPanelStart.ResumeLayout(false);
            this.tlPanelStart.PerformLayout();
            this.gboxLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gboxStatistics.ResumeLayout(false);
            this.gboxStatistics.PerformLayout();
            this.tlPanelStatistics.ResumeLayout(false);
            this.tlPanelStatistics.PerformLayout();
            this.tlPanelMain.ResumeLayout(false);
            this.tlPanelMain.PerformLayout();
            this.tlPanelSecondMain.ResumeLayout(false);
            this.tlPanelSecondMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudStartSite;
        private System.Windows.Forms.NumericUpDown nudEndSite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gboxControl;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox gboxLog;
        private System.Windows.Forms.GroupBox gboxStatistics;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRequests;
        private System.Windows.Forms.CheckBox cboxSaveLog;
        private System.Windows.Forms.Label Treffer;
        private System.Windows.Forms.Label lblHits;
        private System.Windows.Forms.TableLayoutPanel tlPanelStatistics;
        private System.Windows.Forms.TableLayoutPanel tlPanelStart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSearchUrl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSearchUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblConnected;
        private System.Windows.Forms.CheckBox cboxProxy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tlPanelMain;
        private System.Windows.Forms.TableLayoutPanel tlPanelSecondMain;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel llblExceptions;
        private System.Windows.Forms.Timer timerUpdateControls;
        private System.ComponentModel.BackgroundWorker bgWorkerWebRequests;
    }
}

