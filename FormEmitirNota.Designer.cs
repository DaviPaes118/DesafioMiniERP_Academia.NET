namespace MiniERP
{
    partial class FormEmitirNota
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
            label_CPF = new Label();
            maskedTextBox_CPF = new MaskedTextBox();
            textBox_nomeCliente = new TextBox();
            label_produtoID = new Label();
            textBox_ProdutoID = new TextBox();
            textBox_nomeProduto = new TextBox();
            label1 = new Label();
            numericUpDown_Quantidade = new NumericUpDown();
            listView_Produtos = new ListView();
            columnHeader_Produto = new ColumnHeader();
            columnHeader_Quantidade = new ColumnHeader();
            columnHeader_ValorUnit = new ColumnHeader();
            columnHeader_ValorTotal = new ColumnHeader();
            label_total = new Label();
            textBox_Total = new TextBox();
            button_CancelaNota = new Button();
            Button_LimpaCampos = new Button();
            button_AdicionarItem = new Button();
            button_EmitirNota = new Button();
            textBox_ValorUnit = new TextBox();
            label_ValorUnit = new Label();
            textBox_IDCliente = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Quantidade).BeginInit();
            SuspendLayout();
            // 
            // label_Titulo
            // 
            label_Titulo.Dock = DockStyle.Top;
            label_Titulo.Font = new Font("Cambria", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_Titulo.ImageAlign = ContentAlignment.TopCenter;
            label_Titulo.Location = new Point(0, 0);
            label_Titulo.Name = "label_Titulo";
            label_Titulo.Size = new Size(883, 61);
            label_Titulo.TabIndex = 1;
            label_Titulo.Text = "MINI ERP";
            label_Titulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // label_CPF
            // 
            label_CPF.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_CPF.Location = new Point(12, 100);
            label_CPF.Name = "label_CPF";
            label_CPF.Size = new Size(50, 23);
            label_CPF.TabIndex = 3;
            label_CPF.Text = "CPF: ";
            // 
            // maskedTextBox_CPF
            // 
            maskedTextBox_CPF.Location = new Point(68, 100);
            maskedTextBox_CPF.Mask = "000,000,000-00";
            maskedTextBox_CPF.Name = "maskedTextBox_CPF";
            maskedTextBox_CPF.Size = new Size(86, 23);
            maskedTextBox_CPF.TabIndex = 4;
            maskedTextBox_CPF.TextChanged += maskedTextBox_CPF_TextChanged;
            maskedTextBox_CPF.KeyPress += maskedTextBox_CPF_KeyPress;
            // 
            // textBox_nomeCliente
            // 
            textBox_nomeCliente.Enabled = false;
            textBox_nomeCliente.Location = new Point(160, 100);
            textBox_nomeCliente.Name = "textBox_nomeCliente";
            textBox_nomeCliente.Size = new Size(268, 23);
            textBox_nomeCliente.TabIndex = 5;
            // 
            // label_produtoID
            // 
            label_produtoID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_produtoID.Location = new Point(12, 176);
            label_produtoID.Name = "label_produtoID";
            label_produtoID.Size = new Size(118, 23);
            label_produtoID.TabIndex = 6;
            label_produtoID.Text = "ID do Produto: ";
            // 
            // textBox_ProdutoID
            // 
            textBox_ProdutoID.Location = new Point(136, 176);
            textBox_ProdutoID.Name = "textBox_ProdutoID";
            textBox_ProdutoID.Size = new Size(61, 23);
            textBox_ProdutoID.TabIndex = 7;
            textBox_ProdutoID.TextChanged += textBox_ProdutoID_TextChanged;
            // 
            // textBox_nomeProduto
            // 
            textBox_nomeProduto.Enabled = false;
            textBox_nomeProduto.Location = new Point(203, 176);
            textBox_nomeProduto.Name = "textBox_nomeProduto";
            textBox_nomeProduto.Size = new Size(225, 23);
            textBox_nomeProduto.TabIndex = 8;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 279);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 9;
            label1.Text = "Quantidade: ";
            // 
            // numericUpDown_Quantidade
            // 
            numericUpDown_Quantidade.Location = new Point(136, 279);
            numericUpDown_Quantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_Quantidade.Name = "numericUpDown_Quantidade";
            numericUpDown_Quantidade.Size = new Size(74, 23);
            numericUpDown_Quantidade.TabIndex = 10;
            numericUpDown_Quantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // listView_Produtos
            // 
            listView_Produtos.Columns.AddRange(new ColumnHeader[] { columnHeader_Produto, columnHeader_Quantidade, columnHeader_ValorUnit, columnHeader_ValorTotal });
            listView_Produtos.Location = new Point(470, 100);
            listView_Produtos.Name = "listView_Produtos";
            listView_Produtos.Size = new Size(395, 269);
            listView_Produtos.TabIndex = 11;
            listView_Produtos.UseCompatibleStateImageBehavior = false;
            listView_Produtos.View = View.Details;
            // 
            // columnHeader_Produto
            // 
            columnHeader_Produto.Text = "Produto";
            columnHeader_Produto.Width = 150;
            // 
            // columnHeader_Quantidade
            // 
            columnHeader_Quantidade.Text = "Qntd";
            // 
            // columnHeader_ValorUnit
            // 
            columnHeader_ValorUnit.Text = "Valor Unit.";
            columnHeader_ValorUnit.Width = 90;
            // 
            // columnHeader_ValorTotal
            // 
            columnHeader_ValorTotal.Text = "Valor Total";
            columnHeader_ValorTotal.Width = 90;
            // 
            // label_total
            // 
            label_total.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_total.Location = new Point(400, 375);
            label_total.Name = "label_total";
            label_total.Size = new Size(64, 23);
            label_total.TabIndex = 12;
            label_total.Text = "TOTAL: ";
            // 
            // textBox_Total
            // 
            textBox_Total.Enabled = false;
            textBox_Total.Location = new Point(470, 375);
            textBox_Total.Name = "textBox_Total";
            textBox_Total.Size = new Size(395, 23);
            textBox_Total.TabIndex = 13;
            // 
            // button_CancelaNota
            // 
            button_CancelaNota.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_CancelaNota.Location = new Point(215, 375);
            button_CancelaNota.Name = "button_CancelaNota";
            button_CancelaNota.Size = new Size(82, 26);
            button_CancelaNota.TabIndex = 24;
            button_CancelaNota.Text = "CANCELAR";
            button_CancelaNota.UseVisualStyleBackColor = true;
            button_CancelaNota.Click += button_CancelaNota_Click;
            // 
            // Button_LimpaCampos
            // 
            Button_LimpaCampos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Button_LimpaCampos.Location = new Point(137, 375);
            Button_LimpaCampos.Name = "Button_LimpaCampos";
            Button_LimpaCampos.Size = new Size(72, 26);
            Button_LimpaCampos.TabIndex = 25;
            Button_LimpaCampos.Text = "LIMPAR";
            Button_LimpaCampos.UseVisualStyleBackColor = true;
            Button_LimpaCampos.Click += Button_LimpaCampos_Click;
            // 
            // button_AdicionarItem
            // 
            button_AdicionarItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_AdicionarItem.Location = new Point(265, 276);
            button_AdicionarItem.Name = "button_AdicionarItem";
            button_AdicionarItem.Size = new Size(97, 26);
            button_AdicionarItem.TabIndex = 26;
            button_AdicionarItem.Text = "ADICIONAR";
            button_AdicionarItem.UseVisualStyleBackColor = true;
            button_AdicionarItem.Click += button_AdicionarItem_Click;
            // 
            // button_EmitirNota
            // 
            button_EmitirNota.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_EmitirNota.Location = new Point(48, 375);
            button_EmitirNota.Name = "button_EmitirNota";
            button_EmitirNota.Size = new Size(82, 26);
            button_EmitirNota.TabIndex = 27;
            button_EmitirNota.Text = "EMITIR";
            button_EmitirNota.UseVisualStyleBackColor = true;
            button_EmitirNota.Click += button_EmitirNota_Click;
            // 
            // textBox_ValorUnit
            // 
            textBox_ValorUnit.Enabled = false;
            textBox_ValorUnit.Location = new Point(137, 205);
            textBox_ValorUnit.Name = "textBox_ValorUnit";
            textBox_ValorUnit.Size = new Size(291, 23);
            textBox_ValorUnit.TabIndex = 28;
            // 
            // label_ValorUnit
            // 
            label_ValorUnit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_ValorUnit.Location = new Point(12, 205);
            label_ValorUnit.Name = "label_ValorUnit";
            label_ValorUnit.Size = new Size(100, 23);
            label_ValorUnit.TabIndex = 29;
            label_ValorUnit.Text = "Valor Unit.:";
            // 
            // textBox_IDCliente
            // 
            textBox_IDCliente.Enabled = false;
            textBox_IDCliente.Location = new Point(68, 71);
            textBox_IDCliente.Name = "textBox_IDCliente";
            textBox_IDCliente.Size = new Size(62, 23);
            textBox_IDCliente.TabIndex = 30;
            textBox_IDCliente.Visible = false;
            // 
            // FormEmitirNota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 427);
            Controls.Add(textBox_IDCliente);
            Controls.Add(label_ValorUnit);
            Controls.Add(textBox_ValorUnit);
            Controls.Add(button_EmitirNota);
            Controls.Add(button_AdicionarItem);
            Controls.Add(Button_LimpaCampos);
            Controls.Add(button_CancelaNota);
            Controls.Add(textBox_Total);
            Controls.Add(label_total);
            Controls.Add(listView_Produtos);
            Controls.Add(numericUpDown_Quantidade);
            Controls.Add(label1);
            Controls.Add(textBox_nomeProduto);
            Controls.Add(textBox_ProdutoID);
            Controls.Add(label_produtoID);
            Controls.Add(textBox_nomeCliente);
            Controls.Add(maskedTextBox_CPF);
            Controls.Add(label_CPF);
            Controls.Add(label_Titulo);
            Name = "FormEmitirNota";
            Text = "EmitirNota";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Quantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Titulo;
        private Label label_CPF;
        private MaskedTextBox maskedTextBox_CPF;
        private TextBox textBox_nomeCliente;
        private Label label_produtoID;
        private TextBox textBox_ProdutoID;
        private TextBox textBox_nomeProduto;
        private Label label1;
        private NumericUpDown numericUpDown_Quantidade;
        private ListView listView_Produtos;
        private ColumnHeader columnHeader_Produto;
        private ColumnHeader columnHeader_Quantidade;
        private ColumnHeader columnHeader_ValorUnit;
        private ColumnHeader columnHeader_ValorTotal;
        private Label label_total;
        private TextBox textBox_Total;
        private Button button_CancelaNota;
        private Button Button_LimpaCampos;
        private Button button_AdicionarItem;
        private Button button_EmitirNota;
        private TextBox textBox_ValorUnit;
        private Label label_ValorUnit;
        private TextBox textBox_IDCliente;
    }
}