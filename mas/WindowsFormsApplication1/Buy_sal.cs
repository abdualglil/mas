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
    public partial class Buy_sal : Form
    {
        string deeta = DateTime.Now.ToString("yyyy/MM/dd");
        int id_o;
        sal sal = new sal();
        static int tyb = 1;
        int num_id;
        public Buy_sal()
        {
            InitializeComponent();
        }

        private void add_new_Click(object sender, EventArgs e)
        {
            string neam = name.Text;
            if (neam != "")
            {


                int tay = int.Parse(comboBox2.SelectedIndex.ToString());
                int id_accont = int.Parse(comboBox1.SelectedValue.ToString());
                sal.insert_new(1, id_accont, deeta, neam);
                label5.Text = sal.numper();
                show();
            }
            else
            {
                MessageBox.Show("يرجى ادخال اسم العميل");
            }

        }
        public void show()
        {
            item item = new item();
            comboBox3.DataSource = item.return_item();
            comboBox3.DisplayMember = "name";
            comboBox3.ValueMember = "id_item";

        }

        private void Buy_sal_Load(object sender, EventArgs e)
        {
            acoont acont = new acoont();

            comboBox1.DataSource = acont.reternaccont();
            comboBox1.DisplayMember = "nema";
            comboBox1.ValueMember = "id_accont";
            comboBox2.SelectedIndex = 1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id_item = int.Parse(comboBox3.SelectedValue.ToString());
            id_o = int.Parse(label5.Text);
            int qu = int.Parse(textBox1.Text);
            int pric = int.Parse(textBox2.Text);
            sal.add_item(id_item, 1, id_o, deeta, qu, pric);
            ref_tep();
            sum.Text = sal.sum(id_o);
        }
        public void ref_tep()
        {
            dataGridView1.DataSource = sal.tab_item(id_o);
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox3.SelectedValue = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id_item = int.Parse(comboBox3.SelectedValue.ToString());

            int qu = int.Parse(textBox1.Text);
            int pric = int.Parse(textBox2.Text);
            sal.ubdet_item(id_item, 1, id_o, qu, pric);
            ref_tep();
            sum.Text = sal.sum(id_o);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                try
                {
                    num_id = int.Parse(id);
                }
                catch
                {

                }
                if (num_id > 0) { comboBox3.SelectedValue = num_id; }

                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }




    }
}
