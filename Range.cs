class Range : Enemy
{
    // Attack Fireball = new("Fireball", 25);
    // Attack Lightening = new("Lightening Bold", 20);
    // Attack Strike = new("Staff Strike", 10);


    public Range(string name) : base(name)
    {
        Name= name;
        Health = 80;
        AttackList = new List<Attack>()
        {
            new("Fireball", 25),
            new("Lightening Bold", 20),
            new("Staff Strike", 10)
        };
    }

    public void Heal(Enemy Target)
    {
        Health = Target.Health + 40;
        Console.WriteLine($"{Target.Name} has been healed for 40! {Target.Name}'s Health is now {Health}");
    }
}