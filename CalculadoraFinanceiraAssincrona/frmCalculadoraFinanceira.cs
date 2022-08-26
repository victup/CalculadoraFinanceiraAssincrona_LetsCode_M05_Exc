using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalculadoraFinanceiraAssincrona
{
    public partial class frmCalculadoraFinanceira : Form
    {
        public double FolhaDePagamento { get; set; } = 0;
        public double Impostos { get; set; } = 0;
        public double Receitas { get; set; } = 0;
        public double Despesas { get; set; } = 0;
        public Dictionary<string, double> ImpostosPorNome { get; set; } = new();

        public frmCalculadoraFinanceira()
        {
            InitializeComponent();
        }

        private async void btnLancar_Click(object sender, EventArgs e)
        {
            btnLancar.Enabled = false;

            await CalcularFinancas();
            
            btnLancar.Enabled = true;

            txtPagamento.Text = String.Empty;
            txtNomeImposto.Text = String.Empty;
            txtValorImposto.Text = String.Empty;
            txtReceita.Text = String.Empty; 
            txtDespesa.Text = String.Empty;
        }

        private async Task<double> CalcularFolhaDePagamento(double valorPagamento)
        {
            await Task.Delay(TimeSpan.FromSeconds(4));
            return FolhaDePagamento += valorPagamento;
        }

        private async Task CalcularImpostos()
        {
            await Task.Delay(TimeSpan.FromSeconds(4));

            if (ImpostosPorNome.ContainsKey(txtNomeImposto.Text))
            {
                foreach (KeyValuePair<string, double> item in ImpostosPorNome)
                {
                    if (item.Key == txtNomeImposto.Text)
                    {
                        ImpostosPorNome[item.Key] += ValidarEntradaNumerica(txtValorImposto.Text);
                    }
                }
            }
                
            else
                ImpostosPorNome.Add(txtNomeImposto.Text, ValidarEntradaNumerica(txtValorImposto.Text));


        }

        private async Task<double> CalcularReceitas(double receitas)
        {
            await Task.Delay(TimeSpan.FromSeconds(4));
            return Receitas += receitas;

        }

        private async Task<double> CalcularDespesas(double despesas)
        {
            await Task.Delay(TimeSpan.FromSeconds(4));
            return Despesas += despesas;
        }

        private async Task CalcularFinancas()
        {
            Stopwatch stopwatch = new();

            stopwatch.Start();

            lbResultado.Visible = false;
            lblMensagem.Visible = true;


            var pagamentos = CalcularFolhaDePagamento(ValidarEntradaNumerica(txtPagamento.Text));
            var impostos = CalcularImpostos();
            var receitas = CalcularReceitas(ValidarEntradaNumerica(txtReceita.Text));
            var despesas = CalcularDespesas(ValidarEntradaNumerica(txtDespesa.Text));

            lblMensagem.ForeColor = Color.Blue;

            
            lblMensagem.Text = $"Estamos registrando o último pagamento. Aguarde o processamento.";
            await Task.Delay(TimeSpan.FromSeconds(1));
            await pagamentos;
            lblMensagem.Text = $"Estamos registrando o último imposto. Aguarde o processamento.";
            await Task.Delay(TimeSpan.FromSeconds(1));
            await impostos;
            lblMensagem.Text = $"Estamos registrando a última receita. Aguarde o processamento.";
            await Task.Delay(TimeSpan.FromSeconds(1));
            await receitas;
            lblMensagem.Text = $"Estamos registrando a última despesa. Aguarde o processamento.";
            await Task.Delay(TimeSpan.FromSeconds(1));
            await despesas;
            
            

            FolhaDePagamento = pagamentos.Result;        
            Receitas = receitas.Result;
            Despesas = despesas.Result;

            lblMensagem.Text = $"Agora estamos imprimindo a relação final. Só mais alguns instantes.";
            lblMensagem.ForeColor = Color.Green;

            lbResultado.Items.Clear();
            await Task.Delay(TimeSpan.FromSeconds(5));

            

            lbResultado.Visible = true;

            lbResultado.Items.Add($"Folha de pagamento: R$ {FolhaDePagamento}");

            foreach (KeyValuePair<string, double> item in ImpostosPorNome)
            {
                lbResultado.Items.Add($"Imposto {item.Key}: R$ {item.Value}");
            }

            lbResultado.Items.Add($"Receitas: R$ {Receitas}");
            lbResultado.Items.Add($"Despesas: R$ {Despesas}");

            lblMensagem.Text = $"Todo o processo durou: {stopwatch.Elapsed.TotalSeconds} segundos";
            lblMensagem.ForeColor = Color.Blue;
            stopwatch.Stop();
        }

        private double ValidarEntradaNumerica(string valor)
        {
            double valorValidado = 0;
            var rgx = new Regex(@"^-?[0-9,\.]+$");
            if (rgx.IsMatch(valor))
            {
                valorValidado = double.Parse(valor);    
            }

            return valorValidado;
        }

    }
}
