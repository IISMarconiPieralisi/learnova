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
    public partial class FrmMenuStudente : Form
    {
        ClsStudente _studente;
        public FrmMenuStudente(ClsStudente studente)
        {
            InitializeComponent();
            _studente = studente;
        }

        private void FrmMenuStudente_Load(object sender, EventArgs e)
        {
            AggiornaListView(ClsDB.Formare);
        }

        private void AggiornaListView(List<ClsFormare> formazioni)
        {

            lvCorsi.Items.Clear();
            //popolamento list classi dello studente
            List <ClsFormare> formare = ClsDB.Formare.FindAll(val => val.SiglaClasse == _studente.SiglaClasse);
            //popolamento listview
            for(int i = 0; i < formare.Count; i++)
            {
                ClsDisciplina _disciplinaCorrente = ClsDB.Discipline.Find(val => val.Id == formare[i].IdDisciplina);
                ClsDocente _docenteCorrente = ClsDB.Docenti.Find(val => val.CF == formare[i].CfDocente);
                ListViewItem lvi = new ListViewItem(_disciplinaCorrente.Nome);
                lvi.SubItems.Add(formare[i].SiglaClasse);
                lvi.SubItems.Add(_docenteCorrente.Cognome);
                lvCorsi.Items.Add(lvi);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(lvCorsi.SelectedIndices.Count > 0)
            {
                FrmVerifiche frmverifiche = new FrmVerifiche(_studente);
                frmverifiche.ShowDialog();
            }

        }
    }
}
