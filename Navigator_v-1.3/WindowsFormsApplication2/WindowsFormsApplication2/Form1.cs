using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        MoveWindow moveWin;
        WindowButton minWinButt;
        WindowButton maxWinButt;
        WindowButton closeWinButt;

        public Form1()
        {
            InitializeComponent();

            this.moveWin = new MoveWindow();
            this.closeWinButt = new WindowButton(848, 4, 19, 19);
            this.closeWinButt.OnClickEvent += new Buttonapp.OnClickButtonEventHandler(closeWinButt_OnClickEvent);

            this.minWinButt = new WindowButton(808, 4, 19, 19);
            this.minWinButt.OnClickEvent += new Buttonapp.OnClickButtonEventHandler(minWinButt_OnClickEvent);

            this.maxWinButt = new WindowButton(828, 4, 19, 19);
            this.maxWinButt.OnClickEvent += new Buttonapp.OnClickButtonEventHandler(maxWinButt_OnClickEvent);
            this.maxWinButt.State = "Normal";

        }

        

        

        

        private void webBrowser1_NewWindow(object sender, CancelEventArgs e)
        {
            /*System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", "Cancel", e.Cancel);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "NewWindow Event");*/
            
            e.Cancel = true;

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawString("tarace", new Font("Arial", 16.0F), Brushes.Red, new Point(-5, -5));
            int top;
            top = this.Top - 40;// (this.Top == 0) ? this.Top : this.Top - 40;
            //e.Graphics.CopyFromScreen(new Point(this.Left, top), new Point(0, 0), new Size(this.Width, this.webBrowser1.Top), CopyPixelOperation.MergeCopy); 

        }

        private void Form1_Move(object sender, EventArgs e)
        {
            


        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //this.Refresh();
        }

        private void Form1_Layout(object sender, LayoutEventArgs e)
        {
            //this.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            //this.TransparencyKey = Color.Blue;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.moveWin.OnMouseDown(sender, e);
            this.moveWin.StartWidth = this.Width;
            this.moveWin.StartHeight = this.Height;

            if (e.X <= 5)
                this.moveWin.IsLockLeftSideREO = true;
            else
                this.moveWin.IsLockLeftSideREO = false;

            if (e.X >= (this.Width - 5))
                this.moveWin.IsLockRightSideREO = true;
            else
                this.moveWin.IsLockRightSideREO = false;

            if (e.Y <= 5)
                this.moveWin.IsLockedTopSideNS = true;
            else
                this.moveWin.IsLockedTopSideNS = false;

            if (e.Y >= (this.Height - 5))
                this.moveWin.IsLockedBottomSideNS = true;
            else
                this.moveWin.IsLockedBottomSideNS = false;


        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            this.moveWin.OnMouseUp(sender, e);

           

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
                      

            int sw;
            sw = this.Width / 3;

            int swr;
            swr = this.Width - sw;
            int stcr;
            stcr = this.Width - 5;

            int sh;
            sh = this.Height / 3;
            int shr;
            shr = this.Height - sh;
            int shcr;
            shcr = this.Height - 5;

            if( ((e.X <= 5) && (e.Y <= 5)) || ((e.X >= stcr) && (e.Y >= shcr)) )
                this.Cursor = Cursors.SizeNWSE;
            else if( ((e.X >= stcr) && (e.Y <= 5)) || ((e.X <= 5) && (e.Y >= shcr)) )
                this.Cursor = Cursors.SizeNESW;
            else if ((e.X <= 5) || (e.X >= stcr))
                this.Cursor = Cursors.SizeWE;
            else if ((e.Y <= 5) || (e.Y >= (this.Height-5)))
                this.Cursor = Cursors.SizeNS;
            else
                this.Cursor = Cursors.Default;


            //NWSE up
            if (((e.X <= sw) && (this.moveWin.IsLockLeftSideREO == true)) &&
                ((e.Y <= sh) && (this.moveWin.IsLockedTopSideNS == true))
                )
            {

                if (e.Button == MouseButtons.Left)
                {

                    int d = this.moveWin.GetDeltaX(e.X);

             
                    if (d != 0)
                    {
                        this.Left += d;
                        this.Width -= d;
                    }

                    int d2 = this.moveWin.GetDeltaY(e.Y);

                    


                    if (d2 != 0)
                    {
                        this.Top += d2;
                        this.Height -= d2;
                    }
               

                }

                
                this.urlBox1.Refresh();
                this.Refresh();

            }//NWSE bottom
            else if (((e.X >= swr) && (this.moveWin.IsLockRightSideREO == true)) &&
                     ((e.Y >= shr) && (this.moveWin.IsLockedBottomSideNS == true))
                    )
            {

                if (e.Button == MouseButtons.Left)
                {
                    int d = this.moveWin.GetDeltaX(e.X);
                                                     
                    this.Width = this.moveWin.StartWidth + d;


                    int d2 = this.moveWin.GetDeltaY(e.Y);
                                    
                    this.Height = this.moveWin.StartHeight + d2;

                    
                    this.urlBox1.Refresh();
                    this.Refresh();

                }

            }// NESW up
            else if (((e.X >= swr) && (this.moveWin.IsLockRightSideREO == true)) &&
                     ((e.Y <= sh) && (this.moveWin.IsLockedTopSideNS == true))
                    )
            {
                if (e.Button == MouseButtons.Left)
                {
                    int d = this.moveWin.GetDeltaX(e.X);
                    this.Width = this.moveWin.StartWidth + d;

                    int d2 = this.moveWin.GetDeltaY(e.Y);

                    if (d2 != 0)
                    {
                        this.Top += d2;
                        this.Height -= d2;
                    }

                    
                    this.urlBox1.Refresh();
                    this.Refresh();

                }

            }// NESW bottom
            else if (((e.X <= sw) && (this.moveWin.IsLockLeftSideREO == true)) &&
                     ((e.Y >= shr) && (this.moveWin.IsLockedBottomSideNS == true))
                    )
            {
                if (e.Button == MouseButtons.Left)
                {
                    int d = this.moveWin.GetDeltaX(e.X);

                    if (d != 0)
                    {
                        this.Left += d;
                        this.Width -= d;
                    }

                    int d2 = this.moveWin.GetDeltaY(e.Y);
                    this.Height = this.moveWin.StartHeight + d2;

                    
                    this.urlBox1.Refresh();
                    this.Refresh();

                }

            }
            else if ((e.X <= sw) && (this.moveWin.IsLockLeftSideREO == true)/*(this.moveWin.StartCoordX <= 5)*/ )
            {


                if (e.Button == MouseButtons.Left)
                {

                    int d = this.moveWin.GetDeltaX(e.X);

                    if (d != 0)
                    {
                        this.Left += d;
                        this.Width -= d;
                    }
                


                }

                
                this.urlBox1.Refresh();
                this.Refresh();

            }
            else if ((e.X >= swr) && (this.moveWin.IsLockRightSideREO == true)/*(this.moveWin.StartCoordX >= stcr)*/)
            {
                

                if (e.Button == MouseButtons.Left)
                {
                    int d = this.moveWin.GetDeltaX(e.X);

                    this.label1.Text = stcr.ToString();
                    this.label2.Text = e.X.ToString();

                    
                    this.Width = this.moveWin.StartWidth + d;

                    
                    this.urlBox1.Refresh();
                    this.Refresh();

                }


            }
            else if ((e.Y <= sh) && (this.moveWin.IsLockedTopSideNS == true)/*(this.moveWin.StartCoordX <= 5)*/ )
            {


                if (e.Button == MouseButtons.Left)
                {

                    int d = this.moveWin.GetDeltaY(e.Y);

                   

                    if (d != 0)
                    {
                        this.Top += d;
                        this.Height -= d;
                    }
                   

                }

                
                this.urlBox1.Refresh();
                this.Refresh();

            }
            else if ((e.Y >= shr) && (this.moveWin.IsLockedBottomSideNS == true)/*(this.moveWin.StartCoordX >= stcr)*/)
            {
                

                if (e.Button == MouseButtons.Left)
                {
                    int d = this.moveWin.GetDeltaY(e.Y);

                    this.label1.Text = shr.ToString();
                    this.label2.Text = e.Y.ToString();

                   
                    this.Height = this.moveWin.StartHeight + d;

                    
                    this.urlBox1.Refresh();
                    this.Refresh();

                }


            }
            else
            {
                
                this.moveWin.OnMouseMove(sender, e);

            }




        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }

        private void panelButtCroix_MouseMove(object sender, MouseEventArgs e)
        {
            //this.label1.Text = e.X.ToString();
            //this.label2.Text = e.Y.ToString();
        }

        private void panelButtCroix_Click(object sender, EventArgs e)
        {
            this.closeWinButt.Click(sender, e);
        }

        private void panelButtCroix_MouseHover(object sender, EventArgs e)
        {
            
            this.Cursor = Cursors.Hand;
            
        }

        private void panelButtCroix_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        void closeWinButt_OnClickEvent(object sender, EventArgs e)
        {
            this.Close();


        }

        private void panelButtMin_Click(object sender, EventArgs e)
        {
            this.minWinButt.Click(sender, e);
        }

        void minWinButt_OnClickEvent(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void panelButtMin_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void panelButtMin_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void panelMaxButt_Click(object sender, EventArgs e)
        {
            this.maxWinButt.Click(sender, e);
        }

        private void panelMaxButt_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void panelMaxButt_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        void maxWinButt_OnClickEvent(object sender, EventArgs e)
        {
            if (this.maxWinButt.State == "Normal")
            {
                this.WindowState = FormWindowState.Maximized;
                this.maxWinButt.State = "Maximized";
            }
            else if (this.maxWinButt.State == "Maximized")
            {
                this.WindowState = FormWindowState.Normal;
                this.maxWinButt.State = "Normal";
            }

        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            this.urlBox1.Text = e.Url.ToString();
            

        }

        private void urlBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                this.webBrowser1.Navigate(this.urlBox1.Text);

            }
        }

        private void ongletpan1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Actualizebutton_Click(object sender, EventArgs e)
        {
            try
            {
                this.webBrowser1.Navigate(this.webBrowser1.Document.Url.ToString());
            }
            catch (Exception exc)
            {

            }

        }

        private void Forwardbutton_Click(object sender, EventArgs e)
        {
            if (this.webBrowser1.CanGoForward == true)
            {
                this.webBrowser1.GoForward();

            }
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            if (this.webBrowser1.CanGoBack == true)
            {
                this.webBrowser1.GoBack();

            }
        }


    }
}
