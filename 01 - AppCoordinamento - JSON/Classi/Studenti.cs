using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCoordinamento.Classi
{
    internal class Studenti
    {
        private List<Studente> _lista_studenti = new List<Studente>();
        
        public Studenti() { }

        public List<Studente> ListaStudenti {
            get
            {
                return _lista_studenti;
            }
            set
            {
                _lista_studenti = value;
            }
        }

        public void CreaEInserisci(string matricola, string nome, string cognome, float ita, float sto, float eng, float ted, float mat, float inf, float eco, float dir, float ecop, float sci, float irc, float ecc)
        {
            Studente nuovo_studente = new Studente(matricola, nome, cognome, ita, sto, eng, ted, mat, inf, eco, dir, ecop, sci, irc, ecc);
            ListaStudenti.Add(nuovo_studente);
        }

        public Studente Get(int indiceSelezionato)
        {
            if (indiceSelezionato >= 0 && indiceSelezionato < ListaStudenti.Count)
            {
                return ListaStudenti[indiceSelezionato];
            }

            return null;
        }

        public void Elimina(int indice_da_eliminare)
        {
            if (indice_da_eliminare >= 0 && indice_da_eliminare < ListaStudenti.Count)
            {
                ListaStudenti.RemoveAt(indice_da_eliminare);
            }
            else
            {
                throw new Exception("Nessun preventivo da eliminare");
            }
        }

        public void Modifica(int indice_da_modificare, Studente preventivo_modificato)
        {
            if (preventivo_modificato != null)
            {
                ListaStudenti[indice_da_modificare] = preventivo_modificato;
            }
            else
            {
                throw new Exception("Nessun preventivo da modificare");
            }
        }

        // Metodo che mi serve per sapere quanti preventivi ho in lista
        public int Count()
        {
            return ListaStudenti.Count;
        }

        // Invece di fare i < ListaStudenti.Count potevo usare anche il metodo Count() che mi restituisce lo stesso valore
        public bool Trova(string matricola_da_cercare)
        {
            bool trovato = false;
            for (int i = 0; i < ListaStudenti.Count; i++)
            {
                Studente studente_in_elenco = ListaStudenti[i];
                if (studente_in_elenco.Matricola == matricola_da_cercare)
                {
                    trovato = true;
                }
            }
            return trovato;
        }

        // Invece di fare i < ListaStudenti.Count potevo usare anche il metodo Count() che mi restituisce lo stesso valore
        public int N_Promossi()
        {
            int promossi = 0;
            for (int i = 0; i < ListaStudenti.Count; i++)
            {
                Studente studente_in_elenco = ListaStudenti[i];
                if (studente_in_elenco.IsPromosso()) promossi++;
            }

            return promossi;
        }

        // Invece di fare i < ListaStudenti.Count potevo usare anche il metodo Count() che mi restituisce lo stesso valore
        public int N_Bocciati()
        {
            int bocciati = 0;
            for (int i = 0; i < ListaStudenti.Count; i++)
            {
                Studente studente_in_elenco = ListaStudenti[i];
                if (!studente_in_elenco.IsPromosso()) bocciati++;
            }

            return bocciati;
        }
    }
}
