using System;

Fighter player = new Fighter();
player.name = "Lucas";
player.weapon = new Weapon();
player.weapon.name = "Super coola Lukis svärdet";

Fighter enemy = new Fighter();
enemy.name = "Freja";
enemy.weapon = new Weapon();
enemy.weapon.name = "Den bästa Freja kniven";

Random generator = new Random();

ConsoleKey k;

while (player.hp > 0 && enemy.hp > 0)
{
    Console.WriteLine("----------Ny runda startas----------");
    Console.WriteLine($"{player.name}: {player.hp} || {enemy.name}: {enemy.hp}");

    player.Attack(enemy);
    enemy.Attack(player);

    Console.WriteLine("Tryck på SPACE för att fortsätta");
    k = ConsoleKey.A;
    while (k != ConsoleKey.Spacebar)
    {
        k = Console.ReadKey().Key;
    }
}

Console.WriteLine("----------Fighten är slut----------");

if (player.hp == 0 && enemy.hp == 0)
{
    Console.WriteLine("Det blev oavgjort!");
}

else if (player.hp == 0)
{
    Console.WriteLine($"{enemy.name} vann fighten!");
}

else
{
    Console.WriteLine($"{player.name} vann fighten!");
}

Console.WriteLine("Tryck på SPACE för att avsluta");
k = ConsoleKey.A;
while (k != ConsoleKey.Spacebar)
{
    k = Console.ReadKey().Key;
}
