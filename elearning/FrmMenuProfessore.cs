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
    public partial class FrmMenuProfessore : Form
    {
        string _cfDocente;
        public FrmMenuProfessore(string cf)
        {
            InitializeComponent();
            _cfDocente = cf;
        }

        private void FrmMenuProfessore_Load(object sender, EventArgs e)
        {
            MostraNomeDocente(_cfDocente);

            lvCorsi.Items.Clear();
            string cfDocente = _cfDocente;
            foreach (ClsFormare formare in ClsDB.Formare)
            {
                ClsDisciplina disciplina = ClsDB.Discipline.Find(val => val.Id == formare.IdDisciplina);
                if (disciplina != null && formare.CfDocente == _cfDocente)
                {
                    ListViewItem lvi = new ListViewItem(formare.SiglaClasse);
                    lvi.SubItems.Add(disciplina.Nome);
                    lvCorsi.Items.Add(lvi);
                }
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVisualizzaCorso_Click(object sender, EventArgs e)
        {
            if (lvCorsi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleziona una classe.");

            }
            else
            {
                ListViewItem selezionato = lvCorsi.SelectedItems[0];

                string siglaClasse = selezionato.Text;
                string materia = selezionato.SubItems[1].Text;
                string docente = _cfDocente;

                
                FrmVerifiche _frmVerifiche= new FrmVerifiche(ClsDB.Docenti.Find(val => val.CF == docente));
                _frmVerifiche.Show();
                this.Close();
            }
        }
        private void MostraNomeDocente(string cf)
        {
            var persona = ClsDB.Persone.Find(val => val.CF == cf);
            if (persona != null)
            {
                lblDocente.Text = persona.Nome + " " + persona.Cognome;
            }
        }
    }
}
