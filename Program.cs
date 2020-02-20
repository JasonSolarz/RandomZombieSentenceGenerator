using System;
using System.IO;

namespace RandomSent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------/Random Sentence Generator/---------\n");

            string[] areaDescription = File.ReadAllLines("ZombieAreaDescription.txt");
            string[] abjectives = File.ReadAllLines("ZombieAbjectives.txt");
            string[] types = File.ReadAllLines("ZombieTypes.txt");
            string[] verbs = File.ReadAllLines("ZombieVerbs.txt");

            Random rand = new Random();

            string description;
            string abjective;
            string type;
            string verb;

            for (int LCV = 0; LCV < 20; LCV++)
            {
                description = areaDescription[rand.Next(1, areaDescription.Length)];
                abjective = abjectives[rand.Next(1, abjectives.Length)];
                type = types[rand.Next(1, types.Length)];
                verb = verbs[rand.Next(1, verbs.Length)];

                Console.WriteLine("A " + abjective + " " + type + " zombie " + verb + " into the " + description + " street");
            }


            /*
            Console.WriteLine("\n---/Area Description/---");
            foreach(string line in areaDescription)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("\n---/Abjectives/---");

            foreach(string line in abjectives)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("\n---/Types/---");

            foreach(string line in types)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("\n---/Verbs/---");

            foreach(string line in verbs)
            {
                Console.WriteLine(line);
            }
            */
        }
    }
}
