namespace WindowsFormsApplication1
{
    partial class App
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ملفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.السندلتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الفواتيرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.فواتيرشراءToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.فواتيربيعToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الاصنافToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافهصنفجديدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حركهالاصنافToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مخزونكافهالاصنافToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.التقاريرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.كشفحسابToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الحساباتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافهمجموعهحساباتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافهحسابجديدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ملفToolStripMenuItem,
            this.السندلتToolStripMenuItem,
            this.الفواتيرToolStripMenuItem,
            this.الاصنافToolStripMenuItem,
            this.حركهالاصنافToolStripMenuItem,
            this.التقاريرToolStripMenuItem,
            this.الحساباتToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(967, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ملفToolStripMenuItem
            // 
            this.ملفToolStripMenuItem.Name = "ملفToolStripMenuItem";
            this.ملفToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.ملفToolStripMenuItem.Text = "ملف";
            // 
            // السندلتToolStripMenuItem
            // 
            this.السندلتToolStripMenuItem.Name = "السندلتToolStripMenuItem";
            this.السندلتToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.السندلتToolStripMenuItem.Text = "السندلت";
            // 
            // الفواتيرToolStripMenuItem
            // 
            this.الفواتيرToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.فواتيرشراءToolStripMenuItem,
            this.فواتيربيعToolStripMenuItem});
            this.الفواتيرToolStripMenuItem.Name = "الفواتيرToolStripMenuItem";
            this.الفواتيرToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.الفواتيرToolStripMenuItem.Text = "الفواتير";
            // 
            // فواتيرشراءToolStripMenuItem
            // 
            this.فواتيرشراءToolStripMenuItem.Name = "فواتيرشراءToolStripMenuItem";
            this.فواتيرشراءToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.فواتيرشراءToolStripMenuItem.Text = "فواتير شراء";
            this.فواتيرشراءToolStripMenuItem.Click += new System.EventHandler(this.فواتيرشراءToolStripMenuItem_Click);
            // 
            // فواتيربيعToolStripMenuItem
            // 
            this.فواتيربيعToolStripMenuItem.Name = "فواتيربيعToolStripMenuItem";
            this.فواتيربيعToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.فواتيربيعToolStripMenuItem.Text = "فواتير بيع";
            this.فواتيربيعToolStripMenuItem.Click += new System.EventHandler(this.فواتيربيعToolStripMenuItem_Click);
            // 
            // الاصنافToolStripMenuItem
            // 
            this.الاصنافToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اضافهصنفجديدToolStripMenuItem});
            this.الاصنافToolStripMenuItem.Name = "الاصنافToolStripMenuItem";
            this.الاصنافToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.الاصنافToolStripMenuItem.Text = "الاصناف";
            // 
            // اضافهصنفجديدToolStripMenuItem
            // 
            this.اضافهصنفجديدToolStripMenuItem.Name = "اضافهصنفجديدToolStripMenuItem";
            this.اضافهصنفجديدToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.اضافهصنفجديدToolStripMenuItem.Text = "اضافه صنف جديد";
            this.اضافهصنفجديدToolStripMenuItem.Click += new System.EventHandler(this.اضافهصنفجديدToolStripMenuItem_Click);
            // 
            // حركهالاصنافToolStripMenuItem
            // 
            this.حركهالاصنافToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مخزونكافهالاصنافToolStripMenuItem});
            this.حركهالاصنافToolStripMenuItem.Name = "حركهالاصنافToolStripMenuItem";
            this.حركهالاصنافToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.حركهالاصنافToolStripMenuItem.Text = "حركه الاصناف";
            // 
            // مخزونكافهالاصنافToolStripMenuItem
            // 
            this.مخزونكافهالاصنافToolStripMenuItem.Name = "مخزونكافهالاصنافToolStripMenuItem";
            this.مخزونكافهالاصنافToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.مخزونكافهالاصنافToolStripMenuItem.Text = "مخزون الاصناف";
            this.مخزونكافهالاصنافToolStripMenuItem.Click += new System.EventHandler(this.مخزونكافهالاصنافToolStripMenuItem_Click);
            // 
            // التقاريرToolStripMenuItem
            // 
            this.التقاريرToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.كشفحسابToolStripMenuItem});
            this.التقاريرToolStripMenuItem.Name = "التقاريرToolStripMenuItem";
            this.التقاريرToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.التقاريرToolStripMenuItem.Text = "التقارير";
            // 
            // كشفحسابToolStripMenuItem
            // 
            this.كشفحسابToolStripMenuItem.Name = "كشفحسابToolStripMenuItem";
            this.كشفحسابToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.كشفحسابToolStripMenuItem.Text = "كشف حساب";
            this.كشفحسابToolStripMenuItem.Click += new System.EventHandler(this.كشفحسابToolStripMenuItem_Click);
            // 
            // الحساباتToolStripMenuItem
            // 
            this.الحساباتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اضافهمجموعهحساباتToolStripMenuItem,
            this.اضافهحسابجديدToolStripMenuItem});
            this.الحساباتToolStripMenuItem.Name = "الحساباتToolStripMenuItem";
            this.الحساباتToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.الحساباتToolStripMenuItem.Text = "الحسابات";
            // 
            // اضافهمجموعهحساباتToolStripMenuItem
            // 
            this.اضافهمجموعهحساباتToolStripMenuItem.Name = "اضافهمجموعهحساباتToolStripMenuItem";
            this.اضافهمجموعهحساباتToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.اضافهمجموعهحساباتToolStripMenuItem.Text = "اضافه مجموعه حسابات";
            this.اضافهمجموعهحساباتToolStripMenuItem.Click += new System.EventHandler(this.اضافهمجموعهحساباتToolStripMenuItem_Click);
            // 
            // اضافهحسابجديدToolStripMenuItem
            // 
            this.اضافهحسابجديدToolStripMenuItem.Name = "اضافهحسابجديدToolStripMenuItem";
            this.اضافهحسابجديدToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.اضافهحسابجديدToolStripMenuItem.Text = "اضافه حساب جديد";
            this.اضافهحسابجديدToolStripMenuItem.Click += new System.EventHandler(this.اضافهحسابجديدToolStripMenuItem_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(967, 443);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "App";
            this.Text = "App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.App_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ملفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem السندلتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الفواتيرToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الاصنافToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حركهالاصنافToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem التقاريرToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem فواتيرشراءToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem فواتيربيعToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اضافهصنفجديدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مخزونكافهالاصنافToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem كشفحسابToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الحساباتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اضافهمجموعهحساباتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اضافهحسابجديدToolStripMenuItem;
    }
}