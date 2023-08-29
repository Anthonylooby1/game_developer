using System.Net.NetworkInformation;

class Magic : Enemy
{
    // Attack Arrow = new("Arrow", 20);
    // Attack Knife = new("Knife", 15);
    public int Distance;

    public Magic(string name) : base(name)
    {
        Name = name;
        Health = 100;
        AttackList = new List<Attack>()
        {
            new("Knife", 15),
            new("Arrow", 20)
        };
    }

    public override void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        if( Distance < 20)
        {
            Console.WriteLine("You are too close!");
        } else {
            Console.WriteLine($"{Name} did {ChosenAttack.Name} for {ChosenAttack.DamageAmount} on {Target.Name}");
        }
    }

    public void Dash()
    {
        if( Distance < 20)
        {
            Distance = 20;
        }
        Console.WriteLine($"{Name} has set their distance to 20!");
    }
}