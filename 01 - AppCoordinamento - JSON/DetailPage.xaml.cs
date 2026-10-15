using AppCoordinamento.Classi;

namespace AppCoordinamento;

public partial class DetailPage : ContentPage
{
    private Studente _studente_selezionato;

    public DetailPage()
    {
        InitializeComponent();
    }

    private async Task TornaIndietro()
    {
        await Navigation.PopAsync();
    }

    private void AcquisisciDati(out string matricola, out string nome, out string cognome, out float ita, out float sto, out float eng, out float ted, out float mat, out float inf, out float eco, out float dir, out float ecop, out float sci, out float irc, out float ecc)
    {
        matricola = TxtMatricola.Text;
        nome = TxtNome.Text;
        cognome = TxtCognome.Text;
        ita = Convert.ToSingle(TxtITA.Text);
        sto = Convert.ToSingle(TxtSTO.Text);
        eng = Convert.ToSingle(TxtENG.Text);
        ted = Convert.ToSingle(TxtTED.Text);
        mat = Convert.ToSingle(TxtMAT.Text);
        inf = Convert.ToSingle(TxtINF.Text);
        eco = Convert.ToSingle(TxtECO.Text);
        dir = Convert.ToSingle(TxtDIR.Text);
        ecop = Convert.ToSingle(TxtECOP.Text);
        sci = Convert.ToSingle(TxtSCI.Text);
        irc = Convert.ToSingle(TxtIRC.Text);
        ecc = Convert.ToSingle(TxtECC.Text);
    }

    private void PulisciForm()
    {
        TxtMatricola.Text = string.Empty;
        TxtNome.Text = string.Empty;
        TxtCognome.Text = string.Empty;
        TxtITA.Text = string.Empty;
        TxtSTO.Text = string.Empty;
        TxtENG.Text = string.Empty;
        TxtTED.Text = string.Empty;
        TxtMAT.Text = string.Empty;
        TxtINF.Text = string.Empty;
        TxtECO.Text = string.Empty;
        TxtDIR.Text = string.Empty;
        TxtECOP.Text = string.Empty;
        TxtSCI.Text = string.Empty;
        TxtIRC.Text = string.Empty;
        TxtECC.Text = string.Empty;
    }

    private async Task VisualizzaMessaggio(string messaggio)
    {
        await DisplayAlert("Errore", messaggio, "Ok");
    }

    private void ContentPage_Loaded(object sender, EventArgs e)
    {
        _studente_selezionato = Global.Classe.Get(Global.IndiceSelezionato);

        if (_studente_selezionato is not null)
        {
            TxtMatricola.Text = _studente_selezionato.Matricola;
            TxtNome.Text = _studente_selezionato.Nome;
            TxtCognome.Text = _studente_selezionato.Cognome;
            TxtITA.Text = _studente_selezionato.ITA.ToString();
            TxtSTO.Text = _studente_selezionato.STO.ToString();
            TxtENG.Text = _studente_selezionato.ENG.ToString();
            TxtTED.Text = _studente_selezionato.TED.ToString();
            TxtMAT.Text = _studente_selezionato.MAT.ToString();
            TxtINF.Text = _studente_selezionato.INF.ToString();
            TxtECO.Text = _studente_selezionato.ECO.ToString();
            TxtDIR.Text = _studente_selezionato.DIR.ToString();
            TxtECOP.Text = _studente_selezionato.ECOP.ToString();
            TxtSCI.Text = _studente_selezionato.SCI.ToString();
            TxtIRC.Text = _studente_selezionato.IRC.ToString();
            TxtECC.Text = _studente_selezionato.ECC.ToString();
        }
    }

