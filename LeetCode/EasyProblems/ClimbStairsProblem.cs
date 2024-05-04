namespace LeetCode.EasyProblems
{
    public class ClimbStairsProblem
    {

        public ClimbStairsProblem() { }

        public int GetPossibleRoutes(int stairs)
        {
            Dictionary<int, int> mapping = new Dictionary<int, int>();
            mapping.Add(1, 1);
            mapping.Add(2, 2);

            for (int i = 3; i <= stairs; i++)
            {
                mapping[i] = mapping[i - 1] + mapping[i - 2];
            }
            return mapping[stairs];
        }

        public int GetPossibleRoutes2(int stairs)
        {
            if (stairs <= 3) return stairs;

            int routesTwoAgo = 2;
            int routesOneAgo = 3;

            int currentRoutes = routesTwoAgo + routesOneAgo;
            for (int i = 4; i <= stairs; i++)
            {
                currentRoutes = routesTwoAgo + routesOneAgo;
                routesTwoAgo = routesOneAgo;
                routesOneAgo = currentRoutes;

            }
            return currentRoutes;
        }

        
    }
}
