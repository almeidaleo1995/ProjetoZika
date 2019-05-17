using MetroFramework.Forms;
using ProjetoLeonardoBussnies;
using ProjetoZicaLeonardoA.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoZicaLeonardoA
{
    public partial class MainLoginDialog : MetroForm

    {

        private ProjetoLeonardoVO _projetozica;
        public MainLoginDialog()
        {
            InitializeComponent();
        }

    

        private void BtnLoginOK_Click(object sender, EventArgs e)
        {
            MainDialog Logins = new MainDialog(_projetozica);
            Logins.ShowDialog(this);
        }

        private void ManterCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }
    }
}
