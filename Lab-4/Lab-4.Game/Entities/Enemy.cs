using Lab_4.Game.Base;

namespace Lab_4.Game.Entities;

public class Enemy : BaseEntity
{
    public Enemy(string name) : base(name)
    {
    }

    public void AttackPlayer(Player player)
    {
        player.TakeDamage(10);
    }
}