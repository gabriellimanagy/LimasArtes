using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimasArtes.Classes.Cliente
{
    public class PedidoDTO
    {
        public int ID_Pedido { get; set; }

        public decimal Vl_Pedido { get; set; }

        public string Observacao { get; set; }

        public DateTime Dt_Pedido { get; set; }

        public int FK_Funcionario { get; set; }

        public int FK_Cliente { get; set; }


    }
}
