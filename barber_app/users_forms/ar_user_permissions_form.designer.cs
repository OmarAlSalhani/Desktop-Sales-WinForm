namespace ClientApp.users_forms
{
    partial class ar_user_permissions_form
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
            this.top_label = new System.Windows.Forms.Label();
            this.save_btn = new DevExpress.XtraEditors.SimpleButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.manage_today_agle = new System.Windows.Forms.CheckBox();
            this.snds_report = new System.Windows.Forms.CheckBox();
            this.snd_srf = new System.Windows.Forms.CheckBox();
            this.snd_qbd = new System.Windows.Forms.CheckBox();
            this.storages_operations = new System.Windows.Forms.CheckBox();
            this.manage_storages = new System.Windows.Forms.CheckBox();
            this.sales_report = new System.Windows.Forms.CheckBox();
            this.manage_users_roles = new System.Windows.Forms.CheckBox();
            this.manage_users = new System.Windows.Forms.CheckBox();
            this.customers_mdeonee = new System.Windows.Forms.CheckBox();
            this.customers_kshf_7sab = new System.Windows.Forms.CheckBox();
            this.customers_paied_money = new System.Windows.Forms.CheckBox();
            this.manage_customers = new System.Windows.Forms.CheckBox();
            this.manage_daily_brief = new System.Windows.Forms.CheckBox();
            this.manage_blackbox = new System.Windows.Forms.CheckBox();
            this.manage_settings = new System.Windows.Forms.CheckBox();
            this.open_pos = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.top_label, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(601, 38);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // top_label
            // 
            this.top_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.top_label.AutoSize = true;
            this.top_label.Font = new System.Drawing.Font("Arial", 14F);
            this.top_label.ForeColor = System.Drawing.Color.White;
            this.top_label.Location = new System.Drawing.Point(175, 8);
            this.top_label.Name = "top_label";
            this.top_label.Size = new System.Drawing.Size(252, 22);
            this.top_label.TabIndex = 0;
            this.top_label.Text = "إدارة صلاحيات المستخدم : إسم المستخدم";
            // 
            // save_btn
            // 
            this.save_btn.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.save_btn.Appearance.Options.UseFont = true;
            this.save_btn.ImageOptions.Image = global::ClientApp.Properties.Resources.a_save;
            this.save_btn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.save_btn.Location = new System.Drawing.Point(206, 307);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(212, 45);
            this.save_btn.TabIndex = 1;
            this.save_btn.Text = "حفظ";
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
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
            this.groupControl2.Controls.Add(this.manage_today_agle);
            this.groupControl2.Controls.Add(this.snds_report);
            this.groupControl2.Controls.Add(this.snd_srf);
            this.groupControl2.Controls.Add(this.snd_qbd);
            this.groupControl2.Controls.Add(this.storages_operations);
            this.groupControl2.Controls.Add(this.save_btn);
            this.groupControl2.Controls.Add(this.manage_storages);
            this.groupControl2.Controls.Add(this.sales_report);
            this.groupControl2.Controls.Add(this.manage_users_roles);
            this.groupControl2.Controls.Add(this.manage_users);
            this.groupControl2.Controls.Add(this.customers_mdeonee);
            this.groupControl2.Controls.Add(this.customers_kshf_7sab);
            this.groupControl2.Controls.Add(this.customers_paied_money);
            this.groupControl2.Controls.Add(this.manage_customers);
            this.groupControl2.Controls.Add(this.manage_daily_brief);
            this.groupControl2.Controls.Add(this.manage_blackbox);
            this.groupControl2.Controls.Add(this.manage_settings);
            this.groupControl2.Controls.Add(this.open_pos);
            this.groupControl2.Location = new System.Drawing.Point(3, 40);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(596, 357);
            this.groupControl2.TabIndex = 16;
            this.groupControl2.Text = "الصلاحيات";
            // 
            // manage_today_agle
            // 
            this.manage_today_agle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manage_today_agle.AutoSize = true;
            this.manage_today_agle.Checked = true;
            this.manage_today_agle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.manage_today_agle.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.manage_today_agle.Location = new System.Drawing.Point(232, 269);
            this.manage_today_agle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manage_today_agle.Name = "manage_today_agle";
            this.manage_today_agle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.manage_today_agle.Size = new System.Drawing.Size(162, 25);
            this.manage_today_agle.TabIndex = 90;
            this.manage_today_agle.Text = "شاشة الديون المستحقة";
            this.manage_today_agle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.manage_today_agle.UseVisualStyleBackColor = true;
            // 
            // snds_report
            // 
            this.snds_report.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.snds_report.AutoSize = true;
            this.snds_report.Checked = true;
            this.snds_report.CheckState = System.Windows.Forms.CheckState.Checked;
            this.snds_report.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.snds_report.Location = new System.Drawing.Point(27, 104);
            this.snds_report.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.snds_report.Name = "snds_report";
            this.snds_report.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.snds_report.Size = new System.Drawing.Size(150, 25);
            this.snds_report.TabIndex = 89;
            this.snds_report.Text = "شاشة تقرير السندات";
            this.snds_report.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.snds_report.UseVisualStyleBackColor = true;
            // 
            // snd_srf
            // 
            this.snd_srf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.snd_srf.AutoSize = true;
            this.snd_srf.Checked = true;
            this.snd_srf.CheckState = System.Windows.Forms.CheckState.Checked;
            this.snd_srf.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.snd_srf.Location = new System.Drawing.Point(47, 71);
            this.snd_srf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.snd_srf.Name = "snd_srf";
            this.snd_srf.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.snd_srf.Size = new System.Drawing.Size(130, 25);
            this.snd_srf.TabIndex = 88;
            this.snd_srf.Text = "شاشة سند صرف";
            this.snd_srf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.snd_srf.UseVisualStyleBackColor = true;
            // 
            // snd_qbd
            // 
            this.snd_qbd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.snd_qbd.AutoSize = true;
            this.snd_qbd.Checked = true;
            this.snd_qbd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.snd_qbd.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.snd_qbd.Location = new System.Drawing.Point(54, 38);
            this.snd_qbd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.snd_qbd.Name = "snd_qbd";
            this.snd_qbd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.snd_qbd.Size = new System.Drawing.Size(123, 25);
            this.snd_qbd.TabIndex = 87;
            this.snd_qbd.Text = "شاشة سند قبض";
            this.snd_qbd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.snd_qbd.UseVisualStyleBackColor = true;
            // 
            // storages_operations
            // 
            this.storages_operations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.storages_operations.AutoSize = true;
            this.storages_operations.Checked = true;
            this.storages_operations.CheckState = System.Windows.Forms.CheckState.Checked;
            this.storages_operations.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.storages_operations.Location = new System.Drawing.Point(201, 236);
            this.storages_operations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.storages_operations.Name = "storages_operations";
            this.storages_operations.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.storages_operations.Size = new System.Drawing.Size(193, 25);
            this.storages_operations.TabIndex = 86;
            this.storages_operations.Text = "شاشة العمليات على الخزنات";
            this.storages_operations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.storages_operations.UseVisualStyleBackColor = true;
            // 
            // manage_storages
            // 
            this.manage_storages.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manage_storages.AutoSize = true;
            this.manage_storages.Checked = true;
            this.manage_storages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.manage_storages.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.manage_storages.Location = new System.Drawing.Point(473, 203);
            this.manage_storages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manage_storages.Name = "manage_storages";
            this.manage_storages.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.manage_storages.Size = new System.Drawing.Size(113, 25);
            this.manage_storages.TabIndex = 84;
            this.manage_storages.Text = "شاشة الخزنات";
            this.manage_storages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.manage_storages.UseVisualStyleBackColor = true;
            // 
            // sales_report
            // 
            this.sales_report.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sales_report.AutoSize = true;
            this.sales_report.Checked = true;
            this.sales_report.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sales_report.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.sales_report.Location = new System.Drawing.Point(243, 203);
            this.sales_report.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sales_report.Name = "sales_report";
            this.sales_report.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sales_report.Size = new System.Drawing.Size(151, 25);
            this.sales_report.TabIndex = 83;
            this.sales_report.Text = "شاشة تقرير المبيعات";
            this.sales_report.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sales_report.UseVisualStyleBackColor = true;
            // 
            // manage_users_roles
            // 
            this.manage_users_roles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manage_users_roles.AutoSize = true;
            this.manage_users_roles.Checked = true;
            this.manage_users_roles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.manage_users_roles.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.manage_users_roles.Location = new System.Drawing.Point(200, 170);
            this.manage_users_roles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manage_users_roles.Name = "manage_users_roles";
            this.manage_users_roles.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.manage_users_roles.Size = new System.Drawing.Size(194, 25);
            this.manage_users_roles.TabIndex = 82;
            this.manage_users_roles.Text = "شاشة صلاحيات المستخدمين";
            this.manage_users_roles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.manage_users_roles.UseVisualStyleBackColor = true;
            // 
            // manage_users
            // 
            this.manage_users.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manage_users.AutoSize = true;
            this.manage_users.Checked = true;
            this.manage_users.CheckState = System.Windows.Forms.CheckState.Checked;
            this.manage_users.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.manage_users.Location = new System.Drawing.Point(259, 137);
            this.manage_users.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manage_users.Name = "manage_users";
            this.manage_users.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.manage_users.Size = new System.Drawing.Size(135, 25);
            this.manage_users.TabIndex = 81;
            this.manage_users.Text = "شاشة المستخدمين";
            this.manage_users.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.manage_users.UseVisualStyleBackColor = true;
            // 
            // customers_mdeonee
            // 
            this.customers_mdeonee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customers_mdeonee.AutoSize = true;
            this.customers_mdeonee.Checked = true;
            this.customers_mdeonee.CheckState = System.Windows.Forms.CheckState.Checked;
            this.customers_mdeonee.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.customers_mdeonee.Location = new System.Drawing.Point(254, 71);
            this.customers_mdeonee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customers_mdeonee.Name = "customers_mdeonee";
            this.customers_mdeonee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.customers_mdeonee.Size = new System.Drawing.Size(140, 25);
            this.customers_mdeonee.TabIndex = 79;
            this.customers_mdeonee.Text = "شاشة ديون العملاء";
            this.customers_mdeonee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customers_mdeonee.UseVisualStyleBackColor = true;
            // 
            // customers_kshf_7sab
            // 
            this.customers_kshf_7sab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customers_kshf_7sab.AutoSize = true;
            this.customers_kshf_7sab.Checked = true;
            this.customers_kshf_7sab.CheckState = System.Windows.Forms.CheckState.Checked;
            this.customers_kshf_7sab.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.customers_kshf_7sab.Location = new System.Drawing.Point(220, 38);
            this.customers_kshf_7sab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customers_kshf_7sab.Name = "customers_kshf_7sab";
            this.customers_kshf_7sab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.customers_kshf_7sab.Size = new System.Drawing.Size(174, 25);
            this.customers_kshf_7sab.TabIndex = 78;
            this.customers_kshf_7sab.Text = "شاشة كشف حساب عميل";
            this.customers_kshf_7sab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customers_kshf_7sab.UseVisualStyleBackColor = true;
            // 
            // customers_paied_money
            // 
            this.customers_paied_money.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customers_paied_money.AutoSize = true;
            this.customers_paied_money.Checked = true;
            this.customers_paied_money.CheckState = System.Windows.Forms.CheckState.Checked;
            this.customers_paied_money.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.customers_paied_money.Location = new System.Drawing.Point(197, 104);
            this.customers_paied_money.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customers_paied_money.Name = "customers_paied_money";
            this.customers_paied_money.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.customers_paied_money.Size = new System.Drawing.Size(197, 25);
            this.customers_paied_money.TabIndex = 80;
            this.customers_paied_money.Text = "شاشة المقبوضات من العملاء";
            this.customers_paied_money.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customers_paied_money.UseVisualStyleBackColor = true;
            // 
            // manage_customers
            // 
            this.manage_customers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manage_customers.AutoSize = true;
            this.manage_customers.Checked = true;
            this.manage_customers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.manage_customers.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.manage_customers.Location = new System.Drawing.Point(480, 170);
            this.manage_customers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manage_customers.Name = "manage_customers";
            this.manage_customers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.manage_customers.Size = new System.Drawing.Size(106, 25);
            this.manage_customers.TabIndex = 77;
            this.manage_customers.Text = "شاشة العملاء";
            this.manage_customers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.manage_customers.UseVisualStyleBackColor = true;
            // 
            // manage_daily_brief
            // 
            this.manage_daily_brief.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manage_daily_brief.AutoSize = true;
            this.manage_daily_brief.Checked = true;
            this.manage_daily_brief.CheckState = System.Windows.Forms.CheckState.Checked;
            this.manage_daily_brief.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.manage_daily_brief.Location = new System.Drawing.Point(429, 137);
            this.manage_daily_brief.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manage_daily_brief.Name = "manage_daily_brief";
            this.manage_daily_brief.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.manage_daily_brief.Size = new System.Drawing.Size(157, 25);
            this.manage_daily_brief.TabIndex = 76;
            this.manage_daily_brief.Text = "شاشة الملخص اليومي";
            this.manage_daily_brief.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.manage_daily_brief.UseVisualStyleBackColor = true;
            // 
            // manage_blackbox
            // 
            this.manage_blackbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manage_blackbox.AutoSize = true;
            this.manage_blackbox.Checked = true;
            this.manage_blackbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.manage_blackbox.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.manage_blackbox.Location = new System.Drawing.Point(424, 104);
            this.manage_blackbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manage_blackbox.Name = "manage_blackbox";
            this.manage_blackbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.manage_blackbox.Size = new System.Drawing.Size(162, 25);
            this.manage_blackbox.TabIndex = 75;
            this.manage_blackbox.Text = "شاشة الصندوق الأسود";
            this.manage_blackbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.manage_blackbox.UseVisualStyleBackColor = true;
            // 
            // manage_settings
            // 
            this.manage_settings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manage_settings.AutoSize = true;
            this.manage_settings.Checked = true;
            this.manage_settings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.manage_settings.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.manage_settings.Location = new System.Drawing.Point(464, 71);
            this.manage_settings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manage_settings.Name = "manage_settings";
            this.manage_settings.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.manage_settings.Size = new System.Drawing.Size(122, 25);
            this.manage_settings.TabIndex = 74;
            this.manage_settings.Text = "شاشة الأعدادات";
            this.manage_settings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.manage_settings.UseVisualStyleBackColor = true;
            // 
            // open_pos
            // 
            this.open_pos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.open_pos.AutoSize = true;
            this.open_pos.Checked = true;
            this.open_pos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.open_pos.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.open_pos.Location = new System.Drawing.Point(493, 38);
            this.open_pos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.open_pos.Name = "open_pos";
            this.open_pos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.open_pos.Size = new System.Drawing.Size(93, 25);
            this.open_pos.TabIndex = 71;
            this.open_pos.Text = "شاشة البيع";
            this.open_pos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.open_pos.UseVisualStyleBackColor = true;
            // 
            // ar_user_permissions_form
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 399);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MaximizeBox = false;
            this.Name = "ar_user_permissions_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Load += new System.EventHandler(this.ar_user_permissions_form_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton save_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.Label top_label;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.CheckBox manage_blackbox;
        private System.Windows.Forms.CheckBox manage_settings;
        private System.Windows.Forms.CheckBox open_pos;
        private System.Windows.Forms.CheckBox manage_customers;
        private System.Windows.Forms.CheckBox manage_daily_brief;
        private System.Windows.Forms.CheckBox manage_storages;
        private System.Windows.Forms.CheckBox sales_report;
        private System.Windows.Forms.CheckBox manage_users_roles;
        private System.Windows.Forms.CheckBox manage_users;
        private System.Windows.Forms.CheckBox customers_mdeonee;
        private System.Windows.Forms.CheckBox customers_kshf_7sab;
        private System.Windows.Forms.CheckBox customers_paied_money;
        private System.Windows.Forms.CheckBox storages_operations;
        private System.Windows.Forms.CheckBox manage_today_agle;
        private System.Windows.Forms.CheckBox snds_report;
        private System.Windows.Forms.CheckBox snd_srf;
        private System.Windows.Forms.CheckBox snd_qbd;
    }
}