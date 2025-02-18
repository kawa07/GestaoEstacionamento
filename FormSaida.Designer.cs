namespace GestãoEstacionamento
{
    partial class FormSaida
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
            groupBox1 = new GroupBox();
            btnCancelar = new Button();
            btnFinalizar = new Button();
            lblValorTotal = new Label();
            lblTempoEstacionado = new Label();
            label1 = new Label();
            txtPlacaSaida = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnFinalizar);
            groupBox1.Controls.Add(lblValorTotal);
            groupBox1.Controls.Add(lblTempoEstacionado);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPlacaSaida);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(193, 215);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Saída";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(105, 142);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(7, 142);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(75, 23);
            btnFinalizar.TabIndex = 4;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // lblValorTotal
            // 
            lblValorTotal.AutoSize = true;
            lblValorTotal.Location = new Point(9, 113);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(36, 15);
            lblValorTotal.TabIndex = 3;
            lblValorTotal.Text = "Valor:";
            // 
            // lblTempoEstacionado
            // 
            lblTempoEstacionado.AutoSize = true;
            lblTempoEstacionado.Location = new Point(9, 89);
            lblTempoEstacionado.Name = "lblTempoEstacionado";
            lblTempoEstacionado.Size = new Size(46, 15);
            lblTempoEstacionado.TabIndex = 2;
            lblTempoEstacionado.Text = "Tempo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 35);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 1;
            label1.Text = "Placa do Veículo:";
            // 
            // txtPlacaSaida
            // 
            txtPlacaSaida.Location = new Point(7, 55);
            txtPlacaSaida.Name = "txtPlacaSaida";
            txtPlacaSaida.Size = new Size(173, 23);
            txtPlacaSaida.TabIndex = 0;
            // 
            // FormSaida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(219, 244);
            Controls.Add(groupBox1);
            Name = "FormSaida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSaida";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtPlacaSaida;
        private Label lblValorTotal;
        private Label lblTempoEstacionado;
        private Button btnCancelar;
        private Button btnFinalizar;
    }
}