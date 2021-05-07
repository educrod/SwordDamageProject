using System;

namespace SwordDamageProject
{
    class Program
    {
        static void Main(string[] args)
        {
            SwordDamage swordDamage = new SwordDamage();
            Random random = new Random();
            while (true)
            {
                Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
                char keyChar = Console.ReadKey(false).KeyChar;

                if (keyChar != '0' && keyChar != '1' && keyChar != '2' && keyChar != '3') return;

                int roll = random.Next(3, 18);

                swordDamage.Roll = roll;
                swordDamage.SetMagic(keyChar == '1' || keyChar == '3');
                swordDamage.SetFlaming(keyChar == '2' || keyChar == '3');

                Console.WriteLine($"\nRolled {roll} for {swordDamage.Damage} HP");
            }
        }
    }
}
