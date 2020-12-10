namespace AplWfa_Twitch
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnSair = new System.Windows.Forms.Button();
            this.btnOpcoes = new System.Windows.Forms.Button();
            this.btnJogar = new System.Windows.Forms.Button();
            this.pcbTitulo = new System.Windows.Forms.PictureBox();
            this.imglistMenu = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::AplWfa_Twitch.Properties.Resources.btnSair;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(643, 622);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(421, 119);
            this.btnSair.TabIndex = 6;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            this.btnSair.MouseLeave += new System.EventHandler(this.mouseOUTsair);
            this.btnSair.MouseHover += new System.EventHandler(this.mouseINsair);
            // 
            // btnOpcoes
            // 
            this.btnOpcoes.BackgroundImage = global::AplWfa_Twitch.Properties.Resources.btnSettings;
            this.btnOpcoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpcoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpcoes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnOpcoes.FlatAppearance.BorderSize = 0;
            this.btnOpcoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnOpcoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnOpcoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpcoes.Location = new System.Drawing.Point(643, 448);
            this.btnOpcoes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpcoes.Name = "btnOpcoes";
            this.btnOpcoes.Size = new System.Drawing.Size(421, 119);
            this.btnOpcoes.TabIndex = 5;
            this.btnOpcoes.UseVisualStyleBackColor = true;
            this.btnOpcoes.Click += new System.EventHandler(this.btnOpcoes_Click);
            this.btnOpcoes.MouseLeave += new System.EventHandler(this.mouseOUTopcoes);
            this.btnOpcoes.MouseHover += new System.EventHandler(this.mouseINopcoes);
            // 
            // btnJogar
            // 
            this.btnJogar.BackgroundImage = global::AplWfa_Twitch.Properties.Resources.btnJogar;
            this.btnJogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJogar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnJogar.FlatAppearance.BorderSize = 0;
            this.btnJogar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnJogar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJogar.Location = new System.Drawing.Point(643, 283);
            this.btnJogar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(421, 119);
            this.btnJogar.TabIndex = 4;
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            this.btnJogar.MouseLeave += new System.EventHandler(this.mouseOUTjogar);
            this.btnJogar.MouseHover += new System.EventHandler(this.mouseINjogar);
            // 
            // pcbTitulo
            // 
            this.pcbTitulo.Image = global::AplWfa_Twitch.Properties.Resources.TituloMenu;
            this.pcbTitulo.Location = new System.Drawing.Point(375, 39);
            this.pcbTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbTitulo.Name = "pcbTitulo";
            this.pcbTitulo.Size = new System.Drawing.Size(968, 164);
            this.pcbTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbTitulo.TabIndex = 0;
            this.pcbTitulo.TabStop = false;
            // 
            // imglistMenu
            // 
            this.imglistMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistMenu.ImageStream")));
            this.imglistMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imglistMenu.Images.SetKeyName(0, "btnJogar.png");
            this.imglistMenu.Images.SetKeyName(1, "btnJogarHover.png");
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1707, 886);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnOpcoes);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.pcbTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1707, 886);
            this.MinimumSize = new System.Drawing.Size(1707, 886);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Twitch Game";
            ((System.ComponentModel.ISupportInitialize)(this.pcbTitulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbTitulo;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnOpcoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ImageList imglistMenu;
    }
}

