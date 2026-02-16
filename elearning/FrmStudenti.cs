using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elearning
{
    /// <summary>
    /// Sviluppata da Diego Cappelloni
    /// </summary>
    public partial class FrmStudenti : Form
    {
        #region Variabili globali
        bool _nuovoStudente = false;
        ClsStudente _studenteSelezionato = new ClsStudente();
        List<ClsStudente> _listaFiltrata = new List<ClsStudente>();
        ///<summary>
        ///Lista popolata da codice usata per il testing
        ///</summary>
        List<ClsStudente> _test = new List<ClsStudente>();
        const string NOME_FILE_STUDENTI = "Studenti.json";

        #endregion

        #region Enumeratori
        public enum ePARAMETRI_DI_RICERCA
        {
            Tutti,
            Nome,
            Cognome,
            Matricola,
            Scuola,
            Classe
        }

        #endregion

        #region Costruttore
        public FrmStudenti()
        {
            InitializeComponent();
            lvStudenti.MultiSelect = false;
            /*#region testing
            ClsClasse _classe1 = new ClsClasse();
            _classe1.Sigla_Classi = "4BM";
            ClsClasse _classe2 = new ClsClasse();
            _classe2.Sigla_Classi = "5AH";
            ClsClasse _classe3 = new ClsClasse();
            _classe3.Sigla_Classi = "1AP";
            ClsClasse _classe4 = new ClsClasse();
            _classe4.Sigla_Classi = "3CC";
            ClsDB.Classi.Add(_classe1);
            ClsDB.Classi.Add(_classe2);
            ClsDB.Classi.Add(_classe3);
            ClsDB.Classi.Add(_classe4);


            ClsStudente _studente1 = new ClsStudente();
            _studente1.CF = "AAAAAA00A00A000A";
            _studente1.Cognome = "Paoletti";
            _studente1.Matricola = "st12121";
            _studente1.Nome = "Paolo";
            _studente1.Password = "abcDE1";
            _studente1.Scuola = "IIS Marconi Pieralisi";
            _studente1.SiglaClasse = ClsDB.Classi[2].Sigla_Classi;
            _studente1.Username = "pp1";
            _test.Add(_studente1);

            ClsStudente _studente2 = new ClsStudente();
            _studente2.CF = "AAABAA01A00A012C";
            _studente2.Cognome = "Paolinelli";
            _studente2.Matricola = "st10000";
            _studente2.Nome = "Mario";
            _studente2.Password = "abcDweqweE1";
            _studente2.Scuola = "Liceo Leonardo da Vinci";
            _studente2.SiglaClasse = ClsDB.Classi[0].Sigla_Classi;
            _studente2.Username = "aa2321";
            _test.Add(_studente2);

            ClsStudente _studente3 = new ClsStudente();
            _studente3.CF = "EAAAAA01A00A012R";
            _studente3.Cognome = "Gianpini";
            _studente3.Matricola = "st12421";
            _studente3.Nome = "Marco";
            _studente3.Password = "abcDweqweqeqeqwweE1";
            _studente3.Scuola = "Liceo Leonardo Leonardini";
            _studente3.SiglaClasse = ClsDB.Classi[1].Sigla_Classi;
            _studente3.Username = "asdsdwqw";
            _test.Add(_studente3);

            ClsDB.Studenti = _test;
            #endregion*/
        }

        #endregion

        #region Metodi
        /// <summary>
        /// Scrittura su file json
        /// </summary>
        /// <param name="pathFile"></param>
        /// <param name="studenti"></param>
        void ScriviSuFile(string pathFile, List<ClsStudente> studenti)
        {
            if(!File.Exists(pathFile))
            {
                File.Create(pathFile).Close();
            }
            string _listaSerializzata = JsonConvert.SerializeObject(studenti);
            File.WriteAllText(pathFile, _listaSerializzata);
        }
        List<ClsStudente> CaricaFile(string pathFile)
        {
            string _fileJson = File.ReadAllText(pathFile);
            List<ClsStudente> _listaDeserializzata = new List<ClsStudente>();
            _listaDeserializzata = JsonConvert.DeserializeObject<List<ClsStudente>>(_fileJson);
            if(_listaDeserializzata == null)
            {
                _listaDeserializzata = new List<ClsStudente>();
            }
            return _listaDeserializzata;
        }
        void PopolaListView(ListView listView, List<ClsStudente> studenti, List<ClsStudente> listaFiltrata = null)
        {
            //Rimuovo tutti gli elementi dalla listview
            listView.Items.Clear();

            for(int i = 0; i < studenti.Count(); i++)
            {
                bool _aggiungiStudente = true;

                if(listaFiltrata != null && !listaFiltrata.Contains(studenti[i]))
                {
                    //Se ho passato la lista filtrata e lo studente corrente non è contenuto in essa non lo aggiungo alla listview
                    _aggiungiStudente = false;
                }

                if(_aggiungiStudente)
                {
                    //Creo il listview item
                    ListViewItem _lvi = new ListViewItem(studenti[i].Nome); //1a colonna
                    _lvi.SubItems.Add(studenti[i].Cognome); //2a colonna
                    _lvi.SubItems.Add(studenti[i].Matricola); //3a colonna
                    _lvi.SubItems.Add(studenti[i].Scuola); //4a colonna
                    _lvi.SubItems.Add(studenti[i].SiglaClasse); //5a colonna
                    _lvi.Tag = studenti[i]; //Tag

                    //Aggiungo l'item alla listview
                    listView.Items.Add(_lvi);
                }
            }
        }
        /// <summary>
        /// Svuota tutti i controlli grafici di input del lato detail
        /// </summary>
        void CancellaDatiDetail()
        {
            tbCognome.Clear();
            tbNome.Clear();
            tbPassword.Clear();
            tbScuola.Clear();
            mtbCodiceFiscale.Clear();
            mtbMatricola.Clear();
            cbClassi.SelectedItem = null;
        }

        #endregion

        #region Eventi
        private void FrmStudenti_Load(object sender, EventArgs e)
        {
            //Carico il file
            if(!File.Exists(NOME_FILE_STUDENTI))
            {
                File.Create(NOME_FILE_STUDENTI).Close();
            }
            try
            {
                ClsDB.Studenti = new List<ClsStudente>();
                ClsDB.Studenti = CaricaFile(NOME_FILE_STUDENTI);
                MessageBox.Show($"Il file {NOME_FILE_STUDENTI} è stato caricato con successo", "CARICAMENTO FILE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Errore nel caricamento del file {NOME_FILE_STUDENTI}: {ex}", "CARICAMENTO FILE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            pnlDetail.Enabled = false; //Disattivo la parte detail
            PopolaListView(lvStudenti, ClsDB.Studenti); //Popolo la listview 
            //Popolo combobox classi
            foreach (ClsClasse classe in ClsDB.Classi) 
            {
                cbClassi.Items.Add(classe.Sigla_Classi);
            }
            cbClassi.SelectedIndex = 0;
            //Popolo combobx parametri di ricerca
            cbParametriRicerca.DataSource = Enum.GetNames(typeof(ePARAMETRI_DI_RICERCA));
        }

        private void btnNuovo_Click(object sender, EventArgs e)
        {
            _nuovoStudente = true;
            pnlDetail.Enabled = true; //Attivo la parte detail
            CancellaDatiDetail();
            mtbMatricola.Enabled = true;
        }

        private void lvStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Quando seleziono un elemento carico i dati sul pannello detail
            if(lvStudenti.SelectedIndices.Count == 1 && pnlDetail.Enabled == false)
            {
                _studenteSelezionato = (ClsStudente)lvStudenti.SelectedItems[0].Tag;
                tbNome.Text = _studenteSelezionato.Nome;
                tbCognome.Text = _studenteSelezionato.Cognome;
                mtbMatricola.Text = _studenteSelezionato.Matricola;
                tbPassword.Text = _studenteSelezionato.Password;
                tbScuola.Text = _studenteSelezionato.Scuola;
                mtbCodiceFiscale.Text = _studenteSelezionato.CF;
                cbClassi.SelectedItem = _studenteSelezionato.SiglaClasse;
            }
            else if(pnlDetail.Enabled == false)
            {
                CancellaDatiDetail();
                _studenteSelezionato = new ClsStudente();
            }
            
        }

        private void cbVediPassword_CheckedChanged(object sender, EventArgs e)
        {
            //Cambio la visibilità della password in base alla checkbox
            tbPassword.UseSystemPasswordChar = !cbVediPassword.Checked;
        }

        private void pnlDetail_EnabledChanged(object sender, EventArgs e)
        {
            //Quando cambio la visibilità del pannello rendo invisibile la password
            tbPassword.UseSystemPasswordChar = true;
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if(_studenteSelezionato != null)
            {
                _nuovoStudente = false;
                pnlDetail.Enabled = true; //Attivo la parte detail
                mtbMatricola.Enabled = false; //Essendo la matricola la chiave dell'oggetto, non è modificabile
            }
            else
            {
                MessageBox.Show("Nessun elemento selezionato", "MODIFICA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            try
            {

                //Controllo se il formato del CF inserito è giusto
                if (!mtbCodiceFiscale.MaskCompleted)
                {
                    throw new Exception("Codice fiscale non inserito o non completo");
                }

                //Controllo se il formato della matricola inserita è giusta
                if (!mtbMatricola.MaskCompleted)
                {
                    throw new Exception("Matricola non inserita o non completa");
                }

                //Salvo i dati sulla lista
                if (_nuovoStudente)
                {
                    //Creo una nuova istanza di ClsStudente se sono in modalità inserimento
                    _studenteSelezionato = new ClsStudente();
                }

                //Inserisco o modifico i valori
                _studenteSelezionato.Nome = tbNome.Text;
                _studenteSelezionato.Cognome = tbCognome.Text;
                _studenteSelezionato.Username = mtbMatricola.Text;
                _studenteSelezionato.Password = tbPassword.Text;
                _studenteSelezionato.CF = mtbCodiceFiscale.Text;
                _studenteSelezionato.Scuola = tbScuola.Text;
                _studenteSelezionato.SiglaClasse = cbClassi.SelectedItem.ToString();

                if (_nuovoStudente)
                {
                    _studenteSelezionato.Matricola = mtbMatricola.Text;
                    //Aggiungo il nuovo studente nella lista
                    ClsDB.Studenti.Add(_studenteSelezionato);
                    cbParametriRicerca.SelectedIndex = 0; //Seleziono 'tutti'
                    tbRicerca.Clear();
                    btnCerca.PerformClick(); //Eseguo il codice dell'evento click di btnCerca
                }

                //Disattivo parte detail
                pnlDetail.Enabled = false;
                CancellaDatiDetail();

                //Ripopolo la listview
                if(_listaFiltrata.Count <= 0)
                {
                    PopolaListView(lvStudenti, ClsDB.Studenti);
                }
                else
                {
                    //Popolo la listview attenendomi ai parametri di ricerca
                    PopolaListView(lvStudenti, ClsDB.Studenti, _listaFiltrata);
                }

                try
                {
                    ScriviSuFile(NOME_FILE_STUDENTI, ClsDB.Studenti);
                    MessageBox.Show("File aggiornato con successo", "SALVATAGGIO SU FILE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Errore nella scrittura su file:\n" + ex, "SALVATAGGIO SU FILE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel salvataggio modifiche:\n" + ex, "SALVATAGGIO MODIFICHE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCestino_Click(object sender, EventArgs e)
        {
            if (lvStudenti.SelectedIndices.Count == 1)
            {
                //Chiedo all'utente se è sicuro di voler eliminare l'elemento selezionato
                DialogResult _dr = MessageBox.Show("Sei sicur* di voler eliminare l'elemento selezionato?", "ELIMINAZIONE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (_dr == DialogResult.Yes)
                {
                    //Elimino l'elemento selezionato
                    ClsDB.Studenti.Remove(_studenteSelezionato);
                    //Ripopolo la listview
                    if (_listaFiltrata.Count <= 0)
                    {
                        PopolaListView(lvStudenti, ClsDB.Studenti);
                    }
                    else
                    {
                        //Popolo la listview attenendomi ai parametri di ricerca
                        PopolaListView(lvStudenti, ClsDB.Studenti, _listaFiltrata);
                    }
                    CancellaDatiDetail();
                }
            }
            else
            {
                MessageBox.Show("Nessun elemento selezionato", "ELIMINAZIONE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            //Determino il parametro di ricerca
            ePARAMETRI_DI_RICERCA _parametroRicerca = (ePARAMETRI_DI_RICERCA)cbParametriRicerca.SelectedIndex;

            //Determino se l'utente si è autenticato come admin o come docente
            //if (ClsDB.Admin != null) //L'utente è admin
            {              
                switch(_parametroRicerca)
                {
                    case ePARAMETRI_DI_RICERCA.Nome:
                        _listaFiltrata = ClsDB.Admin.Ricerca(ClsDB.Studenti, tbRicerca.Text);
                        break;

                    case ePARAMETRI_DI_RICERCA.Cognome:
                        _listaFiltrata = ClsDB.Admin.Ricerca(ClsDB.Studenti, "", tbRicerca.Text);
                        break;

                    case ePARAMETRI_DI_RICERCA.Matricola:
                        _listaFiltrata = ClsDB.Admin.Ricerca(ClsDB.Studenti, "", "", tbRicerca.Text);
                        break;

                    case ePARAMETRI_DI_RICERCA.Scuola:
                        _listaFiltrata = ClsDB.Admin.Ricerca(ClsDB.Studenti, "", "","", tbRicerca.Text);
                        break;

                    case ePARAMETRI_DI_RICERCA.Classe:
                        _listaFiltrata = ClsDB.Admin.Ricerca(ClsDB.Studenti, "", "", "", "", tbRicerca.Text);
                        break;

                    default:
                        _listaFiltrata = new List<ClsStudente>();
                        break;
                }   
            }
            //else if(ClsDB.Docenti != null) //L'utente è docente
            {
                /*switch (_parametroRicerca)
                {
                    case ePARAMETRI_DI_RICERCA.Nome:
                        _listaFiltrata = ClsDocente.Ricerca(ClsDB.Studenti, tbRicerca.Text);
                        break;

                    case ePARAMETRI_DI_RICERCA.Cognome:
                        _listaFiltrata = ClsDB.Docente.Ricerca(ClsDB.Studenti, "", tbRicerca.Text);
                        break;

                    case ePARAMETRI_DI_RICERCA.Matricola:
                        _listaFiltrata = ClsDB.Docente.Ricerca(ClsDB.Studenti, "", "", tbRicerca.Text);
                        break;

                    case ePARAMETRI_DI_RICERCA.Scuola:
                        _listaFiltrata = ClsDB.Admin.Ricerca(ClsDB.Studenti, "", "", "", tbRicerca.Text);
                        break;

                    case ePARAMETRI_DI_RICERCA.Classe:
                        _listaFiltrata = ClsDB.Docente.Ricerca(ClsDB.Studenti, "", "", "", "", tbRicerca.Text);
                        break;

                    default:
                        _listaFiltrata = new List<ClsStudente>();
                        break;
                }*/
            }

            //Popolo la listview
            if (_parametroRicerca != ePARAMETRI_DI_RICERCA.Tutti)
                PopolaListView(lvStudenti, ClsDB.Studenti, _listaFiltrata);
            else //Parametro 'tutti'
            {
                PopolaListView(lvStudenti, ClsDB.Studenti);
                _listaFiltrata = new List<ClsStudente>();
            }
            CancellaDatiDetail();
        }

        #endregion
    }
}
