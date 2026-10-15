using AppCoordinamento.Classi;

namespace AppCoordinamento
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void AggiornaLista()
        {
            // devo visualizzare la lista aggiornata
            LstStudenti.ItemsSource = null;
            LstStudenti.ItemsSource = Global.Classe.ListaStudenti;

            Global.IndiceSelezionato = -1;
        }

        private void AggiornaNumeroPromossi()
        {
            int numeroPromossi = Global.Classe.N_Promossi(); ;
            LblNumeroPromossi.Text = "Numero promossi: " + numeroPromossi.ToString();
        }

        private void AggiornaNumeroBocciati()
        {
            int numeroBocciati = Global.Classe.N_Bocciati(); ;
            LblNumeroBocciati.Text = "Numero bocciati: " + numeroBocciati.ToString();
        }

        private void ResetSelezione()
        {
            Global.IndiceSelezionato = -1;
            LstStudenti.SelectedItem = null;
        }

        private async void BtnAggiungi_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DetailPage());
        }

        private async void LstStudenti_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Global.IndiceSelezionato = e.SelectedItemIndex;

            if (Global.IndiceSelezionato != -1)
            {
                await Navigation.PushAsync(new DetailPage()); // in alternativa costruttore con indice
            }
        }

        private void ContentPage_Loaded(object sender, EventArgs e)
        {
            ResetSelezione();
            AggiornaLista();
            AggiornaNumeroPromossi();
            AggiornaNumeroBocciati();
        }
    }

}
