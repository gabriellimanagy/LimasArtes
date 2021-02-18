using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimasArtes.Classes.Cliente
{
    public class FuncionarioDTO
    {
        public int ID_Funcionario { get; set; }

        public string Usuario { get; set; }

        public string Senha { get; set; }

        public string Funcionario { get; set; }

        public string Email { get; set; }

        public string Celular { get; set; }

        public string Telefone { get; set; }

        public DateTime Dt_Cadastro { get; set; }

        public string FK_Permissao { get; set; }

    }
}
