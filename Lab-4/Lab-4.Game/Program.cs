using Lab_4.Game.Entities;

var player = new Player("Ferhad");
var enemy = new Enemy("Orc");
var npc = new Npc("Zakir");

while (true)
{
    Console.WriteLine("Choose an option:");
    Console.WriteLine("""
                       1. Player
                       2. Enemy
                       3. Npc
                       
                       0. Exit
                      """);
    int choice = int.Parse(Console.ReadLine() ?? "0");
    switch (choice)
    {
        case 1:
            Console.WriteLine("Chose an action");
            Console.WriteLine("""
                               1.Level Up
                               2.Attack Enemy
                               3. Show Details
                               
                               0. Exit
                              """);
            int innerChoice = int.Parse(Console.ReadLine() ?? "0");
            switch (innerChoice)
            {
                case 1:
                    player.LevelUp();
                    break;
                case 2:
                    player.AttackEnemy(enemy);
                    break;
                case 3:
                    player.ShowDetails();
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Wrong choice, try again");
                    break;
            }

            break;
        case 2:
            Console.WriteLine("Chose an action");
            Console.WriteLine("""
                               1.Attack Player
                               
                               0. Exit
                              """);
            int innerChoiceEnemy = int.Parse(Console.ReadLine() ?? "0");
            switch (innerChoiceEnemy)
            {
                case 1:
                    enemy.AttackPlayer(player);
                    break;
                case 2:
                    return;
                default:
                    Console.WriteLine("Wrong choice, try again");
                    break;
            }

            break;
        case 3:
            Console.WriteLine("Chose and action");
            Console.WriteLine("""
                               1.Talk
                               
                               0. Exit
                              """);
            int innerChoiceNpc = int.Parse(Console.ReadLine() ?? "0");
            switch (innerChoiceNpc)
            {
                case 1:
                    npc.Talk();
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Wrong choice, try again");
                    break;
            }

            break;
        case 4:
            return;
        default:
            Console.WriteLine("Wrong choice, try again");
            break;
    }
}