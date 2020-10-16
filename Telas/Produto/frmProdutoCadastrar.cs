using LimasArtes.Classes.Cliente;
using LimasArtes.Classes.CRUD.Categoria;
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
    public partial class frmProdutoCadastrar : Form
    {
        public frmProdutoCadastrar()
        {
            InitializeComponent();
            CarregarCombo();
        }

        public void CarregarCombo()
        {
            CategoriaBusiness business = new CategoriaBusiness();
            List<CategoriaDTO> listCategoriaDTO = business.Listar();

            cboCategoria.ValueMember = nameof(CategoriaDTO.ID_Categoria);
            cboCategoria.DisplayMember = nameof(CategoriaDTO.Categoria);
            cboCategoria.DataSource = listCategoriaDTO;
        }

        private void btnCONFIRMAR_Click(object sender, EventArgs e)
        {
            ProdutoDTO produtoDTO = new ProdutoDTO
            {
                Produto = txtNome.Text,
                Vl_Unitario = Convert.ToDecimal(txtVLUnitario.Text),
                // FK_Categoria = (Colocar após configurar a combo box
                Observacao = txtObs.Text
            };
        }

        private void txtVLUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
