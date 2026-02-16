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
using Newtonsoft.Json;

namespace elearning
{
    public partial class FrmDocenti : Form
    {
        //Alessandro Urbani
        ClsDocente _docente = new ClsDocente();
        List<ClsFormare> _formaresTmp = new List<ClsFormare>();
        public FrmDocenti()
        {
            InitializeComponent();
        }

        private void FrmDocenti_Load(object sender, EventArgs e)
        {
            foreach (ClsDisciplina disciplina in ClsDB.Discipline)
            {
                cbDiscipline.Items.Add(disciplina.Nome);
            }
            foreach (ClsClasse classe in ClsDB.Classi)
            {
                cbClassi.Items.Add(classe.Sigla_Classi);
            }
            foreach(ColumnHeader ch in lvDocenti.Columns)
            {
                cbRicerca.Items.Add(ch.Text);
            }
            CaricaSerializzazioneDocenti();
            CaricaSerializzazioneFormare();
            PopolaListview(ClsDB.Docenti);
        }

        private void lvDocenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            _docente = null;
            if (lvDocenti.SelectedItems.Count == 1)
            {
                _docente = (ClsDocente)lvDocenti.SelectedItems[0].Tag;
                _formaresTmp = ClsDB.Formare.FindAll(val => val.CfDocente == _docente.CF);
                PopolaDetails();
            }
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            _docente = null;
            PopolaDetails();
            pnlMaster.Enabled = false;
            pnlDetails.Enabled = true;
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (_docente == null) //Inserimento
            {
                ClsDocente docente = new ClsDocente();
                docente.Nome = tbNome.Text;
                docente.Cognome = tbCognome.Text;
                docente.CF = mtbCodiceFiscale.Text;
                docente.Username = tbUsername.Text;
                docente.Password = tbPassword.Text;
                docente.Email = tbEmail.Text;
                _docente = docente;
                ClsDB.Docenti.Add(_docente);
            }
            else    //Modifica
            {
                _docente.Nome = tbNome.Text;
                _docente.Cognome = tbCognome.Text;
                _docente.CF = mtbCodiceFiscale.Text;
                _docente.Username = tbUsername.Text;
                _docente.Password = tbPassword.Text;
                _docente.Email = tbEmail.Text;
                ClsDB.Formare.RemoveAll(val => val.CfDocente == _docente.CF);
            }

            foreach(ListViewItem lvi in lvDisciplineClassi.Items)
            {
                ClsFormare _formare = new ClsFormare();
                _formare.CfDocente = _docente.CF;
                _formare.IdDisciplina = ClsDB.Discipline.Find(val => val.Nome == lvi.SubItems[0].Text).Id;
                _formare.SiglaClasse = lvi.SubItems[1].Text;
                ClsDB.Formare.Add(_formare);
            }

            tbNome.Text = "";
            tbCognome.Text = "";
            mtbCodiceFiscale.Text = "";
            tbUsername.Text = "";
            tbEmail.Text = "";
            tbPassword.Text = "";
            lvDisciplineClassi.Items.Clear();

            PopolaListview(ClsDB.Docenti);
            pnlDetails.Enabled = false;
            pnlMaster.Enabled = true;

            SalvaSerializzazioneDocenti();
            SalvaSerializzazioneFormare();
        }


        private void PopolaListview(List<ClsDocente> docenti)
        {
            lvDocenti.Items.Clear();
            if (docenti.Count > 0)
            {
                foreach (ClsDocente _docente in docenti)
                {
                    ListViewItem lvi = new ListViewItem(_docente.Nome);
                    lvi.SubItems.Add(_docente.Cognome);
                    lvi.SubItems.Add(_docente.CF);
                    lvi.SubItems.Add(_docente.Username);
                    lvi.SubItems.Add(_docente.Email);
                    lvi.SubItems.Add(_docente.Password);
                    lvi.Tag = _docente;
                    lvDocenti.Items.Add(lvi);
                }
            }
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            pnlMaster.Enabled = true;
            pnlDetails.Enabled = false;
        }

