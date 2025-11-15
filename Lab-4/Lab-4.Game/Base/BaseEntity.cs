namespace Lab_4.Game.Base;

public abstract class BaseEntity
{
    public string Name { get; set; }
    public int Health { get; set; } = 100;

    public BaseEntity(string name)
    {
        Name = name;
    }

    public void Move()
    {
        Console.WriteLine($"the {Name} is moving");
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            Console.WriteLine($"{Name} is dead");
            return;
        }

        Console.WriteLine($"{Name} took {damage} damage, health is {Health}");
    }
}