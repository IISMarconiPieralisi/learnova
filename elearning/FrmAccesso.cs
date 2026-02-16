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
    public partial class FrmAccesso : Form
    {
        public FrmAccesso()
        {
            InitializeComponent();

            //Testing
            ClsAdmin _admin = new ClsAdmin("admin123", "qwerty123");
            //ClsDocente _docente = new ClsDocente("docente123", "qwerty123");
            //ClsStudente _studente = new ClsStudente("st00000", "qwerty123");
            //_docente.CF = "CF2345";
            ClsDB.Admin = _admin;
            //ClsDB.Docenti.Add(_docente);
            //ClsDB.Studenti.Add(_studente);
        }

        private void btAccedi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUsername.Text))
                MessageBox.Show("Non è stato inerito un username");
            if (string.IsNullOrWhiteSpace(tbPassword.Text))
                MessageBox.Show("Non è stata inerita una password");

            int i = 0;
            while(i <= (ClsDB.Docenti.Count + ClsDB.Studenti.Count + 1))
            {
                if(i < ClsDB.Docenti.Count)
                {
                    if (tbUsername.Text == ClsDB.Docenti[i].Username)
                    {
                        ClsDocente _docente = new ClsDocente();
                        _docente = ClsDB.Docenti[i];
                        if (_docente.Password == tbPassword.Text)
                        {
                            FrmMenuProfessore frmMenuProfessore = new FrmMenuProfessore(_docente.CF);
                            frmMenuProfessore.ShowDialog();
                        }
                        else
                            MessageBox.Show("Password errata", "ERRORE PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                   
                }
                else if(i < (ClsDB.Docenti.Count + ClsDB.Studenti.Count))
                {
                    if (tbUsername.Text == ClsDB.Studenti[i - ClsDB.Docenti.Count].Username)
                    {
                        ClsStudente _studente = new ClsStudente();
                        _studente = ClsDB.Studenti[i - ClsDB.Docenti.Count];
                        if (_studente.Password == tbPassword.Text)
                        {
                            FrmMenuStudente frmMenuStudente = new FrmMenuStudente(_studente);
                            frmMenuStudente.ShowDialog();
                        }
                        else
                            MessageBox.Show("Password errata", "ERRORE PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                }
                else if(i < (ClsDB.Docenti.Count + ClsDB.Studenti.Count + 1))
                {
                    if (tbUsername.Text == ClsDB.Admin.Username)
                    {
                        ClsAdmin _admin = new ClsAdmin();
                        _admin = ClsDB.Admin;
                        if (_admin.Password == tbPassword.Text)
                        {
                            FrmMenuAdmin frmMenuAdmin = new FrmMenuAdmin(_admin);
                            frmMenuAdmin.ShowDialog();
                        }
                        else
                            MessageBox.Show("Password errata", "ERRORE PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    else if(!string.IsNullOrWhiteSpace(tbUsername.Text))
                        MessageBox.Show("Username non esistente", "ERRORE USERNAME", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                i++;
            }
        }

        private void FrmAccesso_Load(object sender, EventArgs e)
        {
            ClsDB.CaricaTuttiFile();
        }

        private void cbVediPassword_CheckedChanged(object sender, EventArgs e)
        {
            //Cambio la visibilità della password in base alla checkbox
            tbPassword.UseSystemPasswordChar = !cbVediPassword.Checked;
        }
    }
}
