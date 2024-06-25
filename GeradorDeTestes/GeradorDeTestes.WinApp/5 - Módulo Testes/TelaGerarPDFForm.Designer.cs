namespace GeradorDeTestes.WinApp._4___Módulo_Testes
{
    partial class TelaGerarPDFForm
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
            checkBoxGabarito = new CheckBox();
            btnGerarPdf = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 73);
            label1.Name = "label1";
            label1.Size = new Size(492, 28);
            label1.TabIndex = 0;
            label1.Text = "Gostaria de gerar o PDF com o gabarito das questões ?";
            // 
            // checkBoxGabarito
            // 
            checkBoxGabarito.AutoSize = true;
            checkBoxGabarito.Location = new Point(29, 81);
            checkBoxGabarito.Margin = new Padding(3, 4, 3, 4);
            checkBoxGabarito.Name = "checkBoxGabarito";
            checkBoxGabarito.Size = new Size(18, 17);
            checkBoxGabarito.TabIndex = 1;
            checkBoxGabarito.UseVisualStyleBackColor = true;
            // 
            // btnGerarPdf
            // 
            btnGerarPdf.DialogResult = DialogResult.OK;
            btnGerarPdf.Location = new Point(286, 128);
            btnGerarPdf.Margin = new Padding(3, 4, 3, 4);
            btnGerarPdf.Name = "btnGerarPdf";
            btnGerarPdf.Size = new Size(102, 45);
            btnGerarPdf.TabIndex = 2;
            btnGerarPdf.Text = "Gerar";
            btnGerarPdf.UseVisualStyleBackColor = true;
            btnGerarPdf.Click += btnGerarPdf_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(395, 128);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(102, 45);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaGerarPDFForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 189);
            Controls.Add(btnCancelar);
            Controls.Add(btnGerarPdf);
            Controls.Add(checkBoxGabarito);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaGerarPDFForm";
            ShowIcon = false;
            Text = "Gerar PDF";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox checkBoxGabarito;
        private Button btnGerarPdf;
        private Button btnCancelar;
    }
}