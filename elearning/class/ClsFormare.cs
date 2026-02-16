using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elearning
{
    public class ClsFormare
    {
        string _cfDocente;
        int _idDisciplina;
        string _siglaClasse;

        public string CfDocente { get => _cfDocente; set => _cfDocente = value; }
        public int IdDisciplina { get => _idDisciplina; set => _idDisciplina = value; }
        public string SiglaClasse { get => _siglaClasse; set => _siglaClasse = value; }

        public ClsFormare()
        {

        }

        
    }
}
