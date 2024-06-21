using System;

namespace LearnCsharpForBeginners
{
    public class Program
    {
        public static void Main()
        {
        // ******** LOOPS ********

        /*
        1. for Loop
            The for loop is typically used when you know in advance how many times you want to execute a statement or a block of statements.
        */

        // for (int i = 0; i < 10; i++)
        // {
        //     Console.WriteLine("i = " + i);
        // }


        /*
        2. foreach Loop
            The foreach loop is used to iterate over a collection, such as an array or a list.

            foreach (elementType element in collection)
            {
                // Code to execute for each element
            }

        */

        // int[] numbers = { 1, 2, 3, 4, 5 };
        // foreach (int number in numbers)
        // {
        //     Console.WriteLine("number = " + number);
        // }

        /*
        Collection Syntax
            A collection is a data structure that groups multiple elements together. In C#, collections come in various types, 
            each with specific characteristics and use cases. Collections include arrays, lists, dictionaries, queues, stacks, and more.

            Collection Types
                Benefits include dynamic sizing, easy element addition/removal, and built-in methods for data operations.

            Here is the ordered list of collection types in C#:
                Collection Types
                Array
                List
                Dictionary
                HashSet
                Queue
                Stack
                LinkedList
                ObservableCollection
        */
            

         /*
            3. while Loop
            The while loop is used when you want to execute a block of code as long as a specified condition is true.
         */

        // int i = 0;
        // while (i < 10)
        // {
        //     Console.WriteLine("i = " + i);
        //     i++;
        // }


        /*
        4. do-while Loop
            The do-while loop is similar to the while loop, but it guarantees that the code block is executed at least once.

            do-while ցիկլը նման է while ցիկլին, սակայն այն երաշխավորում է, որ կոդի բլոկը կկատարվի առնվազն մեկ անգամ, նույնիսկ եթե պայմանը սկզբից իսկ կեղծ է:
        */

        // int i = 0;
        // do
        // {
        //     Console.WriteLine("i = " + i);
        //     i++;
        // } while (i < 10);


        // ******** Practical Examples ********

        // for (int i = 1; i <= 5; i++)
        // {
        //     Console.WriteLine($"Square of {i} is {i * i}");
        // }


        // string[] fruits = { "Apple", "Banana", "Cherry" };
        // foreach (string fruit in fruits)
        // {
        //     Console.WriteLine(fruit);
        // }

        // int counter = 0;
        // while (counter < 3)
        // {
        //     Console.WriteLine($"Counter is at {counter}");
        //     counter++;
        // }


        int num = 1;
        do
        {
            Console.WriteLine($"Number is {num}");
            num++;
        } while (num <= 3);


        }
    }
};

