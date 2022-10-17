namespace Algorytm6
{
    internal static class Connections
    {
        private static List<Flight> listOfConnections = new List<Flight>();

        internal static List<Flight> GetNextFlights(string start)
        {
            return listOfConnections.Where(x => x.StartingAirport == start).ToList();
        }

        internal static void Add(Flight flight)
        {
            listOfConnections.Add(flight);
        }

        internal static List<Flight> GetConnections()
        {
            return listOfConnections;
        }
    }
}