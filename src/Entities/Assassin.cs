using System;

namespace POO_RPG.src.Entities
{
    public class Assassin : Character
    {
        Random rnd = new Random();
        const int HP = 55;
        const int MP = 10;

        const int ClassBonusDamage = 32;
        const int CriticalBonus = 25;
        const string Class = "Assassino";

        public override void Status()
        {
            Console.WriteLine($"Nome: {getName()}");
            Console.WriteLine($"Nível: {Level}");
            Console.WriteLine($"Classe: {Class}");
            Console.WriteLine($"HP: {(Vitality + Level) * HP}");
            Console.WriteLine($"MP: {(Intelligency + Level) * MP}"); 
            Console.WriteLine(""); 
        }

        public override void Attack()
        {
            if (rnd.Next(1, 10) > 5)
            {
            Console.WriteLine($"O {Class} {getName()}, Nível: {Level}, atacou e causou {Strength * ClassBonusDamage + Level * CriticalBonus} de dano crítico");
            } else
            {
            Console.WriteLine($"O {Class} {getName()}, Nível: {Level}, atacou e causou {Strength * ClassBonusDamage + Level} de dano ");
            }
        }
    }
}