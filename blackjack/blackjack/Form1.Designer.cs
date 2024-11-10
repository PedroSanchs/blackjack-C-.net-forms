namespace blackjack
{
    partial class Form1
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
            this.lb_mao_jogador = new System.Windows.Forms.Label();
            this.btn_hit = new System.Windows.Forms.Button();
            this.btn_stand = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lb_pontos_jogador = new System.Windows.Forms.Label();
            this.lb_mao_dealer = new System.Windows.Forms.Label();
            this.flp_mao_dealer = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_mao_jogador = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_mao_jogador
            // 
            this.lb_mao_jogador.AutoSize = true;
            this.lb_mao_jogador.Location = new System.Drawing.Point(290, 396);
            this.lb_mao_jogador.Name = "lb_mao_jogador";
            this.lb_mao_jogador.Size = new System.Drawing.Size(35, 13);
            this.lb_mao_jogador.TabIndex = 0;
            this.lb_mao_jogador.Text = "label1";
            this.lb_mao_jogador.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_hit
            // 
            this.btn_hit.Location = new System.Drawing.Point(617, 415);
            this.btn_hit.Name = "btn_hit";
            this.btn_hit.Size = new System.Drawing.Size(75, 23);
            this.btn_hit.TabIndex = 1;
            this.btn_hit.Text = "Hit!";
            this.btn_hit.UseVisualStyleBackColor = true;
            this.btn_hit.Click += new System.EventHandler(this.btn_hit_Click);
            // 
            // btn_stand
            // 
            this.btn_stand.Location = new System.Drawing.Point(617, 386);
            this.btn_stand.Name = "btn_stand";
            this.btn_stand.Size = new System.Drawing.Size(75, 23);
            this.btn_stand.TabIndex = 2;
            this.btn_stand.Text = "Stand";
            this.btn_stand.UseVisualStyleBackColor = true;
            this.btn_stand.Click += new System.EventHandler(this.btn_stand_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(617, 18);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // lb_pontos_jogador
            // 
            this.lb_pontos_jogador.AutoSize = true;
            this.lb_pontos_jogador.Location = new System.Drawing.Point(290, 428);
            this.lb_pontos_jogador.Name = "lb_pontos_jogador";
            this.lb_pontos_jogador.Size = new System.Drawing.Size(35, 13);
            this.lb_pontos_jogador.TabIndex = 5;
            this.lb_pontos_jogador.Text = "label1";
            // 
            // lb_mao_dealer
            // 
            this.lb_mao_dealer.AutoSize = true;
            this.lb_mao_dealer.Location = new System.Drawing.Point(290, 134);
            this.lb_mao_dealer.Name = "lb_mao_dealer";
            this.lb_mao_dealer.Size = new System.Drawing.Size(35, 13);
            this.lb_mao_dealer.TabIndex = 6;
            this.lb_mao_dealer.Text = "label1";
            // 
            // flp_mao_dealer
            // 
            this.flp_mao_dealer.AutoSize = true;
            this.flp_mao_dealer.BackColor = System.Drawing.Color.Transparent;
            this.flp_mao_dealer.Location = new System.Drawing.Point(293, 18);
            this.flp_mao_dealer.Name = "flp_mao_dealer";
            this.flp_mao_dealer.Size = new System.Drawing.Size(200, 100);
            this.flp_mao_dealer.TabIndex = 8;
            this.flp_mao_dealer.Paint += new System.Windows.Forms.PaintEventHandler(this.flp_mao_dealer_Paint);
            // 
            // flp_mao_jogador
            // 
            this.flp_mao_jogador.AutoSize = true;
            this.flp_mao_jogador.BackColor = System.Drawing.Color.Transparent;
            this.flp_mao_jogador.Location = new System.Drawing.Point(293, 275);
            this.flp_mao_jogador.Name = "flp_mao_jogador";
            this.flp_mao_jogador.Size = new System.Drawing.Size(200, 100);
            this.flp_mao_jogador.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::blackjack.Properties.Resources.Deck;
            this.pictureBox1.Location = new System.Drawing.Point(12, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::blackjack.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flp_mao_jogador);
            this.Controls.Add(this.flp_mao_dealer);
            this.Controls.Add(this.lb_mao_dealer);
            this.Controls.Add(this.lb_pontos_jogador);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_stand);
            this.Controls.Add(this.btn_hit);
            this.Controls.Add(this.lb_mao_jogador);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_mao_jogador;
        private System.Windows.Forms.Button btn_hit;
        private System.Windows.Forms.Button btn_stand;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lb_pontos_jogador;
        private System.Windows.Forms.Label lb_mao_dealer;
        private System.Windows.Forms.FlowLayoutPanel flp_mao_dealer;
        private System.Windows.Forms.FlowLayoutPanel flp_mao_jogador;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

