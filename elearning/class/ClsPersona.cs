using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elearning
{
    public abstract class ClsPersona
    {
        public enum eTipologia
        {
            Docente,
            Studente,
            Admin
        }

        eTipologia _tipologia;
        string _cf;
        string _cognome;
        string _nome;
        string _email;
        string _username;
        string _password;


        public string CF
        {
            get => _cf;
            set
            {
                if(ClsDB.Persone.Any(val => val.CF == value))
                    throw new Exception("Codice Fiscale già esistsente");
                else
                _cf = value;
            }
        }
        public string Cognome { get => _cognome; set => _cognome = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Username
        {
            get => _username;
            set
            {
                if (ClsDB.Persone.Any(val => val.Username == value))
                    throw new Exception("Username già esistsente");
                else
                    _username = value;
            }
        }
        public string Password { get => _password; set => _password = value; }
        public string Email
        {
            get => _email;
            set
            {
                if (ClsDB.Persone.Any(val => val.Email == value))
                    throw new Exception("Email già esistsente");
                else
                    _email = value;
            }
        }

        public eTipologia Tipologia { get => _tipologia; set => _tipologia = value; }
    }

}
