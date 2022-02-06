namespace POO_RPG.src.Entities
{
    public class Healer : Character
    {
        const int HP = 60;
        const int MP = 40;
        const int ClassBonusDamage = 25;
        const string Class = "Curandeiro";
        public void Heal()
        {
            Console.WriteLine($"O {Class} {getName()}, Nível: {Level}, curou {Intelligency * ClassBonusDamage + (Level * 5)} de HP");
        }
    }
}