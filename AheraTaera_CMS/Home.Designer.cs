
namespace AheraTaera_CMS
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.userLabel = new System.Windows.Forms.Label();
            this.LogoutBotton = new System.Windows.Forms.Button();
            this.AddtoCartButton = new System.Windows.Forms.Button();
            this.ShoppingCardButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DashboardButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(314, 56);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(827, 658);
            this.dataGridView1.TabIndex = 9;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 819);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DashboardButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ShoppingCardButton);
            this.Controls.Add(this.AddtoCartButton);
            this.Controls.Add(this.LogoutBotton);
            this.Controls.Add(this.userLabel);
            this.Name = "Home";
            this.Text = "ViewProduct";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Button LogoutBotton;
        private System.Windows.Forms.Button AddtoCartButton;
        private System.Windows.Forms.Button ShoppingCardButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DashboardButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}