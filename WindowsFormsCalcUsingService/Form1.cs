using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCalcUsingService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbTcp.Checked = true;            
        }

        private void btDivision_Click(object sender, EventArgs e)
        {
            tbTotal.Text = GetClient().Division(Convert.ToInt32(tbNum1.Text), Convert.ToInt32(tbNum2.Text)).ToString();
        }

        private void btMultipl_Click(object sender, EventArgs e)
        {
            tbTotal.Text = GetClient().Multiplicacion(Convert.ToInt32(tbNum1.Text), Convert.ToInt32(tbNum2.Text)).ToString();
        }

        private void btResta_Click(object sender, EventArgs e)
        {
            tbTotal.Text = GetClient().Resta(Convert.ToInt32(tbNum1.Text), Convert.ToInt32(tbNum2.Text)).ToString();
        }

        private void btSuma_Click(object sender, EventArgs e)
        {
            tbTotal.Text = GetClient().Suma(Convert.ToInt32(tbNum1.Text), Convert.ToInt32(tbNum2.Text)).ToString();
        }

        private ServiceReference.Service1Client GetClient()
        {
            ServiceReference.Service1Client svc = (rbTcp.Checked) ? new ServiceReference.Service1Client("Tcp") : new ServiceReference.Service1Client("Http");
            return svc;
        }
    }
}
