using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gScreen = CreateGraphics();
            Application.Idle += MyIdle;
            LineStyle.SelectedItem = 0;
            LineStyle.Text = LineStyle.Items[0].ToString();
            Typeline = typeline.normal;
            
        }
        enum typeline { normal, dash, dash_dot};
        typeline Typeline;
        Graphics gScreen;
        Color Color = Color.Black;
        float x_start_d = 0;
        float y_start_d = 0;
        float x_end_d = 0;
        float y_end_d = 0;

        void MyIdle(object sender, EventArgs e)
        {
            Draw.Enabled = float.TryParse(X_INP_START.Text, out x_start_d) && float.TryParse(Y_INP_START.Text, out y_start_d)
                && float.TryParse(X_INP_END.Text, out x_end_d) && float.TryParse(Y_INP_END.Text, out y_end_d)
                && x_start_d <=500 && x_end_d <=500 && y_start_d<=260 && y_end_d<=260;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            { Color = colorDialog1.Color; }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int x_start = (int)Math.Round(x_start_d);
            int y_start = (int)Math.Round(y_start_d);
            int x_end = (int)Math.Round(x_end_d);
            int y_end = (int)Math.Round(y_end_d);

            int l = Math.Max(Math.Abs(x_end - x_start), Math.Abs(y_end - y_start));
            float dx = (x_end_d - x_start_d) / l;
            float dy = (y_end_d - y_start_d) / l;

            float[] x = new float[l + 1];
            float[] y = new float[l + 1];

            x[0] = x_start_d;
            y[0] = x_start_d;

            for (int i = 1; i < l; i++)
            {
                x[i] = x[i - 1] + dx;
                y[i] = y[i - 1] + dy;
            }

            x[l] = x_end_d;
            y[l] = y_end_d;

            gScreen.Clear(BackColor);
            Bitmap bitmap = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
            switch (Typeline)
            {
                case typeline.normal:
                    for (int i = 0; i <= l; i++)
                    {
                        bitmap.SetPixel((int)Math.Round(x[i]), (int)Math.Round(y[i]), Color);
                    }
                    break;
                case typeline.dash:
                    for (int i = 0; i <= l; i+=4)
                    {
                        bitmap.SetPixel((int)Math.Round(x[i]), (int)Math.Round(y[i]), Color);
                        if (i + 1 <= l)
                        {
                            bitmap.SetPixel((int)Math.Round(x[i + 1]), (int)Math.Round(y[i + 1]), Color);
                        }

                    }
                    break;
                case typeline.dash_dot:
                    for (int i = 0; i <= l; i+=5)
                    {
                        bitmap.SetPixel((int)Math.Round(x[i]), (int)Math.Round(y[i]), Color);
                        if (i + 1 <= l)
                        {
                            bitmap.SetPixel((int)Math.Round(x[i + 1]), (int)Math.Round(y[i + 1]), Color);
                        }
                        if (i + 3 <= l)
                        {
                            bitmap.SetPixel((int)Math.Round(x[i + 3]), (int)Math.Round(y[i + 3]), Color);
                        }

                    }
                    break;

            }
            gScreen.DrawImage(bitmap, ClientRectangle);
        }

        private void LineStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (LineStyle.SelectedIndex)
            {
                case 0: Typeline = Form1.typeline.normal;
                        break;
                case 1: Typeline = typeline.dash;
                        break;
                case 2: Typeline = typeline.dash_dot;
                        break;
            }
            //gScreen.Clear(BackColor);
        }
    }
}
