using System;

namespace zad1
{
    public class Generation
    {
        public Individual[] population;
        public double sumfitness, average, min, max;

        public Generation(Individual[] population)
        {
            this.population = population;
            min = double.MaxValue;
            max = double.MinValue;
            foreach (Individual i in this.population)
            {
                sumfitness += i.fitness;
                if (i.fitness < min)
                    min = i.fitness;
                if (i.fitness > max)
                    max = i.fitness;
            }
            average = sumfitness / population.Length;
        }

        public static Generation FirstGeneration(int leftmost)
        {
            int x = leftmost;
            Individual[] population = new Individual[PopulationInfo.firstGenerationSize];
            for (int i = 0; i < PopulationInfo.firstGenerationSize; i++)
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
            s += "\nAverage value: " + average;
            s += "\nMax value: " + max;
            s += "\nMin value: " + min;
            s += "\n==============================================================";

            return s;
        }
    }
}