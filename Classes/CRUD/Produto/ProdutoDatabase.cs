using LimasArtes.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimasArtes.Classes.Cliente
{
    public class ProdutoDatabase
    {
        public int Salvar(ProdutoDTO produtoDTO)
        {
            string script =
            @"INSERT INTO 
            TB_PRODUTO ( DS_PRODUTO,  VL_UNITARIO,  OBS_PRODUTO,  DT_CADASTRO,  FK_CATEGORIA)
            VALUES     (@DS_PRODUTO, @VL_UNITARIO, @OBS_PRODUTO, @DT_CADASTRO, @FK_CATEGORIA)";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            parms.Add(new MySqlParameter("DS_PRODUTO"   , produtoDTO.Produto));
            parms.Add(new MySqlParameter("VL_UNITARIO"  , produtoDTO.Vl_Unitario));
            parms.Add(new MySqlParameter("OBS_PRODUTO"  , produtoDTO.Observacao));
            parms.Add(new MySqlParameter("DT_CADASTRO"  , produtoDTO.Dt_Cadastro));
            parms.Add(new MySqlParameter("FK_CATEGORIA" , produtoDTO.FK_Categoria));


            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPK(script, parms);
            return pk;

        }

        public void Alterar(ProdutoDTO produtoDTO)
        {
            string script =
                @"UPDATE TB_PRODUTO 
                  SET    
                     DS_PRODUTO   = @DS_PRODUTO,
                     VL_UNITARIO  = @VL_UNITARIO,
                     OBS_PRODUTO  = @OBS_PRODUTO,
                     DT_CADASTRO  = @DT_CADASTRO,
                     FK_CATEGORIA = @FK_CATEGORIA
                     
                  WHERE ID_PRODUTO = @ID_PRODUTO";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            parms.Add(new MySqlParameter("ID_PRODUTO"   , produtoDTO.ID_Produto));
            parms.Add(new MySqlParameter("DS_PRODUTO"   , produtoDTO.Produto));
            parms.Add(new MySqlParameter("VL_UNITARIO"  , produtoDTO.Vl_Unitario));
            parms.Add(new MySqlParameter("OBS_PRODUTO"  , produtoDTO.Observacao));
            parms.Add(new MySqlParameter("DT_CADASTRO"  , produtoDTO.Dt_Cadastro));
            parms.Add(new MySqlParameter("FK_CATEGORIA" , produtoDTO.FK_Categoria));



            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public void Remover(int ID)
        {
            string script =
                @"DELETE FROM TB_PRODUTO WHERE ID_PRODUTO = @ID_PRODUTO";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            parms.Add(new MySqlParameter("ID_PRODUTO", ID));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public List<ProdutoDTO> Listar()
        {
            string script =
                @"SELECT * FROM TB_PRODUTO";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<ProdutoDTO> lstProdutoDTO = new List<ProdutoDTO>();
            while (reader.Read())
            {
                ProdutoDTO produtoDTO = new ProdutoDTO();
                produtoDTO.ID_Produto   = reader.GetInt32("ID_PRODUTO");
                produtoDTO.Produto      = reader.GetString("DS_PRODUTO");
                produtoDTO.Vl_Unitario  = reader.GetDecimal("VL_UNITARIO");
                produtoDTO.Observacao   = reader.GetString("OBS_PRODUTO");
                produtoDTO.Dt_Cadastro  = reader.GetDateTime("DT_CADASTRO");
                produtoDTO.FK_Categoria = reader.GetInt32("FK_CATEGORIA");

                lstProdutoDTO.Add(produtoDTO);
            }
            reader.Close();

            return lstProdutoDTO;
        }
    }
}
