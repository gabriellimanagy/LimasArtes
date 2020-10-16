namespace LimasArtes
{
    partial class frmSPLASH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSPLASH));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmrPROGRESS = new System.Windows.Forms.Timer(this.components);
            this.progressSPLASH = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-47, -34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(586, 521);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tmrPROGRESS
            // 
            this.tmrPROGRESS.Enabled = true;
            this.tmrPROGRESS.Tick += new System.EventHandler(this.tmrPROGRESS_Tick);
            // 
            // progressSPLASH
            // 
            this.progressSPLASH.Location = new System.Drawing.Point(7, 437);
            this.progressSPLASH.Name = "progressSPLASH";
            this.progressSPLASH.Size = new System.Drawing.Size(481, 27);
            this.progressSPLASH.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressSPLASH.TabIndex = 2;
            this.progressSPLASH.UseWaitCursor = true;
            // 
            // frmSPLASH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 471);
            this.Controls.Add(this.progressSPLASH);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSPLASH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tmrPROGRESS;
        private System.Windows.Forms.ProgressBar progressSPLASH;
    }
}

