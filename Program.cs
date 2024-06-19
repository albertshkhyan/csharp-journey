using System;

namespace LearnCsharpForBeginners
{
    public class Program
    {
        public static void Main()
        { 
            // Data Types and Variables
            
            // don't use special charecters like %&! and etc. And can't start with number

            
            // # INT
			// 1.
            // int n;
            // n = 0;
            // n = -3;
            // n = 100;
            // Console.WriteLine(n);
            
            // 2.
            // int n = 20;
            // Console.WriteLine(n);
            //
            
            // Revieve data
            // Console.ReadKey();
            
            // 3.
            // merge outputs - concatatnion
            // Console.WriteLine("N - " + n ".");
            
            
            
            
            // ****** Work with number ******

            // 1 UINT
            // With uint we can't store negative numbers like -n
            // uint n = 10; // Correct
            // uint n2 = -10; // Incorrect -  error CS0031: Constant value '-10' cannot be converted to a 'uint' 
            // Console.WriteLine("N - " + n2 + ".");
            
            
            // 2 BYTE
            // error CS1012: Too many characters in character literal 
            // byte n = 255;// 8 bit
            // Console.WriteLine('n: byte' + n);// error CS1012: Too many characters in character literal - for this ''
            // n = 15; // correct
            // n = 256; // incorrect - Constant value '256' cannot be converted to a 'byte'
            // n = -256;// incorrect 
            // n = -255;// correct 
            // Console.WriteLine("n: byte " + n);
            
            
            // Why use byte instead of int
            // int use 4 times more operating memory than the byte date type
            
            
            // 3 SHORT
            // short n = 256;//correct
            // n = 1450;// correct
            // n = 32650;// correct
            // n = 32655;// correct
            // n = 32755;// correct
            // n = 32767;// correct
            // n = 32768;// incorrect - max value is 32767 - error CS0031: Constant value '33755' cannot be converted to a 'short'
            // Console.WriteLine("n + " + n);
            
            
            /*
             * Sysytem.int32
             * int - use 32-bit - Range: -2,147,483,648 to 2,147,483,647
             * byte - use 8-bit - Range: 0 to 255
             * short - use 16-bit - -32,768 to 32,767
             */
            
            
            
            // 4 LONG
            // 64 bits - Range: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            // long n = 92233368547808;
            // Console.WriteLine("Long: " + n);// correct concatation
            // Console.WriteLine("Long: +", n);// incorrect concatation
            
            
            
            
            // 5 FLOAT and DOUBLE
			// 1. FLOAT
			// numbers with point
			// Size: 32 bits (4 bytes)
			// Range: Approximately ±1.5 × 10^−45 to ±3.4 × 10^38
            // error CS0664: Literal of type double cannot be implicitly converted to type 'float'; use an 'F' suffix to create a literal of this type
            // float n = 12.53232;// incorrect
            // n = -29952.323225;// incorrect
            // float n = 12.53232F;// correct - in last we should add f/F
            // n = -29952.323225f;// correct -  in last we should add f/F
            // Console.WriteLine("N: " + n);

			// 2. DOUBLE
			// Size: 64 bits (8 bytes)
       		// Double example without the suffix
            // double doubleNumber1 = 12.53232;
            // Console.WriteLine("Double Number 1: " + doubleNumber1);

            // Double example with the suffix
            // double doubleNumber2 = 12.53232d;
            // Console.WriteLine("Double Number 2: " + doubleNumber2);



			// # STRING
			// string word = "Hellow World";
			// Console.WriteLine("Word - " + word);

			// int number = 3300;
			// are being concatenated 
			// Console.WriteLine(word + number + ":)");// World3300:)


			//# CHAR
			// Size: 16 bits (2 bytes)
			// Represents a single Unicode character.

			// In C#, a char (short for character) represents a single character and uses single quotes to distinguish 
			// it from a string, which uses double quotes. Here's why:

			// string greeting = "Hello, World!";
			// char symbol = '3';// here should be used only single quotes - ''



			// # BOOL
			// bool isHappy = false;// Output: False
			// Console.WriteLine("isHappy: " + isHappy);
			


	/*
| Category         | Data Types                                                                                  |
|------------------|---------------------------------------------------------------------------------------------|
| Value Types      | byte, sbyte, short, ushort, int, uint, long, ulong, float, double, decimal, bool, char      |
| Enums            | User-defined types with named constants                                                     |
| Structs          | User-defined value types                                                                    |
| Reference Types  | string, arrays, classes, interfaces, delegates                                              |
| Pointer Types    | int*, char*, etc. (used in unsafe code)                                                     |
| Special Types    | Nullable<T> or T? (nullable value types)                                                    |
*/




			// ******** Convert Data Types ********
		
			


			// Using Convert class
			// int intVal = 123;
			// Console.WriteLine("intVal: " + Convert.toInt32(intVal));//  error CS0117: 'Convert' does not contain a definition for 'toInt32'
			// Console.WriteLine("intVal: " + Convert.ToInt32(intVal));
			// intVal = 4.5; //  error CS0266: Cannot implicitly convert type 'double' to 'int'. An explicit conversion exists (are you missing a cast?)
			// Console.WriteLine("intVal: " + Convert.ToInt32(intVal));


			// Implicit conversion
			// int intVal = 123;
			// double doubleVal = intVal; // Correct
			// doubleVal = 123.5;
			// Console.WriteLine("Implicit conversion: " + doubleVal);// Output: 123,5



  			// Task: Reading and Displaying Integer Inputs

			// Initialize variables to store the integer inputs from the user
			int num1 = 0, num2 = 0;

			// Read user input from the console, convert the input from string to integer
			// Note: If the user inputs a float number, a System.FormatException error will occur.
			// Example: Inputting "3.14" will cause an error, while "5" (an integer) is acceptable.
			num1 = Convert.ToInt32(Console.ReadLine());
			num2 = Convert.ToInt32(Console.ReadLine());

			// Display the integers entered by the user
			Console.WriteLine("First: " + num1 + ". Second: " + num2);
			



        }
    }
};

