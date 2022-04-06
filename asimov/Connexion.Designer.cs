namespace asimov
{
    partial class Connexion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_connexion = new System.Windows.Forms.Button();
            this.tb_identification = new System.Windows.Forms.TextBox();
            this.label_title = new System.Windows.Forms.Label();
            this.tb_motdepasse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_connexion
            // 
            this.btn_connexion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_connexion.Location = new System.Drawing.Point(39, 182);
            this.btn_connexion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_connexion.Name = "btn_connexion";
            this.btn_connexion.Size = new System.Drawing.Size(213, 24);
            this.btn_connexion.TabIndex = 3;
            this.btn_connexion.Text = "Connexion";
            this.btn_connexion.UseVisualStyleBackColor = true;
            this.btn_connexion.Click += new System.EventHandler(this.btn_connexion_Click);
            // 
            // tb_identification
            // 
            this.tb_identification.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_identification.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_identification.Location = new System.Drawing.Point(39, 83);
            this.tb_identification.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_identification.Name = "tb_identification";
            this.tb_identification.PlaceholderText = "N° d\'identification";
            this.tb_identification.Size = new System.Drawing.Size(213, 27);
            this.tb_identification.TabIndex = 1;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(32, 34);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(144, 37);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Connexion";
            // 
            // tb_motdepasse
            // 
            this.tb_motdepasse.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_motdepasse.Location = new System.Drawing.Point(39, 134);
            this.tb_motdepasse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_motdepasse.Name = "tb_motdepasse";
            this.tb_motdepasse.PlaceholderText = "Mot de passe";
            this.tb_motdepasse.Size = new System.Drawing.Size(213, 27);
            this.tb_motdepasse.TabIndex = 2;
            this.tb_motdepasse.UseSystemPasswordChar = true;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 265);
            this.Controls.Add(this.tb_motdepasse);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.tb_identification);
            this.Controls.Add(this.btn_connexion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_connexion;
        private TextBox tb_identification;
        private Label label_title;
        private TextBox tb_motdepasse;
    }
}