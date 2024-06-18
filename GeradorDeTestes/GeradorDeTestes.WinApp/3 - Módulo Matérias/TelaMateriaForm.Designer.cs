namespace GeradorDeTestes.WinApp._3___Módulo_Matérias
{
    partial class TelaMateriaForm
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
            label4 = new Label();
            txtId = new TextBox();
            txtMateria = new TextBox();
            rdb1Serie = new RadioButton();
            rdb2Serie = new RadioButton();
            cmbBoxDisciplina = new ComboBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 26);
            label1.Name = "label1";
            label1.Size = new Size(24, 17);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 67);
            label2.Name = "label2";
            label2.Size = new Size(48, 17);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 145);
            label3.Name = "label3";
            label3.Size = new Size(37, 17);
            label3.TabIndex = 2;
            label3.Text = "Série";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(11, 108);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 3;
            label4.Text = "Disciplina";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ScrollBar;
            txtId.Location = new Point(81, 25);
            txtId.Name = "txtId";
            txtId.Size = new Size(61, 23);
            txtId.TabIndex = 4;
            // 
            // txtMateria
            // 
            txtMateria.Location = new Point(81, 67);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(407, 23);
            txtMateria.TabIndex = 5;
            // 
            // rdb1Serie
            // 
            rdb1Serie.AutoSize = true;
            rdb1Serie.Location = new Point(81, 145);
            rdb1Serie.Name = "rdb1Serie";
            rdb1Serie.Size = new Size(64, 19);
            rdb1Serie.TabIndex = 6;
            rdb1Serie.TabStop = true;
            rdb1Serie.Text = "1º Série";
            rdb1Serie.UseVisualStyleBackColor = true;
            // 
            // rdb2Serie
            // 
            rdb2Serie.AutoSize = true;
            rdb2Serie.Location = new Point(160, 145);
            rdb2Serie.Name = "rdb2Serie";
            rdb2Serie.Size = new Size(64, 19);
            rdb2Serie.TabIndex = 7;
            rdb2Serie.TabStop = true;
            rdb2Serie.Text = "2º Série";
            rdb2Serie.UseVisualStyleBackColor = true;
            // 
            // cmbBoxDiscplina
            // 
            cmbBoxDisciplina.FormattingEnabled = true;
            cmbBoxDisciplina.Location = new Point(81, 107);
            cmbBoxDisciplina.Name = "cmbBoxDiscplina";
            cmbBoxDisciplina.Size = new Size(121, 23);
            cmbBoxDisciplina.TabIndex = 8;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.BackColor = SystemColors.Window;
            btnSalvar.Location = new Point(285, 131);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 36);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.BackColor = SystemColors.Window;
            btnCancelar.Location = new Point(394, 131);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 36);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // TelaMateriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 179);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(cmbBoxDisciplina);
            Controls.Add(rdb2Serie);
            Controls.Add(rdb1Serie);
            Controls.Add(txtMateria);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaMateriaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaMateriaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtId;
        private TextBox txtMateria;
        private RadioButton rdb1Serie;
        private RadioButton rdb2Serie;
        private ComboBox cmbBoxDisciplina;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}