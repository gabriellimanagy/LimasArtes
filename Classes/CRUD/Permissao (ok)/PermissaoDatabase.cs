using LimasArtes.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimasArtes.Classes.Cliente
{
    public class PermissaoDatabase
    {
        public int Salvar(PermissaoDTO permissaoDTO)
        {
            string script =
            @"INSERT INTO 
            TB_PERMISSAO ( DS_PERMISSAO,  DT_CADASTRO)
            VALUES       (@DS_PERMISSAO, @DT_CADASTRO)";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            parms.Add(new MySqlParameter("DS_PERMISSAO", permissaoDTO.Permissao));
            parms.Add(new MySqlParameter("DT_CADASTRO" , permissaoDTO.Dt_Cadastro));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPK(script, parms);
            return pk;

        }

        public void Alterar(PermissaoDTO permissaoDTO)
        {
            string script =
                @"UPDATE TB_PERMISSAO 
                  SET    
                     DS_PERMISSAO   = @DS_PERMISSAO,
                     DT_CADASTRO    = @DT_CADASTRO,
                     
                  WHERE ID_PERMISSAO = @ID_PERMISSAO";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            parms.Add(new MySqlParameter("ID_PERMISSAO" , permissaoDTO.ID_Permissao));
            parms.Add(new MySqlParameter("DS_PERMISSAO" , permissaoDTO.Permissao));
            parms.Add(new MySqlParameter("DT_CADASTRO"  , permissaoDTO.Dt_Cadastro));
            
            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public void Remover(int ID)
        {
            string script =
                @"DELETE FROM TB_PRODUTO WHERE ID_PERMISSAO = @ID_PERMISSAO";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            parms.Add(new MySqlParameter("ID_PERMISSAO", ID));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public List<PermissaoDTO> Listar()
        {
            string script =
                @"SELECT * FROM TB_PERMISSAO";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<PermissaoDTO> lstPermissaoDTO = new List<PermissaoDTO>();
            while (reader.Read())
            {
                PermissaoDTO permissaoDTO = new PermissaoDTO();
                permissaoDTO.ID_Permissao   = reader.GetString("ID_PERMISSAO");
                permissaoDTO.Permissao      = reader.GetString("DS_PERMISSAO");
                permissaoDTO.Dt_Cadastro    = reader.GetDateTime("DT_CADASTRO");

                lstPermissaoDTO.Add(permissaoDTO);
            }
            reader.Close();

            return lstPermissaoDTO;
        }
    }
}
