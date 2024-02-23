
namespace State.ExemploIdeal
{
    partial class VendaProduto
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

        #region Component Designer generated code

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
            this.pnProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).BeginInit();
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
            this.pnProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnProdutos.Location = new System.Drawing.Point(0, 0);
            this.pnProdutos.Name = "pnProdutos";
            this.pnProdutos.Size = new System.Drawing.Size(1057, 635);
            this.pnProdutos.TabIndex = 3;
            // 
            // cmdVendaAvancar
            // 
            this.cmdVendaAvancar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdVendaAvancar.BackColor = System.Drawing.Color.OliveDrab;
            this.cmdVendaAvancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdVendaAvancar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdVendaAvancar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdVendaAvancar.Location = new System.Drawing.Point(882, 548);
            this.cmdVendaAvancar.Name = "cmdVendaAvancar";
            this.cmdVendaAvancar.Size = new System.Drawing.Size(158, 73);
            this.cmdVendaAvancar.TabIndex = 8;
            this.cmdVendaAvancar.Text = "Avançar";
            this.cmdVendaAvancar.UseVisualStyleBackColor = false;
            // 
            // cmdAdicionarProduto
            // 
            this.cmdAdicionarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAdicionarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(104)))), ((int)(((byte)(225)))));
            this.cmdAdicionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAdicionarProduto.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdAdicionarProduto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdAdicionarProduto.Location = new System.Drawing.Point(882, 11);
            this.cmdAdicionarProduto.Name = "cmdAdicionarProduto";
            this.cmdAdicionarProduto.Size = new System.Drawing.Size(158, 73);
            this.cmdAdicionarProduto.TabIndex = 7;
            this.cmdAdicionarProduto.Text = "Adicionar";
            this.cmdAdicionarProduto.UseVisualStyleBackColor = false;
            this.cmdAdicionarProduto.Click += new System.EventHandler(this.cmdAdicionarProduto_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(755, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Preco:";
            // 
            // txtPreco
            // 
            this.txtPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(84)))), ((int)(((byte)(221)))));
            this.txtPreco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPreco.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPreco.Location = new System.Drawing.Point(755, 42);
            this.txtPreco.Multiline = true;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(113, 37);
            this.txtPreco.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(598, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(84)))), ((int)(((byte)(221)))));
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantidade.ForeColor = System.Drawing.SystemColors.Window;
            this.txtQuantidade.Location = new System.Drawing.Point(598, 42);
            this.txtQuantidade.Multiline = true;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(151, 37);
            this.txtQuantidade.TabIndex = 3;
            // 
            // grdProdutos
            // 
            this.grdProdutos.AllowUserToAddRows = false;
            this.grdProdutos.AllowUserToDeleteRows = false;
            this.grdProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grdProdutos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.grdProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeProduto,
            this.Quantidade,
            this.Preco});
            this.grdProdutos.Location = new System.Drawing.Point(7, 118);
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
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produto:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(84)))), ((int)(((byte)(221)))));
            this.txtNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeProduto.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNomeProduto.Location = new System.Drawing.Point(14, 42);
            this.txtNomeProduto.Multiline = true;
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(578, 37);
            this.txtNomeProduto.TabIndex = 0;
            // 
            // VendaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnProdutos);
            this.Name = "VendaProduto";
            this.Size = new System.Drawing.Size(1057, 635);
            this.pnProdutos.ResumeLayout(false);
            this.pnProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).EndInit();
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
    }
}