    private async void TxtITA_Unfocused(object sender, FocusEventArgs e)
    {
        float voto;
        if (!string.IsNullOrEmpty(TxtITA.Text))
        {
            if (float.TryParse(TxtITA.Text, out voto))
            {
                if (voto < 1 || voto > 10)
                {
                    await VisualizzaMessaggio("Il voto deve essere compreso tra 1 e 10");
                    TxtITA.Text = string.Empty;
                    TxtITA.Focus();
                }
            }
            else
            {
                await VisualizzaMessaggio("L'importo non è numerico");
                TxtITA.Text = string.Empty;
                TxtITA.Focus();
            }
        }
    }

    private async void TxtSTO_Unfocused(object sender, FocusEventArgs e)
    {
        float voto;
        if (!string.IsNullOrEmpty(TxtSTO.Text))
        {
            if (float.TryParse(TxtSTO.Text, out voto))
            {
                if (voto < 1 || voto > 10)
                {
                    await VisualizzaMessaggio("Il voto deve essere compreso tra 1 e 10");
                    TxtSTO.Text = string.Empty;
                    TxtSTO.Focus();
                }
            }
            else
            {
                await VisualizzaMessaggio("L'importo non è numerico");
                TxtSTO.Text = string.Empty;
                TxtSTO.Focus();
            }
        }
    }

    private async void TxtENG_Unfocused(object sender, FocusEventArgs e)
    {
        float voto;
        if (!string.IsNullOrEmpty(TxtENG.Text))
        {
            if (float.TryParse(TxtENG.Text, out voto))
            {
                if (voto < 1 || voto > 10)
                {
                    await VisualizzaMessaggio("Il voto deve essere compreso tra 1 e 10");
                    TxtENG.Text = string.Empty;
                    TxtENG.Focus();
                }
            }
            else
            {
                await VisualizzaMessaggio("L'importo non è numerico");
                TxtENG.Text = string.Empty;
                TxtENG.Focus();
            }
        }
    }

    private async void TxtTED_Unfocused(object sender, FocusEventArgs e)
    {
        float voto;
        if (!string.IsNullOrEmpty(TxtTED.Text))
        {
            if (float.TryParse(TxtTED.Text, out voto))
            {
                if (voto < 1 || voto > 10)
                {
                    await VisualizzaMessaggio("Il voto deve essere compreso tra 1 e 10");
                    TxtTED.Text = string.Empty;
                    TxtTED.Focus();
                }
            }
            else
            {
                await VisualizzaMessaggio("L'importo non è numerico");
                TxtTED.Text = string.Empty;
                TxtTED.Focus();
            }
        }
    }

    private async void TxtMAT_Unfocused(object sender, FocusEventArgs e)
    {
        float voto;
        if (!string.IsNullOrEmpty(TxtMAT.Text))
        {
            if (float.TryParse(TxtMAT.Text, out voto))
            {
                if (voto < 1 || voto > 10)
                {
                    await VisualizzaMessaggio("Il voto deve essere compreso tra 1 e 10");
                    TxtMAT.Text = string.Empty;
                    TxtMAT.Focus();
                }
            }
            else
            {
                await VisualizzaMessaggio("L'importo non è numerico");
                TxtMAT.Text = string.Empty;
                TxtMAT.Focus();
            }
        }
    }

    private async void TxtINF_Unfocused(object sender, FocusEventArgs e)
    {
        float voto;
        if (!string.IsNullOrEmpty(TxtINF.Text))
        {
            if (float.TryParse(TxtINF.Text, out voto))
            {
                if (voto < 1 || voto > 10)
                {
                    await VisualizzaMessaggio("Il voto deve essere compreso tra 1 e 10");
                    TxtINF.Text = string.Empty;
                    TxtINF.Focus();
                }
            }
            else
            {
                await VisualizzaMessaggio("L'importo non è numerico");
                TxtINF.Text = string.Empty;
                TxtINF.Focus();
            }
        }
    }

