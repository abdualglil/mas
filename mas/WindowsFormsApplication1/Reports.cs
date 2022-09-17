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
    public partial class Reports : Form
    {
        int id_accont;
        Mov_accont mo = new Mov_accont();
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            acoont acont = new acoont();

            comboBox1.DataSource = acont.reternaccont();
            comboBox1.DisplayMember = "nema";
            comboBox1.ValueMember = "id_accont";
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
             id_accont = int.Parse(comboBox1.SelectedValue.ToString());
            dataGridView1.DataSource = mo.mov_con_tab(id_accont);
            string sum_daen1 = mo.sum_daen(id_accont);
            string sum_maden1 = mo.sum_maden(id_accont);
            int sum_daen = 0;
              int sum_maden =0;

              try
              {
                   sum_daen = int.Parse(sum_daen1);
                  sum_maden = int.Parse(sum_maden1);
              }
              catch
              {

              }

            int sumall = sum_daen - sum_maden;
            label3.Text = sumall + "";

            if (sumall < 0)
            {
                label4.Text = "عليكم";
            }
            else if (sumall > 0)
            {
                label4.Text = "لكم";
            }
            else
            {
                label4.Text = "..";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
