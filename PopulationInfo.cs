using System;

namespace zad1
{
    public static class PopulationInfo
    {
        public const int maxPopulation = 100, maxString = 30, generationNumber = 30;
        public const double pcross = 0.5, pmutation = 0.001;

        public static int populationSize, stringSize, translation, leftmost;
        static double[] coefficients;

        public static void GetInfo(string[] args)
        {
            leftmost = int.Parse(args[0]);
            int right = int.Parse(args[1]);

            populationSize = right - leftmost + 1;
            for (int i = 0; i < 10; i++)
                if (Math.Pow(2, i) > populationSize)
                {
                    stringSize = i;
                    break;
                }

            int functionDegree = args.Length - 2;
            coefficients = new double[functionDegree];

            for (int i = 0, argsIndex = 2; i < functionDegree; i++, argsIndex++)
            {
                if (args[argsIndex] != null)
                    coefficients[i] = double.Parse(args[argsIndex]);
                else
                    break;
            }

            if (leftmost < 0)
                translation = Math.Abs(leftmost);
        }

        public static double Function(int x)
        {
            double sum = 0.0;

            for (int i = 0; i < coefficients.Length; i++)
            {
                sum += Math.Pow(x, coefficients.Length - i - 1) * coefficients[i];
            }

            return sum;
        }
    }
}