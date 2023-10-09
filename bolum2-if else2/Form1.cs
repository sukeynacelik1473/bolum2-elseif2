using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bolum2_if_else2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTıkla_Click(object sender, EventArgs e)
        {
            if (cbSarı.Checked)
            {
                lblYaz.Text = "sarı";
                BackColor= Color.Yellow;
            }
            else
            {
                lblYaz.Text = "kırmızı";
                BackColor = Color.Red;
            }

        }
    }
}
