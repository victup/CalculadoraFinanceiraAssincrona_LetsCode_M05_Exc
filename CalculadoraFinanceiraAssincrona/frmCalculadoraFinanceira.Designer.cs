namespace CalculadoraFinanceiraAssincrona
{
    partial class frmCalculadoraFinanceira
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
            this.lblPagamento = new System.Windows.Forms.Label();
            this.btnLancar = new System.Windows.Forms.Button();
            this.txtPagamento = new System.Windows.Forms.TextBox();
            this.lbResultado = new System.Windows.Forms.ListBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.txtValorImposto = new System.Windows.Forms.TextBox();
            this.lblValorImposto = new System.Windows.Forms.Label();
            this.txtNomeImposto = new System.Windows.Forms.TextBox();
            this.lblNomeImposto = new System.Windows.Forms.Label();
            this.txtReceita = new System.Windows.Forms.TextBox();
            this.lblReceita = new System.Windows.Forms.Label();
            this.txtDespesa = new System.Windows.Forms.TextBox();
            this.lblDespesa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.Location = new System.Drawing.Point(96, 27);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(68, 15);
            this.lblPagamento.TabIndex = 0;
            this.lblPagamento.Text = "Pagamento";
            // 
            // btnLancar
            // 
            this.btnLancar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLancar.Location = new System.Drawing.Point(270, 210);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(125, 35);
            this.btnLancar.TabIndex = 1;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = false;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // txtPagamento
            // 
            this.txtPagamento.Location = new System.Drawing.Point(96, 45);
            this.txtPagamento.MaxLength = 20;
            this.txtPagamento.Name = "txtPagamento";
            this.txtPagamento.Size = new System.Drawing.Size(128, 23);
            this.txtPagamento.TabIndex = 2;
            // 
            // lbResultado
            // 
            this.lbResultado.FormattingEnabled = true;
            this.lbResultado.ItemHeight = 15;
            this.lbResultado.Location = new System.Drawing.Point(154, 296);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(357, 184);
            this.lbResultado.TabIndex = 3;
            this.lbResultado.Visible = false;
            // 
            // lblMensagem
            // 
            this.lblMensagem.Location = new System.Drawing.Point(12, 263);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(649, 18);
            this.lblMensagem.TabIndex = 4;
            this.lblMensagem.Text = "label2";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensagem.Visible = false;
            // 
            // txtValorImposto
            // 
            this.txtValorImposto.Location = new System.Drawing.Point(270, 86);
            this.txtValorImposto.MaxLength = 20;
            this.txtValorImposto.Name = "txtValorImposto";
            this.txtValorImposto.Size = new System.Drawing.Size(157, 23);
            this.txtValorImposto.TabIndex = 6;
            // 
            // lblValorImposto
            // 
            this.lblValorImposto.AutoSize = true;
            this.lblValorImposto.Location = new System.Drawing.Point(270, 68);
            this.lblValorImposto.Name = "lblValorImposto";
            this.lblValorImposto.Size = new System.Drawing.Size(113, 15);
            this.lblValorImposto.TabIndex = 5;
            this.lblValorImposto.Text = "Valor do Imposto R$";
            // 
            // txtNomeImposto
            // 
            this.txtNomeImposto.Location = new System.Drawing.Point(96, 86);
            this.txtNomeImposto.MaxLength = 50;
            this.txtNomeImposto.Name = "txtNomeImposto";
            this.txtNomeImposto.Size = new System.Drawing.Size(168, 23);
            this.txtNomeImposto.TabIndex = 8;
            // 
            // lblNomeImposto
            // 
            this.lblNomeImposto.AutoSize = true;
            this.lblNomeImposto.Location = new System.Drawing.Point(96, 68);
            this.lblNomeImposto.Name = "lblNomeImposto";
            this.lblNomeImposto.Size = new System.Drawing.Size(104, 15);
            this.lblNomeImposto.TabIndex = 7;
            this.lblNomeImposto.Text = "Nome do Imposto";
            // 
            // txtReceita
            // 
            this.txtReceita.Location = new System.Drawing.Point(96, 128);
            this.txtReceita.MaxLength = 20;
            this.txtReceita.Name = "txtReceita";
            this.txtReceita.Size = new System.Drawing.Size(128, 23);
            this.txtReceita.TabIndex = 10;
            // 
            // lblReceita
            // 
            this.lblReceita.AutoSize = true;
            this.lblReceita.Location = new System.Drawing.Point(96, 110);
            this.lblReceita.Name = "lblReceita";
            this.lblReceita.Size = new System.Drawing.Size(45, 15);
            this.lblReceita.TabIndex = 9;
            this.lblReceita.Text = "Receita";
            // 
            // txtDespesa
            // 
            this.txtDespesa.Location = new System.Drawing.Point(96, 173);
            this.txtDespesa.MaxLength = 20;
            this.txtDespesa.Name = "txtDespesa";
            this.txtDespesa.Size = new System.Drawing.Size(128, 23);
            this.txtDespesa.TabIndex = 12;
            // 
            // lblDespesa
            // 
            this.lblDespesa.AutoSize = true;
            this.lblDespesa.Location = new System.Drawing.Point(96, 155);
            this.lblDespesa.Name = "lblDespesa";
            this.lblDespesa.Size = new System.Drawing.Size(50, 15);
            this.lblDespesa.TabIndex = 11;
            this.lblDespesa.Text = "Despesa";
            // 
            // frmCalculadoraFinanceira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 492);
            this.Controls.Add(this.txtDespesa);
            this.Controls.Add(this.lblDespesa);
            this.Controls.Add(this.txtReceita);
            this.Controls.Add(this.lblReceita);
            this.Controls.Add(this.txtNomeImposto);
            this.Controls.Add(this.lblNomeImposto);
            this.Controls.Add(this.txtValorImposto);
            this.Controls.Add(this.lblValorImposto);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.txtPagamento);
            this.Controls.Add(this.btnLancar);
            this.Controls.Add(this.lblPagamento);
            this.MaximizeBox = false;
            this.Name = "frmCalculadoraFinanceira";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Financeira Assíncrona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPagamento;
        private Button btnLancar;
        private TextBox txtPagamento;
        private ListBox lbResultado;
        private Label lblMensagem;
        private TextBox txtValorImposto;
        private Label lblValorImposto;
        private TextBox txtNomeImposto;
        private Label lblNomeImposto;
        private TextBox txtReceita;
        private Label lblReceita;
        private TextBox txtDespesa;
        private Label lblDespesa;
    }
}