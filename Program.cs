Unit player = new Unit();
Unit enemy = new Unit();

Console.WriteLine($"Enemy Health: {enemy.Health}\nEnemy Shield: {enemy.Shield}\n");

Console.WriteLine($"Player attacks enemy for {player.Strength + 5} damage");
player.Attack(enemy, 5);
Console.WriteLine($"Enemy Health: {enemy.Health}\nEnemy Shield: {enemy.Shield}\n");

player.Strength += 2;
Console.WriteLine("Player gains 2 strength\n");

Console.WriteLine($"Player attacks enemy for {player.Strength + 5} damage");
player.Attack(enemy, 5);
Console.WriteLine($"Enemy Health: {enemy.Health}\nEnemy Shield: {enemy.Shield}\n");

Console.WriteLine($"Player attacks enemy for {player.Strength + 5} damage");
player.Attack(enemy, 5);
Console.WriteLine($"Enemy Health: {enemy.Health}\nEnemy Shield: {enemy.Shield}\n");

class Unit
{
    public Unit()
    {
        Health = 100;
        Shield = 7;
        Strength = 0;
        Dexterity = 0;
    }
    public int Health { get; set; }
    public int Shield { get; set; }
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public virtual void Attack(Unit unit, int damage)
    {
        int remainingDamage = damage + Strength - unit.Shield;
        unit.Shield -= damage + Strength;
        if (unit.Shield < 0)
        {
            unit.Shield = 0;
        }
        if (remainingDamage > 0)
        {
            unit.Health -= remainingDamage;
        }
    }

    public virtual void Defend(int defense)
    {
        Shield += defense + Dexterity;
    }
}