using LimasArtes.Telas;
using LimasArtes.Telas.Categoria;
using LimasArtes.Telas.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimasArtes
{
    public partial class frmHOME : Form
    {
        public frmHOME()
        {
            InitializeComponent();
            MenuStyle();
            KeyPreview = true;
        }

        private Form activeForm = null;

        #region Configuração Menu
        private void AbrirPanelInterno(Form childForm)
        {
            if (activeForm != null)
            activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBase.Controls.Add(childForm);
            panelBase.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void MenuStyle()
        {
            panelVisaoGeral.Visible = false;
            panelFinanceiro.Visible = false;
            panelCadastros.Visible = false;
            panelControles.Visible = false;
            panelRegistros.Visible = false;
        }
        
        private void EsconderSubMenu()
        {
            if (panelVisaoGeral.Visible == true)
                panelVisaoGeral.Visible = false;
            if (panelFinanceiro.Visible == true)
                panelFinanceiro.Visible = false;
            if (panelCadastros.Visible == true)
                panelCadastros.Visible = false;
            if (panelControles.Visible == true)
                panelControles.Visible = false;
            if (panelRegistros.Visible == true)
                panelRegistros.Visible = false;
        }
        

        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                EsconderSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;

        }
        #endregion

        #region Navegação
        private void btnVisaoGeral_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelVisaoGeral);
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelFinanceiro);
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelRegistros);
        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelCadastros);
        }

        private void btnConsultarClientes_Click(object sender, EventArgs e)
        {
            AbrirPanelInterno(new frmClienteConsultar());
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            AbrirPanelInterno(new frmCategoriaConsultar());

        }
        #endregion

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmHOME_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("Deseja encerrar o sistema?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes) 
                {
                    Application.Exit();
                }
            }
        }

    }
}
