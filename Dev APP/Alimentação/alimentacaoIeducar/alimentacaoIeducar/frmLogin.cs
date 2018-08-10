using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alimentacaoIeducar
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntra_Click(object sender, EventArgs e)
        {
            frmPrincipal princ = new frmPrincipal();
            princ.Show();
            this.Visible = false;
        }
    }
}
