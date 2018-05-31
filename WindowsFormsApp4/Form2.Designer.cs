namespace WindowsFormsApp4
{
    partial class Form2
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
            this.skladBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladTableAdapter = new WindowsFormsApp4.bazaDataSet1TableAdapters.skladTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.idskladDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поставщикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idskladDataGridViewTextBoxColumn,
            this.mestoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.skladBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(86, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(247, 223);
            this.dataGridView1.TabIndex = 0;
            // 
            // bazaDataSet1
            // 
            this.bazaDataSet1.DataSetName = "bazaDataSet1";
            this.bazaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // skladBindingSource
            // 
            this.skladBindingSource.DataMember = "sklad";
            this.skladBindingSource.DataSource = this.bazaDataSet1;
            // 
            // skladTableAdapter
            // 
            this.skladTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(451, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(451, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(451, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Заполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(86, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.skladBindingSource;
            this.comboBox1.DisplayMember = "idsklad";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 276);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "idsklad";
            // 
            // idskladDataGridViewTextBoxColumn
            // 
            this.idskladDataGridViewTextBoxColumn.DataPropertyName = "idsklad";
            this.idskladDataGridViewTextBoxColumn.HeaderText = "номер склада";
            this.idskladDataGridViewTextBoxColumn.Name = "idskladDataGridViewTextBoxColumn";
            // 
            // mestoDataGridViewTextBoxColumn
            // 
            this.mestoDataGridViewTextBoxColumn.DataPropertyName = "mesto";
            this.mestoDataGridViewTextBoxColumn.HeaderText = "адрес";
            this.mestoDataGridViewTextBoxColumn.Name = "mestoDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "номер склада";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "адресс";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поставщикToolStripMenuItem,
            this.товарToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поставщикToolStripMenuItem
            // 
            this.поставщикToolStripMenuItem.Name = "поставщикToolStripMenuItem";
            this.поставщикToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.поставщикToolStripMenuItem.Text = "поставщик";
            this.поставщикToolStripMenuItem.Click += new System.EventHandler(this.поставщикToolStripMenuItem_Click);
            // 
            // товарToolStripMenuItem
            // 
            this.товарToolStripMenuItem.Name = "товарToolStripMenuItem";
            this.товарToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.товарToolStripMenuItem.Text = "товар";
            this.товарToolStripMenuItem.Click += new System.EventHandler(this.товарToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private bazaDataSet1 bazaDataSet1;
        private System.Windows.Forms.BindingSource skladBindingSource;
        private bazaDataSet1TableAdapters.skladTableAdapter skladTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idskladDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поставщикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарToolStripMenuItem;
    }
}