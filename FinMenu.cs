using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CKFinance.Properties;

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
            txtId.Text = null;
            txtVlr.Text = null;
            cbCulEve.Text = null;
            rdEnt.Checked = false;
            rdSai.Checked = false;
            rdCult.Checked = false;
            rdEve.Checked = false;
            lblDes.Text = "DESCRIÇÃO";
            txtbDes.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lblDes.Text = "DESCRIÇÃO CULTO";
            cbCulEve.Enabled = true;
            cbCulEve.BackColor = SystemColors.Control;
        }
        private void rdEve_CheckedChanged(object sender, EventArgs e)
        {
            lblDes.Text = "DESCRIÇÃO EVENTO";
            cbCulEve.Enabled = false;
            cbCulEve.BackColor = SystemColors.ActiveCaption;
            cbCulEve.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Functions functions = new Functions();

            string id = txtId.Text;
            string entSai = null;
            string Culto = cbCulEve.Text;
            string tipo = null;
            decimal valor = Convert.ToDecimal(txtVlr.Text);
            DateTime date = DateTime.Now;
            string des = txtbDes.Text;

            if (rdEnt.Checked == true)
            {
                entSai = rdEnt.Text;
            }
            else if (rdSai.Checked == true)
            {
                entSai = rdSai.Text;
            }

            if (rdCult.Checked == true)
            {
                tipo = rdCult.Text;
            }
            else if (rdEve.Checked == true)
            {
                tipo = rdEve.Text;
            }


            MessageBox.Show(id + entSai + Culto + tipo + valor + date + des, "dados", MessageBoxButtons.OK, MessageBoxIcon.Question);
            /*
            string query = null;
            functions.query(query);
            */
        }

        private void txtVlr_KeyPress(object sender, KeyPressEventArgs e)
        {   /*
            Functions functions = new Functions();
            functions.IntNumber(e);
            */
        }


    }
}
