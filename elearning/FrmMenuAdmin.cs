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
    public partial class FrmMenuAdmin : Form
    {
        //Alessandro Urbani
        ClsAdmin _admin;
        public FrmMenuAdmin(ClsAdmin admin)
        {
            InitializeComponent();
            _admin = admin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDocenti _frmDocenti = new FrmDocenti();
            _frmDocenti.ShowDialog();
        }

        private void FrmMenuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmStudenti frmStudenti = new FrmStudenti();
            frmStudenti.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmClassi frmClassi = new FrmClassi();
            frmClassi.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmDiscipline frmDiscipline = new FrmDiscipline();
            frmDiscipline.ShowDialog();
        }
    }
}
