namespace GeradorDeTestes.WinApp._4___Módulo_Testes
{
    partial class TelaTesteForm
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
            lblTitulo = new Label();
            txtTitulo = new TextBox();
            lblDisciplina = new Label();
            cmbBoxDisciplina = new ComboBox();
            lblMateria = new Label();
            cmbBoxMateria = new ComboBox();
            lblNumQuestoes = new Label();
            numQuestoes = new NumericUpDown();
            chkRecuperacao = new CheckBox();
            gBoxQuestoes = new GroupBox();
            btnSortearQuestoes = new Button();
            listQuestoes = new ListBox();
            btnCancelar = new Button();
            btnGravar = new Button();
            label1 = new Label();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numQuestoes).BeginInit();
            gBoxQuestoes.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(24, 51);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(40, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(79, 49);
            txtTitulo.Margin = new Padding(3, 2, 3, 2);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(399, 23);
            txtTitulo.TabIndex = 1;
            // 
            // lblDisciplina
            // 
            lblDisciplina.AutoSize = true;
            lblDisciplina.Location = new Point(10, 96);
            lblDisciplina.Name = "lblDisciplina";
            lblDisciplina.Size = new Size(58, 15);
            lblDisciplina.TabIndex = 2;
            lblDisciplina.Text = "Discplina:";
            // 
            // cmbBoxDisciplina
            // 
            cmbBoxDisciplina.FormattingEnabled = true;
            cmbBoxDisciplina.Location = new Point(79, 94);
            cmbBoxDisciplina.Margin = new Padding(3, 2, 3, 2);
            cmbBoxDisciplina.Name = "cmbBoxDisciplina";
            cmbBoxDisciplina.Size = new Size(190, 23);
            cmbBoxDisciplina.TabIndex = 3;
            cmbBoxDisciplina.SelectedIndexChanged += cmbBoxDisciplina_SelectedIndexChanged;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new Point(18, 135);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(50, 15);
            lblMateria.TabIndex = 2;
            lblMateria.Text = "Matéria:";
            // 
            // cmbBoxMateria
            // 
            cmbBoxMateria.FormattingEnabled = true;
            cmbBoxMateria.Location = new Point(79, 133);
            cmbBoxMateria.Margin = new Padding(3, 2, 3, 2);
            cmbBoxMateria.Name = "cmbBoxMateria";
            cmbBoxMateria.Size = new Size(190, 23);
            cmbBoxMateria.TabIndex = 3;
            // 
            // lblNumQuestoes
            // 
            lblNumQuestoes.AutoSize = true;
            lblNumQuestoes.Location = new Point(328, 94);
            lblNumQuestoes.Name = "lblNumQuestoes";
            lblNumQuestoes.Size = new Size(83, 15);
            lblNumQuestoes.TabIndex = 4;
            lblNumQuestoes.Text = "Qts. Questões:";
            // 
            // numQuestoes
            // 
            numQuestoes.Location = new Point(423, 91);
            numQuestoes.Margin = new Padding(3, 2, 3, 2);
            numQuestoes.Name = "numQuestoes";
            numQuestoes.Size = new Size(54, 23);
            numQuestoes.TabIndex = 5;
            // 
            // chkRecuperacao
            // 
            chkRecuperacao.AutoSize = true;
            chkRecuperacao.Location = new Point(320, 136);
            chkRecuperacao.Margin = new Padding(3, 2, 3, 2);
            chkRecuperacao.Name = "chkRecuperacao";
            chkRecuperacao.Size = new Size(143, 19);
            chkRecuperacao.TabIndex = 6;
            chkRecuperacao.Text = "Prova de Recuperação";
            chkRecuperacao.UseVisualStyleBackColor = true;
            // 
            // gBoxQuestoes
            // 
            gBoxQuestoes.Controls.Add(btnSortearQuestoes);
            gBoxQuestoes.Controls.Add(listQuestoes);
            gBoxQuestoes.Location = new Point(40, 170);
            gBoxQuestoes.Margin = new Padding(3, 2, 3, 2);
            gBoxQuestoes.Name = "gBoxQuestoes";
            gBoxQuestoes.Padding = new Padding(3, 2, 3, 2);
            gBoxQuestoes.Size = new Size(459, 236);
            gBoxQuestoes.TabIndex = 7;
            gBoxQuestoes.TabStop = false;
            gBoxQuestoes.Text = "Questões Selecionadas";
            // 
            // btnSortearQuestoes
            // 
            btnSortearQuestoes.Location = new Point(5, 20);
            btnSortearQuestoes.Margin = new Padding(3, 2, 3, 2);
            btnSortearQuestoes.Name = "btnSortearQuestoes";
            btnSortearQuestoes.Size = new Size(139, 29);
            btnSortearQuestoes.TabIndex = 1;
            btnSortearQuestoes.Text = "Sortear Questões";
            btnSortearQuestoes.UseVisualStyleBackColor = true;
            btnSortearQuestoes.Click += btnSortearQuestoes_Click;
            // 
            // listQuestoes
            // 
            listQuestoes.FormattingEnabled = true;
            listQuestoes.ItemHeight = 15;
            listQuestoes.Location = new Point(0, 64);
            listQuestoes.Margin = new Padding(3, 2, 3, 2);
            listQuestoes.Name = "listQuestoes";
            listQuestoes.Size = new Size(460, 169);
            listQuestoes.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(432, 431);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 43);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(331, 431);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(95, 43);
            btnGravar.TabIndex = 9;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 26);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(79, 24);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(44, 23);
            txtId.TabIndex = 1;
            txtId.Text = "0";
            txtId.TextAlign = HorizontalAlignment.Right;
            // 
            // TelaTesteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 484);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(gBoxQuestoes);
            Controls.Add(chkRecuperacao);
            Controls.Add(numQuestoes);
            Controls.Add(lblNumQuestoes);
            Controls.Add(cmbBoxMateria);
            Controls.Add(lblMateria);
            Controls.Add(cmbBoxDisciplina);
            Controls.Add(lblDisciplina);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(txtTitulo);
            Controls.Add(lblTitulo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaTesteForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TelaTesteForm";
            ((System.ComponentModel.ISupportInitialize)numQuestoes).EndInit();
            gBoxQuestoes.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtTitulo;
        private Label lblDisciplina;
        private ComboBox cmbBoxDisciplina;
        private Label lblMateria;
        private ComboBox cmbBoxMateria;
        private Label lblNumQuestoes;
        private NumericUpDown numQuestoes;
        private CheckBox chkRecuperacao;
        private GroupBox gBoxQuestoes;
        private Button btnSortearQuestoes;
        private ListBox listQuestoes;
        private Button btnCancelar;
        private Button btnGravar;
        private Label label1;
        private TextBox txtId;
    }
}