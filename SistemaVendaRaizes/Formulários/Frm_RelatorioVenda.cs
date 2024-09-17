using SistemaVendaRaizes.Infra.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendaRaizes.Formulários
{
    public partial class Frm_RelatorioVenda : Form
    {
        DataTable dt = new DataTable();
        public Frm_RelatorioVenda()
        {
            InitializeComponent();
        }

        private void Frm_RelatorioVenda_Load(object sender, EventArgs e)
        {
            FindParameters parameters = new FindParameters();

            cbap.Items.Clear();
            cbbloco.Items.Clear();
            cb_tipo.Items.Clear();

            dt.Clear();
            dt.Columns.Clear();
            dt.Rows.Clear();

            dt.Columns.Add("DATAREGISTRO");
            dt.Columns.Add("BLOCO");
            dt.Columns.Add("AP");
            dt.Columns.Add("CLIENTE");
            dt.Columns.Add("TIPO");
            dt.Columns.Add("PRODUTO");
            dt.Columns.Add("QTDE");
            dt.Columns.Add("V. UNI");
            dt.Columns.Add("PAG.");
            dt.Columns.Add("V. TOTAL");
            dt.Columns.Add("LOCAL");


           //dgtVendas.Rows.Clear();
            dgtVendas.Columns.Clear();

            dgtVendas.DataSource = null;

            cbbloco.Items.AddRange(parameters.FindBloco().ToArray());
            cbap.Items.AddRange(parameters.FindAP().ToArray());
            cb_tipo.Items.AddRange(parameters.FindTipo().ToArray());
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            List<double> somaValores = new List<double>();
            FindParameters banco = new FindParameters();
            var bloco = "";
            var ap = "";
            var tipo = "";
            var local = "";

            if (cbbloco.SelectedItem == null)
            {
                bloco = string.Empty;
            }
            else
            {
                bloco = cbbloco.SelectedItem.ToString();
            }

            if (cbap.SelectedItem == null)
            {
                ap = string.Empty;
            }
            else
            {
                ap = cbap.SelectedItem.ToString();
            }

            if (cb_tipo.SelectedItem == null)
            {
                tipo = string.Empty;
            }
            else
            {
                tipo = cb_tipo.SelectedItem.ToString();
            }

            if (cbLocal.SelectedItem == null)
            {
                local = string.Empty;
            }
            else
            {
                local = cbLocal.SelectedItem.ToString();
            }


            dgtVendas.DataSource = banco.GeraRelatorioTotal(datainicio.Value, dtfim.Value,bloco,ap,tipo,local);
            foreach (DataGridViewRow col in dgtVendas.Rows)
            {
               // dgtVendas.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgtVendas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgtVendas.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgtVendas.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgtVendas.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgtVendas.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgtVendas.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgtVendas.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgtVendas.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgtVendas.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgtVendas.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                somaValores.Add(Convert.ToDouble(col.Cells[9].Value.ToString().Replace("R$", "").Replace(".", ",")));
            }
            lblquantidade.Text = (dgtVendas.RowCount).ToString();
            lbValorTotal.Text = somaValores.Sum().ToString("C");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbbloco.SelectedIndex = -1;
            cbap.SelectedIndex = -1;
            cb_tipo.SelectedIndex = -1;
            cbLocal.SelectedIndex = -1;
            lblquantidade.Text = "-";
            lbValorTotal.Text = "-";
            Frm_RelatorioVenda_Load(sender, e);
        }

        private void dgtVendas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            foreach (DataGridViewRow etapa in dgtVendas.Rows)
            {
                if (etapa.Cells[8].Value.ToString() == "PIX")
                    etapa.DefaultCellStyle.BackColor = Color.LightGreen;

                else if (etapa.Cells[8].Value.ToString() == "DINHEIRO")
                    etapa.DefaultCellStyle.BackColor = Color.LightGreen;

                else if (etapa.Cells[8].Value.ToString() == "CREDITO")
                    etapa.DefaultCellStyle.BackColor = Color.LightGreen;

                else if (etapa.Cells[8].Value.ToString() == "DEBITO")
                    etapa.DefaultCellStyle.BackColor = Color.LightGreen;

                else if (etapa.Cells[8].Value.ToString() == "A PAGAR")
                    etapa.DefaultCellStyle.BackColor = Color.Red;
            }

        }
    }
}
