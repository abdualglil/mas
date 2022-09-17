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
    public partial class Storeg : Form
    {
        item item = new item();
        public Storeg()
        {
            InitializeComponent();
        }

        private void Storeg_Load(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = 1;
            comboBox1.DataSource = item.return_item();
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id_item";
            chek();

        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            chek();
        }
        public void chek()
        {
            if (comboBox2.SelectedIndex == 1)
            {
                comboBox1.Enabled = false;
            }
            else if (comboBox2.SelectedIndex == 0)
            {
                comboBox1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 1)
            {
                dataGridView1.DataSource = item.getstoreg_all();
            }
            else if (comboBox2.SelectedIndex == 0)
            {
                int id_item = int.Parse(comboBox1.SelectedValue.ToString());
                dataGridView1.DataSource = item.getstoreg_on(id_item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
