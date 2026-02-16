using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elearning
{
    public class ClsDocente:ClsPersona
    {
        public ClsDocente()
        {

        }
        public ClsDocente(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public ClsDocente(string cf, string cognome, string nome)
        {
            CF = cf;
            Cognome = cognome;
            Nome = nome;
        }
        public void Corregere(/*ClsVerifica verifica*/)
        {

        }
        public void CercaRisposta(/*ClsRisposta risposta*/)
        {

        }
        public void Corregere(/*ClsRisposta risposta,*/decimal Punteggio)
        {

        }

        public void Formare()
        {

        }

        public void Preparare()
        {

        }
    }
}
