using LimasArtes.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimasArtes.Classes.Cliente
{
    public class FuncionarioDatabase
    {
        public int Salvar(FuncionarioDTO funcionarioDTO)
        {
            string script =
            @"INSERT INTO 
            TB_FUNCIONARIO ( DS_USUARIO,  DS_SENHA,  DS_FUNCIONARIO,  DS_EMAIL,  DS_CELULAR,  DS_TELEFONE,  DT_CADASTRO,  FK_PERMISSAO)
            VALUES         (@DS_USUARIO, @DS_SENHA, @DS_FUNCIONARIO, @DS_EMAIL, @DS_CELULAR, @DS_TELEFONE, @DT_CADASTRO, @FK_PERMISSAO)";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            parms.Add(new MySqlParameter("DS_USUARIO"       , funcionarioDTO.Usuario));
            parms.Add(new MySqlParameter("DS_SENHA"         , funcionarioDTO.Senha));
            parms.Add(new MySqlParameter("DS_FUNCIONARIO"   , funcionarioDTO.Funcionario));
            parms.Add(new MySqlParameter("DS_EMAIL"         , funcionarioDTO.Email));
            parms.Add(new MySqlParameter("DS_CELULAR"       , funcionarioDTO.Celular));
            parms.Add(new MySqlParameter("DS_TELEFONE"      , funcionarioDTO.Telefone));
            parms.Add(new MySqlParameter("DT_CADASTRO"      , funcionarioDTO.Dt_Cadastro));
            parms.Add(new MySqlParameter("FK_PERMISSAO"     , funcionarioDTO.FK_Permissao));


            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPK(script, parms);
            return pk;

        }

        public void Alterar(FuncionarioDTO funcionarioDTO)
        {
            string script =
                @"UPDATE TB_FUNCIONARIO 
                  SET    
                     DS_USUARIO     = @DS_USUARIO,
                     DS_SENHA       = @DS_SENHA,
                     DS_FUNCIONARIO = @DS_FUNCIONARIO,
                     DS_EMAIL       = @DS_EMAIL,
                     DS_CELULAR     = @DS_CELULAR,
                     DS_TELEFONE    = @DS_TELEFONE,
                     DT_CADASTRO    = @DT_CADASTRO,
                     FK_PERMISSAO   = @FK_PERMISSAO

                  WHERE ID_FUNCIONARIO = @ID_FUNCIONARIO";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            parms.Add(new MySqlParameter("ID_FUNCIONARIO"   , funcionarioDTO.ID_Funcionario));
            parms.Add(new MySqlParameter("DS_USUARIO"       , funcionarioDTO.Usuario));
            parms.Add(new MySqlParameter("DS_SENHA"         , funcionarioDTO.Senha));
            parms.Add(new MySqlParameter("DS_FUNCIONARIO"   , funcionarioDTO.Funcionario));
            parms.Add(new MySqlParameter("DS_EMAIL"         , funcionarioDTO.Email));
            parms.Add(new MySqlParameter("DS_CELULAR"       , funcionarioDTO.Celular));
            parms.Add(new MySqlParameter("DS_TELEFONE"      , funcionarioDTO.Telefone));
            parms.Add(new MySqlParameter("DT_CADASTRO"      , funcionarioDTO.Dt_Cadastro));
            parms.Add(new MySqlParameter("FK_PERMISSAO"     , funcionarioDTO.FK_Permissao));
            


            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public void Remover(int ID)
        {
            string script =
                @"DELETE FROM TB_FUNCIONARIO WHERE ID_FUNCIONARIO = @ID_FUNCIONARIO";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            parms.Add(new MySqlParameter("ID_FUNCIONARIO", ID));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public List<FuncionarioDTO> Listar()
        {
            string script =
                @"SELECT * FROM TB_FUNCIONARIO";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<FuncionarioDTO> lstFuncionarioDTO = new List<FuncionarioDTO>();
            while (reader.Read())
            {
                FuncionarioDTO funcionarioDTO   = new FuncionarioDTO();
                funcionarioDTO.Usuario          = reader.GetString("DS_USUARIO");
                funcionarioDTO.Senha            = reader.GetString("DS_SENHA");
                funcionarioDTO.Funcionario      = reader.GetString("DS_FUNCIONARIO");
                funcionarioDTO.Email            = reader.GetString("DS_EMAIL");
                funcionarioDTO.Celular          = reader.GetString("DS_CELULAR");
                funcionarioDTO.Telefone         = reader.GetString("DS_TELEFONE");
                funcionarioDTO.Dt_Cadastro      = reader.GetDateTime("DT_CADASTRP");
                funcionarioDTO.FK_Permissao     = reader.GetString("FK_PERMISSAO");

                lstFuncionarioDTO.Add(funcionarioDTO);
            }
            reader.Close();

            return lstFuncionarioDTO;
        }
    }
}
