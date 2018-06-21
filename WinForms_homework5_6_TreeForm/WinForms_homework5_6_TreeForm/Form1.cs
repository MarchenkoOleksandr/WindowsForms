using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

//Особенности: помимо того, что крестиком можно закрыть форму, ёлку можно ещё и двигать мышью

namespace WinForms_homework5_6_TreeForm
{
    public partial class Form1 : Form
    {
        Point mouseOffset;
        bool IsMouseDown = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath graphics = new GraphicsPath();
            graphics.AddPolygon(
                new[] {
                    new Point(ClientSize.Width / 2, 30),
                    new Point(ClientSize.Width / 2 + 130, 150),
                    new Point(ClientSize.Width / 2 + 50, 150),
                    new Point(ClientSize.Width / 2 + 180, 300),
                    new Point(ClientSize.Width / 2 + 50, 300),
                    new Point(ClientSize.Width / 2 + 50, 380),

                    new Point(ClientSize.Width / 2 - 50, 380),
                    new Point(ClientSize.Width / 2 - 50, 300),
                    new Point(ClientSize.Width / 2 - 180, 300),
                    new Point(ClientSize.Width / 2 - 50, 150),
                    new Point(ClientSize.Width / 2 - 130, 150),
                });
            Region = new Region(graphics);
            Brush bodyBrush = new SolidBrush(Color.Brown);
            e.Graphics.FillRectangle(bodyBrush, new Rectangle(ClientSize.Width / 2 - 60, 270, 120, 120));
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown)
            {
                Point point = MousePosition;
                point.Offset(mouseOffset.X, mouseOffset.Y);
                Location = point;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Point offset = new Point();
            if (e.Button == MouseButtons.Left)
            {
                offset.X = -e.X - SystemInformation.FixedFrameBorderSize.Width;
                offset.Y = -e.Y - SystemInformation.CaptionHeight - SystemInformation.FixedFrameBorderSize.Height;
                mouseOffset = new Point(offset.X, offset.Y);
                IsMouseDown = true;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                IsMouseDown = false;
        }

        private void LabelClose_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }
    }
}