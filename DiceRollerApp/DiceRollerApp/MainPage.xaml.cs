using System.Security.AccessControl;

namespace DiceRollerApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        int qtdLados;

        private void gravarIndex(object sender, EventArgs e)
        {
            int indice = Escolha.SelectedIndex;

            switch (indice)
            {
                case 0:
                    qtdLados = 4;
                    break;
                case 1:
                    qtdLados = 6;
                    break;
                case 2:
                    qtdLados = 10;
                    break;
                case 3:
                    qtdLados = 20;
                    break;
                case 4:
                    qtdLados = 100;
                    break;
            }

        }

        private void girarDado(object sender, EventArgs e)
        {

            int valorMax = qtdLados + 1;
            Random numeroAleatorio = new Random();
            int SelecaoLado = numeroAleatorio.Next(1, valorMax);
            NumeroLadoSelecionado.Text = SelecaoLado.ToString();
        }
    }
}
