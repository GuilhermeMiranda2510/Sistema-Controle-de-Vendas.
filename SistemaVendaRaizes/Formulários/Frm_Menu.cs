using SistemaVendaRaizes.Formulários;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendaRaizes
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void novoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Frm_NovoPedido().ShowDialog();
        }

        private void salgadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Frm_CadastraProduto().ShowDialog();
        }

        private void Frm_Menu_Load(object sender, EventArgs e)
        {
           
        }

        private void relatórioDeVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Frm_RelatorioVenda().ShowDialog();
        }

        private void novoPedidoFiveMedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Frm_CadastroPedidoFive().ShowDialog();
        }

        private void clienteFiveMedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Frm_CadastroCliente().ShowDialog();
        }
    }
}
