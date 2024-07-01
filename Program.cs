using System;

namespace LearnCsharpForBeginners
{
    public class Program
    {
        public static void Main()
        {

        // **************** One-Dimensional Arrays ****************

        // ******** Basics of Arrays ********

        // byte[] nums = new byte[5];


        /*
            Syntax for various types of arrays in C#:

            elementType[] arrayName;


            Initialization:

            elementType[] arrayName = new elementType[arraySize];//with `arraySize` we allocate memory, or how many items we will have



            Declaration and Initialization with Values:

            elementType[] arrayName = { value1, value2, value3, ... };



            difference between
                1. elementType[] arrayName = new elementType[arraySize];
                2. elementType[] arrayName = { value1, value2, value3, ... };


            1. elementType[] arrayName = new elementType[arraySize];


            Description:
                This syntax is used to declare an array and allocate memory for it without initializing its elements.
                The array is created with a specified size (arraySize), but all elements are initialized to the default value of the element type.




        */

        /*
        1. elementType[] arrayName = new elementType[arraySize];
        Usage: Use this when you know the size of the array in advance but will set the values later.

        int[] numbers = new int[5];  // Declares an array of 5 integers
        // The array elements are initialized to 0 (default value for int)
        numbers[0] = 1;
        numbers[1] = 2;
        // ...initialize other elements as needed


        Characteristics:
            Size: The size of the array is specified at the time of creation and cannot be changed.
            Initialization: Elements are initialized to default values (e.g., 0 for int, null for string).


        # 2. elementType[] arrayName = { value1, value2, value3, ... };


        Description:
            This syntax is used to declare, allocate, and initialize an array all at once.
            The array size is determined by the number of values provided.


        Usage: Use this when you know the values you want to store in the array at the time of creation.
        */

        // int[] numbers = { 1, 2, 3, 4, 5 };  // Declares and initializes an array of 5 integers
        // Console.WriteLine("numbers: " + numbers);// Output: System.Int32[]


        /*
        Characteristics:
            Size: The size of the array is implicitly determined by the number of values provided.
            Initialization: Elements are explicitly initialized with the provided values.
        */

        // Declaration without initialization
        // int[] numbers;

        //// # Declaration

        // // Declaration with initialization
        // int[] numbers = new int[5]; // Array of 5 integers, all initialized to 0
        // Console.WriteLine("numbers: " + numbers);//System.Int32[]


        //// # Initialization:

        // Initializing elements at the time of declaration
        // int[] numbers = new int[] {1, 2, 3, 4, 5};

        // // Short-hand syntax for initialization
        // int[] numbers2 = {1, 2, 3, 4, 5};

        /*
        int[] numbers = { 1, 2, 3, 4, 5 }; Equivalent to int[] numbers = new int[] { 1, 2, 3, 4, 5 };
        */

        // Console.WriteLine("numbers: " + numbers);
        // Console.WriteLine("numbers2: " + numbers2);



        //// # Accessing Elements

        /* Elements in an array are accessed using the index, which starts from 0. */
        // int[] numbers = new int[] {1, 2, 3, 4, 5};
        // Console.WriteLine("First Number: " + numbers[0]); // Accessing the first element (1)
        // // Modifying the second element to 10
        // numbers[0] = 10;
        // Console.WriteLine("Modify First Number: " + numbers[0]);

        /*
        Summary:
            When you use curly braces {} to initialize an array in C#, the size of the array is determined dynamically
            based on the number of elements provided. This means you don't explicitly specify the size of the array;
            instead, the compiler calculates the size based on the number of elements within the braces.
        */




        //// # Iterating Over Arrays

        /* You can use a `for` loop or a `foreach` loop to iterate over the elements of an array. */

        // int[] numbers = {1, 2, 3, 4, 5};

        // // Using for loop
        // for(int i = 0; i < numbers.Length; ++i) {
        //     Console.WriteLine(numbers[i]);
        // }


        // Using foreach loop

        // foreach(int i in numbers) {
        //     Console.WriteLine(numbers[i]);
        // }

        // Output: Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.

        // foreach(int number in numbers) {
        //     Console.WriteLine(number);
        // }



        //// # Initialize an array
        // int[] numbers = { 1, 2, 3, 4, 5 };
        // // Use a while loop to iterate over the array
        // int index = 0; // Initialize the index
        // Console.WriteLine("Iterating over the array using a while loop:");
        // while (index < numbers.Length)
        // {
        //     Console.WriteLine(numbers[index]);
        //     index++; // Increment the index
        // }



        // **************** Multi-Dimensional Arrays ****************

        /*
            Multi-dimensional arrays in C# are arrays that have more than one dimension. They are useful for
            representing complex data structures, such as matrices, grids, or tables.
        */

        // int[,] matrix = new int[3, 3];// 3x3 -> 2d array
        // int[,,] matrix2 = new int[3, 3, 3];// 3x3x3 -> 3d array


        // matrix2[0, 0, 0] = 1;
        // matrix2[0, 0, 1] = 2;
        // matrix2[0, 0, 2] = 3;
        // matrix2[0, 1, 0] = 4;
        // matrix2[0, 1, 1] = 5;
        // matrix2[0, 1, 2] = 6;
        // matrix2[0, 2, 0] = 7;
        // matrix2[0, 2, 1] = 8;
        // matrix2[0, 2, 2] = 9;

        // int value = matrix2[0, 1, 1]; // This will get the value 5

        // // Console.WriteLine("Test: " + matrix2[0]);// Wrong number of indices inside []; expected 3CS0022
        // // Console.WriteLine("Test: " + matrix2[0, 0]);// Wrong number of indices inside []; expected 3CS0022
        // // Console.WriteLine("Test: " + matrix2[0, 0, 0]);// Correct -> Output: Test: 1

        // Console.WriteLine("Value at matrix[0, 1, 1]: " + value);

        // Console.WriteLine("3D Array values:");
        // for (int i = 0; i < 3; i++)
        //     {
        //         for (int j = 0; j < 3; j++)
        //         {
        //             for (int k = 0; k < 3; k++)
        //             {
        //                 Console.Write(matrix2[i, j, k] + " ");
        //             }
        //             Console.WriteLine();
        //         }
        //         Console.WriteLine();
        //     }
        // }



        //// # Understanding Layers in a 3D Array

        /*
        Syntax
            int[,,] matrix2 = new int[size1, size2, size3];

        OR

        int[,,] matrix2 = new int[depth, rows, columns];


        Explanation:
            depth: The size of the first dimension, representing the number of layers.
            rows: The size of the second dimension, representing the number of rows in each layer.
            columns: The size of the third dimension, representing the number of columns in each row of each layer.

        */

        // int[,,] matrix2 = new int[3, 3, 3];

        /*
        The term "layer" is used informally to help visualize the concept of a three-dimensional array.
        The correct way to understand the dimensions of a three-dimensional array in C# is to think of
        them as depth, rows, and columns.


         in the context of a three-dimensional array, "depth" and "layer" are often used interchangeably to
         refer to the same concept. Both terms describe the first dimension of the array, which specifies
         the number of "slices" or "layers" in the array.

         // Initialize values in the 3D array
            matrix2[0, 0, 0] = 1;
            matrix2[0, 0, 1] = 2;
            matrix2[0, 0, 2] = 3;
            matrix2[0, 1, 0] = 4;
            matrix2[0, 1, 1] = 5;
            matrix2[0, 1, 2] = 6;
            matrix2[0, 2, 0] = 7;
            matrix2[0, 2, 1] = 8;
            matrix2[0, 2, 2] = 9;

            Layer 0 (Depth 0):
            [
            [1, 2, 3],
            [4, 5, 6],
            [7, 8, 9]
            ]

            [
            [matrix2[0, 0, 0], matrix2[0, 0, 1], matrix2[0, 0, 2]],
            [matrix2[0, 1, 0], matrix2[0, 1, 1], matrix2[0, 1, 2]],
            [matrix2[0, 2, 0], matrix2[0, 2, 1], matrix2[0, 2, 2]]
            ]

            // Initialize values for Layer 1
            matrix2[1, 0, 0] = 10;
            matrix2[1, 0, 1] = 11;
            matrix2[1, 0, 2] = 12;
            matrix2[1, 1, 0] = 13;
            matrix2[1, 1, 1] = 14;
            matrix2[1, 1, 2] = 15;
            matrix2[1, 2, 0] = 16;
            matrix2[1, 2, 1] = 17;
            matrix2[1, 2, 2] = 18;


            Layer 1 (Depth 1):
            [
            [10, 11, 12],
            [13, 14, 15],
            [16, 17, 18]
            ]

            // Initialize values for Layer 2
            matrix2[2, 0, 0] = 19;
            matrix2[2, 0, 1] = 20;
            matrix2[2, 0, 2] = 21;
            matrix2[2, 1, 0] = 22;
            matrix2[2, 1, 1] = 23;
            matrix2[2, 1, 2] = 24;
            matrix2[2, 2, 0] = 25;
            matrix2[2, 2, 1] = 26;
            matrix2[2, 2, 2] = 27;

            Layer 2 (Depth 2):
            [
            [19, 20, 21],
            [22, 23, 24],
            [25, 26, 27]
            ]
        */




        }

    }
};

