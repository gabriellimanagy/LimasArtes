using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimasArtes.Classes.Cliente
{
    public class PedidoBusiness
    {
        PedidoDatabase db = new PedidoDatabase();
        public int Salvar(PedidoDTO pedidoDTO)
        {
            int id = db.Salvar(pedidoDTO);
            return id;
        }
        public void Alterar(PedidoDTO pedidoDTO)
        {
            db.Alterar(pedidoDTO);
        }

        public void Remover(int pedidoDTO)
        {
            db.Remover(pedidoDTO);
        }

        public List<PedidoDTO> Listar()
        {
            List<PedidoDTO> pedidoDTO = db.Listar();
            return pedidoDTO;
        }
    }
}
