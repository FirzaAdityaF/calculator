using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatortugas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(Nilai1.Text);
            var b = Convert.ToInt32(Nilai2.Text);
            Double hasil;
            switch (Operasi.SelectedIndex)
            {
                case 0:
                    hasil = a + b;
                    lstHasil.Text = Convert.ToString(hasil);
                    break;
                case 1:
                    hasil = a - b;
                    lstHasil.Text = Convert.ToString(hasil);
                    break;
                case 2:
                    hasil = a * b;
                    lstHasil.Text = Convert.ToString(hasil);
                    break;
                case 3:
                    hasil = a / b;
                    lstHasil.Text = Convert.ToString(hasil);
                    break;
            }
        }
    }
}
