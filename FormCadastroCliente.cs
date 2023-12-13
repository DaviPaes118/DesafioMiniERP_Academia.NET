using Microsoft.EntityFrameworkCore;
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
    public partial class FormCadastroCliente : Form
    {
        Contexto contexto = new Contexto();

        public FormCadastroCliente()
        {
            InitializeComponent();
            MostrarLista();
        }

        private void textBox_nomeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                maskedTextBox_CPF.Focus();
                maskedTextBox_CPF.SelectionStart = 0;
            }
        }

        private void maskedTextBox_CPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                button_ConfirmarCadastro_Click(sender, e);
            }
        }

        private void button_ConfirmarCadastro_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            string nome = textBox_nomeCliente.Text;
            string cpf = maskedTextBox_CPF.Text;

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cpf))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cliente.Nome = nome;
            cliente.CPF = cpf;

            try
            {
                contexto.Add(cliente);
                contexto.SaveChanges();
                MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                MostrarLista();

            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível cadastrar o cliente.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_LimpaCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        public void LimparCampos()
        {
            textBox_nomeCliente.Clear();

            maskedTextBox_CPF.Clear();
        }

        private void button_CancelaCliente_Click(object sender, EventArgs e)
        {
            LimparCampos();

            this.Close();
        }

        private void MostrarLista()
        {
            List<Cliente> listacliente = (from Cliente c in contexto.Clientes select c).ToList();

            listView_Cadastrados.Items.Clear();

            foreach (Cliente c in listacliente)
            {
                string[] items = { c.ClienteID.ToString(), c.Nome, c.CPF };

                listView_Cadastrados.Items.Add(new ListViewItem(items));
            }
        }
    }
}
