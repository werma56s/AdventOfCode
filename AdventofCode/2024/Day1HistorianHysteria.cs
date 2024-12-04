using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Dynamic;

//Day 1: Historian Hysteria

namespace AdventofCode._2024
{
    public class Day1HistorianHysteria
    {
        List<int> list1 = new List<int>();
        List<int> list2 = new List<int>();
        static string filePath2 = @"..\..\..\2024\Data\InputDay1.txt";

        public (List<int>, List<int>) getDataToList()
        {
            string[] lines = File.ReadAllLines(filePath2);
            foreach (string line in lines)
            {
                // Split the line based on whitespace
                string[] parts = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length == 2)
                {
                    // Parse and add to respective lists
                    if (int.TryParse(parts[0], out int value1) && int.TryParse(parts[1], out int value2))
                    {
                        list1.Add(value1);
                        list2.Add(value2);
                    }
                }
            }
            // Output the results
            //Console.WriteLine("List 1:");
            //list1.Sort();
            //foreach (var item in list1)
            //{
            //    Console.Write(item + ",");
            //}
            //list2.Sort();
            //Console.WriteLine("List 2:");
            //foreach (var item in list2)
            //{
            //    Console.Write(item + ",");
            //}
            return (list1, list2);
        }

        public int GetDiverencesBetweenTheSmallestNumberOfLists()
        {
            //Console.WriteLine();
            int diverence = 0;

            var (l1, l2) = getDataToList();
            //var l1 = new List<int>() { 3, 4, 2, 1, 3, 3 };
            //var l2 = new List<int>() { 4, 3, 5, 3, 9, 3 };

            l1.Sort();
            l2.Sort();

            for (int i=0; i < l1.Count(); i++)
            {
                //Console.WriteLine($"{i}: l1:{l1[i]} l2:{l2[i]} diverence:{Math.Abs(l1[i] - l2[i])}");
                diverence += Math.Abs(l1[i] - l2[i]);
                //Console.WriteLine();
                //Console.WriteLine($" diverence:{diverence}");
                //Console.WriteLine();

            }
            Console.Write($" What is the total distance between your lists? {diverence}");
            return diverence;
        }

    }
}
