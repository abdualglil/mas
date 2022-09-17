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
    public partial class Form3 : Form
    {         
        grop_accont grop = new grop_accont();
        acoont acco = new acoont();
        int id, id_grop2;
        public Form3()
        {
            
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = grop.copepox();
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id_grop";

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id_grop = int.Parse(comboBox1.SelectedValue.ToString());
            string name = textBox2.Text;
            acco.insert_new(id_grop, name);
            refresh();
 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void refresh()
        {

            dataGridView1.DataSource = acco.refresh();
            textBox2.Text = null;
           

        }

        private void ubdet_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
{
            if (textBox2.Text != "") {  
                id_grop2 = int.Parse(comboBox1.SelectedValue.ToString());

            acco.udeit(id, id_grop2, textBox2.Text); }
            refresh();
  
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dataGridView1.CurrentCell != null)
            {
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
           

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
