using MetroFramework.Forms;

namespace Apresentacao.UI
{
    public partial class MainDialog : MetroForm
    {
        public MainDialog()
        {
            InitializeComponent();

            Traduz();
        }

        private void Traduz()
        {
            //Chama o json e retorna uma lista de strings

            metroTabControl1.TabPages[0].Text = "Teste";
        }
    }
}
