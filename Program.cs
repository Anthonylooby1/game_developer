Console.WriteLine("Hello, World!");

Attack Fireball = new("Fireball", 20);
Attack DarkSpell = new("Dark Spell", 15);
Attack Boowomp = new("Boowomp",10);
Console.WriteLine($"Attack {Fireball.Name} did {Fireball.DamageAmount} damage");

Enemy Carl = new("Carl");
Magic Frank = new("Frank");
Range Reginold = new("Reginold");
Melee Gilbert = new("Gilbert");


Carl.AttackList.Add(Fireball);
Carl.AttackList.Add(DarkSpell);
Carl.AttackList.Add(Boowomp);



foreach(Attack type in Carl.AttackList)
{
    Console.WriteLine(type.Name);
}
Carl.RandomAttack();

Carl.PerformAttack(Carl,Fireball);

Reginold.Heal(Frank);

Frank.PerformAttack(Carl, Frank.AttackList[1]);

Frank.Dash();

Reginold.PerformAttack(Gilbert, Reginold.AttackList[0]);

Reginold.Heal(Frank);

Reginold.Heal(Reginold);

Gilbert.PerformAttack(Frank, Gilbert.AttackList[1]);

Frank.PerformAttack(Gilbert, Frank.AttackList[1]);
