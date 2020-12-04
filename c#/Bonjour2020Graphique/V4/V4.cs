using System;
using System.Windows.Forms;

namespace V4
{
    public partial class V4 : Form {
        public V4() {
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
            desactiveModifierSupprimer();
        }
        private void lstPersonnes_SelectedIndexChanged(object sender, EventArgs e) {
            if (lstPersonnes.SelectedItems.Count > 0)
                activeModifierSupprimer();
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
        private void desactiveModifierSupprimer() {
            btModifier.Enabled = false;
            btSupprimer.Enabled = false;
        }
        private void activeModifierSupprimer() {
            btModifier.Enabled = true;
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
                desactiveModifierSupprimer();
            foreach (ListViewItemPersonne pi in lstPersonnes.SelectedItems)
            {
                txtSalut.Text = pi.Qui.AuRevoir();
                lstPersonnes.Items.Remove(pi);
            }
        }
        private void btModifier_Click(object sender, EventArgs e) {
            ListViewItemPersonne lviPers = (ListViewItemPersonne)(lstPersonnes.SelectedItems[0]);
            /*
                        if (lviPers.Qui is VIP v) {
                            EditeurVIP edtVIP = EditeurVIP.getInstance();
                            edtVIP.Modifier(v);
                            edtVIP.ShowDialog(this);
                            if (edtVIP.DialogResult == DialogResult.OK) {
                                lviPers.MettreAJour();
                                txtSalut.Text = v.Salut();
                            }
                        } else {
                            Personne p = lviPers.Qui;
                            EditeurPersonne edtPers = EditeurPersonne.getInstance();
                            edtPers.Modifier(p);
                            edtPers.ShowDialog(this);
                            if (edtPers.DialogResult == DialogResult.OK) {
                                lviPers.MettreAJour();
                                txtSalut.Text = p.Salut();
                            }
                        }
            */
            Personne p = lviPers.Qui;
            Editeur edt = FabriqueEditeur.EditeurPour(p);
            if (edt.ShowDialog() == DialogResult.OK) {
                lviPers.MettreAJour();
                txtSalut.Text = p.Salut();
            }
        }
    }
}
