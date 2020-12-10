namespace AplWfa_Twitch
{
    partial class frmJogo
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
            this.components = new System.ComponentModel.Container();
            this.tmrJogo = new System.Windows.Forms.Timer(this.components);
            this.imglist = new System.Windows.Forms.ImageList(this.components);
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pcblblChatSim = new System.Windows.Forms.PictureBox();
            this.pcblblChatNao = new System.Windows.Forms.PictureBox();
            this.pcblblTesoura = new System.Windows.Forms.PictureBox();
            this.pcblblPapel = new System.Windows.Forms.PictureBox();
            this.pcblblPedra = new System.Windows.Forms.PictureBox();
            this.btnTesoura = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnPedra = new System.Windows.Forms.Button();
            this.pcblblTituloJogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcblblChatSim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcblblChatNao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcblblTesoura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcblblPapel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcblblPedra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcblblTituloJogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrJogo
            // 
            this.tmrJogo.Interval = 1000;
            this.tmrJogo.Tick += new System.EventHandler(this.tmrJogo_Tick);
            // 
            // imglist
            // 
            this.imglist.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imglist.ImageSize = new System.Drawing.Size(16, 16);
            this.imglist.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackgroundImage = global::AplWfa_Twitch.Properties.Resources.btnContinuar;
            this.btnContinuar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinuar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnContinuar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnContinuar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Location = new System.Drawing.Point(531, 604);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(219, 76);
            this.btnContinuar.TabIndex = 4;
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Visible = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::AplWfa_Twitch.Properties.Resources.btnVoltarHover;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(1098, 644);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(143, 47);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pcblblChatSim
            // 
            this.pcblblChatSim.BackColor = System.Drawing.Color.Transparent;
            this.pcblblChatSim.Image = global::AplWfa_Twitch.Properties.Resources.lblChatS;
            this.pcblblChatSim.Location = new System.Drawing.Point(495, 615);
            this.pcblblChatSim.Name = "pcblblChatSim";
            this.pcblblChatSim.Padding = new System.Windows.Forms.Padding(3);
            this.pcblblChatSim.Size = new System.Drawing.Size(290, 56);
            this.pcblblChatSim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcblblChatSim.TabIndex = 8;
            this.pcblblChatSim.TabStop = false;
            this.pcblblChatSim.Visible = false;
            // 
            // pcblblChatNao
            // 
            this.pcblblChatNao.BackColor = System.Drawing.Color.Transparent;
            this.pcblblChatNao.Image = global::AplWfa_Twitch.Properties.Resources.lblChatN;
            this.pcblblChatNao.Location = new System.Drawing.Point(453, 614);
            this.pcblblChatNao.Name = "pcblblChatNao";
            this.pcblblChatNao.Padding = new System.Windows.Forms.Padding(3);
            this.pcblblChatNao.Size = new System.Drawing.Size(374, 48);
            this.pcblblChatNao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcblblChatNao.TabIndex = 7;
            this.pcblblChatNao.TabStop = false;
            this.pcblblChatNao.Visible = false;
            // 
            // pcblblTesoura
            // 
            this.pcblblTesoura.Image = global::AplWfa_Twitch.Properties.Resources.lblTesoura;
            this.pcblblTesoura.Location = new System.Drawing.Point(915, 502);
            this.pcblblTesoura.Name = "pcblblTesoura";
            this.pcblblTesoura.Size = new System.Drawing.Size(155, 53);
            this.pcblblTesoura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcblblTesoura.TabIndex = 6;
            this.pcblblTesoura.TabStop = false;
            // 
            // pcblblPapel
            // 
            this.pcblblPapel.Image = global::AplWfa_Twitch.Properties.Resources.lblPapel;
            this.pcblblPapel.Location = new System.Drawing.Point(577, 502);
            this.pcblblPapel.Name = "pcblblPapel";
            this.pcblblPapel.Size = new System.Drawing.Size(123, 61);
            this.pcblblPapel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcblblPapel.TabIndex = 5;
            this.pcblblPapel.TabStop = false;
            // 
            // pcblblPedra
            // 
            this.pcblblPedra.Image = global::AplWfa_Twitch.Properties.Resources.lblPedra;
            this.pcblblPedra.Location = new System.Drawing.Point(224, 504);
            this.pcblblPedra.Name = "pcblblPedra";
            this.pcblblPedra.Size = new System.Drawing.Size(136, 53);
            this.pcblblPedra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcblblPedra.TabIndex = 4;
            this.pcblblPedra.TabStop = false;
            // 
            // btnTesoura
            // 
            this.btnTesoura.BackgroundImage = global::AplWfa_Twitch.Properties.Resources.btnTesoura;
            this.btnTesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTesoura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTesoura.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnTesoura.FlatAppearance.BorderSize = 0;
            this.btnTesoura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnTesoura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnTesoura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTesoura.Location = new System.Drawing.Point(859, 162);
            this.btnTesoura.Name = "btnTesoura";
            this.btnTesoura.Size = new System.Drawing.Size(260, 327);
            this.btnTesoura.TabIndex = 3;
            this.btnTesoura.UseVisualStyleBackColor = true;
            this.btnTesoura.Click += new System.EventHandler(this.btnTesoura_Click);
            // 
            // btnPapel
            // 
            this.btnPapel.BackgroundImage = global::AplWfa_Twitch.Properties.Resources.btnPapel;
            this.btnPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPapel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPapel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnPapel.FlatAppearance.BorderSize = 0;
            this.btnPapel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnPapel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnPapel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPapel.Location = new System.Drawing.Point(510, 162);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(260, 327);
            this.btnPapel.TabIndex = 2;
            this.btnPapel.UseVisualStyleBackColor = true;
            this.btnPapel.Click += new System.EventHandler(this.btnPapel_Click);
            // 
            // btnPedra
            // 
            this.btnPedra.BackgroundImage = global::AplWfa_Twitch.Properties.Resources.btnPedra;
            this.btnPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPedra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnPedra.FlatAppearance.BorderSize = 0;
            this.btnPedra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnPedra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnPedra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedra.Location = new System.Drawing.Point(167, 162);
            this.btnPedra.Name = "btnPedra";
            this.btnPedra.Size = new System.Drawing.Size(260, 327);
            this.btnPedra.TabIndex = 1;
            this.btnPedra.UseVisualStyleBackColor = true;
            this.btnPedra.Click += new System.EventHandler(this.btnPedra_Click);
            // 
            // pcblblTituloJogo
            // 
            this.pcblblTituloJogo.Image = global::AplWfa_Twitch.Properties.Resources.lblTituloGameplay;
            this.pcblblTituloJogo.Location = new System.Drawing.Point(417, 12);
            this.pcblblTituloJogo.Name = "pcblblTituloJogo";
            this.pcblblTituloJogo.Size = new System.Drawing.Size(447, 70);
            this.pcblblTituloJogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcblblTituloJogo.TabIndex = 0;
            this.pcblblTituloJogo.TabStop = false;
            // 
            // frmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.pcblblChatSim);
            this.Controls.Add(this.pcblblChatNao);
            this.Controls.Add(this.pcblblTesoura);
            this.Controls.Add(this.pcblblPapel);
            this.Controls.Add(this.pcblblPedra);
            this.Controls.Add(this.btnTesoura);
            this.Controls.Add(this.btnPapel);
            this.Controls.Add(this.btnPedra);
            this.Controls.Add(this.pcblblTituloJogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Twitch Game by Samuel";
            ((System.ComponentModel.ISupportInitialize)(this.pcblblChatSim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcblblChatNao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcblblTesoura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcblblPapel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcblblPedra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcblblTituloJogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcblblTituloJogo;
        private System.Windows.Forms.Button btnPedra;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnTesoura;
        private System.Windows.Forms.PictureBox pcblblPedra;
        private System.Windows.Forms.PictureBox pcblblPapel;
        private System.Windows.Forms.PictureBox pcblblTesoura;
        private System.Windows.Forms.Timer tmrJogo;
        private System.Windows.Forms.PictureBox pcblblChatNao;
        private System.Windows.Forms.PictureBox pcblblChatSim;
        private System.Windows.Forms.ImageList imglist;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnContinuar;
    }
}