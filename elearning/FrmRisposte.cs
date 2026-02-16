using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace elearning
{
    public partial class FrmRisposte : Form//Andrea Giorgini
    {
        ClsDomandaChiusa _domanda;
        bool _VF;
        ClsRisposta _rispostaV = new ClsRisposta();
        ClsRisposta _rispostaF = new ClsRisposta();
        public FrmRisposte(ClsDomandaChiusa domanda, bool VF=false)
        {
            InitializeComponent();
            _domanda = domanda;
            _VF = VF;
            if (VF)
            {
                btnAggiungi.Enabled = false;
                btnElimina.Enabled = false;


            }
            else
            {
                btnAggiungi.Enabled = true;
                btnElimina.Enabled = true;
            }
        }

        private void lvRisposte_SelectedIndexChanged(object sender, EventArgs e)//al cambiare del indice, cambia l'icona del bottone per decidere se la risposta è corretta o no
        {
            CambiaIconaBtnCorretta();
        }

        private void PopulaListView(ListView lv, ClsDomandaChiusa domanda)
        {
            lv.Items.Clear();
            List<ClsRisposta> _risposte;
            if (_VF)
            {
                _risposte = new List<ClsRisposta>();
                if (_domanda.VFCORRETTA)
                {
                    _rispostaV.Corretta = true;
                    _rispostaF.Corretta = false;
                }
                    
                else
                {
                    _rispostaV.Corretta = false;
                    _rispostaF.Corretta = true;
                }
                    
                _rispostaV.Id = -1;
                _rispostaV.Testo = "Vero";
                
                _rispostaF.Id = -1;
                _rispostaF.Testo = "Falso";

                _risposte.Add(_rispostaV);
                _risposte.Add(_rispostaF);

            }
            else
            {
                _risposte = domanda.OttieniRisposte();
            }
            foreach(ClsRisposta risposta in _risposte)
            {
                ListViewItem _item = new ListViewItem(risposta.Testo);
                _item.SubItems.Add(risposta.Id.ToString());
                _item.SubItems.Add(risposta.Corretta.ToString());
                _item.Tag = risposta;
                lv.Items.Add(_item);
            }
            
        }

        private void CambiaIconaBtnCorretta()//se la risposta è corretta, metterà l'icona della x per renderla falsa e viceversa, se nulla è selezionato l'icona del divieto
        {
            if (lvRisposte.SelectedIndices.Count == 1)
            {
                if (_VF)
                {
                    btnCorretta.Enabled = true;
                    if (lvRisposte.SelectedIndices[0]==0 && _domanda.VFCORRETTA || lvRisposte.SelectedIndices[0] == 1 && !_domanda.VFCORRETTA)
                    {
                        btnCorretta.Text = "❌";
                        btnCorretta.ForeColor = Color.Red;
                    }
                    else
                    {
                        btnCorretta.Text = "✔️";
                        btnCorretta.ForeColor = Color.Green;
                    }
                }
                else
                {
                    btnCorretta.Enabled = true;
                    ClsRisposta _risposta = ClsDB.Risposte.Find(d => d.Id == ((ClsRisposta)lvRisposte.SelectedItems[0].Tag).Id);
                    if (_risposta.Corretta)
                    {
                        btnCorretta.Text = "❌";
                        btnCorretta.ForeColor = Color.Red;
                    }
                    else
                    {
                        btnCorretta.Text = "✔️";
                        btnCorretta.ForeColor = Color.Green;
                    }
                }
                

            }
            else
            {
                
                
                btnCorretta.Enabled = false;
                btnCorretta.Text = "🚫";
                btnCorretta.ForeColor = Color.Red;
                
                
            }
            
        }

        private void btnCorretta_Click(object sender, EventArgs e)//rende una domanda corretta o sbagliata
        {
            if (lvRisposte.SelectedIndices.Count == 1)
            {
                if (_VF)
                {
                    if (lvRisposte.SelectedIndices[0] == 0)
                        _domanda.VFCORRETTA = true;
                    else
                        _domanda.VFCORRETTA = false;
                    CambiaIconaBtnCorretta();
                }
                else
                {
                    ClsRisposta _risposta = (ClsRisposta)lvRisposte.SelectedItems[0].Tag;
                    _risposta.DomandaCorretta(_domanda, !_risposta.Corretta);
                    CambiaIconaBtnCorretta();
                }
                

            }
            PopulaListView(lvRisposte, _domanda);
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (lvRisposte.SelectedIndices.Count == 1)
            {
                DialogResult _dr = MessageBox.Show("Sei sicuro di voler eliminare l'elemento", "Sei sicuro di voler eliminare l'elemento", MessageBoxButtons.YesNo);
                if (_dr == DialogResult.Yes)
                {
                    ClsDB.Risposte.Remove((ClsRisposta)lvRisposte.SelectedItems[0].Tag);
                }
            }
            PopulaListView(lvRisposte, _domanda);


        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            ClsRisposta _risposta = new ClsRisposta();
            string _testo = tbTesto.Text;
            if (!string.IsNullOrWhiteSpace(_testo))
            {
                _risposta.Testo = _testo;
                _risposta.IdDomanda = _domanda.Id;
                ClsDB.Risposte.Add(_risposta);
                PopulaListView(lvRisposte, _domanda);
            }
            
        }

        private void FrmRisposte_Load(object sender, EventArgs e)
        {
            PopulaListView(lvRisposte, _domanda);
        }

        private void SalvaSuFile()
        {

        }
        
    }
}
