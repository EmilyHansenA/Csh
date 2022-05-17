using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimationTaskGL
{
    public partial class Animation : Form
    {
        public Animation()
        {
            InitializeComponent();
            DoubleBuffered = true;

            ClientSize = new Size(500, 500);

            var centerX = ClientSize.Width / 2;
            var centerY = ClientSize.Height / 2;

            var size = 100;
            var radius = Math.Min(ClientSize.Width, ClientSize.Height) / 3;

            var time = 0;
            var Timer = new Timer();
            Timer.Interval = 500;
            Timer.Tick += (sender, args) =>
            {
                time++;
                Invalidate();
            };

            Timer.Start();

            Paint += (sender, args) =>
            {
                Random rand = new Random();
                SolidBrush brush = new SolidBrush(Color.FromArgb(255, (byte)rand.Next(256), (byte)rand.Next(256), (byte)rand.Next(256)));

                for (int i = 0; i < time; i++)
                {
                    args.Graphics.TranslateTransform(centerX, centerY);
                    args.Graphics.RotateTransform(i * 360f / 10);
                    args.Graphics.FillEllipse(brush, radius - size / 2, -size / 2, size, size);

                    args.Graphics.ResetTransform();
                }
            };
        }

        private void Animation_Load(object sender, EventArgs e)
        {

        }
    }
}
