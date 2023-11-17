using System;

Fighter hero = new Fighter();
hero.name = "Ice";
hero.weapon = new Weapon();
hero.weapon.name = "Munchy";

Fighter villain = new Fighter();
villain.name = "Anty";
villain.weapon = new Weapon();
villain.weapon.name = "Lunchy";


Random generator = new Random();

while (hero.hp > 0 && villain.hp > 0)
{
  Console.WriteLine("\n----- ===== New round ===== -----");
  Console.WriteLine($"{hero.name}: {hero.hp} || {villain.name}: {villain.hp}\n");

  hero.Attack(villain);
  villain.Attack(hero);

  Console.WriteLine("Press any key to continue");
  Console.ReadKey();
}

Console.WriteLine("The fight is over");

if (hero.hp == 0 && villain.hp == 0)
{
  Console.WriteLine("It is a draw");
}
else if (hero.hp == 0)
{
  Console.WriteLine($"{villain.name} won the fight!");
}
else
{
  Console.WriteLine($"{hero.name} won the fight!");
}

Console.WriteLine("Press any key to end the game");
Console.ReadKey();