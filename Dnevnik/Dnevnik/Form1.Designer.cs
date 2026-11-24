namespace Dnevnik
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.классыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оценкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предметыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ученикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учителяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.классыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.идПредметаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеПредметаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.предметыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.microsoft_Access_DatabaseDataSet = new Dnevnik.Microsoft_Access_DatabaseDataSet();
            this.идУчителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.учителяBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.идУченикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.классDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ученикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.идОценкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ученикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.предметDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.учительDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оценкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оценкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.идКлассаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеКлассаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.microsoftAccessDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.классыTableAdapter = new Dnevnik.Microsoft_Access_DatabaseDataSetTableAdapters.КлассыTableAdapter();
            this.оценкиTableAdapter = new Dnevnik.Microsoft_Access_DatabaseDataSetTableAdapters.ОценкиTableAdapter();
            this.предметыTableAdapter = new Dnevnik.Microsoft_Access_DatabaseDataSetTableAdapters.ПредметыTableAdapter();
            this.ученикиTableAdapter = new Dnevnik.Microsoft_Access_DatabaseDataSetTableAdapters.УченикиTableAdapter();
            this.учителяTableAdapter = new Dnevnik.Microsoft_Access_DatabaseDataSetTableAdapters.УчителяTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.классыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.microsoft_Access_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учителяBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ученикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оценкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.microsoftAccessDatabaseDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem,
            this.добавитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.классыToolStripMenuItem,
            this.оценкиToolStripMenuItem,
            this.предметыToolStripMenuItem,
            this.ученикиToolStripMenuItem,
            this.учителяToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // классыToolStripMenuItem
            // 
            this.классыToolStripMenuItem.Name = "классыToolStripMenuItem";
            this.классыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.классыToolStripMenuItem.Text = "Классы";
            this.классыToolStripMenuItem.Click += new System.EventHandler(this.классыToolStripMenuItem_Click);
            // 
            // оценкиToolStripMenuItem
            // 
            this.оценкиToolStripMenuItem.Name = "оценкиToolStripMenuItem";
            this.оценкиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оценкиToolStripMenuItem.Text = "Оценки";
            this.оценкиToolStripMenuItem.Click += new System.EventHandler(this.оценкиToolStripMenuItem_Click);
            // 
            // предметыToolStripMenuItem
            // 
            this.предметыToolStripMenuItem.Name = "предметыToolStripMenuItem";
            this.предметыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.предметыToolStripMenuItem.Text = "Предметы ";
            this.предметыToolStripMenuItem.Click += new System.EventHandler(this.предметыToolStripMenuItem_Click);
            // 
            // ученикиToolStripMenuItem
            // 
            this.ученикиToolStripMenuItem.Name = "ученикиToolStripMenuItem";
            this.ученикиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ученикиToolStripMenuItem.Text = "Ученики";
            this.ученикиToolStripMenuItem.Click += new System.EventHandler(this.ученикиToolStripMenuItem_Click);
            // 
            // учителяToolStripMenuItem
            // 
            this.учителяToolStripMenuItem.Name = "учителяToolStripMenuItem";
            this.учителяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.учителяToolStripMenuItem.Text = "Учителя";
            this.учителяToolStripMenuItem.Click += new System.EventHandler(this.учителяToolStripMenuItem_Click);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.идКлассаDataGridViewTextBoxColumn,
            this.названиеКлассаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.классыBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 426);
            this.dataGridView1.TabIndex = 1;
            // 
            // классыBindingSource
            // 
            this.классыBindingSource.DataMember = "Классы";
            this.классыBindingSource.DataSource = this.microsoftAccessDatabaseDataSetBindingSource;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.идОценкиDataGridViewTextBoxColumn,
            this.ученикDataGridViewTextBoxColumn,
            this.предметDataGridViewTextBoxColumn,
            this.учительDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.оценкаDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.оценкиBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 24);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(800, 426);
            this.dataGridView2.TabIndex = 2;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.идУченикаDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.датаРожденияDataGridViewTextBoxColumn,
            this.классDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.ученикиBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 24);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(800, 426);
            this.dataGridView3.TabIndex = 3;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.идУчителяDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn1});
            this.dataGridView4.DataSource = this.учителяBindingSource;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(0, 24);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(800, 426);
            this.dataGridView4.TabIndex = 4;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.идПредметаDataGridViewTextBoxColumn,
            this.названиеПредметаDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.предметыBindingSource;
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView5.Location = new System.Drawing.Point(0, 24);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(800, 426);
            this.dataGridView5.TabIndex = 5;
            // 
            // идПредметаDataGridViewTextBoxColumn
            // 
            this.идПредметаDataGridViewTextBoxColumn.DataPropertyName = "Ид_Предмета";
            this.идПредметаDataGridViewTextBoxColumn.HeaderText = "Ид_Предмета";
            this.идПредметаDataGridViewTextBoxColumn.Name = "идПредметаDataGridViewTextBoxColumn";
            // 
            // названиеПредметаDataGridViewTextBoxColumn
            // 
            this.названиеПредметаDataGridViewTextBoxColumn.DataPropertyName = "Название_Предмета";
            this.названиеПредметаDataGridViewTextBoxColumn.HeaderText = "Название_Предмета";
            this.названиеПредметаDataGridViewTextBoxColumn.Name = "названиеПредметаDataGridViewTextBoxColumn";
            // 
            // предметыBindingSource
            // 
            this.предметыBindingSource.DataMember = "Предметы";
            this.предметыBindingSource.DataSource = this.microsoft_Access_DatabaseDataSet;
            // 
            // microsoft_Access_DatabaseDataSet
            // 
            this.microsoft_Access_DatabaseDataSet.DataSetName = "Microsoft_Access_DatabaseDataSet";
            this.microsoft_Access_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // идУчителяDataGridViewTextBoxColumn
            // 
            this.идУчителяDataGridViewTextBoxColumn.DataPropertyName = "Ид_Учителя";
            this.идУчителяDataGridViewTextBoxColumn.HeaderText = "Ид_Учителя";
            this.идУчителяDataGridViewTextBoxColumn.Name = "идУчителяDataGridViewTextBoxColumn";
            // 
            // фИОDataGridViewTextBoxColumn1
            // 
            this.фИОDataGridViewTextBoxColumn1.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.Name = "фИОDataGridViewTextBoxColumn1";
            // 
            // учителяBindingSource
            // 
            this.учителяBindingSource.DataMember = "Учителя";
            this.учителяBindingSource.DataSource = this.microsoft_Access_DatabaseDataSet;
            // 
            // идУченикаDataGridViewTextBoxColumn
            // 
            this.идУченикаDataGridViewTextBoxColumn.DataPropertyName = "Ид_Ученика";
            this.идУченикаDataGridViewTextBoxColumn.HeaderText = "Ид_Ученика";
            this.идУченикаDataGridViewTextBoxColumn.Name = "идУченикаDataGridViewTextBoxColumn";
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // датаРожденияDataGridViewTextBoxColumn
            // 
            this.датаРожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата_Рождения";
            this.датаРожденияDataGridViewTextBoxColumn.HeaderText = "Дата_Рождения";
            this.датаРожденияDataGridViewTextBoxColumn.Name = "датаРожденияDataGridViewTextBoxColumn";
            // 
            // классDataGridViewTextBoxColumn
            // 
            this.классDataGridViewTextBoxColumn.DataPropertyName = "Класс";
            this.классDataGridViewTextBoxColumn.HeaderText = "Класс";
            this.классDataGridViewTextBoxColumn.Name = "классDataGridViewTextBoxColumn";
            // 
            // ученикиBindingSource
            // 
            this.ученикиBindingSource.DataMember = "Ученики";
            this.ученикиBindingSource.DataSource = this.microsoft_Access_DatabaseDataSet;
            // 
            // идОценкиDataGridViewTextBoxColumn
            // 
            this.идОценкиDataGridViewTextBoxColumn.DataPropertyName = "Ид_Оценки";
            this.идОценкиDataGridViewTextBoxColumn.HeaderText = "Ид_Оценки";
            this.идОценкиDataGridViewTextBoxColumn.Name = "идОценкиDataGridViewTextBoxColumn";
            // 
            // ученикDataGridViewTextBoxColumn
            // 
            this.ученикDataGridViewTextBoxColumn.DataPropertyName = "Ученик";
            this.ученикDataGridViewTextBoxColumn.HeaderText = "Ученик";
            this.ученикDataGridViewTextBoxColumn.Name = "ученикDataGridViewTextBoxColumn";
            // 
            // предметDataGridViewTextBoxColumn
            // 
            this.предметDataGridViewTextBoxColumn.DataPropertyName = "Предмет";
            this.предметDataGridViewTextBoxColumn.HeaderText = "Предмет";
            this.предметDataGridViewTextBoxColumn.Name = "предметDataGridViewTextBoxColumn";
            // 
            // учительDataGridViewTextBoxColumn
            // 
            this.учительDataGridViewTextBoxColumn.DataPropertyName = "Учитель";
            this.учительDataGridViewTextBoxColumn.HeaderText = "Учитель";
            this.учительDataGridViewTextBoxColumn.Name = "учительDataGridViewTextBoxColumn";
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // оценкаDataGridViewTextBoxColumn
            // 
            this.оценкаDataGridViewTextBoxColumn.DataPropertyName = "Оценка";
            this.оценкаDataGridViewTextBoxColumn.HeaderText = "Оценка";
            this.оценкаDataGridViewTextBoxColumn.Name = "оценкаDataGridViewTextBoxColumn";
            // 
            // оценкиBindingSource
            // 
            this.оценкиBindingSource.DataMember = "Оценки";
            this.оценкиBindingSource.DataSource = this.microsoft_Access_DatabaseDataSet;
            // 
            // идКлассаDataGridViewTextBoxColumn
            // 
            this.идКлассаDataGridViewTextBoxColumn.DataPropertyName = "Ид_Класса";
            this.идКлассаDataGridViewTextBoxColumn.HeaderText = "Ид_Класса";
            this.идКлассаDataGridViewTextBoxColumn.Name = "идКлассаDataGridViewTextBoxColumn";
            // 
            // названиеКлассаDataGridViewTextBoxColumn
            // 
            this.названиеКлассаDataGridViewTextBoxColumn.DataPropertyName = "Название_Класса";
            this.названиеКлассаDataGridViewTextBoxColumn.HeaderText = "Название_Класса";
            this.названиеКлассаDataGridViewTextBoxColumn.Name = "названиеКлассаDataGridViewTextBoxColumn";
            // 
            // microsoftAccessDatabaseDataSetBindingSource
            // 
            this.microsoftAccessDatabaseDataSetBindingSource.DataSource = this.microsoft_Access_DatabaseDataSet;
            this.microsoftAccessDatabaseDataSetBindingSource.Position = 0;
            // 
            // классыTableAdapter
            // 
            this.классыTableAdapter.ClearBeforeFill = true;
            // 
            // оценкиTableAdapter
            // 
            this.оценкиTableAdapter.ClearBeforeFill = true;
            // 
            // предметыTableAdapter
            // 
            this.предметыTableAdapter.ClearBeforeFill = true;
            // 
            // ученикиTableAdapter
            // 
            this.ученикиTableAdapter.ClearBeforeFill = true;
            // 
            // учителяTableAdapter
            // 
            this.учителяTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.классыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.microsoft_Access_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учителяBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ученикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оценкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.microsoftAccessDatabaseDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem классыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оценкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предметыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ученикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учителяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource microsoftAccessDatabaseDataSetBindingSource;
        private Microsoft_Access_DatabaseDataSet microsoft_Access_DatabaseDataSet;
        private System.Windows.Forms.BindingSource классыBindingSource;
        private Microsoft_Access_DatabaseDataSetTableAdapters.КлассыTableAdapter классыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn идКлассаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеКлассаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.BindingSource оценкиBindingSource;
        private Microsoft_Access_DatabaseDataSetTableAdapters.ОценкиTableAdapter оценкиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn идОценкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ученикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn предметDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn учительDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оценкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource предметыBindingSource;
        private Microsoft_Access_DatabaseDataSetTableAdapters.ПредметыTableAdapter предметыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn идПредметаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеПредметаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ученикиBindingSource;
        private Microsoft_Access_DatabaseDataSetTableAdapters.УченикиTableAdapter ученикиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn идУченикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn классDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource учителяBindingSource;
        private Microsoft_Access_DatabaseDataSetTableAdapters.УчителяTableAdapter учителяTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn идУчителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn1;
    }
}

