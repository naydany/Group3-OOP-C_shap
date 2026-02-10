using System.Windows.Forms;

namespace Reaching_Car
{
    public class Enemy : GameObject
    {
        public Enemy(PictureBox pictureBox) : base(pictureBox) { }

        public override void Move(int speed)
        {
            base.Move(speed); // moves down
        }

        protected override void ResetPosition()
        {
            pictureBox.Left = rand.Next(MinX, MaxX);
            pictureBox.Top = -rand.Next(150, 400); // random starting position
        }
    }
}
