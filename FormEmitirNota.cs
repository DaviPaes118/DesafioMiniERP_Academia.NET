using iTextSharp.text.pdf;
using iTextSharp.text;
using MiniERP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Document = iTextSharp.text.Document;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MiniERP
{
    public partial class FormEmitirNota : Form
    {
        Contexto Contexto = new Contexto();

        List<ItemNota> itens = new List<ItemNota>();

        public FormEmitirNota()
        {
            InitializeComponent();
            MostrarLista();
        }

        private void maskedTextBox_CPF_TextChanged(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            string cpfdigitado = maskedTextBox_CPF.Text;

            Cliente clienteEncontrado = Contexto.Clientes.FirstOrDefault(cliente => cliente.CPF == cpfdigitado);

            if (clienteEncontrado != null)
            {
                textBox_nomeCliente.Text = clienteEncontrado.Nome;

                textBox_IDCliente.Text = clienteEncontrado.ClienteID.ToString();
            }
        }

        private void textBox_ProdutoID_TextChanged(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            string idDigitado = textBox_ProdutoID.Text;

            Produto produtoEncontrado = Contexto.Produtos.FirstOrDefault(produto => produto.ProdutoID.ToString() == idDigitado);

            if (produtoEncontrado != null)
            {
                textBox_nomeProduto.Text = produtoEncontrado.Nome;
                textBox_ValorUnit.Text = produtoEncontrado.Preco.ToString();
            }
        }

        private void MostrarLista()
        {
            listView_Produtos.Items.Clear();

            decimal valorTotalitem = 0;

            decimal valortotal = 0;

            foreach (ItemNota p in itens)
            {
                valorTotalitem = p.Qtd * p.PrecoUnitario;

                string[] items = { p.Produto.Nome, p.Qtd.ToString(), p.PrecoUnitario.ToString(), valorTotalitem.ToString() };

                listView_Produtos.Items.Add(new ListViewItem(items));

                valortotal += valorTotalitem;
            }
            textBox_Total.Text = valortotal.ToString();
        }

        private void LimparCampos()
        {
            textBox_ProdutoID.Clear();
            textBox_nomeProduto.Clear();
            numericUpDown_Quantidade.Value = 1;
            textBox_ValorUnit.Clear();
        }

        private void Button_LimpaCampos_Click(object sender, EventArgs e)
        {
            maskedTextBox_CPF.Clear();

            textBox_nomeCliente.Clear();

            LimparCampos();
        }

        private void button_CancelaNota_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_AdicionarItem_Click(object sender, EventArgs e)
        {
            ItemNota itemNota = new ItemNota();

            string cpf = maskedTextBox_CPF.Text;
            string id = textBox_ProdutoID.Text;
            string qtd = numericUpDown_Quantidade.Text;
            string nome = textBox_nomeProduto.Text;
            decimal valorunit = decimal.Parse(textBox_ValorUnit.Text);

            if (string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(id) || string.IsNullOrEmpty(qtd))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            itemNota.Qtd = int.Parse(qtd);
            itemNota.Produto = new() { ProdutoID = int.Parse(id), Nome = nome };
            itemNota.PrecoUnitario = valorunit;
            itemNota.ProdutoID = int.Parse(id);

            itens.Add(itemNota);

            LimparCampos();
            MostrarLista();

        }

        private void button_EmitirNota_Click(object sender, EventArgs e)
        {
            Nota nota = new Nota();
            ItemNota item = new ItemNota();

            nota.ClienteID = int.Parse(textBox_IDCliente.Text);
            nota.Data = DateTime.Now;

            List<ItemNota> lista = new List<ItemNota>();


            foreach (var itemNota in itens)
            {
                item.ProdutoID = itemNota.ProdutoID;
                item.Qtd = itemNota.Qtd;
                item.PrecoUnitario= itemNota.PrecoUnitario;
                lista.Add(item);
            }

            nota.Itens = lista;

            try
            {
                Contexto.NotasFiscais.Add(nota);
                Contexto.SaveChanges();
                MessageBox.Show("Nota emitida com sucesso!", "SUCESSO", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Não foi possível emitir a nota.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            EmitirNota();

            LimparCampos();
            maskedTextBox_CPF.Clear();
            textBox_nomeCliente.Clear();

        }

        private void EmitirNota()
        {
            DateTime data = DateTime.Now;
            string novaData = $"{data.Day}-{data.Month}-{data.Year}";

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PDF (*.pdf)|*.pdf";
            save.FileName = "Nota Fiscal " + novaData + ".pdf";
            save.ShowDialog();

            string arquivo = save.FileNames[0].ToString();

            FileStream pdf = new FileStream(arquivo, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter.GetInstance(doc, pdf);

            PdfPTable table = new PdfPTable(4);

            doc.Open();

            PdfPCell titulo = new PdfPCell(new Phrase("Nota Fiscal"));
            titulo.Colspan = 4;
            titulo.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(titulo);

            table.AddCell("Cliente: ");
            table.AddCell(textBox_nomeCliente.Text);
            table.AddCell("CPF: ");
            table.AddCell(maskedTextBox_CPF.Text);

            table.AddCell("Produto");
            table.AddCell("Qtd.");
            table.AddCell("Valor Unit.");
            table.AddCell("Valor Total");

            foreach (var i in itens)
            {
                decimal total = i.Qtd * i.PrecoUnitario;

                table.AddCell(i.Produto.Nome);
                table.AddCell(i.Qtd.ToString());
                table.AddCell(i.PrecoUnitario.ToString());
                table.AddCell(total.ToString());
            }

            PdfPCell totalcompra = new PdfPCell(new Phrase("TOTAL: R$ " + textBox_Total.Text));
            totalcompra.Colspan = 4;
            totalcompra.HorizontalAlignment = Element.ALIGN_RIGHT;
            table.AddCell(totalcompra);

            doc.Add(table);

            doc.Close();
        }

        private void maskedTextBox_CPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                textBox_ProdutoID.Focus();
                textBox_ProdutoID.SelectionStart = 0;
            }
        }
    }
}
