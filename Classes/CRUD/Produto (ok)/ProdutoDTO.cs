using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimasArtes.Classes.Cliente
{
    public class ProdutoDTO
    {
        public int ID_Produto { get; set; }

        public string Produto { get; set; }

        public string Tipo { get; set; }

        public decimal Vl_Unitario { get; set; }

        public string Observacao { get; set; }

        public DateTime Dt_Cadastro { get; set; }

        public int FK_Categoria { get; set; }

    }
}
