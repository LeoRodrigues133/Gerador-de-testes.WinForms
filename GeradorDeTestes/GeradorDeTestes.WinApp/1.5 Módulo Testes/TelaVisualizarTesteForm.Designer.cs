namespace GeradorDeTestes.View.MóduloTestes
{
    partial class TelaVisualizarTesteForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblTitulo = new Label();
            lblDisciplina = new Label();
            lblMateria = new Label();
            groupBox1 = new GroupBox();
            listQuestoes = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(42, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 0;
            label1.Text = "Titulo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(15, 85);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 1;
            label2.Text = "Disciplina:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(28, 136);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 2;
            label3.Text = "Matéria:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.Location = new Point(125, 33);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(118, 21);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "[Nome Titulo]";
            // 
            // lblDisciplina
            // 
            lblDisciplina.AutoSize = true;
            lblDisciplina.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDisciplina.Location = new Point(125, 85);
            lblDisciplina.Margin = new Padding(4, 0, 4, 0);
            lblDisciplina.Name = "lblDisciplina";
            lblDisciplina.Size = new Size(149, 21);
            lblDisciplina.TabIndex = 4;
            lblDisciplina.Text = "[Nome Disciplina}";
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMateria.Location = new Point(125, 136);
            lblMateria.Margin = new Padding(4, 0, 4, 0);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(132, 21);
            lblMateria.TabIndex = 5;
            lblMateria.Text = "[Nome Matéria]";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listQuestoes);
            groupBox1.Location = new Point(15, 193);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(511, 297);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Questões Selecionadas";
            // 
            // listQuestoes
            // 
            listQuestoes.FormattingEnabled = true;
            listQuestoes.ItemHeight = 21;
            listQuestoes.Location = new Point(13, 37);
            listQuestoes.Name = "listQuestoes";
            listQuestoes.Size = new Size(480, 235);
            listQuestoes.TabIndex = 0;
            // 
            // TelaVisualizarTesteForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 503);
            Controls.Add(groupBox1);
            Controls.Add(lblMateria);
            Controls.Add(lblDisciplina);
            Controls.Add(lblTitulo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaVisualizarTesteForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Visualizar Testes";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblTitulo;
        private Label lblDisciplina;
        private Label lblMateria;
        private GroupBox groupBox1;
        private ListBox listQuestoes;
    }
}