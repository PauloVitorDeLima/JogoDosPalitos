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
        public static int Quantia, RetiradaPlayer, RetiradaPC = 0;

        public FormGame()
        {
            InitializeComponent();
        }

        private void BtJogar_Click(object sender, EventArgs e)
        {
            BtRetirar.Visible = true;
            LbRetirar.Visible = true;
            MskTxtBxPalitos.Visible = true;
            BtJogar.Enabled = false;
            NumericQuantidade.Enabled = false;



            Quantia = (int)NumericQuantidade.Value;
            RTextBoxDisplay.AppendText("Eu começo!!");
            RTextBoxDisplay.AppendText(Environment.NewLine);

            if (Quantia == 30 || Quantia == 26 || Quantia == 22)
            {
                RetiradaPC =  1;
            }
            if (Quantia == 23 || Quantia == 27)
            {
                RetiradaPC =  2;
            }
            if (Quantia == 20 || Quantia == 21 || Quantia == 24 || Quantia == 25 || Quantia == 28 || Quantia == 29)
            {
                RetiradaPC = 3;
            }

            RTextBoxDisplay.AppendText("Retiro " + RetiradaPC + " Palitos");
            RTextBoxDisplay.AppendText(Environment.NewLine);
            RTextBoxDisplay.AppendText("Sua Vez");
            RTextBoxDisplay.AppendText(Environment.NewLine);
            Quantia -= RetiradaPC;
            RTextBoxDisplay.AppendText("Restam " + Quantia + " palitos");
            RTextBoxDisplay.AppendText(Environment.NewLine);
        }

        private void BtRetirar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(MskTxtBxPalitos.Text))
            {
                //(String.IsNullOrEmpty(MaskTextBox.Text)
                MessageBox.Show("É necessário inserir um valor para jogar", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                RetiradaPlayer = int.Parse(MskTxtBxPalitos.Text);

                if (RetiradaPlayer == 1)
                {
                    RetiradaPC = 3;
                    RTextBoxDisplay.AppendText("Você tirou " + RetiradaPlayer + " Palitos");
                    RTextBoxDisplay.AppendText(Environment.NewLine);

                    Quantia -= RetiradaPlayer;

                    if (Quantia <= 0)
                    {
                        MessageBox.Show("Você Perdeu... Rs Rs :)", "KKKKJ Muito fácil!!!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        MskTxtBxPalitos.Clear();
                        RTextBoxDisplay.Clear();

                        if (DialogResult.No == MessageBox.Show("Deseja Jogar novamente?",
                            "DESAFIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            Application.Exit();
                        }
                        else
                        {
                            BtRetirar.Visible = false;
                            LbRetirar.Visible = false;
                            MskTxtBxPalitos.Visible = false;
                            BtJogar.Enabled = true;
                            NumericQuantidade.Enabled = true;
                        }
                    }
                    if(Quantia > 0)
                    { 
                        RTextBoxDisplay.AppendText("Restam  "+ Quantia + " Palitos");
                        RTextBoxDisplay.AppendText(Environment.NewLine);
                        RTextBoxDisplay.AppendText("Retiro " + RetiradaPC + " Palitos");
                        RTextBoxDisplay.AppendText(Environment.NewLine);
                        Quantia -= RetiradaPC;
                        if (Quantia <= 0)
                        {
                            MessageBox.Show("COMO ISSO É POSSÍVEL?????", "Perdi!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            MskTxtBxPalitos.Clear();
                            RTextBoxDisplay.Clear();

                            if (DialogResult.No == MessageBox.Show("Deseja Jogar novamente?",
                                "DESAFIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                            {
                                Application.Exit();
                            }
                            else
                            {
                                BtRetirar.Visible = false;
                                LbRetirar.Visible = false;
                                MskTxtBxPalitos.Visible = false;
                                BtJogar.Enabled = true;
                                NumericQuantidade.Enabled = true;
                            }
                        }
                        if (Quantia > 0)
                        { 
                        RTextBoxDisplay.AppendText("Sua Vez");
                        RTextBoxDisplay.AppendText(Environment.NewLine);
                        RTextBoxDisplay.AppendText("Restam " + Quantia + " Palitos");
                        RTextBoxDisplay.AppendText(Environment.NewLine);
                        MskTxtBxPalitos.Clear();
                        }   
                    }
                }
                if (RetiradaPlayer == 2)
                {
                    RetiradaPC = 2;
                
                    RTextBoxDisplay.AppendText("Você tirou " + RetiradaPlayer + " Palitos");
                    RTextBoxDisplay.AppendText(Environment.NewLine);

                    Quantia -= RetiradaPlayer;

                    if (Quantia <= 0)
                    {
                        MessageBox.Show("Você Perdeu... Rs Rs :)", "KKKKJ Muito fácil!!!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        MskTxtBxPalitos.Clear();
                        RTextBoxDisplay.Clear();

                        if (DialogResult.No == MessageBox.Show("Deseja Jogar novamente?",
                            "DESAFIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            Application.Exit();
                        }
                        else
                        {
                            BtRetirar.Visible = false;
                            LbRetirar.Visible = false;
                            MskTxtBxPalitos.Visible = false;
                            BtJogar.Enabled = true;
                            NumericQuantidade.Enabled = true;
                        }
                    }
                    if (Quantia > 0)
                    {
                        RTextBoxDisplay.AppendText("Restam " + Quantia + " Palitos");
                        RTextBoxDisplay.AppendText(Environment.NewLine);
                        RTextBoxDisplay.AppendText("Retiro " + RetiradaPC + " Palitos");
                         RTextBoxDisplay.AppendText(Environment.NewLine);
                    Quantia -= RetiradaPC;
                    if (Quantia <= 0)
                    {

                        MessageBox.Show("COMO ISSO É POSSÍVEL?????", "Perdi!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        MskTxtBxPalitos.Clear();
                        RTextBoxDisplay.Clear();

                        if (DialogResult.No == MessageBox.Show("Deseja Jogar novamente?",
                            "DESAFIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            Application.Exit();
                        }
                        else
                        {
                            BtRetirar.Visible = false;
                            LbRetirar.Visible = false;
                            MskTxtBxPalitos.Visible = false;
                            BtJogar.Enabled = true;
                            NumericQuantidade.Enabled = true;
                        }
                    }
                    if (Quantia > 0)
                    {
                        RTextBoxDisplay.AppendText("Sua Vez");
                        RTextBoxDisplay.AppendText(Environment.NewLine);
                        RTextBoxDisplay.AppendText("Restam " + Quantia + " Palitos");
                        RTextBoxDisplay.AppendText(Environment.NewLine);

                        MskTxtBxPalitos.Clear();
                    }
                }
            }
            if (RetiradaPlayer == 3)
            {
                RetiradaPC = 1;
                
                RTextBoxDisplay.AppendText("Você tirou " + RetiradaPlayer + " Palitos");
                RTextBoxDisplay.AppendText(Environment.NewLine);

                Quantia -= RetiradaPlayer;



                if (Quantia <= 0)
                {
                    MessageBox.Show("Você Perdeu... Rs Rs :)", "KKKKJ Muito fácil!!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MskTxtBxPalitos.Clear();
                    RTextBoxDisplay.Clear();

                    if (DialogResult.No == MessageBox.Show("Deseja Jogar novamente?",
                        "DESAFIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        Application.Exit();
                    }
                    else
                    {
                        BtRetirar.Visible = false;
                        LbRetirar.Visible = false;
                        MskTxtBxPalitos.Visible = false;
                        BtJogar.Enabled = true;
                        NumericQuantidade.Enabled = true;
                    }
                }
                if (Quantia > 0)
                {
                    RTextBoxDisplay.AppendText("Restam " + Quantia + " Palitos");
                    RTextBoxDisplay.AppendText(Environment.NewLine);
                    RTextBoxDisplay.AppendText("Retiro " + RetiradaPC + " Palitos");
                    RTextBoxDisplay.AppendText(Environment.NewLine);
                    Quantia -= RetiradaPC;
                    if (Quantia <= 0)
                    {

                        MessageBox.Show("COMO ISSO É POSSÍVEL?????", "Perdi!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        MskTxtBxPalitos.Clear();
                        RTextBoxDisplay.Clear();

                        if (DialogResult.No == MessageBox.Show("Deseja Jogar novamente?",
                            "DESAFIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            Application.Exit();
                        }
                        else
                        {
                            BtRetirar.Visible = false;
                            LbRetirar.Visible = false;
                            MskTxtBxPalitos.Visible = false;
                            BtJogar.Enabled = true;
                            NumericQuantidade.Enabled = true;
                        }
                    }
                    if (Quantia > 0)
                    {
                        RTextBoxDisplay.AppendText("Sua Vez");
                        RTextBoxDisplay.AppendText(Environment.NewLine);
                        RTextBoxDisplay.AppendText("Restam " + Quantia + " Palitos");
                        RTextBoxDisplay.AppendText(Environment.NewLine);
                        MskTxtBxPalitos.Clear();
                    }
                }
            }
            else if(RetiradaPlayer != 1 && RetiradaPlayer != 2 && RetiradaPlayer != 3)
            {
                MessageBox.Show("São permitidos retirar 1 a 3 palitos por jogada", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MskTxtBxPalitos.Clear();
            }

            }

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
