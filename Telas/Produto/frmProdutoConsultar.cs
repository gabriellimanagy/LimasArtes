using LimasArtes.Classes.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimasArtes.Telas.Produto
{
    public partial class frmProdutoConsultar : Form
    {
        public frmProdutoConsultar()
        {
            InitializeComponent();

            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add("Cadastrar");
            menu.Items.Add("Zoom");
            menu.Items.Add("/-");
            menu.Items.Add("Gerenciar categorias");

            ContextMenuStrip = menu;

            menu.ItemClicked += new ToolStripItemClickedEventHandler(menu_ItemClicked);
        }

        private readonly frmProdutoCadastrar tela = new frmProdutoCadastrar();

        private int selectedRowIndex { get; set; }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Cadastrar")
            {
                tela.ShowDialog();
                Listar();
            }
            else if (e.ClickedItem.Text == "Zoom")
            {
                Zoom();
            }
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {

        }

        private void Listar()
        {
            ProdutoBusiness business = new ProdutoBusiness();

            List<ProdutoDTO> produtoDTO = business.Listar();

            dgvProduto.AutoGenerateColumns = false;
            dgvProduto.DataSource = produtoDTO;
        }

        private void Zoom()
        {
            ProdutoDTO cliente = dgvProduto.Rows[selectedRowIndex].DataBoundItem as ProdutoDTO;

            tela.Zoom(cliente);
            tela.ShowDialog();
        }
    }
}
