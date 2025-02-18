using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestãoEstacionamento
{
    public partial class FormEntrada : Form
    {
        public FormEntrada()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text;
            string modelo = txtModelo.Text;
            string cor = txtCor.Text;
            string horarioEntrada = DateTime.Now.ToString("HH:mm:ss");

            using (StreamWriter writer = new StreamWriter("estacionamento.txt", true))
            {
                writer.WriteLine($"{placa};{modelo};{cor};{horarioEntrada}");
            }

            MessageBox.Show("Entrada registrada com sucesso!");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Gerenciamento tela1 = new Gerenciamento();
            this.Hide();
            tela1.ShowDialog();
            this.Show();
        }
    }
}
