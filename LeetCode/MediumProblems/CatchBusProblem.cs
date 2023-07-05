namespace LeetCode.MediumProblems
{
    public class CatchBusProblem
    {
        public CatchBusProblem() { }

        public class BusPassenger
        {
            public int bus;
            public int capacity;
            public List<int> passengers;
        }

        public int LatestTimeCatchTheBus(int[] buses, int[] allPassengers, int capacity)
        {
            Array.Sort(buses);
            Array.Sort(allPassengers);

            List<int> passengers = allPassengers.ToList();
            List<BusPassenger> busPassengers = new List<BusPassenger>();
            for(int i = 0; i< buses.Length; i++)
            {
                List<int> currentPassenegers = passengers.Where(x => x <= buses[i]).OrderBy(x=>x).Take(capacity).ToList();
                passengers = passengers.Where(x => !currentPassenegers.Contains(x)).ToList();

                busPassengers.Add(new BusPassenger()
                {
                    bus = buses[i],
                    capacity = capacity,
                    passengers = currentPassenegers
                });
            }

            int answer = DeclareLatestTime(busPassengers);
            return answer;
        }

        public int DeclareLatestTime(List<BusPassenger> busPassengers)
        {
            BusPassenger lastBus = busPassengers.Last();

            bool maxCapacityMet = lastBus.passengers.Count == lastBus.capacity;

            int busCaughtTime = -1;
            if (maxCapacityMet)
            {
                
                foreach(int passenger in lastBus.passengers.OrderByDescending(x => x).ToList())
                {
                    if (busCaughtTime == -1) busCaughtTime = passenger - 1;
                    else if (busCaughtTime == passenger) busCaughtTime--;
                    else return busCaughtTime;
                }
            }
            else
            {
                busCaughtTime = lastBus.bus;
                foreach(int passenger in lastBus.passengers.OrderByDescending(x => x).ToList())
                {
                    if (passenger != busCaughtTime) return busCaughtTime;
                    else busCaughtTime--;
                }
            }
            return busCaughtTime;
        }
    }
}
