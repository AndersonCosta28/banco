using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banco
{
    public partial class FormRelatorio : Form
    {
        private List<Conta> contas;
        public FormRelatorio(List<Conta>	contas)
        {
            InitializeComponent();
            this.contas = contas;
        }

        private void botaoFiltro_Click(object sender, EventArgs e)
        {
            var filtro = from c in this.contas
                         where c.Saldo == 0
                           select c;
            listResultados.Items.Clear();
            foreach ( Conta c in filtro)
            {
                listResultados.Items.Add(c.Titular.Nome);
            }
            
        }

        private void listResultados_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = listResultados.SelectedIndex;
            Conta c = contas[indice];
            labelNumero2.Text = Convert.ToString(c.Numero);
            labelSaldo2.Text = Convert.ToString(c.Saldo);

        }
    }
}
