using System;

namespace Assignment3
{
    class Program
    {

        private static void PrintMemberInformation(Member a)
        {
            Console.WriteLine(a);

        }
        static void Main(string[] args)
        {
            YearlyMember a = new YearlyMember("Tim", "100 place", "5551035566", 6240);
            LifeTimeMember b = new LifeTimeMember("Ron", "102 st", "5551234422", 62400);

            Console.WriteLine("Yearly Members:");
            PrintMemberInformation(a);
            Console.WriteLine(a.ToString());


            Console.WriteLine();
            Console.WriteLine("Lifetime Members:");
            PrintMemberInformation(b);
            Console.WriteLine(b.ToString());


        }
    }
}
