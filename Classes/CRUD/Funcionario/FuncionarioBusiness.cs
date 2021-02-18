using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimasArtes.Classes.Cliente
{
    public class FuncionarioBusiness
    {
        FuncionarioDatabase db = new FuncionarioDatabase();
        public int Salvar(FuncionarioDTO funcionarioDTO)
        {
            int id = db.Salvar(funcionarioDTO);
            return id;
        }
        public void Alterar(FuncionarioDTO funcionarioDTO)
        {
            db.Alterar(funcionarioDTO);
        }

        public void Remover(int funcionarioDTO)
        {
            db.Remover(funcionarioDTO);
        }

        public List<FuncionarioDTO> Listar()
        {
            List<FuncionarioDTO> funcionarioDTO = db.Listar();
            return funcionarioDTO;
        }
    }
}

