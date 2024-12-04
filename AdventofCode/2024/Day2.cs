using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace AdventofCode._2024
{
    public class Day2
    {
        Day1HistorianHysteria day1HistorianHysteria = new Day1HistorianHysteria();

        public void SimilarityScore()
        {
            var (l1, l2) = day1HistorianHysteria.getDataToList();
            //var l1 = new List<int>() { 3, 4, 2, 1, 3, 3 };
            //var l2 = new List<int>() { 4, 3, 5, 3, 9, 3 };
            var score_increases = 0;
            for (int i = 0; i < l1.Count(); i++)
            {
                score_increases += l1[i] * l2.FindAll(x=>x.Equals(l1[i])).Count();
            }
            Console.Write($" What is their similarity score? {score_increases}");
        }
    }
}
