namespace MauiAppCalculadora
{
    public partial class MainPage : ContentPage
    {
        string? operacao = null;
        double memoria_calc_pre_operacao = 0;
        double memoria_calc_pos_operacao = 0;
        string aparecer_visor = "";

        public MainPage()
        {
            InitializeComponent();
        }

        private void remover_sinais()
        {
            if (aparecer_visor == "+" || 
                aparecer_visor == "-" ||
                aparecer_visor == "*" ||
                aparecer_visor == "/")
            {
                aparecer_visor = "";
            }
        }
        private void zerar_Clicked(object sender, EventArgs e)
        {
            visor.Text = "0";
            aparecer_visor = "";
            memoria_calc_pos_operacao = 0;
            memoria_calc_pre_operacao = 0;
            operacao = null;

        }

        private void maismenos_Clicked(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(visor.Text);
            valor = valor * -1;
            visor.Text = valor.ToString();
        }

        private void porcento_Clicked(System.Object sender, System.EventArgs e)
        {
            double valor = Convert.ToDouble(visor.Text);
            valor = valor / 100;
            visor.Text = valor.ToString();
        }
        private void dividir_Clicked(object sender, EventArgs e)
        {
           memoria_calc_pre_operacao = Convert.ToDouble(visor.Text);
            aparecer_visor = "/";
            operacao = "/";
            visor.Text = aparecer_visor;
        }

        private void num7_Clicked(object sender, EventArgs e)
        {
            remover_sinais();
            aparecer_visor += num7.Text;
            visor.Text = aparecer_visor;
        }

        private void num8_Clicked(object sender, EventArgs e)
        {
            remover_sinais();
            aparecer_visor += num8.Text;
            visor.Text = aparecer_visor;
        }

        private void num9_Clicked(object sender, EventArgs e)
        {
            remover_sinais();
            aparecer_visor += num9.Text;
            visor.Text = aparecer_visor;
        }

        private void multiplicar_Clicked(object sender, EventArgs e)
        {
            memoria_calc_pre_operacao = Convert.ToDouble(visor.Text);
            aparecer_visor = "*";
            operacao = "*";
            visor.Text = aparecer_visor;
        }

        private void num4_Clicked(object sender, EventArgs e)
        {
            remover_sinais();
            aparecer_visor += num4.Text;
            visor.Text = aparecer_visor;
        }

        private void num5_Clicked(object sender, EventArgs e)
        {
            remover_sinais();
            aparecer_visor += num5.Text;
            visor.Text = aparecer_visor;
        }

        private void num6_Clicked(object sender, EventArgs e)
        {
            remover_sinais();
            aparecer_visor += num6.Text;
            visor.Text = aparecer_visor;
        }

        private void subtracao_Clicked(object sender, EventArgs e)
        {
            memoria_calc_pre_operacao = Convert.ToDouble(visor.Text);
            aparecer_visor = "-";
            operacao = "-";
            visor.Text = aparecer_visor;
        }

        private void num1_Clicked(object sender, EventArgs e)
        {
            remover_sinais();
            aparecer_visor += num1.Text;
            visor.Text = aparecer_visor;
        }

        private void num2_Clicked(object sender, EventArgs e)
        {
            remover_sinais();
            aparecer_visor += num2.Text;
            visor.Text = aparecer_visor;
        }

        private void num3_Clicked(object sender, EventArgs e)
        {
            remover_sinais();
            aparecer_visor += num3.Text;
            visor.Text = aparecer_visor;
        }

        private void adicao_Clicked(object sender, EventArgs e)
        {
            memoria_calc_pre_operacao = Convert.ToDouble(visor.Text);
            aparecer_visor = "+";
            operacao = "+";
            visor.Text = aparecer_visor;
        }

        private void num0_Clicked(object sender, EventArgs e)
        {
            remover_sinais();
            aparecer_visor += num0.Text;
            visor.Text = aparecer_visor;
        }

        private void ponto_Clicked(object sender, EventArgs e)
        {
            aparecer_visor += ponto.Text;
            visor.Text = aparecer_visor;
        }

        private void igual_Clicked(object sender, EventArgs e)
        {
            try
            {
                memoria_calc_pos_operacao = Convert.ToDouble(visor.Text);
                double resultado = 0;
                switch(operacao)
                {
                    case "+":
                        resultado = memoria_calc_pre_operacao + memoria_calc_pos_operacao;
                        break;
                    case "-":
                        resultado = memoria_calc_pre_operacao - memoria_calc_pos_operacao;
                        break;
                    case "*":
                        resultado = memoria_calc_pre_operacao * memoria_calc_pos_operacao;
                        break;
                    case "/":
                        resultado = memoria_calc_pre_operacao / memoria_calc_pos_operacao;
                        break;
                }
                visor.Text = resultado.ToString();
            } catch ( Exception ex )
            { 
                visor.Text = ex.Message;
            }
        }
    }

}
