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
    public partial class App : Form
    {
        public App()
        {
           
            InitializeComponent();
      
        }

        private void فواتيرشراءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buy_sal sal = new Buy_sal();
            sal.MdiParent = this;
            sal.Show();
        }

        private void فواتيربيعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Billbuy buy = new Billbuy();
            buy.MdiParent = this;
            buy.Show();
        }

        private void اضافهصنفجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formitem new_item = new formitem();
            new_item.MdiParent = this;
            new_item.Show();
        }

        private void كشفحسابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports r = new Reports();
            r.MdiParent = this;
            r.Show();
        }

        private void اضافهمجموعهحساباتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.MdiParent = this;
            f1.Show();
        }

        private void اضافهحسابجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.MdiParent = this;
            f3.Show();
        }

        private void مخزونكافهالاصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Storeg stor = new Storeg();
            stor.MdiParent = this;
            stor.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void App_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
