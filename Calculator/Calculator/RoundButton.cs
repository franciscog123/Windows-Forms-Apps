using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    //create a new custom control that extends button, it basically just cuts an ellipse shape out of the rectangular button control
    public class RoundButton : Button 
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            //create graphics path object(from the System.Drawing.Drawing2D namespace)
            GraphicsPath myPath = new GraphicsPath();

            //adds ellipse to the rectangular button object starting at coordinates (1,1) 
            //of the upper left hand corner of the button with a height and width 4 and 3 pixels
            //smaller than the size of the button (i did this to just barely cut out the black
            //rectangular button border)
            myPath.AddEllipse(1, 1, ClientSize.Width-4, ClientSize.Height-3);

            //creates a region to place the new button on
            this.Region = new System.Drawing.Region(myPath);

            //paints custom button
            base.OnPaint(e);
        }
    }
}
