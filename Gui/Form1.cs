using CKFinance.Properties;
using CKFinance.Database;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CKFinance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }

        private void btnLi_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[2];
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                cbFiltro.Visible = true;

            }
            else
            {
                cbFiltro.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FinMenu finMenu = new FinMenu();
            finMenu.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string hexColor = "#7bb4e3";
            Color myColor = System.Drawing.ColorTranslator.FromHtml(hexColor);

        }

        private void btnMi_Click(object sender, EventArgs e)
        {
            Midias midias = new Midias();
            midias.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Config config = new Config();
            config.Show();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            CKFinance.Database.Connection connection = new CKFinance.Database.Connection();
            string connect = connection.dataConnection();
            string select_data = "SELECT * FROM Financeiro";
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(connect);
                SqlCommand sqlCommand = new SqlCommand(select_data, con);
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                con.Open();
                adapter.Fill(ds);
                dgvFin.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }


        }
    }
}