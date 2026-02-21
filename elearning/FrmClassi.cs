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
    public partial class FrmClassi : Form
    {
        bool _modifica;
        public FrmClassi()
        {
            InitializeComponent();
        }

        private void BtnSalva_Click(object sender, EventArgs e)
            //gg
        {
            string sigla = tbSigla.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(sigla))
            {
                MessageBox.Show("Inserisci la sigla della classe");
                return;
            }

            try
            {
                if (_modifica)
                {
                    // MODIFICA
                    ClsClasse classeSelezionata =
                        (ClsClasse)lvClasse.SelectedItems[0].Tag;

                    classeSelezionata.Sigla_Classi = sigla;
                    MessageBox.Show("Classe modificata correttamente");
                    SalvaClassiSuFile();

                }
                else
                {
                    // INSERIMENTO
                    if (chPer5.Checked)
                    {
                        for(int i = 0; i < 5; i++)
                        {
                            ClsClasse nuovaClasse = new ClsClasse();
                            nuovaClasse.Sigla_Classi = (i+1) + sigla;
                            ClsDB.Classi.Add(nuovaClasse);
                        }
                        MessageBox.Show("Classi inserite correttamente");
                    }
                    else
                    {
                        ClsClasse nuovaClasse = new ClsClasse();
                        nuovaClasse.Sigla_Classi = sigla;
                        ClsDB.Classi.Add(nuovaClasse);
                        MessageBox.Show("Classe inserita correttamente");
                    }
                    SalvaClassiSuFile();

                }

                PopolaListView();
                tbSigla.Clear();
                pnlSalva.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _modifica = false;
        }

        void SalvaClassiSuFile()
        {
            StreamWriter sw = new StreamWriter("classi.json");
            sw.WriteLine(JsonConvert.SerializeObject(ClsDB.Classi));
            sw.Close();
        }
        public static void CaricaClassiDaFile()
        {
            if (File.Exists("classi.json"))
            {
                StreamReader sr = new StreamReader("classi.json");
                ClsDB.Classi = new List<ClsClasse>();
                ClsDB.Classi = JsonConvert.DeserializeObject<List<ClsClasse>>(sr.ReadToEnd());
                sr.Close();
            }
        }

        private void PopolaListView()
        {
            lvClasse.Items.Clear();

            foreach (ClsClasse c in ClsDB.Classi)
            {
                ListViewItem item = new ListViewItem(c.Sigla_Classi);
                item.Tag = c; 
                lvClasse.Items.Add(item);
            }
        }
        private void EliminaClasse()
        {
            if (lvClasse.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleziona una classe da eliminare");
                return;
            }

            ClsClasse classe = (ClsClasse)lvClasse.SelectedItems[0].Tag;

            ClsDB.Classi.Remove(classe);
            SalvaClassiSuFile();

            PopolaListView();
        }


        private void btnElimina_Click(object sender, EventArgs e)
        {
            EliminaClasse();

        }
        private void OrdinaClassi()
        {
            ClsDB.Classi = ClsDB.Classi
                .OrderBy(c => c.Sigla_Classi)
                .ToList();
            SalvaClassiSuFile();

            PopolaListView();
        }

        private void btnOrdina_Click(object sender, EventArgs e)
        {
            OrdinaClassi();
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            _modifica = false;
            chPer5.Visible = true;
            pnlSalva.Visible = true;
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            _modifica = true;
            chPer5.Visible = false;
            pnlSalva.Visible = true;
            ModificaClasse();
        }
        private void ModificaClasse()
        {
            if (lvClasse.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleziona una classe da modificare");
                return;
            }

            string nuovaSigla = tbSigla.Text.Trim();

            if (string.IsNullOrEmpty(nuovaSigla))
            {
                MessageBox.Show("Inserisci la nuova sigla");
                return;
            }

            // Classe selezionata
            ClsClasse classe = (ClsClasse)lvClasse.SelectedItems[0].Tag;

            // Modifica
            classe.Sigla_Classi = nuovaSigla;

            // Aggiorna ListView
            PopolaListView();

        }
        private void CercaClasse()
        {
            string testo = tbCerca.Text.ToUpper().Trim(); // rendi case-insensitive e pulito

            List<ClsClasse> classiFiltrate;

            if (string.IsNullOrEmpty(testo))
            {
                // Se vuoto, mostra tutte le classi
                classiFiltrate = ClsDB.Classi;
            }
            else
            {
                classiFiltrate = ClsDB.Classi.FindAll(c => c.Sigla_Classi.Contains(testo));
            }

            // Aggiorna ListView
            lvClasse.Items.Clear();
            foreach (var c in classiFiltrate)
            {
                ListViewItem item = new ListViewItem(c.Sigla_Classi);
                item.Tag = c;
                lvClasse.Items.Add(item);
            }
        }

        private void BtnCerca_Click(object sender, EventArgs e)
        {
            CercaClasse();

        }

        private void FrmClassi_Load(object sender, EventArgs e)
        {

            CaricaClassiDaFile();
            PopolaListView();
        }
    }
}
