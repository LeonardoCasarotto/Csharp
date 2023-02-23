
namespace Es0215_Form
{
    partial class Form1
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
            this.pulizie = new System.Windows.Forms.PictureBox();
            this.bar = new System.Windows.Forms.PictureBox();
            this.squadraRossa = new System.Windows.Forms.PictureBox();
            this.squadraBlu = new System.Windows.Forms.PictureBox();
            this.blueSemaphore = new System.Windows.Forms.Label();
            this.redSemaphore = new System.Windows.Forms.Label();
            this.blueCounter = new System.Windows.Forms.Label();
            this.redCounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pulizie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.squadraRossa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.squadraBlu)).BeginInit();
            this.SuspendLayout();
            // 
            // pulizie
            // 
            this.pulizie.BackColor = System.Drawing.Color.White;
            this.pulizie.Image = global::Es0215_Form.Properties.Resources.cleaning;
            this.pulizie.Location = new System.Drawing.Point(1366, 84);
            this.pulizie.Name = "pulizie";
            this.pulizie.Size = new System.Drawing.Size(393, 659);
            this.pulizie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pulizie.TabIndex = 3;
            this.pulizie.TabStop = false;
            // 
            // bar
            // 
            this.bar.Image = global::Es0215_Form.Properties.Resources.bar;
            this.bar.Location = new System.Drawing.Point(1319, 130);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(535, 474);
            this.bar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bar.TabIndex = 2;
            this.bar.TabStop = false;
            // 
            // squadraRossa
            // 
            this.squadraRossa.Image = global::Es0215_Form.Properties.Resources.red;
            this.squadraRossa.Location = new System.Drawing.Point(90, 627);
            this.squadraRossa.Name = "squadraRossa";
            this.squadraRossa.Size = new System.Drawing.Size(426, 223);
            this.squadraRossa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.squadraRossa.TabIndex = 1;
            this.squadraRossa.TabStop = false;
            // 
            // squadraBlu
            // 
            this.squadraBlu.Image = global::Es0215_Form.Properties.Resources.blue1;
            this.squadraBlu.Location = new System.Drawing.Point(90, 52);
            this.squadraBlu.Name = "squadraBlu";
            this.squadraBlu.Size = new System.Drawing.Size(426, 223);
            this.squadraBlu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.squadraBlu.TabIndex = 0;
            this.squadraBlu.TabStop = false;
            // 
            // blueSemaphore
            // 
            this.blueSemaphore.AutoSize = true;
            this.blueSemaphore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueSemaphore.Location = new System.Drawing.Point(217, 289);
            this.blueSemaphore.Name = "blueSemaphore";
            this.blueSemaphore.Size = new System.Drawing.Size(236, 55);
            this.blueSemaphore.TabIndex = 4;
            this.blueSemaphore.Text = "ATTENDI";
            // 
            // redSemaphore
            // 
            this.redSemaphore.AutoSize = true;
            this.redSemaphore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redSemaphore.Location = new System.Drawing.Point(217, 880);
            this.redSemaphore.Name = "redSemaphore";
            this.redSemaphore.Size = new System.Drawing.Size(236, 55);
            this.redSemaphore.TabIndex = 5;
            this.redSemaphore.Text = "ATTENDI";
            // 
            // blueCounter
            // 
            this.blueCounter.AutoSize = true;
            this.blueCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueCounter.Location = new System.Drawing.Point(573, 130);
            this.blueCounter.Name = "blueCounter";
            this.blueCounter.Size = new System.Drawing.Size(52, 55);
            this.blueCounter.TabIndex = 6;
            this.blueCounter.Text = "0";
            // 
            // redCounter
            // 
            this.redCounter.AutoSize = true;
            this.redCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redCounter.Location = new System.Drawing.Point(573, 715);
            this.redCounter.Name = "redCounter";
            this.redCounter.Size = new System.Drawing.Size(52, 55);
            this.redCounter.TabIndex = 7;
            this.redCounter.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1866, 956);
            this.Controls.Add(this.redCounter);
            this.Controls.Add(this.blueCounter);
            this.Controls.Add(this.redSemaphore);
            this.Controls.Add(this.blueSemaphore);
            this.Controls.Add(this.pulizie);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.squadraRossa);
            this.Controls.Add(this.squadraBlu);
            this.Name = "Form1";
            this.Text = "BarStadio";
            ((System.ComponentModel.ISupportInitialize)(this.pulizie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.squadraRossa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.squadraBlu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox squadraBlu;
        private System.Windows.Forms.PictureBox squadraRossa;
        private System.Windows.Forms.PictureBox bar;
        private System.Windows.Forms.PictureBox pulizie;
        private System.Windows.Forms.Label blueSemaphore;
        private System.Windows.Forms.Label redSemaphore;
        private System.Windows.Forms.Label blueCounter;
        private System.Windows.Forms.Label redCounter;
    }
}

