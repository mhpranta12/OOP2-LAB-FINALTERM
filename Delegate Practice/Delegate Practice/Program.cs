using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;                       // Using this to use the Collections NameSpace from system 

namespace Delegate_Practice
{
    class Program
    {
        public  delegate void TempDelg (int x,int y) ;          // Creating instance(delegate)
        public static void Add(int a, int b)                    //Declaring a method to test with the delegates.Declaring it in static because the main method is static
        {
            Console.WriteLine(a + b);
        }

        public static void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public static void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void Main(string[] args)
        {
            TempDelg calc = Add;                //Creating a variable of calc and storing/referring the method Add into it 
            calc(2, 3);                         //calc=Add; Thus Add is executing 
            Console.WriteLine();
            calc += Mul;                        //Adding Mul method by += 
            calc(2, 3);                         //calc=Add,Mul; Thus Add and Mul is executing 
            Console.WriteLine();

            calc = Sub;                         //Putting/referring/pointing Sub into calc . This will replace all method reference that we previously stored .
            calc(2, 3);                         // calc =  Sub ; Thus Sub is executing 
            Console.WriteLine();

            calc = calc-Mul;                    //Trying to deduct Mul from calc . But anything will not dedeuct . Because Mul is not under the reference of calc
            calc(4, 2);
            Console.WriteLine();                //Nothing deducted.So, calc =  Sub ; Thus Sub is executing 


            calc = calc + Mul;                   //Adding Mul method  as usually  
            calc(4, 2);                         //calc=Sub,Mul; Thus Sub and Mul is executing 
            Console.WriteLine();

            calc += Add;                        //Adding Add method by += 
            calc(4, 2);                         //calc=Sub,Mul,Add; Thus Sub and Mul and Add is executing 
            Console.WriteLine();

            calc -= Add;                        //Deducting Add from calc by -=       
            calc(4, 3);                         //calc=Sub,Mul,Add; Thus Sub and Mul and Add is executing 
        }
    }
}
