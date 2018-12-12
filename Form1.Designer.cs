namespace NexioPaySample
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
            this.Resultbox = new System.Windows.Forms.RichTextBox();
            this.clear_btn = new System.Windows.Forms.Button();
            this.ClientSideToken_Btn = new System.Windows.Forms.Button();
            this.PostDataBox = new System.Windows.Forms.RichTextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.TransList = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URLBox = new System.Windows.Forms.RichTextBox();
            this.TransFromNexioList = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox_trans = new System.Windows.Forms.GroupBox();
            this.trans_sendcommand_btn = new System.Windows.Forms.Button();
            this.rb_trans_summary = new System.Windows.Forms.RadioButton();
            this.rb_trans_voidtrans = new System.Windows.Forms.RadioButton();
            this.rb_trans_capturetrans = new System.Windows.Forms.RadioButton();
            this.rb_trans_trans = new System.Windows.Forms.RadioButton();
            this.rb_trans_bulkcapture = new System.Windows.Forms.RadioButton();
            this.rb_trans_searchtrans = new System.Windows.Forms.RadioButton();
            this.rb_trans_bulkvoid = new System.Windows.Forms.RadioButton();
            this.rb_trans_paymenttypes = new System.Windows.Forms.RadioButton();
            this.rb_trans_transtotal = new System.Windows.Forms.RadioButton();
            this.rb_trans_refundtran = new System.Windows.Forms.RadioButton();
            this.rb_trans_dailysum = new System.Windows.Forms.RadioButton();
            this.rb_trans_transcount = new System.Windows.Forms.RadioButton();
            this.rb_trans_Match4FDR = new System.Windows.Forms.RadioButton();
            this.rb_trans_tran = new System.Windows.Forms.RadioButton();
            this.rb_trans_tranwithId = new System.Windows.Forms.RadioButton();
            this.tabPage_payment = new System.Windows.Forms.TabPage();
            this.groupBox_payment = new System.Windows.Forms.GroupBox();
            this.bt_payment_sendcommand = new System.Windows.Forms.Button();
            this.rb_savecard = new System.Windows.Forms.RadioButton();
            this.rb_deltoken = new System.Windows.Forms.RadioButton();
            this.rb_cardtrans = new System.Windows.Forms.RadioButton();
            this.rb_echeck = new System.Windows.Forms.RadioButton();
            this.rb_voidtrans = new System.Windows.Forms.RadioButton();
            this.rb_capturetrans = new System.Windows.Forms.RadioButton();
            this.rb_refundtrans = new System.Windows.Forms.RadioButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.TokenList = new System.Windows.Forms.DataGridView();
            this.Token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox_iframe = new System.Windows.Forms.GroupBox();
            this.rb_iframe_onetimetoken = new System.Windows.Forms.RadioButton();
            this.iframe_sendcommand_btn = new System.Windows.Forms.Button();
            this.rb_iframe_runecheck = new System.Windows.Forms.RadioButton();
            this.rb_iframe_saveecheck = new System.Windows.Forms.RadioButton();
            this.rb_iframe_savecard = new System.Windows.Forms.RadioButton();
            this.rb_iframe_alipay = new System.Windows.Forms.RadioButton();
            this.rb_iframe_runtrans = new System.Windows.Forms.RadioButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransFromNexioList)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox_trans.SuspendLayout();
            this.tabPage_payment.SuspendLayout();
            this.groupBox_payment.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TokenList)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox_iframe.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Resultbox
            // 
            this.Resultbox.Location = new System.Drawing.Point(6, 16);
            this.Resultbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Resultbox.Name = "Resultbox";
            this.Resultbox.Size = new System.Drawing.Size(539, 594);
            this.Resultbox.TabIndex = 10;
            this.Resultbox.Text = "";
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(886, 881);
            this.clear_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(161, 35);
            this.clear_btn.TabIndex = 11;
            this.clear_btn.Text = "Clear";
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // ClientSideToken_Btn
            // 
            this.ClientSideToken_Btn.Location = new System.Drawing.Point(117, 72);
            this.ClientSideToken_Btn.Name = "ClientSideToken_Btn";
            this.ClientSideToken_Btn.Size = new System.Drawing.Size(161, 35);
            this.ClientSideToken_Btn.TabIndex = 14;
            this.ClientSideToken_Btn.Text = "Client Side Token";
            this.ClientSideToken_Btn.UseVisualStyleBackColor = true;
            this.ClientSideToken_Btn.Click += new System.EventHandler(this.ClientSideToken_Btn_Click);
            // 
            // PostDataBox
            // 
            this.PostDataBox.Font = new System.Drawing.Font("SimSun", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PostDataBox.Location = new System.Drawing.Point(6, 20);
            this.PostDataBox.Name = "PostDataBox";
            this.PostDataBox.Size = new System.Drawing.Size(539, 162);
            this.PostDataBox.TabIndex = 20;
            this.PostDataBox.Text = "";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.TransList);
            this.groupBox9.Location = new System.Drawing.Point(445, 66);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(422, 338);
            this.groupBox9.TabIndex = 40;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Local Transaction List";
            // 
            // TransList
            // 
            this.TransList.AllowUserToAddRows = false;
            this.TransList.AllowUserToDeleteRows = false;
            this.TransList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check,
            this.id,
            this.amount});
            this.TransList.Location = new System.Drawing.Point(6, 19);
            this.TransList.Name = "TransList";
            this.TransList.RowTemplate.Height = 27;
            this.TransList.Size = new System.Drawing.Size(410, 308);
            this.TransList.TabIndex = 38;
            // 
            // Check
            // 
            this.Check.FillWeight = 200F;
            this.Check.HeaderText = "Check";
            this.Check.Name = "Check";
            this.Check.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Check.Width = 20;
            // 
            // id
            // 
            this.id.FillWeight = 200F;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.HeaderText = "amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // URLBox
            // 
            this.URLBox.Location = new System.Drawing.Point(6, 17);
            this.URLBox.Name = "URLBox";
            this.URLBox.Size = new System.Drawing.Size(967, 27);
            this.URLBox.TabIndex = 21;
            this.URLBox.Text = "";
            // 
            // TransFromNexioList
            // 
            this.TransFromNexioList.AllowUserToAddRows = false;
            this.TransFromNexioList.AllowUserToDeleteRows = false;
            this.TransFromNexioList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransFromNexioList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.TransFromNexioList.Location = new System.Drawing.Point(6, 15);
            this.TransFromNexioList.Name = "TransFromNexioList";
            this.TransFromNexioList.RowTemplate.Height = 27;
            this.TransFromNexioList.Size = new System.Drawing.Size(410, 485);
            this.TransFromNexioList.TabIndex = 39;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.FillWeight = 200F;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Check";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn1.Width = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 200F;
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "amount";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox_trans);
            this.tabPage4.Location = new System.Drawing.Point(4, 46);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(419, 462);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Transaction Service";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox_trans
            // 
            this.groupBox_trans.Controls.Add(this.trans_sendcommand_btn);
            this.groupBox_trans.Controls.Add(this.rb_trans_summary);
            this.groupBox_trans.Controls.Add(this.rb_trans_voidtrans);
            this.groupBox_trans.Controls.Add(this.rb_trans_capturetrans);
            this.groupBox_trans.Controls.Add(this.rb_trans_trans);
            this.groupBox_trans.Controls.Add(this.rb_trans_bulkcapture);
            this.groupBox_trans.Controls.Add(this.rb_trans_searchtrans);
            this.groupBox_trans.Controls.Add(this.rb_trans_bulkvoid);
            this.groupBox_trans.Controls.Add(this.rb_trans_paymenttypes);
            this.groupBox_trans.Controls.Add(this.rb_trans_transtotal);
            this.groupBox_trans.Controls.Add(this.rb_trans_refundtran);
            this.groupBox_trans.Controls.Add(this.rb_trans_dailysum);
            this.groupBox_trans.Controls.Add(this.rb_trans_transcount);
            this.groupBox_trans.Controls.Add(this.rb_trans_Match4FDR);
            this.groupBox_trans.Controls.Add(this.rb_trans_tran);
            this.groupBox_trans.Controls.Add(this.rb_trans_tranwithId);
            this.groupBox_trans.Location = new System.Drawing.Point(4, 6);
            this.groupBox_trans.Name = "groupBox_trans";
            this.groupBox_trans.Size = new System.Drawing.Size(412, 453);
            this.groupBox_trans.TabIndex = 38;
            this.groupBox_trans.TabStop = false;
            // 
            // trans_sendcommand_btn
            // 
            this.trans_sendcommand_btn.Location = new System.Drawing.Point(99, 396);
            this.trans_sendcommand_btn.Name = "trans_sendcommand_btn";
            this.trans_sendcommand_btn.Size = new System.Drawing.Size(161, 35);
            this.trans_sendcommand_btn.TabIndex = 39;
            this.trans_sendcommand_btn.Text = "Send Command";
            this.trans_sendcommand_btn.UseVisualStyleBackColor = true;
            this.trans_sendcommand_btn.Click += new System.EventHandler(this.trans_sendcommand_btn_Click);
            // 
            // rb_trans_summary
            // 
            this.rb_trans_summary.AutoSize = true;
            this.rb_trans_summary.Location = new System.Drawing.Point(6, 371);
            this.rb_trans_summary.Name = "rb_trans_summary";
            this.rb_trans_summary.Size = new System.Drawing.Size(180, 19);
            this.rb_trans_summary.TabIndex = 52;
            this.rb_trans_summary.TabStop = true;
            this.rb_trans_summary.Text = "Transaction Summary";
            this.rb_trans_summary.UseVisualStyleBackColor = true;
            this.rb_trans_summary.CheckedChanged += new System.EventHandler(this.rb_trans_summary_CheckedChanged);
            // 
            // rb_trans_voidtrans
            // 
            this.rb_trans_voidtrans.AutoSize = true;
            this.rb_trans_voidtrans.Location = new System.Drawing.Point(6, 346);
            this.rb_trans_voidtrans.Name = "rb_trans_voidtrans";
            this.rb_trans_voidtrans.Size = new System.Drawing.Size(156, 19);
            this.rb_trans_voidtrans.TabIndex = 51;
            this.rb_trans_voidtrans.TabStop = true;
            this.rb_trans_voidtrans.Text = "Void Transaction";
            this.rb_trans_voidtrans.UseVisualStyleBackColor = true;
            this.rb_trans_voidtrans.CheckedChanged += new System.EventHandler(this.rb_trans_voidtrans_CheckedChanged);
            // 
            // rb_trans_capturetrans
            // 
            this.rb_trans_capturetrans.AutoSize = true;
            this.rb_trans_capturetrans.Location = new System.Drawing.Point(6, 321);
            this.rb_trans_capturetrans.Name = "rb_trans_capturetrans";
            this.rb_trans_capturetrans.Size = new System.Drawing.Size(180, 19);
            this.rb_trans_capturetrans.TabIndex = 50;
            this.rb_trans_capturetrans.TabStop = true;
            this.rb_trans_capturetrans.Text = "Capture Transaction";
            this.rb_trans_capturetrans.UseVisualStyleBackColor = true;
            this.rb_trans_capturetrans.CheckedChanged += new System.EventHandler(this.rb_trans_capturetrans_CheckedChanged);
            // 
            // rb_trans_trans
            // 
            this.rb_trans_trans.AutoSize = true;
            this.rb_trans_trans.Location = new System.Drawing.Point(6, 296);
            this.rb_trans_trans.Name = "rb_trans_trans";
            this.rb_trans_trans.Size = new System.Drawing.Size(124, 19);
            this.rb_trans_trans.TabIndex = 48;
            this.rb_trans_trans.TabStop = true;
            this.rb_trans_trans.Text = "Transactions";
            this.rb_trans_trans.UseVisualStyleBackColor = true;
            this.rb_trans_trans.CheckedChanged += new System.EventHandler(this.rb_trans_trans_CheckedChanged);
            // 
            // rb_trans_bulkcapture
            // 
            this.rb_trans_bulkcapture.AutoSize = true;
            this.rb_trans_bulkcapture.Location = new System.Drawing.Point(6, 271);
            this.rb_trans_bulkcapture.Name = "rb_trans_bulkcapture";
            this.rb_trans_bulkcapture.Size = new System.Drawing.Size(124, 19);
            this.rb_trans_bulkcapture.TabIndex = 47;
            this.rb_trans_bulkcapture.TabStop = true;
            this.rb_trans_bulkcapture.Text = "Bulk Capture";
            this.rb_trans_bulkcapture.UseVisualStyleBackColor = true;
            this.rb_trans_bulkcapture.CheckedChanged += new System.EventHandler(this.rb_trans_bulkcapture_CheckedChanged);
            // 
            // rb_trans_searchtrans
            // 
            this.rb_trans_searchtrans.AutoSize = true;
            this.rb_trans_searchtrans.Location = new System.Drawing.Point(6, 246);
            this.rb_trans_searchtrans.Name = "rb_trans_searchtrans";
            this.rb_trans_searchtrans.Size = new System.Drawing.Size(180, 19);
            this.rb_trans_searchtrans.TabIndex = 46;
            this.rb_trans_searchtrans.TabStop = true;
            this.rb_trans_searchtrans.Text = "Search Transactions";
            this.rb_trans_searchtrans.UseVisualStyleBackColor = true;
            this.rb_trans_searchtrans.CheckedChanged += new System.EventHandler(this.rb_trans_searchtrans_CheckedChanged);
            // 
            // rb_trans_bulkvoid
            // 
            this.rb_trans_bulkvoid.AutoSize = true;
            this.rb_trans_bulkvoid.Location = new System.Drawing.Point(6, 221);
            this.rb_trans_bulkvoid.Name = "rb_trans_bulkvoid";
            this.rb_trans_bulkvoid.Size = new System.Drawing.Size(100, 19);
            this.rb_trans_bulkvoid.TabIndex = 45;
            this.rb_trans_bulkvoid.TabStop = true;
            this.rb_trans_bulkvoid.Text = "Bulk Void";
            this.rb_trans_bulkvoid.UseVisualStyleBackColor = true;
            this.rb_trans_bulkvoid.CheckedChanged += new System.EventHandler(this.rb_trans_bulkvoid_CheckedChanged);
            // 
            // rb_trans_paymenttypes
            // 
            this.rb_trans_paymenttypes.AutoSize = true;
            this.rb_trans_paymenttypes.Location = new System.Drawing.Point(6, 196);
            this.rb_trans_paymenttypes.Name = "rb_trans_paymenttypes";
            this.rb_trans_paymenttypes.Size = new System.Drawing.Size(132, 19);
            this.rb_trans_paymenttypes.TabIndex = 44;
            this.rb_trans_paymenttypes.TabStop = true;
            this.rb_trans_paymenttypes.Text = "Payment Types";
            this.rb_trans_paymenttypes.UseVisualStyleBackColor = true;
            this.rb_trans_paymenttypes.CheckedChanged += new System.EventHandler(this.rb_trans_paymenttypes_CheckedChanged);
            // 
            // rb_trans_transtotal
            // 
            this.rb_trans_transtotal.AutoSize = true;
            this.rb_trans_transtotal.Location = new System.Drawing.Point(6, 171);
            this.rb_trans_transtotal.Name = "rb_trans_transtotal";
            this.rb_trans_transtotal.Size = new System.Drawing.Size(164, 19);
            this.rb_trans_transtotal.TabIndex = 43;
            this.rb_trans_transtotal.TabStop = true;
            this.rb_trans_transtotal.Text = "Transaction Total";
            this.rb_trans_transtotal.UseVisualStyleBackColor = true;
            this.rb_trans_transtotal.CheckedChanged += new System.EventHandler(this.rb_trans_transtotal_CheckedChanged);
            // 
            // rb_trans_refundtran
            // 
            this.rb_trans_refundtran.AutoSize = true;
            this.rb_trans_refundtran.Location = new System.Drawing.Point(6, 146);
            this.rb_trans_refundtran.Name = "rb_trans_refundtran";
            this.rb_trans_refundtran.Size = new System.Drawing.Size(172, 19);
            this.rb_trans_refundtran.TabIndex = 42;
            this.rb_trans_refundtran.TabStop = true;
            this.rb_trans_refundtran.Text = "Refund Transaction";
            this.rb_trans_refundtran.UseVisualStyleBackColor = true;
            this.rb_trans_refundtran.CheckedChanged += new System.EventHandler(this.rb_trans_refundtran_CheckedChanged);
            // 
            // rb_trans_dailysum
            // 
            this.rb_trans_dailysum.AutoSize = true;
            this.rb_trans_dailysum.Location = new System.Drawing.Point(6, 121);
            this.rb_trans_dailysum.Name = "rb_trans_dailysum";
            this.rb_trans_dailysum.Size = new System.Drawing.Size(228, 19);
            this.rb_trans_dailysum.TabIndex = 41;
            this.rb_trans_dailysum.TabStop = true;
            this.rb_trans_dailysum.Text = "Daily Transaction Summary";
            this.rb_trans_dailysum.UseVisualStyleBackColor = true;
            this.rb_trans_dailysum.CheckedChanged += new System.EventHandler(this.rb_trans_dailysum_CheckedChanged);
            // 
            // rb_trans_transcount
            // 
            this.rb_trans_transcount.AutoSize = true;
            this.rb_trans_transcount.Location = new System.Drawing.Point(6, 96);
            this.rb_trans_transcount.Name = "rb_trans_transcount";
            this.rb_trans_transcount.Size = new System.Drawing.Size(164, 19);
            this.rb_trans_transcount.TabIndex = 40;
            this.rb_trans_transcount.TabStop = true;
            this.rb_trans_transcount.Text = "Transaction Count";
            this.rb_trans_transcount.UseVisualStyleBackColor = true;
            this.rb_trans_transcount.CheckedChanged += new System.EventHandler(this.rb_trans_transcount_CheckedChanged);
            // 
            // rb_trans_Match4FDR
            // 
            this.rb_trans_Match4FDR.AutoSize = true;
            this.rb_trans_Match4FDR.Location = new System.Drawing.Point(6, 71);
            this.rb_trans_Match4FDR.Name = "rb_trans_Match4FDR";
            this.rb_trans_Match4FDR.Size = new System.Drawing.Size(340, 19);
            this.rb_trans_Match4FDR.TabIndex = 39;
            this.rb_trans_Match4FDR.TabStop = true;
            this.rb_trans_Match4FDR.Text = "Matching Transaction For FDR Chargeback";
            this.rb_trans_Match4FDR.UseVisualStyleBackColor = true;
            this.rb_trans_Match4FDR.CheckedChanged += new System.EventHandler(this.rb_trans_Match4FDR_CheckedChanged);
            // 
            // rb_trans_tran
            // 
            this.rb_trans_tran.AutoSize = true;
            this.rb_trans_tran.Location = new System.Drawing.Point(6, 46);
            this.rb_trans_tran.Name = "rb_trans_tran";
            this.rb_trans_tran.Size = new System.Drawing.Size(116, 19);
            this.rb_trans_tran.TabIndex = 38;
            this.rb_trans_tran.TabStop = true;
            this.rb_trans_tran.Text = "Transaction";
            this.rb_trans_tran.UseVisualStyleBackColor = true;
            this.rb_trans_tran.CheckedChanged += new System.EventHandler(this.rb_trans_tran_CheckedChanged);
            // 
            // rb_trans_tranwithId
            // 
            this.rb_trans_tranwithId.AutoSize = true;
            this.rb_trans_tranwithId.Location = new System.Drawing.Point(6, 21);
            this.rb_trans_tranwithId.Name = "rb_trans_tranwithId";
            this.rb_trans_tranwithId.Size = new System.Drawing.Size(300, 19);
            this.rb_trans_tranwithId.TabIndex = 37;
            this.rb_trans_tranwithId.TabStop = true;
            this.rb_trans_tranwithId.Text = "Transaction (Using Transaction Id)";
            this.rb_trans_tranwithId.UseVisualStyleBackColor = true;
            this.rb_trans_tranwithId.CheckedChanged += new System.EventHandler(this.rb_trans_tranwithId_CheckedChanged);
            // 
            // tabPage_payment
            // 
            this.tabPage_payment.Controls.Add(this.groupBox_payment);
            this.tabPage_payment.Location = new System.Drawing.Point(4, 46);
            this.tabPage_payment.Name = "tabPage_payment";
            this.tabPage_payment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_payment.Size = new System.Drawing.Size(419, 462);
            this.tabPage_payment.TabIndex = 2;
            this.tabPage_payment.Text = "Payment Service";
            this.tabPage_payment.UseVisualStyleBackColor = true;
            // 
            // groupBox_payment
            // 
            this.groupBox_payment.Controls.Add(this.bt_payment_sendcommand);
            this.groupBox_payment.Controls.Add(this.rb_savecard);
            this.groupBox_payment.Controls.Add(this.rb_deltoken);
            this.groupBox_payment.Controls.Add(this.rb_cardtrans);
            this.groupBox_payment.Controls.Add(this.rb_echeck);
            this.groupBox_payment.Controls.Add(this.rb_voidtrans);
            this.groupBox_payment.Controls.Add(this.rb_capturetrans);
            this.groupBox_payment.Controls.Add(this.rb_refundtrans);
            this.groupBox_payment.Location = new System.Drawing.Point(6, 6);
            this.groupBox_payment.Name = "groupBox_payment";
            this.groupBox_payment.Size = new System.Drawing.Size(399, 245);
            this.groupBox_payment.TabIndex = 28;
            this.groupBox_payment.TabStop = false;
            this.groupBox_payment.Text = "Payment Service";
            // 
            // bt_payment_sendcommand
            // 
            this.bt_payment_sendcommand.Location = new System.Drawing.Point(111, 199);
            this.bt_payment_sendcommand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_payment_sendcommand.Name = "bt_payment_sendcommand";
            this.bt_payment_sendcommand.Size = new System.Drawing.Size(161, 35);
            this.bt_payment_sendcommand.TabIndex = 29;
            this.bt_payment_sendcommand.Text = "Send Command";
            this.bt_payment_sendcommand.Click += new System.EventHandler(this.bt_payment_sendcommand_Click);
            // 
            // rb_savecard
            // 
            this.rb_savecard.AutoSize = true;
            this.rb_savecard.Location = new System.Drawing.Point(6, 25);
            this.rb_savecard.Name = "rb_savecard";
            this.rb_savecard.Size = new System.Drawing.Size(100, 19);
            this.rb_savecard.TabIndex = 21;
            this.rb_savecard.Text = "Save Card";
            this.rb_savecard.UseVisualStyleBackColor = true;
            this.rb_savecard.CheckedChanged += new System.EventHandler(this.rb_savecard_CheckedChanged);
            // 
            // rb_deltoken
            // 
            this.rb_deltoken.AutoSize = true;
            this.rb_deltoken.Location = new System.Drawing.Point(6, 175);
            this.rb_deltoken.Name = "rb_deltoken";
            this.rb_deltoken.Size = new System.Drawing.Size(124, 19);
            this.rb_deltoken.TabIndex = 27;
            this.rb_deltoken.Text = "Delete Token";
            this.rb_deltoken.UseVisualStyleBackColor = true;
            this.rb_deltoken.CheckedChanged += new System.EventHandler(this.rb_deltoken_CheckedChanged);
            // 
            // rb_cardtrans
            // 
            this.rb_cardtrans.AutoSize = true;
            this.rb_cardtrans.Location = new System.Drawing.Point(6, 50);
            this.rb_cardtrans.Name = "rb_cardtrans";
            this.rb_cardtrans.Size = new System.Drawing.Size(156, 19);
            this.rb_cardtrans.TabIndex = 22;
            this.rb_cardtrans.Text = "Card Transaction";
            this.rb_cardtrans.UseVisualStyleBackColor = true;
            this.rb_cardtrans.CheckedChanged += new System.EventHandler(this.rb_cardtrans_CheckedChanged);
            // 
            // rb_echeck
            // 
            this.rb_echeck.AutoSize = true;
            this.rb_echeck.Location = new System.Drawing.Point(6, 150);
            this.rb_echeck.Name = "rb_echeck";
            this.rb_echeck.Size = new System.Drawing.Size(172, 19);
            this.rb_echeck.TabIndex = 26;
            this.rb_echeck.Text = "eCheck Transaction";
            this.rb_echeck.UseVisualStyleBackColor = true;
            this.rb_echeck.CheckedChanged += new System.EventHandler(this.rb_echeck_CheckedChanged);
            // 
            // rb_voidtrans
            // 
            this.rb_voidtrans.AutoSize = true;
            this.rb_voidtrans.Location = new System.Drawing.Point(6, 75);
            this.rb_voidtrans.Name = "rb_voidtrans";
            this.rb_voidtrans.Size = new System.Drawing.Size(156, 19);
            this.rb_voidtrans.TabIndex = 23;
            this.rb_voidtrans.Text = "Void Transaction";
            this.rb_voidtrans.UseVisualStyleBackColor = true;
            this.rb_voidtrans.CheckedChanged += new System.EventHandler(this.rb_voidtrans_CheckedChanged);
            // 
            // rb_capturetrans
            // 
            this.rb_capturetrans.AutoSize = true;
            this.rb_capturetrans.Location = new System.Drawing.Point(6, 125);
            this.rb_capturetrans.Name = "rb_capturetrans";
            this.rb_capturetrans.Size = new System.Drawing.Size(180, 19);
            this.rb_capturetrans.TabIndex = 25;
            this.rb_capturetrans.Text = "Capture Transaction";
            this.rb_capturetrans.UseVisualStyleBackColor = true;
            this.rb_capturetrans.CheckedChanged += new System.EventHandler(this.rb_capturetrans_CheckedChanged);
            // 
            // rb_refundtrans
            // 
            this.rb_refundtrans.AutoSize = true;
            this.rb_refundtrans.Location = new System.Drawing.Point(6, 100);
            this.rb_refundtrans.Name = "rb_refundtrans";
            this.rb_refundtrans.Size = new System.Drawing.Size(172, 19);
            this.rb_refundtrans.TabIndex = 24;
            this.rb_refundtrans.Text = "Refund Transaction";
            this.rb_refundtrans.UseVisualStyleBackColor = true;
            this.rb_refundtrans.CheckedChanged += new System.EventHandler(this.rb_refundtrans_CheckedChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.TokenList);
            this.groupBox8.Location = new System.Drawing.Point(11, 530);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(424, 386);
            this.groupBox8.TabIndex = 39;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Token List";
            // 
            // TokenList
            // 
            this.TokenList.AllowUserToAddRows = false;
            this.TokenList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TokenList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Token});
            this.TokenList.Location = new System.Drawing.Point(6, 24);
            this.TokenList.Name = "TokenList";
            this.TokenList.RowTemplate.Height = 27;
            this.TokenList.Size = new System.Drawing.Size(412, 356);
            this.TokenList.TabIndex = 37;
            // 
            // Token
            // 
            this.Token.HeaderText = "Token";
            this.Token.Name = "Token";
            this.Token.Width = 300;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox_iframe);
            this.tabPage2.Location = new System.Drawing.Point(4, 46);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(419, 462);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Payment Service iFrame";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox_iframe
            // 
            this.groupBox_iframe.Controls.Add(this.rb_iframe_onetimetoken);
            this.groupBox_iframe.Controls.Add(this.iframe_sendcommand_btn);
            this.groupBox_iframe.Controls.Add(this.rb_iframe_runecheck);
            this.groupBox_iframe.Controls.Add(this.rb_iframe_saveecheck);
            this.groupBox_iframe.Controls.Add(this.rb_iframe_savecard);
            this.groupBox_iframe.Controls.Add(this.rb_iframe_alipay);
            this.groupBox_iframe.Controls.Add(this.rb_iframe_runtrans);
            this.groupBox_iframe.Location = new System.Drawing.Point(6, 6);
            this.groupBox_iframe.Name = "groupBox_iframe";
            this.groupBox_iframe.Size = new System.Drawing.Size(404, 246);
            this.groupBox_iframe.TabIndex = 19;
            this.groupBox_iframe.TabStop = false;
            // 
            // rb_iframe_onetimetoken
            // 
            this.rb_iframe_onetimetoken.AutoSize = true;
            this.rb_iframe_onetimetoken.Location = new System.Drawing.Point(7, 18);
            this.rb_iframe_onetimetoken.Name = "rb_iframe_onetimetoken";
            this.rb_iframe_onetimetoken.Size = new System.Drawing.Size(172, 19);
            this.rb_iframe_onetimetoken.TabIndex = 31;
            this.rb_iframe_onetimetoken.TabStop = true;
            this.rb_iframe_onetimetoken.Text = "Get One Time Token";
            this.rb_iframe_onetimetoken.UseVisualStyleBackColor = true;
            this.rb_iframe_onetimetoken.CheckedChanged += new System.EventHandler(this.rb_iframe_onetimetoken_CheckedChanged);
            // 
            // iframe_sendcommand_btn
            // 
            this.iframe_sendcommand_btn.Location = new System.Drawing.Point(85, 199);
            this.iframe_sendcommand_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iframe_sendcommand_btn.Name = "iframe_sendcommand_btn";
            this.iframe_sendcommand_btn.Size = new System.Drawing.Size(161, 35);
            this.iframe_sendcommand_btn.TabIndex = 30;
            this.iframe_sendcommand_btn.Text = "Send Command";
            this.iframe_sendcommand_btn.Click += new System.EventHandler(this.iframe_sendcommand_btn_Click);
            // 
            // rb_iframe_runecheck
            // 
            this.rb_iframe_runecheck.AutoSize = true;
            this.rb_iframe_runecheck.Location = new System.Drawing.Point(7, 147);
            this.rb_iframe_runecheck.Name = "rb_iframe_runecheck";
            this.rb_iframe_runecheck.Size = new System.Drawing.Size(172, 19);
            this.rb_iframe_runecheck.TabIndex = 4;
            this.rb_iframe_runecheck.TabStop = true;
            this.rb_iframe_runecheck.Text = "eCheck Transaction";
            this.rb_iframe_runecheck.UseVisualStyleBackColor = true;
            this.rb_iframe_runecheck.CheckedChanged += new System.EventHandler(this.rb_iframe_runecheck_CheckedChanged);
            // 
            // rb_iframe_saveecheck
            // 
            this.rb_iframe_saveecheck.AutoSize = true;
            this.rb_iframe_saveecheck.Location = new System.Drawing.Point(7, 121);
            this.rb_iframe_saveecheck.Name = "rb_iframe_saveecheck";
            this.rb_iframe_saveecheck.Size = new System.Drawing.Size(116, 19);
            this.rb_iframe_saveecheck.TabIndex = 3;
            this.rb_iframe_saveecheck.TabStop = true;
            this.rb_iframe_saveecheck.Text = "Save eCheck";
            this.rb_iframe_saveecheck.UseVisualStyleBackColor = true;
            this.rb_iframe_saveecheck.CheckedChanged += new System.EventHandler(this.rb_iframe_saveecheck_CheckedChanged);
            // 
            // rb_iframe_savecard
            // 
            this.rb_iframe_savecard.AutoSize = true;
            this.rb_iframe_savecard.Location = new System.Drawing.Point(7, 95);
            this.rb_iframe_savecard.Name = "rb_iframe_savecard";
            this.rb_iframe_savecard.Size = new System.Drawing.Size(100, 19);
            this.rb_iframe_savecard.TabIndex = 2;
            this.rb_iframe_savecard.TabStop = true;
            this.rb_iframe_savecard.Text = "Save Card";
            this.rb_iframe_savecard.UseVisualStyleBackColor = true;
            this.rb_iframe_savecard.CheckedChanged += new System.EventHandler(this.rb_iframe_savecard_CheckedChanged);
            // 
            // rb_iframe_alipay
            // 
            this.rb_iframe_alipay.AutoSize = true;
            this.rb_iframe_alipay.Location = new System.Drawing.Point(7, 69);
            this.rb_iframe_alipay.Name = "rb_iframe_alipay";
            this.rb_iframe_alipay.Size = new System.Drawing.Size(172, 19);
            this.rb_iframe_alipay.TabIndex = 1;
            this.rb_iframe_alipay.TabStop = true;
            this.rb_iframe_alipay.Text = "Alipay Transaction";
            this.rb_iframe_alipay.UseVisualStyleBackColor = true;
            this.rb_iframe_alipay.CheckedChanged += new System.EventHandler(this.rb_iframe_alipay_CheckedChanged);
            // 
            // rb_iframe_runtrans
            // 
            this.rb_iframe_runtrans.AutoSize = true;
            this.rb_iframe_runtrans.Location = new System.Drawing.Point(7, 43);
            this.rb_iframe_runtrans.Name = "rb_iframe_runtrans";
            this.rb_iframe_runtrans.Size = new System.Drawing.Size(212, 19);
            this.rb_iframe_runtrans.TabIndex = 0;
            this.rb_iframe_runtrans.TabStop = true;
            this.rb_iframe_runtrans.Text = "Credit Card Transaction";
            this.rb_iframe_runtrans.UseVisualStyleBackColor = true;
            this.rb_iframe_runtrans.CheckedChanged += new System.EventHandler(this.rb_iframe_runtrans_CheckedChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ClientSideToken_Btn);
            this.tabPage1.Location = new System.Drawing.Point(4, 46);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(419, 462);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Client Side Token";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage_payment);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(427, 512);
            this.tabControl1.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TransFromNexioList);
            this.groupBox1.Location = new System.Drawing.Point(445, 410);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 506);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nexio Transaction List";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.URLBox);
            this.groupBox2.Location = new System.Drawing.Point(445, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(980, 50);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "URL";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PostDataBox);
            this.groupBox3.Location = new System.Drawing.Point(873, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(552, 188);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Post Data";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Resultbox);
            this.groupBox4.Location = new System.Drawing.Point(873, 261);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(552, 615);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Response Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 924);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.clear_btn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Nexio Pay Sample";
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TransList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransFromNexioList)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox_trans.ResumeLayout(false);
            this.groupBox_trans.PerformLayout();
            this.tabPage_payment.ResumeLayout(false);
            this.groupBox_payment.ResumeLayout(false);
            this.groupBox_payment.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TokenList)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox_iframe.ResumeLayout(false);
            this.groupBox_iframe.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox Resultbox;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button ClientSideToken_Btn;
        private System.Windows.Forms.RichTextBox PostDataBox;
        private System.Windows.Forms.GroupBox groupBox9;
        internal System.Windows.Forms.DataGridView TransList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        internal System.Windows.Forms.RichTextBox URLBox;
        internal System.Windows.Forms.DataGridView TransFromNexioList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox_trans;
        private System.Windows.Forms.Button trans_sendcommand_btn;
        private System.Windows.Forms.RadioButton rb_trans_summary;
        private System.Windows.Forms.RadioButton rb_trans_voidtrans;
        private System.Windows.Forms.RadioButton rb_trans_capturetrans;
        private System.Windows.Forms.RadioButton rb_trans_trans;
        private System.Windows.Forms.RadioButton rb_trans_bulkcapture;
        private System.Windows.Forms.RadioButton rb_trans_searchtrans;
        private System.Windows.Forms.RadioButton rb_trans_bulkvoid;
        private System.Windows.Forms.RadioButton rb_trans_paymenttypes;
        private System.Windows.Forms.RadioButton rb_trans_transtotal;
        private System.Windows.Forms.RadioButton rb_trans_refundtran;
        private System.Windows.Forms.RadioButton rb_trans_dailysum;
        private System.Windows.Forms.RadioButton rb_trans_transcount;
        private System.Windows.Forms.RadioButton rb_trans_Match4FDR;
        private System.Windows.Forms.RadioButton rb_trans_tran;
        private System.Windows.Forms.RadioButton rb_trans_tranwithId;
        private System.Windows.Forms.TabPage tabPage_payment;
        private System.Windows.Forms.GroupBox groupBox8;
        internal System.Windows.Forms.DataGridView TokenList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Token;
        private System.Windows.Forms.GroupBox groupBox_payment;
        private System.Windows.Forms.Button bt_payment_sendcommand;
        internal System.Windows.Forms.RadioButton rb_savecard;
        private System.Windows.Forms.RadioButton rb_deltoken;
        private System.Windows.Forms.RadioButton rb_cardtrans;
        private System.Windows.Forms.RadioButton rb_echeck;
        private System.Windows.Forms.RadioButton rb_voidtrans;
        private System.Windows.Forms.RadioButton rb_capturetrans;
        private System.Windows.Forms.RadioButton rb_refundtrans;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox_iframe;
        private System.Windows.Forms.Button iframe_sendcommand_btn;
        private System.Windows.Forms.RadioButton rb_iframe_runecheck;
        private System.Windows.Forms.RadioButton rb_iframe_saveecheck;
        private System.Windows.Forms.RadioButton rb_iframe_savecard;
        private System.Windows.Forms.RadioButton rb_iframe_alipay;
        private System.Windows.Forms.RadioButton rb_iframe_runtrans;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rb_iframe_onetimetoken;
    }
}

