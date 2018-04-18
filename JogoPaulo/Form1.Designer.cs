namespace JogoPaulo
{
    partial class FormGame
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
            this.BtJogar = new System.Windows.Forms.Button();
            this.BtRetirar = new System.Windows.Forms.Button();
            this.LbQuantidade = new System.Windows.Forms.Label();
            this.MskTxtBxPalitos = new System.Windows.Forms.MaskedTextBox();
            this.NumericQuantidade = new System.Windows.Forms.NumericUpDown();
            this.RTextBoxDisplay = new System.Windows.Forms.RichTextBox();
            this.LbRetirar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // BtJogar
            // 
            this.BtJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.BtJogar.Location = new System.Drawing.Point(435, 25);
            this.BtJogar.Name = "BtJogar";
            this.BtJogar.Size = new System.Drawing.Size(82, 25);
            this.BtJogar.TabIndex = 0;
            this.BtJogar.Text = "Jogar";
            this.BtJogar.UseVisualStyleBackColor = true;
            this.BtJogar.Click += new System.EventHandler(this.BtJogar_Click);
            // 
            // BtRetirar
            // 
            this.BtRetirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.BtRetirar.Location = new System.Drawing.Point(435, 71);
            this.BtRetirar.Name = "BtRetirar";
            this.BtRetirar.Size = new System.Drawing.Size(82, 25);
            this.BtRetirar.TabIndex = 1;
            this.BtRetirar.Text = "Retirar";
            this.BtRetirar.UseVisualStyleBackColor = true;
            this.BtRetirar.Visible = false;
            this.BtRetirar.Click += new System.EventHandler(this.BtRetirar_Click);
            // 
            // LbQuantidade
            // 
            this.LbQuantidade.AutoSize = true;
            this.LbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LbQuantidade.Location = new System.Drawing.Point(12, 30);
            this.LbQuantidade.Name = "LbQuantidade";
            this.LbQuantidade.Size = new System.Drawing.Size(253, 20);
            this.LbQuantidade.TabIndex = 2;
            this.LbQuantidade.Text = "Escolha a quantidade de Palitos:";
            // 
            // MskTxtBxPalitos
            // 
            this.MskTxtBxPalitos.Location = new System.Drawing.Point(298, 74);
            this.MskTxtBxPalitos.Mask = "0";
            this.MskTxtBxPalitos.Name = "MskTxtBxPalitos";
            this.MskTxtBxPalitos.Size = new System.Drawing.Size(100, 20);
            this.MskTxtBxPalitos.TabIndex = 3;
            this.MskTxtBxPalitos.ValidatingType = typeof(int);
            this.MskTxtBxPalitos.Visible = false;
            // 
            // NumericQuantidade
            // 
            this.NumericQuantidade.Location = new System.Drawing.Point(298, 25);
            this.NumericQuantidade.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.NumericQuantidade.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumericQuantidade.Name = "NumericQuantidade";
            this.NumericQuantidade.Size = new System.Drawing.Size(100, 20);
            this.NumericQuantidade.TabIndex = 4;
            this.NumericQuantidade.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // RTextBoxDisplay
            // 
            this.RTextBoxDisplay.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTextBoxDisplay.Location = new System.Drawing.Point(16, 119);
            this.RTextBoxDisplay.Name = "RTextBoxDisplay";
            this.RTextBoxDisplay.Size = new System.Drawing.Size(545, 450);
            this.RTextBoxDisplay.TabIndex = 5;
            this.RTextBoxDisplay.Text = "";
            // 
            // LbRetirar
            // 
            this.LbRetirar.AutoSize = true;
            this.LbRetirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LbRetirar.Location = new System.Drawing.Point(26, 73);
            this.LbRetirar.Name = "LbRetirar";
            this.LbRetirar.Size = new System.Drawing.Size(239, 20);
            this.LbRetirar.TabIndex = 6;
            this.LbRetirar.Text = "Quantos palitos deseja retirar?";
            this.LbRetirar.Visible = false;
            this.LbRetirar.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 587);
            this.Controls.Add(this.LbRetirar);
            this.Controls.Add(this.RTextBoxDisplay);
            this.Controls.Add(this.NumericQuantidade);
            this.Controls.Add(this.MskTxtBxPalitos);
            this.Controls.Add(this.LbQuantidade);
            this.Controls.Add(this.BtRetirar);
            this.Controls.Add(this.BtJogar);
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo do Palito";
            ((System.ComponentModel.ISupportInitialize)(this.NumericQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtJogar;
        private System.Windows.Forms.Button BtRetirar;
        private System.Windows.Forms.Label LbQuantidade;
        private System.Windows.Forms.MaskedTextBox MskTxtBxPalitos;
        private System.Windows.Forms.NumericUpDown NumericQuantidade;
        private System.Windows.Forms.RichTextBox RTextBoxDisplay;
        private System.Windows.Forms.Label LbRetirar;
    }
}

