using Microsoft.Maui.Controls;
using System.Collections.Generic;

namespace Burguer_Manager.Pages
{
    public partial class ReservasPage : ContentPage
    {
        // Lista de op��es de status global
        public List<string> StatusOptions { get; set; }

        // Lista de reservas
        public List<Reserva> Reservas { get; set; }

        public ReservasPage()
        {
            InitializeComponent();

            // Inicializando a lista de op��es de status
            StatusOptions = new List<string> { "Pendente", "Confirmada", "Completa" };

            // Inicializando a lista de reservas com status "Pendente"
            Reservas = new List<Reserva>
            {
                new Reserva { Cliente = "Jo�o", HorarioReserva = "18:00", NumeroPessoas = 2, Status = "Pendente" },
                new Reserva { Cliente = "Maria", HorarioReserva = "19:00", NumeroPessoas = 4, Status = "Pendente" }
            };

            // Definindo o binding da lista de reservas
            BindingContext = this;
        }

        private void OnStatusChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            var selectedStatus = (string)picker.SelectedItem;
            var reserva = (Reserva)picker.BindingContext;

            // Atualizando o status da reserva
            reserva.Status = selectedStatus;
        }

        private void OnSaveChangesClicked(object sender, EventArgs e)
        {
            // Aqui voc� pode salvar as mudan�as feitas
            // Exemplo: salvar no banco de dados ou em um modelo
            DisplayAlert("Altera��es Salvas", "As altera��es de status foram salvas com sucesso.", "OK");
        }
    }

    public class Reserva
    {
        public string Cliente { get; set; }
        public string HorarioReserva { get; set; }
        public int NumeroPessoas { get; set; }
        public string Status { get; set; }
    }
}
