using Microsoft.Extensions.DependencyInjection;
using System;

namespace Anagram
{
    public class Program
    {
        private static void Main()
        {
            string myString = Console.ReadLine();

            ServiceCollection serviceCollection = new ServiceCollection();

            serviceCollection.AddScoped<IAnagram, Anagram>();

            ServiceProvider provider = serviceCollection.BuildServiceProvider();

            IAnagram service = provider.GetRequiredService<IAnagram>();

            Console.WriteLine(service.Reverse(myString));

            Console.ReadKey();
        }
    }
}
