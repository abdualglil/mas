using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class formitem : Form
    {
        item item = new item();
        int id;

        public formitem()
        {
            InitializeComponent();
        }
        public void refrish() { dataGridView1.DataSource = item.refresh();
        textBox3.Text = null;
        textBox2.Text =" 0";
        textBox1.Text =" 0";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            refrish();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox3.Text;
            int quntet =int.Parse( textBox2.Text);
            int p_quntet = int.Parse(textBox1.Text);
            int pric_sal = int.Parse(textBox4.Text);
            if (quntet == null) { quntet = 0; }
            if (p_quntet == null) { p_quntet = 0; }
            if (pric_sal == null) { pric_sal = 0; }
            if (pric_sal < p_quntet)
            {
                MessageBox.Show("يجب ان يكون سعر البيع اكبر من سعر الشراء");
            }
            else {
            item.insert_new(name, quntet, p_quntet, pric_sal);
            refrish(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                int a=int.Parse(textBox1.Text);
                item.udeit(id,textBox3.Text,a);
                refrish();
            }
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                textBox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                 id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());


            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
