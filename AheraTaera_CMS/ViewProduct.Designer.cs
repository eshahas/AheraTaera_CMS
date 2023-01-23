
namespace AheraTaera_CMS
{
    partial class ViewProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProduct));
            this.userLabel = new System.Windows.Forms.Label();
            this.LogoutBotton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.AddtoCartButton = new System.Windows.Forms.Button();
            this.ShoppingCardButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DashboardButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userLabel.Location = new System.Drawing.Point(26, 206);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(83, 32);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "label1";
            // 
            // LogoutBotton
            // 
            this.LogoutBotton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogoutBotton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LogoutBotton.Location = new System.Drawing.Point(26, 701);
            this.LogoutBotton.Name = "LogoutBotton";
            this.LogoutBotton.Size = new System.Drawing.Size(224, 52);
            this.LogoutBotton.TabIndex = 1;
            this.LogoutBotton.Text = "Logout";
            this.LogoutBotton.UseVisualStyleBackColor = true;
            this.LogoutBotton.Click += new System.EventHandler(this.LogoutBotton_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(321, 23);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(929, 753);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Description";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price (NZD)";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Category";
            // 
            // AddtoCartButton
            // 
            this.AddtoCartButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddtoCartButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddtoCartButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AddtoCartButton.Location = new System.Drawing.Point(26, 285);
            this.AddtoCartButton.Name = "AddtoCartButton";
            this.AddtoCartButton.Size = new System.Drawing.Size(235, 57);
            this.AddtoCartButton.TabIndex = 4;
            this.AddtoCartButton.Text = "Add to Cart";
            this.AddtoCartButton.UseVisualStyleBackColor = false;
            this.AddtoCartButton.Click += new System.EventHandler(this.AddtoCartButton_Click);
            // 
            // ShoppingCardButton
            // 
            this.ShoppingCardButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.ShoppingCardButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShoppingCardButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ShoppingCardButton.Location = new System.Drawing.Point(26, 359);
            this.ShoppingCardButton.Name = "ShoppingCardButton";
            this.ShoppingCardButton.Size = new System.Drawing.Size(235, 53);
            this.ShoppingCardButton.TabIndex = 6;
            this.ShoppingCardButton.Text = "SHopping Card";
            this.ShoppingCardButton.UseVisualStyleBackColor = false;
            this.ShoppingCardButton.Click += new System.EventHandler(this.ShoppingCardButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // DashboardButton
            // 
            this.DashboardButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DashboardButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DashboardButton.Location = new System.Drawing.Point(26, 558);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Size = new System.Drawing.Size(224, 56);
            this.DashboardButton.TabIndex = 8;
            this.DashboardButton.Text = "Dashboard";
            this.DashboardButton.UseVisualStyleBackColor = true;
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);
            // 
            // ViewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 824);
            this.Controls.Add(this.DashboardButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ShoppingCardButton);
            this.Controls.Add(this.AddtoCartButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.LogoutBotton);
            this.Controls.Add(this.userLabel);
            this.Name = "ViewProduct";
            this.Text = "ViewProduct";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Button LogoutBotton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button AddtoCartButton;
        private System.Windows.Forms.Button ShoppingCardButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DashboardButton;
    }
}