namespace GeradorDeTestes.WinApp._2___Módulo_Disciplinas
{
    partial class TelaDisciplinaForm
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
            lblId = new Label();
            txtId = new TextBox();
            lblDisciplina = new Label();
            txtDisciplina = new TextBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(82, 89);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(108, 86);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            txtId.TextAlign = HorizontalAlignment.Right;
            // 
            // lblDisciplina
            // 
            lblDisciplina.AutoSize = true;
            lblDisciplina.Location = new Point(59, 118);
            lblDisciplina.Name = "lblDisciplina";
            lblDisciplina.Size = new Size(43, 15);
            lblDisciplina.TabIndex = 0;
            lblDisciplina.Text = "Nome:";
            // 
            // txtDisciplina
            // 
            txtDisciplina.Location = new Point(108, 115);
            txtDisciplina.Name = "txtDisciplina";
            txtDisciplina.Size = new Size(351, 23);
            txtDisciplina.TabIndex = 1;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(295, 244);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(95, 43);
            btnGravar.TabIndex = 2;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(396, 244);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 43);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaDisciplinaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 299);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtDisciplina);
            Controls.Add(lblDisciplina);
            Controls.Add(txtId);
            Controls.Add(lblId);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TelaDisciplinaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de disciplinas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private TextBox txtId;
        private Label lblDisciplina;
        private TextBox txtDisciplina;
        private Button btnGravar;
        private Button btnCancelar;
    }
}