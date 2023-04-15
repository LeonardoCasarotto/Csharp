using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anselmo.Classes
{
    public class HeapDrawer
    {
        private Panel panel;
        private PictureBox pictureBox;
        private Bitmap bitmap;

        public HeapDrawer(Panel panel, PictureBox pictureBox)
        {
            this.panel = panel;
            this.pictureBox = pictureBox;

            // Set the AutoScroll property of the Panel to True
            panel.AutoScroll = true;

            // Set the SizeMode property of the PictureBox to AutoSize
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;

            // Add the PictureBox to the Panel
            panel.Controls.Add(pictureBox);
        }

        public void DrawHeap(int[] heap)
        {
            // Create a Bitmap with the desired size for the heap diagram
            bitmap = new Bitmap(500, 500);

            // Use the Graphics class to draw the heap onto the Bitmap
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                // Draw the heap here
                // For example:
                graphics.FillEllipse(Brushes.Red, 200, 50, 100, 100);
            }

            // Assign the Bitmap to the Image property of the PictureBox
            pictureBox.Image = bitmap;
        }
    }
}
