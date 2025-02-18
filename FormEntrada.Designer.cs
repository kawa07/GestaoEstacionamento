namespace GestãoEstacionamento
{
    partial class FormEntrada
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
            Entrada = new GroupBox();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            lblHoraEntrada = new Label();
            label3 = new Label();
            txtCor = new TextBox();
            label2 = new Label();
            txtModelo = new TextBox();
            label1 = new Label();
            txtPlaca = new TextBox();
            Entrada.SuspendLayout();
            SuspendLayout();
            // 
            // Entrada
            // 
            Entrada.Controls.Add(btnCancelar);
            Entrada.Controls.Add(btnConfirmar);
            Entrada.Controls.Add(lblHoraEntrada);
            Entrada.Controls.Add(label3);
            Entrada.Controls.Add(txtCor);
            Entrada.Controls.Add(label2);
            Entrada.Controls.Add(txtModelo);
            Entrada.Controls.Add(label1);
            Entrada.Controls.Add(txtPlaca);
            Entrada.Location = new Point(12, 12);
            Entrada.Name = "Entrada";
            Entrada.Size = new Size(295, 264);
            Entrada.TabIndex = 0;
            Entrada.TabStop = false;
            Entrada.Text = "Entrada";
            Entrada.Enter += groupBox1_Enter;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(87, 220);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(6, 220);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 8;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblHoraEntrada
            // 
            lblHoraEntrada.AutoSize = true;
            lblHoraEntrada.Location = new Point(48, 179);
            lblHoraEntrada.Name = "lblHoraEntrada";
            lblHoraEntrada.Size = new Size(0, 15);
            lblHoraEntrada.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 125);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 5;
            label3.Text = "Cor do Veículo";
            // 
            // txtCor
            // 
            txtCor.Location = new Point(6, 143);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(278, 23);
            txtCor.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 80);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 3;
            label2.Text = "Modelo do Veículo";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(6, 98);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(278, 23);
            txtModelo.TabIndex = 2;
            txtModelo.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 1;
            label1.Text = "Placa do Veículo";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(6, 52);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(278, 23);
            txtPlaca.TabIndex = 0;
            // 
            // FormEntrada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 286);
            Controls.Add(Entrada);
            Name = "FormEntrada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entrada";
            Entrada.ResumeLayout(false);
            Entrada.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Entrada;
        private Label label1;
        private TextBox txtPlaca;
        private Label label2;
        private TextBox txtModelo;
        private Label label3;
        private TextBox txtCor;
        private Button btnCancelar;
        private Button btnConfirmar;
        private Label lblHoraEntrada;
    }
}