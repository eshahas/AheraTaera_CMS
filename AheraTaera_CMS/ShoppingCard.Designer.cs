
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
            this.ShoppingListView = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Name = new System.Windows.Forms.ColumnHeader();
            this.Qty = new System.Windows.Forms.ColumnHeader();
            this.UnitPrice = new System.Windows.Forms.ColumnHeader();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ViewProductButton
            // 
            this.ViewProductButton.BackColor = System.Drawing.Color.White;
            this.ViewProductButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ViewProductButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ViewProductButton.Location = new System.Drawing.Point(365, 526);
            this.ViewProductButton.Name = "ViewProductButton";
            this.ViewProductButton.Size = new System.Drawing.Size(128, 49);
            this.ViewProductButton.TabIndex = 0;
            this.ViewProductButton.Text = "Home";
            this.ViewProductButton.UseVisualStyleBackColor = false;
            this.ViewProductButton.Click += new System.EventHandler(this.ViewProductButton_Click);
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.CheckoutButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckoutButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CheckoutButton.Location = new System.Drawing.Point(107, 526);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.Size = new System.Drawing.Size(128, 49);
            this.CheckoutButton.TabIndex = 1;
            this.CheckoutButton.Text = "Checkout";
            this.CheckoutButton.UseVisualStyleBackColor = false;
            this.CheckoutButton.Click += new System.EventHandler(this.CheckoutButton_Click);
            // 
            // ShoppingListView
            // 
            this.ShoppingListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Name,
            this.Qty,
            this.UnitPrice});
            this.ShoppingListView.FullRowSelect = true;
            this.ShoppingListView.HideSelection = false;
            this.ShoppingListView.Location = new System.Drawing.Point(69, 54);
            this.ShoppingListView.Name = "ShoppingListView";
            this.ShoppingListView.Size = new System.Drawing.Size(633, 305);
            this.ShoppingListView.TabIndex = 2;
            this.ShoppingListView.UseCompatibleStateImageBehavior = false;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 120;
            // 
            // Qty
            // 
            this.Qty.Text = "Qty";
            // 
            // UnitPrice
            // 
            this.UnitPrice.Text = "Unit Price (NZD)";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DeleteButton.Location = new System.Drawing.Point(532, 526);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(112, 49);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalLabel.Location = new System.Drawing.Point(447, 419);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(41, 28);
            this.TotalLabel.TabIndex = 4;
            this.TotalLabel.Text = "0.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(223, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total ( NZD )";
            // 
            // ShoppingCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 617);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ShoppingListView);
            this.Controls.Add(this.CheckoutButton);
            this.Controls.Add(this.ViewProductButton);
         //   this.Name = "ShoppingCard";
            this.Text = "ShoppingCard";
            this.Load += new System.EventHandler(this.ShoppingCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ViewProductButton;
        private System.Windows.Forms.Button CheckoutButton;
        private System.Windows.Forms.ListView ShoppingListView;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Qty;
        private System.Windows.Forms.ColumnHeader UnitPrice;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label label1;
    }
}