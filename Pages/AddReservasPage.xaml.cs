using Microsoft.Maui.Controls;
using System;

namespace Burguer_Manager.Pages
{
    public partial class AddReservasPage : ContentPage
    {
        // Propriedades para o binding
        public DateTime ReservaData { get; set; }
        public TimeSpan ReservaHora { get; set; }

        public AddReservasPage()
        {
            InitializeComponent();

            // Definindo o valor inicial para a reserva
            ReservaData = DateTime.Now;
            ReservaHora = new TimeSpan(18, 0, 0); // Definir o hor�rio inicial, como 18:00

            // Vinculando os dados
            BindingContext = this;

            // Definindo a data m�nima e m�xima diretamente no code-behind
            DataReservaPicker.MinimumDate = DateTime.Now;
            DataReservaPicker.MaximumDate = DateTime.Now.AddDays(2); // 2 dia � frente
        }
    }
}
