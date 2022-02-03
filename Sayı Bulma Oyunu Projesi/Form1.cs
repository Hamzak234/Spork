using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_tekrar_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a, b;
        int sayac = 5;

        private void Form1_Load(object sender, EventArgs e)
        {
            Random oyun = new Random();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            b = Convert.ToInt16(textBox1.Text);
            sayac++;
            if (sayac == 0)
            {
                MessageBox.Show("5 defa hatalı giriş yaptın");
            }
            if (b > a)
            {
                label3.Text = "daha büyük sayı gir";
            }
            else if (a < b)
            {
                label3.Text = "daha küçük sayı gir";
            }
            else
            {
                label3.Text = "tebirkler oyunu kazandın";
            }
        }
    }
}
          
        
          

    
    








