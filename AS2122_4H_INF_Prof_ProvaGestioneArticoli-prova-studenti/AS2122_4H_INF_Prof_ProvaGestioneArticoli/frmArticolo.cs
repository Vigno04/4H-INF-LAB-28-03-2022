using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2122_4H_INF_Prof_ProvaGestioneArticoli
{
    public partial class frmArticolo : Form
    {
        DialogResult status = DialogResult.Cancel;

        // TODO: (5) aggiungere attributi privati dei dati inseriti nella frmArticoli
        // ...
        private string descrizione;
        private string unitaMisura;
        private double prezzo; 

        public DialogResult Status { get { return status; } }

        // TODO: (6) aggiungere property di sola lettura dei dati inseriti nella frmArticoli per l'utilizzo in frmMain
        // ...
        public string Descrizione { get { return descrizione; } }
        public string UnitaMisura { get { return unitaMisura; } }
        public double Prezzo { get { return prezzo; } }

        public frmArticolo()
        {
            InitializeComponent();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            // TODO: (7) passaggio all' attributo/property dei dati inseriti nella frmArticoli con controllo di valorizzazione del dato
            // ... descrizione, unitaMisura, prezzo
            bool Completed = true;
            if (txtDescrizione.Text != null) descrizione = txtDescrizione.Text; else { MessageBox.Show("inserire una descrizione"); Completed = false; }
            if (cmbUnitaMisura.Text != null) unitaMisura = cmbUnitaMisura.Text; else { MessageBox.Show("inserire unita di misura"); Completed = false; }
            if (txtPrezzo.Text != null) prezzo = int.Parse(txtPrezzo.Text); else { MessageBox.Show("inserire il presso"); Completed = false; }
            if (Completed==true)
            {
                status = DialogResult.OK;
                Close();
            }           
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            status = DialogResult.Cancel;
            Close();
        }
    }
}
