// See https://aka.ms/new-console-template for more information
using Advent_of_Code.Dag_1;
using Advent_of_Code.Dag_2;
using System.Diagnostics;

RockPaperScissors rockPaperScissors = new RockPaperScissors();

Console.WriteLine(Calories.MostCalories().Result);
Console.WriteLine(Calories.GetSumOfThreeMostAmountOFCalories().Result);
Stopwatch stopwatch= new Stopwatch();
stopwatch.Start();
rockPaperScissors.Exercise1();
stopwatch.Stop();
Console.WriteLine(stopwatch.ElapsedMilliseconds);
rockPaperScissors.Exercise2();
