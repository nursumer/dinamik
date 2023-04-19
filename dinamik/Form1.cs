using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dinamik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TextBox tt1 = new TextBox();
        private void Form1_Load(object sender, EventArgs e)
        {
            tt1.Location = new Point(185,52);// location property textbox x,y koordinat
            tt1.Size = new Size(100, 20);
            tt1.Click += new EventHandler(ekle);
            Controls.Add(tt1);
            Button b=new Button();
            b.Location = new Point(185, 82);
            b.Text = "OK";
            b.Click += new EventHandler(Mesaj);
            Controls.Add(b);
        }

        private void Mesaj(object sender, EventArgs e)
        {
            MessageBox.Show("Bu sınıf basarır mı");
        }
        private void ekle(object sender, EventArgs e)
        {
            tt1.Text = "Merhaba";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
