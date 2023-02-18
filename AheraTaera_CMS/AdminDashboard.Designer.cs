
namespace AheraTaera_CMS
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.AdminProductButton = new System.Windows.Forms.Button();
            this.AdminPaymentButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminProductButton
            // 
            this.AdminProductButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.AdminProductButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdminProductButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AdminProductButton.Location = new System.Drawing.Point(537, 220);
            this.AdminProductButton.Margin = new System.Windows.Forms.Padding(4);
            this.AdminProductButton.Name = "AdminProductButton";
            this.AdminProductButton.Size = new System.Drawing.Size(347, 75);
            this.AdminProductButton.TabIndex = 0;
            this.AdminProductButton.Text = "Manage Product List";
            this.AdminProductButton.UseVisualStyleBackColor = false;
            this.AdminProductButton.Click += new System.EventHandler(this.AdminProductButton_Click);
            // 
            // AdminPaymentButton
            // 
            this.AdminPaymentButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.AdminPaymentButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdminPaymentButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AdminPaymentButton.Location = new System.Drawing.Point(537, 326);
            this.AdminPaymentButton.Margin = new System.Windows.Forms.Padding(4);
            this.AdminPaymentButton.Name = "AdminPaymentButton";
            this.AdminPaymentButton.Size = new System.Drawing.Size(347, 76);
            this.AdminPaymentButton.TabIndex = 1;
            this.AdminPaymentButton.Text = "Manage Payment Records";
            this.AdminPaymentButton.UseVisualStyleBackColor = false;
            this.AdminPaymentButton.Click += new System.EventHandler(this.AdminPaymentButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BackButton.Location = new System.Drawing.Point(724, 448);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(153, 52);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 506);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(587, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "Admin Portal";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AdminPaymentButton);
            this.Controls.Add(this.AdminProductButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdminProductButton;
        private System.Windows.Forms.Button AdminPaymentButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}