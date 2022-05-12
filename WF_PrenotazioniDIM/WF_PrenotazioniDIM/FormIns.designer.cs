namespace WF_PrenotazioniDIM
{
    partial class FormIns
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
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxCognome = new System.Windows.Forms.TextBox();
            this.LabelCognome = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelData = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxEsami = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(25, 31);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(62, 24);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(122, 28);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(342, 29);
            this.textBoxNome.TabIndex = 1;
            // 
            // textBoxCognome
            // 
            this.textBoxCognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCognome.Location = new System.Drawing.Point(122, 69);
            this.textBoxCognome.Name = "textBoxCognome";
            this.textBoxCognome.Size = new System.Drawing.Size(342, 29);
            this.textBoxCognome.TabIndex = 3;
            // 
            // LabelCognome
            // 
            this.LabelCognome.AutoSize = true;
            this.LabelCognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCognome.Location = new System.Drawing.Point(25, 73);
            this.LabelCognome.Name = "LabelCognome";
            this.LabelCognome.Size = new System.Drawing.Size(94, 24);
            this.LabelCognome.TabIndex = 2;
            this.LabelCognome.Text = "Cognome";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(122, 154);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(342, 29);
            this.dateTimePicker.TabIndex = 4;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(25, 157);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(47, 24);
            this.labelData.TabIndex = 5;
            this.labelData.Text = "Data";
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Location = new System.Drawing.Point(198, 226);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(144, 42);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.comboBoxEsami);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelData);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Controls.Add(this.textBoxCognome);
            this.panel1.Controls.Add(this.LabelCognome);
            this.panel1.Controls.Add(this.textBoxNome);
            this.panel1.Controls.Add(this.labelNome);
            this.panel1.Location = new System.Drawing.Point(25, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 202);
            this.panel1.TabIndex = 7;
            // 
            // comboBoxEsami
            // 
            this.comboBoxEsami.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEsami.FormattingEnabled = true;
            this.comboBoxEsami.Location = new System.Drawing.Point(122, 110);
            this.comboBoxEsami.Name = "comboBoxEsami";
            this.comboBoxEsami.Size = new System.Drawing.Size(342, 32);
            this.comboBoxEsami.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Esame";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormIns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 271);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonOK);
            this.Name = "FormIns";
            this.Text = "Inserimento Prenotazione";
            this.Load += new System.EventHandler(this.FormIns_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxCognome;
        private System.Windows.Forms.Label LabelCognome;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ComboBox comboBoxEsami;
    }
}