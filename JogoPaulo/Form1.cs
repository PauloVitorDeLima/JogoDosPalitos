using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoPaulo
{
    public partial class FormGame : Form
    {
        //Cria variavel publica e estatica para poder mexer em locais diferentes
        public static int Quantia, RetiradaPlayer, RetiradaPC = 0;

        public FormGame()
        {
            InitializeComponent();
        }

        private void BtJogar_Click(object sender, EventArgs e)
        {
            //Deixa o botao, label e a MaskTextBox visivel
            BtRetirar.Visible = true;
            LbRetirar.Visible = true;
            MskTxtBxPalitos.Visible = true;
            //Deixa o Botao e a NumericUpDown inativo
            BtJogar.Enabled = false;
            NumericQuantidade.Enabled = false;


            // Quantia recebe o valor da NumericUpDown
            Quantia = (int)NumericQuantidade.Value;
            //Escreve na RichTextBox
            RTextBoxDisplay.AppendText("Eu começo!!");
            //Pula linha na RichTexBox
            RTextBoxDisplay.AppendText(Environment.NewLine);
            //Verifica se a quantia de inicio do jogo é 30, 26 ou 22
            if (Quantia == 30 || Quantia == 26 || Quantia == 22)
            {
                //se for adiciona o valor que o PC irá retirar (1)
                RetiradaPC =  1;
            }

            //Verifica se a quantia de inicio do jogo é 23 ou 27
            if (Quantia == 23 || Quantia == 27)
            {
                //se for adiciona o valor que o PC irá retirar (2)
                RetiradaPC =  2;
            }
            //Verifica se a quantia de inicio do jogo é 20, 21, 24, 25, 28 ou 29
            if (Quantia == 20 || Quantia == 21 || Quantia == 24 || Quantia == 25 || Quantia == 28 || Quantia == 29)
            {
                //se for adiciona o valor que o PC irá retirar (3)
                RetiradaPC = 3;
            }
            //Mostra quantos palitos o PC retirou
            RTextBoxDisplay.AppendText("Retiro " + RetiradaPC + " Palitos");
            RTextBoxDisplay.AppendText(Environment.NewLine);
            //Informa que é a vez do PLayer
            RTextBoxDisplay.AppendText("Sua Vez");
            RTextBoxDisplay.AppendText(Environment.NewLine);
            //Calcula quantos palitos ainda restam
            Quantia -= RetiradaPC;
            //Mostra quantos palitos restam em jogo
            RTextBoxDisplay.AppendText("Restam " + Quantia + " palitos");
            RTextBoxDisplay.AppendText(Environment.NewLine);
        }

        private void BtRetirar_Click(object sender, EventArgs e)
        {
            //Verifica se o valor está vazio ou nulo
            if (String.IsNullOrEmpty(MskTxtBxPalitos.Text))
            {
                //MessageBox para informar que o valor está vazio ou nulo
                MessageBox.Show("É necessário inserir um valor para jogar", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                //Adiciona o valor da MaskTextBox a variavel RetiradaPlayer 
                RetiradaPlayer = int.Parse(MskTxtBxPalitos.Text);
                //Verifica se o Player escolheu 1
                if (RetiradaPlayer == 1)
                {
                    //Se o Player escolheu 1 o Computador joga 3
                    RetiradaPC = 3;
                    //Informa que tirou 1 palito
                    RTextBoxDisplay.AppendText("Você tirou " + RetiradaPlayer + " Palito");
                    RTextBoxDisplay.AppendText(Environment.NewLine);
                    //Calcula quantos palitos ainda restam
                    Quantia -= RetiradaPlayer;
                    //Se a quantia for igual ou menor que zero significa que o Computador Ganhou
                    if (Quantia <= 0)
                    {
                        //MessageBox informando que o player perdeu
                        MessageBox.Show("Você Perdeu... Rs Rs :)", "KKKKJ Muito fácil!!!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //Limpa o MaskTextBox e o RichTextBox
                        MskTxtBxPalitos.Clear();
                        RTextBoxDisplay.Clear();
                        //Abre outro MessageBox perguntando se deseja jogar novamente
                        if (DialogResult.No == MessageBox.Show("Deseja Jogar novamente?",
                            "DESAFIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            //se a resposta for nao, fecha a application
                            Application.Exit();
                        }
                        else
                        {
                            //se a resposta for Sim faz voltar desde o inicio, ou seja
                            //deixa o botao, Label e MaskTextBox invisivel.
                            BtRetirar.Visible = false;
                            LbRetirar.Visible = false;
                            MskTxtBxPalitos.Visible = false;
                            //Ativa o botao e o NumericUpDown
                            BtJogar.Enabled = true;
                            NumericQuantidade.Enabled = true;
                        }
                    }
                    //Se a quantia for maior que 0 o jogo continua
                    if(Quantia > 0)
                    { 
                        //Informa quantos palitos restam
                        RTextBoxDisplay.AppendText("Restam  "+ Quantia + " Palitos");
                        RTextBoxDisplay.AppendText(Environment.NewLine);
                        //Computador retira 3 Palitos
                        RTextBoxDisplay.AppendText("Retiro " + RetiradaPC + " Palitos");
                        RTextBoxDisplay.AppendText(Environment.NewLine);
                        //Calcula quantos palitos ainda restam
                        Quantia -= RetiradaPC;
                        //Se a quantia for igual ou menor que zero significa que o Player Ganhou
                        if (Quantia <= 0)
                        {
                            //MessageBox informando que o Computador perdeu
                            MessageBox.Show("COMO ISSO É POSSÍVEL?????", "Perdi!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            MskTxtBxPalitos.Clear();
                            RTextBoxDisplay.Clear();
                            //Abre outro MessageBox perguntando se deseja jogar novamente
                            if (DialogResult.No == MessageBox.Show("Deseja Jogar novamente?",
                                "DESAFIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                            {
                                //se a resposta for nao, fecha a application
                                Application.Exit();
                            }
                            else
                            {
                                //se a resposta for Sim faz voltar desde o inicio, ou seja
                                //deixa o botao, Label e MaskTextBox invisivel.
                                BtRetirar.Visible = false;
                                LbRetirar.Visible = false;
                                MskTxtBxPalitos.Visible = false;
                                //Ativa o botao e o NumericUpDown
                                BtJogar.Enabled = true;
                                NumericQuantidade.Enabled = true;
                            }
                        }
                        //Se a quantia for maior que 0 o jogo continua
                        if (Quantia > 0)
                        {
                            //Informa que é a vez do PLayer
                            RTextBoxDisplay.AppendText("Sua Vez");
                            RTextBoxDisplay.AppendText(Environment.NewLine);
                            //informa quantos palitos restam
                            RTextBoxDisplay.AppendText("Restam " + Quantia + " Palitos");
                            RTextBoxDisplay.AppendText(Environment.NewLine);
                            //Limpa MaskTextBox
                            MskTxtBxPalitos.Clear();
                        }   
                    }
                }

                if (RetiradaPlayer == 2)
                {
                    //Se o Player escolheu 1 o Computador joga 2
                    RetiradaPC = 2;
                    //Informa que tirou 2 palito
                    RTextBoxDisplay.AppendText("Você tirou " + RetiradaPlayer + " Palitos");
                    RTextBoxDisplay.AppendText(Environment.NewLine);
                    //Calcula quantos palitos ainda restam
                    Quantia -= RetiradaPlayer;
                    //Se a quantia for igual ou menor que zero significa que o Computador Ganhou
                    if (Quantia <= 0)
                    {
                        //MessageBox informando que o player perdeu
                        MessageBox.Show("Você Perdeu... Rs Rs :)", "KKKKJ Muito fácil!!!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        MskTxtBxPalitos.Clear();
                        RTextBoxDisplay.Clear();
                        //Abre outro MessageBox perguntando se deseja jogar novamente
                        if (DialogResult.No == MessageBox.Show("Deseja Jogar novamente?",
                            "DESAFIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            //se a resposta for nao, fecha a application
                            Application.Exit();
                        }
                        else
                        {
                            //se a resposta for Sim faz voltar desde o inicio, ou seja
                            //deixa o botao, Label e MaskTextBox invisivel.
                            BtRetirar.Visible = false;
                            LbRetirar.Visible = false;
                            MskTxtBxPalitos.Visible = false;
                            //Ativa o botao e o NumericUpDown
                            BtJogar.Enabled = true;
                            NumericQuantidade.Enabled = true;
                        }
                    }
                    //Se a quantia for maior que 0 o jogo continua
                    if (Quantia > 0)
                    {
                        //informa quantos palitos restam
                        RTextBoxDisplay.AppendText("Restam " + Quantia + " Palitos");
                        RTextBoxDisplay.AppendText(Environment.NewLine);
                        //Computador retira 2 Palitos
                        RTextBoxDisplay.AppendText("Retiro " + RetiradaPC + " Palitos");
                         RTextBoxDisplay.AppendText(Environment.NewLine);
                        //Calcula quantos palitos ainda restam
                        Quantia -= RetiradaPC;
                        //Se a quantia for igual ou menor que zero significa que o Player Ganhou
                        if (Quantia <= 0)
                        {
                            //MessageBox informando que o Computador perdeu
                            MessageBox.Show("COMO ISSO É POSSÍVEL?????", "Perdi!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            MskTxtBxPalitos.Clear();
                            RTextBoxDisplay.Clear();
                            //Abre outro MessageBox perguntando se deseja jogar novamente
                            if (DialogResult.No == MessageBox.Show("Deseja Jogar novamente?",
                                "DESAFIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                            {
                                //se a resposta for nao, fecha a application
                                Application.Exit();
                            }
                            else
                            {
                                //se a resposta for Sim faz voltar desde o inicio, ou seja
                                //deixa o botao, Label e MaskTextBox invisivel.
                                BtRetirar.Visible = false;
                                LbRetirar.Visible = false;
                                MskTxtBxPalitos.Visible = false;
                                //Ativa o botao e o NumericUpDown
                                BtJogar.Enabled = true;
                                NumericQuantidade.Enabled = true;
                            }
                        }   
                        //Se a quantia for maior que 0 o jogo continua
                        if (Quantia > 0)
                        {
                            //Informa que é a vez do PLayer
                            RTextBoxDisplay.AppendText("Sua Vez");
                            RTextBoxDisplay.AppendText(Environment.NewLine);
                            //informa quantos palitos restam
                            RTextBoxDisplay.AppendText("Restam " + Quantia + " Palitos");
                            RTextBoxDisplay.AppendText(Environment.NewLine);
                            //Limpa MaskTextBox
                            MskTxtBxPalitos.Clear();    
                        }
                    }
                }

                if (RetiradaPlayer == 3)
                {
                    //Se o Player escolheu 3 o Computador joga 1
                    RetiradaPC = 1;
                    //Informa que tirou 3 palito
                    RTextBoxDisplay.AppendText("Você tirou " + RetiradaPlayer + " Palitos");
                    RTextBoxDisplay.AppendText(Environment.NewLine);
                    //Calcula quantos palitos ainda restam
                    Quantia -= RetiradaPlayer;
                    //Se a quantia for igual ou menor que zero significa que o Computador Ganhou
                    if (Quantia <= 0)
                    {
                        //MessageBox informando que o Player perdeu
                        MessageBox.Show("Você Perdeu... Rs Rs :)", "KKKKJ Muito fácil!!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        MskTxtBxPalitos.Clear();
                        RTextBoxDisplay.Clear();
                        //Abre outro MessageBox perguntando se deseja jogar novamente
                        if (DialogResult.No == MessageBox.Show("Deseja Jogar novamente?",
                        "DESAFIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            //se a resposta for nao, fecha a application
                            Application.Exit();
                        }
                        else
                        {
                            //se a resposta for Sim faz voltar desde o inicio, ou seja
                            //deixa o botao, Label e MaskTextBox invisivel.
                            BtRetirar.Visible = false;
                            LbRetirar.Visible = false;
                            MskTxtBxPalitos.Visible = false;
                            //Ativa o botao e o NumericUpDown
                            BtJogar.Enabled = true;
                            NumericQuantidade.Enabled = true;
                        }
                    }
                    //Se a quantia for maior que 0 o jogo continua
                    if (Quantia > 0)
                    {
                        //informa quantos palitos restam
                        RTextBoxDisplay.AppendText("Restam " + Quantia + " Palitos");
                        RTextBoxDisplay.AppendText(Environment.NewLine);
                        //Computador retira 1 Palitos
                        RTextBoxDisplay.AppendText("Retiro " + RetiradaPC + " Palito");
                        RTextBoxDisplay.AppendText(Environment.NewLine);
                        //Calcula quantos palitos ainda restam
                        Quantia -= RetiradaPC;
                        if (Quantia <= 0)
                        {
                            //MessageBox informando que o Computador perdeu
                            MessageBox.Show("COMO ISSO É POSSÍVEL?????", "Perdi!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            MskTxtBxPalitos.Clear();
                            RTextBoxDisplay.Clear();
                            //Abre outro MessageBox perguntando se deseja jogar novamente
                            if (DialogResult.No == MessageBox.Show("Deseja Jogar novamente?",
                                "DESAFIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                            {
                                ////se a resposta for nao, fecha a application
                                Application.Exit();
                            }
                            else
                            {
                                //se a resposta for Sim faz voltar desde o inicio, ou seja
                                //deixa o botao, Label e MaskTextBox invisivel.
                                BtRetirar.Visible = false;
                                LbRetirar.Visible = false;
                                MskTxtBxPalitos.Visible = false;
                                //Ativa o botao e o NumericUpDown
                                BtJogar.Enabled = true;
                                NumericQuantidade.Enabled = true;
                            }
                        }
                        //Se a quantia for maior que 0 o jogo continua
                        if (Quantia > 0)
                        {
                            //Informa que é a vez do PLayer
                            RTextBoxDisplay.AppendText("Sua Vez");
                            RTextBoxDisplay.AppendText(Environment.NewLine);
                            //informa quantos palitos restam
                            RTextBoxDisplay.AppendText("Restam " + Quantia + " Palitos");
                            RTextBoxDisplay.AppendText(Environment.NewLine);
                            //Limpa MaskTextBox
                            MskTxtBxPalitos.Clear();
                        }
                    }
                }
                //Caso tire valor diferente de 1, 2 ou 3
                else if(RetiradaPlayer != 1 && RetiradaPlayer != 2 && RetiradaPlayer != 3)
                {
                    //Abre MessageBox informando que não é possível concluir essa ação
                    MessageBox.Show("São permitidos retirar 1 a 3 palitos por jogada", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //limpa MaskTextBox
                    MskTxtBxPalitos.Clear();
                }
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
