using LimasArtes.Classes.CRUD.Categoria;
using LimasArtes.Classes.Tools;
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
        public string Resposta { get; set; }
        public int ID { get; set; }

        MessageBoxInteligente Mbox = new MessageBoxInteligente();
        CategoriaBusiness business = new CategoriaBusiness();

        private void btnCONFIRMAR_Click(object sender, EventArgs e)
        {
            
            CategoriaDTO categoriaDTO = new CategoriaDTO
            {
                Categoria = txtNome.Text
            };
            try
            {
                if (Resposta == "Sem alterações")
                {
                    categoriaDTO.ID_Categoria = ID;
                }
                if (ID > 0)
                {
                    business.Alterar(categoriaDTO);

                    string mensagem = "Alterado com sucesso";
                    Mbox.Info(mensagem);

                    Resposta = "Alterado";
                    Close();
                }
                _ = business.Salvar(categoriaDTO);
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
      
        public void Alterar(CategoriaDTO categoriaDTO)
        {
            CarregarCategoria(categoriaDTO);
            Resposta = "Sem alterações";
        }

        public void Zoom(CategoriaDTO categoriaDTO)
        {
            CarregarCategoria(categoriaDTO);
            txtNome.ReadOnly = true;
            btnCONFIRMAR.Enabled = false;
        }

        private void CarregarCategoria(CategoriaDTO categoriaDTO)
        {
            ID = categoriaDTO.ID_Categoria;
            lblID.Text = "ID: " + Convert.ToString(ID);
        }
    }
}
