using LimasArtes.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimasArtes.Classes.Cliente
{
    public class ClienteDatabase
    {
        Database db = new Database();
        public int Salvar(ClienteDTO clienteDTO)
        {
            string script =
            @"INSERT INTO 
            TB_CLIENTE ( DS_CLIENTE,  DS_CELULAR,  DS_TELEFONE,  OBS_CLIENTE,  DT_CADASTRO)
            VALUES     (@DS_CLIENTE, @DS_CELULAR, @DS_TELEFONE, @OBS_CLIENTE, @DT_CADASTRO)";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            parms.Add(new MySqlParameter("DS_CLIENTE"   , clienteDTO.Nome_Cliente));
            parms.Add(new MySqlParameter("DS_CELULAR"   , clienteDTO.Celular));
            parms.Add(new MySqlParameter("DS_TELEFONE"  , clienteDTO.Telefone));
            parms.Add(new MySqlParameter("OBS_CLIENTE"  , clienteDTO.Observacao));
            parms.Add(new MySqlParameter("DT_CADASTRO"  , clienteDTO.Dt_Cadastro));
            
            int pk = db.ExecuteInsertScriptWithPK(script, parms);
            return pk;
        }

        public void Alterar(ClienteDTO clienteDTO)
        {
            string script =
                @"UPDATE TB_CLIENTE 
                  SET    
                     DS_CLIENTE  = @DS_CLIENTE,
                     DS_CELULAR  = @DS_CELULAR,
                     DS_TELEFONE = @DS_TELEFONE,
                     OBS_CLIENTE = @OBS_CLIENTE,
                     DT_CADASTRO = @DT_CADASTRO
                     
                  WHERE ID_CLIENTE = @ID_CLIENTE";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            parms.Add(new MySqlParameter("ID_CLIENTE"   , clienteDTO.ID_Cliente));
            parms.Add(new MySqlParameter("DS_CLIENTE"   , clienteDTO.Nome_Cliente));
            parms.Add(new MySqlParameter("DS_CELULAR"   , clienteDTO.Celular));
            parms.Add(new MySqlParameter("DS_TELEFONE"  , clienteDTO.Telefone));
            parms.Add(new MySqlParameter("OBS_CLIENTE"  , clienteDTO.Observacao));
            parms.Add(new MySqlParameter("DT_CADASTRO"  , clienteDTO.Dt_Cadastro));

            db.ExecuteInsertScript(script, parms);
        }

        public void Remover(int ID)
        {
            string script =
                @"DELETE FROM TB_CLIENTE WHERE ID_CLIENTE = @ID_CLIENTE";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            parms.Add(new MySqlParameter("ID_CLIENTE", ID));

            db.ExecuteInsertScript(script, parms);
        }

        public List<ClienteDTO> Listar()
        {
            string script =
                @"SELECT * FROM TB_CLIENTE";

            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<ClienteDTO> lstClienteDTO = new List<ClienteDTO>();
            while (reader.Read())
            {
                ClienteDTO clienteDTO = new ClienteDTO
                {
                    ID_Cliente      = reader.GetInt32("ID_CLIENTE"),
                    Nome_Cliente    = reader.GetString("DS_CLIENTE"),
                    Celular         = reader.GetString("DS_CELULAR"),
                    Telefone        = reader.GetString("DS_TELEFONE"),
                    Observacao      = reader.GetString("OBS_CLIENTE"),
                    Dt_Cadastro     = reader.GetDateTime("DT_CADASTRO")
                };

                lstClienteDTO.Add(clienteDTO);
            }
            reader.Close();

            return lstClienteDTO;
        }

        public ClienteDTO Consultar_ID(int ID)
        {
            string script =
                @"SELECT * FROM TB_CLIENTE WHERE ID_CLIENTE = @ID_CLIENTE";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("ID_CLIENTE", ID));

            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            ClienteDTO clienteDTO = new ClienteDTO();
            
            while (reader.Read())
            {
                clienteDTO.ID_Cliente   = reader.GetInt32("ID_CLIENTE");
                clienteDTO.Nome_Cliente = reader.GetString("DS_CLIENTE");
                clienteDTO.Celular      = reader.GetString("DS_CELULAR");
                clienteDTO.Telefone     = reader.GetString("DS_TELEFONE");
                clienteDTO.Observacao   = reader.GetString("OBS_CLIENTE");
                clienteDTO.Dt_Cadastro  = reader.GetDateTime("DT_CADASTRO");
            }
            return clienteDTO;
        }

        public List<ClienteDTO> Consultar(string argumentoBusca)
        {

            string script =
                @"SELECT * FROM TB_CLIENTE WHERE DS_CLIENTE LIKE @DS_CLIENTE" + "%";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("DS_CATEGORIA", argumentoBusca));

            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ClienteDTO> lstclienteDTO = new List<ClienteDTO>();
            while (reader.Read())
            {
                ClienteDTO clienteDTO = new ClienteDTO();
                
                clienteDTO.ID_Cliente   = reader.GetInt32("ID_CLIENTE");
                clienteDTO.Nome_Cliente = reader.GetString("DS_CLIENTE");
                clienteDTO.Celular      = reader.GetString("DS_CELULAR");
                clienteDTO.Telefone     = reader.GetString("DS_TELEFONE");
                clienteDTO.Observacao   = reader.GetString("OBS_CLIENTE");
                clienteDTO.Dt_Cadastro  = reader.GetDateTime("DT_CADASTRO");

                lstclienteDTO.Add(clienteDTO);
            }
            reader.Close();

            return lstclienteDTO;
        }

    }
}
