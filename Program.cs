using System;
using System.Windows.Forms;

namespace zad1
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            PopulationInfo.GetInfo(args);
            Generation[] generations = new Generation[PopulationInfo.generationNumber];

            generations[0] = Generation.FirstGeneration(PopulationInfo.leftmost);

            Console.WriteLine(generations[0]);

            for (int i = 1; i < PopulationInfo.generationNumber; i++)
            {
                Generation generation = generations[i - 1];
                Individual[] population = new Individual[PopulationInfo.populationSize];
                for (int j = 0; j < PopulationInfo.populationSize; j += 2)
                {
                    Individual parent1 = Genetics.Select(generation);
                    Individual parent2 = Genetics.Select(generation);
                    Individual child1, child2;
                    Genetics.Crossover(parent1, parent2, out child1, out child2);
                    Genetics.Mutation(child1);
                    Genetics.Mutation(child2);
                    population[j] = child1;
                    population[j + 1] = child2;
                }
                generations[i] = new Generation(population);
            }

            foreach (Generation g in generations)
                Console.WriteLine(g);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Chart());
        }
    }
}