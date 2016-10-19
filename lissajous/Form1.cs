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
        List<PointF> pointsList = new List<PointF>();
        Graphics drawArea;
        float x_angle;
        int mouse_position_x, mouse_position_y;
        bool togMove;
        public Form1()
        {
            InitializeComponent();
            drawArea = drawingPlace.CreateGraphics();
            timer1.Enabled = true;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            rotate_check_box.Checked = false;
            calculate_points(false);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rotate_check_box.Checked == true)
                calculate_points(true);
            equation_1.Text = "x = " + Convert.ToString(amplitude_x.Value) + " sin(" + Convert.ToString(freq_x.Value) + Convert.ToString("\u03C9") + " + " + Convert.ToString(phase_x.Value) + ")";
            equation_2.Text = "y = " + Convert.ToString(amplitude_y.Value) + " sin(" + Convert.ToString(freq_y.Value) + Convert.ToString("\u03C9") + " + " + Convert.ToString(phase_y.Value) + ")";

        }

        private void calculate_points(bool rotate)
        {
            float x, y;
            float screen_width_center = drawingPlace.Size.Width / 2,
                  screen_height_center = drawingPlace.Size.Height / 2;

            Pen blackPen = new Pen(Color.Black, 2);

            float x_amp, x_freq, y_amp, y_freq, y_angle;
            x_amp = Convert.ToInt16(amplitude_x.Value);
            x_freq = Convert.ToInt16(freq_x.Value);
            if (!rotate)
                x_angle = (Convert.ToSingle(Convert.ToSingle(phase_x.Value) * (Math.PI) / 180));
            else
            {
                x_angle += Convert.ToSingle((Math.PI) / 180);
                if (x_angle > 2 * Math.PI)
                {
                    x_angle = 0;
                }
            }

            y_amp = Convert.ToInt16(amplitude_y.Value);
            y_freq = Convert.ToInt16(freq_y.Value);
            y_angle = (Convert.ToSingle(Convert.ToSingle(phase_y.Value) * (Math.PI) / 180));

            double t_max = Math.PI * 2 + Math.PI / 180, t;
            for (t = 0; t <= t_max; t += Math.PI / 360)
            {
                x = (screen_width_center + Convert.ToSingle(x_amp * Math.Sin(x_freq * t + x_angle)));
                y = (screen_height_center + Convert.ToSingle(y_amp * Math.Sin(y_freq * t + y_angle)));
                pointsList.Add(new PointF(x, y));
            }

            Bitmap plane = new Bitmap(drawingPlace.Width, drawingPlace.Height);
            drawArea = Graphics.FromImage(plane);
            drawArea.DrawLines(blackPen, pointsList.ToArray());
            drawingPlace.Image = plane;
            pointsList.Clear();
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            togMove = true;
            mouse_position_x = e.X;
            mouse_position_y = e.Y;
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            togMove = false;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (togMove)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_position_x, MousePosition.Y - mouse_position_y);
            }
        }
    }
}
