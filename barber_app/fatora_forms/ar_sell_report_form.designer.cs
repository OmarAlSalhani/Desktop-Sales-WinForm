namespace ClientApp.fatora_forms
{
    partial class ar_sell_report_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ar_sell_report_form));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.fill_cb_worker = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupControl17 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.excel_btn = new DevExpress.XtraEditors.SimpleButton();
            this.pdf_btn = new DevExpress.XtraEditors.SimpleButton();
            this.word_btn = new DevExpress.XtraEditors.SimpleButton();
            this.print_btn = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.show_report_btn = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.customer_cbx = new DevExpress.XtraEditors.CheckEdit();
            this.customer_name_cb = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.username_cbx = new DevExpress.XtraEditors.CheckEdit();
            this.username_cb = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl8 = new DevExpress.XtraEditors.GroupControl();
            this.id_barcode_tb = new DevExpress.XtraEditors.ButtonEdit();
            this.id_barcode_radio = new System.Windows.Forms.RadioButton();
            this.groupControl7 = new DevExpress.XtraEditors.GroupControl();
            this.date_cbx = new DevExpress.XtraEditors.CheckEdit();
            this.first_date = new DevExpress.XtraEditors.DateEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.last_date = new DevExpress.XtraEditors.DateEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl17)).BeginInit();
            this.groupControl17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer_cbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_name_cb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.username_cbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.username_cb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).BeginInit();
            this.groupControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.id_barcode_tb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).BeginInit();
            this.groupControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_cbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1140, 38);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(501, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "تقرير فواتير المبيعات";
            // 
            // fill_cb_worker
            // 
            this.fill_cb_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.fill_cb_worker_DoWork);
            this.fill_cb_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.fill_cb_worker_RunWorkerCompleted);
            // 
            // groupControl17
            // 
            this.groupControl17.AppearanceCaption.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.groupControl17.AppearanceCaption.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupControl17.AppearanceCaption.Options.UseFont = true;
            this.groupControl17.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl17.Controls.Add(this.simpleButton3);
            this.groupControl17.Controls.Add(this.simpleButton2);
            this.groupControl17.Controls.Add(this.simpleButton1);
            this.groupControl17.Controls.Add(this.excel_btn);
            this.groupControl17.Controls.Add(this.pdf_btn);
            this.groupControl17.Controls.Add(this.word_btn);
            this.groupControl17.Controls.Add(this.print_btn);
            this.groupControl17.Location = new System.Drawing.Point(0, 479);
            this.groupControl17.Name = "groupControl17";
            this.groupControl17.Size = new System.Drawing.Size(1138, 77);
            this.groupControl17.TabIndex = 69;
            this.groupControl17.Text = "العمليات المتاحة وخيارات الطباعة والتصدير";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.simpleButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.simpleButton3.Location = new System.Drawing.Point(157, 34);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(126, 39);
            this.simpleButton3.TabIndex = 9;
            this.simpleButton3.Text = "طباعة مباشرة";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(287, 34);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(126, 39);
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Text = "معاينة الطباعة";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = global::ClientApp.Properties.Resources.a_show_report;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.simpleButton1.Location = new System.Drawing.Point(856, 34);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(124, 39);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "بيانات الفاتورة";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // excel_btn
            // 
            this.excel_btn.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.excel_btn.Appearance.Options.UseFont = true;
            this.excel_btn.ImageOptions.Image = global::ClientApp.Properties.Resources.a_excel;
            this.excel_btn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.excel_btn.Location = new System.Drawing.Point(526, 34);
            this.excel_btn.Name = "excel_btn";
            this.excel_btn.Size = new System.Drawing.Size(105, 39);
            this.excel_btn.TabIndex = 6;
            this.excel_btn.Text = "إكسل";
            this.excel_btn.Click += new System.EventHandler(this.excel_btn_Click);
            // 
            // pdf_btn
            // 
            this.pdf_btn.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.pdf_btn.Appearance.Options.UseFont = true;
            this.pdf_btn.ImageOptions.Image = global::ClientApp.Properties.Resources.a_pdf;
            this.pdf_btn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.pdf_btn.Location = new System.Drawing.Point(417, 34);
            this.pdf_btn.Name = "pdf_btn";
            this.pdf_btn.Size = new System.Drawing.Size(105, 39);
            this.pdf_btn.TabIndex = 3;
            this.pdf_btn.Text = "PDF";
            this.pdf_btn.Click += new System.EventHandler(this.pdf_btn_Click);
            // 
            // word_btn
            // 
            this.word_btn.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.word_btn.Appearance.Options.UseFont = true;
            this.word_btn.ImageOptions.Image = global::ClientApp.Properties.Resources.a_word;
            this.word_btn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.word_btn.Location = new System.Drawing.Point(635, 34);
            this.word_btn.Name = "word_btn";
            this.word_btn.Size = new System.Drawing.Size(105, 39);
            this.word_btn.TabIndex = 5;
            this.word_btn.Text = "وورد";
            this.word_btn.Click += new System.EventHandler(this.word_btn_Click);
            // 
            // print_btn
            // 
            this.print_btn.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.print_btn.Appearance.Options.UseFont = true;
            this.print_btn.ImageOptions.Image = global::ClientApp.Properties.Resources.a_print;
            this.print_btn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.print_btn.Location = new System.Drawing.Point(745, 34);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(105, 39);
            this.print_btn.TabIndex = 4;
            this.print_btn.Text = "طباعة";
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl3.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupControl3.Appearance.Options.UseBackColor = true;
            this.groupControl3.AppearanceCaption.BackColor = System.Drawing.Color.Lime;
            this.groupControl3.AppearanceCaption.BackColor2 = System.Drawing.Color.Lime;
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.groupControl3.AppearanceCaption.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupControl3.AppearanceCaption.Options.UseBackColor = true;
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControl3.Controls.Add(this.show_report_btn);
            this.groupControl3.Location = new System.Drawing.Point(1028, 41);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(110, 65);
            this.groupControl3.TabIndex = 68;
            this.groupControl3.Text = "بحث";
            // 
            // show_report_btn
            // 
            this.show_report_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.show_report_btn.Appearance.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.show_report_btn.Appearance.Options.UseFont = true;
            this.show_report_btn.ImageOptions.Image = global::ClientApp.Properties.Resources.a_show_report;
            this.show_report_btn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.show_report_btn.Location = new System.Drawing.Point(9, 32);
            this.show_report_btn.Name = "show_report_btn";
            this.show_report_btn.Size = new System.Drawing.Size(91, 31);
            this.show_report_btn.TabIndex = 38;
            this.show_report_btn.Text = "عرض";
            this.show_report_btn.Click += new System.EventHandler(this.show_report_btn_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.BackColor = System.Drawing.Color.Lime;
            this.groupControl1.AppearanceCaption.BackColor2 = System.Drawing.Color.Lime;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupControl1.AppearanceCaption.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControl1.Controls.Add(this.customer_cbx);
            this.groupControl1.Controls.Add(this.customer_name_cb);
            this.groupControl1.Location = new System.Drawing.Point(809, 41);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(216, 65);
            this.groupControl1.TabIndex = 66;
            this.groupControl1.Text = "بحث حسب إسم العميل";
            // 
            // customer_cbx
            // 
            this.customer_cbx.Location = new System.Drawing.Point(1, 32);
            this.customer_cbx.Name = "customer_cbx";
            this.customer_cbx.Properties.Appearance.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.customer_cbx.Properties.Appearance.Options.UseFont = true;
            this.customer_cbx.Properties.Caption = "بحث";
            this.customer_cbx.Size = new System.Drawing.Size(51, 28);
            this.customer_cbx.TabIndex = 41;
            // 
            // customer_name_cb
            // 
            this.customer_name_cb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customer_name_cb.Location = new System.Drawing.Point(55, 34);
            this.customer_name_cb.Name = "customer_name_cb";
            this.customer_name_cb.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.customer_name_cb.Properties.AdvancedModeOptions.AllowSelectionAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.customer_name_cb.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.customer_name_cb.Properties.Appearance.Options.UseFont = true;
            this.customer_name_cb.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.customer_name_cb.Properties.AppearanceDisabled.Options.UseFont = true;
            this.customer_name_cb.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.customer_name_cb.Properties.AppearanceDropDown.Options.UseFont = true;
            this.customer_name_cb.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.customer_name_cb.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.customer_name_cb.Properties.AppearanceFocused.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.customer_name_cb.Properties.AppearanceFocused.Options.UseFont = true;
            this.customer_name_cb.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.customer_name_cb.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.customer_name_cb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.customer_name_cb.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Standard;
            this.customer_name_cb.Properties.NullText = "";
            this.customer_name_cb.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest;
            this.customer_name_cb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.customer_name_cb.Size = new System.Drawing.Size(158, 26);
            this.customer_name_cb.TabIndex = 39;
            // 
            // groupControl6
            // 
            this.groupControl6.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl6.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupControl6.Appearance.Options.UseBackColor = true;
            this.groupControl6.AppearanceCaption.BackColor = System.Drawing.Color.Lime;
            this.groupControl6.AppearanceCaption.BackColor2 = System.Drawing.Color.Lime;
            this.groupControl6.AppearanceCaption.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.groupControl6.AppearanceCaption.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupControl6.AppearanceCaption.Options.UseBackColor = true;
            this.groupControl6.AppearanceCaption.Options.UseFont = true;
            this.groupControl6.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControl6.Controls.Add(this.username_cbx);
            this.groupControl6.Controls.Add(this.username_cb);
            this.groupControl6.Location = new System.Drawing.Point(562, 41);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(245, 65);
            this.groupControl6.TabIndex = 65;
            this.groupControl6.Text = "بحث حسب إسم المستخدم";
            // 
            // username_cbx
            // 
            this.username_cbx.Location = new System.Drawing.Point(2, 34);
            this.username_cbx.Name = "username_cbx";
            this.username_cbx.Properties.Appearance.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.username_cbx.Properties.Appearance.Options.UseFont = true;
            this.username_cbx.Properties.Caption = "بحث";
            this.username_cbx.Size = new System.Drawing.Size(53, 28);
            this.username_cbx.TabIndex = 41;
            // 
            // username_cb
            // 
            this.username_cb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username_cb.Location = new System.Drawing.Point(57, 35);
            this.username_cb.Name = "username_cb";
            this.username_cb.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.username_cb.Properties.AdvancedModeOptions.AllowSelectionAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.username_cb.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.username_cb.Properties.Appearance.Options.UseFont = true;
            this.username_cb.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.username_cb.Properties.AppearanceDisabled.Options.UseFont = true;
            this.username_cb.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.username_cb.Properties.AppearanceDropDown.Options.UseFont = true;
            this.username_cb.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.username_cb.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.username_cb.Properties.AppearanceFocused.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.username_cb.Properties.AppearanceFocused.Options.UseFont = true;
            this.username_cb.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.username_cb.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.username_cb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.username_cb.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Standard;
            this.username_cb.Properties.NullText = "";
            this.username_cb.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest;
            this.username_cb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.username_cb.Size = new System.Drawing.Size(180, 26);
            this.username_cb.TabIndex = 39;
            // 
            // groupControl8
            // 
            this.groupControl8.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl8.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupControl8.Appearance.Options.UseBackColor = true;
            this.groupControl8.AppearanceCaption.BackColor = System.Drawing.Color.Lime;
            this.groupControl8.AppearanceCaption.BackColor2 = System.Drawing.Color.Lime;
            this.groupControl8.AppearanceCaption.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.groupControl8.AppearanceCaption.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupControl8.AppearanceCaption.Options.UseBackColor = true;
            this.groupControl8.AppearanceCaption.Options.UseFont = true;
            this.groupControl8.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControl8.Controls.Add(this.id_barcode_tb);
            this.groupControl8.Controls.Add(this.id_barcode_radio);
            this.groupControl8.Location = new System.Drawing.Point(373, 41);
            this.groupControl8.Name = "groupControl8";
            this.groupControl8.Size = new System.Drawing.Size(187, 65);
            this.groupControl8.TabIndex = 64;
            this.groupControl8.Text = "بحث حسب رقم الفاتورة";
            // 
            // id_barcode_tb
            // 
            this.id_barcode_tb.EditValue = "";
            this.id_barcode_tb.Location = new System.Drawing.Point(67, 33);
            this.id_barcode_tb.Name = "id_barcode_tb";
            this.id_barcode_tb.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.id_barcode_tb.Properties.AdvancedModeOptions.AllowSelectionAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.id_barcode_tb.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.id_barcode_tb.Properties.Appearance.Options.UseFont = true;
            this.id_barcode_tb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.id_barcode_tb.Size = new System.Drawing.Size(114, 28);
            this.id_barcode_tb.TabIndex = 45;
            // 
            // id_barcode_radio
            // 
            this.id_barcode_radio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.id_barcode_radio.AutoSize = true;
            this.id_barcode_radio.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.id_barcode_radio.Location = new System.Drawing.Point(5, 33);
            this.id_barcode_radio.Name = "id_barcode_radio";
            this.id_barcode_radio.Size = new System.Drawing.Size(56, 28);
            this.id_barcode_radio.TabIndex = 43;
            this.id_barcode_radio.TabStop = true;
            this.id_barcode_radio.Text = "بحث";
            this.id_barcode_radio.UseVisualStyleBackColor = true;
            this.id_barcode_radio.CheckedChanged += new System.EventHandler(this.id_barcode_radio_CheckedChanged);
            // 
            // groupControl7
            // 
            this.groupControl7.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl7.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupControl7.Appearance.Options.UseBackColor = true;
            this.groupControl7.AppearanceCaption.BackColor = System.Drawing.Color.Lime;
            this.groupControl7.AppearanceCaption.BackColor2 = System.Drawing.Color.Lime;
            this.groupControl7.AppearanceCaption.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.groupControl7.AppearanceCaption.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupControl7.AppearanceCaption.Options.UseBackColor = true;
            this.groupControl7.AppearanceCaption.Options.UseFont = true;
            this.groupControl7.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControl7.Controls.Add(this.date_cbx);
            this.groupControl7.Controls.Add(this.first_date);
            this.groupControl7.Controls.Add(this.label6);
            this.groupControl7.Controls.Add(this.last_date);
            this.groupControl7.Controls.Add(this.label7);
            this.groupControl7.Location = new System.Drawing.Point(2, 41);
            this.groupControl7.Name = "groupControl7";
            this.groupControl7.Size = new System.Drawing.Size(367, 65);
            this.groupControl7.TabIndex = 63;
            this.groupControl7.Text = "بحث حسب التاريخ";
            // 
            // date_cbx
            // 
            this.date_cbx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_cbx.EditValue = true;
            this.date_cbx.Location = new System.Drawing.Point(13, 36);
            this.date_cbx.Name = "date_cbx";
            this.date_cbx.Properties.Appearance.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.date_cbx.Properties.Appearance.Options.UseFont = true;
            this.date_cbx.Properties.Caption = "بحث";
            this.date_cbx.Size = new System.Drawing.Size(48, 28);
            this.date_cbx.TabIndex = 51;
            this.date_cbx.CheckedChanged += new System.EventHandler(this.date_cbx_CheckedChanged);
            // 
            // first_date
            // 
            this.first_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.first_date.EditValue = new System.DateTime(2021, 3, 8, 0, 25, 46, 0);
            this.first_date.Location = new System.Drawing.Point(206, 37);
            this.first_date.Name = "first_date";
            this.first_date.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.first_date.Properties.Appearance.Options.UseFont = true;
            this.first_date.Properties.BeepOnError = false;
            this.first_date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.first_date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.first_date.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            this.first_date.Properties.MaskSettings.Set("mask", "dd-MM-yyyy");
            this.first_date.Properties.UseMaskAsDisplayFormat = true;
            this.first_date.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.first_date.Size = new System.Drawing.Size(117, 26);
            this.first_date.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label6.Location = new System.Drawing.Point(324, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 24);
            this.label6.TabIndex = 47;
            this.label6.Text = "من";
            // 
            // last_date
            // 
            this.last_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.last_date.EditValue = new System.DateTime(2021, 3, 8, 0, 25, 46, 0);
            this.last_date.Location = new System.Drawing.Point(67, 37);
            this.last_date.Name = "last_date";
            this.last_date.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.last_date.Properties.Appearance.Options.UseFont = true;
            this.last_date.Properties.BeepOnError = false;
            this.last_date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.last_date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.last_date.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            this.last_date.Properties.MaskSettings.Set("mask", "dd-MM-yyyy");
            this.last_date.Properties.UseMaskAsDisplayFormat = true;
            this.last_date.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.last_date.Size = new System.Drawing.Size(108, 26);
            this.last_date.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label7.Location = new System.Drawing.Point(175, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 24);
            this.label7.TabIndex = 48;
            this.label7.Text = "إلى";
            // 
            // gridControl2
            // 
            this.gridControl2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridControl2.Location = new System.Drawing.Point(2, 110);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1136, 364);
            this.gridControl2.TabIndex = 62;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.FocusedCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gridView2.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(209)))));
            this.gridView2.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(209)))));
            this.gridView2.Appearance.FocusedRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView2.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridView2.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Appearance.Row.Options.UseTextOptions = true;
            this.gridView2.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(209)))));
            this.gridView2.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(209)))));
            this.gridView2.Appearance.SelectedRow.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView2.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.gridView2.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView2.OptionsBehavior.AllowSortAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView2.OptionsBehavior.UnboundColumnExpressionEditorMode = DevExpress.XtraEditors.ExpressionEditorMode.AutoComplete;
            this.gridView2.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            this.gridView2.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.True;
            this.gridView2.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.True;
            this.gridView2.OptionsFind.AllowFindPanel = false;
            this.gridView2.OptionsFind.AlwaysVisible = true;
            this.gridView2.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridView2.OptionsFind.FindNullPrompt = "ابدأ بكتابة النص لبدء البحث";
            this.gridView2.OptionsFind.HighlightFindResults = false;
            this.gridView2.OptionsFind.SearchInPreview = true;
            this.gridView2.OptionsFind.ShowClearButton = false;
            this.gridView2.OptionsFind.ShowFindButton = false;
            this.gridView2.OptionsImageLoad.AnimationType = DevExpress.Utils.ImageContentAnimationType.Slide;
            this.gridView2.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView2.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.gridView2.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator;
            // 
            // ar_sell_report_form
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 556);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl8);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl6);
            this.Controls.Add(this.groupControl7);
            this.Controls.Add(this.groupControl17);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.gridControl2);
            this.MaximizeBox = false;
            this.Name = "ar_sell_report_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Load += new System.EventHandler(this.ar_sell_report_form_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl17)).EndInit();
            this.groupControl17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customer_cbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_name_cb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.username_cbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.username_cb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).EndInit();
            this.groupControl8.ResumeLayout(false);
            this.groupControl8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.id_barcode_tb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).EndInit();
            this.groupControl7.ResumeLayout(false);
            this.groupControl7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_cbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker fill_cb_worker;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevExpress.XtraEditors.GroupControl groupControl17;
        private DevExpress.XtraEditors.SimpleButton excel_btn;
        private DevExpress.XtraEditors.SimpleButton pdf_btn;
        private DevExpress.XtraEditors.SimpleButton word_btn;
        private DevExpress.XtraEditors.SimpleButton print_btn;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton show_report_btn;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit customer_cbx;
        private DevExpress.XtraEditors.LookUpEdit customer_name_cb;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.CheckEdit username_cbx;
        private DevExpress.XtraEditors.LookUpEdit username_cb;
        private DevExpress.XtraEditors.GroupControl groupControl8;
        private DevExpress.XtraEditors.ButtonEdit id_barcode_tb;
        private System.Windows.Forms.RadioButton id_barcode_radio;
        private DevExpress.XtraEditors.GroupControl groupControl7;
        private DevExpress.XtraEditors.CheckEdit date_cbx;
        private DevExpress.XtraEditors.DateEdit first_date;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.DateEdit last_date;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}