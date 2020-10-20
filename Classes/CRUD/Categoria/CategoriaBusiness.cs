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

        public List<CategoriaDTO> Listar()
        {
            List<CategoriaDTO> listCategoriaDTO = db.Listar();
            return listCategoriaDTO;
        }
    }
}
