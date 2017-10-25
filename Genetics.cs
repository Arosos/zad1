using System;

namespace zad1
{
    public static class Genetics
    {
        static Random random = new Random();

        public static Individual Select(Generation generation)
        {
            double rand = random.NextDouble() * generation.sumfitness;
            int j = -1;
            double partsum = 0.0;
            do
            {
                j++;
                partsum += generation.population[j].fitness;
            } while (partsum < rand && j != PopulationInfo.populationSize);
            
            return generation.population[j];
        }

        public static void Crossover(Individual parent1, Individual parent2, out Individual child1, out Individual child2)
        {
            int jcross;
            if (Flip(PopulationInfo.pcross))
                jcross = random.Next(0, PopulationInfo.stringSize - 1);
            else
                jcross = PopulationInfo.stringSize - 1;
            child1 = parent1.Cross(parent2, jcross, out child2);
            Console.WriteLine(jcross);
        }

        public static void Mutation(Individual i)
        {
            if (Flip(PopulationInfo.pmutation))
            {
                int jmutation = random.Next(0, PopulationInfo.stringSize);
                i.chromosome[jmutation] = !i.chromosome[jmutation];
                Console.WriteLine("Mutation at " + jmutation);
            }
        }

        static bool Flip(double p) => p > random.NextDouble();
    }
}