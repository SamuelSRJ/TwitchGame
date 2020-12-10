namespace AplWfa_Twitch
{
    partial class frmResultadoFinal
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
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.pcbStreamerGanhou = new System.Windows.Forms.PictureBox();
            this.pcbTituloResFinal = new System.Windows.Forms.PictureBox();
            this.pcbChatGanhou = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStreamerGanhou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTituloResFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbChatGanhou)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.BackgroundImage = global::AplWfa_Twitch.Properties.Resources.btnMenuPrincipal;
            this.btnMenuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuPrincipal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnMenuPrincipal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnMenuPrincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPrincipal.Location = new System.Drawing.Point(404, 496);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(473, 141);
            this.btnMenuPrincipal.TabIndex = 2;
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // pcbStreamerGanhou
            // 
            this.pcbStreamerGanhou.Image = global::AplWfa_Twitch.Properties.Resources.lblStreamerWin;
            this.pcbStreamerGanhou.Location = new System.Drawing.Point(327, 251);
            this.pcbStreamerGanhou.Name = "pcbStreamerGanhou";
            this.pcbStreamerGanhou.Size = new System.Drawing.Size(627, 143);
            this.pcbStreamerGanhou.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbStreamerGanhou.TabIndex = 1;
            this.pcbStreamerGanhou.TabStop = false;
            this.pcbStreamerGanhou.Visible = false;
            // 
            // pcbTituloResFinal
            // 
            this.pcbTituloResFinal.Image = global::AplWfa_Twitch.Properties.Resources.lblTituloResFinal;
            this.pcbTituloResFinal.Location = new System.Drawing.Point(241, 45);
            this.pcbTituloResFinal.Name = "pcbTituloResFinal";
            this.pcbTituloResFinal.Size = new System.Drawing.Size(798, 145);
            this.pcbTituloResFinal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbTituloResFinal.TabIndex = 0;
            this.pcbTituloResFinal.TabStop = false;
            // 
            // pcbChatGanhou
            // 
            this.pcbChatGanhou.Image = global::AplWfa_Twitch.Properties.Resources.lblChatWin;
            this.pcbChatGanhou.Location = new System.Drawing.Point(300, 251);
            this.pcbChatGanhou.Name = "pcbChatGanhou";
            this.pcbChatGanhou.Size = new System.Drawing.Size(681, 143);
            this.pcbChatGanhou.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbChatGanhou.TabIndex = 3;
            this.pcbChatGanhou.TabStop = false;
            this.pcbChatGanhou.Visible = false;
            // 
            // frmResultadoFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pcbChatGanhou);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.pcbStreamerGanhou);
            this.Controls.Add(this.pcbTituloResFinal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmResultadoFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Twitch Game by Samuel";
            ((System.ComponentModel.ISupportInitialize)(this.pcbStreamerGanhou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTituloResFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbChatGanhou)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbTituloResFinal;
        private System.Windows.Forms.PictureBox pcbStreamerGanhou;
        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.PictureBox pcbChatGanhou;
    }
}