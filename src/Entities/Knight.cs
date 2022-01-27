namespace POO_RPG.src.Entities
{
    public class Knight : Character
    {
        public Knight(string Name, int Level, int Strength, int Vitality, int Intelligency)
        {   
            this.Name = Name;
            this.Level = Level;
            this.Strength = Strength;
            this.Vitality = Vitality;
            this.Intelligency = Intelligency;
        }
        Random rnd = new Random();
        const int HP = 100;
        const int MP = 15;

        const int ClassBonusDamage = 20;
        const string Class = "Cavaleiro";

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
            if(rnd.Next(1, 10) > 7)
            {
                Console.WriteLine($"O {Class} {Name}, Nível: {Level}, bloqueou o golpe inimigo e contra-atacou causando {Strength * ClassBonusDamage + Level} de dano");
            }else
            {
                Console.WriteLine($"O {Class} {Name}, Nível: {Level}, atacou e causou {Strength * ClassBonusDamage + Level} de dano");
            }
        }

    }
}