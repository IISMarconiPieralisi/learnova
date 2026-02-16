using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elearning
{
    public class ClsRispondere
    {
        //Andrea Giorgini, 4BM

        string _risposta;
        decimal _punteggioOttenuto;
        int _idDomanda;
        string _cfStudente;

        public string Risposta { get => _risposta; set => _risposta = value; }
        public decimal PunteggioOttenuto { get => _punteggioOttenuto; set => _punteggioOttenuto = value; }
        public int IdDomanda { get => _idDomanda; set => _idDomanda = value; }
        public string CfStudente { get => _cfStudente; set => _cfStudente = value; }

        public ClsRispondere()
        {

        }
    }
}
