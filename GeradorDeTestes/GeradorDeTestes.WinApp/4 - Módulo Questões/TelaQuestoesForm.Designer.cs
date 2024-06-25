namespace GeradorDeTestes.WinApp._5___Módulo_Questões
{
    partial class TelaQuestoesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbBoxMateria = new ComboBox();
            lblMateria = new Label();
            txtEnunciado = new TextBox();
            lblAlternativa = new Label();
            lblEnunciado = new Label();
            txtAlternativa = new TextBox();
            btnAdicionar = new Button();
            gpBoxAlternativas = new GroupBox();
            listAlternativas = new CheckedListBox();
            btnRemover = new Button();
            btnCancelar = new Button();
            btnGravar = new Button();
            gpBoxAlternativas.SuspendLayout();
            SuspendLayout();
            // 
            // cmbBoxMateria
            // 
            cmbBoxMateria.FormattingEnabled = true;
            cmbBoxMateria.Location = new Point(95, 47);
            cmbBoxMateria.Margin = new Padding(3, 4, 3, 4);
            cmbBoxMateria.Name = "cmbBoxMateria";
            cmbBoxMateria.Size = new Size(282, 28);
            cmbBoxMateria.TabIndex = 0;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new Point(31, 47);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(63, 20);
            lblMateria.TabIndex = 1;
            lblMateria.Text = "Matéria:";
            // 
            // txtEnunciado
            // 
            txtEnunciado.Location = new Point(95, 117);
            txtEnunciado.Margin = new Padding(3, 4, 3, 4);
            txtEnunciado.Multiline = true;
            txtEnunciado.Name = "txtEnunciado";
            txtEnunciado.Size = new Size(401, 121);
            txtEnunciado.TabIndex = 2;
            // 
            // lblAlternativa
            // 
            lblAlternativa.AutoSize = true;
            lblAlternativa.Location = new Point(11, 265);
            lblAlternativa.Name = "lblAlternativa";
            lblAlternativa.Size = new Size(84, 20);
            lblAlternativa.TabIndex = 1;
            lblAlternativa.Text = "Alternativa:";
            // 
            // lblEnunciado
            // 
            lblEnunciado.AutoSize = true;
            lblEnunciado.Location = new Point(13, 152);
            lblEnunciado.Name = "lblEnunciado";
            lblEnunciado.Size = new Size(81, 20);
            lblEnunciado.TabIndex = 1;
            lblEnunciado.Text = "Enunciado:";
            // 
            // txtAlternativa
            // 
            txtAlternativa.Location = new Point(95, 248);
            txtAlternativa.Margin = new Padding(3, 4, 3, 4);
            txtAlternativa.Multiline = true;
            txtAlternativa.Name = "txtAlternativa";
            txtAlternativa.Size = new Size(282, 67);
            txtAlternativa.TabIndex = 2;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(392, 267);
            btnAdicionar.Margin = new Padding(3, 4, 3, 4);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(98, 49);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // gpBoxAlternativas
            // 
            gpBoxAlternativas.Controls.Add(listAlternativas);
            gpBoxAlternativas.Controls.Add(btnRemover);
            gpBoxAlternativas.Location = new Point(88, 341);
            gpBoxAlternativas.Margin = new Padding(3, 4, 3, 4);
            gpBoxAlternativas.Name = "gpBoxAlternativas";
            gpBoxAlternativas.Padding = new Padding(3, 4, 3, 4);
            gpBoxAlternativas.Size = new Size(408, 283);
            gpBoxAlternativas.TabIndex = 4;
            gpBoxAlternativas.TabStop = false;
            gpBoxAlternativas.Text = "Alternativas:";
            // 
            // listAlternativas
            // 
            listAlternativas.FormattingEnabled = true;
            listAlternativas.Location = new Point(0, 67);
            listAlternativas.Name = "listAlternativas";
            listAlternativas.Size = new Size(408, 202);
            listAlternativas.TabIndex = 4;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(24, 29);
            btnRemover.Margin = new Padding(3, 4, 3, 4);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(126, 31);
            btnRemover.TabIndex = 3;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(429, 632);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(109, 57);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(313, 632);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(109, 57);
            btnGravar.TabIndex = 11;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // TelaQuestoesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 702);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(gpBoxAlternativas);
            Controls.Add(btnAdicionar);
            Controls.Add(txtAlternativa);
            Controls.Add(txtEnunciado);
            Controls.Add(lblEnunciado);
            Controls.Add(lblAlternativa);
            Controls.Add(lblMateria);
            Controls.Add(cmbBoxMateria);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaQuestoesForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TelaQuestoesForm";
            gpBoxAlternativas.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBoxMateria;
        private Label lblMateria;
        private TextBox txtEnunciado;
        private Label lblAlternativa;
        private Label lblEnunciado;
        private TextBox txtAlternativa;
        private Button btnAdicionar;
        private GroupBox gpBoxAlternativas;
        private Button btnRemover;
        private Button btnCancelar;
        private Button btnGravar;
        private CheckedListBox listAlternativas;
    }
}