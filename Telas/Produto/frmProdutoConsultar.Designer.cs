﻿namespace LimasArtes.Telas.Produto
{
    partial class frmProdutoConsultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutoConsultar));
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.Column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Alterar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column_Excluir = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCONSULTAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCONSULTAR.Location = new System.Drawing.Point(441, 13);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(89, 26);
            this.btnCONSULTAR.TabIndex = 8;
            this.btnCONSULTAR.Text = "Consultar";
            this.btnCONSULTAR.UseVisualStyleBackColor = true;
            this.btnCONSULTAR.Click += new System.EventHandler(this.btnCONSULTAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome";
            // 
            // txtConsulta
            // 
            this.txtConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.Location = new System.Drawing.Point(83, 13);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(352, 26);
            this.txtConsulta.TabIndex = 6;
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.AllowUserToResizeColumns = false;
            this.dgvProduto.AllowUserToResizeRows = false;
            this.dgvProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduto.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_ID,
            this.Column_Cliente,
            this.Column_Celular,
            this.Column_Telefone,
            this.Column_Alterar,
            this.Column_Excluir});
            this.dgvProduto.Location = new System.Drawing.Point(12, 48);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.RowHeadersVisible = false;
            this.dgvProduto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProduto.Size = new System.Drawing.Size(927, 621);
            this.dgvProduto.TabIndex = 5;
            // 
            // Column_ID
            // 
            this.Column_ID.DataPropertyName = "ID_Cliente";
            this.Column_ID.HeaderText = "ID";
            this.Column_ID.Name = "Column_ID";
            this.Column_ID.ReadOnly = true;
            this.Column_ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_ID.Width = 50;
            // 
            // Column_Cliente
            // 
            this.Column_Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Cliente.DataPropertyName = "Nome_Cliente";
            this.Column_Cliente.HeaderText = "Nome";
            this.Column_Cliente.Name = "Column_Cliente";
            this.Column_Cliente.ReadOnly = true;
            this.Column_Cliente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column_Celular
            // 
            this.Column_Celular.DataPropertyName = "Celular";
            this.Column_Celular.HeaderText = "Celular";
            this.Column_Celular.Name = "Column_Celular";
            this.Column_Celular.ReadOnly = true;
            this.Column_Celular.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_Celular.Width = 130;
            // 
            // Column_Telefone
            // 
            this.Column_Telefone.DataPropertyName = "Telefone";
            this.Column_Telefone.HeaderText = "Telefone";
            this.Column_Telefone.Name = "Column_Telefone";
            this.Column_Telefone.ReadOnly = true;
            this.Column_Telefone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_Telefone.Width = 130;
            // 
            // Column_Alterar
            // 
            this.Column_Alterar.HeaderText = "";
            this.Column_Alterar.Image = global::LimasArtes.Properties.Resources.edit_50px;
            this.Column_Alterar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column_Alterar.Name = "Column_Alterar";
            this.Column_Alterar.ReadOnly = true;
            this.Column_Alterar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_Alterar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column_Alterar.Width = 25;
            // 
            // Column_Excluir
            // 
            this.Column_Excluir.HeaderText = "";
            this.Column_Excluir.Image = global::LimasArtes.Properties.Resources.remover;
            this.Column_Excluir.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column_Excluir.Name = "Column_Excluir";
            this.Column_Excluir.ReadOnly = true;
            this.Column_Excluir.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_Excluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column_Excluir.Width = 25;
            // 
            // frmProdutoConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 683);
            this.Controls.Add(this.btnCONSULTAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.dgvProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProdutoConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProdutoConsultar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Telefone;
        private System.Windows.Forms.DataGridViewImageColumn Column_Alterar;
        private System.Windows.Forms.DataGridViewImageColumn Column_Excluir;
    }
}