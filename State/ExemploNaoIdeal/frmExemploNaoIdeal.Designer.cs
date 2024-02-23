
namespace State.ExemploNaoIdeal
{
    partial class frmExemploNaoIdeal
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
            this.pnProdutos = new System.Windows.Forms.Panel();
            this.cmdVendaAvancar = new System.Windows.Forms.Button();
            this.cmdAdicionarProduto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.grdProdutos = new System.Windows.Forms.DataGridView();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.pnCliente = new System.Windows.Forms.Panel();
            this.cmdVoltarCliente = new System.Windows.Forms.Button();
            this.cmdAvancarCliente = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.pnFormaPagamento = new System.Windows.Forms.Panel();
            this.cmdPagamentoVoltar = new System.Windows.Forms.Button();
            this.cmdFinalizar = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pnProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).BeginInit();
            this.pnCliente.SuspendLayout();
            this.pnFormaPagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnProdutos
            // 
            this.pnProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(51)))), ((int)(((byte)(132)))));
            this.pnProdutos.Controls.Add(this.cmdVendaAvancar);
            this.pnProdutos.Controls.Add(this.cmdAdicionarProduto);
            this.pnProdutos.Controls.Add(this.label3);
            this.pnProdutos.Controls.Add(this.txtPreco);
            this.pnProdutos.Controls.Add(this.label2);
            this.pnProdutos.Controls.Add(this.txtQuantidade);
            this.pnProdutos.Controls.Add(this.grdProdutos);
            this.pnProdutos.Controls.Add(this.label1);
            this.pnProdutos.Controls.Add(this.txtNomeProduto);
            this.pnProdutos.Location = new System.Drawing.Point(0, 0);
            this.pnProdutos.Name = "pnProdutos";
            this.pnProdutos.Size = new System.Drawing.Size(1085, 617);
            this.pnProdutos.TabIndex = 2;
            // 
            // cmdVendaAvancar
            // 
            this.cmdVendaAvancar.BackColor = System.Drawing.Color.OliveDrab;
            this.cmdVendaAvancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdVendaAvancar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdVendaAvancar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdVendaAvancar.Location = new System.Drawing.Point(909, 529);
            this.cmdVendaAvancar.Name = "cmdVendaAvancar";
            this.cmdVendaAvancar.Size = new System.Drawing.Size(158, 73);
            this.cmdVendaAvancar.TabIndex = 8;
            this.cmdVendaAvancar.Text = "Avançar";
            this.cmdVendaAvancar.UseVisualStyleBackColor = false;
            this.cmdVendaAvancar.Click += new System.EventHandler(this.cmdProdutoAvancar_Click);
            // 
            // cmdAdicionarProduto
            // 
            this.cmdAdicionarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(104)))), ((int)(((byte)(225)))));
            this.cmdAdicionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAdicionarProduto.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdAdicionarProduto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdAdicionarProduto.Location = new System.Drawing.Point(909, 19);
            this.cmdAdicionarProduto.Name = "cmdAdicionarProduto";
            this.cmdAdicionarProduto.Size = new System.Drawing.Size(158, 73);
            this.cmdAdicionarProduto.TabIndex = 7;
            this.cmdAdicionarProduto.Text = "Adicionar";
            this.cmdAdicionarProduto.UseVisualStyleBackColor = false;
            this.cmdAdicionarProduto.Click += new System.EventHandler(this.cmdAdicionarProduto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(775, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Preco:";
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(84)))), ((int)(((byte)(221)))));
            this.txtPreco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPreco.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPreco.Location = new System.Drawing.Point(775, 52);
            this.txtPreco.Multiline = true;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(113, 37);
            this.txtPreco.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(618, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(84)))), ((int)(((byte)(221)))));
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantidade.ForeColor = System.Drawing.SystemColors.Window;
            this.txtQuantidade.Location = new System.Drawing.Point(618, 52);
            this.txtQuantidade.Multiline = true;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(151, 37);
            this.txtQuantidade.TabIndex = 3;
            // 
            // grdProdutos
            // 
            this.grdProdutos.AllowUserToAddRows = false;
            this.grdProdutos.AllowUserToDeleteRows = false;
            this.grdProdutos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.grdProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeProduto,
            this.Quantidade,
            this.Preco});
            this.grdProdutos.Location = new System.Drawing.Point(34, 104);
            this.grdProdutos.Name = "grdProdutos";
            this.grdProdutos.RowTemplate.Height = 25;
            this.grdProdutos.Size = new System.Drawing.Size(1033, 408);
            this.grdProdutos.TabIndex = 2;
            // 
            // NomeProduto
            // 
            this.NomeProduto.HeaderText = "Nome Do Produto";
            this.NomeProduto.MinimumWidth = 790;
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.Width = 790;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // Preco
            // 
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produto:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(84)))), ((int)(((byte)(221)))));
            this.txtNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeProduto.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNomeProduto.Location = new System.Drawing.Point(34, 52);
            this.txtNomeProduto.Multiline = true;
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(578, 37);
            this.txtNomeProduto.TabIndex = 0;
            // 
            // pnCliente
            // 
            this.pnCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(51)))), ((int)(((byte)(132)))));
            this.pnCliente.Controls.Add(this.cmdVoltarCliente);
            this.pnCliente.Controls.Add(this.cmdAvancarCliente);
            this.pnCliente.Controls.Add(this.label9);
            this.pnCliente.Controls.Add(this.txtCidade);
            this.pnCliente.Controls.Add(this.label8);
            this.pnCliente.Controls.Add(this.txtBairro);
            this.pnCliente.Controls.Add(this.label7);
            this.pnCliente.Controls.Add(this.txtNumero);
            this.pnCliente.Controls.Add(this.label6);
            this.pnCliente.Controls.Add(this.txtEndereco);
            this.pnCliente.Controls.Add(this.label5);
            this.pnCliente.Controls.Add(this.txtCpf);
            this.pnCliente.Controls.Add(this.label4);
            this.pnCliente.Controls.Add(this.txtNomeCliente);
            this.pnCliente.Location = new System.Drawing.Point(1, 1);
            this.pnCliente.Name = "pnCliente";
            this.pnCliente.Size = new System.Drawing.Size(1085, 617);
            this.pnCliente.TabIndex = 9;
            // 
            // cmdVoltarCliente
            // 
            this.cmdVoltarCliente.BackColor = System.Drawing.Color.Tomato;
            this.cmdVoltarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdVoltarCliente.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdVoltarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdVoltarCliente.Location = new System.Drawing.Point(12, 532);
            this.cmdVoltarCliente.Name = "cmdVoltarCliente";
            this.cmdVoltarCliente.Size = new System.Drawing.Size(158, 73);
            this.cmdVoltarCliente.TabIndex = 14;
            this.cmdVoltarCliente.Text = "Voltar";
            this.cmdVoltarCliente.UseVisualStyleBackColor = false;
            this.cmdVoltarCliente.Click += new System.EventHandler(this.cmdVoltarCliente_Click);
            // 
            // cmdAvancarCliente
            // 
            this.cmdAvancarCliente.BackColor = System.Drawing.Color.OliveDrab;
            this.cmdAvancarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAvancarCliente.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdAvancarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdAvancarCliente.Location = new System.Drawing.Point(915, 529);
            this.cmdAvancarCliente.Name = "cmdAvancarCliente";
            this.cmdAvancarCliente.Size = new System.Drawing.Size(158, 73);
            this.cmdAvancarCliente.TabIndex = 13;
            this.cmdAvancarCliente.Text = "Avançar";
            this.cmdAvancarCliente.UseVisualStyleBackColor = false;
            this.cmdAvancarCliente.Click += new System.EventHandler(this.cmdAvancarCliente_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(851, 484);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 28);
            this.label9.TabIndex = 12;
            this.label9.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(84)))), ((int)(((byte)(221)))));
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCidade.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCidade.Location = new System.Drawing.Point(950, 475);
            this.txtCidade.Multiline = true;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(123, 37);
            this.txtCidade.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(622, 484);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 28);
            this.label8.TabIndex = 10;
            this.label8.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(84)))), ((int)(((byte)(221)))));
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBairro.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBairro.Location = new System.Drawing.Point(722, 475);
            this.txtBairro.Multiline = true;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(123, 37);
            this.txtBairro.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(293, 484);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 28);
            this.label7.TabIndex = 8;
            this.label7.Text = "Numero";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(84)))), ((int)(((byte)(221)))));
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumero.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNumero.Location = new System.Drawing.Point(489, 475);
            this.txtNumero.Multiline = true;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(123, 37);
            this.txtNumero.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(293, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Endereco";
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(84)))), ((int)(((byte)(221)))));
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndereco.ForeColor = System.Drawing.SystemColors.Window;
            this.txtEndereco.Location = new System.Drawing.Point(489, 415);
            this.txtEndereco.Multiline = true;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(578, 37);
            this.txtEndereco.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(293, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "CPF";
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(84)))), ((int)(((byte)(221)))));
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCpf.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCpf.Location = new System.Drawing.Point(489, 344);
            this.txtCpf.Multiline = true;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(578, 37);
            this.txtCpf.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(293, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nome Do Cliente";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(84)))), ((int)(((byte)(221)))));
            this.txtNomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeCliente.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNomeCliente.Location = new System.Drawing.Point(489, 279);
            this.txtNomeCliente.Multiline = true;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(578, 37);
            this.txtNomeCliente.TabIndex = 1;
            // 
            // pnFormaPagamento
            // 
            this.pnFormaPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(51)))), ((int)(((byte)(132)))));
            this.pnFormaPagamento.Controls.Add(this.cmdPagamentoVoltar);
            this.pnFormaPagamento.Controls.Add(this.cmdFinalizar);
            this.pnFormaPagamento.Controls.Add(this.radioButton3);
            this.pnFormaPagamento.Controls.Add(this.radioButton2);
            this.pnFormaPagamento.Controls.Add(this.radioButton1);
            this.pnFormaPagamento.Location = new System.Drawing.Point(0, 0);
            this.pnFormaPagamento.Name = "pnFormaPagamento";
            this.pnFormaPagamento.Size = new System.Drawing.Size(1086, 618);
            this.pnFormaPagamento.TabIndex = 10;
            this.pnFormaPagamento.Visible = false;
            // 
            // cmdPagamentoVoltar
            // 
            this.cmdPagamentoVoltar.BackColor = System.Drawing.Color.Tomato;
            this.cmdPagamentoVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPagamentoVoltar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdPagamentoVoltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdPagamentoVoltar.Location = new System.Drawing.Point(34, 529);
            this.cmdPagamentoVoltar.Name = "cmdPagamentoVoltar";
            this.cmdPagamentoVoltar.Size = new System.Drawing.Size(158, 73);
            this.cmdPagamentoVoltar.TabIndex = 15;
            this.cmdPagamentoVoltar.Text = "Voltar";
            this.cmdPagamentoVoltar.UseVisualStyleBackColor = false;
            this.cmdPagamentoVoltar.Click += new System.EventHandler(this.cmdPagamentoVoltar_Click);
            // 
            // cmdFinalizar
            // 
            this.cmdFinalizar.BackColor = System.Drawing.Color.OliveDrab;
            this.cmdFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdFinalizar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdFinalizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdFinalizar.Location = new System.Drawing.Point(864, 516);
            this.cmdFinalizar.Name = "cmdFinalizar";
            this.cmdFinalizar.Size = new System.Drawing.Size(158, 73);
            this.cmdFinalizar.TabIndex = 14;
            this.cmdFinalizar.Text = "Finalizar";
            this.cmdFinalizar.UseVisualStyleBackColor = false;
            this.cmdFinalizar.Click += new System.EventHandler(this.cmdFinalizar_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton3.Location = new System.Drawing.Point(894, 456);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(83, 32);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Prazo";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton2.Location = new System.Drawing.Point(893, 403);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(93, 32);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Cartão";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton1.Location = new System.Drawing.Point(893, 354);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(112, 32);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Dinheiro";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // frmExemploNaoIdeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 617);
            this.Controls.Add(this.pnCliente);
            this.Controls.Add(this.pnProdutos);
            this.Controls.Add(this.pnFormaPagamento);
            this.Name = "frmExemploNaoIdeal";
            this.Text = "Form1";
            this.pnProdutos.ResumeLayout(false);
            this.pnProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).EndInit();
            this.pnCliente.ResumeLayout(false);
            this.pnCliente.PerformLayout();
            this.pnFormaPagamento.ResumeLayout(false);
            this.pnFormaPagamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnProdutos;
        private System.Windows.Forms.Button cmdVendaAvancar;
        private System.Windows.Forms.Button cmdAdicionarProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.DataGridView grdProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Panel pnCliente;
        private System.Windows.Forms.Button cmdVoltarCliente;
        private System.Windows.Forms.Button cmdAvancarCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Panel pnFormaPagamento;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button cmdFinalizar;
        private System.Windows.Forms.Button cmdPagamentoVoltar;
    }
}