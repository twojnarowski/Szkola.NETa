using System;
using System.Diagnostics;

namespace AlgorytmGenetyczny3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Path.knapsackValues = new int[] { -1, 7, 2, -1, 3, -8, -2, -5, 5, 4, -6, 8, 0, -10, 2, -7, 10, 4, -8, -9, -1, 0, 7, -10, 6, 9, -9, -7, 8, 8, -3, 1, 2, -2, 1, 4, 1, 10, -2, 0, -2, 5, 9, -7, 3, 5, 10, -10, -9, 10, -3, -4, 3, -10, -6, -8, -6, 1 };
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int numberOfAnts = 5000;
            float pheromoneEvaporationRate = 2.0f;
            Calculate5Populations(numberOfAnts, pheromoneEvaporationRate);
            Console.WriteLine(Graph.bestResult);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            Console.WriteLine("Done");
            Console.ReadLine();
        }

        private static void Calculate5Populations(int numberofAnts, float pheromoneEvaporationRate)
        {
            int numberOfPopulations = 100;
            int numberOfEvaluations = 20000 / numberofAnts;

            for (int trial = 0; trial < numberOfPopulations; trial++)
            {
                Graph graph = new Graph(numberofAnts, pheromoneEvaporationRate);
                graph.RandomPheromoneGeneration();
                for (int i = 0; i < numberOfEvaluations; i++)
                {
                    graph.GeneratePathsForAnts();
                    graph.AddNewPheromonesToPath();
                    graph.EvaporatePheromoneForLinks();
                }
                graph.PrintFinalResult();
            }
        }
    }
}