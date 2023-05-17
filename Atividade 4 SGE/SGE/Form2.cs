using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGE
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            if (form1.logado.Login == "admin")
            {
                btnUsuario.Visible = true;
                btnExcluir.Visible = true;
            }
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = form1.produtos;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(form1);
            form3.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            form1.produtos.Remove(form1.selecionado);
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = form1.produtos;
        }

        private void dgvProdutos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            form1.selecionado = form1.produtos[e.RowIndex];
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(form1, this);
            form5.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (form1.selecionado != null)
            {
                Form6 form6 = new Form6(form1, this);
                form6.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhum contato selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
