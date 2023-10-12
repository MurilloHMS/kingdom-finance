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
using Microsoft.VisualBasic;

namespace CKFinance
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Config_Load(object sender, EventArgs e)
        {
        }

        private void btnCTable_Click(object sender, EventArgs e)
        {
            Functions functions = new Functions();

            string users = "CREATE TABLE Users (ID INT IDENTITY(1,1) PRIMARY KEY, NOME VARCHAR(128), USUARIO VARCHAR(15), CARGO VARCHAR(30), SENHA VARCHAR(20), DATACADASTRO DATETIME)";
            string finance = "CREATE TABLE Financeiro (ID INT IDENTITY(1,1) PRIMARY KEY, VALOR DECIMAL(8,2), CULTO VARCHAR(20),TIPOMOV VARCHAR(8),TIPOEVEN VARCHAR(12),TIPODESP VARCHAR(20), DATAENTRADA DATETIME , DATAALTERACAO DATETIME, USUARIOENTRADA VARCHAR(15), USUARIOALTERACAO VARCHAR(15),DESCRICAO VARCHAR(100))";

            functions.query(users);
            functions.query(finance);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Atenção esse comando deleta todas as tabelas e NÃO é reversivel, Deseja excluir as tabelas sabendo que perderá tudo?", "EXCLUSÃO DE DADOS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string deleteUser = "DROP TABLE Users";
                string deleteFinance = "DROP TABLE Financeiro";

                Functions functions = new Functions();
                functions.query(deleteUser);
                functions.query(deleteFinance);

                MessageBox.Show("Dados deletados a pedido do usuario", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Operação cancelada pelo usuario ", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
