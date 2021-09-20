// 1 Which features of C# will allow SoftSols Inc. to reuse the existing
// application code? Describe in brief

  // C# is a simple, modern, object oriented language derived from C++ and Java.
  // It aims to combine the high productivity of Visual Basic and the raw power of C++.
  // It is a part of Microsoft Visual Studio 7.0.
  // Visual Studio supports VB, VC++, C++, VBscript, JScript. All of these languages provide access to the Microsft .NET platform.
  // .NET includes a Common Execution engine and a rich class library.
  // Microsofts JVM eqiv is Common language run time(CLR).
  // CLR accommadates more than one languages such as C#, VB.NET, Jscript, ASP.NET,C ++.
  // The classes and data types are common to all of the .NET languages.
  // We may develop Console application, Windows application, and Web application using C#.


//  Define an interface. Briefly describe the benefits of using interfaces
// specify what a class must do and not how.

   // Interfaces can’t have private members.
   // By default all the members of Interface are public and abstract.
   // The interface will always defined with the help of keyword ‘interface‘.
   // Interface cannot contain fields because they represent a particular implementation of data.
   // Multiple inheritance is possible with the help of Interfaces but not with classes.



// 2. The development team of SoftSols Inc. analyzes the source code of the existing software
// and notes the following observations: The software contains a private class, named bookTickets,
// that contains the methods used to perform ticket bookings for various flights. There is no class
// or function that can be used to check the maintenance details of FlyHigh's aircrafts.
// Based on the preceding observations, the development team decides to perform the following tasks: 


// Reuse the functions of the bookTickets class in a new class,
// named bookETicket, to add the feature of e-ticket booking. 



// Create a new class named viewMaintenance that allows the maintenance personnel
// of FlyHigh Airlines to view the maintenance details of aircrafts. Write the code
// snippet that the development team should use to accomplish each of the preceding tasks. 

Maintenance: -

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace message

{

    class maintenece
    {
        string user, aftid;
        public void usrd()
        {
            Console.WriteLine("Enter the maint. personal user name:");
            user = Console.ReadLine().ToLower();
            if (user == "ankit" || user == "karishma")
            {
                aftdet();
            }

            else
            {
                Console.WriteLine("Please enter a valid user Name!!!!!!");
            }
        }

        public void aftdet()
        {
            Console.WriteLine("Enter the vaild Aircraft ID:");
            aftid = Console.ReadLine();
            switch (aftid)
            {
                case "001":
                    Console.WriteLine("aircraft is under maint. for 1 days!");
                    break;
                case "002":
                    Console.WriteLine("aircraft is under maint. for 2 days!");
                    break;
                case "003":
                    Console.WriteLine("aircraft is under maint. for 3 days!");
                    break;
                case "004":
                    Console.WriteLine("aircraft is under maint. for 4 days!");
                    break;
                default:
                    Console.WriteLine("Aircraft ID is not Exist or Server Down!!!!!!!");
                    break;
            }


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            maintenece se = new maintenece();
            se.usrd();
            Console.ReadLine();
        }
    }
}


