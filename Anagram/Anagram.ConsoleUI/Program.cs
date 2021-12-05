// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Anagram.ConsoleUI
{
    using System;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Console App with ui for string input and reversed string output.
    /// </summary>
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