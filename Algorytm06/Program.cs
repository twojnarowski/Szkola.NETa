using System.Text;
using Algorytm6;

namespace ALgorytm6
{
    internal class Algorytm6
    {
        private static List<(string, int)> GoodPaths;

        private static int maxFlights;

        public static void Main(string[] args)
        {
            Console.WriteLine("Symulator lotniska!");
            Connections.Add(new Flight("JFK", "ATL", 150));
            Connections.Add(new Flight("ATL", "SFO", 400));
            Connections.Add(new Flight("ORD", "LAX", 200));
            Connections.Add(new Flight("LAX", "DFW", 80));
            Connections.Add(new Flight("JFK", "HKG", 800));
            Connections.Add(new Flight("ATL", "ORD", 90));
            Connections.Add(new Flight("JFK", "LAX", 500));
            Console.WriteLine("Podaj lotnisko początkowe!");
            string start = Console.ReadLine().ToUpper();
            if (!Connections.GetConnections().Select(x => x.StartingAirport).Contains(start))
            {
                Console.WriteLine("Nie ma takiego lotniska początkowego");
                return;
            }

            Console.WriteLine("Podaj lotnisko docelowe!");
            string finish = Console.ReadLine().ToUpper();
            if (!Connections.GetConnections().Select(x => x.LandingAirport).Contains(finish))
            {
                Console.WriteLine("Nie ma takiego lotniska docelowego");
                return;
            }

            Console.WriteLine("Podaj maksymalną liczbę lotów!");
            string temp = new(Console.ReadLine().Where(x => char.IsDigit(x)).ToArray());
            maxFlights = Convert.ToInt32(temp);

            GoodPaths = new List<(string, int)>();

            foreach (Flight flight in Connections.GetNextFlights(start))
            {
                List<(int index, Flight flight)> path = new();
                path.Add((0, flight));
                int lastStop = path.Max(x => x.index);
                if (path.Single(x => x.index == lastStop).flight.LandingAirport == finish)
                {
                    GoodPaths.Add((flight.ToString(), flight.Cost));
                    break;
                }
                else
                {
                    GeneratePaths(0, finish, path);
                }
            }
            var bestPath = GoodPaths.OrderBy(x => x.Item2).First();
            Console.WriteLine(bestPath.Item1 + " koszt: " + bestPath.Item2);
        }

        public static void GeneratePaths(int iteration, string finish, List<(int index, Flight flight)> path)
        {
            iteration++;
            if (iteration > maxFlights - 1)
            {
                return;
            }
            int lastStop = path.Max(x => x.index);
            foreach (Flight flight in Connections.GetNextFlights(path.Single(x => x.index == iteration - 1).flight.LandingAirport))
            {
                List<(int index, Flight flight)> newPath = new(path);
                newPath.Add((iteration, flight));
                if (newPath.Single(x => x.index == lastStop + 1).flight.LandingAirport == finish)
                {
                    StringBuilder buildPath = new();
                    buildPath.Append("Najlepsza trasa: ");
                    buildPath.Append(path.First().flight.StartingAirport + " -> ");
                    foreach ((int index, Flight stop) in newPath)
                    {
                        buildPath.Append(stop.LandingAirport + " -> ");
                    }
                    GoodPaths.Add((buildPath.ToString(), newPath.Sum(x => x.flight.Cost)));
                    break;
                }
                else
                {
                    GeneratePaths(iteration, finish, newPath);
                }
            }
        }
    }
}