using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form 
    {

       
        grop_accont qrop= new grop_accont();
        public Form1()
        {
            InitializeComponent();
        }
        public void refresh()
        {
           
            dataGridView1.DataSource = qrop.refresh();
            textBox1.Text = null;
            textBox2.Text = null;

        }

        private void add_Click(object sender, EventArgs e)
        {
            
           qrop.insert(textBox1.Text);
            refresh();
        }

        private void refrish_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            }
        }

        private void ubdet_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                int id = int.Parse(textBox2.Text);
                string ne = textBox1.Text;
                qrop.udeit(id, ne);
               
                refresh();
            }
        }

        private void delet_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                int id = int.Parse(textBox2.Text);
                qrop.Delet(id);
                refresh();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
