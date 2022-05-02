using System;
using System.Collections.Generic;

//Exercises for the Exceptions Chapter

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {

        static double Divide(double x, double y)
        {
            try
            {
                if (x == 0 || y == 0)
                {
                    throw new ArgumentOutOfRangeException();
                    return 0;
                }
                else
                {
                    return x / y;
                }
            }catch(ArgumentOutOfRangeException err)
            {
                Console.WriteLine(err.Message);
                return 0;
            }

            //    try
            //    {
            //        return x / y;
            //    }
            //    catch (ArgumentOutOfRangeException err)
            //    {
            //        throw new ArgumentException(err.Message, err);
            //}
        }

        static int CheckFileExtension(string fileName)
        {
            try
            {

                 if(fileName == null || fileName ==  "")
                {
                    throw new ArgumentNullException();
                    return 0;
                }
                else if (fileName.Contains(".cs"))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }catch (ArgumentException err)
            {
                Console.WriteLine(err.Message, err);
                return 0;
            }
        }


        static void Main(string[] args)
        {
            // Test out your Divide() function here!

            // Test out your CheckFileExtension() function here!
            //Dictionary<string, string> students = new Dictionary<string, string>();
            //students.Add("Carl", "Program.cs");
            //students.Add("Brad", "");
            //students.Add("Elizabeth", "MyCode.cs");
            //students.Add("Stefanie", "CoolProgram.cs");
            Console.WriteLine(Divide(15.5, 2 ));
            Console.WriteLine(CheckFileExtension("Test.cs"));
            Console.WriteLine(CheckFileExtension("Test"));
            Console.WriteLine(CheckFileExtension(null));


        }
    }
}