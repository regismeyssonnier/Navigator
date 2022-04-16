using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class WindowButton : Buttonapp
    {
        String state;

        public WindowButton() : base()
        {
            
        }

        public WindowButton(int x, int y) : base(x, y)
        {

        }

        public WindowButton(int x, int y, Color c) : base(x, y, c)
        {

        }

        public WindowButton(int x, int y, int w, int h) : base(x, y, w, h)
        {

        }

        public WindowButton(int x, int y, int w, int h, Color c)
            : base(x, y, w, h, c)
        {

        }

        public String State
        {
            set {
                if ((value.Equals("Normal") == true) || (value.Equals("Maximized") == true))
                    this.state = value;
                else
                    throw new ArgumentException("Normal or Maximized value are only authorized.");
            }
            get { return this.state; }
        }

        public override bool Hover(int x, int y)
        {

            return base.Hover(x, y);
        }



    }
}
