using MiniERP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP
{
    public partial class FormCadastroProduto : Form
    {
        Contexto contexto = new Contexto();

        public FormCadastroProduto()
        {
            InitializeComponent();
            MostrarLista();
            ListaFornecedores();
        }

        private void textBox_nomeProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                textBox_ValorUnit.Focus();
                textBox_ValorUnit.SelectionStart = 0;
            }
        }

        private void maskedTextBox_PesquisaCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                button_ConfirmarCadastroProduto_Click(sender, e);
            }
        }

        private void button_ConfirmarCadastroProduto_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            string nome = textBox_nomeProduto.Text;
            decimal valor = decimal.Parse(textBox_ValorUnit.Text);
            string fornecedor = textBox_IDFornecedor.Text;

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(valor.ToString()) || string.IsNullOrEmpty(fornecedor))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            produto.Nome = nome;
            produto.Preco = valor;
            produto.FornecedorID = int.Parse(fornecedor);

            try
            {
                contexto.Add(produto);
                contexto.SaveChanges();
                MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                MostrarLista();

            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível cadastrar o produto!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_LimpaCamposProduto_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void button_CancelaProduto_Click(object sender, EventArgs e)
        {
            LimparCampos();

            this.Close();
        }

        private void LimparCampos()
        {
            textBox_nomeProduto.Clear();
            maskedTextBox_PesquisaCNPJ.Clear();
            textBox_FonecedorProduto.Clear();
            textBox_ValorUnit.Clear();
        }

        private void MostrarLista()
        {
            List<Produto> listaProduto = (from Produto p in contexto.Produtos select p).ToList();

            listView_Produtos.Items.Clear();

            foreach (Produto p in listaProduto)
            {
                string[] items = { p.ProdutoID.ToString(), p.Nome, p.Fornecedor.Nome, p.Preco.ToString() };

                listView_Produtos.Items.Add(new ListViewItem(items));
            }
        }

        private void ListaFornecedores()
        {
            List<Fornecedor> listafornecedor = (from Fornecedor f in contexto.Fornecedores select f).ToList();
        }

        private void maskedTextBox_PesquisaCNPJ_TextChanged(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();

            string cnpjDigitado = maskedTextBox_PesquisaCNPJ.Text;

            Fornecedor fornecedorEncontrado = contexto.Fornecedores.FirstOrDefault(fornecedor => fornecedor.CNPJ == cnpjDigitado);

            if (fornecedorEncontrado != null)
            {
                textBox_FonecedorProduto.Text = fornecedorEncontrado.Nome;
                textBox_IDFornecedor.Text = fornecedorEncontrado.FornecedorID.ToString();
            }
        }

        private void textBox_ValorUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                maskedTextBox_PesquisaCNPJ.Focus();
                maskedTextBox_PesquisaCNPJ.SelectionStart = 0;
            }

        }
    }
}
