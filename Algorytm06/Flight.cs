namespace Algorytm6
{
    internal class Flight
    {
        internal string StartingAirport { get; private set; }

        internal string LandingAirport { get; private set; }

        internal int Cost { get; private set; }

        internal Flight(string startingAirport, string landingAirport, int cost)
        {
            this.StartingAirport = startingAirport;
            this.LandingAirport = landingAirport;
            this.Cost = cost;
        }

        public override string ToString()
        {
            return "Lot z: " + this.StartingAirport + " do " + this.LandingAirport + " o cenie " + this.Cost;
        }
    }
}