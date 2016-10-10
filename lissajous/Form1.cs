using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lissajous
{
    public partial class Form1 : Form
    {
        Graphics drawArea;
        public Form1()
        {
            InitializeComponent();
            drawArea = drawingPlace.CreateGraphics();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            drawArea.Clear(Color.White);
            float x1 = 0, y1 = 0, x2 = 0, y2 = 0;

            Pen blackPen = new Pen(Color.Black, 3);

            float x_amp, x_freq, x_angle, y_amp, y_freq, y_angle;
            x_amp = Convert.ToInt16(x_amplitude.Value);
            x_freq = Convert.ToInt16(x_frequency.Value);
            x_angle = (Convert.ToInt16(Convert.ToInt16(x_phase.Value) * (Math.PI) / 180));
            

            y_amp = Convert.ToInt16(y_amplitude.Value);
            y_freq = Convert.ToInt16(y_frequency.Value);
            y_angle = (Convert.ToInt16(Convert.ToInt16(y_phase.Value) * (Math.PI) / 180));

            double t_max = Math.PI * 2 + Math.PI / 180, t;

            for ( t = 0; t <= t_max; t += Math.PI / 360)
            {
                x1 = drawingPlace.Size.Width / 2 + Convert.ToInt16(x_amp * Math.Sin(x_freq * t + x_angle));
                y1 = drawingPlace.Size.Height / 2 + Convert.ToInt16(y_amp * Math.Sin(y_freq * t + y_angle));
                if (t != 0)
                {
                    drawArea.DrawLine(blackPen, x1, y1, x2, y2);
                }
                x2 = x1;
                y2 = y1;
            }
        }
    }
}
