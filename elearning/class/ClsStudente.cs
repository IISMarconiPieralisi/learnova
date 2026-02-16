using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elearning
{
    /// <summary>
    /// Sviluppata da Diego Cappelloni
    /// </summary>
    public class ClsStudente : ClsPersona
    {
        #region Attributi
        private string _matricola;
        private string _scuola;
        private string _siglaClasse;

        #endregion

        #region Proprietà
        public string Matricola
        {
            get
            {
                return _matricola;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Matricola non inserita");
                }
                else if(ClsDB.Studenti.FirstOrDefault(app => app.Matricola == value) != null)
                {
                    throw new Exception("Matricola già esistente");
                }
                else
                {
                    _matricola = value;
                }
            }
        }
        public string Scuola
        {
            get
            {
                return _scuola;
            }
            set
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Scuola non inserita");
                }
                else
                {
                    _scuola = value;
                }
            }
        }
        public string SiglaClasse
        {
            get => _siglaClasse;
            set
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Classe non inserita");
                }
                else
                {
                    _siglaClasse = value;
                }
            }
        }

        #endregion

        #region Costruttore
        public ClsStudente()
        {

        }
        public ClsStudente(string matricola, string password)
        {
            Username = matricola;
            Matricola = matricola;
            Password = password;
        }

        #endregion

        #region Metodi
        public void Rispondere(ClsVerifica verifica, ClsDomanda domanda, ClsRisposta risposta)
        {

        }

        public void Consegnare(ClsVerifica verifica)
        {

        }

        public decimal Visionare(ClsVerifica verifica)
        {
            return 0;
        }

        #endregion
    }
}
