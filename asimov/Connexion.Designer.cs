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
            this.button1 = new System.Windows.Forms.Button();
            this.tb_identification = new System.Windows.Forms.TextBox();
            this.label_title = new System.Windows.Forms.Label();
            this.tb_motdepasse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(45, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Connexion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_identification
            // 
            this.tb_identification.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_identification.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_identification.Location = new System.Drawing.Point(45, 111);
            this.tb_identification.Name = "tb_identification";
            this.tb_identification.PlaceholderText = "N° d\'identification";
            this.tb_identification.Size = new System.Drawing.Size(243, 32);
            this.tb_identification.TabIndex = 1;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(36, 46);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(180, 46);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Connexion";
            // 
            // tb_motdepasse
            // 
            this.tb_motdepasse.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_motdepasse.Location = new System.Drawing.Point(45, 178);
            this.tb_motdepasse.Name = "tb_motdepasse";
            this.tb_motdepasse.PlaceholderText = "Mot de passe";
            this.tb_motdepasse.Size = new System.Drawing.Size(243, 32);
            this.tb_motdepasse.TabIndex = 2;
            this.tb_motdepasse.UseSystemPasswordChar = true;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 353);
            this.Controls.Add(this.tb_motdepasse);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.tb_identification);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox tb_identification;
        private Label label_title;
        private TextBox tb_motdepasse;
    }
}