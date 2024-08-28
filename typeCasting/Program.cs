//using System;

//namespace MyApplication
//{ 
//    class Program
//  {
//    static void Main(string[] args)
//    {

//        int myNum = 18;
//        double myDoubleNum = 5.124;
//        bool myBool = true;
//        char myChar = 'a';

//        Console.WriteLine(myNum);
//        Console.WriteLine(myDoubleNum);
//        Console.WriteLine(myBool);
//        Console.WriteLine(myChar);

//        // Type casting
//        int myInt = 10;
//        double myDouble = 5.25;
//        bool myBoolean = true;

//        Console.WriteLine(Convert.ToString(myInt));    // convert int to string
//        Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
//        Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
//        Console.WriteLine(Convert.ToString(myBoolean)); // convert bool to string
//    }
//  }

//}


//EXPLICIT CASTING
//using System;

//namespace MyApplication
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double MyDouble = 5.25;
//            int MyInt = (int)MyDouble;
//            Console.WriteLine(MyDouble);
//            Console.WriteLine(MyInt);


//        }
//    }
//}

            //IMPLICT CASTING
            //using System;

            //namespace MyApplication
            //{
            //    class Program
            //    {
            //        static void Main(string[] args)
            //        {
            //            int MyInt = 72;
            //            double MyDouble = MyInt;
            //            Console.WriteLine(MyInt);
            //            Console.WriteLine(MyDouble);
            //        }
            //    }
            //}
            //
using System;

namespace MyApplication
{
    class Program
    {
     static void Main(string[] args)
        {
            int MyInt = 34;
            double MyDouble = 16.8;
            bool MyBool = false;

            Console.WriteLine(Convert.ToString(MyInt));
            Console.WriteLine(Convert.ToDouble(MyInt));
            Console.WriteLine(Convert.ToInt32(MyDouble));
            Console.WriteLine(Convert.ToString(MyBool));

           
        }
    }
}
