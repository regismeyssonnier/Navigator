namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Actualizebutton = new System.Windows.Forms.Panel();
            this.Backbutton = new System.Windows.Forms.Panel();
            this.Forwardbutton = new System.Windows.Forms.Panel();
            this.urlBox1 = new System.Windows.Forms.TextBox();
            this.panelButtCroix = new System.Windows.Forms.Panel();
            this.panelButtMin = new System.Windows.Forms.Panel();
            this.panelMaxButt = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ongletpan1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.ongletpan1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(12, 100);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(846, 517);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://www.bing.fr", System.UriKind.Absolute);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            this.webBrowser1.NewWindow += new System.ComponentModel.CancelEventHandler(this.webBrowser1_NewWindow);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Actualizebutton);
            this.panel1.Controls.Add(this.Backbutton);
            this.panel1.Controls.Add(this.Forwardbutton);
            this.panel1.Controls.Add(this.urlBox1);
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 44);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Actualizebutton
            // 
            this.Actualizebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Actualizebutton.BackgroundImage")));
            this.Actualizebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Actualizebutton.Location = new System.Drawing.Point(69, 12);
            this.Actualizebutton.Name = "Actualizebutton";
            this.Actualizebutton.Size = new System.Drawing.Size(25, 25);
            this.Actualizebutton.TabIndex = 3;
            this.Actualizebutton.Click += new System.EventHandler(this.Actualizebutton_Click);
            // 
            // Backbutton
            // 
            this.Backbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Backbutton.BackgroundImage")));
            this.Backbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Backbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Backbutton.Location = new System.Drawing.Point(12, 15);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(19, 19);
            this.Backbutton.TabIndex = 2;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // Forwardbutton
            // 
            this.Forwardbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Forwardbutton.BackgroundImage")));
            this.Forwardbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Forwardbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Forwardbutton.Location = new System.Drawing.Point(41, 15);
            this.Forwardbutton.Name = "Forwardbutton";
            this.Forwardbutton.Size = new System.Drawing.Size(19, 19);
            this.Forwardbutton.TabIndex = 1;
            this.Forwardbutton.Click += new System.EventHandler(this.Forwardbutton_Click);
            // 
            // urlBox1
            // 
            this.urlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlBox1.Location = new System.Drawing.Point(106, 12);
            this.urlBox1.Name = "urlBox1";
            this.urlBox1.Size = new System.Drawing.Size(752, 24);
            this.urlBox1.TabIndex = 0;
            this.urlBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urlBox1_KeyPress);
            // 
            // panelButtCroix
            // 
            this.panelButtCroix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButtCroix.BackColor = System.Drawing.Color.Transparent;
            this.panelButtCroix.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelButtCroix.BackgroundImage")));
            this.panelButtCroix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelButtCroix.Location = new System.Drawing.Point(842, 8);
            this.panelButtCroix.Name = "panelButtCroix";
            this.panelButtCroix.Size = new System.Drawing.Size(19, 19);
            this.panelButtCroix.TabIndex = 2;
            this.panelButtCroix.Click += new System.EventHandler(this.panelButtCroix_Click);
            this.panelButtCroix.MouseLeave += new System.EventHandler(this.panelButtCroix_MouseLeave);
            this.panelButtCroix.MouseHover += new System.EventHandler(this.panelButtCroix_MouseHover);
            this.panelButtCroix.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelButtCroix_MouseMove);
            // 
            // panelButtMin
            // 
            this.panelButtMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButtMin.BackColor = System.Drawing.Color.Transparent;
            this.panelButtMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelButtMin.BackgroundImage")));
            this.panelButtMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelButtMin.Location = new System.Drawing.Point(802, 8);
            this.panelButtMin.Name = "panelButtMin";
            this.panelButtMin.Size = new System.Drawing.Size(19, 19);
            this.panelButtMin.TabIndex = 3;
            this.panelButtMin.Click += new System.EventHandler(this.panelButtMin_Click);
            this.panelButtMin.MouseLeave += new System.EventHandler(this.panelButtMin_MouseLeave);
            this.panelButtMin.MouseHover += new System.EventHandler(this.panelButtMin_MouseHover);
            // 
            // panelMaxButt
            // 
            this.panelMaxButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMaxButt.BackColor = System.Drawing.Color.Transparent;
            this.panelMaxButt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMaxButt.BackgroundImage")));
            this.panelMaxButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMaxButt.Location = new System.Drawing.Point(822, 8);
            this.panelMaxButt.Name = "panelMaxButt";
            this.panelMaxButt.Size = new System.Drawing.Size(19, 19);
            this.panelMaxButt.TabIndex = 4;
            this.panelMaxButt.Click += new System.EventHandler(this.panelMaxButt_Click);
            this.panelMaxButt.MouseLeave += new System.EventHandler(this.panelMaxButt_MouseLeave);
            this.panelMaxButt.MouseHover += new System.EventHandler(this.panelMaxButt_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // ongletpan1
            // 
            this.ongletpan1.BackColor = System.Drawing.Color.Transparent;
            this.ongletpan1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ongletpan1.BackgroundImage")));
            this.ongletpan1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ongletpan1.Controls.Add(this.panel2);
            this.ongletpan1.Location = new System.Drawing.Point(0, 5);
            this.ongletpan1.Name = "ongletpan1";
            this.ongletpan1.Size = new System.Drawing.Size(150, 35);
            this.ongletpan1.TabIndex = 7;
            this.ongletpan1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ongletpan1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(132, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(15, 15);
            this.panel2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(870, 629);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ongletpan1);
            this.Controls.Add(this.panelMaxButt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panelButtMin);
            this.Controls.Add(this.panelButtCroix);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MEYSSONNIER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.Form1_Layout);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.Move += new System.EventHandler(this.Form1_Move);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ongletpan1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox urlBox1;
        private System.Windows.Forms.Panel panelButtCroix;
        private System.Windows.Forms.Panel panelButtMin;
        private System.Windows.Forms.Panel panelMaxButt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel ongletpan1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Forwardbutton;
        private System.Windows.Forms.Panel Backbutton;
        private System.Windows.Forms.Panel Actualizebutton;
    }
}

