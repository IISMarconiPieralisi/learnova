using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace elearning
{
    public static class ClsDB
    {
        //Attributi
        static List<ClsDisciplina> _discipline = new List<ClsDisciplina>();
        static List<ClsDocente> _docente = new List<ClsDocente>();
        static List<ClsDomanda> _domande = new List<ClsDomanda>();
        static List<ClsDomandaChiusa> _domandeChiuse = new List<ClsDomandaChiusa>();
        static List<ClsFormare> _formare = new List<ClsFormare>();
        static List<ClsPersona> _persone = new List<ClsPersona>();
        static List<ClsRispondere> _rispondere = new List<ClsRispondere>();
        static List<ClsRisposta> _risposte = new List<ClsRisposta>();
        static List<ClsScegliere> _scegliere = new List<ClsScegliere>();
        static List<ClsStudente> _studenti = new List<ClsStudente>();
        static List<ClsVerifica> _verifiche = new List<ClsVerifica>();
        static List<ClsVFRispondere> _vfRispondere = new List<ClsVFRispondere>();
        static List<ClsClasse> _classi = new List<ClsClasse>();
        static ClsAdmin _admin = new ClsAdmin();

        //Proprietà
        public static List<ClsDisciplina> Discipline { get => _discipline; set => _discipline = value; }
        public static List<ClsDocente> Docenti { get => _docente; set => _docente = value; }
        public static List<ClsDomanda> Domande { get => _domande; set => _domande = value; }
        public static List<ClsDomandaChiusa> DomandeChiuse { get => _domandeChiuse; set => _domandeChiuse = value; }
        public static List<ClsFormare> Formare { get => _formare; set => _formare = value; }
        public static List<ClsPersona> Persone { get => _persone; set => _persone = value; }
        public static List<ClsRispondere> Rispondere { get => _rispondere; set => _rispondere = value; }
        public static List<ClsRisposta> Risposte { get => _risposte; set => _risposte = value; }
        public static List<ClsScegliere> Scegliere { get => _scegliere; set => _scegliere = value; }
        public static List<ClsStudente> Studenti { get => _studenti; set => _studenti = value; }
        public static List<ClsVerifica> Verifiche { get => _verifiche; set => _verifiche = value; }
        public static List<ClsVFRispondere> VfRispondere { get => _vfRispondere; set => _vfRispondere = value; }
        public static List<ClsClasse> Classi { get => _classi; set => _classi = value; }
        public static ClsAdmin Admin { get => _admin; set => _admin = value; }

        //Metodi
        static public void CaricaTuttiFile()
        {
            StreamReader sr;
            //Carica classi

            if (File.Exists("classi.json"))
            {
                sr = new StreamReader("classi.json");
                Classi = JsonConvert.DeserializeObject<List<ClsClasse>>(sr.ReadToEnd());
                sr.Close();
            }

            //Carica discipline

            if (File.Exists("Discipline.json"))
            {
                sr = new StreamReader("Discipline.json");
                Discipline = JsonConvert.DeserializeObject<List<ClsDisciplina>>(sr.ReadLine());
                sr.Close();
            }

            //Carica docenti
            if (File.Exists("docenti.json"))
            {
                sr = new StreamReader("docenti.json");
                Docenti = JsonConvert.DeserializeObject<List<ClsDocente>>(sr.ReadToEnd());
                sr.Close();
            }

            //Carica studenti
            if (File.Exists("Studenti.json"))
            {
                sr = new StreamReader("Studenti.json");
                Studenti = JsonConvert.DeserializeObject<List<ClsStudente>>(sr.ReadToEnd());
                sr.Close();
            }

            //Carica Formare
            if (File.Exists("formare.json"))
            {
                sr = new StreamReader("formare.json");
                Formare = JsonConvert.DeserializeObject<List<ClsFormare>>(sr.ReadToEnd());
                sr.Close();
            }

            //caricare Verifiche
            if (File.Exists("verifiche.json"))
            {
                sr = new StreamReader("verifiche.json");
                Verifiche = JsonConvert.DeserializeObject<List<ClsVerifica>>(sr.ReadToEnd());
                sr.Close();
            }

            //caricare Domande

            if (File.Exists("domande.json"))
            {
                sr = new StreamReader("domande.json");
                Domande = JsonConvert.DeserializeObject<List<ClsDomanda>>(sr.ReadToEnd());
                sr.Close();
            }

            //caricare Domande Chiuse

            if (File.Exists("domandeChiuse.json"))
            {
                sr = new StreamReader("domandeChiuse.json");
                DomandeChiuse = JsonConvert.DeserializeObject<List<ClsDomandaChiusa>>(sr.ReadToEnd());
                sr.Close();
            }

            //caricare Risposte

            if (File.Exists("risposte.json"))
            {
                sr = new StreamReader("risposte.json");
                Risposte = JsonConvert.DeserializeObject<List<ClsRisposta>>(sr.ReadToEnd());
                sr.Close();
            }

            //caricare VFRisposndere

            if (File.Exists("VFRispondere.json"))
            {
                sr = new StreamReader("VFRispondere.json");
                VfRispondere = JsonConvert.DeserializeObject<List<ClsVFRispondere>>(sr.ReadToEnd());
                sr.Close();
            }

            //caricare Rispondere
            
            if (File.Exists("rispondere.json"))
            {
                sr = new StreamReader("rispondere.json");
                Rispondere = JsonConvert.DeserializeObject<List<ClsRispondere>>(sr.ReadToEnd());
                sr.Close();
            }

        }
    }
}