    private async void TxtECO_Unfocused(object sender, FocusEventArgs e)
    {
        float voto;
        if (!string.IsNullOrEmpty(TxtECO.Text))
        {
            if (float.TryParse(TxtECO.Text, out voto))
            {
                if (voto < 1 || voto > 10)
                {
                    await VisualizzaMessaggio("Il voto deve essere compreso tra 1 e 10");
                    TxtECO.Text = string.Empty;
                    TxtECO.Focus();
                }
            }
            else
            {
                await VisualizzaMessaggio("L'importo non è numerico");
                TxtECO.Text = string.Empty;
                TxtECO.Focus();
            }
        }
    }

    private async void TxtDIR_Unfocused(object sender, FocusEventArgs e)
    {
        float voto;
        if (!string.IsNullOrEmpty(TxtDIR.Text))
        {
            if (float.TryParse(TxtDIR.Text, out voto))
            {
                if (voto < 1 || voto > 10)
                {
                    await VisualizzaMessaggio("Il voto deve essere compreso tra 1 e 10");
                    TxtDIR.Text = string.Empty;
                    TxtDIR.Focus();
                }
            }
            else
            {
                await VisualizzaMessaggio("L'importo non è numerico");
                TxtDIR.Text = string.Empty;
                TxtDIR.Focus();
            }
        }
    }

    private async void TxtECOP_Unfocused(object sender, FocusEventArgs e)
    {
        float voto;
        if (!string.IsNullOrEmpty(TxtECOP.Text))
        {
            if (float.TryParse(TxtECOP.Text, out voto))
            {
                if (voto < 1 || voto > 10)
                {
                    await VisualizzaMessaggio("Il voto deve essere compreso tra 1 e 10");
                    TxtECOP.Text = string.Empty;
                    TxtECOP.Focus();
                }
            }
            else
            {
                await VisualizzaMessaggio("L'importo non è numerico");
                TxtECOP.Text = string.Empty;
                TxtECOP.Focus();
            }
        }
    }

    private async void TxtSCI_Unfocused(object sender, FocusEventArgs e)
    {
        float voto;
        if (!string.IsNullOrEmpty(TxtSCI.Text))
        {
            if (float.TryParse(TxtSCI.Text, out voto))
            {
                if (voto < 1 || voto > 10)
                {
                    await VisualizzaMessaggio("Il voto deve essere compreso tra 1 e 10");
                    TxtSCI.Text = string.Empty;
                    TxtSCI.Focus();
                }
            }
            else
            {
                await VisualizzaMessaggio("L'importo non è numerico");
                TxtSCI.Text = string.Empty;
                TxtSCI.Focus();
            }
        }
    }

    private async void TxtIRC_Unfocused(object sender, FocusEventArgs e)
    {
        float voto;
        if (!string.IsNullOrEmpty(TxtIRC.Text))
        {
            if (float.TryParse(TxtIRC.Text, out voto))
            {
                if (voto < 1 || voto > 10)
                {
                    await VisualizzaMessaggio("Il voto deve essere compreso tra 1 e 10");
                    TxtIRC.Text = string.Empty;
                    TxtIRC.Focus();
                }
            }
            else
            {
                await VisualizzaMessaggio("L'importo non è numerico");
                TxtIRC.Text = string.Empty;
                TxtIRC.Focus();
            }
        }
    }

    private async void TxtECC_Unfocused(object sender, FocusEventArgs e)
    {
        float voto;
        if (!string.IsNullOrEmpty(TxtECC.Text))
        {
            if (float.TryParse(TxtITA.Text, out voto))
            {
                if (voto < 1 || voto > 10)
                {
                    await VisualizzaMessaggio("Il voto deve essere compreso tra 1 e 10");
                    TxtECC.Text = string.Empty;
                    TxtECC.Focus();
                }
            }
            else
            {
                await VisualizzaMessaggio("L'importo non è numerico");
                TxtECC.Text = string.Empty;
                TxtECC.Focus();
            }
        }
    }

