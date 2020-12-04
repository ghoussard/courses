namespace V4
{
    partial class V4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btSaluer = new System.Windows.Forms.Button();
            this.txtSalut = new System.Windows.Forms.TextBox();
            this.lstPersonnes = new System.Windows.Forms.ListView();
            this.btAjouter = new System.Windows.Forms.Button();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.btModifier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom :";
            // 
            // txtTitre
            // 
            this.txtTitre.Location = new System.Drawing.Point(126, 44);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(100, 22);
            this.txtTitre.TabIndex = 2;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(126, 87);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(160, 22);
            this.txtNom.TabIndex = 3;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // btSaluer
            // 
            this.btSaluer.Enabled = false;
            this.btSaluer.Location = new System.Drawing.Point(457, 37);
            this.btSaluer.Name = "btSaluer";
            this.btSaluer.Size = new System.Drawing.Size(78, 36);
            this.btSaluer.TabIndex = 4;
            this.btSaluer.Text = "Saluer";
            this.btSaluer.UseVisualStyleBackColor = true;
            this.btSaluer.Click += new System.EventHandler(this.btSaluer_Click);
            // 
            // txtSalut
            // 
            this.txtSalut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalut.Location = new System.Drawing.Point(32, 327);
            this.txtSalut.Name = "txtSalut";
            this.txtSalut.Size = new System.Drawing.Size(629, 38);
            this.txtSalut.TabIndex = 5;
            // 
            // lstPersonnes
            // 
            this.lstPersonnes.GridLines = true;
            this.lstPersonnes.HideSelection = false;
            this.lstPersonnes.Location = new System.Drawing.Point(42, 154);
            this.lstPersonnes.MultiSelect = false;
            this.lstPersonnes.Name = "lstPersonnes";
            this.lstPersonnes.Size = new System.Drawing.Size(481, 130);
            this.lstPersonnes.TabIndex = 6;
            this.lstPersonnes.UseCompatibleStateImageBehavior = false;
            this.lstPersonnes.View = System.Windows.Forms.View.SmallIcon;
            this.lstPersonnes.SelectedIndexChanged += new System.EventHandler(this.lstPersonnes_SelectedIndexChanged);
            // 
            // btAjouter
            // 
            this.btAjouter.Enabled = false;
            this.btAjouter.Location = new System.Drawing.Point(457, 90);
            this.btAjouter.Name = "btAjouter";
            this.btAjouter.Size = new System.Drawing.Size(78, 34);
            this.btAjouter.TabIndex = 7;
            this.btAjouter.Text = "Ajouter";
            this.btAjouter.UseVisualStyleBackColor = true;
            this.btAjouter.Click += new System.EventHandler(this.btAjouter_Click);
            // 
            // btSupprimer
            // 
            this.btSupprimer.Enabled = false;
            this.btSupprimer.Location = new System.Drawing.Point(561, 249);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(84, 35);
            this.btSupprimer.TabIndex = 8;
            this.btSupprimer.Text = "Supprimer";
            this.btSupprimer.UseVisualStyleBackColor = true;
            this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
            // 
            // btModifier
            // 
            this.btModifier.Enabled = false;
            this.btModifier.Location = new System.Drawing.Point(561, 154);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(83, 35);
            this.btModifier.TabIndex = 9;
            this.btModifier.Text = "Modifier";
            this.btModifier.UseVisualStyleBackColor = true;
            this.btModifier.Click += new System.EventHandler(this.btModifier_Click);
            // 
            // V3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.btModifier);
            this.Controls.Add(this.btSupprimer);
            this.Controls.Add(this.btAjouter);
            this.Controls.Add(this.lstPersonnes);
            this.Controls.Add(this.txtSalut);
            this.Controls.Add(this.btSaluer);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "V3";
            this.Text = "Bonjour";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btSaluer;
        private System.Windows.Forms.TextBox txtSalut;
        private System.Windows.Forms.ListView lstPersonnes;
        private System.Windows.Forms.Button btAjouter;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.Button btModifier;
    }
}
