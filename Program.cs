// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Attack Fireball = new("Fireball", 20);
Attack DarkSpell = new("Dark Spell", 15);
Attack Boowomp = new("Boowomp",10);
Console.WriteLine($"Attack {Fireball.Name} did {Fireball.DamageAmount} damage");

Enemy Carl = new("Carl");


Carl.AttackList.Add(Fireball);
Carl.AttackList.Add(DarkSpell);
Carl.AttackList.Add(Boowomp);


foreach(Attack type in Carl.AttackList)
{
    Console.WriteLine(type.Name);
}
Carl.RandomAttack();
