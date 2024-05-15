using DiceRollerApp.Models;
using DiceRollerApp.ViewModel;
namespace DiceRollerApp.Views;

public partial class DiceView : ContentPage
{
	public DiceView()
	{
		InitializeComponent();
		BindingContext = new DiceViewModel();
	}

}