using System;

using System.Collections.Generic;//included for lists


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lists!!!
            List<string> list_name = new List<string>();

            list_name.Add("Bob"); // adding name to the list
            list_name.Add("Jerry");
            list_name.Add("Sue");

            list_name.ForEach(name => Console.Write(name)); //prints all the names in the list


            string aString = "a";
            List<string> stuff = new List<string>{aString, "b", "c", "d", "e"}; // Populating list. Can still add using .Add command

            //char aSingleCharacter = 'a'; //single quotes when using char

            int x = 5;
            int y = 7;

            int result = Adder(x, y); // 12

            int result_2 = Adder(10, 46); // 56

            Console.WriteLine($"{x} + {y} = {result}");





        }

        //creating new function
        static int Adder(int a, int b)
        {
            return a + b;
        }
    }
}