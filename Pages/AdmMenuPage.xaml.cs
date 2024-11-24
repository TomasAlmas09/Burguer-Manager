namespace Burguer_Manager.Pages;

public partial class AdmMenuPage : ContentPage
{
	public AdmMenuPage()
	{
		InitializeComponent();
	}

    private async void OnReservasButtonClicked(object sender, EventArgs e)
    {
        // Navegar para outra página
        await Navigation.PushAsync(new ReservasPage()); // Substitua por outra página se necessário
    }

    private async void OnAddReservasButtonClicked(object sender, EventArgs e)
    {
        // Navegar para outra página
        await Navigation.PushAsync(new AddReservasPage()); // Substitua por outra página se necessário
    }

    private async void OnAddFuncButtonClicked(object sender, EventArgs e)
    {
        // Navegar para outra página
        await Navigation.PushAsync(new AddFuncPage()); // Substitua por outra página se necessário
    }

}