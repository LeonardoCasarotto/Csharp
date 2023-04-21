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
            panel.AutoScroll = true;
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            panel.Controls.Add(pictureBox);
        }





        public void DrawHeap(int[] heap, int x, int y, int leafSize)
        {
            bitmap = new Bitmap(500, 1500);

            int leafSpacing = 10;
            int levels = (int)Math.Log(heap.Length, 2) + 1;
            int maxNodesInLevel = (int)Math.Pow(2, levels - 1);
            int totalWidth = maxNodesInLevel * (leafSize + leafSpacing);

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                for (int i = 0; i < heap.Length; i++)
                {
                    int level = (int)Math.Log(i + 1, 2);
                    int nodesInLevel = (int)Math.Pow(2, level);
                    int nodeIndexInLevel = i - nodesInLevel + 1;
                    int nodeX = x + totalWidth / 2 - nodesInLevel * leafSize / 2 - (nodesInLevel - 1) * leafSpacing / 2 + nodeIndexInLevel * (leafSize + leafSpacing);
                    int nodeY = y + level * (leafSize + leafSpacing);

                    graphics.FillEllipse(Brushes.Red, nodeX, nodeY, leafSize, leafSize);

                    int lenx = 1;
                    int leny = 1;
                    switch (heap[i].ToString().Length)
                    {
                        case 1:
                            lenx = 3;
                            leny = 4;
                            break;
                        case 2:
                            lenx = 4;
                            leny = 4;
                            break;
                        case 3:
                            lenx = 9;
                            leny = 5;
                            break;
                    }
                    graphics.DrawString(heap[i].ToString(), new Font("Arial", 11), Brushes.White, nodeX + leafSize / lenx, nodeY + leafSize / leny);

                    // Draw branches
                    if (i > 0)
                    {
                        int parentIndex = (i - 1) / 2;
                        int parentLevel = (int)Math.Log(parentIndex + 1, 2);
                        int parentNodesInLevel = (int)Math.Pow(2, parentLevel);
                        int parentNodeIndexInLevel = parentIndex - parentNodesInLevel + 1;
                        int parentNodeX = x + totalWidth / 2 - parentNodesInLevel * leafSize / 2 - (parentNodesInLevel - 1) * leafSpacing / 2 + parentNodeIndexInLevel * (leafSize + leafSpacing);
                        int parentNodeY = y + parentLevel * (leafSize + leafSpacing);

                        Pen pen = new Pen(Brushes.Black, 2);
                        graphics.DrawLine(pen, nodeX + leafSize / 2, nodeY, parentNodeX + leafSize / 2, parentNodeY + leafSize);
                    }
                }
            }
            pictureBox.Image = bitmap;
        }












    }
}
    
