using System;
using System.Windows.Forms;

namespace Reaching_Car
{
    public abstract class GameObject
    {
        protected PictureBox pictureBox;
        protected static readonly Random rand = new Random();

        protected const int MinX = 80;
        protected const int MaxX = 420;
        protected const int ResetTop = -100;
        protected const int ScreenBottom = 700;

        protected GameObject(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox ?? throw new ArgumentNullException(nameof(pictureBox));
        }

        public virtual void Move(int speed)
        {
            if (pictureBox.Top >= ScreenBottom)
                ResetPosition();
            else
                pictureBox.Top += speed;
        }

        protected virtual void ResetPosition()
        {
            pictureBox.Left = rand.Next(MinX, MaxX);
            pictureBox.Top = ResetTop;
        }

        // Safe reset for coins (avoids car/enemies/other coins)
        protected void ResetPositionSafe(params Control[] avoidControls)
        {
            bool collides;
            do
            {
                pictureBox.Left = rand.Next(MinX, MaxX);
                pictureBox.Top = ResetTop;

                collides = false;
                foreach (var control in avoidControls)
                {
                    if (control != null && pictureBox.Bounds.IntersectsWith(control.Bounds))
                    {
                        collides = true;
                        break;
                    }
                }
            } while (collides);
        }

        public bool IsColliding(Control control)
        {
            return control != null && pictureBox.Bounds.IntersectsWith(control.Bounds);
        }
    }
}
