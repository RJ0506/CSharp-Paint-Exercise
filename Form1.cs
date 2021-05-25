using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {

        Graphics g;
        Pen p;
        int x;
        int y;
        int width;
        int height;
        bool moving;

        public Form1()
        {
            InitializeComponent();
            g = panelCanvas.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            p = new Pen(Color.Black, 5);
            p.StartCap = p.EndCap = System.Drawing.Drawing2D.LineCap.Round;   
            x = 0;
            y = 0;
            moving = false;
        }

        //Canvas mouse events
        private void panelCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            panelCanvas.Cursor = Cursors.Cross;
            moving = true;
            x = e.X;
            y = e.Y;
        }
        private void panelCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x != 0 && y != 0)
            {
                if(radioPen.Checked)
                {
                    p.Color = picBoxPenColor.BackColor;
                    g.DrawLine(p, new Point(x, y), e.Location);
                    x = e.X;
                    y = e.Y;
                } 
                else if(radioEraser.Checked)
                {
                    p.Color = panelCanvas.BackColor;
                    g.DrawLine(p, new Point(x, y), e.Location);
                    x = e.X;
                    y = e.Y;
                }              
            }


        }
        private void panelCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            panelCanvas.Cursor = Cursors.Default;
            moving = false;
            height = e.X - x;
            width = e.Y - y;
            Rectangle shape = new Rectangle(x, y, height, width);

            if (radioRectangle.Checked)
            {
                p.Color = picBoxPenColor.BackColor;
                g.DrawRectangle(p, shape);
            }
            else if (radioCircle.Checked)
            {
                p.Color = picBoxPenColor.BackColor;
                g.DrawEllipse(p, shape);
            }

        }

        private void btnPenColor_Click(object sender, EventArgs e)
        {
            colorDialogPenColor.ShowDialog();
            p.Color = colorDialogPenColor.Color;
            picBoxPenColor.BackColor = p.Color;
        }

        private void btnBackgroundColor_Click(object sender, EventArgs e)
        {
            colorDialogBackgroundColor.ShowDialog();
            panelCanvas.BackColor = colorDialogBackgroundColor.Color;
        }

        private void numPenWidth_ValueChanged(object sender, EventArgs e)
        {
            p.Width = (int) numPenWidth.Value;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            g.Clear(colorDialogBackgroundColor.Color);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpg files (*.jpg)|*.jpg";

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                Thread.Sleep(1000);
                Image bmp = new Bitmap(panelCanvas.Width, panelCanvas.Height);
                var gg = Graphics.FromImage(bmp);
                var rect = panelCanvas.RectangleToScreen(panelCanvas.ClientRectangle);
                gg.CopyFromScreen(rect.Location, Point.Empty, panelCanvas.Size);

                bmp.Save(sfd.FileName, ImageFormat.Jpeg);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "jpg files (*.jpg)|*.jpg";

            if(opf.ShowDialog() == DialogResult.OK)
            {
                Image file = Image.FromFile(opf.FileName);
                panelCanvas.BackgroundImage = file;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            g = panelCanvas.CreateGraphics();
        }
    }
}
