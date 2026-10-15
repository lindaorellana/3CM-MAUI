using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
        private float _ecc;
        private float _irc;

        public Studente(string matricola, string nome, string cognome, float ita, float sto, float eng, float ted, float mat, float inf, float eco, float dir, float ecop, float ecc, float irc)
        {
            Matricola = matricola;
            Nome = nome;
            Cognome = cognome;
            Ita = ita;
            Sto = sto;
            Eng = eng;
            Ted = ted;
            Mat = mat;
            Inf = inf;
            Eco = eco;
            Dir = dir;
            Ecop = ecop;
            Ecc = ecc;
            Irc = irc;
        }

        public Studente(string valMatricola, string valNome, string valCognome, float valIta, float valSto, float valEng, float valTed, float valMat, float valInf, float valEco, float valDir, float valEcop, float valSci, float valEcc, float valIrc)
        {
            Matricola = valMatricola;
        }
        public string Matricola
        {
            get
            {
                return _matricola;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("la matricola è obbligatoria");
                }
                else
                {
                    if (value.StartsWith("MAT_"))
                    {
                        _matricola = value;
                    }
                    else
                    {
                        throw new Exception("la matricola non è nel formato corretto");
                    }
                }

            }
        }
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Il nonw  è obbligatoria");
                }
                else
                {
                    if (value.StartsWith("MAT_"))
                    {
                        _nome = value;
                    }
                    else
                    {
                        throw new Exception("il nome non è nel formato corretto");
                    }
                }
            }
        }
        public string Cognome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Il nonw  è obbligatoria");
                }
                else
                {
                    if (value.StartsWith("MAT_"))
                    {
                        _nome = value;
                    }
                    else
                    {
                        throw new Exception("il nome non è nel formato corretto");
                    }
                }
            }
        }
        public float Ita
        {
            get
            {
                return _ita;
            }
            set
            {
                if (value<1|| value> 10)
                {
                    throw new Exception("Il voto Ita deve essere tra 1 e 10");
                }
                else
                {
                   _ita = value;
                }

            }
        }
        public float Sto
        {
            get
            {
                return _sto;
            }
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new Exception("Il voto Sto deve essere tra 1 e 10");
                }
                else
                {
                    _sto = value;
                }

            }
        }
        public float Eng
        {
            get
            {
                return _eng;
            }
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new Exception("Il voto Eng deve essere tra 1 e 10");
                }
                else
                {
                    _eng = value;
                }

            }
        }
        public float Ted
        {
            get
            {
                return _ted;
            }
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new Exception("Il voto Ita deve essere tra 1 e 10");
                }
                else
                {
                    _ted = value;
                }

            }
        }
        public float Mat
        {
            get
            {
                return _mat;
            }
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new Exception("Il voto Mat deve essere tra 1 e 10");
                }
                else
                {
                    _mat = value;
                }

            }
        }
        public float Inf
        {
            get
            {
                return _inf;
            }
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new Exception("Il voto Inf deve essere tra 1 e 10");
                }
                else
                {
                    _inf = value;
                }

            }
        }
        public float Eco
        {
            get
            {
                return _eco;
            }
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new Exception("Il voto Eco deve essere tra 1 e 10");
                }
                else
                {
                    _eco = value;
                }

            }
        }
        public float Dir
        {
            get
            {
                return _dir;
            }
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new Exception("Il voto Dir deve essere tra 1 e 10");
                }
                else
                {
                    _dir = value;
                }

            }
        }
        public float Ecop
        {
            get
            {
                return _ecop;
            }
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new Exception("Il voto Ecop deve essere tra 1 e 10");
                }
                else
                {
                    _ecop = value;
                }

            }
        }
        public float Sci
        {
            get
            {
                return _sci;
            }
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new Exception("Il voto Sci deve essere tra 1 e 10");
                }
                else
                {
                    _sci = value;
                }

            }
        }
        public float Ecc
        {
            get
            {
                return _ecc;
            }
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new Exception("Il voto di Ecc deve essere tra 1 e 10");
                }
                else
                {
                    _ecc = value;
                }

            }
        }
        public float Irc
        {
            get
            {
                return _irc;
            }
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new Exception("Il voto di Irc deve essere tra 1 e 10");
                }
                else
                {
                    _irc = value;
                }

            }
        }


    }  
}

