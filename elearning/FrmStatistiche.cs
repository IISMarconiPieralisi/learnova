using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace elearning
{
    public partial class FrmStatistiche : Form
    {
        private ClsDocente _docente;
        private ClsStudente _studente;
        private ClsDisciplina _disciplina;
        private bool _isDocente;

        // Costruttore per Docente
        public FrmStatistiche(ClsDocente docente)
        {
            InitializeComponent();
            _docente = docente;
            _isDocente = true;
        }

        // Costruttore per Studente
        public FrmStatistiche(ClsStudente studente, ClsDisciplina disciplina)
        {
            InitializeComponent();
            _studente = studente;
            _disciplina = disciplina;
            _isDocente = false;
        }

        private void FrmStatistiche_Load(object sender, EventArgs e)
        {
            if (_isDocente)
            {
                CaricaStatisticheDocente();
            }
            else
            {
                CaricaStatisticheStudente();
            }
        }

        private void CaricaStatisticheDocente()
        {
            // Configura il titolo
            //this.Text = "Statistiche Verifiche - Prof. " + _docente.Cognome;
            lblTitolo.Text = "Statistiche Voti Studenti";

            // Configura il Chart
            chartStatistiche.Series.Clear();
            chartStatistiche.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea("MainArea");
            chartArea.AxisX.Title = "Fasce di Voto";
            chartArea.AxisY.Title = "Numero Studenti";
            chartArea.AxisX.Interval = 1;
            chartStatistiche.ChartAreas.Add(chartArea);

            // Crea serie per l'istogramma
            Series series = new Series("Distribuzione Voti");
            series.ChartType = SeriesChartType.Column;
            series.Color = Color.Teal;

            // Ottiene tutte le verifiche del docente
            List<ClsVerifica> verificheDocente = ClsDB.Verifiche.FindAll(v => v.CfDocente == _docente.CF);

            if (verificheDocente.Count == 0)
            {
                MessageBox.Show("Nessuna verifica trovata.",
                               "Informazione",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                return;
            }

            // Crea fasce di voto (0-3, 3-4, 4-5, 5-6, 6-7, 7-8, 8-9, 9-10)
            Dictionary<string, int> fasceDiVoto = new Dictionary<string, int>
            {
                {"0-3", 0},
                {"3-4", 0},
                {"4-5", 0},
                {"5-6", 0},
                {"6-7", 0},
                {"7-8", 0},
                {"8-9", 0},
                {"9-10", 0}
            };

            // Calcola i voti per ogni studente in ogni verifica
            foreach (ClsVerifica verifica in verificheDocente)
            {
                // Ottiene tutte le domande della verifica
                List<ClsDomanda> domande = verifica.OttieniListaDomande();

                // Per ogni studente, calcola il voto totale
                foreach (ClsStudente studente in ClsDB.Studenti)
                {
                    decimal votoTotale = 0;
                    decimal punteggioMassimo = 0;

                    foreach (ClsDomanda domanda in domande)
                    {
                        punteggioMassimo += domanda.PunteggioMax;

                        // Cerca le risposte dello studente per questa domanda
                        if (domanda is ClsDomandaChiusa)
                        {
                            ClsDomandaChiusa domandaChiusa = (ClsDomandaChiusa)domanda;

                            if (domandaChiusa.TIPOLOGIA == ClsDomandaChiusa.eTipologia.VF)
                            {
                                // Cerca in ClsVFRispondere
                                ClsVFRispondere vfRisposta = ClsDB.VfRispondere.Find(vf =>
                                    vf != null); // Qui servirebbe un link tra studente e risposta

                                if (vfRisposta != null)
                                {
                                    votoTotale += vfRisposta.PunteggioOttenuto;
                                }
                            }
                            else
                            {
                                // Cerca in ClsScegliere per domande a scelta
                                ClsScegliere scelta = ClsDB.Scegliere.Find(s =>
                                    s.Studente != null && s.Studente.Matricola == studente.Matricola);

                                if (scelta != null)
                                {
                                    votoTotale += scelta.PunteggioOttenuto;
                                }
                            }
                        }
                        else
                        {
                            // Domanda aperta - cerca in ClsRispondere
                            ClsRispondere risposta = ClsDB.Rispondere.Find(r => r != null);

                            if (risposta != null)
                            {
                                votoTotale += risposta.PunteggioOttenuto;
                            }
                        }
                    }

                    // Normalizza il voto in decimi se c'è un punteggio massimo
                    if (punteggioMassimo > 0)
                    {
                        decimal votoDecimi = (votoTotale / punteggioMassimo) * 10;

                        // Assegna alla fascia corretta
                        if (votoDecimi >= 0 && votoDecimi < 3)
                            fasceDiVoto["0-3"]++;
                        else if (votoDecimi >= 3 && votoDecimi < 4)
                            fasceDiVoto["3-4"]++;
                        else if (votoDecimi >= 4 && votoDecimi < 5)
                            fasceDiVoto["4-5"]++;
                        else if (votoDecimi >= 5 && votoDecimi < 6)
                            fasceDiVoto["5-6"]++;
                        else if (votoDecimi >= 6 && votoDecimi < 7)
                            fasceDiVoto["6-7"]++;
                        else if (votoDecimi >= 7 && votoDecimi < 8)
                            fasceDiVoto["7-8"]++;
                        else if (votoDecimi >= 8 && votoDecimi < 9)
                            fasceDiVoto["8-9"]++;
                        else if (votoDecimi >= 9 && votoDecimi <= 10)
                            fasceDiVoto["9-10"]++;
                    }
                }
            }

            // Aggiungi i dati al grafico
            foreach (var fascia in fasceDiVoto)
            {
                series.Points.AddXY(fascia.Key, fascia.Value);
            }

            chartStatistiche.Series.Add(series);

            // Aggiungi legenda
            chartStatistiche.Legends.Clear();
            Legend legend = new Legend("Legend");
            chartStatistiche.Legends.Add(legend);
        }

        private void CaricaStatisticheStudente()
        {
            // Configura il titolo
            this.Text = "I Miei Voti - " + _disciplina.Nome;
            lblTitolo.Text = "Voti in " + _disciplina.Nome;

            // Configura il Chart
            chartStatistiche.Series.Clear();
            chartStatistiche.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea("MainArea");
            chartArea.AxisX.Title = "Verifica";
            chartArea.AxisY.Title = "Voto";
            chartArea.AxisY.Minimum = 0;
            chartArea.AxisY.Maximum = 10;
            chartArea.AxisX.Interval = 1;
            chartStatistiche.ChartAreas.Add(chartArea);

            // Crea serie per l'istogramma
            Series series = new Series("I Miei Voti");
            series.ChartType = SeriesChartType.Column;
            series.Color = Color.DarkCyan;

            // Ottiene le verifiche della disciplina selezionata
            List<ClsVerifica> verificheMateria = ClsDB.Verifiche.FindAll(v =>
                v.IdDisciplina == _disciplina.Id);

            if (verificheMateria.Count == 0)
            {
                MessageBox.Show("Nessuna verifica trovata per questa materia.",
                               "Informazione",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                return;
            }

            // Ordina per data
            verificheMateria.Sort((a, b) => a.Data.CompareTo(b.Data));

            // Per ogni verifica, calcola il voto dello studente
            int indiceVerifica = 1;
            foreach (ClsVerifica verifica in verificheMateria)
            {
                // Ottiene tutte le domande della verifica
                List<ClsDomanda> domande = verifica.OttieniListaDomande();

                decimal votoTotale = 0;
                decimal punteggioMassimo = 0;

                foreach (ClsDomanda domanda in domande)
                {
                    punteggioMassimo += domanda.PunteggioMax;

                    // Cerca le risposte dello studente per questa domanda
                    if (domanda is ClsDomandaChiusa)
                    {
                        ClsDomandaChiusa domandaChiusa = (ClsDomandaChiusa)domanda;

                        if (domandaChiusa.TIPOLOGIA == ClsDomandaChiusa.eTipologia.VF)
                        {
                            // Cerca in ClsVFRispondere
                            ClsVFRispondere vfRisposta = ClsDB.VfRispondere.Find(vf =>
                                vf != null); // Qui servirebbe un link tra studente e risposta

                            if (vfRisposta != null)
                            {
                                votoTotale += vfRisposta.PunteggioOttenuto;
                            }
                        }
                        else
                        {
                            // Cerca in ClsScegliere per domande a scelta
                            ClsScegliere scelta = ClsDB.Scegliere.Find(s =>
                                s.Studente != null && s.Studente.Matricola == _studente.Matricola);

                            if (scelta != null)
                            {
                                votoTotale += scelta.PunteggioOttenuto;
                            }
                        }
                    }
                    else
                    {
                        // Domanda aperta - cerca in ClsRispondere
                        ClsRispondere risposta = ClsDB.Rispondere.Find(r => r != null);

                        if (risposta != null)
                        {
                            votoTotale += risposta.PunteggioOttenuto;
                        }
                    }
                }

                // Normalizza il voto in decimi
                decimal votoDecimi = 0;
                if (punteggioMassimo > 0)
                {
                    votoDecimi = (votoTotale / punteggioMassimo) * 10;
                }

                // Aggiungi al grafico
                string etichetta = verifica.Nome + "\n" + verifica.Data.ToShortDateString();
                series.Points.AddXY(etichetta, (double)votoDecimi);

                indiceVerifica++;
            }

            chartStatistiche.Series.Add(series);

            // Aggiungi legenda
            chartStatistiche.Legends.Clear();
            Legend legend = new Legend("Legend");
            chartStatistiche.Legends.Add(legend);

            // Aggiungi linea di sufficienza (6)
            Series lineaSufficienza = new Series("Sufficienza");
            lineaSufficienza.ChartType = SeriesChartType.Line;
            lineaSufficienza.Color = Color.Red;
            lineaSufficienza.BorderWidth = 2;
            lineaSufficienza.BorderDashStyle = ChartDashStyle.Dash;

            for (int i = 0; i < verificheMateria.Count; i++)
            {
                lineaSufficienza.Points.AddXY(i, 6);
            }

            chartStatistiche.Series.Add(lineaSufficienza);
        }
    }
}