namespace ClientApp
{
    partial class activate_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(activate_form));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.FillWorker = new System.ComponentModel.BackgroundWorker();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.save_btn = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.activate_tb = new DevExpress.XtraEditors.ButtonEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.serial_tb = new DevExpress.XtraEditors.ButtonEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activate_tb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serial_tb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(445, 38);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(175, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "تفعيل البرنامج";
            // 
            // FillWorker
            // 
            this.FillWorker.WorkerReportsProgress = true;
            this.FillWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.FillWorker_DoWork);
            this.FillWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.FillWorker_RunWorkerCompleted);
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
            this.groupControl2.Controls.Add(this.pictureEdit1);
            this.groupControl2.Controls.Add(this.save_btn);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.activate_tb);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.serial_tb);
            this.groupControl2.Location = new System.Drawing.Point(2, 40);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(442, 179);
            this.groupControl2.TabIndex = 42;
            this.groupControl2.Text = "تفعيل البرنامج";
            // 
            // save_btn
            // 
            this.save_btn.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.save_btn.Appearance.Options.UseFont = true;
            this.save_btn.ImageOptions.Image = global::ClientApp.Properties.Resources.a_save;
            this.save_btn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.save_btn.Location = new System.Drawing.Point(106, 134);
            this.save_btn.LookAndFeel.SkinName = "DevExpress Style";
            this.save_btn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(176, 40);
            this.save_btn.TabIndex = 193;
            this.save_btn.Text = "تفعيل";
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(329, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 192;
            this.label3.Text = "رمز التفعيل";
            // 
            // activate_tb
            // 
            this.activate_tb.EditValue = "";
            this.activate_tb.Location = new System.Drawing.Point(45, 91);
            this.activate_tb.Name = "activate_tb";
            this.activate_tb.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.activate_tb.Properties.AdvancedModeOptions.AllowSelectionAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.activate_tb.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.activate_tb.Properties.Appearance.Options.UseFont = true;
            this.activate_tb.Properties.Appearance.Options.UseTextOptions = true;
            this.activate_tb.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.activate_tb.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.activate_tb.Properties.AppearanceFocused.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.activate_tb.Properties.AppearanceFocused.Options.UseFont = true;
            this.activate_tb.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.activate_tb.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.activate_tb.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.activate_tb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.activate_tb.Size = new System.Drawing.Size(281, 28);
            this.activate_tb.TabIndex = 191;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(329, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 190;
            this.label2.Text = "الرقم التسلسلي";
            // 
            // serial_tb
            // 
            this.serial_tb.EditValue = "";
            this.serial_tb.Enabled = false;
            this.serial_tb.Location = new System.Drawing.Point(45, 43);
            this.serial_tb.Name = "serial_tb";
            this.serial_tb.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.serial_tb.Properties.AdvancedModeOptions.AllowSelectionAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.serial_tb.Properties.AllowFocused = false;
            this.serial_tb.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.serial_tb.Properties.Appearance.Options.UseFont = true;
            this.serial_tb.Properties.Appearance.Options.UseTextOptions = true;
            this.serial_tb.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.serial_tb.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.serial_tb.Properties.AppearanceFocused.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.serial_tb.Properties.AppearanceFocused.Options.UseFont = true;
            this.serial_tb.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.serial_tb.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.serial_tb.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.serial_tb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.serial_tb.Properties.ReadOnly = true;
            this.serial_tb.Size = new System.Drawing.Size(281, 28);
            this.serial_tb.TabIndex = 189;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(5, 41);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Size = new System.Drawing.Size(38, 34);
            this.pictureEdit1.TabIndex = 194;
            this.pictureEdit1.Click += new System.EventHandler(this.pictureEdit1_Click);
            // 
            // activate_form
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 222);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "activate_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.activate_form_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activate_tb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serial_tb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker FillWorker;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.ButtonEdit activate_tb;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ButtonEdit serial_tb;
        private DevExpress.XtraEditors.SimpleButton save_btn;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}