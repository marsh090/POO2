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
    public partial class Form5 : Form
    {
        Form1 form1;
        Form2 form2;
        public Form5(Form1 form1, Form2 form2)
        {
            InitializeComponent();
            this.form1 = form1;
            this.form2 = form2;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) ||
                string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtDesc.Text) ||
                string.IsNullOrWhiteSpace(txtQtd.Text))
            {
                MessageBox.Show("Existem campos a serem preenchidos",
                                "Configuration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Produto adicionando = form1.produtos.FirstOrDefault(u => u.Id == int.Parse(txtId.Text) || u.Nome == txtNome.Text);

                if (adicionando != null)
                {
                    MessageBox.Show("Já existe um item com este Id ou Nome");
                }
                else
                {
                    try
                    {
                        int id = int.Parse(txtId.Text);
                        string nome = txtNome.Text;
                        string descricao = txtDesc.Text;
                        int quantidade = Convert.ToInt32(txtQtd.Text);

                        form1.produtos.Add(new Produto(id, nome, descricao, quantidade));

                        form2.dgvProdutos.DataSource = null;
                        form2.dgvProdutos.DataSource = form1.produtos;

                        txtId.Clear();
                        txtNome.Clear();
                        txtDesc.Clear();
                        txtQtd.Clear();

                        Close();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("O valor digitado para o ID ou quantidade é inválido. Certifique-se de que são números inteiros válidos.");
                    }
                }
            }
        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDesc_Click(object sender, EventArgs e)
        {

        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblQtd_Click(object sender, EventArgs e)
        {

        }

        private void txtQtd_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
