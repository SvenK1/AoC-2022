using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_Code.Dag_1
{
    public class Calories
    {
        public static async Task<int> MostCalories()
        {

            string text = await File.ReadAllTextAsync("C:\\Users\\svenk\\AoC 2022\\Advent of Code\\Advent of Code\\Dag 1\\input.txt");
            int calories = 0;
            int varCalories;
            int maxCalories = 0;

            foreach (var s in text.Split("\n"))
            {
                int.TryParse(s.Trim(), out varCalories);
                calories += varCalories;
                if (string.IsNullOrEmpty(s.Trim()))
                {
                    if (maxCalories < calories)
                        maxCalories = calories;

                    calories = 0;
                }
            }
            return maxCalories;
        }

        public static async Task<int> GetSumOfThreeMostAmountOFCalories()
        {

            string text = await File.ReadAllTextAsync("C:\\Users\\svenk\\AoC 2022\\Advent of Code\\Advent of Code\\Dag 1\\input.txt");
            int calories = 0;
            int varCalories;
            List<int> listOfCalories = new List<int>();

            foreach (var s in text.Split("\n"))
            {
                int.TryParse(s.Trim(), out varCalories);
                calories += varCalories;
                if (string.IsNullOrEmpty(s.Trim()))
                {
                    listOfCalories.Add(calories);
                    calories = 0;
                }
            }
            return listOfCalories.OrderByDescending(x => x).Take(3).Sum();
        }
    }
}
