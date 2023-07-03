namespace WindowsFormsApp1
{
    partial class FormStart
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblClientNume = new System.Windows.Forms.Label();
            this.lblClientAdresa = new System.Windows.Forms.Label();
            this.lblClientTelefon = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelMenu.Controls.Add(this.btnCart);
            this.panelMenu.Controls.Add(this.btnList);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 568);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelLogo.Controls.Add(this.lblClientTelefon);
            this.panelLogo.Controls.Add(this.lblClientNume);
            this.panelLogo.Controls.Add(this.lblClientAdresa);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.panelTitleBar);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(951, 568);
            this.panelDesktop.TabIndex = 1;
            // 
            // btnCart
            // 
            this.btnCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.ForeColor = System.Drawing.Color.White;
            this.btnCart.Image = global::WindowsFormsApp1.Properties.Resources.cart_78_32;
            this.btnCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.Location = new System.Drawing.Point(0, 140);
            this.btnCart.Name = "btnCart";
            this.btnCart.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnCart.Size = new System.Drawing.Size(220, 60);
            this.btnCart.TabIndex = 2;
            this.btnCart.Text = "   Cos";
            this.btnCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnList
            // 
            this.btnList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.Image = global::WindowsFormsApp1.Properties.Resources.view_details_32;
            this.btnList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnList.Location = new System.Drawing.Point(0, 80);
            this.btnList.Name = "btnList";
            this.btnList.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnList.Size = new System.Drawing.Size(220, 60);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "   Produse";
            this.btnList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Teal;
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(951, 80);
            this.panelTitleBar.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(428, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(62, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Hello";
            // 
            // lblClientNume
            // 
            this.lblClientNume.AutoSize = true;
            this.lblClientNume.ForeColor = System.Drawing.Color.White;
            this.lblClientNume.Location = new System.Drawing.Point(78, 17);
            this.lblClientNume.Name = "lblClientNume";
            this.lblClientNume.Size = new System.Drawing.Size(44, 16);
            this.lblClientNume.TabIndex = 0;
            this.lblClientNume.Text = "label1";
            // 
            // lblClientAdresa
            // 
            this.lblClientAdresa.AutoSize = true;
            this.lblClientAdresa.ForeColor = System.Drawing.Color.White;
            this.lblClientAdresa.Location = new System.Drawing.Point(78, 33);
            this.lblClientAdresa.Name = "lblClientAdresa";
            this.lblClientAdresa.Size = new System.Drawing.Size(44, 16);
            this.lblClientAdresa.TabIndex = 1;
            this.lblClientAdresa.Text = "label2";
            // 
            // lblClientTelefon
            // 
            this.lblClientTelefon.AutoSize = true;
            this.lblClientTelefon.ForeColor = System.Drawing.Color.White;
            this.lblClientTelefon.Location = new System.Drawing.Point(78, 49);
            this.lblClientTelefon.Name = "lblClientTelefon";
            this.lblClientTelefon.Size = new System.Drawing.Size(44, 16);
            this.lblClientTelefon.TabIndex = 2;
            this.lblClientTelefon.Text = "label3";
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 568);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormStart";
            this.Text = "FormStart";
            this.Load += new System.EventHandler(this.FormStart_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblClientTelefon;
        private System.Windows.Forms.Label lblClientAdresa;
        private System.Windows.Forms.Label lblClientNume;
    }
}