    private async void TxtMatricola_Unfocused(object sender, FocusEventArgs e)
    {
        string matricola;
        if (!string.IsNullOrEmpty(TxtMatricola.Text))
        {
            matricola = TxtMatricola.Text;
            if (!matricola.StartsWith("MAT_"))
            {
                await VisualizzaMessaggio("La matricola non è nel formato corretto");
                TxtMatricola.Text = string.Empty;
                TxtMatricola.Focus();
            }
        }
    }

    private async void BtnAggiungi_Clicked(object sender, EventArgs e)
    {
        // -------------fase di dichiarazione -------------------
        // dati input
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
        float sci; 
        float irc; 
        float ecc;

        // -------- controllo dati obbligatori ----------------------
        if (string.IsNullOrEmpty(TxtMatricola.Text) || string.IsNullOrEmpty(TxtNome.Text) || string.IsNullOrEmpty(TxtCognome.Text) || string.IsNullOrEmpty(TxtITA.Text) || string.IsNullOrEmpty(TxtSTO.Text) || string.IsNullOrEmpty(TxtENG.Text) || string.IsNullOrEmpty(TxtTED.Text) || string.IsNullOrEmpty(TxtMAT.Text) || string.IsNullOrEmpty(TxtINF.Text) || string.IsNullOrEmpty(TxtECO.Text) || string.IsNullOrEmpty(TxtDIR.Text) || string.IsNullOrEmpty(TxtECOP.Text) || string.IsNullOrEmpty(TxtSCI.Text) || string.IsNullOrEmpty(TxtIRC.Text) || string.IsNullOrEmpty(TxtECC.Text))
        {
            await VisualizzaMessaggio("Mancano dei dati obbligatori");
        }
        else
        {
            try
            {
                // -------------fase di input -------------------
                AcquisisciDati(out matricola, out nome, out cognome, out ita, out sto, out eng, out ted, out mat, out inf, out eco, out dir, out ecop, out sci, out irc, out ecc);

                // Se la _riga è null sono in aggiungi altrimenti in modifica
                if (_studente_selezionato is not null)
                {
                    // -------------fase di calcolo -------------------
                    _studente_selezionato.Matricola = matricola;
                    _studente_selezionato.Nome = nome;
                    _studente_selezionato.Cognome = cognome;
                    _studente_selezionato.ITA = ita;
                    _studente_selezionato.STO = sto;
                    _studente_selezionato.ENG = eng;
                    _studente_selezionato.TED = ted;
                    _studente_selezionato.MAT = mat;
                    _studente_selezionato.INF = inf;
                    _studente_selezionato.ECO = eco;
                    _studente_selezionato.DIR = dir;
                    _studente_selezionato.ECOP = ecop;
                    _studente_selezionato.SCI = sci;
                    _studente_selezionato.IRC = irc;
                    _studente_selezionato.ECC = ecc;

                    // Modifico la _riga esistente
                    Global.Classe.Modifica(Global.IndiceSelezionato, _studente_selezionato);
                }
                else
                {
                    bool trovato = Global.Classe.Trova(matricola);

                    if (trovato)
                    {
                        await VisualizzaMessaggio("Elemento già in elenco");
                    }
                    else
                    {
                        // -------------fase di calcolo -------------------
                        Global.Classe.CreaEInserisci(matricola, nome, cognome, ita, sto, eng, ted, mat, inf, eco, dir, ecop, sci, irc, ecc);
                    }
                }

                PulisciForm(); // visto che torno indietro non servirebbe
                await TornaIndietro(); // scelta di design, non è che bisogna per forza
            }
            catch (Exception ex)
            {
                await VisualizzaMessaggio(ex.Message);
            }
        }
    }

    private async void BtnElimina_Clicked(object sender, EventArgs e)
    {
		if (Global.IndiceSelezionato != -1)
        {
			Global.Classe.Elimina(Global.IndiceSelezionato);
		}
        await TornaIndietro();
    }

    private async void BtnAnnulla_Clicked(object sender, EventArgs e)
    {
        await TornaIndietro();
    }
}