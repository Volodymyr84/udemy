using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        class Address
        {
            string index;
            string country;
            string sity;
            string street;
            string house;
            string appartment;

            public string Index
            {
                get { return index; }
                set { index = value; }
            }
            public string Country
            {
                get { return country; }
                set { country = value; }
            }
            public string Sity
            {
                get { return sity; }
                set { sity = value; }
            }
            public string Street
            {
                get { return street; }
                set { street = value; }
            }
            public string House
            {
                get { return house; }
                set { house = value; }
            }
            public string Appartment
            {
                get { return appartment; }
                set { appartment = value; }
            }
        }
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Index = "11111";
            address.Country = "Ukraine";
            address.Sity = "Lvov";
            address.Street = "kol";
            address.House = "19";
            address.Appartment = "502";

            Console.WriteLine(address.Index);
            Console.WriteLine(address.Country);
            Console.WriteLine(address.Sity);
            Console.WriteLine(address.Street);
            Console.WriteLine(address.House);
            Console.WriteLine(address.Appartment);

            Console.ReadKey();


        }
        
    }
}
