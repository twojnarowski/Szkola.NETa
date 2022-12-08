using System;

namespace AlgorytmGenetyczny3
{
    internal class Path
    {
        private int currentIndex = 0;
        private int[] knapsack;
        internal static int[] knapsackValues;
        internal Path()
        {
            knapsack = new int[knapsackValues.Length];
        }

        internal void AddItem(int item)
        {
            knapsack[currentIndex] = item;
            currentIndex++;
        }

        internal int FitnessFunction()
        {
            int fitnessScore = 0;
            for (int i = 0; i < knapsackValues.Length; i++)
            {
                fitnessScore += knapsack[i] * knapsackValues[i];
            }
            return fitnessScore*3;
        }

        internal int[] GetKnapsack()
        {
            return this.knapsack;
        }

        internal string GetSubTable()
        {
            string result = string.Empty;
            for(int i = 0; i < knapsackValues.Length; i++)
            {
                if(knapsack[i] == 1)
                {
                    result += knapsackValues[i] + ",";
                }
            }
            return result;
        }
    }
}