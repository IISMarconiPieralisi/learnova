using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elearning
{
    public class ClsScegliere
    {
        //Di Bernardo Leonardo
        #region Attributi       
        decimal _punteggioOttenuto;
        ClsRisposta _risposta;
        ClsStudente _studente;
        #endregion

        #region Proprieta
        public decimal PunteggioOttenuto { get => _punteggioOttenuto; set => _punteggioOttenuto = value; }
        public ClsRisposta Risposta { get => _risposta; set => _risposta = value; }
        public ClsStudente Studente { get => _studente; set => _studente = value; }
        #endregion

        #region Metodi
        public ClsScegliere()
        {

        }
        public ClsScegliere(decimal punteggioOttenuto, ClsRisposta risposta, ClsStudente studente)
        {
            PunteggioOttenuto = punteggioOttenuto;
            Risposta = risposta;
            Studente = studente;
        }
        #endregion

    }
}
