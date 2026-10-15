using AppCoordinamento.Classi;
using System.Globalization;

namespace AppCoordinamento;

public partial class DetailPages : ContentPage
{

    private Studente _studente_selezionato;
    public DetailPages()
    {
        InitializeComponent();
    }

    private void ContentPage_Loaded(object sender, EventArgs e)
    {
        _studente_selezionato = Global.Classe.Get(Global.Indiceelezionato);

        if (_studente_selezionato != null)
        {
            TxtMatricola.Text = _studente_selezionato.Matricola;
            TxtNome.Text = _studente_selezionato.Nome;
            TxtCognome.Text = _studente_selezionato.Cognome;
            TxtITA.Text = _studente_selezionato.Ita.ToString();
            TxtSTO.Text = _studente_selezionato.Sto.ToString();
            TxtENG.Text = _studente_selezionato.Eng.ToString();
            TxtTED.Text = _studente_selezionato.Ted.ToString();
            TxtMAT.Text = _studente_selezionato.Mat.ToString();
            TxtINF.Text = _studente_selezionato.Inf.ToString();
            TxtECO.Text = _studente_selezionato.Eco.ToString();
            TxtDIR.Text = _studente_selezionato.Dir.ToString();
            TxtECOP.Text = _studente_selezionato.Ecop.ToString();
            TxtECC.Text = _studente_selezionato.Ecc.ToString();
            TxtIRC.Text = _studente_selezionato.Irc.ToString();

            
        }
    }

    private async void BtnAggiungi_Clicked(object sender, EventArgs e)
    {
        string matricola;
        string nome;
        string cognome;
        float ita;
        float sto;
        float eng;
        float ted;
        float mat;
        float inf;
        float eco;
        float dir;
        float ecop;
        float ecc;
        float irc;

        if (string.IsNullOrEmpty(TxtMatricola.Text || string.IsNullOrEmpty(TxtMatricola.Text)
        { 
            await Visualizzaerrore("alcuni dati obbligatori non sono stati completati");
        }
        else
        {
            try
            {
                AcquisisciDati(out matricola, out nome, out cognome, out ita, out sto, out eng, out ted, out mat, out inf, out eco, out dir, out ecop, out ecc, out irc)

            }
                if (_studente_selezionato != null)
            {
                _studente_selezionato.Matricola = matricola;
                _studente_selezionato.Nome= nome;  

            }
            else
            {
                bool trovato = Global.Classe.Trova(matricola);
                if (trovato == true)
                {
                    await Visualizzaerrore("la matricola è giàpresente");
                }
                else
                {
                    Global.Classe.CreaEInserisci(matricola, nome, cognome, ita, sto, eng, ted, mat, inf, eco, dir, ecop, ecc, irc);
              
                }
                
            } 
                
        } 
    }
       
    private async void BtnElimina_Clicked(object sender, EventArgs e)
    {
        if (_studente_selezionato != null)
        {
            Global.ClasseStudenti.Ellimina(Global.Indiceelezionato);
            await TornaIndietro();
        }
    }

    private async void BtnAnnulla_Clicked(object sender, EventArgs e)
    {
        await TornaIndietro();
    }
    private async Task TornaIndietro()
    {
        await Navigation.PopAsync();
    }
    private void AcquisisciDati(out string matricola, out string nome, out string cognome, out float ita, out float sto, out float eng, out float ted, out float mat, out float inf, out float eco, out float dir, out float ecop, out float ecc, out float irc)
    {
        matricola = TxtMatricola.text;
        nome = TxtNome.text;
        cognome = TxtCognome.text;
        ita = Convert.ToSingle(TxtITA.Text);
        sto = Convert.ToSingle(TxtSTO.Text);
        eng = Convert.ToSingle(TxtENG.Text);
        ted = Convert.ToSingle(TxtTED.Text);
        mat = Convert.ToSingle(TxtMAT.Text);
        inf = Convert.ToSingle(TxtINF.Text);
        eco = Convert.ToSingle(TxtECO.Text);
        dir = Convert.ToSingle(TxtDIR.Text);
        ecop = Convert.ToSingle(TxtECOP.Text);
        ecc = Convert.ToSingle(TxtECC.Text);
        irc = Convert.ToSingle(TxtIRC.Text);















    }
}