using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;

namespace BlowtorchesAndGunpowder
{
    public partial class WireframeGame : Form
    {
        private Font OutputFont = new Font("Arial", 8);
        private BufferedGraphicsContext context;
        private BufferedGraphics grafx;
        private Stopwatch stopWatch = new Stopwatch();
        private TimeSpan _totalTimeElapsed;
        private TimeSpan _totalTimeElapsedWhenUpdateScreen;
        private TimeSpan _totalTimeElapsedWhenLastShot;
        private bool _pause = false;
        private Settings _settings = new Settings("localhost",4567,"Player1");

        Pen _heroShotPen = new Pen(Color.YellowGreen);
        Pen _heroShipPen = new Pen(Color.Cornsilk);
        Ship _heroShip = new Ship();
        List<Shot> _heroShotList = new List<Shot>();
        
        public WireframeGame() : base()
        {
            InitializeComponent();

            this.Text = "WireframeGame";
            this.SetClientSizeCore(800, 800);
            this.Resize += new EventHandler(this.OnResize);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            //Cursor.Hide();

            Application.Idle += new EventHandler(OnApplicationIdle);

            // Retrieves the BufferedGraphicsContext for the 
            // current application domain.
            context = BufferedGraphicsManager.Current;

            // Sets the maximum size for the primary graphics buffer
            // of the buffered graphics context for the application
            // domain.  Any allocation requests for a buffer larger 
            // than this will create a temporary buffered graphics 
            // context to host the graphics buffer.
            context.MaximumBuffer = new Size(this.Width + 1, this.Height + 1);

            // Allocates a graphics buffer the size of this form
            // using the pixel format of the Graphics created by 
            // the Form.CreateGraphics() method, which returns a 
            // Graphics object that matches the pixel format of the form.
            grafx = context.Allocate(this.CreateGraphics(), new Rectangle(0, 0, this.Width, this.Height));

            // Draw the first frame to the buffer.
            //DoChange();
            //DrawToBuffer(grafx.Graphics);
            //this.WindowState = FormWindowState.Maximized;
            stopWatch.Start();
            _totalTimeElapsed = stopWatch.Elapsed;
            _totalTimeElapsedWhenUpdateScreen = _totalTimeElapsed;
            _totalTimeElapsedWhenLastShot = _totalTimeElapsed;
        }
        private void  OnApplicationIdle(object sender, EventArgs e)
        {
            if (User32Import.GetKeyState(Keys.Escape))
            {
                if (_pause)
                    return;
                _pause = true;
                //Cursor.Show();
                SettingsForm settingsForm = new SettingsForm(_settings);
                DialogResult settingsResult = settingsForm.ShowDialog(this);
                if (settingsResult == DialogResult.Abort)
                    Close();
                else if (settingsResult == DialogResult.Cancel)
                    _pause = false;
                else if (settingsResult == DialogResult.OK)
                {
                    _settings = settingsForm.GetSettings();
                    _pause = false;
                }
                //Cursor.Hide();
            }
            if (_pause)
                return;
            while (User32Import.AppStillIdle())
            {
                // LOOP
                TimeSpan timeElapsedNow = stopWatch.Elapsed;
                TimeSpan timeElapsedFromLast = timeElapsedNow - _totalTimeElapsed;
                _totalTimeElapsed = timeElapsedNow;

                ProcessKeyState(timeElapsedFromLast);
                DoChange(timeElapsedFromLast);
                //CheckBounds(new RectangleF(0, 0, this.ClientSize.Width - size, this.ClientSize.Height - size));

                TimeSpan timeElapsedFromLastUpdateScreen = timeElapsedNow - _totalTimeElapsedWhenUpdateScreen;
                if (timeElapsedFromLastUpdateScreen.Milliseconds > 46)
                {
                    _totalTimeElapsedWhenUpdateScreen = timeElapsedNow;
                    UpdateScreen();
                }
            }
        }
        private void ProcessKeyState(TimeSpan aTimeElapsed)
        {
            if (User32Import.GetKeyState(Keys.Left))
                _heroShip.RotateLeft(aTimeElapsed);
            if (User32Import.GetKeyState(Keys.Right))
                _heroShip.RotateRight(aTimeElapsed);
            if (User32Import.GetKeyState(Keys.Up))
                _heroShip.EngageForwardThrustors(aTimeElapsed);
            if (User32Import.GetKeyState(Keys.Space) && (_totalTimeElapsed - _totalTimeElapsedWhenLastShot).Milliseconds > _heroShip.GetBulletDelay())
            {
                _heroShotList.Add(new Shot(_totalTimeElapsed, _heroShip.GetPosition(), _heroShip.GetDirection(), _heroShip.GetSpeedVector()));
                _totalTimeElapsedWhenLastShot = _totalTimeElapsed;
            }
        }
        private void DoChange(TimeSpan aTimeElapsed)
        {
            _heroShip.CalcNewPosition(aTimeElapsed, this.ClientRectangle);
            int i = 0;
            while (i < _heroShotList.Count)
            {
                if (_heroShotList[i].IsTimeToRemove(_totalTimeElapsed))
                    _heroShotList.RemoveAt(i);
                else
                {
                    _heroShotList[i].CalcNewPosition(aTimeElapsed, this.ClientRectangle);
                    i++;
                }
            }
        }
        private void UpdateScreen()
        {
            // Draw to the buffer.
            DrawToBuffer(grafx.Graphics);
            // draw in the paint method.
            this.Refresh();
        }
        private void OnResize(object sender, EventArgs e)
        {
            // Re-create the graphics buffer for a new window size.
            context.MaximumBuffer = new Size(this.ClientSize.Width + 1, this.ClientSize.Height + 1);
            if (grafx != null)
            {
                grafx.Dispose();
                grafx = null;
            }
            grafx = context.Allocate(this.CreateGraphics(), new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height));
            UpdateScreen();
        }
        private void DrawToBuffer(Graphics g)
        {
            // Clear the graphics buffer
            g.Clear(Color.Black);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.DrawLines(_heroShipPen, _heroShip.GetWorldPoints());
            for(int i = 0; i < _heroShotList.Count; i++)
                g.DrawLines(_heroShotPen, _heroShotList[i].GetWorldPoints());
            // Draw information strings.
            //g.DrawString("Click enter to toggle timed display refresh " + timer1.Enabled.ToString() , OutputFont, Brushes.White, 10, 10);
            g.DrawString(string.Format("Direction: {0:F2}", _heroShip.GetDirection()), OutputFont, Brushes.White, 10, 34);
            //g.DrawString(string.Format("Cos: {2:F2} Sin: {3:F2} SpeedF: {0:F2} SpeedS: {1:F2}", forwardSpeed, strafeSpeed, (float)Math.Cos(camera.MyDirection.VXY), (float)Math.Sin(camera.MyDirection.VXY)), new Font("Arial", 8), Brushes.White, 10, 46);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            grafx.Render(e.Graphics);
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Idle -= OnApplicationIdle;
            stopWatch.Stop();
            //Cursor.Show();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // WireframeGame
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WireframeGame";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }
        private void GoFullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
                this.Activate();
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }        //The equivalent of PeekMessage() is Application.DoEvents().  You could modify your Main() function in Program.cs like this:
        //[STAThread]
        //static void Main()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Form1 f1 = new Form1();
        //    f1.FormClosed += QuitLoop;
        //    f1.Show();
        //    do
        //    {
        //        Application.DoEvents();
        //        // Do your stuff to implement the main game loop
        //        //...
        //        // Yield the CPU
        //        System.Threading.Thread.Sleep(1);
        //    } while (!mQuit);
        //}
        //private static bool mQuit;
        //private static void QuitLoop(object sender, FormClosedEventArgs e)
        //{
        //    mQuit = true;
        //}
        //Use Sleep(0) if you want all the CPU cycles you can get.
    }
}

