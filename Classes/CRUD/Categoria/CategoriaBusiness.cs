using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimasArtes.Classes.CRUD.Categoria
{
    public class CategoriaBusiness
    {
        CategoriaDatabase db = new CategoriaDatabase();
        public int Salvar(CategoriaDTO categoriaDTO)
        {
            if (categoriaDTO.Categoria == string.Empty)
            {
                throw new ArgumentException("Dê um titulo a categoria");
            }

            int id = db.Salvar(categoriaDTO);
            return id;
        }
        public void Alterar(CategoriaDTO categoriaDTO)
        {
            if (categoriaDTO.Categoria == string.Empty)
            {
                throw new ArgumentException("Dê um titulo a categoria");
            }
            db.Alterar(categoriaDTO);
        }

        public void Remover(int idCategoria)
        {
            db.Remover(idCategoria);
        }
        public List<CategoriaDTO> Listar()
        {
            List<CategoriaDTO> listCategoriaDTO = db.Listar();
            return listCategoriaDTO;
        }

        public CategoriaDTO Consultar_ID(int ID)
        {
            CategoriaDTO categoriaDTO = db.Consultar_ID(ID);
            return categoriaDTO;
        }

        public List<CategoriaDTO> Consultar(string argumentoBusca)
        {
            List<CategoriaDTO> listCategoriaDTO = db.Consultar(argumentoBusca);
            return listCategoriaDTO;
        }
    }
}
