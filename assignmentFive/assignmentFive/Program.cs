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
            
            Person[] arrayOfLight = new Person[13];
            
            arrayOfLight[0] = new Person("Mary", "Stover");
            arrayOfLight[1] = new Person("Emma", "Hill");
            arrayOfLight[2] = new Person("Larry", "Cunningham");
            arrayOfLight[3] = new Person("Debra", "Stover");
            arrayOfLight[4]= new Person("Synetta", "Fields");
            arrayOfLight[5]=new Person("Tierian", "Stover");
            arrayOfLight[6]=new Person("Tierra", "Stover");
            arrayOfLight[7] =new Person("Larry", "Stover");
            arrayOfLight[8] = new Person("Randall", "Fields");
            arrayOfLight[9]=new Person("Tatiana", "Stover");
            arrayOfLight[10]= new Person("Tashiana", "Stover");
            arrayOfLight[11]= new Person("Traymaine", "Smith");
            arrayOfLight[12]= new Person("Tayviyon", "Stover");

            Console.WriteLine("\n\tThe Stover/Cunningham Family Tree (4 Generations)\n");

            for(int i =0; i <arrayOfLight.Length; i++)
            {
                Console.WriteLine(arrayOfLight[i].GetPerson());
         
            }
            Console.ReadKey();
        }
    }
    
    }

