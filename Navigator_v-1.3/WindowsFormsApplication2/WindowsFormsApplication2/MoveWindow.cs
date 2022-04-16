using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class MoveWindow
    {
        int startdotcoordX;
        int startdotcoordY;
        bool mousedotisdown;
        int startdotwidth;
        int startdotheight;
        int rightsideEO;
        bool lockedrightside;
        int leftsideEO;
        bool lockedleftside;
        int topsideNS;
        bool lockedtopside;
        int bottomsideNS;
        bool lockedbottomside;

        public MoveWindow()
        {
            this.startdotcoordX = 0;
            this.startdotcoordY = 0;
            this.mousedotisdown = false;
            this.startdotwidth = 0;
            this.startdotheight = 0;
            this.rightsideEO = 0;
            this.lockedrightside = false;
            this.leftsideEO = 0;
            this.lockedleftside = false;
            this.topsideNS = 0;
            this.lockedtopside = false;
            this.bottomsideNS = 0;
            this.lockedbottomside = false;

        }

        public void OnMouseDown(object sender, MouseEventArgs e)
        {
            this.mousedotisdown = true;
            this.startdotcoordX = e.X;
            this.startdotcoordY = e.Y;
        }

        public void OnMouseMove(object sender, MouseEventArgs e)
        {
            int deltaX;
            int deltaY;
            int x;
            int y;

            if (this.mousedotisdown == true)
            {
                deltaX = e.X - this.startdotcoordX;
                deltaY = e.Y - this.startdotcoordY;
                Form1 f = (Form1)sender;
                x = f.DesktopLocation.X + deltaX;
                y = f.DesktopLocation.Y + deltaY;

                f.SetDesktopLocation(x, y);

            }


        }

        public void OnMouseUp(object sender, MouseEventArgs e)
        {
            this.mousedotisdown = false;
        }

        public int StartCoordX
        {
            get { return this.startdotcoordX; }
        }

        public int StartWidth
        {
            set { this.startdotwidth = value; }
            get { return this.startdotwidth; }
        }

        public int StartHeight
        {
            set { this.startdotheight = value; }
            get { return this.startdotheight; }
        }

        public bool IsLockLeftSideREO
        {
            set { this.lockedleftside = value; }
            get { return this.lockedleftside; }
        }

        public int LeftSideResizeEO
        {
            set { this.leftsideEO = value; }
            get { return this.leftsideEO; }
        }

        public bool IsLockRightSideREO
        {
            set { this.lockedrightside = value; }
            get { return this.lockedrightside; }
        }

        public int RightSideResizeEO
        {
            set { this.rightsideEO = value; }
            get { return this.rightsideEO; }
        }

        public bool IsLockedTopSideNS
        {
            set { this.lockedtopside = value; }
            get { return this.lockedtopside; }
        }

        public int TopSideResizeNS
        {
            set { this.topsideNS = value; }
            get { return this.topsideNS; }
        }

        public bool IsLockedBottomSideNS
        {
            set { this.lockedbottomside = value; }
            get { return this.lockedbottomside; }
        }

        public int BottomSideResizeNS
        {
            set { this.bottomsideNS = value; }
            get { return this.bottomsideNS; }
        } 


        public int GetDeltaX(int x)
        {
            int r = x - this.startdotcoordX;
            return r;

        }

        public int GetDeltaY(int y)
        {
            return (y - this.startdotcoordY);

        }


    }
}
