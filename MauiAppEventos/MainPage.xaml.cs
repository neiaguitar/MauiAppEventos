namespace MauiAppEventos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCadastrarEventoClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.CadastroEventoPage());
        }
    }
}
