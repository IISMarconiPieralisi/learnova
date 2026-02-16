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
    public partial class FrmVerifica : Form //Andrea Giorgini
    {

        int _x = 117, _y = 50;
        
        int _margine = 50;
        int _altezza = 350;


        List<Panel> _pannelli = new List<Panel>();
        List<Panel> _pannelliRisposte = new List<Panel>();
        List<ComboBox> _comboboxesTipologiaDomanda = new List<ComboBox>();
        List<TextBox> _tbTesti = new List<TextBox>();
        List<RichTextBox> _rtbRisposteDomandeAperte = new List<RichTextBox>();
        List<RadioButton> _rbRisposteDomandeSingole = new List<RadioButton>();
        List<CheckBox> _cbxRisposteDomandeMultiple = new List<CheckBox>();

 


        ClsVerifica _verifica = new ClsVerifica();
        bool _isDocente;
        ClsDocente _docente;
        ClsStudente _studente;
        

        public FrmVerifica(ClsPersona persona, ClsVerifica verifica=null)
        {
            InitializeComponent();
            _verifica = verifica;
            if (persona.GetType() == typeof(ClsDocente))
            {
                _docente = (ClsDocente)persona;
                _isDocente = true;
            }
            else if(persona.GetType() == typeof(ClsStudente))
            {
                _studente = (ClsStudente)persona;
                _isDocente = false;
                tbTitoloVerifica.ReadOnly = true;
                nudDurata.ReadOnly = true;
                cbDisciplina.Enabled = false;
                cbStato.Enabled = false;
                btnSalva.Text = "Consegna";
                btnSalva.Click -= btnSalva_Click;
                btnSalva.Click += btnConsegna_Click;
                pnlDomande.Controls.Remove(btnAggiungi);
            }

        }





        private void AggiungiCasellaDomanda(ClsDomanda domanda = null)//trasforma la domanda in un pannello che la visualizza graficamente
        {
            //pannello padre che racchiude tutto ciò che riguarda la domanda
            Panel _pnlDomanda = new Panel();
            _pnlDomanda.Size = new System.Drawing.Size(1662, _altezza);
            _pnlDomanda.TabIndex = 3;
            _pnlDomanda.BorderStyle = BorderStyle.FixedSingle;
            //_pnlDomanda.Tag = domanda;

            //testo domanda
            TextBox _tbTesto = new TextBox();
            _tbTesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _tbTesto.Location = new System.Drawing.Point(37, 28);
            _tbTesto.Name = "textBox1";
            _tbTesto.Size = new System.Drawing.Size(1171, 49);
            _tbTesto.TabIndex = 4;

            //combobox per scegliere il tipo di domanda
            ComboBox _cbTipologia = new ComboBox();
            _cbTipologia.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _cbTipologia.FormattingEnabled = true;
            _cbTipologia.Items.AddRange(new object[] {
                    "Vero o Falso",
                    "Singola chiusa",
                    "Multipla chiusa",
                    "Aperta"});
            _cbTipologia.Location = new System.Drawing.Point(1275, 36);
            _cbTipologia.Size = new System.Drawing.Size(334, 41);
            _cbTipologia.TabIndex = 3;
            _cbTipologia.DropDownStyle = ComboBoxStyle.DropDownList;
            _cbTipologia.SelectedIndexChanged += cbTipologia_ChangedIndex;

            //pannello dove lo studente può rispondere
            Panel _pnlRisposta = new Panel();
            _pnlRisposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _pnlRisposta.Location = new System.Drawing.Point(37, 100);
            _pnlRisposta.Size = new System.Drawing.Size(1171, 200);
            _pnlRisposta.BorderStyle = BorderStyle.FixedSingle;
            _pnlRisposta.Tag = domanda;
            _pnlRisposta.Name = "pnlRisposta";
            _pnlRisposta.AutoScroll = true;

            //bottone per il docente, serve a cancellare la domanda
            Button _btnCancella = new Button();
            _btnCancella.Text = "🗑️";
            _btnCancella.Size = new Size(80, 80);
            _btnCancella.Location = new Point(1220,100);
            _btnCancella.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _btnCancella.Click += btnCancella_Click;

            //per le domande chiuse serve a gestire le risposte
            Button _btnGestisciRisposte = new Button();
            _btnGestisciRisposte.Text = "Gestisci Risposte";
            _btnGestisciRisposte.Name = "btnGestisci";
            _btnGestisciRisposte.AutoSize = true;
            _btnGestisciRisposte.Location = new Point(1400, 100);
            _btnGestisciRisposte.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _btnGestisciRisposte.Click += _btnGestisciRisposte_Click;
            _btnGestisciRisposte.Visible = false;

            
            

            //aggiungo i controlli grafici alle liste cosi da raggiungerle meglio
            _pannelli.Add(_pnlDomanda);
            _comboboxesTipologiaDomanda.Add(_cbTipologia);
            _tbTesti.Add(_tbTesto);
            _pannelliRisposte.Add(_pnlRisposta);
            

            //aggiungo tutto al pannello principale
            _pnlDomanda.Controls.Add(_cbTipologia);
            _pnlDomanda.Controls.Add(_tbTesto);
            _pnlDomanda.Controls.Add(_pnlRisposta);
            _pnlDomanda.Controls.Add(_btnCancella);
            _pnlDomanda.Controls.Add(_btnGestisciRisposte);
            
            //aggiungo il pannello al pannello che racchiude tutte le domande
            pnlDomande.Controls.Add(_pnlDomanda);

            //calcola la y, sottraendo lo scroll position
            int _scrollY = Math.Abs(pnlDomande.AutoScrollPosition.Y);
            _pnlDomanda.Location = new Point(_x, _y - _scrollY);
            _y = _y + _altezza + _margine;
            btnAggiungi.Location = new Point(_x, _y - _scrollY);

            if (domanda != null)//se la domanda esiste già
            {
                _tbTesto.Text = domanda.Testo;

                //verifico se è una domanda chiusa
                if (domanda.GetType() == typeof(ClsDomandaChiusa))
                {
                    ClsDomandaChiusa _domandaChiusa = (ClsDomandaChiusa)domanda;
                    int _tipoDomanda = (int)_domandaChiusa.TIPOLOGIA;
                    

                    //Inserisco i rispettivi controlli grafici al tipo di domanda chiusa
                    switch (_tipoDomanda)
                    {
                        case 0:
                            CreaVeroFalso(_pnlRisposta, _domandaChiusa);
                            _btnGestisciRisposte.Visible = false;
                            break;
                        case 1:
                            CreaSingola(_pnlRisposta, _domandaChiusa);

                            break;
                        case 2:
                            CreaMultipla(_pnlRisposta, _domandaChiusa);
                            _btnGestisciRisposte.Visible = false;
                            break;
                    }
                    _pnlDomanda.Tag = _domandaChiusa;//cambio il tag del pannello
                    _cbTipologia.SelectedIndex = _tipoDomanda;//aggiorno la combobox

                }
                else
                {
                    _pnlDomanda.Tag = domanda;//metto come tag del pannello la domanda
                    _cbTipologia.SelectedIndex = 3;//aggiorno combobox a domanda aperta
                    CreaAperta(_pnlRisposta);//inserisco la rtb nel pannello risposta

                }



            }
            else
            {
                ClsDomanda _domanda = new ClsDomanda();
                _domanda.IdVerifica = _verifica.Id;
                _pnlDomanda.Tag = _domanda;
                _cbTipologia.SelectedIndex = 0;
                
            }


            if (!_isDocente)
            {
                _pnlDomanda.Controls.Remove(_btnCancella);
                _pnlDomanda.Controls.Remove(_btnGestisciRisposte);
                _cbTipologia.Visible = false;
                _tbTesto.ReadOnly = true;
            }








        }
        

        private void CreaAperta(Panel pnlRisposta)
        {
            pnlRisposta.Controls.Clear();
            Button _button = (Button)pnlRisposta.Parent.Controls.Find("btnGestisci", true)[0];
            _button.Visible = false;
            RichTextBox _rtbRisposta = new RichTextBox();
            _rtbRisposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _rtbRisposta.Location = new System.Drawing.Point(0, 0);
            _rtbRisposta.Size = new System.Drawing.Size(1171, 200);
            _rtbRisposteDomandeAperte.Add(_rtbRisposta);
            _rtbRisposta.Tag = (Panel)pnlRisposta.Parent;
            pnlRisposta.Controls.Add(_rtbRisposta);
        }

        private void CreaMultipla(Panel pnlRisposta, ClsDomandaChiusa domanda)
        {
            pnlRisposta.Controls.Clear();
            Button _button=(Button)pnlRisposta.Parent.Controls.Find("btnGestisci", true)[0];
            _button.Visible = true;
            
            int _XX = 10, _YY = 10;
            List<ClsRisposta> _risposte = domanda.OttieniRisposte();
            foreach (ClsRisposta r in _risposte)
            {
                CheckBox _cbx = new CheckBox();
                _cbx.Text = r.Testo;
                _cbx.AutoSize = true;
                _cbx.Tag = r;
                _cbx.Location = new Point(_XX, _YY);
                _cbx.Tag = (Panel)pnlRisposta.Parent;
                _YY += 50;
                _cbxRisposteDomandeMultiple.Add(_cbx);
                pnlRisposta.Controls.Add(_cbx);
            }
        }

        private void CreaSingola(Panel pnlRisposta, ClsDomandaChiusa domanda)
        {
            pnlRisposta.Controls.Clear();
            Button _button = (Button)pnlRisposta.Parent.Controls.Find("btnGestisci", true)[0];
            _button.Visible = true;
            int _x = 10, _y = 10;
            List<ClsRisposta> _risposte = domanda.OttieniRisposte();
            foreach (ClsRisposta r in _risposte)
            {

                RadioButton _rb = new RadioButton();
                _rb.AutoSize = true;
                _rb.Text = r.Testo;
                _rb.Tag = r;
                _rb.Location = new Point(_x, _y);
                _rb.Tag = (Panel)pnlRisposta.Parent;
                _y += 50;
                
                _rbRisposteDomandeSingole.Add(_rb);
                pnlRisposta.Controls.Add(_rb);
            }
        }

        private void CreaVeroFalso(Panel pnlRisposta, ClsDomandaChiusa domanda)
        {
            Button _button = (Button)pnlRisposta.Parent.Controls.Find("btnGestisci", true)[0];
            _button.Visible = true;
            List<ClsRisposta> _risposte = domanda.OttieniRisposte();
            pnlRisposta.Controls.Clear();
            RadioButton _rbVero = new RadioButton();
            _rbVero.Text = "Vero";
            _rbVero.Tag = 1;
            _rbVero.Location = new Point(10, 10);
            _rbVero.AutoSize = true;
            _rbVero.Tag = (Panel)pnlRisposta.Parent;

            RadioButton _rbFalso = new RadioButton();
            _rbFalso.Text = "Falso";
            _rbFalso.Tag = 0;
            _rbFalso.Location = new Point(10, 40);
            _rbFalso.AutoSize = true;
            _rbFalso.Tag = (Panel)pnlRisposta.Parent;

            _rbRisposteDomandeSingole.Add(_rbVero);
            _rbRisposteDomandeSingole.Add(_rbFalso);

            pnlRisposta.Controls.Add(_rbVero);
            pnlRisposta.Controls.Add(_rbFalso);
        }

        


        private void TrasformaDomandeInPanel(ClsVerifica verifica)//trasforma le domande della verifica in pannelli che può visualizzare il docente o lo studente
        {
            List<ClsDomanda> _domande = new List<ClsDomanda>();
            tbTitoloVerifica.Text = verifica.Nome;
            _domande=verifica.OttieniListaDomande();//ottengo la lista di domande della verifica

            foreach (ClsDomanda d in _domande)//Scorre tutte le domande
                AggiungiCasellaDomanda(d);
            
        }

        //elimina tutti pannelli con le domande
        private void EliminaTuttiPannelli()
        {
            foreach (Panel p in _pannelli)
                this.Controls.Remove(p);
            _pannelli.Clear();

        }

        //riempe la combobox con le disciplina
        private void RiempiCbDisciplina()
        {
            foreach(ClsDisciplina disciplina in ClsDB.Discipline)
                cbDisciplina.Items.Add(disciplina.Nome);
            
        }

        //aggiorna il pnlRisposta per le domande chiuse
        private void AggiornaRisposte(ClsDomandaChiusa domanda)
        {
            Panel _pnlRisposta = _pannelliRisposte.Find(d => ((ClsDomanda)d.Parent.Tag).Id == domanda.Id);
            switch ((int)domanda.TIPOLOGIA)
            {
                case 0:
                    CreaVeroFalso(_pnlRisposta, domanda);
                    break;
                case 1:
                    CreaSingola(_pnlRisposta, domanda);
                    break;
                case 2:
                    CreaMultipla(_pnlRisposta, domanda);
                    break;
            }
        }

        //al cambiare della tipologia, modifica il pnlRisposta e cambia la tipologia della domanda inserendola nel tag
        private void cbTipologia_ChangedIndex(object sender, EventArgs e)
        {
            SalvaSuDB();
            ComboBox _cbSender = (ComboBox)sender;
            Panel _pnlDomanda = (Panel)_cbSender.Parent;
            ClsDomanda _domanda = (ClsDomanda)_pnlDomanda.Tag;
            Panel _pnlRisposta = _pannelliRisposte.Find(d=>((ClsDomanda)d.Parent.Tag).Id==_domanda.Id);
            int _indiceCB=_cbSender.SelectedIndex;
            
            if (_indiceCB >= 0 && _indiceCB < 3)
            {
                ClsDomandaChiusa _domandaChiusa = _domanda.ConverToDomandaChiusa(_indiceCB);
                _domandaChiusa.TIPOLOGIA = (ClsDomandaChiusa.eTipologia)_indiceCB;
                _cbSender.Parent.Tag = _domandaChiusa;
                switch (_indiceCB)
                {
                    case 0:
                        CreaVeroFalso(_pnlRisposta, _domandaChiusa);
                        break;
                    case 1:
                        CreaSingola(_pnlRisposta, _domandaChiusa);
                        break;
                    case 2:
                        CreaMultipla(_pnlRisposta, _domandaChiusa);
                        break;
                }
               _cbSender.Parent.Tag = _domandaChiusa;
            }
            else if (_indiceCB == 3)
            {
                CreaAperta(_pnlRisposta);
                _cbSender.Parent.Tag = _domanda.ConverToDomanda();
            }
                    
            
               
            

        }

    


        private void FrmVerifica_Load(object sender, EventArgs e)
        {
            //_verifica = new ClsVerifica();
            //_verifica.Nome = "ciao";

            //ClsDomanda _domanda = new ClsDomanda();
            //_domanda.Testo = "ciao";
            //_domanda.IdVerifica = _verifica.Id;

            //ClsRisposta _risposta = new ClsRisposta();
            //_risposta.Testo = "ciao";
            //_risposta.IdDomanda = _domanda.Id;

            //ClsDB.Verifiche.Add(_verifica);
            //ClsDB.Domande.Add(_domanda);
            //ClsDB.Risposte.Add(_risposta);


            //se la verifica già esiste carico le domande
            
            TrasformaDomandeInPanel(_verifica);
            
            
            

        }


        
        //apre la form per la gestione delle risposte per le domande chiuse
        private void _btnGestisciRisposte_Click(object sender, EventArgs e)
        {
            Button _btnSender = (Button)sender;
            ComboBox _cb = _comboboxesTipologiaDomanda[_pannelli.FindIndex(d=> d==((Panel)_btnSender.Parent))];
            if(_cb.SelectedIndex >= 1 && _cb.SelectedIndex < 3)
            {
                FrmRisposte _frmRisposte = new FrmRisposte((ClsDomandaChiusa)_btnSender.Parent.Tag);
                _frmRisposte.ShowDialog(this);
                AggiornaRisposte((ClsDomandaChiusa)_btnSender.Parent.Tag);
            }
            else if(_cb.SelectedIndex == 0)
            {
                FrmRisposte _frmRisposte = new FrmRisposte((ClsDomandaChiusa)_btnSender.Parent.Tag, true);
                _frmRisposte.ShowDialog(this);
                AggiornaRisposte((ClsDomandaChiusa)_btnSender.Parent.Tag);
            }
            
        }
        private void btnSalva_Click(object sender, EventArgs e)
        {
            SalvaSuDB();
        }

        private void btnConsegna_Click(object sender, EventArgs e)
        {
            ConsegnaVerifica();
        }

        private void ConsegnaVerifica()
        {
            
            for(int i = 0; i < _pannelliRisposte.Count; i++)
            {
                ClsRispondere _rispondere = new ClsRispondere();
                switch (_comboboxesTipologiaDomanda[i].SelectedIndex)
                {
                    case 3://domanda aperta

                        _rispondere.Risposta = _rtbRisposteDomandeAperte.Find(d => (Panel)d.Parent == _pannelliRisposte[i]).Text;
                        _rispondere.IdDomanda = ((ClsDomanda)_pannelliRisposte[i].Parent.Tag).Id;
                        _rispondere.CfStudente = _studente.CF;
                        break;
                    case 2:
                        List<RadioButton> _radioButtons = new List<RadioButton>();
                        _radioButtons = _rbRisposteDomandeSingole.FindAll(d => (Panel)d.Parent == _pannelliRisposte[i]);
                        _rispondere.Risposta = _radioButtons.Find(d => d.Checked == true).Text;
                        _rispondere.IdDomanda = ((ClsDomanda)_pannelliRisposte[i].Parent.Tag).Id;
                        _rispondere.CfStudente = _studente.CF;
                        break;
                    case 1:
                        List<CheckBox> _checkBoxes = new List<CheckBox>();
                        _checkBoxes = _cbxRisposteDomandeMultiple.FindAll(d => (Panel)d.Parent == _pannelliRisposte[i]);
                        foreach(CheckBox cb in _checkBoxes)
                        {
                            if (cb.Checked)
                            {
                                _rispondere = new ClsRispondere();
                                _rispondere.Risposta = cb.Text;
                                _rispondere.IdDomanda = ((ClsDomanda)_pannelliRisposte[i].Parent.Tag).Id;
                                _rispondere.CfStudente = _studente.CF;
                                ClsDB.Rispondere.Add(_rispondere);
                            }
                        }

                        
                        break;
                    case 0:

                        break;
                }
            }
        }


        private void SalvaSuDB()
        {
            try
            {
                _verifica.Nome = tbTitoloVerifica.Text;
                _verifica.Durata = (int)nudDurata.Value;
                _verifica.Aperta = Convert.ToBoolean(cbStato.SelectedIndex);
                //_verifica.IdDisciplina = ClsDB.Discipline.Find(d => d.Nome == cbDisciplina.SelectedText).Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Si è verificato un errore: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _verifica.EliminaTutteDomande();

            for (int i = 0; i < _pannelli.Count; i++)
            {
                try
                {
                    ClsDomanda _domanda = (ClsDomanda)_pannelli[i].Tag;
                    _domanda.Testo = _tbTesti[i].Text;
                    if (_domanda.GetType() == typeof(ClsDomandaChiusa))
                    {
                        ClsDomandaChiusa _domandaChiusa = (ClsDomandaChiusa)_domanda;
                        ClsDB.DomandeChiuse.Add(_domandaChiusa);
                    }
                    else
                    {
                        ClsDB.Domande.Add(_domanda);
                    }
                }
                
                catch (Exception ex)
                {
                    MessageBox.Show("Si è verificato un errore: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        



        }

        private void btnCancella_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Sei sicuro di voler cancellare?", "Sei sicuro di voler cancellare?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Button _btnSender = (Button)sender;
                Panel _pannello = (Panel)_btnSender.Parent;
                int _indicePannello = _pannelli.FindIndex(d => d == _pannello);

                ShiftaPannelli(_indicePannello);

                _pannelli.RemoveAt(_indicePannello);
                _tbTesti.RemoveAt(_indicePannello);
                _pannelliRisposte.RemoveAt(_indicePannello);
                _comboboxesTipologiaDomanda.RemoveAt(_indicePannello);
                _rtbRisposteDomandeAperte.RemoveAll(d => ((Panel)d.Tag) == _pannello);
                _rbRisposteDomandeSingole.RemoveAll(d => ((Panel)d.Tag) == _pannello);
                _cbxRisposteDomandeMultiple.RemoveAll(d => ((Panel)d.Tag) == _pannello);
                _pannello.Controls.Clear();
                pnlDomande.Controls.Remove(_pannello);



            }
            
                           
        }

        private void ShiftaPannelli(int indicePannello)
        {

            int x = _pannelli[indicePannello].Location.X;
            _y = _pannelli[indicePannello].Location.Y;

            int _scrollY = Math.Abs(_pannelli[_pannelli.Count - 1].AutoScrollPosition.Y);
            if (indicePannello + 1 == _pannelli.Count)
                btnAggiungi.Location = new Point(x, _y - _scrollY);
            
            for (int i = indicePannello+1; i < _pannelli.Count;i++)
            {
                _pannelli[i].Location = new Point(x, _y - _scrollY);
                _y = _y + _altezza + _margine;
                btnAggiungi.Location = new Point(x, _y - _scrollY);
            }
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            AggiungiCasellaDomanda();
        }
    }
}