namespace Burguer_Manager.Pages;

public partial class UserMenuPage : ContentPage
{
	public UserMenuPage()
	{
		InitializeComponent();
	}

    private async void OnReservarButtonClicked(object sender, EventArgs e)
    {
        // Navegar para outra p�gina
        await Navigation.PushAsync(new UserReserva()); // Substitua por outra p�gina se necess�rio
    }
}