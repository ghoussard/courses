using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V2
{
    public partial class V2 : Form {
        public V2() {
            InitializeComponent();
        }
        private void btSaluer_Click(object sender, EventArgs e) {
            string salut = "";
            String titre = txtTitre.Text.Trim();
            String nom = txtNom.Text.Trim();
            if (titre != "")
                salut += "Bien le bonjour " + titre + " ";
            else
                salut += "Bonjour ";
            salut += nom;
            salut += " !";
            txtSalut.Text = salut;
            txtTitre.Text = "";
            txtNom.Text = "";
            desactiveSaluerAjouter();
        }
        private void btAjouter_Click(object sender, EventArgs e) {
            Personne p;
            String titre = txtTitre.Text.Trim();
            String nom = txtNom.Text.Trim();
            if (titre != "")
                p = new VIP(titre, nom);
            else
                p = new Personne(nom);
            lstPersonnes.Items.Add(new ListViewItemPersonne(p));
            txtTitre.Text = "";
            txtNom.Text = "";
            txtSalut.Text = "";
            desactiveSaluerAjouter();
            desactiveSupprimer();
        }
        private void lstPersonnes_SelectedIndexChanged(object sender, EventArgs e) {
            if (lstPersonnes.SelectedItems.Count > 0)
                activeSupprimer();
            foreach (ListViewItemPersonne pi in lstPersonnes.SelectedItems)
                txtSalut.Text = pi.Qui.Salut();
        }
        private void desactiveSaluerAjouter() {
            btSaluer.Enabled = false;
            btAjouter.Enabled = false;
        }
        private void activeSaluerAjouter() {
            btSaluer.Enabled = true;
            btAjouter.Enabled = true;
        }
        private void desactiveSupprimer()  {
            btSupprimer.Enabled = false;
        }
        private void activeSupprimer() {
            btSupprimer.Enabled = true;
        }
        private void txtNom_TextChanged(object sender, EventArgs e) {
            if (txtNom.Text.Trim() == "")
                desactiveSaluerAjouter();
            else
                activeSaluerAjouter();
        }
        private void btSupprimer_Click(object sender, EventArgs e) {
            if (lstPersonnes.SelectedItems.Count > 0)
                desactiveSupprimer();
            foreach (ListViewItemPersonne pi in lstPersonnes.SelectedItems) {
                txtSalut.Text = pi.Qui.AuRevoir();
                lstPersonnes.Items.Remove(pi);
            }
        }
    }
}
