using System;


namespace ConsoleApp50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Nik";
            string familyName = "Kond";
            Console.WriteLine(name + " " + familyName);
            string changedData = name;
            name = familyName;
            familyName = changedData;
            Console.WriteLine(name + " " + familyName);
        }
    }
}
