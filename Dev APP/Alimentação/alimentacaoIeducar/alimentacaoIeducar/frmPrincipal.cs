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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadProduto cadProd = new frmCadProduto();
            cadProd.ShowDialog();
        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadPessoaTipo cadPT = new cadPessoaTipo();
            cadPT.Show();

        }

           private void prefeituraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadCliente cadClien = new frmCadCliente();
            cadClien.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedor cadFornec = new frmFornecedor();
            cadFornec.Show();
        }
    }
}
