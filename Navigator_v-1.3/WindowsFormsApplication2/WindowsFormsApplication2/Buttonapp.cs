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
    class Buttonapp
    {
        protected int posX;
        protected int posY;
        protected int width;
        protected int height;
        protected bool isHover;
        protected Color colorButton;
        protected Color colorBhover;
        protected String text;
        bool hasText;

        public Buttonapp()
        {
            this.colorButton = Color.Red;
            this.posX = 0;
            this.posY = 0;
            this.width = 10;
            this.height = 10;
            this.colorBhover = Color.White;
            this.isHover = false;
            this.hasText = false;
        }

        public Buttonapp(int x, int y)
        {
            this.posX = x;
            this.posY = y;
            this.colorButton = Color.Red;
            this.width = 10;
            this.height = 10;
            this.colorBhover = Color.White;
            this.isHover = false;
            this.hasText = false;
        }

        public Buttonapp(int x, int y, Color c)
        {
            this.posX = x;
            this.posY = y;
            this.colorButton = c;
            this.width = 10;
            this.height = 10;
            this.colorBhover = Color.White;
            this.isHover = false;
            this.hasText = false;

        }

        public Buttonapp(int x, int y, int w, int h)
        {
            this.posX = x;
            this.posY = y;
            this.colorButton = Color.Red;
            this.width = w;
            this.height = h;
            this.colorBhover = Color.White;
            this.isHover = false;
            this.hasText = false;

        }

        public Buttonapp(int x, int y, int w, int h, Color c)
        {
            this.posX = x;
            this.posY = y;
            this.colorButton = c;
            this.width = w;
            this.height = h;
            this.colorBhover = Color.White;
            this.isHover = false;
            this.hasText = false;
        }

        public Color ColorButton
        {
            get { return this.colorButton; }

            set { this.colorButton = value; }

        }

        public Color ColorButtonHover
        {
            get { return this.colorBhover; }

            set { this.colorBhover = value; }

        }

        public int PosX
        {
            get { return this.posX; }

            set { this.posX = value; }

        }


        public int PosY
        {
            get { return this.posY; }

            set { this.posY = value; }

        }

        public int Width
        {
            get { return this.width; }

            set { this.width = value; }

        }

        public int Height
        {
            get { return this.height; }

            set { this.height = value; }

        }

        public bool IsHover
        {
            set { this.isHover = value; }
            get { return this.isHover; }

        }

        public String Text
        {
            set { this.text = value; if (this.text.Equals("") == true)this.hasText = false; else this.hasText = true; }
            get { return this.text; }
        }

        public virtual bool Hover(int x, int y)
        {
            if ((x >= this.posX) && (x <= (this.posX + this.width)) && (y >= this.posY) && (y <= (this.posY + this.height)))
            {
                this.isHover = true;
                return true;
            }

            this.isHover = false;
            return false;

        }

        public virtual void Paint(object sender, PaintEventArgs e)
        {
            SolidBrush sb;

            if (this.isHover == false)
                sb = new SolidBrush(this.colorButton);
            else
                sb = new SolidBrush(this.colorBhover);

            // Create rectangle.
            Rectangle buttRect = new Rectangle(this.posX, this.posY, this.width, this.height);

            // Fill rectangle to screen.
            e.Graphics.FillRectangle(sb, buttRect);

            if (this.hasText == true)
            {

                // Create font and brush.
                Font drawFont = new Font("Arial", 16);
                SolidBrush drawBrush = new SolidBrush(Color.White);

                int ln = this.text.Length;
                // Create point for upper-left corner of drawing.
                PointF drawPoint = new PointF(this.posX + (this.width / 2 - ln * 16), this.posY + (this.height / 2 - 16));

                // Draw string to screen.
                e.Graphics.DrawString(/*drawString*/ this.text, drawFont, drawBrush, drawPoint);
            }

        }


        public delegate void OnClickButtonEventHandler(object sender, EventArgs e);
        public event OnClickButtonEventHandler OnClickEvent;

        public virtual void Click(object sender, EventArgs e)
        {
            OnClickEvent(sender, e);
        }

        public virtual void MouseMove(object sender, MouseEventArgs e)
        {
            this.Hover(e.X, e.Y);
        }

        public virtual void MouseDown(object sender, MouseEventArgs e)
        {

        }

        public virtual void MouseUp(object sender, MouseEventArgs e)
        {

        }


    }
}
