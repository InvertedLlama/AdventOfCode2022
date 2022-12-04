namespace CalorieCounter
{
    public class CalorieCounter
    {
        public static List<int?> ConvertToInts(List<string> input)
        {
            return input.Select(x => string.IsNullOrWhiteSpace(x) ? (int?)null : int.Parse(x)).ToList();
        }

        public static List<List<int>> GetGroups(List<int?> input)
        {
            var groups = new List<List<int>>();
            var group = new List<int>();
            groups.Add(group);

            foreach (var item in input)
            {
                if (!item.HasValue)
                {
                    group = new List<int>();
                    groups.Add(group);
                }
                else
                {
                    group.Add(item.Value);
                }
            }

            return groups;
        }

        public static List<int> GetTotals(List<List<int>> groups)
        {
            var result = new List<int>();
            groups.ForEach(x => result.Add(x.Sum()));
            return result;
        }

        public static int GetLargestTotal(List<int> groupTotals)
        {
            return groupTotals.Max();
        }

        public static List<int> GetLargestTotals(List<int> groupTotals, int numberOfTotals)
        {
            var result = new List<int>();
            var orderedGroups = groupTotals.OrderByDescending(x => x).ToList();
            for(int i = 0; i < numberOfTotals; i++)
            {
                result.Add(orderedGroups[i]);
            }
            return result;
        }

        public static int GetTotal(List<int> groupTotals)
        {
            return groupTotals.Sum();
        }
    }
}