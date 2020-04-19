using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentFive
{
    class Program
    {
        static void Main()
        {
            Person[] arrayOfLight = new Person[9];

            arrayOfLight[0] = new Person("Larry", "Cunningham");
            arrayOfLight[1]= new Person("Synetta", "Fields");
            arrayOfLight[2]=new Person("Tierian", "Stover");
            arrayOfLight[3]=new Person("Tierra", "Stover");
            arrayOfLight[4] =new Person("Larry", "Stover");
            arrayOfLight[5]=new Person("Tatiana", "Stover");
            arrayOfLight[6]= new Person("Tashiana", "Stover");
            arrayOfLight[7]= new Person("Traymaine", "Smith");
            arrayOfLight[8]= new Person("Tayviyon", "Stover");

            for(int i =0; i <arrayOfLight.Length; i++)
            {
                Console.WriteLine(arrayOfLight[i].GetPerson());
         
            }
            Console.ReadKey();
        }
    }
    
    }

