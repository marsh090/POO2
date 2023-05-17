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
    public partial class Form4 : Form
    {
        Form1 form1;
        Form3 form3;

        public Form4(Form1 form1, Form3 form3)
        {
            InitializeComponent();
            this.form1 = form1;
            this.form3 = form3;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text) ||
                string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Existem campos a serem preenchidos",
                                "Configuration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Usuario adicionando = form1.usuarios.FirstOrDefault(u => u.Login == txtLogin.Text || u.Senha == txtSenha.Text);

                if (adicionando != null)
                {
                    MessageBox.Show("Já existe um item com este Id ou Nome");
                }
                else
                {
                    try
                    {
                        string username = txtLogin.Text;
                        string nome = txtNome.Text;
                        string senha = txtSenha.Text;
                        bool habilitado = cbxHabilitar.Checked;

                        form1.usuarios.Add(new Usuario(username, nome, senha, habilitado));

                        form3.dgvUsuarios.DataSource = null;
                        form3.dgvUsuarios.DataSource = form1.usuarios;

                        txtLogin.Clear();
                        txtNome.Clear();
                        txtSenha.Clear();
                        cbxHabilitar.Checked = false;

                        Close();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("O valor digitado para o ID ou quantidade é inválido. Certifique-se de que são números inteiros válidos.");
                    }
                }
            }
        }
    }
}
