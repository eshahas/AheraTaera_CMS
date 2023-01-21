
namespace AheraTaera_CMS
{
    partial class Checkout
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
            this.PaymentButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PaymentButton
            // 
            this.PaymentButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.PaymentButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PaymentButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PaymentButton.Location = new System.Drawing.Point(158, 530);
            this.PaymentButton.Name = "PaymentButton";
            this.PaymentButton.Size = new System.Drawing.Size(196, 56);
            this.PaymentButton.TabIndex = 0;
            this.PaymentButton.Text = "Payment";
            this.PaymentButton.UseVisualStyleBackColor = false;
            this.PaymentButton.Click += new System.EventHandler(this.PaymentButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogoutButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LogoutButton.Location = new System.Drawing.Point(489, 530);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(169, 56);
            this.LogoutButton.TabIndex = 2;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 660);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.PaymentButton);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PaymentButton;
        private System.Windows.Forms.Button LogoutButton;
    }
}