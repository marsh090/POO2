using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            lblComboBox.Items.Add(txtItem.Text);
            txtItem.Clear();
        }

        private void btnCopiarEstado_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < lblComboBox.Items.Count; i++)
            {
                lbCopiados.Items.Add(lblComboBox.Items[i]);
            }
        }

        private void btnCopiarSelecionados_Click(object sender, EventArgs e)
        {
            if (int.Parse(lbCopiados.SelectionMode) = 2)
            {
                lbSelecionados.Items.Add(lbCopiados.SelectedItems);
            }
        }
    }
}
