using Burguer_Manager.Pages;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;

namespace Burguer_Manager
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            
            
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            // Navegar para outra p�gina
            await Navigation.PushAsync(new MenuPage()); // Substitua por outra p�gina se necess�rio
        }

    }
}
