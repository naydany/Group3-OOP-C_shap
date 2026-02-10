using System.Windows.Forms;

namespace Reaching_Car
{
    public class Coin : GameObject
    {
        public Coin(PictureBox pictureBox) : base(pictureBox) { }

        // Collect coin if colliding with car, reset safely
        public bool Collect(Control car, params Control[] avoidControls)
        {
            if (IsColliding(car))
            {
                ResetPositionSafe(avoidControls);
                return true;
            }
            return false;
        }
    }
}
