namespace WindowsFormsApp1
{
    partial class FormList
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblNumar = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.addColumn});
            this.dataGridView1.Location = new System.Drawing.Point(58, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(812, 309);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(742, 392);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 33);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Adauga in cos";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblNumar
            // 
            this.lblNumar.AutoSize = true;
            this.lblNumar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNumar.Location = new System.Drawing.Point(720, 436);
            this.lblNumar.Name = "lblNumar";
            this.lblNumar.Size = new System.Drawing.Size(0, 17);
            this.lblNumar.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.categorieColumn.Width = 125;
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
            // addColumn
            // 
            this.addColumn.HeaderText = "Adauga";
            this.addColumn.MinimumWidth = 6;
            this.addColumn.Name = "addColumn";
            this.addColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.addColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.addColumn.Width = 71;
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 500);
            this.Controls.Add(this.lblNumar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormList";
            this.Text = "FormList";
            this.Load += new System.EventHandler(this.FormList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblNumar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorieColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn addColumn;
    }
}