
namespace AheraTaera_CMS
{
    partial class ShoppingCard
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
            this.ViewProductButton = new System.Windows.Forms.Button();
            this.CheckoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewProductButton
            // 
            this.ViewProductButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.ViewProductButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ViewProductButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ViewProductButton.Location = new System.Drawing.Point(204, 332);
            this.ViewProductButton.Name = "ViewProductButton";
            this.ViewProductButton.Size = new System.Drawing.Size(149, 49);
            this.ViewProductButton.TabIndex = 0;
            this.ViewProductButton.Text = "Product List";
            this.ViewProductButton.UseVisualStyleBackColor = false;
            this.ViewProductButton.Click += new System.EventHandler(this.ViewProductButton_Click);
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.CheckoutButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckoutButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CheckoutButton.Location = new System.Drawing.Point(461, 332);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.Size = new System.Drawing.Size(128, 49);
            this.CheckoutButton.TabIndex = 1;
            this.CheckoutButton.Text = "Checkout";
            this.CheckoutButton.UseVisualStyleBackColor = false;
            this.CheckoutButton.Click += new System.EventHandler(this.CheckoutButton_Click);
            // 
            // ShoppingCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckoutButton);
            this.Controls.Add(this.ViewProductButton);
            this.Name = "ShoppingCard";
            this.Text = "ShoppingCard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewProductButton;
        private System.Windows.Forms.Button CheckoutButton;
    }
}