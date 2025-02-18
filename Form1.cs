using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestãoEstacionamento
{
    public partial class Gerenciamento : Form
    {
        public Gerenciamento()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Impede redimensionamento
            this.MaximizeBox = false; // Impede maximizar
        }

        private void Gerenciamento_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            VerificarArquivo();
            AtualizarListaVeiculos();
        }

        private void ConfigurarDataGridView()
        {
            dgvVeiculos.Columns.Clear();
            dgvVeiculos.Columns.Add("placa", "Placa");
            dgvVeiculos.Columns.Add("modelo", "Modelo");
            dgvVeiculos.Columns.Add("cor", "Cor");
            dgvVeiculos.Columns.Add("horario", "Horário de Entrada");

            dgvVeiculos.AllowUserToAddRows = false;
            dgvVeiculos.ReadOnly = true;
        }

        private void VerificarArquivo()
        {
            if (!File.Exists("estacionamento.txt"))
            {
                File.Create("estacionamento.txt").Close();
            }
        }

        private void AtualizarListaVeiculos()
        {
            dgvVeiculos.Rows.Clear();

            string[] linhas = File.ReadAllLines("estacionamento.txt");

            foreach (string linha in linhas)
            {
                string[] dados = linha.Split(';');

                if (dados.Length == 4)
                {
                    dgvVeiculos.Rows.Add(dados[0], dados[1], dados[2], dados[3]);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormEntrada telaEntrada = new FormEntrada();
            telaEntrada.ShowDialog(); // Abre sem esconder a tela principal
            AtualizarListaVeiculos();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormSaida telaSaida = new FormSaida();
            telaSaida.ShowDialog(); // Abre sem esconder a tela principal
            AtualizarListaVeiculos();
        }
    }
}
