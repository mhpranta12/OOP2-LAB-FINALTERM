using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HasTablePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();
            table["pranta"] = 18362331;         // Hastable is able to store no inside index of string 
            table["Maruf"] = 18366181;
            table['A'] = "HashTable is able to store indexed char";  // Hastable is able to store string inside index of character
            table[0] = "HashTable is able to store indexed int";                // Hastable is able to store string inside index of integer
            table[0.5] = "HashTable is able to store indexed float";             // Hastable is able to store string inside index of float 
            Console.WriteLine(table["pranta"]);
            Console.WriteLine(table["Maruf"]);
            Console.WriteLine(table['A']);
            Console.WriteLine(table[0]);
            Console.WriteLine(table[0.5]);


        }
    }
}
