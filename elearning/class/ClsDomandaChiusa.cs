using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elearning
{
    public class ClsDomandaChiusa : ClsDomanda //Sushko Oleksandr 
    {
        public enum eTipologia
        {
            VF,
            S,
            M
        }

        //Attributi

        decimal _punteggioNullo;
        eTipologia _tipologia;
        bool _VFCorretta;

        //Propietà

        public decimal PUNTEGGIONULLO
        {
            get => _punteggioNullo;
            set
            {
                if (_punteggioNullo > 0)
                    throw new Exception("il punteggio non puo essere superiore a 0");
                else
                    _punteggioNullo = value;
            }
        }

        public eTipologia TIPOLOGIA
        {
            get => _tipologia;
            set => _tipologia = value;
        }

        public bool VFCORRETTA
        {
            get => _VFCorretta;
            set => _VFCorretta = value;
        }

        //Metodi

        public ClsDomandaChiusa()
        {
            AssegnaID();
        }

        public ClsDomandaChiusa(eTipologia TIPOLOGIA)
        {
            TIPOLOGIA = _tipologia;
        }

        public List<ClsRisposta> OttieniRisposte()
        {
            List<ClsRisposta> _risposte = new List<ClsRisposta>();
            foreach (ClsRisposta r in ClsDB.Risposte)
            {
                if (r.IdDomanda == this.Id)
                    _risposte.Add(r);
            }

            return _risposte;
        }

        public ClsDomanda ConverToDomanda()
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
