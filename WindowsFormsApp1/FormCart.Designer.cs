namespace WindowsFormsApp1
{
    partial class FormCart
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pret_totalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPretTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.brandColumn,
            this.categorieColumn,
            this.pretColumn,
            this.cantitateColumn,
            this.pret_totalColumn});
            this.dataGridView1.Location = new System.Drawing.Point(58, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(812, 309);
            this.dataGridView1.TabIndex = 1;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "Id";
            this.idColumn.MinimumWidth = 6;
            this.idColumn.Name = "idColumn";
            this.idColumn.Width = 71;
            // 
            // brandColumn
            // 
            this.brandColumn.HeaderText = "Brand";
            this.brandColumn.MinimumWidth = 6;
            this.brandColumn.Name = "brandColumn";
            this.brandColumn.Width = 120;
            // 
            // categorieColumn
            // 
            this.categorieColumn.HeaderText = "Categorie";
            this.categorieColumn.MinimumWidth = 6;
            this.categorieColumn.Name = "categorieColumn";
            this.categorieColumn.Width = 124;
            // 
            // pretColumn
            // 
            this.pretColumn.HeaderText = "Pret";
            this.pretColumn.MinimumWidth = 6;
            this.pretColumn.Name = "pretColumn";
            this.pretColumn.Width = 80;
            // 
            // cantitateColumn
            // 
            this.cantitateColumn.HeaderText = "Cantitate";
            this.cantitateColumn.MinimumWidth = 6;
            this.cantitateColumn.Name = "cantitateColumn";
            this.cantitateColumn.Width = 71;
            // 
            // pret_totalColumn
            // 
            this.pret_totalColumn.HeaderText = "Pret total";
            this.pret_totalColumn.MinimumWidth = 6;
            this.pret_totalColumn.Name = "pret_totalColumn";
            this.pret_totalColumn.Width = 90;
            // 
            // lblPretTotal
            // 
            this.lblPretTotal.AutoSize = true;
            this.lblPretTotal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPretTotal.Location = new System.Drawing.Point(686, 381);
            this.lblPretTotal.Name = "lblPretTotal";
            this.lblPretTotal.Size = new System.Drawing.Size(0, 23);
            this.lblPretTotal.TabIndex = 2;
            // 
            // FormCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 499);
            this.Controls.Add(this.lblPretTotal);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormCart";
            this.Text = "FormCart";
            this.Load += new System.EventHandler(this.FormCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblPretTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorieColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pret_totalColumn;
    }
}