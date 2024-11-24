namespace Burguer_Manager.Pages
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
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
    }
}
