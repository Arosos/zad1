using System;
using System.Collections;

namespace zad1
{
    public class Individual
    {
        public BitArray chromosome;
        public int x;
        public double fitness;
        public Individual parent1, parent2;

        public Individual(int x, Individual parent1, Individual parent2)
        {
            chromosome = Encode(x);
            chromosome.Length = PopulationInfo.stringSize;
            Reverse();
            this.x = x;
            fitness = PopulationInfo.Function(x);
            this.parent1 = parent1;
            this.parent2 = parent2;
        }

        public Individual(BitArray chromosome, Individual parent1, Individual parent2)
        {
            this.chromosome = chromosome;
            this.parent1 = parent1;
            this.parent2 = parent2;
        }

        BitArray Encode(int x)
        {
            BitArray bitArray;
            if (PopulationInfo.translation == 0)
                bitArray = new BitArray(new int[1] { x });
            else
            {
                x += PopulationInfo.translation;
                bitArray = new BitArray(new int[1] { x });
            }
            return bitArray;
        }

        public override string ToString()
        {
            string chromosome = "";

            foreach (bool bit in this.chromosome)
                chromosome += bit ? "1" : "0";
            string parents = (parent1 == null ? "null" : parent1.x.ToString()) + " " + (parent2 == null ? "null" : parent2.x.ToString());
            return "Chromosome: " + chromosome + " " + "X: " + x + " " + "Fitness: " + Math.Round(fitness, 10) + " " + parents;
        }

        void Reverse()
        {
            BitArray tempArray = new BitArray(chromosome);
            for (int i = 0; i < chromosome.Count; i++)
                tempArray[i] = chromosome[chromosome.Count - i - 1];
            chromosome = tempArray;
        }

        public Individual Cross(Individual otherParent, int cross, out Individual child2)
        {
            BitArray newChromosome2 = new BitArray(PopulationInfo.stringSize);
            for (int i = 0; i < cross + 1; i++)
                newChromosome2[i] = otherParent.chromosome[i];
            for (int i = cross + 1; i < PopulationInfo.stringSize; i++)
                newChromosome2[i] = chromosome[i];
            child2 = new Individual(newChromosome2, this, otherParent);

            BitArray newChromosome1 = new BitArray(PopulationInfo.stringSize);
            for (int i = 0; i < cross + 1; i++)
                newChromosome1[i] = chromosome[i];
            for (int i = cross + 1; i < PopulationInfo.stringSize; i++)
                newChromosome1[i] = otherParent.chromosome[i];
            return new Individual(newChromosome1, this, otherParent);
        }
    }
}