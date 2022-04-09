namespace asimov
{
    partial class FormClasse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
            this.cb_classes = new System.Windows.Forms.ComboBox();
            this.dtp_annee = new System.Windows.Forms.DateTimePicker();
            this.tb_libelle = new System.Windows.Forms.TextBox();
            this.cb_pp = new System.Windows.Forms.ComboBox();
            this.panel_matieres = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_eleves = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_ajouterEleve = new System.Windows.Forms.Button();
            this.btn_supprimerEleve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ajouter une classe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Classe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(409, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Année scolaire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(17, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Libellé";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(409, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Professeur principal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(409, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 28);
            this.label7.TabIndex = 14;
            this.label7.Text = "Les élèves";
            // 
            // btn_valider
            // 
            this.btn_valider.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_valider.Location = new System.Drawing.Point(23, 741);
            this.btn_valider.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(729, 39);
            this.btn_valider.TabIndex = 16;
            this.btn_valider.Text = "Ajouter";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // cb_classes
            // 
            this.cb_classes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_classes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_classes.FormattingEnabled = true;
            this.cb_classes.Items.AddRange(new object[] {
            ""});
            this.cb_classes.Location = new System.Drawing.Point(23, 119);
            this.cb_classes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_classes.Name = "cb_classes";
            this.cb_classes.Size = new System.Drawing.Size(337, 36);
            this.cb_classes.TabIndex = 1;
            // 
            // dtp_annee
            // 
            this.dtp_annee.CustomFormat = "yyyy";
            this.dtp_annee.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_annee.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_annee.Location = new System.Drawing.Point(415, 119);
            this.dtp_annee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_annee.Name = "dtp_annee";
            this.dtp_annee.Size = new System.Drawing.Size(337, 36);
            this.dtp_annee.TabIndex = 2;
            // 
            // tb_libelle
            // 
            this.tb_libelle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_libelle.Location = new System.Drawing.Point(23, 216);
            this.tb_libelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_libelle.Name = "tb_libelle";
            this.tb_libelle.PlaceholderText = "Libellé";
            this.tb_libelle.Size = new System.Drawing.Size(337, 36);
            this.tb_libelle.TabIndex = 3;
            // 
            // cb_pp
            // 
            this.cb_pp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_pp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_pp.FormattingEnabled = true;
            this.cb_pp.Items.AddRange(new object[] {
            ""});
            this.cb_pp.Location = new System.Drawing.Point(415, 216);
            this.cb_pp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_pp.Name = "cb_pp";
            this.cb_pp.Size = new System.Drawing.Size(337, 36);
            this.cb_pp.TabIndex = 4;
            // 
            // panel_matieres
            // 
            this.panel_matieres.AutoScroll = true;
            this.panel_matieres.Location = new System.Drawing.Point(23, 309);
            this.panel_matieres.Name = "panel_matieres";
            this.panel_matieres.Size = new System.Drawing.Size(337, 407);
            this.panel_matieres.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(17, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = "Les matières";
            // 
            // panel_eleves
            // 
            this.panel_eleves.AutoScroll = true;
            this.panel_eleves.Location = new System.Drawing.Point(415, 309);
            this.panel_eleves.Name = "panel_eleves";
            this.panel_eleves.Size = new System.Drawing.Size(337, 364);
            this.panel_eleves.TabIndex = 19;
            // 
            // btn_ajouterEleve
            // 
            this.btn_ajouterEleve.Location = new System.Drawing.Point(415, 679);
            this.btn_ajouterEleve.Name = "btn_ajouterEleve";
            this.btn_ajouterEleve.Size = new System.Drawing.Size(94, 37);
            this.btn_ajouterEleve.TabIndex = 21;
            this.btn_ajouterEleve.Text = "Ajouter";
            this.btn_ajouterEleve.UseVisualStyleBackColor = true;
            this.btn_ajouterEleve.Click += new System.EventHandler(this.btn_ajouterEleve_Click);
            // 
            // btn_supprimerEleve
            // 
            this.btn_supprimerEleve.Location = new System.Drawing.Point(515, 679);
            this.btn_supprimerEleve.Name = "btn_supprimerEleve";
            this.btn_supprimerEleve.Size = new System.Drawing.Size(94, 37);
            this.btn_supprimerEleve.TabIndex = 22;
            this.btn_supprimerEleve.Text = "Supprimer";
            this.btn_supprimerEleve.UseVisualStyleBackColor = true;
            this.btn_supprimerEleve.Click += new System.EventHandler(this.btn_supprimerEleve_Click);
            // 
            // FormClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 805);
            this.Controls.Add(this.btn_supprimerEleve);
            this.Controls.Add(this.btn_ajouterEleve);
            this.Controls.Add(this.panel_eleves);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel_matieres);
            this.Controls.Add(this.cb_pp);
            this.Controls.Add(this.tb_libelle);
            this.Controls.Add(this.dtp_annee);
            this.Controls.Add(this.cb_classes);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormClasse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter une classe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Button btn_valider;
        private ComboBox cb_classes;
        private DateTimePicker dtp_annee;
        private TextBox tb_libelle;
        private ComboBox cb_pp;
        private FlowLayoutPanel panel_matieres;
        private Label label6;
        private FlowLayoutPanel panel_eleves;
        private Button btn_ajouterEleve;
        private Button btn_supprimerEleve;
    }
}