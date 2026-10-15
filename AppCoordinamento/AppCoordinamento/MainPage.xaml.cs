using AppCoordinamento.Classi;

namespace AppCoordinamento
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnAggiungi_Clicked(object sender, EventArgs e)
        {
            ResetSelezione();
            await Navigation.PushAsync(new DetailPages());
        }
        private void ResetSelezione()
        {
            Global.Indiceelezionato = -1;
            LstStudenti.SelectedItem = null;
        }
        private void AggiornaLista()
        {
            LstStudenti.ItemsSource = null;
            LstStudenti.ItemsSource = Global.Classe.ListaStudenti;
        }

        private async void LstStudenti_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Global.Indiceelezionato= e.SelectedItemIndex;
            if(Global.Indiceelezionato! ==-1)
            {
                await Navigation.PushAsync(new DetailPages());
            }
        }
         private void ContentPage_Loaded(object sender, EventArgs e)
        {
            
        }

        

       
    }

}
