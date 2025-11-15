using Lab_4.Game.Base;

namespace Lab_4.Game.Entities;

public class Player : BaseEntity
{
    public int Level { get; private set; } = 1;

    public Player(string name) : base(name)
    {
    }

    public void LevelUp()
    {
        Level++;
        Health += 10;
        Console.WriteLine(
            $"{Name} has been level up!" +
            $", you gained 10 HP, your current health is {Health}," +
            $" your current level is {Level}");
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Level: {Level}");
        Console.WriteLine($"Health: {Health}");
    }

    public void AttackEnemy(Enemy enemy)
    {
        enemy.TakeDamage(10);
    }
}