using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace elearning
{
    public partial class FrmDiscipline : Form
    {
        int _indice = -1; //variabile per capire se sono in modifica o no
        ClsDisciplina clsDisciplina;


        public FrmDiscipline()
        {
            InitializeComponent();

            //discipline di prova
            /*ClsDisciplina disciplinaTest1 = new ClsDisciplina(0, "Italiano", 1901);
            ClsDisciplina disciplinaTest2 = new ClsDisciplina(1, "Matematica", 1980);
            ClsDB.Discipline.Add(disciplinaTest1);
            ClsDB.Discipline.Add(disciplinaTest2);*/
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            pnlDetails.Enabled = true;  //attivo il pannello
            _indice = -1;   //resetto l'indice
        }

        private void FrmDiscipline_Load(object sender, EventArgs e)
        {
            //disattivo il pannello e setto il massimo e minimo della nud
            pnlDetails.Enabled = false; 
            nudAnno.Maximum = DateTime.Now.Year;
            nudAnno.Value = DateTime.Now.Year;

            //carico il file
            CaricaDaFile();

            //carico la listView
            PopolaListView(ClsDB.Discipline);
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbNome.Text) && controlloSoloLettere(tbNome.Text))   //controllo se la parola esiste e sono solo lettere
            {
                if (!((int)nudAnno.Value <= 1800 || (int)nudAnno.Value > DateTime.Now.Year))    //controllo se l'anno è nel range giusto
                {
                    if (_indice == -1)  //se sono in aggiunta
                    {
                        clsDisciplina = new ClsDisciplina();
                        clsDisciplina.Id = ClsDB.Discipline.Count;

                        ClsDB.Discipline.Add(clsDisciplina);   //salvo sulla lista
                    }
                    clsDisciplina.Nome = tbNome.Text;
                    clsDisciplina.Anno = (int)nudAnno.Value;

                    ClsDB.Discipline = ClsDB.Discipline.OrderBy(app => app.Nome).ToList();  //ordino la lista per Nome
                    SalvaSuFile();
                    PopolaListView(ClsDB.Discipline);
                    _indice = -1;   //ritorno in modalità inserisci
                }
            }
            else
                MessageBox.Show("Il nome non è valido", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);  //stampo l'errore

            //resetto i componenti grafici e disattivo il pannello
            tbNome.Text = "";
            nudAnno.Value = DateTime.Now.Year;
            pnlDetails.Enabled = false;
        }

        private void PopolaListView(List<ClsDisciplina> discipline)
        {
            lvDiscipline.Items.Clear(); //ripulisco la listView

            foreach(ClsDisciplina disciplina in discipline)   //ripopolo la listView con tutti gli elementi della lista
            {
                ListViewItem lvi = new ListViewItem(disciplina.Nome);   //aggiungo il nome
                lvi.SubItems.Add(disciplina.Anno.ToString());   //aggiungo l'anno
                lvi.Tag = disciplina.Id;    //l'id è il tag
                lvDiscipline.Items.Add(lvi);    //aggiungo l'elemento alla listView
            }
        }

        private bool controlloSoloLettere(string parola)
        {
            bool _parolaValida = true;

            foreach (char _carattere in parola) //controllo tutti i caratteri della parola
            {
                if (!((_carattere >= 65 && _carattere <= 90) || (_carattere >= 97 && _carattere <= 122)))   //se non sono lettere
                {
                    _parolaValida = false;  //restituisco false
                }
            }
            return _parolaValida;   //restituisco se la parola è coretta o no
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sicuro di voler cancellare?", "Attenzione", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (lvDiscipline.SelectedIndices.Count == 1)    //controllo se è stto selezionato un elemetno
                {
                    _indice = (int)lvDiscipline.SelectedItems[0].Tag;   //prendo il tag dell'elemento selezionato
                    clsDisciplina = ClsDB.Discipline.FirstOrDefault(app => app.Id == _indice);      //trovo l'elemento con quel tag
                    ClsDB.Discipline.Remove(clsDisciplina); //elimino l'elemento
                    PopolaListView(ClsDB.Discipline);
                }
            }
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            string _nomeDaCercare = tbCerca.Text;   //metto il valore da cercare in una variabile

            List<ClsDisciplina> discipline = ClsDB.Discipline.FindAll(app => app.Nome.Contains(_nomeDaCercare)).ToList();   //creo una lista parallela filtrata
            PopolaListView(discipline);

        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (lvDiscipline.SelectedIndices.Count == 1)    //controllo se è stto selezionato un elemetno
            {
                _indice = (int)lvDiscipline.SelectedItems[0].Tag;   //prendo il tag dell'elemento selezionato
                clsDisciplina = ClsDB.Discipline.FirstOrDefault(app => app.Id == _indice);      //trovo l'elemento con quel tag
                tbNome.Text = clsDisciplina.Nome;
                nudAnno.Value = clsDisciplina.Anno;
                pnlDetails.Enabled = true;  //attivo il pannello
            }
        }





        void SalvaSuFile()
        {
            string output = JsonConvert.SerializeObject(ClsDB.Discipline);

            StreamWriter sw = new StreamWriter("Discipline.json");
            sw.WriteLine(output);
            sw.Close();
        }

        void CaricaDaFile()
        {
            if (File.Exists("Discipline.json"))
            {
                StreamReader sr = new StreamReader("Discipline.json");
                string output = sr.ReadLine();
                ClsDB.Discipline = new List<ClsDisciplina>();
                ClsDB.Discipline = JsonConvert.DeserializeObject<List<ClsDisciplina>>(output);
                PopolaListView(ClsDB.Discipline);
            }
        }
    }
}
