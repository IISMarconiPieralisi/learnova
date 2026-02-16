using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elearning
{
    public class ClsDomanda //Simoncini Riccardo
    {
        //ATTRIBUTI
        static int _prossimoId = -1;
        int _id = 0, _ordine, _idVerifica;
        string _testo;
        decimal _punteggioMax, _PunteggioMin;

        //PROPRIETà
        public int Id
        {
            get => _id;
            set
            {
                if (value >= 0)
                    _id = value;

                else
                    throw new Exception("L'ID non può essere negativo");


            }
        }
        public int Ordine
        {
            get => _ordine;
            set
            {
                if (value >= 0)
                    _ordine = value;

                else
                    throw new Exception("L'ordine della domanda non può essere negativo");
            }
        }

        public string Testo
        {
            get => _testo;
            set
            {
                _testo = value;
                //if (!string.IsNullOrWhiteSpace(value))
                //    _testo = value;
                //else
                //    throw new Exception("Il testo della domanda non può essere vuoto");
            }
        }

        public decimal PunteggioMax
        {
            get => _punteggioMax;
            set
            {
                if (value > _PunteggioMin && value > 0)
                    _punteggioMax = value;
                else
                    throw new Exception();
            }
        }
        public decimal PunteggioMin
        {
            get => _PunteggioMin;
            set
            {
                if (value < _punteggioMax)
                    _PunteggioMin = value;
                else
                    throw new Exception("Il punteggio minimo deve essere minore di quello massimo");
            }
        }

        public int IdVerifica { get => _idVerifica; set => _idVerifica = value; }

        //COSTRUTTORI
        public ClsDomanda()
        {
            AssegnaID();
        }
        public ClsDomanda(string Testo)
        {
            Testo = _testo;
        }

        //metodi
        internal void AssegnaID()
        {
            List<ClsDomanda> _domande = ClsDB.Domande;
            _domande.AddRange(ClsDB.DomandeChiuse);
            if (_prossimoId == -1 && _domande.Count>0)
            {
                _prossimoId = _domande.Max(d => d.Id);
            }
            _prossimoId += 1;
            Id = _prossimoId;
            
        }

        public ClsDomandaChiusa ConverToDomandaChiusa(int tipologia)
        {
            ClsDomandaChiusa _domandaChiusa = new ClsDomandaChiusa();
            _domandaChiusa.Id = Id;
            _domandaChiusa.Testo = Testo;
            //_domandaChiusa.PunteggioMax = PunteggioMax;
            //_domandaChiusa.PunteggioMin = PunteggioMin;
            _domandaChiusa.TIPOLOGIA = (ClsDomandaChiusa.eTipologia)tipologia;
            _domandaChiusa.IdVerifica = this.IdVerifica;
            return _domandaChiusa;
        }

        public ClsDomanda ConverToDomanda()//in caso una domanda chiusa sia salvata come ClsDomanda
        {
            ClsDomanda _domanda = new ClsDomanda();
            _domanda.Id = Id;
            _domanda.Testo = Testo;
            _domanda.IdVerifica = this.IdVerifica;
            //_domandaChiusa.PunteggioMax = PunteggioMax;
            //_domandaChiusa.PunteggioMin = PunteggioMin;

            return _domanda;
        }
    }
}
