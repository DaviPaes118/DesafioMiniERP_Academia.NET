namespace MiniERP
{
    partial class FormCadastroProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_Titulo = new Label();
            panel1 = new Panel();
            textBox_IDFornecedor = new TextBox();
            textBox_ValorUnit = new TextBox();
            label_ValorUnit = new Label();
            button_CancelaProduto = new Button();
            Button_LimpaCamposProduto = new Button();
            button_ConfirmarCadastroProduto = new Button();
            listView_Produtos = new ListView();
            columnHeader_IDProduto = new ColumnHeader();
            columnHeader_NomeProduto = new ColumnHeader();
            columnHeader_Fornecedor = new ColumnHeader();
            maskedTextBox_PesquisaCNPJ = new MaskedTextBox();
            textBox_FonecedorProduto = new TextBox();
            label_Fornecedor = new Label();
            textBox_nomeProduto = new TextBox();
            label_nomeProduto = new Label();
            label_CadastrarProduto = new Label();
            columnHeader_Preço = new ColumnHeader();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label_Titulo
            // 
            label_Titulo.Dock = DockStyle.Top;
            label_Titulo.Font = new Font("Cambria", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_Titulo.ImageAlign = ContentAlignment.TopCenter;
            label_Titulo.Location = new Point(0, 0);
            label_Titulo.Name = "label_Titulo";
            label_Titulo.Size = new Size(790, 61);
            label_Titulo.TabIndex = 10;
            label_Titulo.Text = "MINI ERP";
            label_Titulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox_IDFornecedor);
            panel1.Controls.Add(textBox_ValorUnit);
            panel1.Controls.Add(label_ValorUnit);
            panel1.Controls.Add(button_CancelaProduto);
            panel1.Controls.Add(Button_LimpaCamposProduto);
            panel1.Controls.Add(button_ConfirmarCadastroProduto);
            panel1.Controls.Add(listView_Produtos);
            panel1.Controls.Add(maskedTextBox_PesquisaCNPJ);
            panel1.Controls.Add(textBox_FonecedorProduto);
            panel1.Controls.Add(label_Fornecedor);
            panel1.Controls.Add(textBox_nomeProduto);
            panel1.Controls.Add(label_nomeProduto);
            panel1.Controls.Add(label_CadastrarProduto);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(790, 449);
            panel1.TabIndex = 11;
            // 
            // textBox_IDFornecedor
            // 
            textBox_IDFornecedor.Enabled = false;
            textBox_IDFornecedor.Location = new Point(260, 282);
            textBox_IDFornecedor.Name = "textBox_IDFornecedor";
            textBox_IDFornecedor.Size = new Size(100, 23);
            textBox_IDFornecedor.TabIndex = 28;
            textBox_IDFornecedor.Visible = false;
            // 
            // textBox_ValorUnit
            // 
            textBox_ValorUnit.Location = new Point(125, 175);
            textBox_ValorUnit.Name = "textBox_ValorUnit";
            textBox_ValorUnit.Size = new Size(286, 23);
            textBox_ValorUnit.TabIndex = 27;
            textBox_ValorUnit.KeyPress += textBox_ValorUnit_KeyPress;
            // 
            // label_ValorUnit
            // 
            label_ValorUnit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_ValorUnit.Location = new Point(3, 175);
            label_ValorUnit.Name = "label_ValorUnit";
            label_ValorUnit.Size = new Size(91, 23);
            label_ValorUnit.TabIndex = 26;
            label_ValorUnit.Text = "Valor Unit.:";
            // 
            // button_CancelaProduto
            // 
            button_CancelaProduto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_CancelaProduto.Location = new Point(329, 365);
            button_CancelaProduto.Name = "button_CancelaProduto";
            button_CancelaProduto.Size = new Size(82, 26);
            button_CancelaProduto.TabIndex = 23;
            button_CancelaProduto.Text = "CANCELAR";
            button_CancelaProduto.UseVisualStyleBackColor = true;
            button_CancelaProduto.Click += button_CancelaProduto_Click;
            // 
            // Button_LimpaCamposProduto
            // 
            Button_LimpaCamposProduto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Button_LimpaCamposProduto.Location = new Point(239, 365);
            Button_LimpaCamposProduto.Name = "Button_LimpaCamposProduto";
            Button_LimpaCamposProduto.Size = new Size(72, 26);
            Button_LimpaCamposProduto.TabIndex = 22;
            Button_LimpaCamposProduto.Text = "LIMPAR";
            Button_LimpaCamposProduto.UseVisualStyleBackColor = true;
            Button_LimpaCamposProduto.Click += Button_LimpaCamposProduto_Click;
            // 
            // button_ConfirmarCadastroProduto
            // 
            button_ConfirmarCadastroProduto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_ConfirmarCadastroProduto.Location = new Point(125, 365);
            button_ConfirmarCadastroProduto.Name = "button_ConfirmarCadastroProduto";
            button_ConfirmarCadastroProduto.Size = new Size(97, 26);
            button_ConfirmarCadastroProduto.TabIndex = 21;
            button_ConfirmarCadastroProduto.Text = "CADASTRAR";
            button_ConfirmarCadastroProduto.UseVisualStyleBackColor = true;
            button_ConfirmarCadastroProduto.Click += button_ConfirmarCadastroProduto_Click;
            // 
            // listView_Produtos
            // 
            listView_Produtos.Columns.AddRange(new ColumnHeader[] { columnHeader_IDProduto, columnHeader_NomeProduto, columnHeader_Fornecedor, columnHeader_Preço });
            listView_Produtos.Location = new Point(429, 71);
            listView_Produtos.Name = "listView_Produtos";
            listView_Produtos.Size = new Size(349, 366);
            listView_Produtos.TabIndex = 20;
            listView_Produtos.UseCompatibleStateImageBehavior = false;
            listView_Produtos.View = View.Details;
            // 
            // columnHeader_IDProduto
            // 
            columnHeader_IDProduto.Text = "ID";
            columnHeader_IDProduto.Width = 45;
            // 
            // columnHeader_NomeProduto
            // 
            columnHeader_NomeProduto.Text = "Produto";
            columnHeader_NomeProduto.Width = 100;
            // 
            // columnHeader_Fornecedor
            // 
            columnHeader_Fornecedor.Text = "Fornecedor";
            columnHeader_Fornecedor.Width = 145;
            // 
            // maskedTextBox_PesquisaCNPJ
            // 
            maskedTextBox_PesquisaCNPJ.Location = new Point(125, 253);
            maskedTextBox_PesquisaCNPJ.Mask = "00,000,000/0000-00";
            maskedTextBox_PesquisaCNPJ.Name = "maskedTextBox_PesquisaCNPJ";
            maskedTextBox_PesquisaCNPJ.Size = new Size(97, 23);
            maskedTextBox_PesquisaCNPJ.TabIndex = 19;
            maskedTextBox_PesquisaCNPJ.TextChanged += maskedTextBox_PesquisaCNPJ_TextChanged;
            maskedTextBox_PesquisaCNPJ.KeyPress += maskedTextBox_PesquisaCNPJ_KeyPress;
            // 
            // textBox_FonecedorProduto
            // 
            textBox_FonecedorProduto.Enabled = false;
            textBox_FonecedorProduto.Location = new Point(228, 253);
            textBox_FonecedorProduto.Name = "textBox_FonecedorProduto";
            textBox_FonecedorProduto.Size = new Size(183, 23);
            textBox_FonecedorProduto.TabIndex = 18;
            // 
            // label_Fornecedor
            // 
            label_Fornecedor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Fornecedor.Location = new Point(3, 253);
            label_Fornecedor.Name = "label_Fornecedor";
            label_Fornecedor.Size = new Size(103, 23);
            label_Fornecedor.TabIndex = 17;
            label_Fornecedor.Text = "Fornecedor: ";
            // 
            // textBox_nomeProduto
            // 
            textBox_nomeProduto.Location = new Point(125, 98);
            textBox_nomeProduto.Name = "textBox_nomeProduto";
            textBox_nomeProduto.Size = new Size(286, 23);
            textBox_nomeProduto.TabIndex = 16;
            textBox_nomeProduto.KeyPress += textBox_nomeProduto_KeyPress;
            // 
            // label_nomeProduto
            // 
            label_nomeProduto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_nomeProduto.Location = new Point(12, 98);
            label_nomeProduto.Name = "label_nomeProduto";
            label_nomeProduto.Size = new Size(71, 23);
            label_nomeProduto.TabIndex = 15;
            label_nomeProduto.Text = "Nome:";
            // 
            // label_CadastrarProduto
            // 
            label_CadastrarProduto.Dock = DockStyle.Top;
            label_CadastrarProduto.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_CadastrarProduto.ImageAlign = ContentAlignment.TopCenter;
            label_CadastrarProduto.Location = new Point(0, 0);
            label_CadastrarProduto.Name = "label_CadastrarProduto";
            label_CadastrarProduto.Size = new Size(790, 30);
            label_CadastrarProduto.TabIndex = 12;
            label_CadastrarProduto.Text = "CADASTRAR PRODUTO\r\n\r\n";
            label_CadastrarProduto.TextAlign = ContentAlignment.TopCenter;
            // 
            // columnHeader_Preço
            // 
            columnHeader_Preço.Text = "Preço";
            columnHeader_Preço.Width = 55;
            // 
            // FormCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 510);
            Controls.Add(panel1);
            Controls.Add(label_Titulo);
            Name = "FormCadastroProduto";
            Text = "FormCadastroProduto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label_Titulo;
        private Panel panel1;
        private Label label_CadastrarProduto;
        private Label label_nomeProduto;
        private TextBox textBox_nomeProduto;
        private Label label_Fornecedor;
        private TextBox textBox_FonecedorProduto;
        private MaskedTextBox maskedTextBox_PesquisaCNPJ;
        private ListView listView_Produtos;
        private ColumnHeader columnHeader_IDProduto;
        private ColumnHeader columnHeader_NomeProduto;
        private ColumnHeader columnHeader_Fornecedor;
        private Button button_ConfirmarCadastroProduto;
        private Button Button_LimpaCamposProduto;
        private Button button_CancelaProduto;
        private Label label_ValorUnit;
        private TextBox textBox_ValorUnit;
        private TextBox textBox_IDFornecedor;
        private ColumnHeader columnHeader_Preço;
    }
}