using System;

namespace LearnCsharpForBeginners
{
    public class Program
    {
        public static void Main()
        {
        // Task: Reading and Displaying a Floating-Point Number
        // Create a C# console application that reads a floating-point number from the user, converts the input from a string to a float,
        // and then displays the floating-point number back to the console with a formatted message.
		// Purpose of Console.ReadLine() -  User Input: To interact with the user and get input data during the execution of the program
        // Console ReadLine always return string data types
        // 1
        // Console.WriteLine("Enter Floating-Point Number ");
        // float userInput = 0;
        // userInput = float.Parse(Console.ReadLine());// convert user input data to float
        // Console.WriteLine("Your answer is: " + userInput);


        // 2. Math Actions
        // float userInput = float.Parse(Console.ReadLine());
        // float result = 0;
        // result = userInput + 10;
        // result = userInput + 10f;// readonly struct System.Single ===  floating-point number
        // result = userInput - 10f;// 
        // result = userInput * 10f;// 
        // result = userInput / 10f;//
        // result = userInput % 10f;//

        // result += 5f;

        // Console.WriteLine("Result: " + result);

         // convert string to float data type
         // important nuance about float - when we are trying to enter a number from the keyboard, than here we need
         // to set comma ,



         // 3. Maths

        // CONSTANTS
        //  const int number = 18;
        //  number = 20;//  error CS0131: The left-hand side of an assignment must be a variable, property or indexer 
        //  Console.WriteLine(number);


        // MATH    
        // math constants
        // Console.WriteLine("PI" + Math.PI);// 3.141592653589793
        // Console.WriteLine("E" + Math.E);// 718281828459045

        // // math functions
        // //  C# uses PascalCase as a naming convention
        // Console.WriteLine("Absolute number: " + Math.Abs(-20));// 20
        // Console.WriteLine("Math Ceil: " + Math.Ceiling(4.11));// 5
        // Console.WriteLine("Math Floor: " + Math.Floor(4.11));// 4
        // Console.WriteLine("Math nearest intenger : " + Math.Round(4.11));// 5

        // // Math.Min, Math.Max


        //  Console.WriteLine("Number return with specifed Power  Math.Pow(5, 2) : " + Math.Pow(5, 3));// 125 - 5*5*5



        /*
        using System;

class Program
{
    static void Main()
    {
        // Հարցնում ենք օգտատիրոջից շրջանի շառավիղը (Radius)
        Console.WriteLine("Введите радиус круга: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        // Հաշվարկում ենք շրջանի մակերեսը
        // Հարաբերությունը (\pi)-ի
        // 	1.	Շրջանի շրջագծի և տրամագծի հարաբերությունը:
        // (\pi) թիվը սահմանում է հարաբերությունը շրջանի շրջագծի (կամ պարագծի) (C)-ի և նրա տրամագծի (d)-ի միջև:
        // \pi = \frac{C}{d}

        double area = Math.PI * Math.Pow(radius, 2);

        // Տպում ենք արդյունքը
        Console.WriteLine("Площадь круга с радиусом {0} равна {1}", radius, area);
    }
}
        */

        }
    }
};

