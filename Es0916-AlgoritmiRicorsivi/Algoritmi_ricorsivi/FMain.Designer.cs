
namespace Algoritmi_ricorsivi
{
    partial class FMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_risultato = new System.Windows.Forms.Label();
            this.selezione = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_risultato
            // 
            this.label_risultato.AutoSize = true;
            this.label_risultato.BackColor = System.Drawing.Color.Yellow;
            this.label_risultato.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_risultato.Location = new System.Drawing.Point(384, 85);
            this.label_risultato.Name = "label_risultato";
            this.label_risultato.Size = new System.Drawing.Size(110, 31);
            this.label_risultato.TabIndex = 2;
            this.label_risultato.Text = "risultato";
            this.label_risultato.Visible = false;
            // 
            // selezione
            // 
            this.selezione.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selezione.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selezione.FormattingEnabled = true;
            this.selezione.IntegralHeight = false;
            this.selezione.Items.AddRange(new object[] {
            "calcola 2^n",
            "fattoriale",
            "somma"});
            this.selezione.Location = new System.Drawing.Point(58, 88);
            this.selezione.Name = "selezione";
            this.selezione.Size = new System.Drawing.Size(298, 28);
            this.selezione.TabIndex = 4;
            this.selezione.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selezionare l\'operazione";
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 440);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selezione);
            this.Controls.Add(this.label_risultato);
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMain";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_risultato;
        private System.Windows.Forms.ComboBox selezione;
        private System.Windows.Forms.Label label1;
    }
}

