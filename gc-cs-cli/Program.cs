using GoCardless;
using GoCardless.Resources;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace gc_cs_cli
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync().Wait();
        }

        static async Task MainAsync()
        {

            var accessToken = "sandbox_xXXXXxx";
            var gocardless = GoCardlessClient.Create(accessToken, GoCardlessClient.Environment.SANDBOX);

            IEnumerable<Customer> customers = gocardless.Customers.All();
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id);

            }
        }
    }
}
