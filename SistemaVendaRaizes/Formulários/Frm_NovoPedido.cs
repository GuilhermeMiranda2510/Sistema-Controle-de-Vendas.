using SistemaVendaRaizes.Infra.DAO;
using SistemaVendaRaizes.Model;
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
   
    public partial class Frm_NovoPedido : Form
    {
        DataTable dt = new DataTable();
        public Frm_NovoPedido()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                List<double> somaValores = new List<double>();
                var valor = Double.Parse(txtQtde.Text.ToString()) * Double.Parse(txtValorUni.Text.ToString());
                var valortotal = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", valor.ToString("F2", CultureInfo.InvariantCulture));
                dt.Rows.Add(
                           cbbloco.SelectedItem.ToString(),
                           cbap.SelectedItem.ToString(),
                           cb_tipo.SelectedItem.ToString(),
                           cb_produto.SelectedItem.ToString(),
                           "R$" + txtValorUni.Text.ToString(),
                           txtQtde.Text,
                            cbPagamento.SelectedItem.ToString(),
                            "R$" + valortotal.ToString()
                           );

                foreach (DataGridViewRow col in dt_contrato.Rows)
                {
                    dt_contrato.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dt_contrato.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dt_contrato.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dt_contrato.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dt_contrato.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dt_contrato.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    somaValores.Add(Convert.ToDouble(col.Cells[7].Value.ToString().Replace("R$", "").Replace(".", ",")));
                }

                if (dt_contrato.ColumnCount == 10)
                {
                    foreach (DataGridViewRow col in dt_contrato.Rows)
                    {
                        if (Convert.ToInt32(col.Cells[7].Value) > 0)
                        {
                            col.DefaultCellStyle.BackColor = Color.Green;
                        }
                    }
                }

                dt_contrato.CurrentRow.ReadOnly = true;
                lblquantidade.Text = dt_contrato.RowCount.ToString();
                lbValorTotal.Text = somaValores.Sum().ToString("C");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Frm_NovoPedido_Load(object sender, EventArgs e)
        {
            FindParameters parameters = new FindParameters();
            try
            {

                cbap.Items.Clear();
                cbbloco.Items.Clear();
                cbPagamento.Items.Clear();
                cb_produto.Items.Clear();
                cb_tipo.Items.Clear();

                dt.Clear();
                dt.Rows.Clear();
                dt.Columns.Clear();

                dt.Columns.Add("BLOCO");
                dt.Columns.Add("AP");
                dt.Columns.Add("TIPO");
                dt.Columns.Add("PRODUTO");
                dt.Columns.Add("V. UNI.");
                dt.Columns.Add("QTDE");
                // //dt.Columns.Add("ACRES.");
                //// dt.Columns.Add("VALOR TOTAL");
                 dt.Columns.Add("PAG.");
                dt.Columns.Add("V.TOTAL");
                dt_contrato.DataSource = dt;

                cbbloco.Items.Clear();
                cbbloco.Items.AddRange(parameters.FindBloco().ToArray());
                cbap.Items.AddRange(parameters.FindAP().ToArray());
                cb_tipo.Items.AddRange(parameters.FindTipo().ToArray());
                cb_produto.Items.AddRange(parameters.FindProduto().ToArray());
                cbPagamento.Items.AddRange(parameters.FindPagamento().ToArray());
                //cb_tipo.Items.AddRange(parameters.FindMedicamento().ToArray());
                //cb_produto.Items.AddRange(parameters.FindTipo().ToArray());
                //cbAcrescimo.Items.AddRange(parameters.FindTipo().ToArray());
                //cbPagamento.Items.AddRange(parameters.FindTipo().ToArray());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int cont = 0;
            try
            {
                FindParameters dao = new FindParameters();
                PedidoItemModel obj = new PedidoItemModel();
                List<PedidoItemModel> list = new List<PedidoItemModel>();
                var cliente = "";
                foreach (DataGridViewRow item in dt_contrato.Rows)
                {
                    obj = new PedidoItemModel();
                    obj.Bloco = Convert.ToInt32(item.Cells[0].Value);
                    obj.AP = Convert.ToInt32(item.Cells[1].Value);
                    obj.Tipo = item.Cells[2].Value.ToString();
                    obj.Produto = item.Cells[3].Value.ToString();
                    obj.VUni = item.Cells[4].Value.ToString();
                    obj.Qtde = Convert.ToInt32(item.Cells[5].Value);
                    obj.Pag = item.Cells[6].Value.ToString();
                    obj.VTotal = item.Cells[7].Value.ToString();
                    list.Add(obj);
                    cont++;
                }

                if (dt_contrato.RowCount < 1)
                    MessageBox.Show("Adicione um item no pedido.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                else
                {
                    DialogResult result = MessageBox.Show("Deseja realmente cadastrar o pedido?",
                    "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dao.RegistraPedido(list);
                        MessageBox.Show("Pedido criado com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Frm_NovoPedido_Load(sender, e);
                        cbbloco.SelectedIndex = -1;
                        cbap.SelectedIndex = -1;
                        cb_tipo.SelectedIndex = -1;
                        cb_produto.SelectedIndex = -1;
                        cbPagamento.SelectedIndex = -1;
                        txtQtde.Clear();
                        txtValorUni.Clear();
                        lblquantidade.Text = "-";
                        lbValorTotal.Text = "-";
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Frm_NovoPedido_Load(sender, e);
            cbbloco.SelectedIndex = -1;
            cbap.SelectedIndex = -1;
            cb_tipo.SelectedIndex = -1;
            cb_produto.SelectedIndex = -1;
            cbPagamento.SelectedIndex = -1;
            txtQtde.Clear();
            txtValorUni.Clear();
            lblquantidade.Text = "-";
            lbValorTotal.Text = "-";

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
           var valor =  dao.FindProdutoValor(produto);

            txtValorUni.Text = valor.ToString();
        }

        private void dt_contrato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
