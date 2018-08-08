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
    public partial class cadPessoaTipo : Form
    {
        public cadPessoaTipo()
        {
            InitializeComponent();
        }

        private void pessoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pessoaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ieducarDataSet);

        }

        private void cadPessoaTipo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'ieducarDataSet.pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter.Fill(this.ieducarDataSet.pessoa);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadCliente cadClie = new cadCliente();
            cadClie.Show();

        }
    }
}
