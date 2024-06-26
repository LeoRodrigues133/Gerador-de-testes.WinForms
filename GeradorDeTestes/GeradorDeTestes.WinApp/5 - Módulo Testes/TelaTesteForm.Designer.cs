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
            lblTitulo.Location = new Point(27, 68);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(50, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(90, 65);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(455, 27);
            txtTitulo.TabIndex = 1;
            // 
            // lblDisciplina
            // 
            lblDisciplina.AutoSize = true;
            lblDisciplina.Location = new Point(11, 128);
            lblDisciplina.Name = "lblDisciplina";
            lblDisciplina.Size = new Size(73, 20);
            lblDisciplina.TabIndex = 2;
            lblDisciplina.Text = "Discplina:";
            // 
            // cmbBoxDisciplina
            // 
            cmbBoxDisciplina.FormattingEnabled = true;
            cmbBoxDisciplina.Location = new Point(90, 125);
            cmbBoxDisciplina.Name = "cmbBoxDisciplina";
            cmbBoxDisciplina.Size = new Size(217, 28);
            cmbBoxDisciplina.TabIndex = 2;
            cmbBoxDisciplina.SelectedIndexChanged += cmbBoxDisciplina_SelectedIndexChanged;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new Point(21, 180);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(63, 20);
            lblMateria.TabIndex = 2;
            lblMateria.Text = "Matéria:";
            // 
            // cmbBoxMateria
            // 
            cmbBoxMateria.FormattingEnabled = true;
            cmbBoxMateria.Location = new Point(90, 177);
            cmbBoxMateria.Name = "cmbBoxMateria";
            cmbBoxMateria.Size = new Size(217, 28);
            cmbBoxMateria.TabIndex = 3;
            // 
            // lblNumQuestoes
            // 
            lblNumQuestoes.AutoSize = true;
            lblNumQuestoes.Location = new Point(375, 125);
            lblNumQuestoes.Name = "lblNumQuestoes";
            lblNumQuestoes.Size = new Size(102, 20);
            lblNumQuestoes.TabIndex = 4;
            lblNumQuestoes.Text = "Qts. Questões:";
            // 
            // numQuestoes
            // 
            numQuestoes.Location = new Point(483, 121);
            numQuestoes.Name = "numQuestoes";
            numQuestoes.Size = new Size(62, 27);
            numQuestoes.TabIndex = 4;
            // 
            // chkRecuperacao
            // 
            chkRecuperacao.AutoSize = true;
            chkRecuperacao.Location = new Point(366, 181);
            chkRecuperacao.Name = "chkRecuperacao";
            chkRecuperacao.Size = new Size(179, 24);
            chkRecuperacao.TabIndex = 5;
            chkRecuperacao.Text = "Prova de Recuperação";
            chkRecuperacao.UseVisualStyleBackColor = true;
            chkRecuperacao.CheckedChanged += chkRecuperacao_CheckedChanged;
            // 
            // gBoxQuestoes
            // 
            gBoxQuestoes.Controls.Add(btnSortearQuestoes);
            gBoxQuestoes.Controls.Add(listQuestoes);
            gBoxQuestoes.Location = new Point(46, 227);
            gBoxQuestoes.Name = "gBoxQuestoes";
            gBoxQuestoes.Size = new Size(525, 315);
            gBoxQuestoes.TabIndex = 7;
            gBoxQuestoes.TabStop = false;
            gBoxQuestoes.Text = "Questões Selecionadas";
            // 
            // btnSortearQuestoes
            // 
            btnSortearQuestoes.Location = new Point(6, 27);
            btnSortearQuestoes.Name = "btnSortearQuestoes";
            btnSortearQuestoes.Size = new Size(159, 39);
            btnSortearQuestoes.TabIndex = 6;
            btnSortearQuestoes.Text = "Sortear Questões";
            btnSortearQuestoes.UseVisualStyleBackColor = true;
            btnSortearQuestoes.Click += btnSortearQuestoes_Click;
            // 
            // listQuestoes
            // 
            listQuestoes.FormattingEnabled = true;
            listQuestoes.Location = new Point(0, 85);
            listQuestoes.Name = "listQuestoes";
            listQuestoes.Size = new Size(525, 224);
            listQuestoes.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(494, 575);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(109, 57);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(378, 575);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(109, 57);
            btnGravar.TabIndex = 7;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 35);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(90, 32);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(50, 27);
            txtId.TabIndex = 1;
            txtId.Text = "0";
            txtId.TextAlign = HorizontalAlignment.Right;
            // 
            // TelaTesteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 645);
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