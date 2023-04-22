
namespace ClientApp.fatora_forms.en
{
    partial class en_pos_form
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
            this.product_name_lbl = new System.Windows.Forms.Label();
            this.en_pos_uc1 = new ClientApp.fatora_forms.en.en_pos_uc();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.product_name_lbl, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1108, 38);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // product_name_lbl
            // 
            this.product_name_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.product_name_lbl.AutoSize = true;
            this.product_name_lbl.Font = new System.Drawing.Font("Arial", 14F);
            this.product_name_lbl.ForeColor = System.Drawing.Color.White;
            this.product_name_lbl.Location = new System.Drawing.Point(509, 8);
            this.product_name_lbl.Name = "product_name_lbl";
            this.product_name_lbl.Size = new System.Drawing.Size(90, 22);
            this.product_name_lbl.TabIndex = 0;
            this.product_name_lbl.Text = "E-Invoice";
            // 
            // en_pos_uc1
            // 
            this.en_pos_uc1.Appearance.BackColor = System.Drawing.Color.White;
            this.en_pos_uc1.Appearance.Options.UseBackColor = true;
            this.en_pos_uc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.en_pos_uc1.Location = new System.Drawing.Point(0, 38);
            this.en_pos_uc1.Name = "en_pos_uc1";
            this.en_pos_uc1.Size = new System.Drawing.Size(1108, 625);
            this.en_pos_uc1.TabIndex = 17;
            // 
            // en_pos_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 663);
            this.Controls.Add(this.en_pos_uc1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "DevExpress Style";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "en_pos_form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "en_pos_form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label product_name_lbl;
        private en_pos_uc en_pos_uc1;
    }
}