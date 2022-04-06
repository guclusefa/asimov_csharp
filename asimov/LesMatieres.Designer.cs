namespace asimov
{
    partial class LesMatieres
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_supprimerMatiere = new System.Windows.Forms.Button();
            this.btn_modifierMatiere = new System.Windows.Forms.Button();
            this.dg_lesMatieres = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_lesMatieres)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Les Matières";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(860, 464);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.btn_ajouter);
            this.tabPage1.Controls.Add(this.btn_supprimerMatiere);
            this.tabPage1.Controls.Add(this.btn_modifierMatiere);
            this.tabPage1.Controls.Add(this.dg_lesMatieres);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(852, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Liste des matières";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(6, 401);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(75, 29);
            this.btn_ajouter.TabIndex = 7;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_supprimerMatiere
            // 
            this.btn_supprimerMatiere.Location = new System.Drawing.Point(168, 401);
            this.btn_supprimerMatiere.Name = "btn_supprimerMatiere";
            this.btn_supprimerMatiere.Size = new System.Drawing.Size(75, 29);
            this.btn_supprimerMatiere.TabIndex = 6;
            this.btn_supprimerMatiere.Text = "Supprimer";
            this.btn_supprimerMatiere.UseVisualStyleBackColor = true;
            // 
            // btn_modifierMatiere
            // 
            this.btn_modifierMatiere.Location = new System.Drawing.Point(87, 401);
            this.btn_modifierMatiere.Name = "btn_modifierMatiere";
            this.btn_modifierMatiere.Size = new System.Drawing.Size(75, 29);
            this.btn_modifierMatiere.TabIndex = 5;
            this.btn_modifierMatiere.Text = "Modifier";
            this.btn_modifierMatiere.UseVisualStyleBackColor = true;
            this.btn_modifierMatiere.Click += new System.EventHandler(this.btn_modifierMatiere_Click);
            // 
            // dg_lesMatieres
            // 
            this.dg_lesMatieres.AllowUserToAddRows = false;
            this.dg_lesMatieres.AllowUserToDeleteRows = false;
            this.dg_lesMatieres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_lesMatieres.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dg_lesMatieres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_lesMatieres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_lesMatieres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.libelle});
            this.dg_lesMatieres.Location = new System.Drawing.Point(6, 6);
            this.dg_lesMatieres.Name = "dg_lesMatieres";
            this.dg_lesMatieres.ReadOnly = true;
            this.dg_lesMatieres.RowTemplate.Height = 25;
            this.dg_lesMatieres.Size = new System.Drawing.Size(840, 389);
            this.dg_lesMatieres.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "#";
            this.id.MinimumWidth = 100;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // libelle
            // 
            this.libelle.HeaderText = "Libellé";
            this.libelle.MinimumWidth = 50;
            this.libelle.Name = "libelle";
            this.libelle.ReadOnly = true;
            // 
            // btn_quitter
            // 
            this.btn_quitter.Location = new System.Drawing.Point(796, 527);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(75, 29);
            this.btn_quitter.TabIndex = 4;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.UseVisualStyleBackColor = true;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // LesMatieres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LesMatieres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LesMatieres";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_lesMatieres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dg_lesMatieres;
        private Button btn_quitter;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn libelle;
        private DataGridViewTextBoxColumn action;
        private Button btn_modifierMatiere;
        private Button btn_supprimerMatiere;
        private Button btn_ajouter;
    }
}