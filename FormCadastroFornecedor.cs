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
    public partial class FormCadastroFornecedor : Form
    {
        Contexto contexto = new Contexto();

        public FormCadastroFornecedor()
        {
            InitializeComponent();
            MostrarLista();
        }

        private void Button_LimpaCamposFornecedor_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        public void LimparCampos()
        {
            textBox_nomeFornecedor.Clear();

            maskedTextBox_CNPJ.Clear();
        }

        private void button_CancelaFornecedor_Click(object sender, EventArgs e)
        {
            LimparCampos();

            this.Close();
        }

        private void textBox_nomeFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                maskedTextBox_CNPJ.Focus();
                maskedTextBox_CNPJ.SelectionStart = 0;
            }
        }

        private void maskedTextBox_CNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                button_ConfirmarCadastroFornecedor_Click(sender, e);
            }
        }

        private void button_ConfirmarCadastroFornecedor_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();

            string nome = textBox_nomeFornecedor.Text;
            string cnpj = maskedTextBox_CNPJ.Text;

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cnpj))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            fornecedor.Nome = nome;
            fornecedor.CNPJ = cnpj;

            try
            {
                contexto.Add(fornecedor);
                contexto.SaveChanges();
                MessageBox.Show("Fornecedor cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                MostrarLista();

            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível cadastrar o Fornecedor.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarLista()
        {
            List<Fornecedor> listafornecedor = (from Fornecedor f in contexto.Fornecedores select f).ToList();

            listView_FornecedorCadastrado.Items.Clear();

            foreach (Fornecedor f in listafornecedor)
            {
                string[] items = { f.FornecedorID.ToString(), f.Nome, f.CNPJ };

                listView_FornecedorCadastrado.Items.Add(new ListViewItem(items));
            }
        }
    }


}
