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
    public partial class Form3 : Form
    {
        Form1 form1;
        public Form3(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            dgvUsuarios.DataSource = form1.usuarios;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(form1, this);
            form4.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(!(form1.logado.Login == "admin"))
            {
                form1.logado.Habilitado = false;
                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = form1.usuarios;
            }
            
        }

        private void dgvProdutos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            form1.logado = form1.usuarios[e.RowIndex];
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (form1.logado != null)
            {
                Form7 form7 = new Form7(form1, this);
                form7.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhum contato selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(form1.logado.Login == "admin"))
            {
                form1.logado.Habilitado = true;
                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = form1.usuarios;
            }
        }
    }
}
