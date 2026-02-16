using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace elearning
{
    public class ClsVerifica
    {
        #region attributi
        static int _prossimoId;
        public int _id;
        public string _nome;
        public DateTime _data;
        public int _durata;
        public string _cfDocente;
        public int _idDisciplina;
        public bool aperta;
        #endregion

        #region proprietà
        public int Id
        {
            get => _id;
            set
            {
                if (value <= -1)
                    throw new Exception();
                else
                    _id = value;
            }
        }
        public string Nome
        {
            get => _nome;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Nome della verifica non inserito");
                else
                    _nome = value.Trim();
            }
        }
        public DateTime Data
        {
            get => _data;
            set
            {
                if (value < DateTime.Today)
                    throw new Exception();
                else
                    _data = value;
            }
        }
        public int Durata
        {
            get => _durata;
            set
            {
                if (value <= -1)
                    throw new Exception();
                else
                    _durata = value;
            }
        }

        public string CfDocente
        {
            get => _cfDocente;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception();
                else
                    _cfDocente = value.Trim();
            }
        }
        public int IdDisciplina
        {
            get => _idDisciplina;
            set
            {
                if (value <= -1)
                    throw new Exception();
                else
                    _idDisciplina = value;
            }
        }

        public bool Aperta
        {
            get => aperta;
            set => aperta = value;
        }
        #endregion

        #region metodi
        public ClsVerifica()
        {
        }
        public ClsVerifica(int id, string nome, DateTime data)
        {
            this.Id = id;
            this.Nome = nome;
            this.Data = data;
        }

        public List<ClsDomanda> OttieniListaDomande()
        {
            List<ClsDomanda> _domande = new List<ClsDomanda>();

            foreach (ClsDomanda d in ClsDB.Domande)
            {
                if (d.IdVerifica == this.Id)
                {
                    _domande.Add(d);


                }


            }

            foreach (ClsDomandaChiusa d in ClsDB.DomandeChiuse)
            {
                if (d.IdVerifica == this.Id)
                {
                    _domande.Add(d);

                }
            }

            _domande = _domande.OrderBy(d => d.Ordine).ToList();
            return _domande;
        }

        private void AssegnaId()
        {
            List<ClsVerifica> _verifiche = ClsDB.Verifiche;
            if (_prossimoId == -1 && _verifiche.Count > 0)
            {
                _prossimoId = _verifiche.Max(d => d.Id);
            }
            _prossimoId += 1;
            Id = _prossimoId;
        }

        /// <summary>
        /// carica tutte le verifiche dalla lista clsdb.verifiche nella listview
        /// </summary>
        /// <param name="listView">listview da popolare</param>
        public static void CaricaListView(ListView listView)
        {
            //pulisce tutti gli elementi esistenti nella listview
            listView.Items.Clear();

            //verifica che la lista delle verifiche non sia vuota
            if (ClsDB.Verifiche != null && ClsDB.Verifiche.Count > 0)
            {
                //itera attraverso tutte le verifiche
                for (int i = 0; i < ClsDB.Verifiche.Count; i++)
                {
                    ClsVerifica verifica = ClsDB.Verifiche[i];
                    //crea un nuovo listviewitem con l'id
                    ListViewItem item = new ListViewItem(verifica.Id.ToString());
                    //aggiunge le sub-items per le altre colonne
                    item.SubItems.Add(verifica.Nome);
                    item.SubItems.Add(verifica.Data.ToShortDateString());
                    item.SubItems.Add(verifica.Durata.ToString() + " min");

                    //cerca il nome della disciplina usando l'iddisciplina
                    string nomeDisciplina = "";
                    for (int j = 0; j < ClsDB.Discipline.Count; j++)
                    {
                        if (ClsDB.Discipline[j].Id == verifica.IdDisciplina)
                        {
                            nomeDisciplina = ClsDB.Discipline[j].Nome;
                            break;
                        }
                    }
                    item.SubItems.Add(nomeDisciplina);

                    //cerca il nome del docente usando il cfdocente
                    string nomeDocente = "";
                    for (int j = 0; j < ClsDB.Docenti.Count; j++)
                    {
                        if (ClsDB.Docenti[j].CF == verifica.CfDocente)
                        {
                            nomeDocente = ClsDB.Docenti[j].Nome + " " + ClsDB.Docenti[j].Cognome;
                            break;
                        }
                    }
                    item.SubItems.Add(nomeDocente);
                    //memorizza l'oggetto verifica nel tag per recuperarlo facilmente
                    item.Tag = verifica;
                    //aggiunge l'item alla listview
                    listView.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// funzione che verifica che almeno un parametro della verifica contenga il testo
        /// </summary>
        /// <param name="testo">testo inserito dall'utente nella tb</param>
        /// <returns>true se il testo è contenuto in almeno un campo della verifica</returns>
        public bool ContieneTesto(string testo)
        {
            testo = testo.ToLower();

            //verifica nei campi diretti
            if (Id.ToString().Contains(testo))
                return true;

            if (Nome.ToLower().Contains(testo))
                return true;

            if (Data.ToShortDateString().Contains(testo))
                return true;

            if (Durata.ToString().Contains(testo))
                return true;

            //cerca il nome della disciplina
            for (int i = 0; i < ClsDB.Discipline.Count; i++)
            {
                if (ClsDB.Discipline[i].Id == IdDisciplina)
                {
                    if (ClsDB.Discipline[i].Nome.ToLower().Contains(testo))
                        return true;
                }
            }

            //cerca il nome completo del docente
            for (int i = 0; i < ClsDB.Docenti.Count; i++)
            {
                if (ClsDB.Docenti[i].CF == CfDocente)
                {
                    string nomeCompleto = (ClsDB.Docenti[i].Nome + " " + ClsDB.Docenti[i].Cognome).ToLower();
                    if (nomeCompleto.Contains(testo))
                        return true;
                }
            }

            //se nessun campo contiene il testo
            return false;
        }

        /// <summary>
        /// Serializza la lista delle verifiche in formato JSON e la salva su file
        /// </summary>
        /// <param name="percorsoFile">percorso del file dove salvare i dati</param>
        public static void SalvaVerifiche(string percorsoFile)
        {
            try
            {
                //serializza la lista in formato JSON con formattazione indentata
                string json = JsonConvert.SerializeObject(ClsDB.Verifiche, Formatting.Indented);

                //scrive il JSON nel file
                File.WriteAllText(percorsoFile, json);

                MessageBox.Show("Verifiche salvate con successo!",
                               "Salvataggio",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante il salvataggio: {ex.Message}",
                               "Errore",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Deserializza la lista delle verifiche da un file JSON
        /// </summary>
        /// <param name="percorsoFile">percorso del file da cui caricare i dati</param>
        public static void CaricaVerifiche(string percorsoFile)
        {
            try
            {
                //verifica che il file esista
                if (File.Exists(percorsoFile))
                {
                    //legge il contenuto del file
                    string json = File.ReadAllText(percorsoFile);

                    //deserializza il JSON nella lista
                    ClsDB.Verifiche = JsonConvert.DeserializeObject<List<ClsVerifica>>(json);

                    //se la deserializzazione ha restituito null, inizializza una nuova lista
                    if (ClsDB.Verifiche == null)
                    {
                        ClsDB.Verifiche = new List<ClsVerifica>();
                    }

                    MessageBox.Show($"Caricate {ClsDB.Verifiche.Count} verifiche!",
                                   "Caricamento",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("File non trovato. Verrà creata una nuova lista di verifiche.",
                                   "Attenzione",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning);
                    ClsDB.Verifiche = new List<ClsVerifica>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante il caricamento: {ex.Message}",
                               "Errore",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                ClsDB.Verifiche = new List<ClsVerifica>();
            }
        }

        

        public void EliminaTutteDomande()
        {
            for (int i = ClsDB.Domande.Count - 1; i >= 0; i--)
            {
                if (ClsDB.Domande[i].IdVerifica == _id)
                {
                    ClsDB.Domande.RemoveAt(i);
                }
            }

            // Ciclo per ClsDB.DomandeChiuse
            for (int i = ClsDB.DomandeChiuse.Count - 1; i >= 0; i--)
            {
                if (ClsDB.DomandeChiuse[i].IdVerifica == _id)
                {
                    ClsDB.DomandeChiuse.RemoveAt(i);
                }
            }

        }
        #endregion
    }
}