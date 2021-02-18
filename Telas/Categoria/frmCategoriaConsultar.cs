using LimasArtes.Classes.CRUD.Categoria;
using LimasArtes.Classes.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimasArtes.Telas.Categoria
{
    public partial class frmCategoriaConsultar : Form
    {
        public frmCategoriaConsultar()
        {
            InitializeComponent();

            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add("Cadastrar");
            menu.Items.Add("Zoom");
            ContextMenuStrip = menu;
            menu.ItemClicked += new ToolStripItemClickedEventHandler(menu_ItemClicked);
        }

        CategoriaBusiness categoriaBusiness = new CategoriaBusiness();
        private readonly MessageBoxInteligente Mbox = new MessageBoxInteligente();
 

        private int selectedRowIndex { get; set; }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (txtConsulta.Text == string.Empty)
            {
                Listar();
            }
            else
            {
                Consultar();
            }
            //   #PRECISA# - Menu de contexto - integrar

        }
        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Cadastrar")
            {
                frmCategoriaCadastrar tela = new frmCategoriaCadastrar();

                tela.Show();
                Listar();
            }
            else if (e.ClickedItem.Text == "Zoom")
            {
                Zoom();
            }
        }
        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
            if (e.ColumnIndex == 5 && selectedRowIndex >= 0)
            {
                Excluir();
                Listar();
            }

            if (e.ColumnIndex == 4 && selectedRowIndex >= 0)
            {
                Alterar();
            }
        }

        #region Métodos
        private void Consultar()
        {
            string argumentoBusca = txtConsulta.Text;

            List<CategoriaDTO> categoriaDTO = categoriaBusiness.Consultar(argumentoBusca);

            dgvCategoria.AutoGenerateColumns = false;
            dgvCategoria.DataSource = categoriaDTO;
        }
        private void Listar()
        {
            List<CategoriaDTO> categoriaDTO = categoriaBusiness.Listar();

            dgvCategoria.AutoGenerateColumns = false;
            dgvCategoria.DataSource = categoriaDTO;
        }

        private void Alterar()
        {
            CategoriaDTO categoriaDTO = dgvCategoria.Rows[selectedRowIndex].DataBoundItem as CategoriaDTO;
            frmCategoriaCadastrar tela = new frmCategoriaCadastrar();

            tela.Alterar(categoriaDTO);
            tela.Show();

            string resposta = tela.Resposta;

            if (resposta == "Alterado")
            {
                CategoriaDTO categoriaATU = categoriaBusiness.Consultar_ID(categoriaDTO.ID_Categoria);

                _ = new DataGridViewRow();
                DataGridViewRow row = dgvCategoria.Rows[selectedRowIndex];

                row.Cells[1].Value = categoriaATU.Categoria;

                dgvCategoria.Refresh();
            }
        }
       
        private void Excluir()
        {
            CategoriaDTO categoriaDTO = dgvCategoria.Rows[selectedRowIndex].DataBoundItem as CategoriaDTO;

            DialogResult result = MessageBox.Show("Deseja excluir este cadastro?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                categoriaBusiness.Remover(categoriaDTO.ID_Categoria);
                Mbox.Info("Cadastro excluido com sucesso");
            }
            else if (result == DialogResult.Cancel)
            {
                Mbox.Info("O cadastro: " + categoriaDTO.Categoria + " não foi excluido!");
            }
        }
        private void Zoom()
        {
            CategoriaDTO categoriaDTO = dgvCategoria.Rows[selectedRowIndex].DataBoundItem as CategoriaDTO;
            frmCategoriaCadastrar tela = new frmCategoriaCadastrar();

            tela.Zoom(categoriaDTO);
            tela.Show();
        }

        #endregion

        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
