using System;
using System.Windows.Forms;

public abstract class GameObject
{
    public PictureBox Picture { get; protected set; }
    public int Speed { get; set; }

    protected GameObject(PictureBox picture, int initialSpeed)
    {
        Picture = picture ?? throw new ArgumentNullException(nameof(picture));
        Speed = initialSpeed;
    }

    public virtual void Move()
    {
        try
        {
            Picture.Top += Speed;
        }
        catch (Exception ex)
        {
            // You can log ex.Message to file if needed
            Console.WriteLine("Move error: " + ex.Message);
        }
    }

    public abstract void Respawn();
}
