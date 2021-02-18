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
        public void Alterar(CategoriaDTO categoriaDTO)
        {
            string script =
                @"UPDATE TB_CATEGORIA 
                SET    
                    DS_CATEGORIA   = @DS_CATEGORIA,
                WHERE ID_CATEGORIA = @ID_CATEGORIA";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            parms.Add(new MySqlParameter("ID_CATEGORIA", categoriaDTO.ID_Categoria));
            parms.Add(new MySqlParameter("DS_CATEGORIA", categoriaDTO.Categoria));
           
            db.ExecuteInsertScript(script, parms);
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
                categoriaDTO.ID_Categoria = reader.GetInt32("ID_CATEGORIA");
                categoriaDTO.Categoria = reader.GetString("DS_CATEGORIA");
                lstCategoriaDTO.Add(categoriaDTO);
            }
            reader.Close();

            return lstCategoriaDTO;
            
        }
        public void Remover(int ID)
        {
            string script =
                @"DELETE FROM TB_CATEGORIA WHERE ID_CATEGORIA = @ID_CATEGORIA";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            parms.Add(new MySqlParameter("ID_CATEGORIA", ID));

            db.ExecuteInsertScript(script, parms);
        }
        public CategoriaDTO Consultar_ID(int ID)
        {

            string script =
                @"SELECT * FROM TB_CATEGORIA WHERE ID_CATEGORIA = @ID_CATEGORIA";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("ID_CATEGORIA", ID));

            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            CategoriaDTO categoriaDTO = new CategoriaDTO();

            while (reader.Read())
            {
                categoriaDTO.ID_Categoria = reader.GetInt32("ID_CATEGORIA");
                categoriaDTO.Categoria = reader.GetString("DS_CATEGORIA");
            }
            return categoriaDTO;
        }

        public List<CategoriaDTO> Consultar(string argumentoBusca)
        {

            string script =
                @"SELECT * FROM TB_CATEGORIA WHERE DS_CATEGORIA LIKE @DS_CATEGORIA" + "%";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("DS_CATEGORIA", argumentoBusca));

            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<CategoriaDTO> lstCategoriaDTO = new List<CategoriaDTO>();
            while (reader.Read())
            {
                CategoriaDTO categoriaDTO = new CategoriaDTO();
                categoriaDTO.ID_Categoria = reader.GetInt32("ID_CATEGORIA");
                categoriaDTO.Categoria = reader.GetString("DS_CATEGORIA");
                lstCategoriaDTO.Add(categoriaDTO);
            }
            reader.Close();

            return lstCategoriaDTO;
        }
    }
}
