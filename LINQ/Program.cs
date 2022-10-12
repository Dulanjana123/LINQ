using System;
using System.Linq;
using System.Text;

//Language Interpretated Query
namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            string[] words = { "hello", "wonderful", "LINQ", "beautiful", "world", "hello" };

            //Get words length less than or equal to 5
            var shortWords = from word in words where word.Length <= 5 select word;
            //to use WHERE clause LINQ provide infrastructure  

            //Print each word out
            foreach (var word in shortWords)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("--------\n");
            //use keyword 'Equals' to compare value
            var nameWords = from word in words where word.Equals("hello") select word;
            //
            foreach (var name in nameWords)
            {
                Console.WriteLine(name);
            }

            ///example 
            Console.WriteLine("--------\n");
            Console.WriteLine("Below is a simple LINQ to Objects example");
            string[] tools = { "Tablesaw", "Bandsaw", "Planer", "Jointer", "Drill", "Sander" };
            var list = from t in tools select t;

            StringBuilder sb = new StringBuilder();

            foreach (string s in list)
            {
                sb.Append(s + Environment.NewLine);
            }

            Console.WriteLine(sb.ToString(), "Tools");
            Console.ReadLine();





            Console.ReadLine();
        }
    }
}
