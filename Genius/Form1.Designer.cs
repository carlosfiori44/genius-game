namespace Genius
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bIniciar = new System.Windows.Forms.Button();
            this.bSair = new System.Windows.Forms.Button();
            this.radioFacil = new System.Windows.Forms.RadioButton();
            this.radioDificil = new System.Windows.Forms.RadioButton();
            this.radioMedio = new System.Windows.Forms.RadioButton();
            this.radioPesadelo = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pontos = new System.Windows.Forms.Label();
            this.pbAmarelo = new System.Windows.Forms.PictureBox();
            this.pbVermelho = new System.Windows.Forms.PictureBox();
            this.pbAzul = new System.Windows.Forms.PictureBox();
            this.pbVerde = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAmarelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVermelho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAzul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerde)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bIniciar
            // 
            this.bIniciar.Location = new System.Drawing.Point(213, 381);
            this.bIniciar.Name = "bIniciar";
            this.bIniciar.Size = new System.Drawing.Size(75, 23);
            this.bIniciar.TabIndex = 4;
            this.bIniciar.Text = "Iniciar";
            this.bIniciar.UseVisualStyleBackColor = true;
            this.bIniciar.Click += new System.EventHandler(this.bIniciar_Click);
            // 
            // bSair
            // 
            this.bSair.Location = new System.Drawing.Point(306, 381);
            this.bSair.Name = "bSair";
            this.bSair.Size = new System.Drawing.Size(75, 23);
            this.bSair.TabIndex = 5;
            this.bSair.Text = "Sair";
            this.bSair.UseVisualStyleBackColor = true;
            this.bSair.Click += new System.EventHandler(this.bSair_Click);
            // 
            // radioFacil
            // 
            this.radioFacil.AutoSize = true;
            this.radioFacil.Checked = true;
            this.radioFacil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioFacil.Location = new System.Drawing.Point(22, 19);
            this.radioFacil.Name = "radioFacil";
            this.radioFacil.Size = new System.Drawing.Size(47, 17);
            this.radioFacil.TabIndex = 6;
            this.radioFacil.TabStop = true;
            this.radioFacil.Text = "Fácil";
            this.radioFacil.UseVisualStyleBackColor = true;
            // 
            // radioDificil
            // 
            this.radioDificil.AutoSize = true;
            this.radioDificil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioDificil.Location = new System.Drawing.Point(22, 63);
            this.radioDificil.Name = "radioDificil";
            this.radioDificil.Size = new System.Drawing.Size(53, 17);
            this.radioDificil.TabIndex = 7;
            this.radioDificil.Text = "Dífcil ";
            this.radioDificil.UseVisualStyleBackColor = true;
            // 
            // radioMedio
            // 
            this.radioMedio.AutoSize = true;
            this.radioMedio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioMedio.Location = new System.Drawing.Point(134, 19);
            this.radioMedio.Name = "radioMedio";
            this.radioMedio.Size = new System.Drawing.Size(54, 17);
            this.radioMedio.TabIndex = 8;
            this.radioMedio.Text = "Médio";
            this.radioMedio.UseVisualStyleBackColor = true;
            // 
            // radioPesadelo
            // 
            this.radioPesadelo.AutoSize = true;
            this.radioPesadelo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioPesadelo.Location = new System.Drawing.Point(134, 63);
            this.radioPesadelo.Name = "radioPesadelo";
            this.radioPesadelo.Size = new System.Drawing.Size(69, 17);
            this.radioPesadelo.TabIndex = 9;
            this.radioPesadelo.Text = "Pesadelo";
            this.radioPesadelo.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 700;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pontos
            // 
            this.pontos.AutoSize = true;
            this.pontos.Font = new System.Drawing.Font("November", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pontos.ForeColor = System.Drawing.Color.AliceBlue;
            this.pontos.Location = new System.Drawing.Point(12, 9);
            this.pontos.Name = "pontos";
            this.pontos.Size = new System.Drawing.Size(103, 24);
            this.pontos.TabIndex = 10;
            this.pontos.Text = "Pontuação";
            // 
            // pbAmarelo
            // 
            this.pbAmarelo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbAmarelo.BackgroundImage")));
            this.pbAmarelo.Image = global::Genius.Properties.Resources.amarelo;
            this.pbAmarelo.Location = new System.Drawing.Point(0, 28);
            this.pbAmarelo.Name = "pbAmarelo";
            this.pbAmarelo.Size = new System.Drawing.Size(300, 300);
            this.pbAmarelo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbAmarelo.TabIndex = 3;
            this.pbAmarelo.TabStop = false;
            this.pbAmarelo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbAmarelo_MouseDown);
            this.pbAmarelo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbAmarelo_MouseUp);
            // 
            // pbVermelho
            // 
            this.pbVermelho.Image = global::Genius.Properties.Resources.vermelho;
            this.pbVermelho.Location = new System.Drawing.Point(294, 324);
            this.pbVermelho.Name = "pbVermelho";
            this.pbVermelho.Size = new System.Drawing.Size(300, 300);
            this.pbVermelho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbVermelho.TabIndex = 2;
            this.pbVermelho.TabStop = false;
            this.pbVermelho.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbVermelho_MouseDown);
            this.pbVermelho.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbVermelho_MouseUp);
            // 
            // pbAzul
            // 
            this.pbAzul.Image = global::Genius.Properties.Resources.azul;
            this.pbAzul.Location = new System.Drawing.Point(294, 28);
            this.pbAzul.Name = "pbAzul";
            this.pbAzul.Size = new System.Drawing.Size(300, 300);
            this.pbAzul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbAzul.TabIndex = 1;
            this.pbAzul.TabStop = false;
            this.pbAzul.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbAzul_MouseDown);
            this.pbAzul.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbAzul_MouseUp);
            // 
            // pbVerde
            // 
            this.pbVerde.Image = global::Genius.Properties.Resources.verde;
            this.pbVerde.Location = new System.Drawing.Point(0, 324);
            this.pbVerde.Name = "pbVerde";
            this.pbVerde.Size = new System.Drawing.Size(300, 300);
            this.pbVerde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbVerde.TabIndex = 0;
            this.pbVerde.TabStop = false;
            this.pbVerde.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbVerde_MouseDown);
            this.pbVerde.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbVerde_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.radioFacil);
            this.groupBox1.Controls.Add(this.radioMedio);
            this.groupBox1.Controls.Add(this.radioDificil);
            this.groupBox1.Controls.Add(this.radioPesadelo);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(193, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dificuldade";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(596, 622);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pontos);
            this.Controls.Add(this.bSair);
            this.Controls.Add(this.bIniciar);
            this.Controls.Add(this.pbAmarelo);
            this.Controls.Add(this.pbVermelho);
            this.Controls.Add(this.pbAzul);
            this.Controls.Add(this.pbVerde);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "        ";
            ((System.ComponentModel.ISupportInitialize)(this.pbAmarelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVermelho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAzul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerde)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbVerde;
        private System.Windows.Forms.PictureBox pbAzul;
        private System.Windows.Forms.PictureBox pbVermelho;
        private System.Windows.Forms.PictureBox pbAmarelo;
        private System.Windows.Forms.Button bIniciar;
        private System.Windows.Forms.Button bSair;
        private System.Windows.Forms.RadioButton radioFacil;
        private System.Windows.Forms.RadioButton radioDificil;
        private System.Windows.Forms.RadioButton radioMedio;
        private System.Windows.Forms.RadioButton radioPesadelo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label pontos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer2;
    }
}

