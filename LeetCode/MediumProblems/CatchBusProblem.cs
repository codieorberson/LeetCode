using System.Linq;

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

            int answer = DeclareLatestTime(busPassengers, allPassengers);
            return answer;
        }
        public int DeclareLatestTime(List<BusPassenger> busPassengers, int[] allPassenegers)
        {
            int latestTime = -1;
            int capacity = busPassengers[0].capacity;

            bool fullBus = false;


            
            for(int i = busPassengers.Count -1; i>=0; i--)
            {
                List<int> currentBusPassengers = busPassengers[i].passengers;
                if (currentBusPassengers.Count == 0) return busPassengers[i].bus;
                else if (!fullBus && currentBusPassengers.Count == capacity)
                {
                    int? caughtBus = UserCatchFullBus(currentBusPassengers, busPassengers[i].bus);
                    if (caughtBus != null && !allPassenegers.Contains((int)caughtBus))
                    {
                        return (int)caughtBus;
                    }

                    fullBus = true;
                }
                else
                {
                    int? caughtBus = UserSitAnywhere(currentBusPassengers, busPassengers[i].bus);
                    if (caughtBus != null && !allPassenegers.Contains((int)caughtBus)) return (int)caughtBus;
                    fullBus = true;
                }
            }

            return -1;
        }

        public int? UserSitAnywhere(List<int> currentPassengers, int busCaughtTime)
        {
            int? returnValue = null;
            currentPassengers = currentPassengers.OrderByDescending(x => x).ToList();
            foreach (int passenger in currentPassengers)
            {
                if (passenger != busCaughtTime) return busCaughtTime;
                else busCaughtTime--;
            }
            return returnValue;

        }
        public int? UserCatchFullBus(List<int> currentPassengers, int busCaughtTime)
        {
            int? returnValue = null;
            currentPassengers = currentPassengers.OrderByDescending(x => x).ToList();

            int firstPassenger = currentPassengers[currentPassengers.Count - 1];
            int tempBusCaughtTime = -1;
            foreach (int passenger in currentPassengers)
            {
                if (tempBusCaughtTime == -1) tempBusCaughtTime = passenger - 1;
                else if (tempBusCaughtTime == passenger) tempBusCaughtTime--;
                else return tempBusCaughtTime;
            }
            if (tempBusCaughtTime < firstPassenger) return tempBusCaughtTime;

            return returnValue;

        } 
        public int DeclareLatestTime2(List<BusPassenger> busPassengers)
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
