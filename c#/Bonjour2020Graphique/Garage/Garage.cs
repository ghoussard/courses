using System;
using System.Windows.Forms;

namespace Garage
{
    public partial class Garage : Form
    {
        public Garage()
        {
            InitializeComponent();
        }

        private void ajouterButton_Click(object sender, EventArgs e)
        {
            try
            {
                int chevaux = Int32.Parse(chevauxTextBox.Text);
                Voiture voiture = new Voiture(nomTextBox.Text, chevaux);

                ajouterVoiture(voiture);
                nettoyerInput();
            } catch(Exception error)
            {
                MessageBox.Show("Erreur champ \"chevaux\" : " + error.Message);
            }
        }

        private void ajouterVoiture(Voiture voiture)
        {
            voitureListView.Items.Add(new ListViewItemVoiture(voiture));
            modifierButton.Enabled = true;
        }

        private void nettoyerInput()
        {
            nomTextBox.Text = null;
            chevauxTextBox.Text = null;
        }

        private void modifierButton_Click(object sender, EventArgs e)
        {
            ListViewItemVoiture itemVoiture = (ListViewItemVoiture)voitureListView.SelectedItems[0];
            Voiture voiture = itemVoiture.Garé;

            EditeurVoiture editeur = new EditeurVoiture();
            editeur.Modifier(voiture);
            editeur.ShowDialog(this);

            if(editeur.DialogResult == DialogResult.OK)
            {
                itemVoiture.changerText(voiture);
            }
        }

        private void Garage_Load(object sender, EventArgs e)
        {
            modifierButton.Enabled = false;
        }
    }
}
