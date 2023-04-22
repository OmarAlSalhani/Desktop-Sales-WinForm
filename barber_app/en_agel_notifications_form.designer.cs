namespace ClientApp
{
    partial class en_agel_notifications_form
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
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.main_gridview = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.pay_btn = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.some_tb = new DevExpress.XtraEditors.ButtonEdit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.some_tb.Properties)).BeginInit();
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(675, 38);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(232, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customers today debits";
            // 
            // gridControl2
            // 
            this.gridControl2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridControl2.Location = new System.Drawing.Point(3, 40);
            this.gridControl2.MainView = this.main_gridview;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(669, 263);
            this.gridControl2.TabIndex = 40;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.main_gridview});
            // 
            // main_gridview
            // 
            this.main_gridview.Appearance.FocusedCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.main_gridview.Appearance.FocusedCell.Options.UseFont = true;
            this.main_gridview.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(209)))));
            this.main_gridview.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(209)))));
            this.main_gridview.Appearance.FocusedRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.main_gridview.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.main_gridview.Appearance.FocusedRow.Options.UseBackColor = true;
            this.main_gridview.Appearance.FocusedRow.Options.UseFont = true;
            this.main_gridview.Appearance.FocusedRow.Options.UseForeColor = true;
            this.main_gridview.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.main_gridview.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.main_gridview.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.main_gridview.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.main_gridview.Appearance.HeaderPanel.Options.UseFont = true;
            this.main_gridview.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.main_gridview.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.main_gridview.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.main_gridview.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.main_gridview.Appearance.Row.Options.UseFont = true;
            this.main_gridview.Appearance.Row.Options.UseTextOptions = true;
            this.main_gridview.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.main_gridview.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.main_gridview.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(209)))));
            this.main_gridview.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(209)))));
            this.main_gridview.Appearance.SelectedRow.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.main_gridview.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.main_gridview.Appearance.SelectedRow.Options.UseBackColor = true;
            this.main_gridview.Appearance.SelectedRow.Options.UseFont = true;
            this.main_gridview.Appearance.SelectedRow.Options.UseForeColor = true;
            this.main_gridview.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.main_gridview.GridControl = this.gridControl2;
            this.main_gridview.Name = "main_gridview";
            this.main_gridview.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.main_gridview.OptionsBehavior.AllowIncrementalSearch = true;
            this.main_gridview.OptionsBehavior.AllowSortAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.main_gridview.OptionsBehavior.Editable = false;
            this.main_gridview.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            this.main_gridview.OptionsBehavior.UnboundColumnExpressionEditorMode = DevExpress.XtraEditors.ExpressionEditorMode.AutoComplete;
            this.main_gridview.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            this.main_gridview.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.main_gridview.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.True;
            this.main_gridview.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.False;
            this.main_gridview.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.True;
            this.main_gridview.OptionsFind.AllowFindPanel = false;
            this.main_gridview.OptionsFind.FindNullPrompt = "";
            this.main_gridview.OptionsFind.HighlightFindResults = false;
            this.main_gridview.OptionsFind.ShowClearButton = false;
            this.main_gridview.OptionsFind.ShowCloseButton = false;
            this.main_gridview.OptionsFind.ShowFindButton = false;
            this.main_gridview.OptionsFind.ShowSearchNavButtons = false;
            this.main_gridview.OptionsHint.ShowFooterHints = false;
            this.main_gridview.OptionsImageLoad.AnimationType = DevExpress.Utils.ImageContentAnimationType.Slide;
            this.main_gridview.OptionsNavigation.AutoFocusNewRow = true;
            this.main_gridview.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.main_gridview.OptionsSelection.MultiSelect = true;
            this.main_gridview.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.main_gridview.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.main_gridview.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;
            this.main_gridview.OptionsView.ShowGroupPanel = false;
            this.main_gridview.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // groupControl4
            // 
            this.groupControl4.AppearanceCaption.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.groupControl4.AppearanceCaption.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupControl4.AppearanceCaption.Options.UseFont = true;
            this.groupControl4.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl4.Controls.Add(this.pay_btn);
            this.groupControl4.Controls.Add(this.label3);
            this.groupControl4.Controls.Add(this.some_tb);
            this.groupControl4.Location = new System.Drawing.Point(3, 305);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(669, 80);
            this.groupControl4.TabIndex = 41;
            this.groupControl4.Text = "Options";
            // 
            // pay_btn
            // 
            this.pay_btn.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.pay_btn.Appearance.Options.UseFont = true;
            this.pay_btn.ImageOptions.Image = global::ClientApp.Properties.Resources.a_cash;
            this.pay_btn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.pay_btn.Location = new System.Drawing.Point(107, 36);
            this.pay_btn.Name = "pay_btn";
            this.pay_btn.Size = new System.Drawing.Size(122, 38);
            this.pay_btn.TabIndex = 39;
            this.pay_btn.Text = "Take";
            this.pay_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(422, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Money";
            // 
            // some_tb
            // 
            this.some_tb.EditValue = "";
            this.some_tb.Location = new System.Drawing.Point(233, 41);
            this.some_tb.Name = "some_tb";
            this.some_tb.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.some_tb.Properties.AdvancedModeOptions.AllowSelectionAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.some_tb.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.some_tb.Properties.Appearance.Options.UseFont = true;
            this.some_tb.Properties.Appearance.Options.UseTextOptions = true;
            this.some_tb.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.some_tb.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.some_tb.Properties.BeepOnError = false;
            this.some_tb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.some_tb.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.some_tb.Properties.MaskSettings.Set("mask", "n");
            this.some_tb.Properties.NullText = "0";
            this.some_tb.Properties.UseMaskAsDisplayFormat = true;
            this.some_tb.Size = new System.Drawing.Size(186, 28);
            this.some_tb.TabIndex = 41;
            // 
            // en_agel_notifications_form
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 387);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.tableLayoutPanel2);
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.False;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.Name = "en_agel_notifications_form";
            this.Load += new System.EventHandler(this.en_agel_notifications_form_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.some_tb.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView main_gridview;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.ButtonEdit some_tb;
        private DevExpress.XtraEditors.SimpleButton pay_btn;
        private System.Windows.Forms.Label label3;
    }
}