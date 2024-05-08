using DiceRollerApp.Models;
namespace DiceRollerApp.Views;

public partial class DiceView : ContentPage
{
	public DiceView()
	{
		InitializeComponent();
	}

	private void RollBtn_Clicked(object sender, EventArgs e)
	{
		int quantidadeLados = Convert.ToInt32(Escolha.SelectedItem);
		Dice dice = new Dice(quantidadeLados);
		dice.Rolar();
		NumeroLadoSelecionado.Text = dice.NumeroSorteado.ToString();
	}
}