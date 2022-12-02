using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Advent_of_Code.Dag_2
{
    public class RockPaperScissors
    {
        public void Exercise1()
        {
            //Neem hier geen voorbeeld aan XD
            string[] text = File.ReadAllLines("C:\\Users\\svenk\\AoC 2022\\Advent of Code\\Advent of Code\\Dag 2\\input.txt");
            int score = 0;
            int X = 1;
            int Y = 2;
            int Z = 3;
            int lose = 0;
            int draw = 3;
            int win = 6;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Contains("X"))
                {
                    score += X;
                    if (text[i].Contains("A"))
                        score += draw;
                    if (text[i].Contains("B"))
                        score += lose;
                    if (text[i].Contains("C"))
                        score += win;
                }
                if (text[i].Contains("Y"))
                {
                    score += Y;
                    if (text[i].Contains("A"))
                        score += win;
                    if (text[i].Contains("B"))
                        score += draw;
                    if (text[i].Contains("C"))
                        score += lose;
                }

                if (text[i].Contains("Z"))
                {
                    score += Z;
                    if (text[i].Contains("A"))
                        score += lose;
                    if (text[i].Contains("B"))
                        score += win;
                    if (text[i].Contains("C"))
                        score += draw;
                }
            }
            Console.WriteLine(score);
        }
        public void Exercise2()
        {
            string[] text = File.ReadAllLines("C:\\Users\\svenk\\AoC 2022\\Advent of Code\\Advent of Code\\Dag 2\\input.txt");
            int score = 0;

            for (int i = 0; i < text.Length; i++)
            {
                score += GetValue(text[i].Trim());
            }
            Console.WriteLine(score);
        }



        public int GetValue(string input)
        {
            int X = 1;
            int Y = 2;
            int Z = 3;
            int lose = 0;
            int draw = 3;
            int win = 6;

            if (input.Contains("A"))
            {
                if (input.Contains("X"))
                    return Z + lose;
                if (input.Contains("Y"))
                    return X + draw;
                if (input.Contains("Z"))
                    return Y + win;

            }
            if (input.Contains("B"))
            {
                if (input.Contains("X"))
                    return X + lose;
                if (input.Contains("Y"))
                    return Y + draw;
                if (input.Contains("Z"))
                    return Z + win;
            }
            if (input.Contains("C"))
            {
                if (input.Contains("X"))
                    return Y + lose;
                if (input.Contains("Y"))
                    return Z + draw;
                if (input.Contains("Z"))
                    return X + win;
            }
            return 0;
        }
    }
}



