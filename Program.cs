using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    //public class A
    //{
    //    public virtual void Abc()
    //    {
    //        Console.WriteLine("base class Method");
    //    }
    //}

    //public class B:A
    //{
    //    public override void Abc()
    //    {
    //        Console.WriteLine("Child class Method");
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            // Create Customer Objects
            Customer customr1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };
            Customer customr2 = new Customer()
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000
            };
            Customer customr3 = new Customer()
            {
                ID = 104,
                Name = "Rob",
                Salary = 5500
            };
            //B b1 = new B();
            //b1.Abc();



            Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();
            dictionaryCustomers.Add(customr1.ID, customr1);
            dictionaryCustomers.Add(customr2.ID, customr2);
            dictionaryCustomers.Add(customr3.ID, customr3);

           
            if (!dictionaryCustomers.ContainsKey(105))
            {
                dictionaryCustomers.Add(105, customr1);
            }
            Customer customer999;


            if (dictionaryCustomers.TryGetValue(999, out customer999))
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer999.ID,
                customer999.Name, customer999.Salary);
            }
            else
            {
                customer999 = new Customer()
                {
                    ID = 999,
                    Name = "Rob",
                    Salary = 5500
                };


                Console.WriteLine("Customer with Key = 999 is not found in the dictionary ");
                Console.WriteLine("Adding it to the Dictionary");

                Console.WriteLine("-------------------------------------------------------------------");
                //customer999.ID = 999;
                //customer999.Name = "Jane";
                //customer999.Salary = 7000;
                dictionaryCustomers.Add(customer999.ID, customer999);
            }
            foreach (KeyValuePair<int, Customer> item in dictionaryCustomers)
            {
                Console.WriteLine("Key={0}", item.Key);
            }
            Console.ReadLine();
        }
    }
}




