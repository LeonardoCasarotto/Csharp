
namespace CasarottoVideogiochi
{
    partial class Form2
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
            this.cbUnit = new Krypton.Toolkit.KryptonComboBox();
            this.btnIns = new Krypton.Toolkit.KryptonButton();
            this.txTime = new Krypton.Toolkit.KryptonTextBox();
            this.txPrice = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.txTitle = new Krypton.Toolkit.KryptonTextBox();
            this.releaseDtp = new Krypton.Toolkit.KryptonDateTimePicker();
            this.btnBack = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // cbUnit
            // 
            this.cbUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbUnit.DropDownWidth = 115;
            this.cbUnit.IntegralHeight = false;
            this.cbUnit.Items.AddRange(new object[] {
            "Seleziona",
            "Ore",
            "Minuti"});
            this.cbUnit.Location = new System.Drawing.Point(331, 231);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(115, 21);
            this.cbUnit.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbUnit.TabIndex = 22;
            // 
            // btnIns
            // 
            this.btnIns.Location = new System.Drawing.Point(439, 283);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(133, 25);
            this.btnIns.TabIndex = 21;
            this.btnIns.Values.Text = "Inserisci";
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // txTime
            // 
            this.txTime.Location = new System.Drawing.Point(161, 231);
            this.txTime.Name = "txTime";
            this.txTime.Size = new System.Drawing.Size(147, 23);
            this.txTime.TabIndex = 20;
            this.txTime.Text = "kryptonTextBox3";
            // 
            // txPrice
            // 
            this.txPrice.Location = new System.Drawing.Point(161, 178);
            this.txPrice.Name = "txPrice";
            this.txPrice.Size = new System.Drawing.Size(147, 23);
            this.txPrice.TabIndex = 19;
            this.txPrice.Text = "kryptonTextBox2";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(12, 234);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(96, 20);
            this.kryptonLabel5.TabIndex = 18;
            this.kryptonLabel5.Values.Text = "Tempo di gioco";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(12, 68);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(42, 20);
            this.kryptonLabel4.TabIndex = 17;
            this.kryptonLabel4.Values.Text = "Titolo";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(12, 178);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(88, 20);
            this.kryptonLabel3.TabIndex = 16;
            this.kryptonLabel3.Values.Text = "Prezzo in euro";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 121);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(91, 20);
            this.kryptonLabel2.TabIndex = 15;
            this.kryptonLabel2.Values.Text = "Data di rilascio";
            // 
            // txTitle
            // 
            this.txTitle.Location = new System.Drawing.Point(161, 68);
            this.txTitle.Name = "txTitle";
            this.txTitle.Size = new System.Drawing.Size(147, 23);
            this.txTitle.TabIndex = 14;
            // 
            // releaseDtp
            // 
            this.releaseDtp.Location = new System.Drawing.Point(161, 120);
            this.releaseDtp.Name = "releaseDtp";
            this.releaseDtp.Size = new System.Drawing.Size(147, 21);
            this.releaseDtp.TabIndex = 13;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 283);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 25);
            this.btnBack.TabIndex = 23;
            this.btnBack.Values.Text = "Indietro";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 376);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbUnit);
            this.Controls.Add(this.btnIns);
            this.Controls.Add(this.txTime);
            this.Controls.Add(this.txPrice);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.txTitle);
            this.Controls.Add(this.releaseDtp);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.cbUnit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonComboBox cbUnit;
        private Krypton.Toolkit.KryptonButton btnIns;
        private Krypton.Toolkit.KryptonTextBox txTime;
        private Krypton.Toolkit.KryptonTextBox txPrice;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox txTitle;
        private Krypton.Toolkit.KryptonDateTimePicker releaseDtp;
        private Krypton.Toolkit.KryptonButton btnBack;
    }
}