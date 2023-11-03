using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DicePoker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // definição das variaveis a usar na aplicação
        //controla o tempo de duração da rolagem de dados
        private const int cRolarTempo = 5;
        
        //armazena a mensagem da barra de titulo
        private const string cTituloBarra = "Dice Poker";

        //controlar a exibição de controlos checkBox
        private bool cListaDados = false;

        //total de creditos na conta do jogador
        private int creditos = 20;

        //armazena o numero de jogadas de dados
        private int nrJogadas;

        private int contador;   //variavel contador
        private int dado1;      //dado com a face 1
        private int dado2;      //dado com a face 2
        private int dado3;      //dado com a face 3
        private int dado4;      //dado com a face 4
        private int dado5;      //dado com a face 5
        private int dado6;      //dado com a face 6

        private void Form1_Load(object sender, EventArgs e)
        {
            //mostrar a imagem branco nas picturebox dos dados
            pbDado1.Image = imgDados.Images[0];
            pbDado2.Image = imgDados.Images[0];
            pbDado3.Image = imgDados.Images[0];
            pbDado4.Image = imgDados.Images[0];
            pbDado5.Image = imgDados.Images[0];

            //mostrar uma saudação e total de créditos ao jogador
            txtOutput.Text = "Bem vindo!\nEstá pronto para jogar?" + "\nTem " + creditos.ToString() + "créditos.";
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRolar_Click(object sender, EventArgs e)
        {
            //verificar se os dados foram lançados duas vezes
            if (nrJogadas == 2)
            {
                //alterar o texto a mostrar no botão
                btnRolar.Text = "Rolar os dados";
                //colocar 0 para preparar novo jogo
                nrJogadas = 0;
            }

            /*se o primeiro lançamento foi feito deve-se alternar a exibicao das checkbox e acompanhar o numero de rolagens*/
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
        }

        private void RolarOsDados (int x)
        {
            /*armazena os numeros gerados aleatoriamente que representam o valor da face de um dado*/
            int rolar;

            /*variaveis para controlar os dados que o jogador escolheu para manter na sua primeira rolagem*/
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
            //certificar que vai ser gerado um numero aleatorio
            Random r = new Random();
            rolar = r.Next(1, 6);

            //testar valor geradopara determinar face do dado
            switch (rolar)
            {
                case 1:
                    if(saltaCase1 == false) 
                    {
                        //jogador otpou por nao guardar
                        if (x == 1) pbDado1.Image = imgDados.Images[1];
                        if (x == 2) pbDado1.Image = imgDados.Images[2];
                        if (x == 3) pbDado1.Image = imgDados.Images[3];
                        if (x == 4) pbDado1.Image = imgDados.Images[4];
                        if (x == 5) pbDado1.Image = imgDados.Images[5];
                        if (x == 6) pbDado1.Image = imgDados.Images[6];
                    }
                    break;

                case 2:
                    if (saltaCase2 == false)
                    {
                        //jogador otpou por nao guardar
                        if (x == 1) pbDado1.Image = imgDados.Images[1];
                        if (x == 2) pbDado1.Image = imgDados.Images[2];
                        if (x == 3) pbDado1.Image = imgDados.Images[3];
                        if (x == 4) pbDado1.Image = imgDados.Images[4];
                        if (x == 5) pbDado1.Image = imgDados.Images[5];
                        if (x == 6) pbDado1.Image = imgDados.Images[6];
                    }
                    break;
                
                case 3:
                    if (saltaCase3 == false)
                    {
                        //jogador otpou por nao guardar
                        if (x == 1) pbDado1.Image = imgDados.Images[1];
                        if (x == 2) pbDado1.Image = imgDados.Images[2];
                        if (x == 3) pbDado1.Image = imgDados.Images[3];
                        if (x == 4) pbDado1.Image = imgDados.Images[4];
                        if (x == 5) pbDado1.Image = imgDados.Images[5];
                        if (x == 6) pbDado1.Image = imgDados.Images[6];
                    }
                    break;

                case 4:
                    if (saltaCase4 == false)
                    {
                        //jogador otpou por nao guardar
                        if (x == 1) pbDado1.Image = imgDados.Images[1];
                        if (x == 2) pbDado1.Image = imgDados.Images[2];
                        if (x == 3) pbDado1.Image = imgDados.Images[3];
                        if (x == 4) pbDado1.Image = imgDados.Images[4];
                        if (x == 5) pbDado1.Image = imgDados.Images[5];
                        if (x == 6) pbDado1.Image = imgDados.Images[6];
                    }
                    break;
                
                case 5:
                    if (saltaCase5 == false)
                    {
                        //jogador otpou por nao guardar
                        if (x == 1) pbDado1.Image = imgDados.Images[1];
                        if (x == 2) pbDado1.Image = imgDados.Images[2];
                        if (x == 3) pbDado1.Image = imgDados.Images[3];
                        if (x == 4) pbDado1.Image = imgDados.Images[4];
                        if (x == 5) pbDado1.Image = imgDados.Images[5];
                        if (x == 6) pbDado1.Image = imgDados.Images[6];
                    }
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //variavel para controlar o loop
            int i;

            //chamar o procedimento RolarOsDados em cada iteração
            for (i = 0; i < 6;  i++)
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
            }
        }
    }
}
