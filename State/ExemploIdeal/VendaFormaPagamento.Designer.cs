
namespace State.ExemploIdeal
{
    partial class VendaFormaPagamento
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
            this.pnFormaPagamento = new System.Windows.Forms.Panel();
            this.cmdPagamentoVoltar = new System.Windows.Forms.Button();
            this.cmdFinalizar = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pnFormaPagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnFormaPagamento
            // 
            this.pnFormaPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(51)))), ((int)(((byte)(132)))));
            this.pnFormaPagamento.Controls.Add(this.cmdPagamentoVoltar);
            this.pnFormaPagamento.Controls.Add(this.cmdFinalizar);
            this.pnFormaPagamento.Controls.Add(this.radioButton3);
            this.pnFormaPagamento.Controls.Add(this.radioButton2);
            this.pnFormaPagamento.Controls.Add(this.radioButton1);
            this.pnFormaPagamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFormaPagamento.Location = new System.Drawing.Point(0, 0);
            this.pnFormaPagamento.Name = "pnFormaPagamento";
            this.pnFormaPagamento.Size = new System.Drawing.Size(1057, 635);
            this.pnFormaPagamento.TabIndex = 11;
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
            // VendaFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnFormaPagamento);
            this.Name = "VendaFormaPagamento";
            this.Size = new System.Drawing.Size(1057, 635);
            this.pnFormaPagamento.ResumeLayout(false);
            this.pnFormaPagamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnFormaPagamento;
        private System.Windows.Forms.Button cmdPagamentoVoltar;
        private System.Windows.Forms.Button cmdFinalizar;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}
