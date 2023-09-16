using CKFinance.Properties;
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

            string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Murillo\\projects\\CKFinance\\CkFinance.mdf;Integrated Security=True";

            try
            {
                SqlConnection con = new SqlConnection(connection);
                con.Open();

                var slqQuery = "SELECT * FROM Financeiro";
                using (SqlDataAdapter da = new SqlDataAdapter(slqQuery, con))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dgvFin.DataSource = dt;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
    }
}