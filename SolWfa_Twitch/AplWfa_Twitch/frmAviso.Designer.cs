namespace AplWfa_Twitch
{
    partial class frmAviso
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
            this.btnNao = new System.Windows.Forms.Button();
            this.btnSim = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNao
            // 
            this.btnNao.BackgroundImage = global::AplWfa_Twitch.Properties.Resources.btnNao;
            this.btnNao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(138)))));
            this.btnNao.FlatAppearance.BorderSize = 0;
            this.btnNao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(138)))));
            this.btnNao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(138)))));
            this.btnNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNao.Location = new System.Drawing.Point(503, 266);
            this.btnNao.Name = "btnNao";
            this.btnNao.Size = new System.Drawing.Size(233, 85);
            this.btnNao.TabIndex = 2;
            this.btnNao.UseVisualStyleBackColor = true;
            this.btnNao.Click += new System.EventHandler(this.btnNao_Click);
            this.btnNao.MouseLeave += new System.EventHandler(this.mouseOUTnao);
            this.btnNao.MouseHover += new System.EventHandler(this.mouseINnao);
            // 
            // btnSim
            // 
            this.btnSim.BackgroundImage = global::AplWfa_Twitch.Properties.Resources.btnSim;
            this.btnSim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(138)))));
            this.btnSim.FlatAppearance.BorderSize = 0;
            this.btnSim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(138)))));
            this.btnSim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(138)))));
            this.btnSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSim.Location = new System.Drawing.Point(148, 266);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(233, 85);
            this.btnSim.TabIndex = 1;
            this.btnSim.UseVisualStyleBackColor = true;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            this.btnSim.MouseLeave += new System.EventHandler(this.mouseOUTsim);
            this.btnSim.MouseHover += new System.EventHandler(this.mouseINsim);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AplWfa_Twitch.Properties.Resources.MensagemAviso;
            this.pictureBox1.Location = new System.Drawing.Point(115, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(673, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmAviso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(902, 491);
            this.Controls.Add(this.btnNao);
            this.Controls.Add(this.btnSim);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAviso";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Twitch Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.Button btnNao;
    }
}