namespace Mall_Shoprite
{
    partial class shoprite
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
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.subStockPanel = new System.Windows.Forms.Panel();
            this.addStockBtn = new System.Windows.Forms.Button();
            this.adjustStockBtn = new System.Windows.Forms.Button();
            this.subProductPanel = new System.Windows.Forms.Panel();
            this.categoryBtn = new System.Windows.Forms.Button();
            this.productListBtn = new System.Windows.Forms.Button();
            this.brandBtn = new System.Windows.Forms.Button();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.stockBtn = new System.Windows.Forms.Button();
            this.productBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.accountsBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.middlepanel = new System.Windows.Forms.Panel();
            this.sidebarPanel.SuspendLayout();
            this.subStockPanel.SuspendLayout();
            this.subProductPanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.sidebarPanel.Controls.Add(this.subStockPanel);
            this.sidebarPanel.Controls.Add(this.subProductPanel);
            this.sidebarPanel.Controls.Add(this.infoPanel);
            this.sidebarPanel.Controls.Add(this.stockBtn);
            this.sidebarPanel.Controls.Add(this.productBtn);
            this.sidebarPanel.Controls.Add(this.logoutBtn);
            this.sidebarPanel.Controls.Add(this.accountsBtn);
            this.sidebarPanel.Controls.Add(this.homeBtn);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.ForeColor = System.Drawing.Color.White;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(208, 653);
            this.sidebarPanel.TabIndex = 0;
            // 
            // subStockPanel
            // 
            this.subStockPanel.Controls.Add(this.addStockBtn);
            this.subStockPanel.Controls.Add(this.adjustStockBtn);
            this.subStockPanel.Location = new System.Drawing.Point(2, 394);
            this.subStockPanel.Name = "subStockPanel";
            this.subStockPanel.Size = new System.Drawing.Size(200, 116);
            this.subStockPanel.TabIndex = 0;
            // 
            // addStockBtn
            // 
            this.addStockBtn.FlatAppearance.BorderSize = 0;
            this.addStockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStockBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStockBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addStockBtn.Location = new System.Drawing.Point(-1, 12);
            this.addStockBtn.Name = "addStockBtn";
            this.addStockBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.addStockBtn.Size = new System.Drawing.Size(200, 45);
            this.addStockBtn.TabIndex = 0;
            this.addStockBtn.Text = "Add to Stock";
            this.addStockBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addStockBtn.UseVisualStyleBackColor = true;
            this.addStockBtn.Click += new System.EventHandler(this.addStockBtn_Click);
            // 
            // adjustStockBtn
            // 
            this.adjustStockBtn.FlatAppearance.BorderSize = 0;
            this.adjustStockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adjustStockBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adjustStockBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adjustStockBtn.Location = new System.Drawing.Point(-2, 63);
            this.adjustStockBtn.Name = "adjustStockBtn";
            this.adjustStockBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.adjustStockBtn.Size = new System.Drawing.Size(200, 45);
            this.adjustStockBtn.TabIndex = 0;
            this.adjustStockBtn.Text = "Adjust Stock";
            this.adjustStockBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adjustStockBtn.UseVisualStyleBackColor = true;
            this.adjustStockBtn.Click += new System.EventHandler(this.adjustStockBtn_Click);
            // 
            // subProductPanel
            // 
            this.subProductPanel.Controls.Add(this.categoryBtn);
            this.subProductPanel.Controls.Add(this.productListBtn);
            this.subProductPanel.Controls.Add(this.brandBtn);
            this.subProductPanel.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.subProductPanel.Location = new System.Drawing.Point(0, 185);
            this.subProductPanel.Name = "subProductPanel";
            this.subProductPanel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.subProductPanel.Size = new System.Drawing.Size(208, 152);
            this.subProductPanel.TabIndex = 0;
            this.subProductPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.subProductPanel_Paint);
            // 
            // categoryBtn
            // 
            this.categoryBtn.FlatAppearance.BorderSize = 0;
            this.categoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoryBtn.Location = new System.Drawing.Point(0, 3);
            this.categoryBtn.Name = "categoryBtn";
            this.categoryBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.categoryBtn.Size = new System.Drawing.Size(200, 45);
            this.categoryBtn.TabIndex = 0;
            this.categoryBtn.Text = "Category";
            this.categoryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoryBtn.UseVisualStyleBackColor = true;
            this.categoryBtn.Click += new System.EventHandler(this.categoryBtn_Click);
            // 
            // productListBtn
            // 
            this.productListBtn.FlatAppearance.BorderSize = 0;
            this.productListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productListBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productListBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productListBtn.Location = new System.Drawing.Point(0, 94);
            this.productListBtn.Name = "productListBtn";
            this.productListBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.productListBtn.Size = new System.Drawing.Size(200, 45);
            this.productListBtn.TabIndex = 0;
            this.productListBtn.Text = "Product List";
            this.productListBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productListBtn.UseVisualStyleBackColor = true;
            this.productListBtn.Click += new System.EventHandler(this.productListBtn_Click);
            // 
            // brandBtn
            // 
            this.brandBtn.FlatAppearance.BorderSize = 0;
            this.brandBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brandBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brandBtn.Location = new System.Drawing.Point(4, 54);
            this.brandBtn.Name = "brandBtn";
            this.brandBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.brandBtn.Size = new System.Drawing.Size(200, 45);
            this.brandBtn.TabIndex = 0;
            this.brandBtn.Text = "Brands";
            this.brandBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brandBtn.UseVisualStyleBackColor = true;
            this.brandBtn.Click += new System.EventHandler(this.brandBtn_Click);
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.label1);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoPanel.Font = new System.Drawing.Font("20th Century Font", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoPanel.Location = new System.Drawing.Point(0, 0);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(208, 100);
            this.infoPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shoprite";
            // 
            // stockBtn
            // 
            this.stockBtn.FlatAppearance.BorderSize = 0;
            this.stockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockBtn.Location = new System.Drawing.Point(0, 343);
            this.stockBtn.Name = "stockBtn";
            this.stockBtn.Size = new System.Drawing.Size(200, 45);
            this.stockBtn.TabIndex = 0;
            this.stockBtn.Text = "Stock";
            this.stockBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockBtn.UseVisualStyleBackColor = true;
            this.stockBtn.Click += new System.EventHandler(this.stockBtn_Click);
            // 
            // productBtn
            // 
            this.productBtn.FlatAppearance.BorderSize = 0;
            this.productBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productBtn.Location = new System.Drawing.Point(0, 147);
            this.productBtn.Name = "productBtn";
            this.productBtn.Size = new System.Drawing.Size(200, 45);
            this.productBtn.TabIndex = 0;
            this.productBtn.Text = "Products";
            this.productBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productBtn.UseVisualStyleBackColor = true;
            this.productBtn.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(0, 608);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(208, 45);
            this.logoutBtn.TabIndex = 0;
            this.logoutBtn.Text = "logout";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // accountsBtn
            // 
            this.accountsBtn.FlatAppearance.BorderSize = 0;
            this.accountsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountsBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountsBtn.Location = new System.Drawing.Point(0, 526);
            this.accountsBtn.Name = "accountsBtn";
            this.accountsBtn.Size = new System.Drawing.Size(200, 45);
            this.accountsBtn.TabIndex = 0;
            this.accountsBtn.Text = "Accounts";
            this.accountsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountsBtn.UseVisualStyleBackColor = true;
            this.accountsBtn.Click += new System.EventHandler(this.accountsBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(2, 106);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(200, 45);
            this.homeBtn.TabIndex = 0;
            this.homeBtn.Text = "Home";
            this.homeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(208, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 34);
            this.panel1.TabIndex = 1;
            // 
            // middlepanel
            // 
            this.middlepanel.BackColor = System.Drawing.Color.White;
            this.middlepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middlepanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.middlepanel.Location = new System.Drawing.Point(208, 34);
            this.middlepanel.Name = "middlepanel";
            this.middlepanel.Size = new System.Drawing.Size(974, 619);
            this.middlepanel.TabIndex = 2;
            this.middlepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.middlepanel_Paint);
            // 
            // shoprite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.middlepanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidebarPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "shoprite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IVM";
            this.sidebarPanel.ResumeLayout(false);
            this.subStockPanel.ResumeLayout(false);
            this.subProductPanel.ResumeLayout(false);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel middlepanel;
        private System.Windows.Forms.Panel subProductPanel;
        private System.Windows.Forms.Button categoryBtn;
        private System.Windows.Forms.Button productListBtn;
        private System.Windows.Forms.Button brandBtn;
        private System.Windows.Forms.Button productBtn;
        private System.Windows.Forms.Button accountsBtn;
        private System.Windows.Forms.Panel subStockPanel;
        private System.Windows.Forms.Button addStockBtn;
        private System.Windows.Forms.Button adjustStockBtn;
        private System.Windows.Forms.Button stockBtn;
        private System.Windows.Forms.Button logoutBtn;
    }
}

