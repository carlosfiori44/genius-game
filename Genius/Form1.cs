using Genius.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genius
{
    public partial class Form1 : Form
    {
        /***Declaração das variáveis***/
        Random ran = new Random();
        //qntOld é a quantidade da sequência antiga e qntAtual é a atual. O tempo define o tempo do temporizador
        int qntOld = 0, qntAtual = 0, tempo; 
        int[] cores;  //cores vai guardar as cores sortedas, e selecPlayer quais o jogador clicou

        public Form1()
        {
            InitializeComponent();
            DesativarCores();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
        }

        /********Métodos_de_Atalho********/
        private void ControleRadios(bool radio) //Desativa/Ativa o botão de iniciar e os RadioButtons
        {
            radioFacil.Enabled = radio;
            radioMedio.Enabled = radio;
            radioDificil.Enabled = radio;
            radioPesadelo.Enabled = radio;
            bIniciar.Enabled = radio;
        }

        private void DesativarCores() //Desativa o click das cores
        {
            pbAmarelo.Enabled = false;
            pbAzul.Enabled = false;
            pbVerde.Enabled = false;
            pbVermelho.Enabled = false;
        }

        private void AtivarCores() //Ativa as cores para click
        {
            pbAmarelo.Enabled = true;
            pbAzul.Enabled = true;
            pbVerde.Enabled = true;
            pbVermelho.Enabled = true;
        }

        private void corPadrao() //Seta as cores padrão
        {
            pbAmarelo.Image = Properties.Resources.amarelo;
            pbAzul.Image = Properties.Resources.azul;
            pbVerde.Image = Properties.Resources.verde;
            pbVermelho.Image = Properties.Resources.vermelho;
        }

        /*******Processamento*******/

        private void bSair_Click(object sender, EventArgs e) //Botão para sair do jogo
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bIniciar_Click(object sender, EventArgs e)//Inicia o Jogo
        {
            timer2.Start();
            if (radioFacil.Checked == true) //Descobrindo qual a dificuldade(Fácil é o padrão selecionado)
            {
                Som(6);
                Thread.Sleep(500);
                cores = new int[6];
                tempo = 350;
            }
            else if (radioMedio.Checked == true)
            {
                Som(7);
                Thread.Sleep(500);
                cores = new int[8];
                tempo = 270;
            }
            else if (radioDificil.Checked == true)
            {
                Som(8);
                Thread.Sleep(500);
                cores = new int[12];
                tempo = 170;
            }
            else if (radioPesadelo.Checked == true)
            {
                Som(9);
                Thread.Sleep(500);
                cores = new int[16];
                tempo = 100;
            }

            for (int l = 0; l < cores.Length; l++) //Criando a sequência aleatorias das cores
            {
                cores[l] = ran.Next(0, 4);
            }

            ControleRadios(false); //Desabilitando os RadioButtons
            timer1.Interval = tempo;
            timer1.Start(); //Inicia o temporizador
            AtivarCores();
        }   

        private void verificaResposta(int novaCor) //Verificar se as respostas estão corretas e continua o jogo
        {
            if (novaCor == cores[qntAtual] && qntAtual < qntOld) //Se tiver mais cores pra pisca
            {
                qntAtual++;
            }
            else if (novaCor == cores[qntAtual] && qntAtual >= qntOld) //Aqui verifica se o jogador acertou todas
            {
                if (radioFacil.Checked == true && (qntAtual + 1) == 6) //Fácil
                {
                    Som(4);
                    MessageBox.Show("Parabéns! Você venceu o nível fácil!");
                    qntOld = 0;
                    qntAtual = 0;
                    DesativarCores();
                    ControleRadios(true);
                }
                else if (radioMedio.Checked == true && (qntAtual + 1) == 8) //Médio
                {
                    Som(4);
                    MessageBox.Show("Parabéns! Você venceu o nível Médio!");
                    qntOld = 0;
                    qntAtual = 0;
                    DesativarCores();
                    ControleRadios(true);
                }
                else if (radioDificil.Checked == true && (qntAtual + 1) == 12) //Difícil
                {
                    Som(4);
                    MessageBox.Show("Parabéns! Você venceu o nível Difícil!");
                    qntOld = 0;
                    qntAtual = 0;
                    DesativarCores();
                    ControleRadios(true);
                }
                else if (radioPesadelo.Checked == true && (qntAtual + 1) == 16) //Rádio
                {
                    Som(4);
                    MessageBox.Show("Parabéns! Você venceu o nível Pesadelo!");
                    qntOld = 0;
                    qntAtual = 0;
                    DesativarCores();
                    ControleRadios(true);
                }
                else
                {
                    qntOld++;
                    qntAtual = 0;
                    timer1.Start();
                }
            }
            else if (novaCor != cores[qntAtual]) //Se o Jogador errar, acaba jogo
            {
                Som(5);
                MessageBox.Show("Game Over! Você acertou " + qntOld.ToString() + " de " + cores.Length ,
                    "Fim de jogo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                qntOld = 0;
                qntAtual = 0;
                DesativarCores();
                ControleRadios(true);
            }

            pontos.Text = "Sua pontuação é: " + qntOld + " de " + (cores.Length - 1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DesativarCores(); //Desativar o click das cores
            corPadrao(); //Voltar a cor padrão
            Application.DoEvents(); Thread.Sleep(tempo/2);
            //Se a quantidade atual for maior que a antiga ele para, pro jogador inserir a resposta
            if (qntAtual > qntOld) 
            {
                AtivarCores();
                qntAtual = 0;
                timer1.Stop();
            } 
            else //Caso contrário continua piscando
            {
                //Aqui vai piscar as cores que foram sorteada
                switch (cores[qntAtual])
                {
                    case 0: //Azul
                        {                         
                            pbAzul.Image = Properties.Resources.azul_aceso;
                            Som(0);
                            break;
                        }
                    case 1: //Amarelo
                        {
                            pbAmarelo.Image = Properties.Resources.amarelo_aceso;
                            Som(1); 
                            break;
                        }
                    case 2://Verde
                        {
                            pbVerde.Image = Properties.Resources.verde_aceso;                            
                            Som(2);
                            break;
                        }
                    case 3://Vermelho
                        {
                            pbVermelho.Image = Properties.Resources.vermelho_aceso;
                            Som(3);
                            break;
                        }
                }
                qntAtual++; 
            }
        }

        private void Som(int cor) //Realizar um som para cada ação
        {
            if (cor == 0) //Azul
            {
                SoundPlayer player = new SoundPlayer(Resources.Gravação);
                player.Load();
                player.Play();
            }else if(cor == 1) //Amarelo
            {
                SoundPlayer player = new SoundPlayer(Resources.Gravação1);
                player.Load();
                player.Play();
            }
            else if (cor == 2) //Verde
            {
                SoundPlayer player = new SoundPlayer(Resources.Gravação2);
                player.Load();
                player.Play();
            }
            else if (cor == 3) //Vermelho
            {
                SoundPlayer player = new SoundPlayer(Resources.Gravação3);
                player.Load();
                player.Play();
            }
            else if(cor == 4) //Para vitoria
            {
                SoundPlayer player = new SoundPlayer(Resources.GravaçãoGanhou);
                player.Load();
                player.Play();
            }
            else if(cor == 5) //Para derrota
            {
                SoundPlayer player = new SoundPlayer(Resources.GravaçãoPerdeu);
                player.Load();
                player.Play();
            }
            else if (cor == 6) //Para Fácil
            {
                SoundPlayer player = new SoundPlayer(Resources.GravaçãoFacil);
                player.Load();
                player.Play();
            }
            else if (cor == 7) //Para Medio
            {
                SoundPlayer player = new SoundPlayer(Resources.GravaçãoMedio);
                player.Load();
                player.Play();
            }
            else if (cor == 8) //Para Dificil
            {
                SoundPlayer player = new SoundPlayer(Resources.GravaçãoDificil);
                player.Load();
                player.Play();
            }
            else if (cor == 9) //Para Pesadelo
            {
                SoundPlayer player = new SoundPlayer(Resources.GravaçãoPesadelo);
                player.Load();
                player.Play();
            }
        }

        /*********Mouse_Down\Up(Para piscar quando clicar)************/
        private void pbAmarelo_MouseDown(object sender, MouseEventArgs e)
        {
            pbAmarelo.Image = Resources.amarelo_aceso;
            Som(1);
        }

        private void pbAmarelo_MouseUp(object sender, MouseEventArgs e)
        {
            pbAmarelo.Image = Resources.amarelo;
            verificaResposta(1);
        }

        private void pbAzul_MouseDown(object sender, MouseEventArgs e)
        {
            pbAzul.Image = Resources.azul_aceso;
            Som(0);
        }

        private void pbAzul_MouseUp(object sender, MouseEventArgs e)
        {
            pbAzul.Image = Resources.azul;
            verificaResposta(0);
        }

        private void pbVerde_MouseDown(object sender, MouseEventArgs e)
        {
            pbVerde.Image = Resources.verde_aceso; 
            Som(2);
        }

        private void pbVerde_MouseUp(object sender, MouseEventArgs e)
        {
            pbVerde.Image = Resources.verde;
            verificaResposta(2);
        }

        private void pbVermelho_MouseDown(object sender, MouseEventArgs e)
        {
            pbVermelho.Image = Resources.vermelho_aceso;
            Som(3);
        }

        private void pbVermelho_MouseUp(object sender, MouseEventArgs e)
        {
            pbVermelho.Image = Resources.vermelho;
            verificaResposta(3);
        }
    }
}

