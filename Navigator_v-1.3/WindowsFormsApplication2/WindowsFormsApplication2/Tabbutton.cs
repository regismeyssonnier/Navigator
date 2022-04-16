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
    class Tabbutton : Buttonapp
    {
        public Tabbutton() : base()
        {
            
        }

        public Tabbutton(int x, int y) : base(x, y)
        {

        }

        public Tabbutton(int x, int y, Color c) : base(x, y, c)
        {

        }

        public Tabbutton(int x, int y, int w, int h) : base(x, y, w, h)
        {

        }

        public Tabbutton(int x, int y, int w, int h, Color c)
            : base(x, y, w, h, c)
        {

        }


    }
}
