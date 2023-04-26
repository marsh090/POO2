namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblComboBox = new System.Windows.Forms.ComboBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lbCopiados = new System.Windows.Forms.ListBox();
            this.btnCopiarEstado = new System.Windows.Forms.Button();
            this.btnCopiarSelecionados = new System.Windows.Forms.Button();
            this.lbSelecionados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblEstado.Location = new System.Drawing.Point(13, 13);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(203, 26);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "Selecione o estado:";
            // 
            // lblComboBox
            // 
            this.lblComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lblComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblComboBox.FormattingEnabled = true;
            this.lblComboBox.Items.AddRange(new object[] {
            "Estado1",
            "Estado2",
            "Estado3"});
            this.lblComboBox.Location = new System.Drawing.Point(217, 17);
            this.lblComboBox.Name = "lblComboBox";
            this.lblComboBox.Size = new System.Drawing.Size(221, 23);
            this.lblComboBox.TabIndex = 1;
            // 
            // txtItem
            // 
            this.txtItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtItem.Location = new System.Drawing.Point(18, 71);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(192, 26);
            this.txtItem.TabIndex = 2;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(217, 73);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(127, 23);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar à lista";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lbCopiados
            // 
            this.lbCopiados.FormattingEnabled = true;
            this.lbCopiados.Location = new System.Drawing.Point(18, 152);
            this.lbCopiados.Name = "lbCopiados";
            this.lbCopiados.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbCopiados.Size = new System.Drawing.Size(221, 95);
            this.lbCopiados.TabIndex = 4;
            // 
            // btnCopiarEstado
            // 
            this.btnCopiarEstado.Location = new System.Drawing.Point(64, 123);
            this.btnCopiarEstado.Name = "btnCopiarEstado";
            this.btnCopiarEstado.Size = new System.Drawing.Size(127, 23);
            this.btnCopiarEstado.TabIndex = 5;
            this.btnCopiarEstado.Text = "Copiar Estados";
            this.btnCopiarEstado.UseVisualStyleBackColor = true;
            this.btnCopiarEstado.Click += new System.EventHandler(this.btnCopiarEstado_Click);
            // 
            // btnCopiarSelecionados
            // 
            this.btnCopiarSelecionados.Location = new System.Drawing.Point(343, 123);
            this.btnCopiarSelecionados.Name = "btnCopiarSelecionados";
            this.btnCopiarSelecionados.Size = new System.Drawing.Size(127, 23);
            this.btnCopiarSelecionados.TabIndex = 6;
            this.btnCopiarSelecionados.Text = "Copiar Selecionados";
            this.btnCopiarSelecionados.UseVisualStyleBackColor = true;
            this.btnCopiarSelecionados.Click += new System.EventHandler(this.btnCopiarSelecionados_Click);
            // 
            // lbSelecionados
            // 
            this.lbSelecionados.FormattingEnabled = true;
            this.lbSelecionados.Location = new System.Drawing.Point(296, 152);
            this.lbSelecionados.Name = "lbSelecionados";
            this.lbSelecionados.Size = new System.Drawing.Size(221, 95);
            this.lbSelecionados.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSelecionados);
            this.Controls.Add(this.btnCopiarSelecionados);
            this.Controls.Add(this.btnCopiarEstado);
            this.Controls.Add(this.lbCopiados);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.lblComboBox);
            this.Controls.Add(this.lblEstado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox lblComboBox;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListBox lbCopiados;
        private System.Windows.Forms.Button btnCopiarEstado;
        private System.Windows.Forms.Button btnCopiarSelecionados;
        private System.Windows.Forms.ListBox lbSelecionados;
    }
}

