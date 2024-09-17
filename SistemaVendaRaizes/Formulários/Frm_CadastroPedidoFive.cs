using SistemaVendaRaizes.Infra.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendaRaizes.Formulários
{
    public partial class Frm_CadastroPedidoFive : Form
    {
        public Frm_CadastroPedidoFive()
        {
            InitializeComponent();
        }

        private void Frm_CadastroCliente_Load(object sender, EventArgs e)
        {
            FindParameters parameters = new FindParameters();


            cb_cliente.Items.Clear();
            cbPagamento.Items.Clear();
            cb_produto.Items.Clear();
            cb_tipo.Items.Clear();

            cbPagamento.Items.Clear();
            cb_produto.Items.Clear();
            cb_tipo.Items.Clear();


            cb_cliente.Items.AddRange(parameters.FindCliente().ToArray());
            cb_tipo.Items.AddRange(parameters.FindTipo().ToArray());
            cb_produto.Items.AddRange(parameters.FindProduto().ToArray());
            cbPagamento.Items.AddRange(parameters.FindPagamento().ToArray());

        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            new Frm_CadastroCliente().ShowDialog();
        }

        private void cb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            FindParameters dao = new FindParameters();
            txtValorUni.Clear();
            var tipo = cb_tipo.SelectedItem.ToString();
            List<string> list = new List<string>();

            list = dao.FindTipoProduto(tipo);
            cb_produto.Items.Clear();

            foreach (var item in list)
            {
                cb_produto.Items.Add(item.ToString());
            }
        }

        private void cb_produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            FindParameters dao = new FindParameters();
            txtValorUni.Clear();
            var produto = cb_produto.SelectedItem.ToString();
            var valor = dao.FindProdutoValor(produto);

            txtValorUni.Text = valor.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                FindParameters dao = new FindParameters();
                var cliente = "";
                var tipo = "";
                var produto = "";
                var pagamento = "";

                foreach (Control field in grouppedido.Controls)
                {
                    if (field.GetType().Equals(typeof(TextBox)) ||
                        field.GetType().Equals(typeof(MaskedTextBox)) ||
                        field.GetType().Equals(typeof(ComboBox)))
                    {
                        if (string.IsNullOrWhiteSpace(field.Text))
                        {
                            toolTip1.ToolTipTitle = "Atenção:";
                            toolTip1.SetToolTip(field, "Preencha");
                            toolTip1.Show("Preencha este campo!", field, 5000);
                            field.Focus();
                            return;
                        }
                    }
                }


                if (cb_cliente.SelectedItem == null)
                {
                    cliente = string.Empty;
                }
                else
                {
                    cliente = cb_cliente.SelectedItem.ToString();
                }

                if (cb_tipo.SelectedItem == null)
                {
                    tipo = string.Empty;
                }
                else
                {
                    tipo = cb_tipo.SelectedItem.ToString();
                }

                if (cb_produto.SelectedItem == null)
                {
                    produto = string.Empty;
                }
                else
                {
                    produto = cb_produto.SelectedItem.ToString();
                }

                if (cbPagamento.SelectedItem == null)
                {
                    pagamento = string.Empty;
                }
                else
                {
                    pagamento = cbPagamento.SelectedItem.ToString();
                }

                DialogResult result = MessageBox.Show("Deseja realmente cadastrar o pedido?",
                   "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dao.RegistraPedidoFiveMed(cliente,tipo,produto,txtValorUni.Text,txtQtde.Text,txtValorTotal.Text,pagamento);
                    MessageBox.Show("Pedido criado com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm_CadastroCliente_Load(sender, e);
                    cb_cliente.SelectedIndex = -1;
                    cb_tipo.SelectedIndex = -1;
                    cb_produto.SelectedIndex = -1;
                    cbPagamento.SelectedIndex = -1;
                    txtQtde.Clear();
                    txtValorUni.Clear();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txtQtde_TextChanged(object sender, EventArgs e)
        {
            
            double valor = 0;
            var valortotal ="";
          
            if(txtQtde.Text == string.Empty)
            {
                txtValorTotal.Text = "0,00";
                txtQtde.Text = "0";
            }

            valor = Double.Parse(txtQtde.Text.ToString()) * Double.Parse(txtValorUni.Text.ToString());
            valortotal = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", valor.ToString("F2", CultureInfo.InvariantCulture));

            txtValorTotal.Text =  valortotal.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cb_cliente.SelectedIndex = -1;
            cb_tipo.SelectedIndex = -1;
            cb_produto.SelectedIndex = -1;
            cbPagamento.SelectedIndex = -1;
            txtQtde.Clear();
            txtValorUni.Clear();
            txtValorTotal.Clear();
        }

        private void txtValorTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
