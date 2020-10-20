using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimasArtes.Classes.Cliente
{
    public class ProdutoBusiness
    {
        ProdutoDatabase db = new ProdutoDatabase();
        public int Salvar(ProdutoDTO produtoDTO)
        {
            int id = db.Salvar(produtoDTO);
            return id;
        }
        public void Alterar(ProdutoDTO produtoDTO)
        {
            db.Alterar(produtoDTO);
        }

        public void Remover(int produtoDTO)
        {
            db.Remover(produtoDTO); 
        }

        public List<ProdutoDTO> Listar()
        {
            List<ProdutoDTO> produtoDTO = db.Listar();
            return produtoDTO;
        }
    }
}
