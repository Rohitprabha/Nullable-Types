using System;

namespace Nullable_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = null;                                     //Error Cannot convert null to 'int' because it is a non-nullable value type
            Nullable<int> i = null;
            int? j = null;                                      // converting non-nullable type to nullable type 
            string name = null;                                 //string is a Nullable Type

            Console.WriteLine(i.GetValueOrDefault());
            Console.WriteLine(j.HasValue);                           //to check the value

            bool? Having_Bike = null;

            if (Having_Bike == true)
            {
                Console.WriteLine("User having a Bike");
            }
            else if (Having_Bike == false)
            {
                Console.WriteLine("User didn't have any Bike");
            }
            else
            {
                Console.WriteLine("User didn't answer the Question");
            }

        }
    }
}
