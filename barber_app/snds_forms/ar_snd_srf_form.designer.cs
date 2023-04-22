namespace ClientApp.n_snds_forms.ar
{
    partial class ar_snd_srf_form
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.fill_cb_worker = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.snd_date_dtp = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.id_tb = new DevExpress.XtraEditors.ButtonEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.notes_textbox = new DevExpress.XtraEditors.ButtonEdit();
            this.value_textbox = new DevExpress.XtraEditors.ButtonEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.pay_type_cb = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.customer_name_cb = new DevExpress.XtraEditors.ComboBoxEdit();
            this.next_btn = new DevExpress.XtraEditors.SimpleButton();
            this.last_btn = new DevExpress.XtraEditors.SimpleButton();
            this.first_btn = new DevExpress.XtraEditors.SimpleButton();
            this.prev_btn = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl9 = new DevExpress.XtraEditors.GroupControl();
            this.update_btn = new DevExpress.XtraEditors.SimpleButton();
            this.save_btn = new DevExpress.XtraEditors.SimpleButton();
            this.new_btn = new DevExpress.XtraEditors.SimpleButton();
            this.delete_btn = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.snd_date_dtp.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snd_date_dtp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id_tb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notes_textbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_textbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pay_type_cb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_name_cb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl9)).BeginInit();
            this.groupControl9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(606, 38);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(265, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "سند صرف";
            // 
            // fill_cb_worker
            // 
            this.fill_cb_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.fill_cb_worker_DoWork);
            this.fill_cb_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.fill_cb_worker_RunWorkerCompleted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(501, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "العميل";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label8.Location = new System.Drawing.Point(127, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "المبلغ";
            // 
            // snd_date_dtp
            // 
            this.snd_date_dtp.EditValue = new System.DateTime(2021, 3, 25, 23, 59, 59, 0);
            this.snd_date_dtp.EnterMoveNextControl = true;
            this.snd_date_dtp.Location = new System.Drawing.Point(176, 40);
            this.snd_date_dtp.Name = "snd_date_dtp";
            this.snd_date_dtp.Properties.Appearance.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.snd_date_dtp.Properties.Appearance.Options.UseFont = true;
            this.snd_date_dtp.Properties.BeepOnError = false;
            this.snd_date_dtp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.snd_date_dtp.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.snd_date_dtp.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            this.snd_date_dtp.Properties.MaskSettings.Set("mask", "dd-MM-yyyy");
            this.snd_date_dtp.Properties.UseMaskAsDisplayFormat = true;
            this.snd_date_dtp.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.snd_date_dtp.Size = new System.Drawing.Size(132, 30);
            this.snd_date_dtp.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(310, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "تاريخ السند";
            // 
            // id_tb
            // 
            this.id_tb.EditValue = "";
            this.id_tb.Enabled = false;
            this.id_tb.Location = new System.Drawing.Point(397, 38);
            this.id_tb.Name = "id_tb";
            this.id_tb.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.id_tb.Properties.AdvancedModeOptions.AllowSelectionAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.id_tb.Properties.Appearance.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.id_tb.Properties.Appearance.Options.UseFont = true;
            this.id_tb.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.id_tb.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.id_tb.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.id_tb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.id_tb.Properties.ReadOnly = true;
            this.id_tb.Size = new System.Drawing.Size(102, 32);
            this.id_tb.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label9.Location = new System.Drawing.Point(503, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "البيان";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(500, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "رقم السند";
            // 
            // notes_textbox
            // 
            this.notes_textbox.EditValue = "";
            this.notes_textbox.EnterMoveNextControl = true;
            this.notes_textbox.Location = new System.Drawing.Point(24, 114);
            this.notes_textbox.Name = "notes_textbox";
            this.notes_textbox.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.notes_textbox.Properties.AdvancedModeOptions.AllowSelectionAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.notes_textbox.Properties.Appearance.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.notes_textbox.Properties.Appearance.Options.UseFont = true;
            this.notes_textbox.Properties.Appearance.Options.UseTextOptions = true;
            this.notes_textbox.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.notes_textbox.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.notes_textbox.Properties.BeepOnError = false;
            this.notes_textbox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.notes_textbox.Size = new System.Drawing.Size(475, 32);
            this.notes_textbox.TabIndex = 5;
            // 
            // value_textbox
            // 
            this.value_textbox.EditValue = "0";
            this.value_textbox.EnterMoveNextControl = true;
            this.value_textbox.Location = new System.Drawing.Point(24, 38);
            this.value_textbox.Name = "value_textbox";
            this.value_textbox.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.value_textbox.Properties.AdvancedModeOptions.AllowSelectionAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.value_textbox.Properties.Appearance.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.value_textbox.Properties.Appearance.Options.UseFont = true;
            this.value_textbox.Properties.Appearance.Options.UseTextOptions = true;
            this.value_textbox.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.value_textbox.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.value_textbox.Properties.BeepOnError = false;
            this.value_textbox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.value_textbox.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.value_textbox.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.value_textbox.Properties.MaskSettings.Set("mask", "n");
            this.value_textbox.Properties.NullText = "0";
            this.value_textbox.Properties.NullValuePrompt = "0";
            this.value_textbox.Properties.UseMaskAsDisplayFormat = true;
            this.value_textbox.Size = new System.Drawing.Size(105, 32);
            this.value_textbox.TabIndex = 4;
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.AppearanceCaption.BackColor = System.Drawing.Color.Lime;
            this.groupControl2.AppearanceCaption.BackColor2 = System.Drawing.Color.Lime;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupControl2.AppearanceCaption.Options.UseBackColor = true;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControl2.Controls.Add(this.pay_type_cb);
            this.groupControl2.Controls.Add(this.label5);
            this.groupControl2.Controls.Add(this.customer_name_cb);
            this.groupControl2.Controls.Add(this.value_textbox);
            this.groupControl2.Controls.Add(this.notes_textbox);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.label9);
            this.groupControl2.Controls.Add(this.id_tb);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.snd_date_dtp);
            this.groupControl2.Controls.Add(this.label8);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Location = new System.Drawing.Point(3, 41);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(600, 160);
            this.groupControl2.TabIndex = 13;
            this.groupControl2.Text = "البيانات الأساسية";
            // 
            // pay_type_cb
            // 
            this.pay_type_cb.EditValue = "كاش";
            this.pay_type_cb.EnterMoveNextControl = true;
            this.pay_type_cb.Location = new System.Drawing.Point(24, 77);
            this.pay_type_cb.Name = "pay_type_cb";
            this.pay_type_cb.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.pay_type_cb.Properties.AdvancedModeOptions.AllowSelectionAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.pay_type_cb.Properties.Appearance.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.pay_type_cb.Properties.Appearance.Options.UseFont = true;
            this.pay_type_cb.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.pay_type_cb.Properties.AppearanceDropDown.Options.UseFont = true;
            this.pay_type_cb.Properties.AppearanceFocused.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.pay_type_cb.Properties.AppearanceFocused.Options.UseFont = true;
            this.pay_type_cb.Properties.AppearanceItemSelected.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.pay_type_cb.Properties.AppearanceItemSelected.Options.UseFont = true;
            this.pay_type_cb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.pay_type_cb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.pay_type_cb.Properties.Items.AddRange(new object[] {
            "كاش",
            "شبكة",
            "آجل"});
            this.pay_type_cb.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.pay_type_cb.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.base_unit_cb_Properties_ButtonClick);
            this.pay_type_cb.Size = new System.Drawing.Size(153, 32);
            this.pay_type_cb.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label5.Location = new System.Drawing.Point(179, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 24);
            this.label5.TabIndex = 44;
            this.label5.Text = "طريقة الصرف";
            // 
            // customer_name_cb
            // 
            this.customer_name_cb.EditValue = "";
            this.customer_name_cb.EnterMoveNextControl = true;
            this.customer_name_cb.Location = new System.Drawing.Point(283, 76);
            this.customer_name_cb.Name = "customer_name_cb";
            this.customer_name_cb.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.customer_name_cb.Properties.AdvancedModeOptions.AllowSelectionAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.customer_name_cb.Properties.Appearance.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.customer_name_cb.Properties.Appearance.Options.UseFont = true;
            this.customer_name_cb.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.customer_name_cb.Properties.AppearanceDisabled.Options.UseFont = true;
            this.customer_name_cb.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.customer_name_cb.Properties.AppearanceDropDown.Options.UseFont = true;
            this.customer_name_cb.Properties.AppearanceFocused.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.customer_name_cb.Properties.AppearanceFocused.Options.UseFont = true;
            this.customer_name_cb.Properties.AppearanceItemDisabled.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.customer_name_cb.Properties.AppearanceItemDisabled.Options.UseFont = true;
            this.customer_name_cb.Properties.AppearanceItemHighlight.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.customer_name_cb.Properties.AppearanceItemHighlight.Options.UseFont = true;
            this.customer_name_cb.Properties.AppearanceItemSelected.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.customer_name_cb.Properties.AppearanceItemSelected.Options.UseFont = true;
            this.customer_name_cb.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.customer_name_cb.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.customer_name_cb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.customer_name_cb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.customer_name_cb.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.base_unit_cb_Properties_ButtonClick);
            this.customer_name_cb.Size = new System.Drawing.Size(216, 32);
            this.customer_name_cb.TabIndex = 43;
            // 
            // next_btn
            // 
            this.next_btn.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.next_btn.Appearance.Options.UseFont = true;
            this.next_btn.ImageOptions.Image = global::ClientApp.Properties.Resources.a_next;
            this.next_btn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.next_btn.Location = new System.Drawing.Point(310, 35);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(90, 39);
            this.next_btn.TabIndex = 6;
            this.next_btn.Text = "التالي";
            this.next_btn.Click += new System.EventHandler(this.second_btn_Click);
            // 
            // last_btn
            // 
            this.last_btn.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.last_btn.Appearance.Options.UseFont = true;
            this.last_btn.ImageOptions.Image = global::ClientApp.Properties.Resources.a_last;
            this.last_btn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.last_btn.Location = new System.Drawing.Point(133, 34);
            this.last_btn.Name = "last_btn";
            this.last_btn.Size = new System.Drawing.Size(81, 39);
            this.last_btn.TabIndex = 4;
            this.last_btn.Text = "الأخير";
            this.last_btn.Click += new System.EventHandler(this.last_btn_Click);
            // 
            // first_btn
            // 
            this.first_btn.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.first_btn.Appearance.Options.UseFont = true;
            this.first_btn.ImageOptions.Image = global::ClientApp.Properties.Resources.a_first;
            this.first_btn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.first_btn.Location = new System.Drawing.Point(406, 35);
            this.first_btn.Name = "first_btn";
            this.first_btn.Size = new System.Drawing.Size(81, 39);
            this.first_btn.TabIndex = 5;
            this.first_btn.Text = "الأول";
            this.first_btn.Click += new System.EventHandler(this.first_btn_Click);
            // 
            // prev_btn
            // 
            this.prev_btn.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.prev_btn.Appearance.Options.UseFont = true;
            this.prev_btn.ImageOptions.Image = global::ClientApp.Properties.Resources.a_prev;
            this.prev_btn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.prev_btn.Location = new System.Drawing.Point(217, 34);
            this.prev_btn.Name = "prev_btn";
            this.prev_btn.Size = new System.Drawing.Size(90, 39);
            this.prev_btn.TabIndex = 7;
            this.prev_btn.Text = "السابق";
            this.prev_btn.Click += new System.EventHandler(this.prev_btn_Click);
            // 
            // groupControl9
            // 
            this.groupControl9.AppearanceCaption.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.groupControl9.AppearanceCaption.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupControl9.AppearanceCaption.Options.UseFont = true;
            this.groupControl9.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl9.Controls.Add(this.prev_btn);
            this.groupControl9.Controls.Add(this.first_btn);
            this.groupControl9.Controls.Add(this.last_btn);
            this.groupControl9.Controls.Add(this.next_btn);
            this.groupControl9.Location = new System.Drawing.Point(3, 204);
            this.groupControl9.Name = "groupControl9";
            this.groupControl9.Size = new System.Drawing.Size(600, 78);
            this.groupControl9.TabIndex = 40;
            this.groupControl9.Text = "خيارات التنقل";
            // 
            // update_btn
            // 
            this.update_btn.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.update_btn.Appearance.Options.UseFont = true;
            this.update_btn.ImageOptions.Image = global::ClientApp.Properties.Resources.a_edit;
            this.update_btn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.update_btn.Location = new System.Drawing.Point(190, 37);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(105, 39);
            this.update_btn.TabIndex = 2;
            this.update_btn.Text = "تعديل";
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.save_btn.Appearance.Options.UseFont = true;
            this.save_btn.ImageOptions.Image = global::ClientApp.Properties.Resources.a_save;
            this.save_btn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.save_btn.Location = new System.Drawing.Point(299, 37);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(105, 39);
            this.save_btn.TabIndex = 6;
            this.save_btn.Text = "حفظ";
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // new_btn
            // 
            this.new_btn.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.new_btn.Appearance.Options.UseFont = true;
            this.new_btn.ImageOptions.Image = global::ClientApp.Properties.Resources.a_new;
            this.new_btn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.new_btn.Location = new System.Drawing.Point(408, 37);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(105, 39);
            this.new_btn.TabIndex = 0;
            this.new_btn.Text = "جديد";
            this.new_btn.Click += new System.EventHandler(this.new_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.delete_btn.Appearance.Options.UseFont = true;
            this.delete_btn.ImageOptions.Image = global::ClientApp.Properties.Resources.a_delete;
            this.delete_btn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.delete_btn.Location = new System.Drawing.Point(81, 37);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(105, 39);
            this.delete_btn.TabIndex = 3;
            this.delete_btn.Text = "حذف";
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.delete_btn);
            this.groupControl1.Controls.Add(this.new_btn);
            this.groupControl1.Controls.Add(this.save_btn);
            this.groupControl1.Controls.Add(this.update_btn);
            this.groupControl1.Location = new System.Drawing.Point(3, 284);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(600, 83);
            this.groupControl1.TabIndex = 42;
            this.groupControl1.Text = "العمليات المتاحة";
            // 
            // ar_snd_srf_form
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 369);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl9);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MaximizeBox = false;
            this.Name = "ar_snd_srf_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Load += new System.EventHandler(this.ar_snd_srf_form_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.snd_date_dtp.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snd_date_dtp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id_tb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notes_textbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_textbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pay_type_cb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_name_cb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl9)).EndInit();
            this.groupControl9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker fill_cb_worker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.DateEdit snd_date_dtp;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.ButtonEdit id_tb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ButtonEdit notes_textbox;
        private DevExpress.XtraEditors.ButtonEdit value_textbox;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton next_btn;
        private DevExpress.XtraEditors.SimpleButton last_btn;
        private DevExpress.XtraEditors.SimpleButton first_btn;
        private DevExpress.XtraEditors.SimpleButton prev_btn;
        private DevExpress.XtraEditors.GroupControl groupControl9;
        private DevExpress.XtraEditors.SimpleButton update_btn;
        private DevExpress.XtraEditors.SimpleButton save_btn;
        private DevExpress.XtraEditors.SimpleButton new_btn;
        private DevExpress.XtraEditors.SimpleButton delete_btn;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        public DevExpress.XtraEditors.ComboBoxEdit pay_type_cb;
        private System.Windows.Forms.Label label5;
        public DevExpress.XtraEditors.ComboBoxEdit customer_name_cb;
    }
}