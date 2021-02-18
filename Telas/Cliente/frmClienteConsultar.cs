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

namespace LimasArtes.Telas.Cliente
{
    public partial class frmClienteConsultar : Form
    {
        public frmClienteConsultar()
        {
            InitializeComponent();

            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add("Cadastrar");
            menu.Items.Add("Zoom");
            ContextMenuStrip = menu;
            menu.ItemClicked += new ToolStripItemClickedEventHandler(menu_ItemClicked);
        }

        private readonly MessageBoxInteligente Mbox = new MessageBoxInteligente();
        private readonly ClienteBusiness business = new ClienteBusiness();

        private int selectedRowIndex { get; set; }

        #region Opções Menu de Contexto
        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Cadastrar")
            {
                frmClienteCadastrar tela = new frmClienteCadastrar();

                tela.Show();
                Listar();
            }
            else if (e.ClickedItem.Text == "Zoom")
            {
                Zoom();
            }
        }
        #endregion

        #region Eventos
        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (txtConsulta.Text == string.Empty)
            {
                Listar();
            }
            else
            {
                // Consultar(); #PRECISA# - descrição: precisa ser criado
            }
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            selectedRowIndex = e.RowIndex;
            if (e.ColumnIndex == 5 && selectedRowIndex >= 0)
            {
                Excluir();
                Listar();
            }

            if (e.ColumnIndex == 4 && selectedRowIndex >= 0)
            {
                Alterar();
            }
        }

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Zoom();
        }
        #endregion

        #region Métodos
        private void Listar()
        {
            List<ClienteDTO> clienteDTO = business.Listar();

            dgvCliente.AutoGenerateColumns = false;
            dgvCliente.DataSource = clienteDTO;
        }
        private void Alterar()
        {
            ClienteDTO cliente = dgvCliente.Rows[selectedRowIndex].DataBoundItem as ClienteDTO;
            frmClienteCadastrar tela = new frmClienteCadastrar();

            tela.Alterar(cliente);
            tela.Show();

            string resposta = tela.Resposta;

            if (resposta == "Alterado")
            {
                ClienteDTO ClienteAtu = business.Consultar_ID(cliente.ID_Cliente);

                _ = new DataGridViewRow();
                DataGridViewRow row = dgvCliente.Rows[selectedRowIndex];

                row.Cells[1].Value = ClienteAtu.Nome_Cliente;
                row.Cells[2].Value = ClienteAtu.Celular;
                row.Cells[3].Value = ClienteAtu.Telefone;

                dgvCliente.Refresh();
            }
        }
        private void Excluir()
        {
            ClienteDTO cliente = dgvCliente.Rows[selectedRowIndex].DataBoundItem as ClienteDTO;

            DialogResult result = MessageBox.Show("Deseja excluir este cadastro?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                business.Remover(cliente.ID_Cliente);
                Mbox.Info("Cadastro excluido com sucesso");
            }
            else if (result == DialogResult.Cancel)
            {
                Mbox.Info("O cadastro: " + cliente.Nome_Cliente + " não foi excluido!");
            }
        }
        private void Zoom()
        {
            if(dgvCliente.RowCount > 0) 
            { 
                ClienteDTO cliente = dgvCliente.Rows[selectedRowIndex].DataBoundItem as ClienteDTO;
                frmClienteCadastrar tela = new frmClienteCadastrar();

                tela.Zoom(cliente);
                tela.Show();
            }
        }
        #endregion
    }
}
