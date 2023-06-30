using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private int x1, y1, x2, y2;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics scenery = CreateGraphics();
            SolidBrush solid_road = new SolidBrush(Color.SlateGray);
            SolidBrush solid_sky = new SolidBrush(Color.Blue);
            scenery.FillRectangle(solid_road, 0, 200, 800, 125);
            scenery.FillRectangle(solid_sky, 0, 0, 800, 100);
            
            for (int i = 10; i < 800; i += 70)
                Band(i);
            
            Sun();

            Tree(50, 150); Tree(100, 400); Tree(300, 132);
            Tree(376, 112); Tree(432, 101); Tree(532, 143);
            Tree(543, 360); Tree(658, 120);
            
            Bush(52, 376); Bush(100, 130); Bush(225, 400);
            Bush(654, 336); Bush(354, 364); Bush(454, 150); 

            void Bush(int x,int y)
            {
                Graphics bush = CreateGraphics();
                SolidBrush solid_bush = new SolidBrush(Color.DarkGreen);
                
                bush.FillEllipse(solid_bush, x, y, 25, 25);
                bush.FillEllipse(solid_bush, x + 8, y - 10, 25, 25);
                bush.FillEllipse(solid_bush, x + 16, y, 25, 25);
            }

            void Tree(int x, int y)
            {
                Graphics bush = CreateGraphics();
                SolidBrush solid_bush = new SolidBrush(Color.DarkGreen);
                SolidBrush solid_branch = new SolidBrush(Color.Brown);

                bush.FillEllipse(solid_bush, x, y, 25, 25);
                bush.FillEllipse(solid_bush, x + 5, y - 10, 25, 25);
                bush.FillEllipse(solid_bush, x + 10, y, 25, 25);
                bush.FillRectangle(solid_branch, x + 15, y + 10, 5, 25);
            }

            void Sun()
            {
                Graphics sun = CreateGraphics();
                SolidBrush solid_sun = new SolidBrush(Color.Yellow);
                sun.FillEllipse(solid_sun, 300, 35, 35, 35);

            }
            void Band(int x)
            {
                Graphics band = CreateGraphics();
                SolidBrush solid_band = new SolidBrush(Color.White);
                band.FillRectangle(solid_band, x, 255, 40, 10);
            }
        }
    }
}
