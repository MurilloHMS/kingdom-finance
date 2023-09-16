using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
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
            limpar();
        }

        public void limpar()
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
            rdUsoInt.Checked = false;
            cbTipo.Text = null;
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
            cbTipo.Enabled = false;
        }
        private void rdEve_CheckedChanged(object sender, EventArgs e)
        {
            lblDes.Text = "DESCRIÇÃO EVENTO";
            cbCulEve.Enabled = false;
            cbCulEve.BackColor = SystemColors.ActiveCaption;
            cbCulEve.Text = null;
            cbTipo.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Functions functions = new Functions();

            string id = txtId.Text;
            string entSai = null;
            string culto = cbCulEve.Text;
            string tipo = null;
            decimal valor = Convert.ToDecimal(txtVlr.Text);
            DateTime date = DateTime.Now;
            var sqlFormattedDate = date.ToString(@"yyyy-MM-dd HH:mm:ss");
            
            string des = txtbDes.Text;
            string mov = cbTipo.Text;

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
            else if (rdUsoInt.Checked == true) 
            { 
                tipo = rdUsoInt.Text;
            }
            string query;

            if ((culto == "") || (culto == null) || culto == string.Empty)
            {
                culto = "null";
                query = "INSERT INTO Financeiro VALUES(" + valor + "," + culto + ",'" + entSai + "','" + tipo + "','" + mov + "','" + sqlFormattedDate + "'," + "null" + ",'" + "KINGDOM" + "','" + "KINGDOM" + "','" + des + "');";
            }
            else
            {
                query = "INSERT INTO Financeiro VALUES(" + valor + ",'" + culto + "','" + entSai + "','" + tipo + "','" + mov + "','" + sqlFormattedDate + "'," + "null" + ",'" + "KINGDOM" + "','" + "KINGDOM" + "','" + des + "')";
            }
            

            DialogResult dialogResult = MessageBox.Show("Deseja inserir os seguintes dados:\n\n" + "Tipo: " + tipo + "\nTipo Movimentação: " + mov + "\nEntrada/Saida: " + entSai
                            + "\nDia Do Culto: " + culto + "\nValor: " + valor + "\nData entrada: " + sqlFormattedDate + "\nDescrição: " + des , "dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           
            if (dialogResult == DialogResult.Yes)
            {
                functions.query(query);
            }

            limpar();
        }

        private void txtVlr_KeyPress(object sender, KeyPressEventArgs e)
        {   /*
            Functions functions = new Functions();
            functions.IntNumber(e);
            */
        }

        private void rdUsoInt_Click(object sender, EventArgs e)
        {
            if (rdSai.Checked == true)
            {
                cbTipo.Enabled = true;
            }
            cbTipo.BackColor = SystemColors.Control;
            lblDes.Text = "DESCRIÇÃO USO INTERNO";
        }

        private void rdEnt_Click(object sender, EventArgs e)
        {
            if ((!rdSai.Checked) && rdUsoInt.Checked)
            {
                cbTipo.Enabled = false;
                cbTipo.Text = string.Empty;
            }
        }

        private void rdSai_Click(object sender, EventArgs e)
        {
            if ((rdSai.Checked == true) && rdUsoInt.Checked)
            {
                cbTipo.Enabled = true;
            }
        }
    }
}
