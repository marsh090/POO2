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
    public partial class Form6 : Form
    {
        Form1 form1;
        Form2 form2;
        Produto editando;
        public Form6(Form1 form1, Form2 form2)
        {
            InitializeComponent();
            this.form1 = form1;
            this.form2 = form2;

            txtId.Text = form1.selecionado.Id.ToString();
            txtNome.Text = form1.selecionado.Nome;
            txtDesc.Text = form1.selecionado.Descricao;
            txtQtd.Text = form1.selecionado.Quantidade.ToString();
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
                bool idAlterado = int.TryParse(txtId.Text, out int novoId);
                string novoNome = txtNome.Text.Trim();

                if (idAlterado && novoId != form1.selecionado.Id && form1.produtos.Any(p => p.Id == novoId))
                {
                    MessageBox.Show("Já existe um item com este ID.");
                }
                else if (!idAlterado)
                {
                    MessageBox.Show("O valor digitado para o ID é inválido. Certifique-se de que é um número inteiro válido.");
                }
                else if (form1.produtos.Any(p => p.Nome == novoNome && p != form1.selecionado))
                {
                    MessageBox.Show("Já existe um item com este Nome.");
                }
                else
                {
                    try
                    {
                        form1.selecionado.Id = novoId;
                        form1.selecionado.Nome = novoNome;
                        form1.selecionado.Descricao = txtDesc.Text;
                        form1.selecionado.Quantidade = int.Parse(txtQtd.Text);

                        form2.dgvProdutos.DataSource = null;
                        form2.dgvProdutos.DataSource = form1.produtos;

                        txtId.Clear();
                        txtNome.Clear();
                        txtDesc.Clear();
                        txtQtd.Clear();

                        // Fecha o Form6 após uma edição bem-sucedida
                        Close();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("O valor digitado para a quantidade é inválido. Certifique-se de que é um número inteiro válido.");
                    }
                }
            }
        }

    }
}
