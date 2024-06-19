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
            btnRemover = new Button();
            gpBoxAlternativas.SuspendLayout();
            SuspendLayout();
            // 
            // cmbBoxMateria
            // 
            cmbBoxMateria.FormattingEnabled = true;
            cmbBoxMateria.Location = new Point(83, 35);
            cmbBoxMateria.Name = "cmbBoxMateria";
            cmbBoxMateria.Size = new Size(247, 23);
            cmbBoxMateria.TabIndex = 0;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new Point(27, 35);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(50, 15);
            lblMateria.TabIndex = 1;
            lblMateria.Text = "Matéria:";
            // 
            // txtEnunciado
            // 
            txtEnunciado.Location = new Point(83, 88);
            txtEnunciado.Multiline = true;
            txtEnunciado.Name = "txtEnunciado";
            txtEnunciado.Size = new Size(351, 92);
            txtEnunciado.TabIndex = 2;
            // 
            // lblAlternativa
            // 
            lblAlternativa.AutoSize = true;
            lblAlternativa.Location = new Point(10, 199);
            lblAlternativa.Name = "lblAlternativa";
            lblAlternativa.Size = new Size(67, 15);
            lblAlternativa.TabIndex = 1;
            lblAlternativa.Text = "Alternativa:";
            // 
            // lblEnunciado
            // 
            lblEnunciado.AutoSize = true;
            lblEnunciado.Location = new Point(11, 114);
            lblEnunciado.Name = "lblEnunciado";
            lblEnunciado.Size = new Size(66, 15);
            lblEnunciado.TabIndex = 1;
            lblEnunciado.Text = "Enunciado:";
            // 
            // txtAlternativa
            // 
            txtAlternativa.Location = new Point(83, 186);
            txtAlternativa.Multiline = true;
            txtAlternativa.Name = "txtAlternativa";
            txtAlternativa.Size = new Size(247, 51);
            txtAlternativa.TabIndex = 2;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(343, 200);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(86, 37);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // gpBoxAlternativas
            // 
            gpBoxAlternativas.Controls.Add(btnRemover);
            gpBoxAlternativas.Location = new Point(77, 256);
            gpBoxAlternativas.Name = "gpBoxAlternativas";
            gpBoxAlternativas.Size = new Size(357, 201);
            gpBoxAlternativas.TabIndex = 4;
            gpBoxAlternativas.TabStop = false;
            gpBoxAlternativas.Text = "Alternativas:";
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(21, 22);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(110, 23);
            btnRemover.TabIndex = 3;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // TelaQuestoesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 483);
            Controls.Add(gpBoxAlternativas);
            Controls.Add(btnAdicionar);
            Controls.Add(txtAlternativa);
            Controls.Add(txtEnunciado);
            Controls.Add(lblEnunciado);
            Controls.Add(lblAlternativa);
            Controls.Add(lblMateria);
            Controls.Add(cmbBoxMateria);
            Name = "TelaQuestoesForm";
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
    }
}