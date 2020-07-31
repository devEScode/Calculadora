namespace Calculadora
{
    partial class Calculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BoxPainel = new System.Windows.Forms.TextBox();
            this.BtnZero = new System.Windows.Forms.Button();
            this.BtnUm = new System.Windows.Forms.Button();
            this.BtnQuatro = new System.Windows.Forms.Button();
            this.BtnSete = new System.Windows.Forms.Button();
            this.BtnApagar = new System.Windows.Forms.Button();
            this.BtnDois = new System.Windows.Forms.Button();
            this.BtnCinco = new System.Windows.Forms.Button();
            this.BtnOito = new System.Windows.Forms.Button();
            this.BtnPorcentagem = new System.Windows.Forms.Button();
            this.BtnPonto = new System.Windows.Forms.Button();
            this.BtnTres = new System.Windows.Forms.Button();
            this.BtnSeis = new System.Windows.Forms.Button();
            this.BtnNove = new System.Windows.Forms.Button();
            this.BtnMultiplicacao = new System.Windows.Forms.Button();
            this.BtnIgual = new System.Windows.Forms.Button();
            this.BtnMais = new System.Windows.Forms.Button();
            this.BtnMenos = new System.Windows.Forms.Button();
            this.BtnDivicao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BoxPainel
            // 
            this.BoxPainel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxPainel.Location = new System.Drawing.Point(39, 12);
            this.BoxPainel.Name = "BoxPainel";
            this.BoxPainel.ReadOnly = true;
            this.BoxPainel.Size = new System.Drawing.Size(202, 32);
            this.BoxPainel.TabIndex = 1;
            this.BoxPainel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BoxPainel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BtnZero
            // 
            this.BtnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnZero.Location = new System.Drawing.Point(39, 260);
            this.BtnZero.Name = "BtnZero";
            this.BtnZero.Size = new System.Drawing.Size(100, 45);
            this.BtnZero.TabIndex = 10;
            this.BtnZero.Text = "0";
            this.BtnZero.UseVisualStyleBackColor = true;
            this.BtnZero.Click += new System.EventHandler(this.BtnZero_Click);
            // 
            // BtnUm
            // 
            this.BtnUm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUm.Location = new System.Drawing.Point(39, 209);
            this.BtnUm.Name = "BtnUm";
            this.BtnUm.Size = new System.Drawing.Size(45, 45);
            this.BtnUm.TabIndex = 9;
            this.BtnUm.Text = "1";
            this.BtnUm.UseVisualStyleBackColor = true;
            this.BtnUm.Click += new System.EventHandler(this.BtnUm_Click);
            // 
            // BtnQuatro
            // 
            this.BtnQuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuatro.Location = new System.Drawing.Point(39, 158);
            this.BtnQuatro.Name = "BtnQuatro";
            this.BtnQuatro.Size = new System.Drawing.Size(45, 45);
            this.BtnQuatro.TabIndex = 8;
            this.BtnQuatro.Text = "4";
            this.BtnQuatro.UseVisualStyleBackColor = true;
            this.BtnQuatro.Click += new System.EventHandler(this.BtnQuatro_Click);
            // 
            // BtnSete
            // 
            this.BtnSete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSete.Location = new System.Drawing.Point(39, 107);
            this.BtnSete.Name = "BtnSete";
            this.BtnSete.Size = new System.Drawing.Size(45, 45);
            this.BtnSete.TabIndex = 7;
            this.BtnSete.Text = "7";
            this.BtnSete.UseVisualStyleBackColor = true;
            this.BtnSete.Click += new System.EventHandler(this.BtnSete_Click);
            // 
            // BtnApagar
            // 
            this.BtnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApagar.Location = new System.Drawing.Point(39, 56);
            this.BtnApagar.Name = "BtnApagar";
            this.BtnApagar.Size = new System.Drawing.Size(45, 45);
            this.BtnApagar.TabIndex = 6;
            this.BtnApagar.Text = "CE";
            this.BtnApagar.UseVisualStyleBackColor = true;
            this.BtnApagar.Click += new System.EventHandler(this.BtnApagar_Click);
            // 
            // BtnDois
            // 
            this.BtnDois.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDois.Location = new System.Drawing.Point(94, 209);
            this.BtnDois.Name = "BtnDois";
            this.BtnDois.Size = new System.Drawing.Size(45, 45);
            this.BtnDois.TabIndex = 14;
            this.BtnDois.Text = "2";
            this.BtnDois.UseVisualStyleBackColor = true;
            this.BtnDois.Click += new System.EventHandler(this.BtnDois_Click);
            // 
            // BtnCinco
            // 
            this.BtnCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCinco.Location = new System.Drawing.Point(94, 158);
            this.BtnCinco.Name = "BtnCinco";
            this.BtnCinco.Size = new System.Drawing.Size(45, 45);
            this.BtnCinco.TabIndex = 13;
            this.BtnCinco.Text = "5";
            this.BtnCinco.UseVisualStyleBackColor = true;
            this.BtnCinco.Click += new System.EventHandler(this.BtnCinco_Click);
            // 
            // BtnOito
            // 
            this.BtnOito.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOito.Location = new System.Drawing.Point(94, 107);
            this.BtnOito.Name = "BtnOito";
            this.BtnOito.Size = new System.Drawing.Size(45, 45);
            this.BtnOito.TabIndex = 12;
            this.BtnOito.Text = "8";
            this.BtnOito.UseVisualStyleBackColor = true;
            this.BtnOito.Click += new System.EventHandler(this.BtnOito_Click);
            // 
            // BtnPorcentagem
            // 
            this.BtnPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPorcentagem.Location = new System.Drawing.Point(94, 56);
            this.BtnPorcentagem.Name = "BtnPorcentagem";
            this.BtnPorcentagem.Size = new System.Drawing.Size(45, 45);
            this.BtnPorcentagem.TabIndex = 11;
            this.BtnPorcentagem.Text = "%";
            this.BtnPorcentagem.UseVisualStyleBackColor = true;
            this.BtnPorcentagem.Click += new System.EventHandler(this.BtnPorcentagem_Click);
            // 
            // BtnPonto
            // 
            this.BtnPonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPonto.Location = new System.Drawing.Point(145, 260);
            this.BtnPonto.Name = "BtnPonto";
            this.BtnPonto.Size = new System.Drawing.Size(45, 45);
            this.BtnPonto.TabIndex = 20;
            this.BtnPonto.Text = ".";
            this.BtnPonto.UseVisualStyleBackColor = true;
            this.BtnPonto.Click += new System.EventHandler(this.BtnPonto_Click);
            // 
            // BtnTres
            // 
            this.BtnTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTres.Location = new System.Drawing.Point(145, 209);
            this.BtnTres.Name = "BtnTres";
            this.BtnTres.Size = new System.Drawing.Size(45, 45);
            this.BtnTres.TabIndex = 19;
            this.BtnTres.Text = "3";
            this.BtnTres.UseVisualStyleBackColor = true;
            this.BtnTres.Click += new System.EventHandler(this.BtnTres_Click);
            // 
            // BtnSeis
            // 
            this.BtnSeis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeis.Location = new System.Drawing.Point(145, 158);
            this.BtnSeis.Name = "BtnSeis";
            this.BtnSeis.Size = new System.Drawing.Size(45, 45);
            this.BtnSeis.TabIndex = 18;
            this.BtnSeis.Text = "6";
            this.BtnSeis.UseVisualStyleBackColor = true;
            this.BtnSeis.Click += new System.EventHandler(this.BtnSeis_Click);
            // 
            // BtnNove
            // 
            this.BtnNove.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNove.Location = new System.Drawing.Point(145, 107);
            this.BtnNove.Name = "BtnNove";
            this.BtnNove.Size = new System.Drawing.Size(45, 45);
            this.BtnNove.TabIndex = 17;
            this.BtnNove.Text = "9";
            this.BtnNove.UseVisualStyleBackColor = true;
            this.BtnNove.Click += new System.EventHandler(this.BtnNove_Click);
            // 
            // BtnMultiplicacao
            // 
            this.BtnMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMultiplicacao.Location = new System.Drawing.Point(145, 56);
            this.BtnMultiplicacao.Name = "BtnMultiplicacao";
            this.BtnMultiplicacao.Size = new System.Drawing.Size(45, 45);
            this.BtnMultiplicacao.TabIndex = 16;
            this.BtnMultiplicacao.Text = "*";
            this.BtnMultiplicacao.UseVisualStyleBackColor = true;
            this.BtnMultiplicacao.Click += new System.EventHandler(this.BtnMultiplicacao_Click);
            // 
            // BtnIgual
            // 
            this.BtnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIgual.Location = new System.Drawing.Point(196, 209);
            this.BtnIgual.Name = "BtnIgual";
            this.BtnIgual.Size = new System.Drawing.Size(45, 96);
            this.BtnIgual.TabIndex = 25;
            this.BtnIgual.Text = "=";
            this.BtnIgual.UseVisualStyleBackColor = true;
            this.BtnIgual.Click += new System.EventHandler(this.BtnIgual_Click);
            // 
            // BtnMais
            // 
            this.BtnMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMais.Location = new System.Drawing.Point(196, 158);
            this.BtnMais.Name = "BtnMais";
            this.BtnMais.Size = new System.Drawing.Size(45, 45);
            this.BtnMais.TabIndex = 23;
            this.BtnMais.Text = "+";
            this.BtnMais.UseVisualStyleBackColor = true;
            this.BtnMais.Click += new System.EventHandler(this.BtnMais_Click);
            // 
            // BtnMenos
            // 
            this.BtnMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenos.Location = new System.Drawing.Point(196, 107);
            this.BtnMenos.Name = "BtnMenos";
            this.BtnMenos.Size = new System.Drawing.Size(45, 45);
            this.BtnMenos.TabIndex = 22;
            this.BtnMenos.Text = "-";
            this.BtnMenos.UseVisualStyleBackColor = true;
            this.BtnMenos.Click += new System.EventHandler(this.BtnMenos_Click);
            // 
            // BtnDivicao
            // 
            this.BtnDivicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDivicao.Location = new System.Drawing.Point(196, 56);
            this.BtnDivicao.Name = "BtnDivicao";
            this.BtnDivicao.Size = new System.Drawing.Size(45, 45);
            this.BtnDivicao.TabIndex = 21;
            this.BtnDivicao.Text = "/";
            this.BtnDivicao.UseVisualStyleBackColor = true;
            this.BtnDivicao.Click += new System.EventHandler(this.BtnDivicao_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 329);
            this.Controls.Add(this.BtnIgual);
            this.Controls.Add(this.BtnMais);
            this.Controls.Add(this.BtnMenos);
            this.Controls.Add(this.BtnDivicao);
            this.Controls.Add(this.BtnPonto);
            this.Controls.Add(this.BtnTres);
            this.Controls.Add(this.BtnSeis);
            this.Controls.Add(this.BtnNove);
            this.Controls.Add(this.BtnMultiplicacao);
            this.Controls.Add(this.BtnDois);
            this.Controls.Add(this.BtnCinco);
            this.Controls.Add(this.BtnOito);
            this.Controls.Add(this.BtnPorcentagem);
            this.Controls.Add(this.BtnZero);
            this.Controls.Add(this.BtnUm);
            this.Controls.Add(this.BtnQuatro);
            this.Controls.Add(this.BtnSete);
            this.Controls.Add(this.BtnApagar);
            this.Controls.Add(this.BoxPainel);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox BoxPainel;
        private System.Windows.Forms.Button BtnZero;
        private System.Windows.Forms.Button BtnUm;
        private System.Windows.Forms.Button BtnQuatro;
        private System.Windows.Forms.Button BtnSete;
        private System.Windows.Forms.Button BtnApagar;
        private System.Windows.Forms.Button BtnDois;
        private System.Windows.Forms.Button BtnCinco;
        private System.Windows.Forms.Button BtnOito;
        private System.Windows.Forms.Button BtnPorcentagem;
        private System.Windows.Forms.Button BtnPonto;
        private System.Windows.Forms.Button BtnTres;
        private System.Windows.Forms.Button BtnSeis;
        private System.Windows.Forms.Button BtnNove;
        private System.Windows.Forms.Button BtnMultiplicacao;
        private System.Windows.Forms.Button BtnIgual;
        private System.Windows.Forms.Button BtnMais;
        private System.Windows.Forms.Button BtnMenos;
        private System.Windows.Forms.Button BtnDivicao;
    }
}

