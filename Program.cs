using System;

namespace LearnCsharpForBeginners
{
    public class Program
    {
        public static void Main()
        {
        // ******** CONDITIONS ********


        // # if-else
        /*
        1. if Statement
            The if statement allows you to execute a block of code if a specified condition is true.
        */

        // int a = 10;
        // if (a > 5)
        // {
        //     Console.WriteLine("a is greater than 5");
        // }

        /*
        2. else Statement
            The else statement allows you to execute a block of code if the condition in the if statement is false.
        */

        // int a = 3;
        // if (a > 5)
        // {
        //     Console.WriteLine("a is greater than 5");
        // }
        // else
        // {
        //     Console.WriteLine("a is not greater than 5");
        // }

        /*
            3. else if Statement
            The else if statement allows you to check multiple conditions.
        */

        // int a = 5;
        // if (a > 5)
        // {
        //     Console.WriteLine("a is greater than 5");
        // }
        // else if (a == 5)
        // {
        //     Console.WriteLine("a is equal to 5");
        // }
        // else
        // {
        //     Console.WriteLine("a is less than 5");
        // }


        /*
        in C#, you can write if or else statements without curly braces {} if the statement is a single line. This is called single-line if or else syntax. 
        Here is an example:

        Without Curly Braces
        */

        // int a = 5;

        // if (a > 5)
        //     Console.WriteLine("a is greater than 5");
        // else if (a == 5)
        //     Console.WriteLine("a is equal to 5");
        // else
        //     Console.WriteLine("a is less than 5");



        /*
        However, it is generally recommended to use curly braces even for single-line statements for better readability and to avoid errors,
        especially when modifying code in the future. Here is the same example with curly braces:
        */

        // int a = 10;

        // if (a > 5)
        // {
        //     Console.WriteLine("a is greater than 5");
        // }
        // else
        // {
        //     Console.WriteLine("a is not greater than 5");
        // }



        /*
            4. switch Statement
        */ 

        // int day = 3;
        // switch (day) 
        // {
        //     case 1:
        //         Console.WriteLine("Monday");
        //         break;
        //     case 2:
        //         Console.WriteLine("Tuesday");
        //         break;
        //     case 3:
        //         Console.WriteLine("Wednesday");
        //         break;
        //     default:
        //         Console.WriteLine("Another day");
        //         break;
        // }


        /* 5. Ternary Operator */ 

        // int a = 10;
        // string result = (a > 5) ? "a is greater than 5" : "a is not greater than 5";
        // Console.WriteLine(result);

        // int a = 10;
        // string result = a > 5 ? "a is greater than 5" : "a is not greater than 5";
        // Console.WriteLine(result);


        /*  Here's a more complex example to illustrate the importance of parentheses: */

        // int a = 10;
        // int b = 15;
        // string result = (a > 5 && b < 20) ? "Condition is true" : "Condition is false";
        // Console.WriteLine(result);


        /* Without parentheses, it can become unclear which parts of the expression are being evaluated as the condition: */ 

        // int a = 10;
        // int b = 15;
        // string result = a > 5 && b < 20 ? "Condition is true" : "Condition is false";
        // Console.WriteLine(result);


        /*
            Practical Example
            Here is a practical example that combines several conditions:
        */

         int age = 25;
            string category;

            if (age < 13)
            {
                category = "Child";
            }
            else if (age < 20)
            {
                category = "Teenager";
            }
            else if (age < 60)
            {
                category = "Adult";
            }
            else
            {
                category = "Senior";
            }

            Console.WriteLine($"You are categorized as: {category}");

            // Switch example
            int grade = 85;
            string gradeLetter;

            switch (grade / 10)
            {
                case 10:
                case 9:
                    gradeLetter = "A";
                    break;
                case 8:
                    gradeLetter = "B";
                    break;
                case 7:
                    gradeLetter = "C";
                    break;
                case 6:
                    gradeLetter = "D";
                    break;
                default:
                    gradeLetter = "F";
                    break;
            }

            Console.WriteLine($"Your grade is: {gradeLetter}");

            // Ternary operator example
            bool isEven = (age % 2 == 0) ? true : false;
            Console.WriteLine($"Is the age even? {isEven}");



        }
    }
};

