using MetroFramework.Forms;
using ProjetoLeonardoBussnies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoZicaLeonardoA.UI
{
    public partial class MainDialog : MetroForm
    {
        private ProjetoLeonardoVO _projetozica;

       

        public MainDialog(ProjetoLeonardoVO projetozica)
        {
            InitializeComponent();
            _projetozica = projetozica;


        }


        private void ManterCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainDialog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'leonardo_TesteDataSet1.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.leonardo_TesteDataSet1.Products);

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
