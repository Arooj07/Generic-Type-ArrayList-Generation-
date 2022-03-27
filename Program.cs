using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AroojQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new List<int>();
            arr.Add(3);
            arr.Add(4);
            arr.Add(5);
            arr.Add(1);
            arr.Add(8);
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }
            arr.Reverse();
            Console.WriteLine();
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------------------");
            arr.Sort();

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
           