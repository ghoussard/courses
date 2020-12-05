namespace exempleBdD
{
    partial class FenetreRepertoire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenetreRepertoire));
            this.lstIdentite = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPren = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btAjouter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.modifierButton = new System.Windows.Forms.Button();
            this.supprimerButton = new System.Windows.Forms.Button();
            this.actionsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstIdentite
            // 
            this.lstIdentite.FormattingEnabled = true;
            resources.ApplyResources(this.lstIdentite, "lstIdentite");
            this.lstIdentite.Name = "lstIdentite";
            this.lstIdentite.SelectedIndexChanged += new System.EventHandler(this.lstIdentite_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtNom
            // 
            resources.ApplyResources(this.txtNom, "txtNom");
            this.txtNom.Name = "txtNom";
            // 
            // txtPren
            // 
            resources.ApplyResources(this.txtPren, "txtPren");
            this.txtPren.Name = "txtPren";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtTel
            // 
            resources.ApplyResources(this.txtTel, "txtTel");
            this.txtTel.Name = "txtTel";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // btAjouter
            // 
            resources.ApplyResources(this.btAjouter, "btAjouter");
            this.btAjouter.Name = "btAjouter";
            this.btAjouter.UseVisualStyleBackColor = true;
            this.btAjouter.Click += new System.EventHandler(this.btAjouter_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // modifierButton
            // 
            resources.ApplyResources(this.modifierButton, "modifierButton");
            this.modifierButton.Name = "modifierButton";
            this.modifierButton.UseVisualStyleBackColor = true;
            this.modifierButton.Click += new System.EventHandler(this.modifierButton_Click);
            // 
            // supprimerButton
            // 
            resources.ApplyResources(this.supprimerButton, "supprimerButton");
            this.supprimerButton.Name = "supprimerButton";
            this.supprimerButton.UseVisualStyleBackColor = true;
            this.supprimerButton.Click += new System.EventHandler(this.supprimerButton_Click);
            // 
            // actionsLabel
            // 
            resources.ApplyResources(this.actionsLabel, "actionsLabel");
            this.actionsLabel.Name = "actionsLabel";
            // 
            // FenetreRepertoire
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.actionsLabel);
            this.Controls.Add(this.supprimerButton);
            this.Controls.Add(this.modifierButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btAjouter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPren);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstIdentite);
            this.Name = "FenetreRepertoire";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstIdentite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPren;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btAjouter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button modifierButton;
        private System.Windows.Forms.Button supprimerButton;
        private System.Windows.Forms.Label actionsLabel;
    }
}

