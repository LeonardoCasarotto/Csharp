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

        public void Draw()
        {
            // Create a Bitmap with the desired size for the heap diagram
            bitmap = new Bitmap(500, 500);

            // Use the Graphics class to draw the heap onto the Bitmap
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                // Draw the heap here
                // For example:
                graphics.FillEllipse(Brushes.Red, 50, 50, 50, 50);
            }

            // Assign the Bitmap to the Image property of the PictureBox
            pictureBox.Image = bitmap;
        }




        public void DrawHeap()
        {



            // Create a Bitmap with the desired size for the heap diagram
            bitmap = new Bitmap(500, 500);

            // Use the Graphics class to draw the heap onto the Bitmap
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                // Draw the heap here
              

                int leafsize = 50;
                int x = 100;
                int y = 50;

                for (int i = 0; i < 4; i++)
                {
                    graphics.FillEllipse(Brushes.Red, x + i * leafsize, y, leafsize, leafsize);
                }

            }

            // Assign the Bitmap to the Image property of the PictureBox
            pictureBox.Image = bitmap;
        }




        public void DrawHeap(int[] heap, int x, int y, int leafSize)
        {
            bitmap = new Bitmap(500, 500);


            
            int leafSpacing = 10;
            int levels = (int)Math.Log(heap.Length, 2) + 1;
            int maxNodesInLevel = (int)Math.Pow(2, levels - 1);
            int totalWidth = maxNodesInLevel * (leafSize + leafSpacing);
            

            for (int i = 0; i < heap.Length; i++)
            {
                int level = (int)Math.Log(i + 1, 2);
                int nodesInLevel = (int)Math.Pow(2, level);
                int nodeIndexInLevel = i - nodesInLevel + 1;
                int nodeX = x + totalWidth / 2 - nodesInLevel * leafSize / 2 - (nodesInLevel - 1) * leafSpacing / 2 + nodeIndexInLevel * (leafSize + leafSpacing);
                int nodeY = y + level * (leafSize + leafSpacing);

                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.FillEllipse(Brushes.Red, nodeX, nodeY, leafSize, leafSize);
                    graphics.DrawString(heap[i].ToString(), new Font("Arial",11), Brushes.White, nodeX+leafSize/4, nodeY+leafSize/4);
                }
            }
            pictureBox.Image = bitmap;
        }












    }
}
    
