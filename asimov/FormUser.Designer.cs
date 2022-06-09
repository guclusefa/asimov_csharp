namespace asimov
{
    partial class FormUser
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
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_tel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.cb_sexe = new System.Windows.Forms.ComboBox();
            this.cb_resp1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_resp2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ajouter un user";
            // 
            // tb_nom
            // 
            this.tb_nom.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_nom.Location = new System.Drawing.Point(23, 121);
            this.tb_nom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.PlaceholderText = "NOM";
            this.tb_nom.Size = new System.Drawing.Size(337, 36);
            this.tb_nom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "NOM";
            // 
            // tb_prenom
            // 
            this.tb_prenom.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_prenom.Location = new System.Drawing.Point(415, 121);
            this.tb_prenom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.PlaceholderText = "Prenom";
            this.tb_prenom.Size = new System.Drawing.Size(337, 36);
            this.tb_prenom.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(409, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(17, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sexe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(409, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date de naissance";
            // 
            // tb_mail
            // 
            this.tb_mail.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_mail.Location = new System.Drawing.Point(23, 309);
            this.tb_mail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.PlaceholderText = "Email";
            this.tb_mail.Size = new System.Drawing.Size(337, 36);
            this.tb_mail.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(17, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "Email";
            // 
            // tb_tel
            // 
            this.tb_tel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_tel.Location = new System.Drawing.Point(415, 309);
            this.tb_tel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.PlaceholderText = "Numéro de téléphone";
            this.tb_tel.Size = new System.Drawing.Size(337, 36);
            this.tb_tel.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(409, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 28);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tél";
            // 
            // btn_valider
            // 
            this.btn_valider.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_valider.Location = new System.Drawing.Point(23, 596);
            this.btn_valider.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(729, 39);
            this.btn_valider.TabIndex = 16;
            this.btn_valider.Text = "Ajouter";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // dtp_date
            // 
            this.dtp_date.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(415, 216);
            this.dtp_date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(337, 36);
            this.dtp_date.TabIndex = 4;
            // 
            // cb_sexe
            // 
            this.cb_sexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sexe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_sexe.FormattingEnabled = true;
            this.cb_sexe.Items.AddRange(new object[] {
            ""});
            this.cb_sexe.Location = new System.Drawing.Point(23, 219);
            this.cb_sexe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_sexe.Name = "cb_sexe";
            this.cb_sexe.Size = new System.Drawing.Size(337, 36);
            this.cb_sexe.Sorted = true;
            this.cb_sexe.TabIndex = 3;
            // 
            // cb_resp1
            // 
            this.cb_resp1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_resp1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_resp1.FormattingEnabled = true;
            this.cb_resp1.Items.AddRange(new object[] {
            ""});
            this.cb_resp1.Location = new System.Drawing.Point(23, 415);
            this.cb_resp1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_resp1.Name = "cb_resp1";
            this.cb_resp1.Size = new System.Drawing.Size(729, 36);
            this.cb_resp1.Sorted = true;
            this.cb_resp1.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(17, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 28);
            this.label8.TabIndex = 18;
            this.label8.Text = "Responsable 1";
            // 
            // cb_resp2
            // 
            this.cb_resp2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_resp2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_resp2.FormattingEnabled = true;
            this.cb_resp2.Items.AddRange(new object[] {
            ""});
            this.cb_resp2.Location = new System.Drawing.Point(23, 509);
            this.cb_resp2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_resp2.Name = "cb_resp2";
            this.cb_resp2.Size = new System.Drawing.Size(729, 36);
            this.cb_resp2.Sorted = true;
            this.cb_resp2.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(17, 474);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 28);
            this.label9.TabIndex = 20;
            this.label9.Text = "Resaponsable 2";
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 706);
            this.Controls.Add(this.cb_resp2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_resp1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_sexe);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.tb_tel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_mail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_prenom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter un user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tb_nom;
        private Label label2;
        private TextBox tb_prenom;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tb_mail;
        private Label label6;
        private TextBox tb_tel;
        private Label label7;
        private Button btn_valider;
        private DateTimePicker dtp_date;
        private ComboBox cb_sexe;
        private ComboBox cb_resp1;
        private Label label8;
        private ComboBox cb_resp2;
        private Label label9;
    }
}