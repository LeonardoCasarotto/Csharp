
namespace CasarottoVideogiochi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIns));
            this.cbUnit = new Krypton.Toolkit.KryptonComboBox();
            this.btnIns = new Krypton.Toolkit.KryptonButton();
            this.txTime = new Krypton.Toolkit.KryptonTextBox();
            this.txPrice = new Krypton.Toolkit.KryptonTextBox();
            this.txTitle = new Krypton.Toolkit.KryptonTextBox();
            this.releaseDtp = new Krypton.Toolkit.KryptonDateTimePicker();
            this.btnBack = new Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cbUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // cbUnit
            // 
            this.cbUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnit.DropDownWidth = 115;
            this.cbUnit.IntegralHeight = false;
            this.cbUnit.Items.AddRange(new object[] {
            "Seleziona",
            "Ore",
            "Minuti"});
            this.cbUnit.Location = new System.Drawing.Point(360, 227);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(147, 27);
            this.cbUnit.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbUnit.StateCommon.ComboBox.Border.Rounding = 7F;
            this.cbUnit.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbUnit.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbUnit.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbUnit.TabIndex = 22;
            // 
            // btnIns
            // 
            this.btnIns.Location = new System.Drawing.Point(439, 283);
            this.btnIns.Name = "btnIns";
            this.btnIns.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnIns.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(216)))));
            this.btnIns.Size = new System.Drawing.Size(133, 25);
            this.btnIns.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnIns.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(216)))));
            this.btnIns.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnIns.StateCommon.Border.Rounding = 7F;
            this.btnIns.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnIns.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnIns.TabIndex = 21;
            this.btnIns.Values.Text = "Inserisci";
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // txTime
            // 
            this.txTime.Location = new System.Drawing.Point(127, 225);
            this.txTime.Name = "txTime";
            this.txTime.Size = new System.Drawing.Size(174, 29);
            this.txTime.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txTime.StateCommon.Border.Rounding = 7F;
            this.txTime.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txTime.TabIndex = 20;
            // 
            // txPrice
            // 
            this.txPrice.Location = new System.Drawing.Point(127, 172);
            this.txPrice.Name = "txPrice";
            this.txPrice.Size = new System.Drawing.Size(174, 29);
            this.txPrice.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txPrice.StateCommon.Border.Rounding = 7F;
            this.txPrice.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txPrice.TabIndex = 19;
            // 
            // txTitle
            // 
            this.txTitle.Location = new System.Drawing.Point(127, 68);
            this.txTitle.Name = "txTitle";
            this.txTitle.Size = new System.Drawing.Size(174, 27);
            this.txTitle.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txTitle.StateCommon.Border.Rounding = 7F;
            this.txTitle.TabIndex = 14;
            // 
            // releaseDtp
            // 
            this.releaseDtp.Location = new System.Drawing.Point(127, 120);
            this.releaseDtp.MaxDate = new System.DateTime(2060, 12, 31, 0, 0, 0, 0);
            this.releaseDtp.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.releaseDtp.Name = "releaseDtp";
            this.releaseDtp.Size = new System.Drawing.Size(174, 27);
            this.releaseDtp.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.releaseDtp.StateCommon.Border.Rounding = 7F;
            this.releaseDtp.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseDtp.TabIndex = 13;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 283);
            this.btnBack.Name = "btnBack";
            this.btnBack.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnBack.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(226)))));
            this.btnBack.Size = new System.Drawing.Size(133, 25);
            this.btnBack.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnBack.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(226)))));
            this.btnBack.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBack.StateCommon.Border.Rounding = 7F;
            this.btnBack.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnBack.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.TabIndex = 23;
            this.btnBack.Values.Text = "Indietro";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Titolo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Data di rilascio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Prezzo in euro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "Tempo di gioco";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(307, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 21);
            this.label5.TabIndex = 29;
            this.label5.Text = "Unità";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(4, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(308, 40);
            this.label6.TabIndex = 30;
            this.label6.Text = "Inserisci nuovo gioco";
            // 
            // FormIns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 322);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbUnit);
            this.Controls.Add(this.btnIns);
            this.Controls.Add(this.txTime);
            this.Controls.Add(this.txPrice);
            this.Controls.Add(this.txTitle);
            this.Controls.Add(this.releaseDtp);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormIns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inserisci Nuovo Videogioco";
            ((System.ComponentModel.ISupportInitialize)(this.cbUnit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonComboBox cbUnit;
        private Krypton.Toolkit.KryptonButton btnIns;
        private Krypton.Toolkit.KryptonTextBox txTime;
        private Krypton.Toolkit.KryptonTextBox txPrice;
        private Krypton.Toolkit.KryptonTextBox txTitle;
        private Krypton.Toolkit.KryptonDateTimePicker releaseDtp;
        private Krypton.Toolkit.KryptonButton btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}