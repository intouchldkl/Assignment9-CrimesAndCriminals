using System;

namespace Assignment9_CrimesAndCriminals
{
    class Program
    {
        static void Main(string[] args)
        {
            Criminal[] criminals = new Criminal[3];
            criminals[0] = new Criminal("Joel", 31);
            criminals[1] = new Criminal("Jesus", 51);
            criminals[2] = new Criminal("John", 26);

            DateTime date;
            date = DateTime.Parse("31/01/2021");
            criminals[0].AddCrime(new Crime(date, "Ascot", "Armed Roberry"));
            criminals[0].AddCrime(new Crime(date, "Airport", "Theft"));
            criminals[0].AddCrime(new Crime(date, "Airport", "Theft"));
            criminals[0].AddCrime(new Crime(date, "Airport", "Theft"));
            criminals[0].AddCrime(new Crime(date, "Airport", "Theft"));
            criminals[0].AddCrime(new Crime(date, "Airport", "Theft"));
            criminals[0].AddCrime(new Crime(date, "Airport", "Theft"));
            criminals[0].AddCrime(new Crime(date, "Airport", "Theft"));
            criminals[0].AddCrime(new Crime(date, "Airport", "Theft"));
            criminals[0].AddCrime(new Crime(date, "Airport", "Theft"));
            criminals[0].AddCrime(new Crime(date, "Airport", "Theft"));
            criminals[1].AddCrime(new Crime(date, "Buckingham Palace", "Attempted murder"));
            criminals[2].AddCrime(new Crime(date, "Walmart", "racketeering"));

            
            for (int i = 0;i < criminals.Length;i++)
            {
                Console.WriteLine(criminals[i].GetName() + " :" + criminals[i].GetAge());
                for(int z = 0;z < criminals[i].CountCrime();z++)
                {
                    Console.WriteLine(criminals[i].GetCrime(z));
                    
                }
                if (criminals[i].CountCrime() > 9)
                {
                    Console.WriteLine("Execute");
                }
            }



            // HW
            // Add Crimes to all 3 Criminals
            // Write a for loop below which loop through all 3 criminals
            // loops through each crime for each criminal and prints all of the information.
            // Extension, if they have more than 10 crimes then show message EXECUTE 
        }
    }
}
