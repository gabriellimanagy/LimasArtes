using LimasArtes.Classes.Cliente;
using LimasArtes.Classes.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimasArtes.Telas
{
    public partial class frmClienteCadastrar : Form
    {
        public frmClienteCadastrar()
        {
            InitializeComponent();
            KeyPreview = true;
        }
        
        public string Resposta { get; set; }
        public int ID { get; set; }
        
        MessageBoxInteligente Mbox = new MessageBoxInteligente();

        public void Alterar(ClienteDTO cliente)
        {
            CarregarCliente(cliente);
            Resposta = "Sem alterações";
        }
        public void Zoom(ClienteDTO cliente)
        {
            CarregarCliente(cliente);
            txtNome.ReadOnly = true;
            txtCelular.ReadOnly = true;
            txtTelefone.ReadOnly = true;
            txtObs.ReadOnly = true;
            btnCONFIRMAR.Enabled = false;
        }
        private void btnCONFIRMAR_Click(object sender, EventArgs e)
        {
            ClienteBusiness business = new ClienteBusiness();

            ClienteDTO clienteDTO = new ClienteDTO
            {
                Nome_Cliente = txtNome.Text,
                Celular = txtCelular.Text,
                Telefone = txtTelefone.Text,
                Observacao = txtObs.Text,
                Dt_Cadastro = DateTime.Now
            };

            if (Resposta == "Sem alterações")
            {
                clienteDTO.ID_Cliente = ID;
            }
            try
            {
                if (ID > 0)
                {
                    business.Alterar(clienteDTO);
                    
                    string mensagem = "Alterado com sucesso";
                    Mbox.Info(mensagem);
                    
                    Resposta = "Alterado";
                    Close();
                }
                else if (ID == 0) 
                {
                    _ = business.Salvar(clienteDTO);
                    
                    string mensagem = "Salvo com sucesso";
                    Mbox.Info(mensagem);
                }
                
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            
        }

        private void CarregarCliente(ClienteDTO cliente)
        {
            ID = cliente.ID_Cliente;
            lblID.Text = "ID: " + Convert.ToString(ID);
            txtNome.Text = cliente.Nome_Cliente;
            txtCelular.Text = cliente.Celular;
            txtTelefone.Text = cliente.Telefone;
            txtObs.Text = cliente.Observacao;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmClienteCadastrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
