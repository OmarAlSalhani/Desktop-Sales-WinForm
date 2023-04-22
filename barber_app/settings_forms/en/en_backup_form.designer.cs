namespace ClientApp.n_settings_forms.en
{
    partial class en_backup_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(en_backup_form));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.delete_backup_btn = new DevExpress.XtraEditors.SimpleButton();
            this.backup_gridcontrol = new DevExpress.XtraGrid.GridControl();
            this.backup_gridview = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.add_to_backup_grid_btn = new DevExpress.XtraEditors.SimpleButton();
            this.label11 = new System.Windows.Forms.Label();
            this.db_folder_text = new DevExpress.XtraEditors.ButtonEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.backup_time = new DevExpress.XtraEditors.TimeEdit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backup_gridcontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backup_gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_folder_text.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backup_time.Properties)).BeginInit();
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(661, 38);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(294, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Backup";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "الصور |*.jpg;*.jpeg;*.png;*.bmp;*.gif";
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
            this.groupControl2.Controls.Add(this.delete_backup_btn);
            this.groupControl2.Controls.Add(this.backup_gridcontrol);
            this.groupControl2.Controls.Add(this.add_to_backup_grid_btn);
            this.groupControl2.Controls.Add(this.label11);
            this.groupControl2.Controls.Add(this.db_folder_text);
            this.groupControl2.Controls.Add(this.label10);
            this.groupControl2.Controls.Add(this.backup_time);
            this.groupControl2.Location = new System.Drawing.Point(2, 39);
            this.groupControl2.LookAndFeel.SkinName = "DevExpress Style";
            this.groupControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(657, 445);
            this.groupControl2.TabIndex = 164;
            this.groupControl2.Text = "Backup Scheduale";
            // 
            // delete_backup_btn
            // 
            this.delete_backup_btn.Appearance.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.delete_backup_btn.Appearance.Options.UseFont = true;
            this.delete_backup_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("delete_backup_btn.ImageOptions.Image")));
            this.delete_backup_btn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.delete_backup_btn.Location = new System.Drawing.Point(5, 402);
            this.delete_backup_btn.Name = "delete_backup_btn";
            this.delete_backup_btn.Size = new System.Drawing.Size(105, 39);
            this.delete_backup_btn.TabIndex = 169;
            this.delete_backup_btn.Text = "Delete";
            this.delete_backup_btn.Click += new System.EventHandler(this.delete_backup_btn_Click);
            // 
            // backup_gridcontrol
            // 
            this.backup_gridcontrol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backup_gridcontrol.Location = new System.Drawing.Point(5, 88);
            this.backup_gridcontrol.MainView = this.backup_gridview;
            this.backup_gridcontrol.Name = "backup_gridcontrol";
            this.backup_gridcontrol.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.backup_gridcontrol.Size = new System.Drawing.Size(647, 310);
            this.backup_gridcontrol.TabIndex = 168;
            this.backup_gridcontrol.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.backup_gridview});
            // 
            // backup_gridview
            // 
            this.backup_gridview.Appearance.FocusedCell.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.backup_gridview.Appearance.FocusedCell.Options.UseFont = true;
            this.backup_gridview.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(209)))));
            this.backup_gridview.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(209)))));
            this.backup_gridview.Appearance.FocusedRow.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.backup_gridview.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.backup_gridview.Appearance.FocusedRow.Options.UseBackColor = true;
            this.backup_gridview.Appearance.FocusedRow.Options.UseFont = true;
            this.backup_gridview.Appearance.FocusedRow.Options.UseForeColor = true;
            this.backup_gridview.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.backup_gridview.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.backup_gridview.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.backup_gridview.Appearance.HeaderPanel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.backup_gridview.Appearance.HeaderPanel.Options.UseFont = true;
            this.backup_gridview.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.backup_gridview.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.backup_gridview.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.backup_gridview.Appearance.HotTrackedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.backup_gridview.Appearance.HotTrackedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.backup_gridview.Appearance.HotTrackedRow.ForeColor = System.Drawing.Color.White;
            this.backup_gridview.Appearance.HotTrackedRow.Options.UseBackColor = true;
            this.backup_gridview.Appearance.HotTrackedRow.Options.UseForeColor = true;
            this.backup_gridview.Appearance.Row.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.backup_gridview.Appearance.Row.Options.UseFont = true;
            this.backup_gridview.Appearance.Row.Options.UseTextOptions = true;
            this.backup_gridview.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.backup_gridview.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.backup_gridview.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(209)))));
            this.backup_gridview.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(209)))));
            this.backup_gridview.Appearance.SelectedRow.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.backup_gridview.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.backup_gridview.Appearance.SelectedRow.Options.UseBackColor = true;
            this.backup_gridview.Appearance.SelectedRow.Options.UseFont = true;
            this.backup_gridview.Appearance.SelectedRow.Options.UseForeColor = true;
            this.backup_gridview.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.backup_gridview.GridControl = this.backup_gridcontrol;
            this.backup_gridview.Name = "backup_gridview";
            this.backup_gridview.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.backup_gridview.OptionsBehavior.AllowIncrementalSearch = true;
            this.backup_gridview.OptionsBehavior.AllowSortAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.backup_gridview.OptionsBehavior.Editable = false;
            this.backup_gridview.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.backup_gridview.OptionsBehavior.UnboundColumnExpressionEditorMode = DevExpress.XtraEditors.ExpressionEditorMode.AutoComplete;
            this.backup_gridview.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            this.backup_gridview.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.backup_gridview.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.True;
            this.backup_gridview.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.False;
            this.backup_gridview.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.True;
            this.backup_gridview.OptionsFind.AllowFindPanel = false;
            this.backup_gridview.OptionsFind.FindNullPrompt = "ابدأ بكتابة النص لبدء البحث";
            this.backup_gridview.OptionsFind.HighlightFindResults = false;
            this.backup_gridview.OptionsFind.SearchInPreview = true;
            this.backup_gridview.OptionsFind.ShowClearButton = false;
            this.backup_gridview.OptionsFind.ShowFindButton = false;
            this.backup_gridview.OptionsImageLoad.AnimationType = DevExpress.Utils.ImageContentAnimationType.Slide;
            this.backup_gridview.OptionsNavigation.AutoFocusNewRow = true;
            this.backup_gridview.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.backup_gridview.OptionsSelection.EnableAppearanceHotTrackedRow = DevExpress.Utils.DefaultBoolean.True;
            this.backup_gridview.OptionsSelection.MultiSelect = true;
            this.backup_gridview.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.backup_gridview.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.backup_gridview.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;
            this.backup_gridview.OptionsView.RowAutoHeight = true;
            this.backup_gridview.OptionsView.ShowGroupPanel = false;
            this.backup_gridview.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator;
            // 
            // add_to_backup_grid_btn
            // 
            this.add_to_backup_grid_btn.Appearance.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.add_to_backup_grid_btn.Appearance.Options.UseFont = true;
            this.add_to_backup_grid_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("add_to_backup_grid_btn.ImageOptions.Image")));
            this.add_to_backup_grid_btn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.add_to_backup_grid_btn.Location = new System.Drawing.Point(7, 41);
            this.add_to_backup_grid_btn.Name = "add_to_backup_grid_btn";
            this.add_to_backup_grid_btn.Size = new System.Drawing.Size(105, 39);
            this.add_to_backup_grid_btn.TabIndex = 167;
            this.add_to_backup_grid_btn.Text = "Add";
            this.add_to_backup_grid_btn.Click += new System.EventHandler(this.add_to_backup_grid_btn_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label11.Location = new System.Drawing.Point(600, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 21);
            this.label11.TabIndex = 166;
            this.label11.Text = "Time";
            // 
            // db_folder_text
            // 
            this.db_folder_text.EditValue = "";
            this.db_folder_text.Location = new System.Drawing.Point(117, 43);
            this.db_folder_text.Name = "db_folder_text";
            this.db_folder_text.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.db_folder_text.Properties.AdvancedModeOptions.AllowSelectionAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.db_folder_text.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.db_folder_text.Properties.Appearance.Options.UseFont = true;
            this.db_folder_text.Properties.AppearanceFocused.Font = new System.Drawing.Font("Cairo", 10.5F);
            this.db_folder_text.Properties.AppearanceFocused.Options.UseFont = true;
            this.db_folder_text.Properties.AutoHeight = false;
            this.db_folder_text.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.db_folder_text.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.db_folder_text.Properties.NullText = "أضغط على زر + لإضافة مجلد";
            this.db_folder_text.Properties.NullValuePrompt = "أضغط على زر + لإضافة مجلد";
            this.db_folder_text.Properties.ReadOnly = true;
            this.db_folder_text.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.db_folder_text_Properties_ButtonClick);
            this.db_folder_text.Size = new System.Drawing.Size(213, 35);
            this.db_folder_text.TabIndex = 163;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label10.Location = new System.Drawing.Point(331, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 21);
            this.label10.TabIndex = 165;
            this.label10.Text = "Backup folder";
            // 
            // backup_time
            // 
            this.backup_time.EditValue = new System.DateTime(2021, 3, 2, 0, 0, 0, 0);
            this.backup_time.Location = new System.Drawing.Point(475, 43);
            this.backup_time.Name = "backup_time";
            this.backup_time.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.backup_time.Properties.Appearance.Options.UseFont = true;
            this.backup_time.Properties.Appearance.Options.UseTextOptions = true;
            this.backup_time.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.backup_time.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.backup_time.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.backup_time.Properties.AppearanceDisabled.Options.UseFont = true;
            this.backup_time.Properties.AppearanceFocused.Font = new System.Drawing.Font("Cairo", 10.5F);
            this.backup_time.Properties.AppearanceFocused.Options.UseFont = true;
            this.backup_time.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.backup_time.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.backup_time.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.backup_time.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.backup_time.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.backup_time.Properties.AutoHeight = false;
            this.backup_time.Properties.BeepOnError = false;
            this.backup_time.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.backup_time.Properties.MaskSettings.Set("mask", "t");
            this.backup_time.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.backup_time.Size = new System.Drawing.Size(124, 35);
            this.backup_time.TabIndex = 164;
            // 
            // en_backup_form
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 486);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 900);
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "en_backup_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.en_backup_form_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backup_gridcontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backup_gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_folder_text.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backup_time.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton add_to_backup_grid_btn;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.ButtonEdit db_folder_text;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TimeEdit backup_time;
        private DevExpress.XtraGrid.GridControl backup_gridcontrol;
        private DevExpress.XtraGrid.Views.Grid.GridView backup_gridview;
        private DevExpress.XtraEditors.SimpleButton delete_backup_btn;
    }
}