using System;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace FlowControl
{
    class Program
    {
        public static void Main(string[] args)
        {
            const int MAX_MINOR_AGE = 17;
            const int MIN_SENIOR_AGE = 60;

            var isPWD = true;
           // var age = 25;
            Console.WriteLine("Add your age: ");
            var ageString = Console.ReadLine();
            var age = int.Parse(ageString);

            if (age <= 17 || age >= 60)
            {
                Console.WriteLine("Add miinor and senior discount");
            }
            else if (isPWD)
            {
                Console.WriteLine("Add PWD discount");
            }
            else
            {
                Console.WriteLine("No Discount");
            }

            Console.WriteLine("Are you a pwd?:");
            var pwdString = Console.ReadLine();
            var pwd = bool.Parse(pwdString);

            if (pwd == true) {
                Console.WriteLine("Add discount pwd eh");
            }
            else
            {
                Console.WriteLine("No dc");
            }
    
   
       
        } 
    }
}
