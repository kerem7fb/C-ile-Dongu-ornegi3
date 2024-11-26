using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24.Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam=0;
            int baslangıc = Convert.ToInt32(textBox1.Text);
            int bitis = Convert.ToInt32(textBox2.Text);
            int artis = Convert.ToInt32(textBox3.Text);
            for (int i = baslangıc; i <= bitis; i=i+artis)
            {
                toplam = toplam + i;
            }
            MessageBox.Show(bitis + " e kadar olan sayıların toplamı " + toplam);
        }
    }
}
