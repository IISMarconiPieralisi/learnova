using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace elearning
{
    public partial class FrmVerifiche : Form//D'Amico
    {
        //Persona loggata
        private ClsPersona _persona;
        //Docente loggato
        private ClsDocente _docente;
        //Studente loggato
        private ClsStudente _studente;
        //True se docente, false se studente
        private bool _isDocente;

        public FrmVerifiche(ClsPersona persona)
        {
            InitializeComponent();
            _persona = persona;

            //Controlla se l'utente è un docente
            _isDocente = _persona is ClsDocente;

            if (_isDocente)
                _docente = (ClsDocente)_persona;
            else
                _studente = (ClsStudente)_persona;
        }

        #region Eventi

        public void CaricaListView(ListView lv)
        {
            //Pulisce la ListView
            lv.Items.Clear();

            //Lista delle verifiche filtrate
            List<ClsVerifica> verificheFiltrate = new List<ClsVerifica>();

            if (_isDocente)
            {
                //Carica solo le verifiche del docente
                verificheFiltrate = ClsDB.Verifiche.FindAll(v => v.CfDocente == _docente.CF);
            }
            else
            {
                //Recupera le materie della classe dello studente
                List<ClsFormare> formazioniStudente =
                    ClsDB.Formare.FindAll(f => f.SiglaClasse == _studente.SiglaClasse);

                //Recupera le verifiche per ogni materia
                foreach (ClsFormare formazione in formazioniStudente)
                {
                    List<ClsVerifica> verificheMateria = ClsDB.Verifiche.FindAll(v =>
                        v.IdDisciplina == formazione.IdDisciplina &&
                        v.CfDocente == formazione.CfDocente);

                    verificheFiltrate.AddRange(verificheMateria);
                }
            }

            //Popola la ListView
            foreach (ClsVerifica verifica in verificheFiltrate)
            {
                //Recupera la disciplina
                ClsDisciplina disciplina =
                    ClsDB.Discipline.Find(d => d.Id == verifica.IdDisciplina);

                string nomeDisciplina = disciplina != null ? disciplina.Nome : "N/D";

                ListViewItem item = new ListViewItem(verifica.Id.ToString());
                item.SubItems.Add(verifica.Nome);
                item.SubItems.Add(verifica.Data.ToShortDateString());
                item.SubItems.Add(verifica.Durata.ToString());
                item.SubItems.Add(nomeDisciplina);

                //Salva l'oggetto verifica
                item.Tag = verifica;

                lv.Items.Add(item);
            }
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            //Blocca l'accesso agli studenti
            if (!_isDocente)
            {
                MessageBox.Show("Solo i docenti possono creare verifiche.",
                               "Accesso negato",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return;
            }

            //Crea una nuova verifica
            ClsVerifica verifica = new ClsVerifica();
            verifica.CfDocente = _docente.CF;

            //Apre la form di inserimento
            FrmVerifica frmVerifica = new FrmVerifica(_docente, verifica);
            frmVerifica.ShowDialog();
            ClsDB.Verifiche.Add(verifica);
            //Aggiorna la ListView
            CaricaListView(lvVerifiche);
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            //Solo i docenti possono modificare
            if (!_isDocente)
            {
                MessageBox.Show("Solo i docenti possono modificare verifiche.",
                               "Accesso negato",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return;
            }

            //Controlla se c'è una selezione
            if (lvVerifiche.SelectedIndices.Count > 0)
            {
                //Recupera la verifica selezionata
                ClsVerifica verificaSelezionata =
                    (ClsVerifica)lvVerifiche.SelectedItems[0].Tag;

                //Apre la form di modifica
                FrmVerifica frmVerifica = new FrmVerifica(_docente, verificaSelezionata);
                frmVerifica.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleziona una verifica da modificare.",
                               "Attenzione",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
            }

            //Aggiorna la ListView
            CaricaListView(lvVerifiche);
        }

        private void btnElimina_Click_1(object sender, EventArgs e)
        {
            //Solo i docenti possono eliminare
            if (!_isDocente)
            {
                MessageBox.Show("Solo i docenti possono eliminare verifiche.",
                               "Accesso negato",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return;
            }

            //Controlla se è selezionata una verifica
            if (lvVerifiche.SelectedIndices.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Sei sicuro di voler eliminare la verifica selezionata?",
                    "Conferma eliminazione",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    //Rimuove la verifica dal database
                    ClsVerifica verificaSelezionata =
                        (ClsVerifica)lvVerifiche.SelectedItems[0].Tag;

                    ClsDB.Verifiche.Remove(verificaSelezionata);

                    MessageBox.Show("Verifica eliminata con successo.",
                                   "Eliminazione completata",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Seleziona una verifica da eliminare.",
                               "Attenzione",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
            }

            //Aggiorna la ListView
            CaricaListView(lvVerifiche);
        }

        private void FrmVerifiche_Load(object sender, EventArgs e)
        {
            //Carica le verifiche all'avvio
            CaricaListView(lvVerifiche);

            //Disabilita pannello per studenti

            if (!_isDocente)
            {
                pnlstudente.Visible = false;
                btnIniziaCompito.Visible = true;
            }
                
           
    

            //Imposta il testo del bottone statistiche
            btnStatistiche.Text = _isDocente ? "Statistiche Classe" : "I Miei Voti";
        }

        #endregion

        private void cbCerca_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Evento non utilizzato
        }

        private void btnStatistiche_Click(object sender, EventArgs e)
        {
            FrmStatistiche frmStatistiche = new FrmStatistiche(_docente);
            frmStatistiche.ShowDialog();
        }

        private void btnIniziaCompito_Click(object sender, EventArgs e)
        {
            if (lvVerifiche.SelectedIndices.Count == 0)
            {
                ClsVerifica _verifica = (ClsVerifica)lvVerifiche.SelectedItems[0].Tag;
                FrmVerifica _frmVerifica = new FrmVerifica(_studente,_verifica);
                _frmVerifica.ShowDialog(this);
            }
            
        }
    }
}