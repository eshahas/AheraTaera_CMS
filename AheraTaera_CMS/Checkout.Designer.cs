
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkout));
            this.PaymentButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.DiscountButton = new System.Windows.Forms.Button();
            this.WeekendDeliveryCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.finalPriceLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.GSTLabel = new System.Windows.Forms.Label();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.HomeDeliveryCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ShipmentCostLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PaymentButton
            // 
            this.PaymentButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.PaymentButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PaymentButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PaymentButton.Location = new System.Drawing.Point(89, 597);
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
            this.LogoutButton.Location = new System.Drawing.Point(629, 595);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(169, 56);
            this.LogoutButton.TabIndex = 2;
            this.LogoutButton.Text = "Cancel";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // DiscountButton
            // 
            this.DiscountButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DiscountButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DiscountButton.Location = new System.Drawing.Point(310, 599);
            this.DiscountButton.Name = "DiscountButton";
            this.DiscountButton.Size = new System.Drawing.Size(198, 52);
            this.DiscountButton.TabIndex = 3;
            this.DiscountButton.Text = "Apply Discount";
            this.DiscountButton.UseVisualStyleBackColor = true;
            this.DiscountButton.Click += new System.EventHandler(this.DiscountButton_Click);
            // 
            // WeekendDeliveryCheckBox
            // 
            this.WeekendDeliveryCheckBox.AutoSize = true;
            this.WeekendDeliveryCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WeekendDeliveryCheckBox.Location = new System.Drawing.Point(126, 475);
            this.WeekendDeliveryCheckBox.Name = "WeekendDeliveryCheckBox";
            this.WeekendDeliveryCheckBox.Size = new System.Drawing.Size(211, 32);
            this.WeekendDeliveryCheckBox.TabIndex = 4;
            this.WeekendDeliveryCheckBox.Text = "Weekend Delivery";
            this.WeekendDeliveryCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(310, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(310, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "GST";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(310, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Discount";
            // 
            // finalPriceLabel
            // 
            this.finalPriceLabel.AutoSize = true;
            this.finalPriceLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.finalPriceLabel.Location = new System.Drawing.Point(310, 424);
            this.finalPriceLabel.Name = "finalPriceLabel";
            this.finalPriceLabel.Size = new System.Drawing.Size(134, 28);
            this.finalPriceLabel.TabIndex = 8;
            this.finalPriceLabel.Text = "Total ( NZD )";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(46, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 38);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ahera Taera";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateLabel.Location = new System.Drawing.Point(407, 70);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(57, 28);
            this.DateLabel.TabIndex = 11;
            this.DateLabel.Text = "Date";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PriceLabel.Location = new System.Drawing.Point(620, 213);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(41, 28);
            this.PriceLabel.TabIndex = 12;
            this.PriceLabel.Text = "0.0";
            // 
            // GSTLabel
            // 
            this.GSTLabel.AutoSize = true;
            this.GSTLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GSTLabel.Location = new System.Drawing.Point(620, 376);
            this.GSTLabel.Name = "GSTLabel";
            this.GSTLabel.Size = new System.Drawing.Size(41, 28);
            this.GSTLabel.TabIndex = 13;
            this.GSTLabel.Text = "0.0";
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.AutoSize = true;
            this.DiscountLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DiscountLabel.Location = new System.Drawing.Point(620, 268);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(41, 28);
            this.DiscountLabel.TabIndex = 14;
            this.DiscountLabel.Text = "0.0";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalLabel.Location = new System.Drawing.Point(620, 424);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(41, 28);
            this.TotalLabel.TabIndex = 15;
            this.TotalLabel.Text = "0.0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(310, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "Customer";
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustomerLabel.Location = new System.Drawing.Point(579, 160);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(32, 28);
            this.CustomerLabel.TabIndex = 17;
            this.CustomerLabel.Text = "....";
            // 
            // HomeDeliveryCheckBox
            // 
            this.HomeDeliveryCheckBox.AutoSize = true;
            this.HomeDeliveryCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HomeDeliveryCheckBox.Location = new System.Drawing.Point(126, 529);
            this.HomeDeliveryCheckBox.Name = "HomeDeliveryCheckBox";
            this.HomeDeliveryCheckBox.Size = new System.Drawing.Size(180, 32);
            this.HomeDeliveryCheckBox.TabIndex = 18;
            this.HomeDeliveryCheckBox.Text = "Home Delivery";
            this.HomeDeliveryCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(310, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "Shipment";
            // 
            // ShipmentCostLabel
            // 
            this.ShipmentCostLabel.AutoSize = true;
            this.ShipmentCostLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShipmentCostLabel.Location = new System.Drawing.Point(620, 322);
            this.ShipmentCostLabel.Name = "ShipmentCostLabel";
            this.ShipmentCostLabel.Size = new System.Drawing.Size(41, 28);
            this.ShipmentCostLabel.TabIndex = 20;
            this.ShipmentCostLabel.Text = "0.0";
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 688);
            this.Controls.Add(this.ShipmentCostLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HomeDeliveryCheckBox);
            this.Controls.Add(this.CustomerLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.DiscountLabel);
            this.Controls.Add(this.GSTLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.finalPriceLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WeekendDeliveryCheckBox);
            this.Controls.Add(this.DiscountButton);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.PaymentButton);
            this.Name = "Checkout";
            this.Text = "Checkout";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PaymentButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button DiscountButton;
        private System.Windows.Forms.CheckBox WeekendDeliveryCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label finalPriceLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label GSTLabel;
        private System.Windows.Forms.Label DiscountLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.CheckBox HomeDeliveryCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ShipmentCostLabel;
    }
}