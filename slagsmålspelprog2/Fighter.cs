using System;

public class Fighter
{
    public string name;
    public int hp = 100;


    public Weapon weapon;

    public void Attack(Fighter target)
    {
        int damage = weapon.GetDamage();
        target.hp -= damage;
        target.hp = Math.Max(0, target.hp);
        Console.WriteLine($"{name} gör {damage} i skada på {target} med {weapon.name}");

    }
}

