namespace ClientApp.n_blackbox_forms.ar
{
    partial class ar_blackbox_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ar_blackbox_form));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.screen_cb = new DevExpress.XtraEditors.LookUpEdit();
            this.screen_name_checkbox = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.username_checkbox = new DevExpress.XtraEditors.CheckEdit();
            this.username_cb = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl7 = new DevExpress.XtraEditors.GroupControl();
            this.date_checkbox = new DevExpress.XtraEditors.CheckEdit();
            this.last_date = new DevExpress.XtraEditors.DateEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.first_date = new DevExpress.XtraEditors.DateEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.show_report_btn = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl17 = new DevExpress.XtraEditors.GroupControl();
            this.delete_btn = new DevExpress.XtraEditors.SimpleButton();
            this.excel_btn = new DevExpress.XtraEditors.SimpleButton();
            this.word_btn = new DevExpress.XtraEditors.SimpleButton();
            this.print_btn = new DevExpress.XtraEditors.SimpleButton();
            this.pdf_btn = new DevExpress.XtraEditors.SimpleButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.FillWorker = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screen_cb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.screen_name_checkbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.username_checkbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.username_cb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).BeginInit();
            this.groupControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_checkbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl17)).BeginInit();
            this.groupControl17.SuspendLayout();
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
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(957, 38);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(428, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "سجل النشاطات";
            // 
            // gridControl2
            // 
            this.gridControl2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridControl2.Location = new System.Drawing.Point(4, 119);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(949, 356);
            this.gridControl2.TabIndex = 39;
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
            this.gridView2.OptionsFilter.AllowMultiSelectInCheckedFilterPopup = false;
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
            this.gridView2.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.gridView2.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator;
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
            this.groupControl6.Controls.Add(this.screen_cb);
            this.groupControl6.Controls.Add(this.screen_name_checkbox);
            this.groupControl6.Location = new System.Drawing.Point(630, 42);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(190, 71);
            this.groupControl6.TabIndex = 40;
            this.groupControl6.Text = "بحث حسب إسم الشاشة";
            // 
            // screen_cb
            // 
            this.screen_cb.Location = new System.Drawing.Point(63, 37);
            this.screen_cb.Name = "screen_cb";
            this.screen_cb.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.screen_cb.Properties.AdvancedModeOptions.AllowSelectionAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.screen_cb.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.screen_cb.Properties.Appearance.Options.UseFont = true;
            this.screen_cb.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.screen_cb.Properties.AppearanceDisabled.Options.UseFont = true;
            this.screen_cb.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.screen_cb.Properties.AppearanceDropDown.Options.UseFont = true;
            this.screen_cb.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.screen_cb.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.screen_cb.Properties.AppearanceFocused.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.screen_cb.Properties.AppearanceFocused.Options.UseFont = true;
            this.screen_cb.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.screen_cb.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.screen_cb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.screen_cb.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Standard;
            this.screen_cb.Properties.NullText = "";
            this.screen_cb.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest;
            this.screen_cb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.screen_cb.Size = new System.Drawing.Size(122, 26);
            this.screen_cb.TabIndex = 39;
            // 
            // screen_name_checkbox
            // 
            this.screen_name_checkbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.screen_name_checkbox.Location = new System.Drawing.Point(5, 38);
            this.screen_name_checkbox.Name = "screen_name_checkbox";
            this.screen_name_checkbox.Properties.Appearance.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.screen_name_checkbox.Properties.Appearance.Options.UseFont = true;
            this.screen_name_checkbox.Properties.Caption = "بحث";
            this.screen_name_checkbox.Size = new System.Drawing.Size(52, 28);
            this.screen_name_checkbox.TabIndex = 41;
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
            this.groupControl1.Controls.Add(this.username_checkbox);
            this.groupControl1.Controls.Add(this.username_cb);
            this.groupControl1.Location = new System.Drawing.Point(429, 42);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(197, 71);
            this.groupControl1.TabIndex = 39;
            this.groupControl1.Text = "بحث حسب إسم المستخدم";
            // 
            // username_checkbox
            // 
            this.username_checkbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username_checkbox.Location = new System.Drawing.Point(3, 37);
            this.username_checkbox.Name = "username_checkbox";
            this.username_checkbox.Properties.Appearance.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.username_checkbox.Properties.Appearance.Options.UseFont = true;
            this.username_checkbox.Properties.Caption = "بحث";
            this.username_checkbox.Size = new System.Drawing.Size(58, 28);
            this.username_checkbox.TabIndex = 47;
            // 
            // username_cb
            // 
            this.username_cb.Location = new System.Drawing.Point(70, 36);
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
            this.username_cb.Size = new System.Drawing.Size(122, 26);
            this.username_cb.TabIndex = 46;
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
            this.groupControl7.Controls.Add(this.date_checkbox);
            this.groupControl7.Controls.Add(this.last_date);
            this.groupControl7.Controls.Add(this.label6);
            this.groupControl7.Controls.Add(this.first_date);
            this.groupControl7.Controls.Add(this.label7);
            this.groupControl7.Location = new System.Drawing.Point(4, 42);
            this.groupControl7.Name = "groupControl7";
            this.groupControl7.Size = new System.Drawing.Size(422, 71);
            this.groupControl7.TabIndex = 8;
            this.groupControl7.Text = "بحث حسب التاريخ";
            // 
            // date_checkbox
            // 
            this.date_checkbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_checkbox.Location = new System.Drawing.Point(3, 35);
            this.date_checkbox.Name = "date_checkbox";
            this.date_checkbox.Properties.Appearance.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.date_checkbox.Properties.Appearance.Options.UseFont = true;
            this.date_checkbox.Properties.Caption = "بحث";
            this.date_checkbox.Size = new System.Drawing.Size(58, 28);
            this.date_checkbox.TabIndex = 46;
            // 
            // last_date
            // 
            this.last_date.EditValue = new System.DateTime(2021, 3, 25, 23, 59, 59, 0);
            this.last_date.Location = new System.Drawing.Point(68, 36);
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
            this.last_date.Size = new System.Drawing.Size(110, 26);
            this.last_date.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label6.Location = new System.Drawing.Point(359, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 21);
            this.label6.TabIndex = 42;
            this.label6.Text = "من تاريخ";
            // 
            // first_date
            // 
            this.first_date.EditValue = new System.DateTime(2021, 3, 25, 23, 59, 59, 0);
            this.first_date.Location = new System.Drawing.Point(245, 36);
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
            this.first_date.Size = new System.Drawing.Size(112, 26);
            this.first_date.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label7.Location = new System.Drawing.Point(180, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 21);
            this.label7.TabIndex = 43;
            this.label7.Text = "إلى تاريخ";
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.White;
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
            this.groupControl2.Controls.Add(this.show_report_btn);
            this.groupControl2.Location = new System.Drawing.Point(824, 42);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(129, 71);
            this.groupControl2.TabIndex = 41;
            this.groupControl2.Text = "البحث";
            // 
            // show_report_btn
            // 
            this.show_report_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.show_report_btn.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.show_report_btn.Appearance.Options.UseFont = true;
            this.show_report_btn.ImageOptions.Image = global::ClientApp.Properties.Resources.a_show_report;
            this.show_report_btn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.show_report_btn.Location = new System.Drawing.Point(8, 34);
            this.show_report_btn.Name = "show_report_btn";
            this.show_report_btn.Size = new System.Drawing.Size(116, 32);
            this.show_report_btn.TabIndex = 38;
            this.show_report_btn.Text = "عرض";
            this.show_report_btn.Click += new System.EventHandler(this.show_report_btn_Click);
            // 
            // groupControl17
            // 
            this.groupControl17.AppearanceCaption.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.groupControl17.AppearanceCaption.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupControl17.AppearanceCaption.Options.UseFont = true;
            this.groupControl17.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl17.Controls.Add(this.delete_btn);
            this.groupControl17.Controls.Add(this.excel_btn);
            this.groupControl17.Controls.Add(this.word_btn);
            this.groupControl17.Controls.Add(this.print_btn);
            this.groupControl17.Controls.Add(this.pdf_btn);
            this.groupControl17.Location = new System.Drawing.Point(4, 480);
            this.groupControl17.Name = "groupControl17";
            this.groupControl17.Size = new System.Drawing.Size(949, 84);
            this.groupControl17.TabIndex = 41;
            this.groupControl17.Text = "خيارات الطباعة والتصدير";
            // 
            // delete_btn
            // 
            this.delete_btn.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.delete_btn.Appearance.Options.UseFont = true;
            this.delete_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("delete_btn.ImageOptions.Image")));
            this.delete_btn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.delete_btn.Location = new System.Drawing.Point(177, 38);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(105, 39);
            this.delete_btn.TabIndex = 8;
            this.delete_btn.Text = "حذف";
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // excel_btn
            // 
            this.excel_btn.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.excel_btn.Appearance.Options.UseFont = true;
            this.excel_btn.ImageOptions.Image = global::ClientApp.Properties.Resources.a_excel;
            this.excel_btn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.excel_btn.Location = new System.Drawing.Point(399, 38);
            this.excel_btn.Name = "excel_btn";
            this.excel_btn.Size = new System.Drawing.Size(105, 39);
            this.excel_btn.TabIndex = 6;
            this.excel_btn.Text = "إكسل";
            this.excel_btn.Click += new System.EventHandler(this.excel_btn_Click);
            // 
            // word_btn
            // 
            this.word_btn.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.word_btn.Appearance.Options.UseFont = true;
            this.word_btn.ImageOptions.Image = global::ClientApp.Properties.Resources.a_word;
            this.word_btn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.word_btn.Location = new System.Drawing.Point(510, 38);
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
            this.print_btn.Location = new System.Drawing.Point(621, 38);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(105, 39);
            this.print_btn.TabIndex = 4;
            this.print_btn.Text = "طباعة";
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // pdf_btn
            // 
            this.pdf_btn.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.pdf_btn.Appearance.Options.UseFont = true;
            this.pdf_btn.ImageOptions.Image = global::ClientApp.Properties.Resources.a_pdf;
            this.pdf_btn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.pdf_btn.Location = new System.Drawing.Point(288, 38);
            this.pdf_btn.Name = "pdf_btn";
            this.pdf_btn.Size = new System.Drawing.Size(105, 39);
            this.pdf_btn.TabIndex = 3;
            this.pdf_btn.Text = "PDF";
            this.pdf_btn.Click += new System.EventHandler(this.pdf_btn_Click);
            // 
            // FillWorker
            // 
            this.FillWorker.WorkerReportsProgress = true;
            this.FillWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.FillWorker_DoWork);
            this.FillWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.FillWorker_RunWorkerCompleted);
            // 
            // ar_blackbox_form
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 568);
            this.Controls.Add(this.groupControl6);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.groupControl17);
            this.Controls.Add(this.groupControl7);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MaximizeBox = false;
            this.Name = "ar_blackbox_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Load += new System.EventHandler(this.ar_blackbox_form_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.screen_cb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.screen_name_checkbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.username_checkbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.username_cb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).EndInit();
            this.groupControl7.ResumeLayout(false);
            this.groupControl7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_checkbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl17)).EndInit();
            this.groupControl17.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton show_report_btn;
        private DevExpress.XtraEditors.GroupControl groupControl7;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.GroupControl groupControl17;
        private DevExpress.XtraEditors.SimpleButton excel_btn;
        private DevExpress.XtraEditors.SimpleButton word_btn;
        private DevExpress.XtraEditors.SimpleButton print_btn;
        private DevExpress.XtraEditors.SimpleButton pdf_btn;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit screen_name_checkbox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.ComponentModel.BackgroundWorker FillWorker;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LookUpEdit screen_cb;
        private DevExpress.XtraEditors.CheckEdit username_checkbox;
        private DevExpress.XtraEditors.LookUpEdit username_cb;
        private DevExpress.XtraEditors.CheckEdit date_checkbox;
        private DevExpress.XtraEditors.DateEdit last_date;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.DateEdit first_date;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton delete_btn;
    }
}