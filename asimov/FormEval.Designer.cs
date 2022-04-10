namespace asimov
{
    partial class FormEval
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
            this.btn_valider = new System.Windows.Forms.Button();
            this.cb_classes = new System.Windows.Forms.ComboBox();
            this.tb_desc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_trimestre = new System.Windows.Forms.ComboBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.cb_matieres = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_notes = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ajouter une évaluation";
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
            this.label3.Size = new System.Drawing.Size(79, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Matière";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(17, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Déscription";
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
            this.cb_classes.SelectionChangeCommitted += new System.EventHandler(this.cb_classes_SelectedIndexChanged);
            // 
            // tb_desc
            // 
            this.tb_desc.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_desc.Location = new System.Drawing.Point(23, 216);
            this.tb_desc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.PlaceholderText = "Déscription";
            this.tb_desc.Size = new System.Drawing.Size(729, 36);
            this.tb_desc.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(17, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 28);
            this.label8.TabIndex = 24;
            this.label8.Text = "Trimestre";
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
            // cb_trimestre
            // 
            this.cb_trimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_trimestre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_trimestre.FormattingEnabled = true;
            this.cb_trimestre.Items.AddRange(new object[] {
            ""});
            this.cb_trimestre.Location = new System.Drawing.Point(23, 309);
            this.cb_trimestre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_trimestre.Name = "cb_trimestre";
            this.cb_trimestre.Size = new System.Drawing.Size(337, 36);
            this.cb_trimestre.TabIndex = 4;
            // 
            // dtp_date
            // 
            this.dtp_date.CustomFormat = "";
            this.dtp_date.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(415, 309);
            this.dtp_date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(337, 36);
            this.dtp_date.TabIndex = 5;
            // 
            // cb_matieres
            // 
            this.cb_matieres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_matieres.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_matieres.FormattingEnabled = true;
            this.cb_matieres.Items.AddRange(new object[] {
            ""});
            this.cb_matieres.Location = new System.Drawing.Point(415, 119);
            this.cb_matieres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_matieres.Name = "cb_matieres";
            this.cb_matieres.Size = new System.Drawing.Size(337, 36);
            this.cb_matieres.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(17, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 28);
            this.label6.TabIndex = 26;
            // 
            // panel_notes
            // 
            this.panel_notes.AutoScroll = true;
            this.panel_notes.Location = new System.Drawing.Point(23, 405);
            this.panel_notes.Name = "panel_notes";
            this.panel_notes.Size = new System.Drawing.Size(729, 304);
            this.panel_notes.TabIndex = 10;
            // 
            // FormEval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 805);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel_notes);
            this.Controls.Add(this.cb_matieres);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.cb_trimestre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_desc);
            this.Controls.Add(this.cb_classes);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormEval";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter une évaluation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_valider;
        private ComboBox cb_classes;
        private TextBox tb_desc;
        private Label label8;
        private Label label7;
        private ComboBox cb_trimestre;
        private DateTimePicker dtp_date;
        private ComboBox cb_matieres;
        private Label label6;
        private FlowLayoutPanel panel_notes;
    }
}