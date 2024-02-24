using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.unite_uygulama_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtSAyi.Text);
            if(sayi%2 == 0 )
            {
                MessageBox.Show("sayı çifttir.");
            }else if(sayi%2 == 1 )
            {
                MessageBox.Show("sayı tekttir.");

            }
            else
            {
                MessageBox.Show("sayı 0 eşittir.");
            }
        }
    }
}
