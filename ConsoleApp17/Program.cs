using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new CustomersContext())
            {
                List<CustomersDetails> customersDetails = context.CustomersDetails.ToList();
                foreach (var customerDetailss in customersDetails)
                {
                    Console.WriteLine(customerDetailss.Location);
                }
                    

            }
        }
    }
}
