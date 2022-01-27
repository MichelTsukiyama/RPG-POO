using System;
using POO_RPG.src.Entities;

namespace POO_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arthur = new Knight("Arthur", 10, 15, 10, 5);
            arthur.Attack();
            arthur.Status();

            Assassin zodiaco = new Assassin("Zodiaco", 10, 20, 5, 5);
            zodiaco.Attack();
            zodiaco.Attack();
            zodiaco.Attack();
            zodiaco.Status();

            Mage merlin =new Mage("Merlin", 10, 1, 10, 19);
            merlin.Attack();
            merlin.Status();

            Healer frei = new Healer("Frei", 10, 1, 14, 15);
            frei.Heal();
            frei.Status();

            // Character teste = new Character("teste", 10, 10, 10, 10); Classe abstrata não pode ser instanciada
        }
    }
}
