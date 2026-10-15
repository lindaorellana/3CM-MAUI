using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCoordinamento.Classi
{
    internal class Studente
    {
        private string _matricola;
        private string _nome;
        private string _cognome;
        private float _ita;
        private float _sto;
        private float _eng;
        private float _ted;
        private float _mat;
        private float _inf;
        private float _eco;
        private float _dir;
        private float _ecop;
        private float _sci;
        private float _irc;
        private float _ecc;

        public Studente(string valMatricola, string valNome, string valCognome, float valITA, float valSTO, float valENG, float valTED, float valMAT, float valINF, float valECO, float valDIR, float valECOP, float valSCI, float valIRC, float valECC)
        {
            Matricola = valMatricola;
			Nome = valNome;
			Cognome = valCognome;
			ITA = valITA;
			STO = valSTO;
			ENG = valENG;
			TED = valTED;
			MAT = valMAT;
			INF = valINF;
			ECO = valECO;
			DIR = valDIR;
			ECOP = valECOP;
			SCI = valSCI;
			IRC = valIRC;
			ECC = valECC;
        }

        public string Matricola
        {
            get { return _matricola; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("La matricola è obbligatoria");
                }
                if (!value.StartsWith("MAT_"))
                { // Se la stringa parte con MA_, maiuscolo
                    throw new Exception("Il formato della matricola non è corretto");
                }

                _matricola = value;
            }
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Il nome è obbligatorio");
                }

                _nome = value;
            }
        }

        public string Cognome
        {
            get { return _cognome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Il cognome è obbligatorio");
                }

                _cognome = value;
            }
        }

        public float ITA
        {
            get { return _ita; }
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new Exception("Il valore della media di italiano non è nel range corretto");
                }

                _ita = value;
            }
        }

        public float STO
        {
            get { return _sto; }
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new Exception("Il valore della media di storia non è nel range corretto");
                }

                _sto = value;
            }
        }

        public float ENG
        {
            get { return _eng; }
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new Exception("Il valore della media di inglese non è nel range corretto");
                }

                _eng = value;
            }
        }

        public float TED
        {
            get { return _ted; }
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new Exception("Il valore della media di tedesco non è nel range corretto");
                }

                _ted = value;
            }
        }

        public float MAT
        {
            get { return _mat; }
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new Exception("Il valore della media di matematica non è nel range corretto");
                }

                _mat = value;
            }
        }

        public float INF
        {
            get { return _inf; }
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new Exception("Il valore della media di informatica non è nel range corretto");
                }

                _inf = value;
            }
        }

        public float ECO
        {
            get { return _eco; }
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new Exception("Il valore della media di economia aziendale non è nel range corretto");
                }

                _eco = value;
            }
        }

        public float DIR
        {
            get { return _dir; }
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new Exception("Il valore della media di diritto non è nel range corretto");
                }

                _dir = value;
            }
        }

        public float ECOP
        {
            get { return _ecop; }
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new Exception("Il valore della media di economia politica non è nel range corretto");
                }

                _ecop = value;
            }
        }

        public float SCI
        {
            get { return _sci; }
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new Exception("Il valore della media di scienze motorie non è nel range corretto");
                }

                _sci = value;
            }
        }

        public float IRC
        {
            get { return _irc; }
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new Exception("Il valore della media di religione non è nel range corretto");
                }

                _irc = value;
            }
        }

        public float ECC
        {
            get { return _ecc; }
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new Exception("Il valore della media di educazione civica non è nel range corretto");
                }

                _ecc = value;
            }
        }

        public bool IsPromosso() {
            int insuff = 0;
            if (ITA < 6) insuff++;
            if (STO < 6) insuff++;
            if (ENG < 6) insuff++;
            if (TED < 6) insuff++;
            if (MAT < 6) insuff++;
            if (INF < 6) insuff++;
            if (ECO < 6) insuff++;
            if (DIR < 6) insuff++;
            if (ECOP < 6) insuff++;
            if (SCI < 6) insuff++;
            if (IRC < 6) insuff++;
            if (ECC < 6) insuff++;

            return insuff <= 3;
        }
    }
}
