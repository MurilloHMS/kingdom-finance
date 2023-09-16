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
    public partial class Midias : Form
    {
        public Midias()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFac_Click(object sender, EventArgs e)
        {
            Functions functions = new Functions();
            string target = "https://www.facebook.com/kingdomcomunidade";
            functions.openMidias(target);
        }
    }
}
