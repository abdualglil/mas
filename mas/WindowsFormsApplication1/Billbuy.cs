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
    public partial class Billbuy : Form
    {


        Buy buy = new Buy();
        string deeta = DateTime.Now.ToString("yyyy/MM/dd");
        int id_o;
        static int typ = 2;
        int num_id = 0;
        acoont acont = new acoont();
        public Billbuy()
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
                buy.insert_new(1, id_accont, deeta, neam);
                label5.Text = buy.numper();
                show();
            }
            else
            {
                MessageBox.Show("يرجى ادخال اسم العميل");
            }



        }

        private void Billbuy_Load(object sender, EventArgs e)
        {


            comboBox1.DataSource = acont.reternaccont();
            comboBox1.DisplayMember = "nema";
            comboBox1.ValueMember = "id_accont";
            comboBox2.SelectedIndex = 0;


        }
        public void acoont_show(int id_accont)
        {
            comboBox1.DataSource = acont.get_acont_waer(id_accont);
            comboBox1.DisplayMember = "nema";
            comboBox1.ValueMember = "id_accont";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void show()
        {
            item item = new item();
            comboBox3.DataSource = item.return_item();
            comboBox3.DisplayMember = "name";
            comboBox3.ValueMember = "id_item";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id_item = int.Parse(comboBox3.SelectedValue.ToString());
            id_o = int.Parse(label5.Text);
            int qu = int.Parse(textBox1.Text);
            int pric = int.Parse(textBox2.Text);
            buy.add_item(id_item, 2, id_o, deeta, qu, pric);
            ref_tep();
            sum.Text = buy.sum(id_o);
        }
        public void ref_tep()
        {
            dataGridView1.DataSource = buy.tab_item(id_o);
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox3.SelectedValue = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id_item = int.Parse(comboBox3.SelectedValue.ToString());

            int qu = int.Parse(textBox1.Text);
            int pric = int.Parse(textBox2.Text);
            buy.ubdet_item(id_item, 2, id_o, qu, pric);
            ref_tep();
            sum.Text = buy.sum(id_o);
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
            chek();
        }
        public void chek()
        {

            if (comboBox2.SelectedIndex == 1)
            {
                acoont_show(17);
            }

        }
    }
}
