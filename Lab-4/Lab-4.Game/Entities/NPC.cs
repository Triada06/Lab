using Lab_4.Game.Base;

namespace Lab_4.Game.Entities;

public class Npc : BaseEntity
{
    public Npc(string name) : base(name)
    {
    }

    public void Talk()
    {
        Console.WriteLine($"Welcome {Name}, how may i assist you?");
    }
}