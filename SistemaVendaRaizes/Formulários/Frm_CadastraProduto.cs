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
    public partial class Frm_CadastraProduto : Form
    {
        public Frm_CadastraProduto()
        {
            InitializeComponent();
        }

        private void grouppedido_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
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


                FindParameters dao = new FindParameters();
                DialogResult result = MessageBox.Show("Deseja realmente cadastrar o produto?",
                    "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dao.RegistraProduto(cb_tipo.SelectedItem.ToString(), txtProduto.Text, txtValorUni.Text);
                    MessageBox.Show("Produto criado com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cb_tipo.SelectedIndex = -1;
                    txtValorUni.Clear();
                    txtProduto.Clear();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void Frm_CadastraProduto_Load(object sender, EventArgs e)
        {
            FindParameters parameters = new FindParameters();
            cb_tipo.Items.AddRange(parameters.FindTipo().ToArray());
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cb_tipo.SelectedIndex = -1;
            txtValorUni.Clear();
            txtProduto.Clear();
        }
    }
}
