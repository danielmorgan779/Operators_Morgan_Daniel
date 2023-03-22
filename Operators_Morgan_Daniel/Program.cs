using System;

namespace Operators_Morgan_Daniel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Integers");
            int intMult = 7 * 46; // Two numbers multiplied and initialized
            int intAdd = 77 + 66; // Two numbers added together and intialized 
            //Prints the maximum and minimum of both integers 
            Console.WriteLine($"Max of {intMult} and {intAdd} is {Math.Max(intMult, intAdd)}. The min of both is {Math.Min(intMult, intAdd)}");
            //Tells whether intMult is greater than inAdd or not and initializes as a bool
            bool isIntGreater = intMult > intAdd;
            //Prints intMult is greater than intAdd if it is
            Console.WriteLine($"{intMult} is greater than {intAdd}, {isIntGreater}.\n");

            Console.WriteLine("Shorts");
            short shortMult = 7 * 46; // Two numbers multiplied and initialized
            short shortAdd = 77 + 66; // Two numbers added together and initialized 
            //Prints the maximum and minimum of both integers 
            Console.WriteLine($"Max of {shortMult} and {shortAdd} is {Math.Max(shortMult, shortAdd)}. The min of both is {Math.Min(shortMult, shortAdd)}");
            //Tells whether shortMult is greater than inAdd or not and initializes as a bool
            bool isshortGreater = shortMult > shortAdd;
            //Prints shortMult is greater than shortAdd if it is
            Console.WriteLine($"{shortMult} is greater than {shortAdd}, {isshortGreater}.\n");

            Console.WriteLine("Longs");
            long longMult = 7 * 46; // Two numbers multiplied and initialized
            long longAdd = 77 + 66; // Two numbers added together and initialized 
            //Prints the maximum and minimum of both integers 
            Console.WriteLine($"Max of {longMult} and {longAdd} is {Math.Max(longMult, longAdd)}. The min of both is {Math.Min(longMult, longAdd)}");
            //Tells whether longMult is greater than inAdd or not and initializes as a bool
            bool islongGreater = longMult > longAdd;
            //Prints longMult is greater than longAdd if it is
            Console.WriteLine($"{longMult} is greater than {longAdd}, {islongGreater}.\n");

            Console.WriteLine("Floats");
            float floatMult = 7 * 46; // Two numbers multiplied and initialized
            float floatAdd = 77 + 66; // Two numbers added together and initialized 
            //Prints the maximum and minimum of both integers 
            Console.WriteLine($"Max of {floatMult} and {floatAdd} is {Math.Max(floatMult, floatAdd)}. The min of both is {Math.Min(floatMult, floatAdd)}");
            //Tells whether floatMult is greater than inAdd or not and initializes as a bool
            bool isfloatGreater = floatMult > floatAdd;
            //Prints floatMult is greater than floatAdd if it is
            Console.WriteLine($"{floatMult} is greater than {floatAdd}, {isfloatGreater}.\n");

            Console.WriteLine("Doubles");
            double doubleMult = 7 * 46; // Two numbers multiplied and initialized
            double doubleAdd = 77 + 66; // Two numbers added together and initialized 
            //Prints the maximum and minimum of both integers 
            Console.WriteLine($"Max of {doubleMult} and {doubleAdd} is {Math.Max(doubleMult, doubleAdd)}. The min of both is {Math.Min(doubleMult, doubleAdd)}");
            //Tells whether doubleMult is greater than inAdd or not and initializes as a bool
            bool isdoubleGreater = doubleMult > doubleAdd;
            //Prints doubleMult is greater than doubleAdd if it is
            Console.WriteLine($"{doubleMult} is greater than {doubleAdd}, {isdoubleGreater}.\n");

            Console.WriteLine("Decimals");
            decimal decimalMult = (decimal)(7.23 * 46.21); // Two numbers multiplied and initialized
            decimal decimalAdd = (decimal)(77.23 + 66.54); // Two numbers added together and initialized 
            //Prints the maximum and minimum of both integers 
            Console.WriteLine($"Max of {decimalMult} and {decimalAdd} is {Math.Max(decimalMult, decimalAdd)}. The min of both is {Math.Min(decimalMult, decimalAdd)}");
            //Tells whether decimalMult is greater than inAdd or not and initializes as a bool
            bool isdecimalGreater = decimalMult > decimalAdd;
            //Prints decimalMult is greater than decimalAdd if it is
            Console.WriteLine($"{decimalMult} is greater than {decimalAdd}, {isdecimalGreater}.\n");
        }
    }
}
