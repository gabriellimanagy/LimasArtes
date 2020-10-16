using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimasArtes.Classes.CRUD.Categoria
{
    class CategoriaBusiness
    {
        CategoriaDatabase db = new CategoriaDatabase();
        public int Salvar(CategoriaDTO categoriaDTO)
        {
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
