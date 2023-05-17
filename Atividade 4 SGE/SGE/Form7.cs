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
    public partial class Form7 : Form
    {
        Form1 form1;
        Form3 form3;
        public Form7(Form1 form1, Form3 form3)
        {
            InitializeComponent();
            this.form1 = form1;
            this.form3 = form3;

            txtLogin.Text = form1.logado.Login;
            txtNome.Text = form1.logado.Nome;
            txtSenha.Text = form1.logado.Senha;
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
                string loginAlterado = txtLogin.Text.Trim();
                string senhaAlterada = txtSenha.Text.Trim();

                if (form1.usuarios.Any(u => u.Login == loginAlterado && u != form1.logado))
                {
                    MessageBox.Show("Já existe um usuário com este Login.");
                }
                else if (form1.usuarios.Any(u => u.Senha == senhaAlterada && u != form1.logado))
                {
                    MessageBox.Show("Já existe um usuário com esta Senha.");
                }
                else
                {
                    try
                    {
                        form1.logado.Login = loginAlterado;
                        form1.logado.Nome = txtNome.Text;
                        form1.logado.Senha = senhaAlterada;

                        form3.dgvUsuarios.DataSource = null;
                        form3.dgvUsuarios.DataSource = form1.usuarios;

                        txtLogin.Clear();
                        txtNome.Clear();
                        txtSenha.Clear();

                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao salvar a edição do usuário: " + ex.Message);
                    }
                }
            }
        }

    }
}
