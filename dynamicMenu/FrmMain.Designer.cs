namespace dynamicMenu
{
    partial class FrmMain
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
            this.pMenuLateral = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pLogo = new System.Windows.Forms.Panel();
            this.pRodape = new System.Windows.Forms.Panel();
            this.pOpcoes = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pMenuLateral.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.pRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMenuLateral
            // 
            this.pMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.pMenuLateral.Controls.Add(this.pOpcoes);
            this.pMenuLateral.Controls.Add(this.pRodape);
            this.pMenuLateral.Controls.Add(this.pLogo);
            this.pMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.pMenuLateral.Name = "pMenuLateral";
            this.pMenuLateral.Size = new System.Drawing.Size(227, 543);
            this.pMenuLateral.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.pbClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(227, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 31);
            this.panel1.TabIndex = 2;
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.pbClose.Image = global::dynamicMenu.Properties.Resources.power_24x24;
            this.pbClose.Location = new System.Drawing.Point(659, 3);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(25, 25);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 0;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // pLogo
            // 
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(227, 94);
            this.pLogo.TabIndex = 0;
            // 
            // pRodape
            // 
            this.pRodape.Controls.Add(this.label1);
            this.pRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pRodape.Location = new System.Drawing.Point(0, 498);
            this.pRodape.Name = "pRodape";
            this.pRodape.Size = new System.Drawing.Size(227, 45);
            this.pRodape.TabIndex = 1;
            // 
            // pOpcoes
            // 
            this.pOpcoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pOpcoes.Location = new System.Drawing.Point(0, 94);
            this.pOpcoes.Name = "pOpcoes";
            this.pOpcoes.Size = new System.Drawing.Size(227, 404);
            this.pOpcoes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.label1.Location = new System.Drawing.Point(0, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desenvolvido por Gabriel Monteiro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 543);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pMenuLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pMenuLateral.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.pRodape.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pMenuLateral;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Panel pOpcoes;
        private System.Windows.Forms.Panel pRodape;
        private System.Windows.Forms.Panel pLogo;
        private System.Windows.Forms.Label label1;
    }
}

