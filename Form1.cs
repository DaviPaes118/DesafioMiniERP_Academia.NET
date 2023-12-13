namespace MiniERP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_cadastroCliente_Click(object sender, EventArgs e)
        {
            FormCadastroCliente cadastroCliente = new FormCadastroCliente();

            cadastroCliente.Show();
        }

        private void button_cadastroFornecedor_Click(object sender, EventArgs e)
        {
            FormCadastroFornecedor cadastroFornecedor = new FormCadastroFornecedor();

            cadastroFornecedor.Show();
        }

        private void button_cadastrarProduto_Click(object sender, EventArgs e)
        {
            FormCadastroProduto cadastroProduto = new FormCadastroProduto();

            cadastroProduto.Show();
        }

        private void button_emitirNota_Click(object sender, EventArgs e)
        {
            FormEmitirNota emitirNota = new FormEmitirNota();

            emitirNota.Show();
        }
    }
}