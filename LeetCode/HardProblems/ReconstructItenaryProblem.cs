namespace LeetCode.HardProblems
{
    public class ReconstructItenaryProblem
    {
        public class Trip
        {
            public string departure;
            public string arrival;
            public int lexCode;
            public int order;
        }
        
        public ReconstructItenaryProblem() { }


        public IList<string> FindItinerary(IList<IList<string>> tickets)
        {
            Dictionary<string, List<string>> trips = new Dictionary<string, List<string>>();

            foreach (var ticket in tickets)
            {
                if (!trips.ContainsKey(ticket[0]))
                {
                    trips[ticket[0]] = new List<string>();
                }
                trips[ticket[0]].Add(ticket[1]);
            }
            foreach (var list in trips.Values)
                list.Sort(StringComparer.Ordinal);

            List<string> itinerary = new List<string>();

            DFS(trips, "JFK", tickets.Count + 1, itinerary);
            return itinerary;
        }

        private bool DFS(Dictionary<string, List<string>> trips, string rootTrip, int maxCount, List<string> itinerary)
        {
            itinerary.Add(rootTrip);
            if (maxCount == 1) return true;

            if (trips.ContainsKey(rootTrip))
            {
                List<string> children = trips[rootTrip].ToList();
                foreach (var child in children)
                {
                    trips[rootTrip].Remove(child);
                    bool validChild = DFS(trips, child, maxCount-1, itinerary);
                    if (validChild) return true;
                    trips[rootTrip].Add(child);

                }
            }

            itinerary.RemoveAt(itinerary.Count - 1);
            return false;
        }
        //public IList<string> FindItenary(IList<IList<string>> tickets)
        //{
        //    List<Trip> trips = new List<Trip>();
        //    IList<string> itenary = new List<string>() { "JFK" };
        //    foreach (var ticket in tickets)
        //    {
        //        trips.Add(new Trip()
        //        {
        //            departure = ticket[0],
        //            arrival = ticket[1],
        //            lexCode = ticket[0].Sum(x => (int)x) + ticket[1].Sum(x => (int)x),
        //            order = -1
        //        });
        //    }

        //    trips.Where(x => x.departure == "JFK").OrderBy(x => x.lexCode).First().order = 0;
        //    for (int i = 0; i < trips.Count - 1; i++)
        //    {
        //        Trip trip = trips.Where(x => x.order == i).First();
        //        trips.Where(x => x.departure == trip.arrival).Where(x => x.order == -1).OrderBy(x => x.lexCode).First().order = i + 1;
        //    }

        //    trips = trips.OrderBy(x => x.order).ToList();

        //    foreach (var trip in trips)
        //    {
        //        itenary.Add(trip.arrival);
        //    }
        //    return itenary;
        //}
    }
}
