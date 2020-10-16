using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimasArtes.Classes.Tools
{
    public class MessageBoxInteligente
    {
        public void Info(string mensagem)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            MessageBoxDefaultButton padrao = MessageBoxDefaultButton.Button1;
            string titulo = "Informação";

            MessageBox.Show(mensagem, titulo, buttons, icon, padrao);
        }
    }
}
