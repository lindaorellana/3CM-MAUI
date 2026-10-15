using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCoordinamento.Classi
{
    class Studenti
    {
        private List<Studente> _lista_studenti = new List<Studente>();

        public Studenti() { }

        public List<Studente> ListaStudenti
        {
            get
            {
                return _lista_studenti;
            }
            set
            {
                _lista_studenti = value;
            }
        }

        public  int Count()
        {
            return ListaStudenti.Count;
        }
         
        public Studente Get(int indiceSelezionato)
        {
            if (indiceSelezionato>=0 && indiceSelezionato  < ListaStudenti.Count) 
         return ListaStudenti[indiceSelezionato];

            else
            {
                return null;
            }
        }
        public void Ellimina(int Indice_da_ellimnare)
        {
            if(Indice_da_ellimnare >= 0 && Indice_da_ellimnare < ListaStudenti.Count)
            {
                ListaStudenti.RemoveAt(Indice_da_ellimnare);
            }
            else
            {
                throw new Exception("Nessun indice da selezionare");
            }
        }      
        public void CreaEInserisci(string matricola,string nome,string cognome,float ita,  float sto,  float eng,  float ted,  float mat,  float inf,  float eco,  float dir,  float ecop,  float ecc,  float irc)
        {
            Studente nuovo_studente =new Studente(matricola,nome,cognome,ita, sto, eng, ted, mat,inf, eco, dir, ecop, ecc, irc);
            ListaStudenti.Add(nuovo_studente);
        }
         
        public void Modifica(int indice_studente_da_modificare, Studente  studente_modificato)
        {
           
            ListaStudenti[indice_studente_da_modificare] = studente_modificato;
        }
        public bool Trova(string matricola_da_cercare)
        {
            for(int i = 0; i < ListaStudenti.Count; i++)
            {
                Studente studente_in_elenco=ListaStudenti[i];
                if (studente_in_elenco.Matricola==matricola_da_cercare) 
                {
                    return true;
                }
            }
                    return false;
        }
    }
}

