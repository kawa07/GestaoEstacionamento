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
    public partial class FormSaida : Form
    {
        public FormSaida()
        {
            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            string placaSaida = txtPlacaSaida.Text;
            List<string> linhasAtualizadas = new List<string>();
            bool encontrado = false;
            string horarioEntrada = "";

            if (File.Exists("estacionamento.txt"))
            {
                string[] linhas = File.ReadAllLines("estacionamento.txt");
                foreach (string linha in linhas)
                {
                    if (linha.StartsWith(placaSaida))
                    {
                        encontrado = true;
                        string[] dados = linha.Split(';');
                        horarioEntrada = dados[3];
                    }
                    else
                    {
                        linhasAtualizadas.Add(linha);
                    }
                }

                if (encontrado)
                {
                    File.WriteAllLines("estacionamento.txt", linhasAtualizadas);

                    DateTime entrada = DateTime.Parse(horarioEntrada);
                    TimeSpan tempoEstacionado = DateTime.Now - entrada;
                    double preco = tempoEstacionado.TotalHours * 5.00;

                    lblTempoEstacionado.Text = $"Tempo: {tempoEstacionado.TotalHours:F2} horas";
                    lblValorTotal.Text = $"Valor: R$ {preco:F2}";

                    MessageBox.Show($"Pagamento realizado com sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Veículo não encontrado!");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Gerenciamento tela1 = new Gerenciamento();
            this.Hide();
            tela1.ShowDialog();
            this.Show();
        }

        private void FormSaida_Load(object sender, EventArgs e)
        {

        }
    }
}
