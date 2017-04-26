using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoulSim
{
    class Table
    {
        private FormMain formMain;

        // Double buffering
        BufferedGraphicsContext DBcurrentContext;
        BufferedGraphics DBmyBuffer;

        // objects
        Font fontMain;
        Image tableBitmap;

        public Table(FormMain formMain)
        {
            this.formMain = formMain;

            // Create DB objects
            DBcurrentContext = BufferedGraphicsManager.Current;
            DBmyBuffer = DBcurrentContext.Allocate(formMain.panelTable.CreateGraphics(), formMain.panelTable.DisplayRectangle);
            fontMain = new Font("Arial", 14, FontStyle.Regular);

            // Load Image
            tableBitmap = Bitmap.FromFile("table.bmp");
        }
        
        public void Draw()
        {
            Draw(-1);
        }

        public void Draw(int selectedNumber)
        {
            // clear backbuffer
            DBmyBuffer.Graphics.Clear(Color.Black);

            // draw table
            DBmyBuffer.Graphics.DrawImageUnscaled(tableBitmap, formMain.panelTable.DisplayRectangle);

            // Draw Selected Number
            if( selectedNumber >= 0)
            {
                Color customColor = Color.FromArgb(150, Color.Blue);
                SolidBrush shadowBrush = new SolidBrush(customColor);
                if ( selectedNumber == 0)
                {
                    DBmyBuffer.Graphics.FillRectangle(shadowBrush, 118, 18, 60, 40);
                }
                else
                {
                    int column = ((selectedNumber - 1) % 3);
                    int row = (selectedNumber-1) / 3;

                    DBmyBuffer.Graphics.FillRectangle(shadowBrush, column*63 + 55, (int)(row * 32.5) + 60, 60, 40);
                }


            }


            // render to screen            
            DBmyBuffer.Render();
        }
    }
}
