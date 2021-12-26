namespace Meu_bloco_de_Notas
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void salvarClick(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void salvarOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string caminho = saveFileDialog1.FileName; 
            File.WriteAllText(caminho,txbJanela.Text);
        }
    }
}