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
    public partial class login : Form
    {
        User user = new User();
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = user.retern();
            comboBox1.DisplayMember = "username";
            comboBox1.ValueMember = "id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass = textBox1.Text;
            int id =int.Parse(comboBox1.SelectedValue.ToString());
            if (user.chek(id, pass) == true)
            {
             
                App app=new App();
                app.Show();
                this.Close();
            
                
            
              
                
            }
            else
            {
                MessageBox.Show("اسم المستخدم او كلمه المرور خطاء");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
