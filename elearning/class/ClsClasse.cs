using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elearning
{
    public class ClsClasse
    {
        string Sigla_Classe;
        public string Sigla_Classi
        {
            get { return Sigla_Classe; }
            set
            {
                // Controllo duplicati nella lista statica ClsDB.Classe
                if (!string.IsNullOrEmpty(value) &&
                    ClsDB.Classi.Any(c => c != this && c.Sigla_Classi.Equals(value, StringComparison.OrdinalIgnoreCase)))
                {
                    throw new Exception($"La classe '{value}' esiste già!");
                }

                Sigla_Classe = value.ToUpper(); // converte in maiuscolo automaticamente
            }
        }
    }
}
