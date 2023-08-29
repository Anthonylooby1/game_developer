// using System.Security.Cryptography.X509Certificates;

class Enemy
{
    public string Name;
    public int Health;
    public List<Attack> AttackList;

    public Enemy(string name)
    {
        Name = name;
        Health = 100;
        AttackList = new List<Attack>();
    }

    public void RandomAttack()
    {
        Random attack = new();
        int random = attack.Next(0,3);
        Console.WriteLine($"{Name} hit you with {AttackList[random].Name} for {AttackList[random].DamageAmount} damage.");
    }

    public virtual void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        Target.Health = Health - ChosenAttack.DamageAmount;
        Console.WriteLine($"{Target.Name} lost {ChosenAttack.DamageAmount} health from {ChosenAttack.Name}");
    } 
}