namespace LeetCode.EasyProblems
{
    public class ClimbStairsProblem
    {

        public ClimbStairsProblem() { }

        public int GetPossibleRoutes(int stairs)
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
