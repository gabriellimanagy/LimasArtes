using LimasArtes.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimasArtes.Classes.Cliente
{
    public class PedidoDatabase
    {
        public int Salvar(PedidoDTO pedidoDTO)
        {
            string script =
            @"INSERT INTO 
            TB_PEDIDO (  VL_PEDIDO,  OBS_PEDIDO,  DT_PEDIDO,  FK_FUNCIONARIO,  FK_CLIENTE)
            VALUES     (@VL_PEDIDO, @OBS_PEDIDO, @DT_PEDIDO, @FK_FUNCIONARIO, @FK_CLIENTE)";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            parms.Add(new MySqlParameter("VL_PEDIDO"        , pedidoDTO.Vl_Pedido));
            parms.Add(new MySqlParameter("OBS_PEDIDO"       , pedidoDTO.Observacao));
            parms.Add(new MySqlParameter("DT_PEDIDO"        , pedidoDTO.Dt_Pedido));
            parms.Add(new MySqlParameter("FK_FUNCIONARIO"   , pedidoDTO.FK_Funcionario));
            parms.Add(new MySqlParameter("FK_CLIENTE"       , pedidoDTO.FK_Cliente));


            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPK(script, parms);
            return pk;

        }

        public void Alterar(PedidoDTO pedidoDTO)
        {
            string script =
                @"UPDATE TB_PEDIDO 
                  SET    
                     VL_PEDIDO      = @VL_PEDIDO,
                     OBS_PEDIDO     = @OBS_PEDIDO,
                     DT_PEDIDO      = @DT_PEDIDO,
                     FK_FUNCIONARIO = @FK_FUNCIONARIO,
                     FK_CLIENTE     = @FK_CLIENTE
                     
                  WHERE ID_PRODUTO = @ID_PRODUTO";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            parms.Add(new MySqlParameter("ID_PEDIDO", pedidoDTO.ID_Pedido));
            parms.Add(new MySqlParameter("VL_PEDIDO", pedidoDTO.Vl_Pedido));
            parms.Add(new MySqlParameter("OBS_PEDIDO", pedidoDTO.Observacao));
            parms.Add(new MySqlParameter("DT_PEDIDO", pedidoDTO.Dt_Pedido));
            parms.Add(new MySqlParameter("FK_FUNCIONARIO", pedidoDTO.FK_Funcionario));
            parms.Add(new MySqlParameter("FK_CLIENTE", pedidoDTO.FK_Cliente)); ;

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public void Remover(int ID)
        {
            string script =
                @"DELETE FROM TB_PEDIDO WHERE ID_PEDIDO = @ID_PEDIDO";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            parms.Add(new MySqlParameter("ID_PEDIDO", ID));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public List<PedidoDTO> Listar()
        {
            string script =
                @"SELECT * FROM TB_PEDIDO";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<PedidoDTO> lstPedidoDTO = new List<PedidoDTO>();
            while (reader.Read())
            {
                PedidoDTO pedidoDTO = new PedidoDTO();
                pedidoDTO.ID_Pedido         = reader.GetInt32("ID_PEDIDO");
                pedidoDTO.Vl_Pedido         = reader.GetDecimal("VL_PEDIDO");
                pedidoDTO.Observacao        = reader.GetString("OBS_PEDIDO");
                pedidoDTO.Dt_Pedido         = reader.GetDateTime("DT_PEDIDO");
                pedidoDTO.FK_Funcionario    = reader.GetInt32("FK_FUNCIONARIO");
                pedidoDTO.FK_Cliente        = reader.GetInt32("FK_CLIENTE");

                lstPedidoDTO.Add(pedidoDTO);
            }
            reader.Close();

            return lstPedidoDTO;
        }
    }
}
