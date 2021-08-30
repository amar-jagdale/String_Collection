using System;
using System.Collections;
namespace BitArray_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implement BitArray");
            TestBittArray obj = new TestBittArray();
            obj.PrintBitArray();
            
        }
    }

    class TestBittArray
    {
        // Driver code
        public  void PrintBitArray()
        {

            // Creating a BitArray myBitArr
            BitArray myBitArr = new BitArray(5);

            // Initializing all the bits in myBitArr
            myBitArr[0] = false;
            myBitArr[1] = true;
            myBitArr[2] = true;
            myBitArr[3] = false;
            myBitArr[4] = true;

           
            Console.WriteLine("Initially the bits are as : ");

            PrintIndexAndValues(myBitArr);

           
            myBitArr.SetAll(false);   //Bit Array Property to set all values to be false

            
            
            Console.WriteLine("Finally the bits are as : ");  // It should display all the bits as false

            PrintIndexAndValues(myBitArr);
        }

        // Function to display bits
        public static void PrintIndexAndValues(IEnumerable myArr)
        {
            foreach (Object obj in myArr)
            {
                Console.WriteLine(obj);
            }
        }
    }
}