E - Booktickets :-

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eticketbook
{
    class bookticket
    {
        string name, age, destination, from, date;

        public void passdet()
        {
            Console.WriteLine("Enter the Your Name :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Your Age :");
            age = Console.ReadLine();
            Console.WriteLine("Enter Your destination :");
            destination = Console.ReadLine();
            Console.WriteLine("Enter from Airport or City :");
            from = Console.ReadLine();
            Console.WriteLine("Enter Date in dd/mm/yyyy :");
            date = Console.ReadLine();
        }
    }
    class ebook : bookticket

    {
        int num;
        public void ebookf()
        {
            Console.WriteLine("Enter the number of passenger who want(s) to travel :");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.Clear();
                Console.WriteLine("Enter the detail of " + i + " passenger :");
                passdet();

            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            ebook e = new ebook();
            e.ebookf();
            Console.WriteLine("Happy Journey!!!!!!");
            Console.ReadLine();
        }
    }
}
// 3. Weight of Luggage

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weightcal
{
    class weight
    {
        int cls;
        double maw, weigh, res;

        public void checkcls()
        {
            Console.WriteLine("Enter the class you wantto travel:");
            Console.WriteLine("1>> for First class!!!!!");
            Console.WriteLine("2>> for Business class!!!!!");
            Console.WriteLine("3>> for Economy class!!!!!");
            cls = Convert.ToInt32(Console.ReadLine());
            switch (cls)
            {
                case 1:
                    maw = 50;
                    ckeckwei();
                    break;
                case 2:
                    maw = 40;
                    ckeckwei();
                    break;
                case 3:
                    maw = 20;
                    ckeckwei();
                    break;
                default:
                    Console.WriteLine("invalid option entered!!!!!");
                    break;
            }

        }
        public void ckeckwei()
        {
            Console.WriteLine("max allowable weight is :" + maw);
            Console.WriteLine("Enter the total luggage weight:");
            weigh = Convert.ToDouble(Console.ReadLine());
            if (maw > (weigh))
            {
                Console.WriteLine("Weight is under allowable limit!!!!!");
            }
            if (maw < (weigh))
            {
                Console.WriteLine("Over weight will be charged @ 2$/kg");
                Console.WriteLine("Weight is over than allowable limit!!!!!");
                res = weigh - maw;
                Console.WriteLine("additional charged weight is:" + res + " kg");
                res = 2 * res;
                Console.WriteLine("additional cost is (in $): " + res + " $");
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            weight w = new weight();
            w.checkcls();
            Console.ReadLine();
        }
    }
}


// 4. The development team of SoftSols Inc. has revamped the software according to the
// requirements of FlyHigh Airlines and is in the process of testing the software.
// While testing the software, the team encounters the following issues: 

// The operations - related data of FlyHigh Airlines is stored in a central database.
// The software fails to respond to user inputs, if there is a connectivity problem with
// the database. Add the code snippet that the development team should use to ensure that
// the application shows a userfriendly message, if such a situation arises in future.

//The application used to calculate the cost of carrying additional luggage results in erroneous amount,
//if the weight of the luggage is a fractional number. Help the development team modify the code snippet
//so that the cost of carrying additional luggage is calculated correctly.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weightcal
{
    class weight
    {
        int cls;
        double maw, res, weigh;
        string mass;

        public void str()
        {
            Console.WriteLine("Enter the total luggage weight:");
            mass = Console.ReadLine();

        }


        public void strchk()
        {
            str();

            if (mass.Contains('/'))
            {
                string[] st = mass.Split('/');

                double i = Convert.ToDouble(st[0]);
                double j = Convert.ToDouble(st[1]);
                // Console.WriteLine(st[0]);
                // Console.WriteLine(st[1]);
                weigh = i / j;
                ckeckwei();
            }
            if (!(mass.Contains('/')))
            {
                weigh = Convert.ToDouble(mass);
                ckeckwei();

            }
        }

        public void checkcls()
        {
            Console.WriteLine("Enter the class you wantto travel:");
            Console.WriteLine("1>> for First class!!!!!");
            Console.WriteLine("2>> for Business class!!!!!");
            Console.WriteLine("3>> for Economy class!!!!!");
            cls = Convert.ToInt32(Console.ReadLine());
            switch (cls)
            {
                case 1:
                    maw = 50;
                    strchk();
                    break;
                case 2:
                    maw = 40;
                    strchk();
                    break;
                case 3:
                    maw = 20;
                    strchk();
                    break;
                default:
                    Console.WriteLine("invalid option entered!!!!!");
                    break;
            }

        }
        public void ckeckwei()
        {


            Console.WriteLine("max allowable weight is :" + maw);

            if (maw > weigh)
            {
                Console.WriteLine("Weight is under allowable limit!!!!!");
            }
            if (maw < weigh)
            {
                Console.WriteLine("Over weight will be charged @ 2$/kg");
                Console.WriteLine("Weight is over than allowable limit!!!!!");
                res = weigh - maw;
                float temp = (float)res;
                Console.WriteLine("additional charged weight is:" + temp + " kg");
                res = 2 * res;
                temp = (float)res;
                Console.WriteLine("additional cost is (in $): " + temp + " $");
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            weight w = new weight();
            w.checkcls();
            Console.ReadLine();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace message

{

    class select
    {
        string user, aftid;
        public void usrd()
        {
            Console.WriteLine("Enter the maint. personal user name:");
            user = Console.ReadLine().ToLower();
            if (user == "ankit" || user == "karishma")
            {
                aftdet();
            }

            else
            {
                Console.WriteLine("Please enter a valid user Name!!!!!!");
            }
        }

        public void aftdet()
        {
            Console.WriteLine("Enter the vaild Aircraft ID:");
            aftid = Console.ReadLine();
            switch (aftid)
            {
                case "001":
                    Console.WriteLine("aircraft is under maint. for 1 days!");
                    break;
                case "002":
                    Console.WriteLine("aircraft is under maint. for 2 days!");
                    break;
                case "003":
                    Console.WriteLine("aircraft is under maint. for 3 days!");
                    break;
                case "004":
                    Console.WriteLine("aircraft is under maint. for 4 days!");
                    break;
                default:
                    Console.WriteLine("Aircraft ID is not Exist or Server Down!!!!!!!");
                    break;
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            select se = new select();
            se.usrd();
            Console.ReadLine();
        }
    }
}