using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimasArtes.Classes.Cliente
{
    public class ClienteBusiness
    {
        ClienteDatabase db = new ClienteDatabase();
        public int Salvar(ClienteDTO clienteDTO)
        {
            if (clienteDTO.Nome_Cliente == string.Empty)
            {
                throw new ArgumentException("Nome do produto é obrigatório.");
            }        
                        
            int id = db.Salvar(clienteDTO);
            return id;
        }
        public void Alterar(ClienteDTO clienteDTO)
        {
            if (clienteDTO.Nome_Cliente == string.Empty)
            {
                throw new ArgumentException("Nome do produto é obrigatório.");
            }

            db.Alterar(clienteDTO);
        }

        public void Remover(int clienteDTO)
        {
            db.Remover(clienteDTO);
        }

        public List<ClienteDTO> Listar()
        {
            List<ClienteDTO> clienteDTO = db.Listar();
            return clienteDTO;
        }
        public ClienteDTO Consultar_ID(int ID)
        {
            ClienteDTO clienteDTO = db.Consultar_ID(ID);
            return clienteDTO;
        }
    }
}
