using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DesktopDuplication.Demo
{
    public partial class OverlayForm : Form
    {
        public OverlayForm()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
                return createParams;
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            Pen pen = new Pen(Color.White, 4);
            Brush transparent = new SolidBrush(TransparencyKey);

            var fullWidth = ClientRectangle.Width;
            var fullHeight = ClientRectangle.Height;
            var halfWidth = ClientRectangle.Width / 2;
            var halfHeight = ClientRectangle.Height / 2;

            var buffer = 10;

            LinearGradientBrush myBrush = new LinearGradientBrush(new Point(0, 0), new Point(1, 1), Color.White, Color.Black);

            // Draw border
            e.Graphics.FillRectangle(myBrush, this.ClientRectangle);
            e.Graphics.FillRectangle(transparent, 3, 3, ClientRectangle.Width - 6, ClientRectangle.Height - 6);

            // Draw target
            //e.Graphics.FillRectangle(transparent, this.ClientRectangle);
            //e.Graphics.DrawLine(pen, halfWidth, 0, halfWidth, fullHeight);
            //e.Graphics.DrawLine(pen, 0, halfHeight, fullWidth, halfHeight);
            //e.Graphics.FillRectangle(transparent, halfWidth - (buffer / 2), halfHeight - (buffer / 2), buffer, buffer);
        }
    }
}
