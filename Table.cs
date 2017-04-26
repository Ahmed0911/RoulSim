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
        private Font fontMain;

        public Table(FormMain formMain)
        {
            this.formMain = formMain;

            // Create DB objects
            DBcurrentContext = BufferedGraphicsManager.Current;
            DBmyBuffer = DBcurrentContext.Allocate(formMain.panelTable.CreateGraphics(), formMain.panelTable.DisplayRectangle);
            fontMain = new Font("Arial", 14, FontStyle.Regular);
        }
        
        public void Draw()
        {
            Draw(-1);
        }

        public void Draw(int selectedNumber)
        {
            // clear backbuffer
            DBmyBuffer.Graphics.Clear(Color.Black);

            DBmyBuffer.Graphics.FillEllipse(new SolidBrush(Color.White), 100, 100, 10, 10);

            StringFormat strF = new StringFormat();
            strF.Alignment = StringAlignment.Center;
            DBmyBuffer.Graphics.DrawString("Mirko", fontMain, Brushes.BlanchedAlmond, 10, 10, strF);

            // render to screen            
            DBmyBuffer.Render();
        }
    }
}
