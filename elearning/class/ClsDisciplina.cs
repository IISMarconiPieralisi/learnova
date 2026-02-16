using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elearning
{
    public class ClsDisciplina
    {
        //Classe di Cesaretti

        int _id;
        string _nome;
        int _anno;



        public int Id
        { get => _id;
            set
            {
                if(value >= 0)
                    _id = value;
                else
                    throw new Exception("ID non valido");    //stampo l'errore
            }
        }
        public string Nome
        {
            get => _nome;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))  //controllo se il nome esiste o sono solo spazi bianchi
                    _nome = value;
                else
                    throw new Exception("Nome assente");    //stampo l'errore
            }
        }
        public int Anno
        {
            get => _anno;
            set
            {
                if (value <= DateTime.Now.Year || value > 1800)  //controllo se l'anno è troppo grande o troppo piccolo
                    _anno = value;
                else
                    throw new Exception("Anno non nvalido");     //stampo l'errore
            }
        }

        public ClsDisciplina()
        {

        }

        public ClsDisciplina(int id, string nome, int anno)
        {
            Id = id;
            Nome = nome;
            Anno = anno;
        }
    }
}
