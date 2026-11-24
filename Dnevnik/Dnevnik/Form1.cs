using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dnevnik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_DatabaseDataSet.Учителя". При необходимости она может быть перемещена или удалена.
            this.учителяTableAdapter.Fill(this.microsoft_Access_DatabaseDataSet.Учителя);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_DatabaseDataSet.Ученики". При необходимости она может быть перемещена или удалена.
            this.ученикиTableAdapter.Fill(this.microsoft_Access_DatabaseDataSet.Ученики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_DatabaseDataSet.Предметы". При необходимости она может быть перемещена или удалена.
            this.предметыTableAdapter.Fill(this.microsoft_Access_DatabaseDataSet.Предметы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_DatabaseDataSet.Оценки". При необходимости она может быть перемещена или удалена.
            this.оценкиTableAdapter.Fill(this.microsoft_Access_DatabaseDataSet.Оценки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_DatabaseDataSet.Классы". При необходимости она может быть перемещена или удалена.
            this.классыTableAdapter.Fill(this.microsoft_Access_DatabaseDataSet.Классы);

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();   
        }

        private void классыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
        }

        private void оценкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
        }

        private void предметыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = true;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
        }

        private void ученикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = true;
            dataGridView5.Visible = false;
        }

        private void учителяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = true;
        }
    }
}
