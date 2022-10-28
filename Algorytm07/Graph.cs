using System;

namespace AlgorytmGenetyczny3
{
    internal class Graph
    {
        private Random rand;

        internal static string bestResult;

        internal static int bestValue = 0;

        private float[][] globalPheromoneLevels;

        private Path[] generatedPaths;

        private int numberOfAnts;

        private float pheromoneEvaporationRate;

        internal Graph(int numberOfPaths, float pheromoneEvaporationRate)
        {
            this.numberOfAnts = numberOfPaths;
            this.pheromoneEvaporationRate = pheromoneEvaporationRate;
            this.rand = new Random();

            this.globalPheromoneLevels = new float[Path.knapsackValues.Length][];
            for (int i = 0; i < Path.knapsackValues.Length; i++)
            {
                this.globalPheromoneLevels[i] = new float[2];
            }
            this.generatedPaths = new Path[this.numberOfAnts];
        }

        internal void RandomPheromoneGeneration()
        {
            for (int i = 0; i < Path.knapsackValues.Length; i++)
            {
                for (int b = 0; b < 2; b++)
                {
                    this.globalPheromoneLevels[i][b] = (float)rand.NextDouble();
                }
            }
        }

        internal void GeneratePathsForAnts()
        {
            this.generatedPaths = new Path[this.numberOfAnts];

            for (int ant = 0; ant < this.numberOfAnts; ant++)
            {
                this.generatedPaths[ant] = GeneratePath();
            }
        }

        internal Path GeneratePath()
        {
            Path path = new Path();

            for (int i = 0; i < Path.knapsackValues.Length; i++)
            {
                path.AddItem(SelectPath(i));
            }
            return path;
        }

        internal int SelectPath(int itemNumber)
        {
            float[] pheromoneLevels = globalPheromoneLevels[itemNumber];

            double pheromoneSum = 0.0;
            foreach (float f in pheromoneLevels)
            {
                pheromoneSum += Math.Abs(f);
            }

            double random = rand.NextDouble() * pheromoneSum;

            if (random <= Math.Abs(pheromoneLevels[0]))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        internal void AddNewPheromonesToPath()
        {
            for (int i = 0; i < this.numberOfAnts; i++)
            {
                Path currentPath = this.generatedPaths[i];

                int fitness = currentPath.FitnessFunction();

                int[] knapsackFromPath = currentPath.GetKnapsack();

                for (int path = 0; path < Path.knapsackValues.Length; path++)
                {
                    int currentItem = knapsackFromPath[path];
                    globalPheromoneLevels[path][currentItem] += fitness;
                }
            }
        }

        internal void EvaporatePheromoneForLinks()
        {
            for (int i = 0; i < Path.knapsackValues.Length; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    globalPheromoneLevels[i][j] *= this.pheromoneEvaporationRate;
                }
            }
        }

        internal void PrintFinalResult()
        {
            int averageSolutionFitness = 0;
            int min = int.MaxValue;
            int max = int.MinValue;
            string bestPath = "[]";

            for (int path = 0; path < this.numberOfAnts; path++)
            {
                Path currentPath = this.generatedPaths[path];
                int fitness = currentPath.FitnessFunction();
                averageSolutionFitness += fitness;

                if (fitness > max)
                {
                    max = fitness;
                    bestPath = currentPath.GetSubTable();
                }

                if (fitness < min)
                {
                    min = fitness;
                }

                if (max > bestValue)
                {
                    bestValue = max;
                    bestResult = "Suma: " + max / 3 + ", tablica: " + bestPath;
                }
            }

            averageSolutionFitness /= this.numberOfAnts;
        }
    }
}