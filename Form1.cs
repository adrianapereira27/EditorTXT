namespace EditorTXT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Menu Arquivo
        private void mArquivoNovo_Click(object sender, EventArgs e)
        {
            txtConteudo.Clear();

        }
        private void mArquivoNovaJanela_Click(object sender, EventArgs e)
        {
            /*Form1 f = new Form1();
            f.Show();*/

            Thread t = new Thread(() => Application.Run(new Form1()));  // thread para desvincular o novo objeto do objeto origem
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        private void mArquivoAbrir_Click(object sender, EventArgs e)
        {

        }
        private void mArquivoSalvar_Click(object sender, EventArgs e)
        {

        }
        private void mArquivoSalvarComo_Click(object sender, EventArgs e)
        {

        }
        private void mArquivoSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente sair?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }            
        }
        #endregion
    }
}