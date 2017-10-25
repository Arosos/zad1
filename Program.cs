using System;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            PopulationInfo.GetInfo(args);
            Generation[] generations = new Generation[PopulationInfo.generationNumber];

            generations[0] = Generation.FirstGeneration(PopulationInfo.leftmost);

            Console.WriteLine(generations[0]);

            Individual t1 = Genetics.Select(generations[0]);
            Individual t2 = Genetics.Select(generations[0]);

            Console.WriteLine(t1);
            Console.WriteLine(t2);

            Individual c1, c2;
            Genetics.Crossover(t1, t2, out c1, out c2);

            Console.WriteLine(c1);
            Console.WriteLine(c2);

            for (int i = 1; i < PopulationInfo.generationNumber; i++)
            {

            }

            Console.ReadKey();
        }
    }
}