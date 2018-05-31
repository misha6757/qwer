namespace WindowsFormsApp4
{
    partial class Form4
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
            this.bazaDataSet1 = new WindowsFormsApp4.bazaDataSet1();
            this.vseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vseTableAdapter = new WindowsFormsApp4.bazaDataSet1TableAdapters.vseTableAdapter();
            this.vseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkompDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idskladDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vseDataGridViewTextBoxColumn,
            this.idpostDataGridViewTextBoxColumn,
            this.idkompDataGridViewTextBoxColumn,
            this.idskladDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(86, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 184);
            this.dataGridView1.TabIndex = 0;
            // 
            // bazaDataSet1
            // 
            this.bazaDataSet1.DataSetName = "bazaDataSet1";
            this.bazaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vseBindingSource
            // 
            this.vseBindingSource.DataMember = "vse";
            this.vseBindingSource.DataSource = this.bazaDataSet1;
            // 
            // vseTableAdapter
            // 
            this.vseTableAdapter.ClearBeforeFill = true;
            // 
            // vseDataGridViewTextBoxColumn
            // 
            this.vseDataGridViewTextBoxColumn.DataPropertyName = "vse";
            this.vseDataGridViewTextBoxColumn.HeaderText = "vse";
            this.vseDataGridViewTextBoxColumn.Name = "vseDataGridViewTextBoxColumn";
            // 
            // idpostDataGridViewTextBoxColumn
            // 
            this.idpostDataGridViewTextBoxColumn.DataPropertyName = "idpost";
            this.idpostDataGridViewTextBoxColumn.HeaderText = "idpost";
            this.idpostDataGridViewTextBoxColumn.Name = "idpostDataGridViewTextBoxColumn";
            // 
            // idkompDataGridViewTextBoxColumn
            // 
            this.idkompDataGridViewTextBoxColumn.DataPropertyName = "idkomp";
            this.idkompDataGridViewTextBoxColumn.HeaderText = "idkomp";
            this.idkompDataGridViewTextBoxColumn.Name = "idkompDataGridViewTextBoxColumn";
            // 
            // idskladDataGridViewTextBoxColumn
            // 
            this.idskladDataGridViewTextBoxColumn.DataPropertyName = "idsklad";
            this.idskladDataGridViewTextBoxColumn.HeaderText = "idsklad";
            this.idskladDataGridViewTextBoxColumn.Name = "idskladDataGridViewTextBoxColumn";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private bazaDataSet1 bazaDataSet1;
        private System.Windows.Forms.BindingSource vseBindingSource;
        private bazaDataSet1TableAdapters.vseTableAdapter vseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkompDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idskladDataGridViewTextBoxColumn;
    }
}