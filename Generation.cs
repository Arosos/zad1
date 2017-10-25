using System;

namespace zad1
{
    public class Generation
    {
        public Individual[] population = new Individual[PopulationInfo.populationSize];
        public double sumfitness;

        public Generation(Individual[] population)
        {
            this.population = population;
            foreach (Individual i in population)
                sumfitness += i.fitness;
        }

        public static Generation FirstGeneration(int leftmost)
        {
            int x = leftmost;
            Individual[] population = new Individual[PopulationInfo.populationSize];
            for (int i = 0; i < PopulationInfo.populationSize; i++)
            {
                population[i] = new Individual(x, null, null);
                x++;
            }

            return new Generation(population);
        }

        public override string ToString()
        {
            string s = "";
            foreach(Individual i in population)
                s += i.ToString() + "\n";
            s += "Sumfitness: " + sumfitness;

            return s;
        }
    }
}