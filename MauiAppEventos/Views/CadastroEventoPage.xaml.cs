using MauiAppEventos.Models;

namespace MauiAppEventos.Views
{
    public partial class CadastroEventoPage : ContentPage
    {
        public CadastroEventoPage()
        {
            InitializeComponent();
        }

        private async void OnSalvarClicked(object sender, EventArgs e)
        {
            var novoEvento = new Evento
            {
                Nome = entryNome.Text,
                DataInicio = datePickerDataInicio.Date,
                DataTermino = datePickerDataTermino.Date,
                NumeroParticipantes = int.Parse(entryNumeroParticipantes.Text),
                Local = entryLocal.Text,
                CustoPorParticipante = double.Parse(entryCustoPorParticipante.Text)
            };

            await Navigation.PushAsync(new ResumoEventoPage
            {
                BindingContext = novoEvento
            });
        }
    }
}
