// See https://aka.ms/new-console-template for more information
using Cards.Strategy.Card;

SmallBasicBattleTest();

int y = Console.Read();

static void SmallBasicBattleTest()
{
    Console.WriteLine("A small battle test:");

    Pawn enemy = new Pawn("Enemy Cultist", "basic enemy", 3, 1);
    Pawn myCultist = new Pawn("Loyal Cultist", "basic pawn", 4, 2);
    WhiteBishop myPriest = new WhiteBishop("Holy father", "Local Priest", 1);

    myPriest.ApplyEffectToOpponent(enemy);
    enemy.InflictDamage(myCultist);
    myCultist.InflictDamage(enemy);

    Console.WriteLine($"{enemy.Name} has {enemy.HealthScore} health");
    Console.WriteLine($"{myCultist.Name} has {myCultist.HealthScore} health");

    enemy.InflictDamage(myCultist);
    myCultist.InflictDamage(enemy);

    Console.WriteLine($"{enemy.Name} has {enemy.HealthScore} health");
    Console.WriteLine($"{myCultist.Name} has {myCultist.HealthScore} health");
}