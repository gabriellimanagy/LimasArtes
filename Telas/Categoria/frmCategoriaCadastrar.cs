using LimasArtes.Classes.CRUD.Categoria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimasArtes.Telas.Categoria
{
    public partial class frmCategoriaCadastrar : Form
    {
        public frmCategoriaCadastrar()
        {
            InitializeComponent();
        }
        
        private void btnCONFIRMAR_Click(object sender, EventArgs e)
        {
            CategoriaBusiness business = new CategoriaBusiness();
            
            CategoriaDTO categoriaDTO = new CategoriaDTO
            {
                Categoria = txtNome.Text
            };
            try
            {
                _ = business.Salvar(categoriaDTO);
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }
            

            
        }
    }
}
