using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args) => Process();

        static void Process() {
            Console.Write("Enter word for coup: ");
            string word = Convert.ToString(Console.ReadLine());
            string reverseWord = "";
            if (word != ""){
                for (int i = word.Length - 1; i >= 0; i--)
                    reverseWord += word[i];
                Console.WriteLine($"\nInverted string: {reverseWord}");
                Repeat();
                return;
            }
            else {
                Console.WriteLine("\nI'm not going to flip the empty line!\n");
                reverseWord = "";
                Process();
                return;
            }
        }

        static void Repeat(){
            Console.Write("\nWant to flip another word? (yes/no): ");
            string answer = Console.ReadLine().Trim().ToString().ToLower();
            if (answer == "yes") {
                answer = "";
                Console.WriteLine();
                Process();
                return;
            }
            else if (answer == "no") {
                answer = "";
                Console.WriteLine("\nShutting down...");
                return;
            }
            else {
                Console.Clear();
                Console.WriteLine("\nTry again...");
                answer = "";
                Repeat();
            }
        }
    }
}
