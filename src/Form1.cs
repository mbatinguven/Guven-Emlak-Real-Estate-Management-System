using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiteEmlakProgramıSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 giris=new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "guvensitesi" && textBox2.Text == "4646")
            {
                this.Hide();
                giris.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri kontrol ediniz!");
            }
        }
    }
}
