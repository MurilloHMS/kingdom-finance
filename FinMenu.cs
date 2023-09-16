using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CKFinance
{
    public partial class FinMenu : Form
    {
        public FinMenu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtOk.Text = null;
            txtVlr.Text = null;
            cbCulEve.Text = null;
            rdEnt.Checked = false;
            rdSai.Checked = false;
            lblDes.Text = "DESCRIÇÃO";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lblDes.Text = "DESCRIÇÃO CULTO";
        }

        private void lblEve_CheckedChanged(object sender, EventArgs e)
        {
            lblDes.Text = "DESCRIÇÃO EVENTO";
        }
    }
}
