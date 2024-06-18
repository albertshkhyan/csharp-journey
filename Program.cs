// In every c# file in the top we connect special libraries

// 1.
// connect system 
// this is core library which by default included in .NET framework
using System;
// with this library we will get access the method name of WriteLine



// 2.
// usually the namespace name is indicated in same way as folder name of your project
// in namespacw we will write all necessary code
namespace LearnCsharpForBeginners
{
    // body of namespace - all which written here inside these curly braces will refer to this namespace LearnCsharpForBeginners
    // namespace you can image as certan folder in which are located verious files. If you have different namespace for
    // different files accordingly you will not be able to link from one file to another file. In face thay are located in different folders
    
    
    // namespace is like a folder in a computer. it help organize your code so that easier to find and use.
    // For our future files we will use same namespace and in this case we able to access another file from one file
    
    /*
     1. Organize Code
     Image you have a lot of files on your computer. You pur similar files in folder to keep things tidy. Namespace
     do  the same for your code.
     2. Avoid nameing Conflicts.
     3. Easier Code Use - prevent writing the full path every time.
     */
    
    
    // 3. Class in namespace
    
    // class name is set exactly the same of the file. For example here should be Program


    public class Program
    {
        // And now here we should create here function


        // always after function name  ther are curly braces
        public static void Main()
        { 
            // If there no such a function for  LearnCsharpForBeginners project then accordingly the project
            // will not be launched
            // by default we we run "dotnet run" in the first executes this main function
            
            // 4. Ouput in console
            // Always should be writtern ";" when end expression.
            // all this displayed in new line
            Console.WriteLine("Hellow world 1");
            Console.WriteLine("Hellow world 2");
            Console.WriteLine("Hellow world 3");
            // it just wait for write for me to enter at least one character form keyboard
            Console.ReadKey();



            Console.Write("Hellow world 4 - \n\n");
            Console.Write("Hellow world 5 - \n\n");
            Console.Write("Hellow world 6 \n\n");

            // Console.ReadKey();// complete when write some key
            // Console.ReadLine();// complete when write some key than press enter - Recive data from user
        }
    }
};

