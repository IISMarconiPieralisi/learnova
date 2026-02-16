using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elearning
{
    public class ClsAdmin:ClsPersona
    {

        //Costruttori

        public ClsAdmin()
        {

        }

        public ClsAdmin(string username, string password)
        {
            Username = username;
            Password = password;
        }

        //Metodi


        /// <summary>
        /// Metodo sviluppato da Diego Cappelloni
        /// </summary>
        /// <param name="studenti"></param>
        /// <param name="nome"></param>
        /// <param name="cognome"></param>
        /// <param name="matricola"></param>
        /// <param name="scuola"></param>
        /// <param name="classe"></param>
        /// <returns></returns>
        public List<ClsStudente> Ricerca(List<ClsStudente> studenti, string nome = "", string cognome = "", string matricola = "", string scuola = "", string classe = "")
        {
            List<ClsStudente> _listaFiltrata = new List<ClsStudente>();

            //Scorro la lista con tutti gli studenti
            foreach (ClsStudente studente in studenti)
            {
                //Svolgo i controlli in base al parametro di ricerca
                bool _aggiungiStudente = false;
                if (nome != "" && studente.Nome.ToLower().Contains(nome.ToLower())) //Cerco per nome
                {
                    _aggiungiStudente = true;
                }
                else if (cognome != "" && studente.Cognome.ToLower().Contains(cognome.ToLower()))
                {
                    _aggiungiStudente = true;
                }
                else if (matricola != "" && studente.Matricola.ToLower().Contains(matricola.ToLower()))
                {
                    _aggiungiStudente = true;
                }
                else if (scuola != "" && studente.Scuola.ToLower().Contains(scuola.ToLower()))
                {
                    _aggiungiStudente = true;
                }
                else if (classe != "" && studente.SiglaClasse.ToLower().Contains(classe.ToLower()))
                {
                    _aggiungiStudente = true;
                }

                //Aggiungo lo studente alla lista filtrata se richiesto
                if (_aggiungiStudente)
                {
                    _listaFiltrata.Add(studente);
                }
            }

            //Restituisco la lista filtrata
            return _listaFiltrata;
        }



        public List<ClsDocente> RicercaDocenti(List<ClsDocente> docenti, string nome = "", string cognome = "", string cf = "", string username = "", string email = "", string password = "")
        {
            if (nome != "")
                return docenti.FindAll(val => val.Nome.Contains(nome.ToLower()));
            else if (cognome != "")
                return docenti.FindAll(val => val.Cognome.Contains(cognome.ToLower()));
            else if (cf != "")
                return docenti.FindAll(val => val.CF.Contains(cf.ToLower()));
            else if (username != "")
                return docenti.FindAll(val => val.Username.Contains(username.ToLower()));
            else if (email != "")
                return docenti.FindAll(val => val.Email.Contains(email.ToLower()));
            else if (password != "")
                return docenti.FindAll(val => val.Password.Contains(password.ToLower()));
            else
                return null;

        }
    }
}
