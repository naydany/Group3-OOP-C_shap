using System;

public class Enemy : GameObject
{
    public Enemy(PictureBox picture, int initialSpeed) : base(picture, initialSpeed) { }

    public override void Move()
    {
        if (Picture.Top >= 700)
            Respawn();
        else
            base.Move();
    }

    public override void Respawn()
    {
        try
        {
            Picture.Top = -100;
            Picture.Left = GameManager.Rand.Next(80, 420);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Enemy respawn error: " + ex.Message);
        }
    }
}
