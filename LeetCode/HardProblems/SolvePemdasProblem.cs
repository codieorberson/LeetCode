using System.Data;
using System.Linq.Expressions;

namespace LeetCode.HardProblems
{
    public class SolvePemdasProblem
    {
        public SolvePemdasProblem() { }

        public string SolvePemdas(int[] numbers, int target)
        {
            List<string> possibleOperators = new List<string>() { "+", "-", "*", "/" };

            List<string> combinations = new List<string>();

            for(int i = 0; i< numbers.Length; i++)
            {
                if(i == numbers.Length - 1)
                {
                    List<string> lastEquationsBuilder = new List<string>();
                    foreach (string combination in combinations)
                    {
                        lastEquationsBuilder.Add(combination + numbers[i]);
                    }
                    combinations = lastEquationsBuilder;
                    continue;
                }

                List<string> partialEquations = new List<string>();
                for(int j = 0; j < possibleOperators.Count; j++)
                {
                    partialEquations.Add(numbers[i] + possibleOperators[j]);
                }
                if (combinations.Count == 0) {
                    combinations = partialEquations;
                    continue;
                };

                List<string> newEquationsBuilder = new List<string>();
                foreach(string partialEquation in partialEquations)
                {
                    foreach (string combination in combinations)
                    {
                        newEquationsBuilder.Add(combination + partialEquation);
                    }
                }
                combinations = newEquationsBuilder;
            }

            foreach (string combination in combinations)
            {
                DataTable table = new DataTable();
                double value = Convert.ToDouble(table.Compute(combination, ""));
                if (value == target)
                {
                    return combination;
                }
            }

            return string.Empty;
        }

        public bool SolvePemdas2(int[] numbers, int sum)
        {
            string operators = "+-*/";


            List<string> operatorCombinatations = GenerateCombinations(operators, numbers.Length -1);
            List<string> combinations = new List<string>();
            foreach(string operatorCombinatation in operatorCombinatations)
            {
                string combination = string.Empty;
                for(int i = 0; i< numbers.Length; i++)
                {
                    if (i == numbers.Length - 1) combination += numbers[i];
                    else combination += numbers[i] + operatorCombinatation[i].ToString();
                }
                combinations.Add(combination);
            }

            foreach(string combination in combinations)
            {
                DataTable table = new DataTable();
                double value = Convert.ToDouble(table.Compute(combination, ""));
                if(value == sum)
                {
                    return true;
                }
            }
            return false;
        }

        public List<string> GenerateCombinations(string str, int length, string prefix = "")
        {

            List<string> combinations = new List<string>();
            if(length == 0)
            {
                combinations.Add(prefix);
                return combinations;
            }

            for(int i = 0; i < str.Length;i++)
            {
                string newPrefix = prefix + str[i];
                combinations.AddRange(GenerateCombinations(str, length -1, newPrefix));
                
            }
            return combinations;
        }


        
    }
}
