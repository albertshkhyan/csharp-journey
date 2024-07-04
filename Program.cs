using System;// System namespace
using System.Collections.Generic; // System.Collections.Generic namespace


namespace LearnCsharpForBeginners
{
    public class Program
    {
        public static void Main()
        {
            // **************** One-Dimensional Arrays ****************

            //// ******** Basics of Arrays ********

            // int[] numbers;

            //// Declaration and Initialization with Size:

            // int[] numbers2 = new int[5]; // Array of 5 integers, all initialized to 0


            //// Declaration and Initialization with Values:

            // int[] numbers = { 1, 2, 3, 4, 5 };



            //// Example:
            // int[] numbers = new int[5]; // Declares an array of 5 integers
            // numbers[0] = 1;
            // numbers[1] = 2;
            //// ...initialize other elements as needed



            //// Accessing and Modifying Array Elements

            // int[] numbers = { 1, 2, 3, 4, 5 };
            // Console.WriteLine("First Number: " + numbers[0]); // Output: 1
            // numbers[0] = 10; // Modifying the first element
            // Console.WriteLine("Modified First Number: " + numbers[0]); // Output: 10


            //// Iterating Over Arrays

            // int[] numbers = { 1, 2, 3, 4, 5 };

            // for (int i = 0; i < numbers.Length; i++)
            // {
            //     Console.WriteLine(numbers[i]);
            // }


            //// Using a foreach Loop

            /*
            Syntax:
            foreach (elementType element in collection)
            {
                // Code to execute for each element
            }
            */

//             int[] numbers = { 1, 2, 3, 4, 5 };
//
//             foreach (int n in numbers)
//             {
//                 Console.WriteLine("N: " + n);
//             }



            /*
            Why Not Use Dynamic Arrays Directly?

            Using List<T> over dynamic arrays
            simplifies coding,
            improves performance,
            ensures safety,
            and
            enhances maintainability effortlessly.

            Օգտագործելով List<T> դինամիկ զանգվածների փոխարեն՝
            - պարզեցնում է ծրագրավորման գործընթացը,
            - բարելավում է կատարողականությունը,
            - ապահովում է անվտանգությունը,
            - և հեշտությամբ բարձրացնում է պահպանելիությունը:

            Dynamic arrays in C# are typically not used directly because the .NET framework provides a more flexible
            and powerful collection class called List<T>, which offers dynamic array-like behavior along with many
            other useful features. Let's discuss why List<T> is preferred over manual dynamic arrays and explore its
            features in detail.

            . Memory Management
            Dynamic Arrays:
            When manually managing dynamic arrays, developers need to handle resizing the array when it exceeds its
            current capacity. This involves creating a new larger array, copying elements from the old array to the
            new one, and then discarding the old array. Frequent resizing operations can lead to memory
            fragmentation and inefficient use of memory.

            Հիշողության Կառավարում
            Դինամիկ Զանգվածներ
            Երբ ձեռքով կառավարում են դինամիկ զանգվածները, ծրագրավորողները պետք է զբաղվեն զանգվածի չափսի
            փոփոխմամբ, երբ այն գերազանցում է իր ներկա հզորությունը: Սա ենթադրում է ստեղծել նոր, ավելի մեծ
            զանգված, հին զանգվածի տարրերը պատճենել նոր զանգվածի մեջ և ապա հինը դուրս նետել: Հաճախակի
            չափսի փոփոխման գործողությունները կարող են բերել հիշողության ֆրագմենտացիայի և հիշողության անարդյունավետ
            օգտագործման:

            */



        /*
        List<T> in C#
        List<T> is a generic collection class provided by the .NET framework in the System.Collections.Generic namespace. It represents a strongly typed list of objects that can be accessed by index. It provides methods to search, sort, and manipulate lists.

        Key Features of List<T>
        Dynamic Sizing: Automatically resizes as elements are added or removed.
        Type Safety: Ensures that only objects of the specified type can be added.
        Rich API: Offers a wide range of methods for common operations like adding, removing, searching, and sorting elements.
        Indexed Access: Elements can be accessed by their zero-based index.
        Creating a List
        You can create a list by specifying the type of elements it will hold.

        Example:
        */


           Console.WriteLine("Hello, World !");


           /*
           Basic Syntax:
            List<T> listName = new List<T>();


           */


//         List<string> names = {"Alice", "Bob", "Jakob"}// Incorrect
//         List<string> names = new List<string> {"Alice", "Bob", "Jakob"};
//         Console.WriteLine("Names: " + names);// Output: System.Collections.Generic.List`1[System.String]

           /*
           Detailed Breakdown:

           List<string> names = new List<string>

           1. Declaration
           List<string> names;

           *  declared that names will hold a reference to a list of strings.

           2. Instantiation (Создание экземпляра)

           names = new List<string>();

           * <string> specifies that this instance will hold strings.
             the second string in new List<string>() is necessary to specify the type of
              elements the new list instance will hold

           // Example Without Initialization:

           List<string> names; // Declaration
           names = new List<string>(); // Instantiation


           the statement List<string> numbers = new List<int>(); is incorrect


            List<T> as a Reference Type
            List<T>: List<T> is a generic class provided by the .NET framework. Classes in C# are always reference types.
            Memory Storage: The List<T> instance itself is stored on the heap, and the variable names stores a reference
            to this heap object.


            // Example to Illustrate Reference Type Behavior
           */

//            // Create a list of strings
//            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
//
//            // Assign the reference to another variable
//            List<string> otherNames = names;
//
//            // Modify the list through the new reference
//            otherNames.Add("Dave");
//
//            // Both variables reflect the change
//            Console.WriteLine(string.Join(", ", names)); // Output: Alice, Bob, Charlie, Dave
//            Console.WriteLine(string.Join(", ", otherNames)); // Output: Alice, Bob, Charlie, Dave



           /*
            Syntax Without Initialization
            If you create an empty list without adding initial values, you still need the parentheses:
           */

            // List<string> names = new List<string>();


            /*
            And when initializing with values:
            */
//             List<string> names2 = new List<string> (){ "Alice", "Bob", "Jakob" };
//             Console.WriteLine("String: " + string.Join(" ",names2));

// # Without parentheses:
// List<string> names = new List<string> { "Alice", "Bob", "Jakob" };// Correct

// # With parentheses:
// List<string> names2 = new List<string> () { "Alice", "Bob", "Jakob" };// Correct





/*
List<T> - provides methods to search, sort, and manipulate lists.
*/

// List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
//
// // To add an element to the beginning of a List<T>
// names.Add("Jacob");
// names.Insert(0, "Megan");// Megan Alice Bob Charlie Jacob
// names.Insert(1, "Karen");// Megan Karen Alice Bob Charlie Jacob
// Console.WriteLine("Names: " + string.Join(" ", names));

/*
listName.Remove(element);// Removing by Value
numbers.RemoveAt(0); // Removing by Index
listName.Clear();// Removing All Elements
*/

// # Checking for Elements in a List
// bool containsAlice = names.Contains("Alice");


// # Finding Elements
// T element = listName.Find(match);

// string name = names.Find(n => n.StartsWith("A")); // Finds the first name starting with "A"

// # Sorting a List
// numbers.Sort();


/*
List Properties
*/

/*
What is Capacity?
Capacity: Capacity is the amount of space that is allocated for a list to hold elements. It determines
how many items the list can store before it needs more space.


Why Capacity Matters
Efficiency: By allocating extra space (capacity), the list doesn't have to get new space every time
you add an item, which makes adding items faster overall.


Why Capacity Matters
Efficiency: By allocating extra space (capacity), the list doesn't have to get new space every time you
add an item, which makes adding items faster overall.
Simple Example
Imagine a box that can hold balls:

Starting Box: You start with a box that can hold 4 balls.
Adding Balls: You add 4 balls, and the box is now full.
Need More Space: You want to add another ball, but the box is full.
Bigger Box: You get a bigger box that can hold 8 balls, move the 4 balls to the new box, and add the new ball.
In this example:

The capacity of the first box is 4.
When you needed more space, the new box had a capacity of 8.
*/

        // Initializing the list
//         List<string> listName = new List<string> { "Alice", "Bob", "Charlie", "Karen" };
//
//         // Displaying Count and Capacity
//         Console.WriteLine("Count: " + listName.Count); // Output: 3
//         Console.WriteLine("Capacity: " + listName.Capacity); // Output: 4 (or another value >= 3)



// Initializing the list with four elements
//         List<string> listName = new List<string> { "Alice", "Bob", "Charlie", "Karen" };
//
//         // Displaying Count and Capacity
//         Console.WriteLine("Count: " + listName.Count); // Output: 4
//         Console.WriteLine("Capacity: " + listName.Capacity); // Output: 4



//         // Initializing the list with four elements
//         List<string> listName = new List<string> { "Alice", "Bob", "Charlie", "Karen" };
//
//         // Displaying initial Count and Capacity
//         Console.WriteLine("Initial Count: " + listName.Count);    // Output: 4
//         Console.WriteLine("Initial Capacity: " + listName.Capacity); // Output: 4
//
//         // Adding another element to trigger resizing
//         listName.Add("Eve");
//
//         // Displaying Count and Capacity after adding one element
//         Console.WriteLine("New Count: " + listName.Count);    // Output: 5
//         Console.WriteLine("New Capacity: " + listName.Capacity); // Output: 8 (or another value >= 5)

        }
    }
}
