namespace ClientApp
{
    partial class en_first_form
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
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.progress_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.version_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.user_pic = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(500, 313);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(157)))));
            this.progressBarControl1.Properties.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(109)))), ((int)(((byte)(22)))));
            this.progressBarControl1.Properties.Step = 1;
            this.progressBarControl1.Size = new System.Drawing.Size(288, 28);
            this.progressBarControl1.TabIndex = 14;
            // 
            // progress_label
            // 
            this.progress_label.AutoSize = true;
            this.progress_label.BackColor = System.Drawing.Color.Transparent;
            this.progress_label.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progress_label.ForeColor = System.Drawing.Color.Black;
            this.progress_label.Location = new System.Drawing.Point(636, 284);
            this.progress_label.Name = "progress_label";
            this.progress_label.Size = new System.Drawing.Size(16, 16);
            this.progress_label.TabIndex = 13;
            this.progress_label.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(604, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Loading ...";
            // 
            // version_label
            // 
            this.version_label.AutoSize = true;
            this.version_label.BackColor = System.Drawing.Color.Transparent;
            this.version_label.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.version_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.version_label.Location = new System.Drawing.Point(588, 59);
            this.version_label.Name = "version_label";
            this.version_label.Size = new System.Drawing.Size(85, 16);
            this.version_label.TabIndex = 10;
            this.version_label.Text = "Version 1.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(157)))));
            this.label1.Location = new System.Drawing.Point(442, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "E-invoice Program";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // user_pic
            // 
            this.user_pic.Image = global::ClientApp.Properties.Resources.profile;
            this.user_pic.Location = new System.Drawing.Point(13, 13);
            this.user_pic.Name = "user_pic";
            this.user_pic.Size = new System.Drawing.Size(10, 10);
            this.user_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.user_pic.TabIndex = 15;
            this.user_pic.TabStop = false;
            this.user_pic.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(157)))));
            this.label2.Location = new System.Drawing.Point(12, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "0506499275";
            // 
            // en_first_form
            // 
            this.BackgroundImage = global::ClientApp.Properties.Resources.LOGO3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.user_pic);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.progress_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.version_label);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "en_first_form";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.en_first_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private System.Windows.Forms.Label progress_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label version_label;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox user_pic;
        private System.Windows.Forms.Label label2;
    }
}