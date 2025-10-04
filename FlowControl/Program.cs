using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.ExceptionServices;

namespace FlowControl
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region -If..Else If..-
            /*        const int MAX_MINOR_AGE = 17;
                    const int MIN_SENIOR_AGE = 60;

                    var isPWD = true;
                   // var age = 25;
                    Console.WriteLine("Add your age: ");
                    var ageString = Console.ReadLine();
                   var ages = int.Parse(ageString);

                    if (ages <= 17 || ages >= 60)
                    {
                        Console.WriteLine("Add minor and senior discount");
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
            */
            #endregion

            #region -Switch-
            /*        var age = 1;
                    switch (age)
                    {
                        case 1:
                        Console.WriteLine("baby");
                        break;
                        case 10:
                        case 11:
                        case 12:
                        case 13:
                        case 14:
                        case 15:
                        case 16:
                        case 17:
                        case 18:
                        case 19:
                        Console.WriteLine("Teens");
                        break;
                        default:
                        Console.WriteLine("Unknown");
                         break;
                    }
            */
            #endregion

            #region -While-
             var count = 0;
             while(count < 3)
             {
                 count++;
                 Console.WriteLine(count);
             }
           
            #endregion

            #region -Do While Loop-
            do
            {
                Console.WriteLine("Print using do while");
                Console.WriteLine(count);     
            }while (count < 3);

            #endregion

            #region -For Loop-
            //index++ equivalent to index = index + 1 or index += 1
            for (var index = 0; index <= 5; index++ )
            {
                Console.WriteLine($"index value {index} ");
            }

            #endregion

            #region -For each Loop-
            var nameSegments = new[] { "pro", "grammer", "tv" };
            foreach(var segment in nameSegments)
            {
                Console.WriteLine($"segment value:{segment}");
            }
             #endregion

            #region -Clients Requirement examples-
            //Client Requirements: No. 5 Discount for ADULT.
            // implementation 1
            /*    if (ages >= MAX_MINOR_AGE && ages <= MIN_SENIOR_AGE) 
                {

                }
                else
                {
                    Console.WriteLine("added 5 discount");
                }
                //implementation 2
                if (!(ages >= MIN_SENIOR_AGE && ages <= MAX_MINOR_AGE))
                {
                    Console.WriteLine("added 5 discout");
                }
            */
            #endregion

        }
    }
}
