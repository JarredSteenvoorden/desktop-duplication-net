using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;
using Tesseract;

namespace DesktopDuplication.Demo
{
    public partial class FormDemo : Form
    {
        private DesktopDuplicator desktopDuplicator;

        public FormDemo()
        {
            InitializeComponent();

            try
            {
                desktopDuplicator = new DesktopDuplicator(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FormDemo_Shown(object sender, EventArgs e)
        {
            var overlay = new OverlayForm();
            overlay.StartPosition = FormStartPosition.Manual;
            overlay.Show();

            txtTargetPosX.Text = _targetPosition.X.ToString();
            txtTargetPosY.Text = _targetPosition.Y.ToString();
            txtTargetPosWidth.Text = _targetPosition.Width.ToString();
            txtTargetPosHeight.Text = _targetPosition.Height.ToString();

            txtThreshold.Text = _threshold.ToString();

            var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default);

            while (true)
            {
                Application.DoEvents();

                DesktopFrame frame = null;
                try
                {
                    frame = desktopDuplicator.GetLatestFrame();
                }
                catch
                {
                    desktopDuplicator = new DesktopDuplicator(0);
                    continue;
                }

                if (frame != null && frame.DesktopImage != null)
                {
                    _processingStopwatch.Start();

                    // Pre Process image
                    var targetImage = CropImage(frame.DesktopImage.Bitmap, _targetPosition);
                    PreProcessImage(targetImage, ckbInvert.Checked, ckbBlur.Checked, _threshold);

                    // Get colour of center pixel
                    _targetColouPrevious = _targetColour;
                    _targetColour = frame.DesktopImage.GetPixel(_targetPosition.X + (_targetPosition.Width / 2), _targetPosition.Y + (_targetPosition.Height / 2));

                    // Run tesseract text recognition
                    using (var page = engine.Process(targetImage, PageSegMode.SingleBlock))
                    {
                        var text = page.GetText();
                        lblResult.Text = text;
                    }

                    _processingStopwatch.Stop();

                    // Update UI
                    _frames++;
                    var now = DateTime.Now;
                    var period = now - _lastUpdate;
                    if (period.TotalMilliseconds > UiUpdateIntervalMs)
                    {
                        var fps = _frames / period.TotalSeconds;
                        var processingAverage = _processingStopwatch.ElapsedMilliseconds / _frames;

                        _processingStopwatch.Reset();
                        _frames = 0;
                        _lastUpdate = now;

                        // Update Labels
                        lblFps.Text = $"{fps:0} fps - {processingAverage:0}ms - {_targetColour}";

                        // Position Overlay
                        overlay.Width = _targetPosition.Width + 6;
                        overlay.Height = _targetPosition.Height + 6;
                        overlay.Left = _targetPosition.X - 3;
                        overlay.Top = _targetPosition.Y - 3;
                        overlay.Invalidate();

                        // Update Input Image
                        if (pictureBox.Image == null || ckbUpdateInput.Checked)
                            pictureBox.Image = SizeToForm(targetImage);

                        // Get inputs
                        if (Int32.TryParse(txtTargetPosX.Text, out int x) && Int32.TryParse(txtTargetPosY.Text, out int y) &&
                            Int32.TryParse(txtTargetPosWidth.Text, out int width) && Int32.TryParse(txtTargetPosHeight.Text, out int height))
                        {
                            _targetPosition = new Rectangle(x, frame.DesktopImage.Height - y, width, height);
                        }

                        if (Int32.TryParse(txtThreshold.Text, out int threshold))
                            _threshold = threshold;
                    }

                    // Limit processing speed
                    if (ckbLimitFps.Checked)
                    {
                        var frameTime = DateTime.Now - _lastFrame;
                        var targetTimeMs = 1000 / _fpsLimit;
                        if (frameTime.TotalMilliseconds < targetTimeMs)
                            Thread.Sleep((int)(targetTimeMs - frameTime.TotalMilliseconds));
                    }

                    _lastFrame = DateTime.Now;
                }
            }

            engine.Dispose();
        }

        private const int _fpsLimit = 15;
        private const int UiUpdateIntervalMs = 500;

        private Stopwatch _processingStopwatch = new Stopwatch();
        private DateTime _lastFrame = DateTime.Now;
        private DateTime _lastUpdate = DateTime.Now;
        private int _frames = 0;

        private int _threshold = 220;
        private Rectangle _targetPosition = new Rectangle(130, 360, 140, 70);
        private Color _targetColour;
        private Color _targetColouPrevious;

        private Bitmap SizeToForm(Image image)
        {
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (Graphics g = Graphics.FromImage(bmp))
                g.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height));

            return bmp;
        }

        private static Bitmap CropImage(Bitmap source, Rectangle section)
        {
            /*Bitmap bmpImage = new Bitmap(img);
            return bmpImage.Clone(cropArea, bmpImage.PixelFormat);*/

            var bitmap = new Bitmap(section.Width, section.Height);
            using (var g = Graphics.FromImage(bitmap))
            {
                g.DrawImage(source, 0, 0, section, GraphicsUnit.Pixel);
                return bitmap;
            }
        }

        public unsafe Bitmap PreProcessImage(Bitmap b, bool invert, bool blur, double threshold)
        {
            byte darkByte = (byte)(invert ? 0 : 255);
            byte lightByte = (byte)(invert ? 255 : 0);

            BitmapData bData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadWrite, b.PixelFormat);

            int bitsPerPixel = Image.GetPixelFormatSize(bData.PixelFormat);

            // Use pointer for fast access to byet data
            byte* scan0 = (byte*)bData.Scan0.ToPointer();

            for (int i = 0; i < bData.Height; ++i)
            {
                for (int j = 0; j < bData.Width; ++j)
                {
                    // data is a pointer to the first byte of the 3-byte color data
                    byte* data = scan0 + i * bData.Stride + j * bitsPerPixel / 8;

                    double magnitude = 1 / 3d * (data[0] + data[1] + data[2]);

                    bool dark = 
                        magnitude > threshold && 
                        (!blur || Math.Abs(data[0] - data[1]) <= 5 && Math.Abs(data[0] - data[2]) <= 5);

                    if (dark)
                    {
                        data[0] = darkByte;
                        data[1] = darkByte;
                        data[2] = darkByte;
                    }
                    else
                    {
                        data[0] = lightByte;
                        data[1] = lightByte;
                        data[2] = lightByte;
                    }
                }
            }

            b.UnlockBits(bData);

            return b;
        }
    }
}
