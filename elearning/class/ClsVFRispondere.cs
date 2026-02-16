using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elearning
{
    public class ClsVFRispondere
    {
        //Andrea Giorgini, 4BM

        bool _rispostaVF;
        decimal _punteggioOttenuto;
        int _idDomanda;
        string _cfStudente;
        public bool RispostaVF { get => _rispostaVF; set => _rispostaVF = value; }
        public decimal PunteggioOttenuto { get => _punteggioOttenuto; set => _punteggioOttenuto = value; }

        public int IdDomanda { get => _idDomanda; set => _idDomanda = value; }
        public string CfStudente { get => _cfStudente; set => _cfStudente = value; }
        public ClsVFRispondere()
        {

        }
    }
}
