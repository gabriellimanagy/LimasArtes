using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimasArtes.Classes.Cliente
{
    public class ClienteDTO
    {
        public int ID_Cliente { get; set; }

        public string Nome_Cliente { get; set; }

        public string Celular { get; set; }

        public string Telefone { get; set; }

        public string Observacao { get; set; }

        public DateTime Dt_Cadastro { get; set; }
    }
}
