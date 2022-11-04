using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DicePoker2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();
        
        /* definição das variáveis a usar na aplicação */
        // controla o tempo de duração da rolagem de dados
        private const int cRolarTempo = 5;

        // armazena a mensagem da barra de título
        private const string cTituloBarra = "Dice Poker";

        // controlar a exibição de controlos checkbox
        private bool cListaDados = false;

        // total de créditos na conta do jogador
        private int creditos = 20;

        // armazena o número de jogadas de dados
        private int nrJogadas;
        private int contar = 0;

        private int contador;   //variável contador
        private int dado1;      //dado com a face 1
        private int dado2;      //dado com a face 2
        private int dado3;      //dado com a face 3
        private int dado4;      //dado com a face 4
        private int dado5;      //dado com a face 5

        // private int dado6;      //dado com a face 6

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 255, 0);

            //mostrar a imagem branco nas picturebox dos dados
            pbDado1.Image = imgDados.Images[0];
            pbDado2.Image = imgDados.Images[0];
            pbDado3.Image = imgDados.Images[0];
            pbDado4.Image = imgDados.Images[0];
            pbDado5.Image = imgDados.Images[0];

            //mostrar uma saudação e total de créditos ao jogador
            label1.Text = "Bem vindo! Está pronto para jogar?";
            txtOutput.Text = "Creditos: " + creditos.ToString();
        }

        private void btnRolar_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 0, 0);
            label1.Text = "";

            contar++;
            

            //verificar se os dados foram lançados duas vezes
            if (nrJogadas == 2)
            {
               
                //alterar o texto a mostrar no botão
                btnRolar.Text = "Rolar os dados";
                //colocar 0 para preparar novo jogo
                nrJogadas = 0;
            }  
            else
            {
                creditos -=1;
            }

          

            if (contar == 2)
            {
                creditos += 1;
            }
            if (contar == 3)
            {
                creditos -= 1;
                nrJogadas += 1;
            }

            txtOutput.Text = "Creditos: " + creditos.ToString();
            //se o primeiro lançamento foi feito deve-se alternar a
            //exibição das checkbox e acompanhar o numero de rolagens
            if (btnRolar.Text == "Rolar os dados")
            {
                cListaDados = false;
                nrJogadas += 1;
            }
            else
            {
                cListaDados = true;
                nrJogadas += 1;
            }

            //iniciar o controlo Timer
            timer1.Enabled = true;

            if (creditos == 0)
            {
                
                FimDoJogo();
                AtualizarConta();
            }

        }

    private void RolarOsDados (int x)
        {
            //armazena os números gerados aleatoriamente
            //que representam o valor da face de um dado
            int rolar;

            //variáveis para controlar os dados que o jogador
            //escolheu para manter na sua primeira rolagem
            bool saltaCase1 = false;
            bool saltaCase2 = false;
            bool saltaCase3 = false;
            bool saltaCase4 = false;
            bool saltaCase5 = false;

            if (cListaDados)
            {
                //assinalar o dado a manter pelo jogador
                if (chkDado1.Checked==true) saltaCase1=true;
                if (chkDado2.Checked==true) saltaCase2=true;
                if (chkDado3.Checked==true) saltaCase3=true;
                if (chkDado4.Checked==true) saltaCase4=true;
                if (chkDado5.Checked==true) saltaCase5=true;
            }

            //certificar que vai ser gerado um número aleatório0
            //Random r = new Random();
            //rolar = r.Next(1, 6);

            rolar = r.Next(1, 6);

            //testar valor gerado para determinar face do dado
            switch (rolar)
            {
                case 1:
                    if (saltaCase1 == false)
                    {
                        if (x == 1) pbDado1.Image = imgDados.Images[1];
                        if (x == 2) pbDado1.Image = imgDados.Images[2];
                        if (x == 3) pbDado1.Image = imgDados.Images[3];  
                        if (x == 4) pbDado1.Image = imgDados.Images[4];
                        if (x == 5) pbDado1.Image = imgDados.Images[5];
                        if (x == 6) pbDado1.Image = imgDados.Images[6];
                        dado1 = x;
                    }
                    break;

                case 2:
                    if (saltaCase2 == false)
                    {
                        //jogador optou por nao guardar
                        if (x == 1) pbDado2.Image = imgDados.Images[1];
                        if (x == 2) pbDado2.Image = imgDados.Images[2];
                        if (x == 3) pbDado2.Image = imgDados.Images[3];
                        if (x == 4) pbDado2.Image = imgDados.Images[4];
                        if (x == 5) pbDado2.Image = imgDados.Images[5];
                        if (x == 6) pbDado2.Image = imgDados.Images[6];
                        dado2 = x;
                    }
                    break;

                case 3:
                    if (saltaCase3 == false)
                    {
                        //jogador optou por nao guardar
                        if (x == 1) pbDado3.Image = imgDados.Images[1];
                        if (x == 2) pbDado3.Image = imgDados.Images[2];
                        if (x == 3) pbDado3.Image = imgDados.Images[3];
                        if (x == 4) pbDado3.Image = imgDados.Images[4];
                        if (x == 5) pbDado3.Image = imgDados.Images[5];
                        if (x == 6) pbDado3.Image = imgDados.Images[6];
                        dado3 = x;
                    }
                    break;

                case 4:
                    if (saltaCase4 == false)
                    {
                        //jogador optou por nao guardar
                        if (x == 1) pbDado4.Image = imgDados.Images[1];
                        if (x == 2) pbDado4.Image = imgDados.Images[2];
                        if (x == 3) pbDado4.Image = imgDados.Images[3];
                        if (x == 4) pbDado4.Image = imgDados.Images[4];
                        if (x == 5) pbDado4.Image = imgDados.Images[5];
                        if (x == 6) pbDado4.Image = imgDados.Images[6];
                        dado4 = x;
                    }
                    break;

                case 5:
                    if (saltaCase5 == false)
                    {
                        //jogador optou por nao guardar
                        if (x == 1) pbDado5.Image = imgDados.Images[1];
                        if (x == 2) pbDado5.Image = imgDados.Images[2];
                        if (x == 3) pbDado5.Image = imgDados.Images[3];
                        if (x == 4) pbDado5.Image = imgDados.Images[4];
                        if (x == 5) pbDado5.Image = imgDados.Images[5];
                        if (x == 6) pbDado5.Image = imgDados.Images[6];
                        dado5 = x;
                    }
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //variável para controlar o loop
            int i;

            //chamar o procedimento RolarOsDados em cada iteração
            for (i = 1; i < 7; i++)
            {
                RolarOsDados(i);
            }

            //incrementa o contador de jogadas
            contador += 1;

            //desativa o temporizador e exibir os checkbox no final da rolagem
            if (contador > cRolarTempo)
            {
                contador = 0;
                timer1.Enabled = false;

                if (nrJogadas==1)
                {
                    
                    this.BackColor = Color.FromArgb(0, 255, 0);
                    //alterar o texto do botão
                    btnRolar.Text = "Rolar outra vez os Dados";

                    //exibir o checkbox de cada dado
                    chkDado1.Visible = true;
                    chkDado2.Visible = true;
                    chkDado3.Visible = true;
                    chkDado4.Visible = true;
                    chkDado5.Visible = true;
                    chkDados.Visible = true;
                }

                if (nrJogadas == 2)
                {
                    this.BackColor = Color.FromArgb(0, 255, 0);
                    //preparar para uma nova jogada
                    btnRolar.Text = "Rolar os Dados";
                    LimparCheckbox();

                    //verificar o resultado da jogada
                    VerificarResultadoJogada();

                }
            }
        }

        private void LimparCheckbox()
        {
            //ocultar e desativar as checkboxes
            chkDado1.Visible = false;
            chkDado1.Checked = false;
            chkDado2.Visible = false;
            chkDado2.Checked = false;
            chkDado3.Visible = false;
            chkDado3.Checked = false;
            chkDado4.Visible = false;
            chkDado4.Checked = false;
            chkDado5.Visible = false;
            chkDado5.Checked = false;

            chkDados.Visible = false;
            chkDados.Checked = false;
        }

        private void VerificarResultadoJogada()
        {
            //array para manter a contagem do número em cada mão
            //int[] dadosArray = new int[6];

            //variável para controlar a execução do loop
            int i = 1;

            int[] DadosNum = new int[6];

            //iterar seis vezes para manter a contagem do total
            //de 1s, 2s, 3s, 4s, 5s e 6s que foram rolados
            for (i=1; i<7; i++)
            {
                if (dado1 == i) DadosNum[i-1] += 1;
                if (dado2 == i) DadosNum[i-1] += 1;
                if (dado3 == i) DadosNum[i-1] += 1;
                if (dado4 == i) DadosNum[i-1] += 1;
                if (dado5 == i) DadosNum[i-1] += 1;
            }

            //iterar seis vezes para contar as mãos vencedoras
            for (i = 1; i < 7; i++)
            {

                //ver se o jogador tem 5 do mesmo tipo
                if (DadosNum[i - 1] == 5)
                {
                    creditos += 4;
                    label1.Text = "GANHOU! 5 of a kind.\nGanhou 4 créditos.";
                    txtOutput.Text = "Creditos: " + creditos.ToString();
                }

                //ver se o jogador tem 4 do mesmo tipo
                if (DadosNum[i - 1] == 4)
                {
                    creditos += 3;
                    label1.Text = "GANHOU! 4 of a kind.\nGanhou 3 créditos.";
                    txtOutput.Text = "Creditos: " + creditos.ToString();
                }

                //ver se o jogador tem 3 do mesmo tipo ou Full House (3 + 2)
                if (DadosNum[i - 1] == 3)
                {
                    //tem 3 do mesmo tipo
                    bool fullHouse = false;

                    //verificar se tem 2 do mesmo tipo
                    if (DadosNum[i - 1] == 2)
                    {
                        fullHouse = true;
                        creditos += 2;
                        label1.Text = "GANHOU! Full House.\nGanhou 2 créditos.";
                        txtOutput.Text = "Creditos: " + creditos.ToString();
                        return;
                    }
                    if (fullHouse == false)
                    {
                        creditos += 1;
                        label1.Text = "GANHOU! 3 of a kind.\nGanhou 1 crédito.";
                        txtOutput.Text = "Creditos: " + creditos.ToString();
                        return;
                    }
                }
            }
                //iterar os dados 2 a 6 à procura de um High Straiht
                //cada uma das posições só pode conter o valor 1
                for (i=2; i<7; i++)
                {
                    if (DadosNum[i-1] != 1) return;
                    else
                    {
                        //quando terminar
                        if (i == 6)
                        {
                            creditos += 3;
                            label1.Text = "GANHOU! Hight Straigh.\nGanhou 3 créditos.";
                            txtOutput.Text = "Creditos: " + creditos.ToString();
                            return;
                        }
                    }
                }

                //iterar os dados 1 a 5 à procura de um Low Straight
                //cada uma das posições só pode conter o valor 1
                for (i = 1; i < 5; i++)
                {
                    if (DadosNum[i-1] != 1) return;
                    else
                    {
                        //quando terminar
                        if (i == 5)
                        {
                            creditos += 3;
                            label1.Text = "GANHOU! Low Straigh.\nGanhou 3 créditos.";
                            txtOutput.Text = "Creditos: " + creditos.ToString();
                            return;
                        }
                    }
                }

                //atualizar o preço da jogada
                creditos -= 2;
                label1.Text = "SORRY! Perdeu esta mão e 2 créditos.";
                txtOutput.Text = "Creditos: " + creditos.ToString();
           
        }

        private void AtualizarConta()
        {
            txtOutput.Text = "Créditos." + creditos.ToString();
        }

        private void FimDoJogo()
        {
            
            //variável para resposta ao jogador
            DialogResult resposta = new DialogResult();
            
            //limpar as mensagens de estado do jogo
            txtOutput.Text = "";

            //prompt alerta para avisar o jogador
            string mensagem = "Não tem créditos.\nGostaria de jogar outra vez?";

            resposta = MessageBox.Show(mensagem, "Aviso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //se o jogador clica em Sim deve-se criar um novo jogo
            if (resposta == DialogResult.Yes)
            {
                //redefinir a conta do jogador
                creditos = 20;

                //mostrar a imagem branco nas picture box
                pbDado1.Image = imgDados.Images[0];
                pbDado2.Image = imgDados.Images[0];
                pbDado3.Image = imgDados.Images[0];
                pbDado4.Image = imgDados.Images[0];
                pbDado5.Image = imgDados.Images[0];
            }
            else
            {
                //o jogador não quer jogar mais
                Application.Exit();
            }
        }

        private void chkDados_CheckedChanged(object sender, EventArgs e)
        {
            //se o jogador seleciona Manter tudo
            if (chkDados.Checked == true)
            {
                chkDado1.Checked = true;
                chkDado2.Checked = true;
                chkDado3.Checked = true;
                chkDado4.Checked = true;
                chkDado5.Checked = true;
                btnRolar.Text = "Manter tudo";
            }
            else
            {
                chkDado1.Checked = false;
                chkDado2.Checked = false;
                chkDado3.Checked = false;
                chkDado4.Checked = false;
                chkDado5.Checked = false;
                btnRolar.Text = "Rolar os Dados";
            }
        }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbDado1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
