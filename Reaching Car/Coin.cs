using System;

public class Coin : GameObject
{
    public Coin(PictureBox picture, int initialSpeed) : base(picture, initialSpeed) { }

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
            Picture.Left = GameManager.GetSafeCoinX(Picture);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Coin respawn error: " + ex.Message);
        }
    }
}
