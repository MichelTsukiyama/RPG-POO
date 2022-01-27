namespace POO_RPG.src.Entities
{
    public class Healer : Character
    {
        public Healer(string Name, int Level, int Strength, int Vitality, int Intelligency)
        {   
            this.Name = Name;
            this.Level = Level;
            this.Strength = Strength;
            this.Vitality = Vitality;
            this.Intelligency = Intelligency;
        }
        const int HP = 60;
        const int MP = 40;

        const int ClassBonusDamage = 25;
        const string Class = "Curandeiro";

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
            Console.WriteLine($"O {Class} {Name}, Nível: {Level}, causou {Intelligency * ClassBonusDamage + Level} de dano");
        }

        public void Heal()
        {
            Console.WriteLine($"O {Class} {Name}, Nível: {Level}, curou {Intelligency * ClassBonusDamage + (Level * 5)} de HP");
        }
    }
}