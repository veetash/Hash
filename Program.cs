using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var List = new HashTableList(3);
            List.PutPair("BMW", "E39");
            List.PutPair("Audi", "A6");
            List.PutPair("JDM", "Tourer V");
            List.PutPair("Mercedes", "V-klasse");
            List.PutPair("BMW", "M5");

            Console.WriteLine(List.GetValueByKey("Mercedes"));
            Console.WriteLine(List.GetValueByKey("BMW"));
            Console.WriteLine(List.GetValueByKey("Audi"));
            Console.WriteLine(List.GetValueByKey("JDM"));
        }
    }
}