        private void btnAggiungiDC_Click(object sender, EventArgs e)
        {
            if (cbClassi.SelectedItem != null && cbDiscipline.SelectedItem != null)
            {
                ClsFormare _formare = new ClsFormare();
                _formare.IdDisciplina = ClsDB.Discipline.Find(val => val.Nome == cbDiscipline.Text).Id;
                _formare.SiglaClasse = cbClassi.Text;
                _formaresTmp.Add(_formare);
                PopolaListViewDC();
            }
            else
            {
                MessageBox.Show("Inserisci disciplina e classe", "Parametri mancanti", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PopolaDetails()
        {
            if (_docente != null)
            {
                tbNome.Text = _docente.Nome;
                tbCognome.Text = _docente.Cognome;
                mtbCodiceFiscale.Text = _docente.CF;
                tbUsername.Text = _docente.Username;
                tbPassword.Text = _docente.Password;
                tbEmail.Text = _docente.Email;
                PopolaListViewDC();
            }
            else
            {
                tbNome.Text = "";
                tbCognome.Text = "";
                mtbCodiceFiscale.Text = "";
                tbUsername.Text = "";
                tbEmail.Text = "";
                tbPassword.Text = "";
                lvDisciplineClassi.Items.Clear();
            }
        }
        void PopolaListViewDC()
        {
            lvDisciplineClassi.Items.Clear();
            foreach (ClsFormare formare in _formaresTmp)
            {
                ListViewItem lvi = new ListViewItem(ClsDB.Discipline.Find(val => val.Id == formare.IdDisciplina).Nome);
                lvi.Tag = formare;
                lvi.SubItems.Add(formare.SiglaClasse);
                lvDisciplineClassi.Items.Add(lvi);
            }
            cbClassi.SelectedItem = null;
            cbDiscipline.SelectedItem = null;
        }


        private void btnModifica_Click(object sender, EventArgs e)
        {
            pnlMaster.Enabled = false;
            pnlDetails.Enabled = true;
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show($"Vuoi eliminare {lvDocenti.SelectedItems.Count} elemento/i?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach(ListViewItem lvi in lvDocenti.SelectedItems)
                {
                    //Rimuovo tutte le entità associative asociate all'istanza del docente eliminato
                    foreach(ClsFormare formare in ClsDB.Formare)
                    {
                        if(formare.CfDocente == ((ClsDocente)lvi.Tag).CF)
                        {
                            ClsDB.Formare.Remove(formare);
                        }
                    }
                    ClsDB.Docenti.Remove((ClsDocente)lvi.Tag);
                }
                SalvaSerializzazioneDocenti();
                SalvaSerializzazioneFormare();
                PopolaListview(ClsDB.Docenti);
                PopolaDetails();
                _docente = null;
                PopolaDetails();
            }
        }

        private void btnRicerca_Click(object sender, EventArgs e)
        {
            if (tbCerca.Text != "")
            {
                switch (cbRicerca.SelectedIndex)
                {
                    case 0:
                        PopolaListview(ClsDB.Admin.RicercaDocenti(ClsDB.Docenti, tbCerca.Text));
                        break;
                    case 1:
                        PopolaListview(ClsDB.Admin.RicercaDocenti(ClsDB.Docenti, "", tbCerca.Text));
                        break;
                    case 2:
                        PopolaListview(ClsDB.Admin.RicercaDocenti(ClsDB.Docenti, "", "", tbCerca.Text));
                        break;
                    case 3:
                        PopolaListview(ClsDB.Admin.RicercaDocenti(ClsDB.Docenti, "", "", "", tbCerca.Text));
                        break;
                    case 4:
                        PopolaListview(ClsDB.Admin.RicercaDocenti(ClsDB.Docenti, "", "", "", "", tbCerca.Text));
                        break;
                    case 5:
                        PopolaListview(ClsDB.Admin.RicercaDocenti(ClsDB.Docenti, "", "", "", "", "", tbCerca.Text));
                        break;
                }
            }
            else
            {
                PopolaListview(ClsDB.Docenti);
            }
        }

        private void btnEliminaDC_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Vuoi eliminare {lvDisciplineClassi.SelectedItems.Count} elemento/i?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (ListViewItem lvi in lvDisciplineClassi.SelectedItems)
                {
                    ClsDB.Formare.Remove((ClsFormare)lvi.Tag);
                    _formaresTmp.Remove((ClsFormare)lvi.Tag);
                }
                PopolaListview(ClsDB.Docenti);
                _docente = null;
                SalvaSerializzazioneFormare();
                PopolaListViewDC();
            }
        }

        private void btnOrdina_Click(object sender, EventArgs e)
        {
            ClsDB.Docenti.Sort((val1, val2) => val1.Cognome.CompareTo(val2.Cognome));
        }

        void SalvaSerializzazioneDocenti()
        {
            StreamWriter sw = new StreamWriter("docenti.json");
            sw.WriteLine(JsonConvert.SerializeObject(ClsDB.Docenti));
            sw.Close();
        }
        void CaricaSerializzazioneDocenti()
        {
            StreamReader sr = new StreamReader("docenti.json");
            ClsDB.Docenti = new List<ClsDocente>();
            ClsDB.Docenti = JsonConvert.DeserializeObject<List<ClsDocente>>(sr.ReadToEnd());
            sr.Close();
        }
        void SalvaSerializzazioneFormare()
        {
            StreamWriter sw = new StreamWriter("formare.json");
            sw.WriteLine(JsonConvert.SerializeObject(ClsDB.Formare));
            sw.Close();
        }
        void CaricaSerializzazioneFormare()
        {
            StreamReader sr = new StreamReader("formare.json");
            ClsDB.Formare = new List<ClsFormare>();
            ClsDB.Formare = JsonConvert.DeserializeObject<List<ClsFormare>>(sr.ReadToEnd());
            sr.Close();
        }
    }
}
