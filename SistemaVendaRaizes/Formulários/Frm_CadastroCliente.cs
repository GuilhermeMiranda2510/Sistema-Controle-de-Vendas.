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
    public partial class Frm_CadastroCliente : Form
    {
        public Frm_CadastroCliente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                FindParameters dao = new FindParameters();

                foreach (Control field in groupBox1.Controls)
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

                DialogResult result = MessageBox.Show("Deseja realmente cadastrar este cliente?",
                  "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dao.RegistraCliente(cbSetor.SelectedItem.ToString(), txtNome.Text);
                    MessageBox.Show("Cliente criado com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbSetor.SelectedIndex = -1;
                    txtNome.Clear();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Frm_CadastroCliente_Load(object sender, EventArgs e)
        {
            FindParameters parameters = new FindParameters();
            cbSetor.Items.AddRange(parameters.FindSetor().ToArray());
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            cbSetor.SelectedIndex = -1;
        }
    }
}
