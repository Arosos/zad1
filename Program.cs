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

            

            /*for (int i = 1; i < PopulationInfo.generationNumber; i++)
            {

            }*/

            Console.ReadKey();
        }
    }
}