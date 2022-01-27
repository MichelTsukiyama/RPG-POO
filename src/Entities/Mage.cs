namespace POO_RPG.src.Entities
{
    public class Mage : Character
    {
        public Mage(string Name, int Level, int Strength, int Vitality, int Intelligency)
        {   
            this.Name = Name;
            this.Level = Level;
            this.Strength = Strength;
            this.Vitality = Vitality;
            this.Intelligency = Intelligency;
        }
        const int HP = 50;
        const int MP = 120;

        const int ClassBonusDamage = 28;
        const string Class = "Mago";

        public override void Status()
        {
            Console.WriteLine($"Nome: {Name}");
            Console.WriteLine($"Nível: {Level}");
            Console.WriteLine($"Classe: {Class}");
            Console.WriteLine($"HP: {(Vitality + Level) * HP}");
            Console.WriteLine($"MP: {(Intelligency + Level) * MP}");  
            Console.WriteLine(""); 
        }

        public override void Attack()
        {
            Console.WriteLine($"O {Class} {Name}, Nível: {Level}, atacou e causou {Intelligency * ClassBonusDamage + Level} de dano");
        }
    }
}