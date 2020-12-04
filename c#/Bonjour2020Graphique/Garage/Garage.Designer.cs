
namespace Garage
{
    partial class Garage
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.ajouterButton = new System.Windows.Forms.Button();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.Label();
            this.chevauxTextBox = new System.Windows.Forms.TextBox();
            this.chevaux = new System.Windows.Forms.Label();
            this.voitureListView = new System.Windows.Forms.ListView();
            this.modifierButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ajouterButton
            // 
            this.ajouterButton.Location = new System.Drawing.Point(70, 161);
            this.ajouterButton.Name = "ajouterButton";
            this.ajouterButton.Size = new System.Drawing.Size(176, 44);
            this.ajouterButton.TabIndex = 0;
            this.ajouterButton.Text = "ajouter voiture";
            this.ajouterButton.UseVisualStyleBackColor = true;
            this.ajouterButton.Click += new System.EventHandler(this.ajouterButton_Click);
            // 
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(120, 44);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(145, 22);
            this.nomTextBox.TabIndex = 1;
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Location = new System.Drawing.Point(48, 47);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(35, 17);
            this.nom.TabIndex = 2;
            this.nom.Text = "nom";
            // 
            // chevauxTextBox
            // 
            this.chevauxTextBox.Location = new System.Drawing.Point(120, 104);
            this.chevauxTextBox.Name = "chevauxTextBox";
            this.chevauxTextBox.Size = new System.Drawing.Size(145, 22);
            this.chevauxTextBox.TabIndex = 3;
            // 
            // chevaux
            // 
            this.chevaux.AutoSize = true;
            this.chevaux.Location = new System.Drawing.Point(48, 107);
            this.chevaux.Name = "chevaux";
            this.chevaux.Size = new System.Drawing.Size(60, 17);
            this.chevaux.TabIndex = 4;
            this.chevaux.Text = "chevaux";
            // 
            // voitureListView
            // 
            this.voitureListView.HideSelection = false;
            this.voitureListView.Location = new System.Drawing.Point(444, 44);
            this.voitureListView.Name = "voitureListView";
            this.voitureListView.Size = new System.Drawing.Size(316, 161);
            this.voitureListView.TabIndex = 5;
            this.voitureListView.UseCompatibleStateImageBehavior = false;
            // 
            // modifierButton
            // 
            this.modifierButton.Location = new System.Drawing.Point(444, 229);
            this.modifierButton.Name = "modifierButton";
            this.modifierButton.Size = new System.Drawing.Size(110, 35);
            this.modifierButton.TabIndex = 6;
            this.modifierButton.Text = "modifier";
            this.modifierButton.UseVisualStyleBackColor = true;
            this.modifierButton.Click += new System.EventHandler(this.modifierButton_Click);
            // 
            // Garage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modifierButton);
            this.Controls.Add(this.voitureListView);
            this.Controls.Add(this.chevaux);
            this.Controls.Add(this.chevauxTextBox);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(this.ajouterButton);
            this.Name = "Garage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Garage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ajouterButton;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.TextBox chevauxTextBox;
        private System.Windows.Forms.Label chevaux;
        private System.Windows.Forms.ListView voitureListView;
        private System.Windows.Forms.Button modifierButton;
    }
}

