using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace blackjack
{
    public partial class Form1 : Form
    {

        public class Carta
        {
            public string Nome { get; set; }
            public int Valor { get; set; }

            public System.Drawing.Image Imagem { get; set; }

            public Carta(string nome, int valor, System.Drawing.Image imagem)
            {
                Nome = nome;
                Valor = valor;
                Imagem = imagem;
            }
        }
        public class Baralho
        {
            private List<Carta> cartas;
            private Random random = new Random();
            private string basePath;

            public Baralho()
            {
                basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
                ReporCartas(); // Inicializa o baralho com todas as cartas
            }

            // Método para reabastecer e embaralhar o baralho
            public void ReporCartas()
            {
                cartas = new List<Carta>
                {
                    // Espadas
                    new Carta("Ás de Espadas", 11, System.Drawing.Image.FromFile(basePath + "imagens/1.png")),
                    new Carta("Dois de Espadas", 2, System.Drawing.Image.FromFile(basePath + "imagens/5.png")),
                    new Carta("Três de Espadas", 3, System.Drawing.Image.FromFile(basePath + "imagens/9.png")),
                    new Carta("Quatro de Espadas", 4, System.Drawing.Image.FromFile(basePath + "imagens/13.png")),
                    new Carta("Cinco de Espadas", 5, System.Drawing.Image.FromFile(basePath + "imagens/17.png")),
                    new Carta("Seis de Espadas", 6, System.Drawing.Image.FromFile(basePath + "imagens/21.png")),
                    new Carta("Sete de Espadas", 7, System.Drawing.Image.FromFile(basePath + "imagens/25.png")),
                    new Carta("Oito de Espadas", 8, System.Drawing.Image.FromFile(basePath + "imagens/29.png")),
                    new Carta("Nove de Espadas", 9, System.Drawing.Image.FromFile(basePath + "imagens/33.png")),
                    new Carta("Dez de Espadas", 10, System.Drawing.Image.FromFile(basePath + "imagens/37.png")),
                    new Carta("Valete de Espadas", 10, System.Drawing.Image.FromFile(basePath + "imagens/41.png")),
                    new Carta("Rainha de Espadas", 10, System.Drawing.Image.FromFile(basePath + "imagens/45.png")),
                    new Carta("Rei de Espadas", 10, System.Drawing.Image.FromFile(basePath + "imagens/49.png")),

                    // Paus
                    new Carta("Ás de Paus", 11, System.Drawing.Image.FromFile(basePath + "imagens/2.png")),
                    new Carta("Dois de Paus", 2, System.Drawing.Image.FromFile(basePath + "imagens/6.png")),
                    new Carta("Três de Paus", 3, System.Drawing.Image.FromFile(basePath + "imagens/10.png")),
                    new Carta("Quatro de Paus", 4, System.Drawing.Image.FromFile(basePath + "imagens/14.png")),
                    new Carta("Cinco de Paus", 5, System.Drawing.Image.FromFile(basePath + "imagens/18.png")),
                    new Carta("Seis de Paus", 6, System.Drawing.Image.FromFile(basePath + "imagens/22.png")),
                    new Carta("Sete de Paus", 7, System.Drawing.Image.FromFile(basePath + "imagens/26.png")),
                    new Carta("Oito de Paus", 8, System.Drawing.Image.FromFile(basePath + "imagens/30.png")),
                    new Carta("Nove de Paus", 9, System.Drawing.Image.FromFile(basePath + "imagens/34.png")),
                    new Carta("Dez de Paus", 10, System.Drawing.Image.FromFile(basePath + "imagens/38.png")),
                    new Carta("Valete de Paus", 10, System.Drawing.Image.FromFile(basePath + "imagens/42.png")),
                    new Carta("Rainha de Paus", 10, System.Drawing.Image.FromFile(basePath + "imagens/46.png")),
                    new Carta("Rei de Paus", 10, System.Drawing.Image.FromFile(basePath + "imagens/50.png")),

                    // Copas
                    new Carta("Ás de Copas", 11, System.Drawing.Image.FromFile(basePath + "imagens/3.png")),
                    new Carta("Dois de Copas", 2, System.Drawing.Image.FromFile(basePath + "imagens/7.png")),
                    new Carta("Três de Copas", 3, System.Drawing.Image.FromFile(basePath + "imagens/11.png")),
                    new Carta("Quatro de Copas", 4, System.Drawing.Image.FromFile(basePath + "imagens/15.png")),
                    new Carta("Cinco de Copas", 5, System.Drawing.Image.FromFile(basePath + "imagens/19.png")),
                    new Carta("Seis de Copas", 6, System.Drawing.Image.FromFile(basePath + "imagens/23.png")),
                    new Carta("Sete de Copas", 7, System.Drawing.Image.FromFile(basePath + "imagens/27.png")),
                    new Carta("Oito de Copas", 8, System.Drawing.Image.FromFile(basePath + "imagens/31.png")),
                    new Carta("Nove de Copas", 9, System.Drawing.Image.FromFile(basePath + "imagens/35.png")),
                    new Carta("Dez de Copas", 10, System.Drawing.Image.FromFile(basePath + "imagens/39.png")),
                    new Carta("Valete de Copas", 10, System.Drawing.Image.FromFile(basePath + "imagens/43.png")),
                    new Carta("Rainha de Copas", 10, System.Drawing.Image.FromFile(basePath + "imagens/47.png")),
                    new Carta("Rei de Copas", 10, System.Drawing.Image.FromFile(basePath + "imagens/51.png")),

                    // Ouros
                    new Carta("Ás de Ouros", 11, System.Drawing.Image.FromFile(basePath + "imagens/4.png")),
                    new Carta("Dois de Ouros", 2, System.Drawing.Image.FromFile(basePath + "imagens/8.png")),
                    new Carta("Três de Ouros", 3, System.Drawing.Image.FromFile(basePath + "imagens/12.png")),
                    new Carta("Quatro de Ouros", 4, System.Drawing.Image.FromFile(basePath + "imagens/16.png")),
                    new Carta("Cinco de Ouros", 5, System.Drawing.Image.FromFile(basePath + "imagens/20.png")),
                    new Carta("Seis de Ouros", 6, System.Drawing.Image.FromFile(basePath + "imagens/24.png")),
                    new Carta("Sete de Ouros", 7, System.Drawing.Image.FromFile(basePath + "imagens/28.png")),
                    new Carta("Oito de Ouros", 8, System.Drawing.Image.FromFile(basePath + "imagens/32.png")),
                    new Carta("Nove de Ouros", 9, System.Drawing.Image.FromFile(basePath + "imagens/36.png")),
                    new Carta("Dez de Ouros", 10, System.Drawing.Image.FromFile(basePath + "imagens/40.png")),
                    new Carta("Valete de Ouros", 10, System.Drawing.Image.FromFile(basePath + "imagens/44.png")),
                    new Carta("Rainha de Ouros", 10, System.Drawing.Image.FromFile(basePath + "imagens/48.png")),
                    new Carta("Rei de Ouros", 10, System.Drawing.Image.FromFile(basePath + "imagens/52.png"))
                };

                Embaralhar();
            }

            // Método para embaralhar o baralho
            public void Embaralhar()
            {
                cartas = cartas.OrderBy(x => random.Next()).ToList();
            }

            // Método para distribuir uma carta, reabastecendo o baralho se estiver vazio
            public Carta DistribuirCarta()
            {
                if (cartas.Count == 0)
                {
                    ReporCartas(); // Reabastece o baralho se estiver vazio
                }

                int index = random.Next(cartas.Count);
                Carta carta = cartas[index];
                cartas.RemoveAt(index);
                return carta;
            }
        }

        private List<Carta> maoJogador = new List<Carta>();
        private List<Carta> maoDealer = new List<Carta>();
        private Baralho baralho;

        public Form1()
        {
            InitializeComponent();
            baralho = new Baralho();
            IniciarJogo();
        }
        private void IniciarJogo()
        {
            maoJogador.Clear();
            maoDealer.Clear();
            maoJogador.Add(baralho.DistribuirCarta());
            maoJogador.Add(baralho.DistribuirCarta());
            maoDealer.Add(baralho.DistribuirCarta());
            AtualizarTela();
        }

        private void AtualizarTela()
        {
            string basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
            flp_mao_jogador.Controls.Clear();
            flp_mao_dealer.Controls.Clear();

            // Atualiza as cartas do jogador
            foreach (var carta in maoJogador)
            {
                PictureBox pb = new PictureBox();
                pb.Image = carta.Imagem;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Size = new Size(60, 90);
                flp_mao_jogador.Controls.Add(pb);
            }
            lb_mao_jogador.Text = "Cartas Jogador: " + string.Join(", ", maoJogador.Select(c => c.Nome));

            // Atualiza os pontos do jogador
            int pontosJogador = CalcularPontos(maoJogador);
            lb_pontos_jogador.Text = "Pontos Jogador: " + pontosJogador;

            // Atualiza as cartas do dealer
            for (int i = 0; i < maoDealer.Count; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Size = new Size(60, 90);

                // Mostra a primeira carta do dealer e oculta as outras até o "stand"
                if (i == 0 || maoDealer.Count > 1)
                {
                    pb.Image = maoDealer[i].Imagem;
                }
                else
                {
                    pb.Image = System.Drawing.Image.FromFile(basePath + "imagens/0.png");
                }

                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                flp_mao_dealer.Controls.Add(pb);
            }
            lb_mao_dealer.Text = "Cartas Dealer: " + maoDealer[0].Nome + ", [Carta Oculta]";

            int pontosDealerParcial = maoDealer[0].Valor;
            

            // Se o jogador terminou a jogada (clicou em Stand), mostra as cartas e pontos completos do dealer
            if (maoDealer.Count > 1)
            {
                lb_mao_dealer.Text = "Cartas Dealer: " + string.Join(", ", maoDealer.Select(c => c.Nome));
                int pontosDealer = CalcularPontos(maoDealer);
                
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_hit_Click(object sender, EventArgs e)
        {
            maoJogador.Add(baralho.DistribuirCarta());
            if (CalcularPontos(maoJogador) > 21)
            {
                MessageBox.Show("Você perdeu! Estourou 21.");
                IniciarJogo();
            }
            AtualizarTela();
        }

        private void btn_stand_Click(object sender, EventArgs e)
        {
            while (CalcularPontos(maoDealer) < 17)
            {
                maoDealer.Add(baralho.DistribuirCarta());
            }
            VerificarVencedor();
            AtualizarTela();
        }

        private int CalcularPontos(List<Carta> mao)
        {
            int pontos = mao.Sum(c => c.Valor);
            int ases = mao.Count(c => c.Nome == "Ás");
            while (pontos > 21 && ases > 0)
            {
                pontos -= 10;
                ases--;
            }
            return pontos;
        }

        private void VerificarVencedor()
        {
            int pontosJogador = CalcularPontos(maoJogador);
            int pontosDealer = CalcularPontos(maoDealer);

            if (pontosDealer > 21 || pontosJogador > pontosDealer)
            {
                MessageBox.Show("Você ganhou!");
            }
            else if (pontosJogador == pontosDealer)
            {
                MessageBox.Show("Empate!");
            }
            else
            {
                MessageBox.Show("Você perdeu!");
            }
            IniciarJogo();
        }

        private void flp_mao_dealer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            IniciarJogo();
            MessageBox.Show("O jogo foi reiniciado!");
        }
    }
}
