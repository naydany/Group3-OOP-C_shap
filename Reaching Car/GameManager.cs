using System;
using System.Collections.Generic;
using System.Windows.Forms;

public static class GameManager
{
    public static Random Rand = new Random();

    public static List<Enemy> Enemies = new List<Enemy>();
    public static List<Coin> Coins = new List<Coin>();

    public static int EnemySpeed = 5;
    public static int MaxEnemySpeed = 10;
    public static int TotalCoinsCollected = 0;

    public static void Initialize(PictureBox e1, PictureBox e2, PictureBox e3,
                                  PictureBox c1, PictureBox c2, PictureBox c3)
    {
        if (e1 == null || e2 == null || e3 == null ||
            c1 == null || c2 == null || c3 == null)
            throw new ArgumentNullException("All PictureBoxes must be assigned.");

        Enemies.Clear();
        Coins.Clear();

        Enemies.Add(new Enemy(e1, EnemySpeed));
        Enemies.Add(new Enemy(e2, EnemySpeed));
        Enemies.Add(new Enemy(e3, EnemySpeed));

        Coins.Add(new Coin(c1, EnemySpeed));
        Coins.Add(new Coin(c2, EnemySpeed));
        Coins.Add(new Coin(c3, EnemySpeed));
    }

    public static void UpdateAll()
    {
        try
        {
            foreach (var enemy in Enemies)
                enemy.Move();

            foreach (var coin in Coins)
                coin.Move();

            UpdateEnemySpeed();
        }
        catch (Exception ex)
        {
            Console.WriteLine("UpdateAll error: " + ex.Message);
        }
    }

    public static void UpdateEnemySpeed()
    {
        try
        {
            int calc = 5 + (TotalCoinsCollected / 6);
            EnemySpeed = Math.Min(calc, MaxEnemySpeed);

            foreach (var e in Enemies)
                e.Speed = EnemySpeed;

            foreach (var c in Coins)
                c.Speed = EnemySpeed;
        }
        catch (Exception ex)
        {
            Console.WriteLine("EnemySpeed update error: " + ex.Message);
        }
    }

    public static int GetSafeCoinX(PictureBox coin)
    {
        int newX;
        bool conflict;

        do
        {
            newX = Rand.Next(80, 420);
            coin.Left = newX;
            conflict = false;

            foreach (var otherCoin in Coins)
            {
                if (!ReferenceEquals(coin, otherCoin.Picture) &&
                    coin.Bounds.IntersectsWith(otherCoin.Picture.Bounds))
                {
                    conflict = true;
                    break;
                }
            }

            if (!conflict)
            {
                foreach (var enemy in Enemies)
                {
                    if (coin.Bounds.IntersectsWith(enemy.Picture.Bounds))
                    {
                        conflict = true;
                        break;
                    }
                }
            }

        } while (conflict);

        return newX;
    }
}
