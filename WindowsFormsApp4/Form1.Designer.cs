namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bazaDataSet1 = new WindowsFormsApp4.bazaDataSet1();
            this.kompBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kompTableAdapter = new WindowsFormsApp4.bazaDataSet1TableAdapters.kompTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idkompDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tovarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поставщикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.складToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kompBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkompDataGridViewTextBoxColumn,
            this.tovarDataGridViewTextBoxColumn,
            this.opisanieDataGridViewTextBoxColumn,
            this.chenaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kompBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(82, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 225);
            this.dataGridView1.TabIndex = 0;
            // 
            // bazaDataSet1
            // 
            this.bazaDataSet1.DataSetName = "bazaDataSet1";
            this.bazaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kompBindingSource
            // 
            this.kompBindingSource.DataMember = "komp";
            this.kompBindingSource.DataSource = this.bazaDataSet1;
            // 
            // kompTableAdapter
            // 
            this.kompTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(621, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(621, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(621, 139);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(621, 195);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(621, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "заполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.kompBindingSource;
            this.comboBox1.DisplayMember = "idkomp";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(215, 284);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "idkomp";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(215, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(564, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "товар";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(564, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "описание";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(564, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "цена";
            // 
            // idkompDataGridViewTextBoxColumn
            // 
            this.idkompDataGridViewTextBoxColumn.DataPropertyName = "idkomp";
            this.idkompDataGridViewTextBoxColumn.HeaderText = "номер";
            this.idkompDataGridViewTextBoxColumn.Name = "idkompDataGridViewTextBoxColumn";
            // 
            // tovarDataGridViewTextBoxColumn
            // 
            this.tovarDataGridViewTextBoxColumn.DataPropertyName = "tovar";
            this.tovarDataGridViewTextBoxColumn.HeaderText = "товар";
            this.tovarDataGridViewTextBoxColumn.Name = "tovarDataGridViewTextBoxColumn";
            // 
            // opisanieDataGridViewTextBoxColumn
            // 
            this.opisanieDataGridViewTextBoxColumn.DataPropertyName = "opisanie";
            this.opisanieDataGridViewTextBoxColumn.HeaderText = "описание";
            this.opisanieDataGridViewTextBoxColumn.Name = "opisanieDataGridViewTextBoxColumn";
            // 
            // chenaDataGridViewTextBoxColumn
            // 
            this.chenaDataGridViewTextBoxColumn.DataPropertyName = "chena";
            this.chenaDataGridViewTextBoxColumn.HeaderText = "цена";
            this.chenaDataGridViewTextBoxColumn.Name = "chenaDataGridViewTextBoxColumn";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(390, 282);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "цена по возрастанию";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поставщикToolStripMenuItem,
            this.складToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поставщикToolStripMenuItem
            // 
            this.поставщикToolStripMenuItem.Name = "поставщикToolStripMenuItem";
            this.поставщикToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.поставщикToolStripMenuItem.Text = "поставщик";
            this.поставщикToolStripMenuItem.Click += new System.EventHandler(this.поставщикToolStripMenuItem_Click);
            // 
            // складToolStripMenuItem
            // 
            this.складToolStripMenuItem.Name = "складToolStripMenuItem";
            this.складToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.складToolStripMenuItem.Text = "склад";
            this.складToolStripMenuItem.Click += new System.EventHandler(this.складToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kompBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private bazaDataSet1 bazaDataSet1;
        private System.Windows.Forms.BindingSource kompBindingSource;
        private bazaDataSet1TableAdapters.kompTableAdapter kompTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkompDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поставщикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem складToolStripMenuItem;
    }
}

