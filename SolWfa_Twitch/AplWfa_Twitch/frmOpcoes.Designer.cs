namespace AplWfa_Twitch
{
    partial class frmOpcoes
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
            this.txtTwitchid = new System.Windows.Forms.TextBox();
            this.trkVolume = new System.Windows.Forms.TrackBar();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnSpain = new System.Windows.Forms.Button();
            this.btnUsa = new System.Windows.Forms.Button();
            this.btnBrazil = new System.Windows.Forms.Button();
            this.lblIdioma = new System.Windows.Forms.PictureBox();
            this.lblVolume = new System.Windows.Forms.PictureBox();
            this.pcbTwitchid = new System.Windows.Forms.PictureBox();
            this.pcbTituloOpcoes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trkVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblIdioma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTwitchid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTituloOpcoes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTwitchid
            // 
            this.txtTwitchid.Font = new System.Drawing.Font("Burbank Big Cd Bd", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTwitchid.Location = new System.Drawing.Point(424, 198);
            this.txtTwitchid.Name = "txtTwitchid";
            this.txtTwitchid.Size = new System.Drawing.Size(698, 54);
            this.txtTwitchid.TabIndex = 2;
            this.txtTwitchid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkVolume
            // 
            this.trkVolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trkVolume.Location = new System.Drawing.Point(424, 335);
            this.trkVolume.Maximum = 100;
            this.trkVolume.Name = "trkVolume";
            this.trkVolume.Size = new System.Drawing.Size(698, 45);
            this.trkVolume.SmallChange = 50;
            this.trkVolume.TabIndex = 4;
            this.trkVolume.TabStop = false;
            this.trkVolume.TickFrequency = 0;
            this.trkVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkVolume.Value = 100;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::AplWfa_Twitch.Properties.Resources.btnVoltar;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(1119, 655);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(143, 47);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.button1_Click);
            this.btnVoltar.MouseLeave += new System.EventHandler(this.mouseOUTvoltar);
            this.btnVoltar.MouseHover += new System.EventHandler(this.mouseINvoltar);
            // 
            // btnAplicar
            // 
            this.btnAplicar.BackgroundImage = global::AplWfa_Twitch.Properties.Resources.btnAplicar;
            this.btnAplicar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAplicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAplicar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAplicar.FlatAppearance.BorderSize = 0;
            this.btnAplicar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAplicar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicar.Location = new System.Drawing.Point(784, 551);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(182, 62);
            this.btnAplicar.TabIndex = 10;
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            this.btnAplicar.MouseLeave += new System.EventHandler(this.mouseOUTaplicar);
            this.btnAplicar.MouseHover += new System.EventHandler(this.mouseINaplicar);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.BackgroundImage = global::AplWfa_Twitch.Properties.Resources.btnRestaurar;
            this.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Location = new System.Drawing.Point(496, 551);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(182, 62);
            this.btnRestaurar.TabIndex = 9;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            this.btnRestaurar.MouseLeave += new System.EventHandler(this.mouseOUTrestaurar);
            this.btnRestaurar.MouseHover += new System.EventHandler(this.mouseINrestaurar);
            // 
            // btnSpain
            // 
            this.btnSpain.BackgroundImage = global::AplWfa_Twitch.Properties.Resources.btnSpainOFF;
            this.btnSpain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpain.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnSpain.FlatAppearance.BorderSize = 0;
            this.btnSpain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnSpain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnSpain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpain.Location = new System.Drawing.Point(910, 411);
            this.btnSpain.Name = "btnSpain";
            this.btnSpain.Size = new System.Drawing.Size(101, 72);
            this.btnSpain.TabIndex = 8;
            this.btnSpain.UseVisualStyleBackColor = true;
            this.btnSpain.Click += new System.EventHandler(this.mouseSelecSpain);
            // 
            // btnUsa
            // 
            this.btnUsa.BackgroundImage = global::AplWfa_Twitch.Properties.Resources.btnUsaOFF;
            this.btnUsa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnUsa.FlatAppearance.BorderSize = 0;
            this.btnUsa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnUsa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnUsa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsa.Location = new System.Drawing.Point(696, 411);
            this.btnUsa.Name = "btnUsa";
            this.btnUsa.Size = new System.Drawing.Size(101, 72);
            this.btnUsa.TabIndex = 7;
            this.btnUsa.UseVisualStyleBackColor = true;
            this.btnUsa.Click += new System.EventHandler(this.mouseSelecUsa);
            // 
            // btnBrazil
            // 
            this.btnBrazil.BackgroundImage = global::AplWfa_Twitch.Properties.Resources.btnBrazilOFF;
            this.btnBrazil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrazil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrazil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnBrazil.FlatAppearance.BorderSize = 0;
            this.btnBrazil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnBrazil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnBrazil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrazil.Location = new System.Drawing.Point(473, 411);
            this.btnBrazil.Name = "btnBrazil";
            this.btnBrazil.Size = new System.Drawing.Size(101, 72);
            this.btnBrazil.TabIndex = 6;
            this.btnBrazil.UseVisualStyleBackColor = true;
            this.btnBrazil.Click += new System.EventHandler(this.mouseSelecBrazil);
            // 
            // lblIdioma
            // 
            this.lblIdioma.Image = global::AplWfa_Twitch.Properties.Resources.lblIdioma;
            this.lblIdioma.Location = new System.Drawing.Point(186, 419);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(185, 61);
            this.lblIdioma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lblIdioma.TabIndex = 5;
            this.lblIdioma.TabStop = false;
            // 
            // lblVolume
            // 
            this.lblVolume.Image = global::AplWfa_Twitch.Properties.Resources.lblVolume;
            this.lblVolume.Location = new System.Drawing.Point(165, 307);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(206, 61);
            this.lblVolume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lblVolume.TabIndex = 3;
            this.lblVolume.TabStop = false;
            // 
            // pcbTwitchid
            // 
            this.pcbTwitchid.Image = global::AplWfa_Twitch.Properties.Resources.lblTwitchid;
            this.pcbTwitchid.Location = new System.Drawing.Point(128, 191);
            this.pcbTwitchid.Name = "pcbTwitchid";
            this.pcbTwitchid.Size = new System.Drawing.Size(243, 61);
            this.pcbTwitchid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbTwitchid.TabIndex = 1;
            this.pcbTwitchid.TabStop = false;
            // 
            // pcbTituloOpcoes
            // 
            this.pcbTituloOpcoes.Image = global::AplWfa_Twitch.Properties.Resources.TituloOpcoes;
            this.pcbTituloOpcoes.Location = new System.Drawing.Point(503, 26);
            this.pcbTituloOpcoes.Name = "pcbTituloOpcoes";
            this.pcbTituloOpcoes.Size = new System.Drawing.Size(274, 102);
            this.pcbTituloOpcoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbTituloOpcoes.TabIndex = 0;
            this.pcbTituloOpcoes.TabStop = false;
            // 
            // frmOpcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnSpain);
            this.Controls.Add(this.btnUsa);
            this.Controls.Add(this.btnBrazil);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.trkVolume);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.txtTwitchid);
            this.Controls.Add(this.pcbTwitchid);
            this.Controls.Add(this.pcbTituloOpcoes);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOpcoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Twitch Game by Samuel";
            ((System.ComponentModel.ISupportInitialize)(this.trkVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblIdioma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTwitchid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTituloOpcoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbTituloOpcoes;
        private System.Windows.Forms.PictureBox pcbTwitchid;
        private System.Windows.Forms.TextBox txtTwitchid;
        private System.Windows.Forms.PictureBox lblVolume;
        private System.Windows.Forms.TrackBar trkVolume;
        private System.Windows.Forms.PictureBox lblIdioma;
        private System.Windows.Forms.Button btnBrazil;
        private System.Windows.Forms.Button btnUsa;
        private System.Windows.Forms.Button btnSpain;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnVoltar;
    }
}