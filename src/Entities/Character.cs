namespace POO_RPG.src.Entities
{
    public abstract class Character
    {
        public Character(string Name, int Level, int Strength, int Vitality, int Intelligency)
        {   
            this.Name = Name;
            this.Level = Level;
            this.Strength = Strength;
            this.Vitality = Vitality;
            this.Intelligency = Intelligency;
        }

        public Character()
        {

        }
        public string Name;
        public int Level;
        public int Strength; 
        public int Vitality;
        public int Intelligency;

        public virtual void Attack()
        {
            Console.WriteLine($"{Name}, Nível: {Level}, atacou e causou {Level} de dano");
        }

        public virtual void Status()
        {
            Console.WriteLine($"Nome: {Name}");
            Console.WriteLine($"Nível: {Level}");
            Console.WriteLine($"Força: {Strength}");
            Console.WriteLine($"Inteligência: {Intelligency}");
            Console.WriteLine($"HP: {Vitality * Level}");
            Console.WriteLine($"MP: {Intelligency * Level}");  
        }


    }
}