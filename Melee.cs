using System.Runtime;

class Melee : Enemy
{
    // Attack Punch = new("punch", 20);
    // Attack Kick = new("kick",15);
    // Attack Tackle = new("tackle", 25);

    public Melee(string name) : base(name)
    {
        Name = name;
        Health = 120;
        AttackList = new List<Attack>()
        {
            new("tackle", 25),
            new("kick",15),
            new("punch", 20)
        };
    }

    public void Rage(Enemy Target, Attack ChosenAttack)
    {
        Target.Health = Target.Health - ChosenAttack.DamageAmount + 10;
        Console.WriteLine($"{Target.Name} lost {ChosenAttack.DamageAmount + 10} from Rage");
    }
}