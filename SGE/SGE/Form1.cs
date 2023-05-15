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
    public partial class Form1 : Form
    {
        public List<Usuario> usuarios { get; set; }
        public List<Produto> produtos { get; set; }
        public Produto selecionado;
        public Form1()
        {
            InitializeComponent();

            usuarios = new List<Usuario>();
            Usuario admin = new Usuario("admin", "admin123", true);
            usuarios.Add(admin);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string loginDigitado = txtLogin.Text;
            string senhaDigitada = txtSenha.Text;

            Usuario usuarioAdmin = usuarios.FirstOrDefault(u => u.Login == loginDigitado && u.Senha == senhaDigitada && u.Habilitado);

            if (usuarioAdmin != null && cbxCiente.Checked)
            {
                Form2 form2 = new Form2(this);
                form2.ShowDialog();
            }
            else if(!cbxCiente.Checked)
            {
                MessageBox.Show("Clique em estou ciente para continuar!");
            }
            else
            {
                MessageBox.Show("Dados de login inválidos!");
            }
        }

    }
}
