using System;

public class Weapon
{
    public string name;
    private Random generator;
    public Weapon()
    {
        generator = new Random();
    }

    public int GetDamage()
    {
        return generator.Next(10, 20);
    }
}