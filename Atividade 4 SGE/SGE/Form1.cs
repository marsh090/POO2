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
        public Usuario logado;
        public List<Produto> produtos { get; set; }
        public Produto selecionado;
        public Form1()
        {
            InitializeComponent();

            usuarios = new List<Usuario>();
            Usuario admin = new Usuario("admin", "administrador", "admin123", true);
            Usuario u1 = new Usuario("user1", "douglas", "user1", true);
            usuarios.Add(admin);
            usuarios.Add(u1);

            produtos = new List<Produto>();
            Produto p1 = new Produto(0, "maçã", "Fruta", 5);
            Produto p2 = new Produto(1, "banana", "Fruta", 15);
            produtos.Add(p1);
            produtos.Add(p2);

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string loginDigitado = txtLogin.Text;
            string senhaDigitada = txtSenha.Text;

            logado = usuarios.FirstOrDefault(u => u.Login == loginDigitado && u.Senha == senhaDigitada && u.Habilitado);

            if (logado != null && cbxCiente.Checked)
            {
                txtLogin.Text = null;
                txtSenha.Text = null;
                cbxCiente.Checked = false;
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
