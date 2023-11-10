Unit player = new Unit(100, 0, 0, 0);
Unit enemy = new Unit(100, 7, 0, 0);

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
    public Unit(int Health, int Shield, int Strength, int Dexterity)
    {
        this.Health = Health;
        this.Shield = Shield;
        this.Strength = Strength;
        this.Dexterity = Dexterity;
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