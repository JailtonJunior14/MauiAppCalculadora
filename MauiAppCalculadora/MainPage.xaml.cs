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

        }
        private void dividir_Clicked(object sender, EventArgs e)
        {
           
        }

        private void num7_Clicked(object sender, EventArgs e)
        {

        }

        private void num8_Clicked(object sender, EventArgs e)
        {

        }

        private void num9_Clicked(object sender, EventArgs e)
        {

        }

        private void multiplicar_Clicked(object sender, EventArgs e)
        {

        }

        private void num4_Clicked(object sender, EventArgs e)
        {

        }

        private void num5_Clicked(object sender, EventArgs e)
        {

        }

        private void num6_Clicked(object sender, EventArgs e)
        {

        }

        private void subtracao_Clicked(object sender, EventArgs e)
        {

        }

        private void num1_Clicked(object sender, EventArgs e)
        {

        }

        private void num2_Clicked(object sender, EventArgs e)
        {

        }

        private void num3_Clicked(object sender, EventArgs e)
        {

        }

        private void adicao_Clicked(object sender, EventArgs e)
        {

        }

        private void num0_Clicked(object sender, EventArgs e)
        {

        }

        private void ponto_Clicked(object sender, EventArgs e)
        {

        }

        private void igual_Clicked(object sender, EventArgs e)
        {

        }
    }

}
