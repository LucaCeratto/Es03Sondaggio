using ES01persone;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es03Sondaggio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[] aree = { "personale", "acquisti", "magazzino", "risorse umane" };

        clsPersona p;
        clsElencoSondaggio elenco;

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbArea.DataSource = aree;
            cmbArea.SelectedIndex = 0;

            elenco = new clsElencoSondaggio();
        }

        private void btnInserire_Click(object sender, EventArgs e)
        {
            if(chkPartTime.Checked)
            {
                p = new clsDipendenti(txtCognome.Text, txtNome.Text, txtDataNascita.Text, cmbArea.Text, chkPartTime.Checked.ToString());
            }
            else
            {
                p = new clsPersona(txtCognome.Text, txtNome.Text, txtDataNascita.Text);
            }
            MessageBox.Show(p.visualizza());
            elenco.aggiungiPersona(p);
            elenco.visualizzaLista(dgvLista);
        }

        private void chkDipendente_CheckedChanged(object sender, EventArgs e)
        {
            grbDipendente.Visible = chkDipendente.Checked;
            if(grbDipendente.Visible==true)
            {

            }
        }

        private void btnContaPartTime_Click(object sender, EventArgs e)
        {
            MessageBox.Show("")
        }

        private void btnContaDipendenti_Click(object sender, EventArgs e)
        {

        }
    }
}
