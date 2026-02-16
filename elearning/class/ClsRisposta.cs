using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elearning
{
    public class ClsRisposta
    {
        //Mattia Maggiori 4BM
        //attributi
        static int _prossimoId = 0;
        int _id = 0;
        string _testo;
        bool _corretta;
        int _idDomanda;

        //proprieta
        public int Id { get => _id; set => _id = value; }
        public string Testo { get => _testo; set => _testo = value; }
        public bool Corretta
        {
            get => _corretta;
            set => _corretta = value;
        }

        public int IdDomanda { get => _idDomanda; set => _idDomanda = value; }

        //costruttore
        public ClsRisposta()
        {
            AssegnaID();
        }

        //metodi 


        void AssegnaID()
        {
            List<ClsRisposta> _risposte = ClsDB.Risposte;
            if (_prossimoId == -1 && _risposte.Count > 0)
            {
                _prossimoId = _risposte.Max(d => d.Id);
            }
            _prossimoId += 1;
            Id = _prossimoId;

        }

        public void DomandaCorretta(ClsDomandaChiusa domanda, bool corretta)//se la tipologia è singola, una volta messa corretta una risposta, rende false tutte le altre
        {
            List<ClsRisposta> _risposte = domanda.OttieniRisposte();

            if (corretta)
            {
                if (domanda.TIPOLOGIA == ClsDomandaChiusa.eTipologia.S)
                {
                    foreach (ClsRisposta risposta in _risposte)
                    {
                        ClsRisposta _risposta = ClsDB.Risposte.Find(d => d.Id == risposta.Id);
                        _risposta.Corretta = false;
                    }
                }
                _corretta = true;
            }
            else
                _corretta = false;
            
        }

    }


}
