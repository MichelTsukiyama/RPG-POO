namespace POO_RPG.src.Entities
{
    public class Mage : Character
    {
        const int HP = 50;
        const int MP = 120;

        const int ClassBonusDamage = 28;
        const string Class = "Mago";

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
            Console.WriteLine($"O {Class} {getName()}, Nível: {Level}, atacou e causou {Intelligency * ClassBonusDamage + Level} de dano");
        }
    }
}