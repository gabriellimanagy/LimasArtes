using LimasArtes.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimasArtes.Classes.CRUD.Categoria
{
    public class CategoriaDatabase
    {
        Database db = new Database();
        public int Salvar(CategoriaDTO categoriaDTO)
        {
            string script = @"INSERT INTO 
                            TB_CATEGORIA (DS_CATEGORIA)
                            VALUES      (@DS_CATEGORIA)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("@DS_CATEGORIA", categoriaDTO.Categoria));

            int id = db.ExecuteInsertScriptWithPK(script, parms);

            return id;
        }
        public List<CategoriaDTO> Listar()
        {
            string script = @"SELECT
                              * 
                              FROM TB_CATEGORIA";
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<CategoriaDTO> lstCategoriaDTO = new List<CategoriaDTO>();
            while (reader.Read())
            {
                CategoriaDTO categoriaDTO = new CategoriaDTO();
                categoriaDTO.ID_Categoria = reader.GetInt32("ID_PRODUTO");
                categoriaDTO.Categoria = reader.GetString("DS_CATEGORIA");
                lstCategoriaDTO.Add(categoriaDTO);
            }
            reader.Close();

            return lstCategoriaDTO;
            
        }
    }
}
