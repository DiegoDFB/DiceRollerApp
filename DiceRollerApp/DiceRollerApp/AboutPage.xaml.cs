namespace DiceRollerApp;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

	private async void gitHubLink(object sender, EventArgs e)
	{
		await Launcher.OpenAsync("https://github.com/DiegoDFB/DiceRoller");
	}
}