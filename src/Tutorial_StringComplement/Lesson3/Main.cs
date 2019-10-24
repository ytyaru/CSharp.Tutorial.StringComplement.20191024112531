using System;
using System.Collections.Generic;

namespace Tutorial_StringComplement.Lesson3
{
    class Main
    {
        public enum Unit { item, kilogram, gram, dozen };
        public void Run()
        {
            var titles = new Dictionary<string, string>()
            {
                ["Doyle, Arthur Conan"] = "Hound of the Baskervilles, The",
                ["London, Jack"] = "Call of the Wild, The",
                ["Shakespeare, William"] = "Tempest, The"
            };
            Console.WriteLine("Author and Title List");
            Console.WriteLine();
            Console.WriteLine($"|{"Author",-25}|{"Title",30}|");
            foreach (var title in titles)
                Console.WriteLine($"|{title.Key,-25}|{title.Value,30}|");

            Console.WriteLine($"|{"Author",25}|{"Title",30}|");
            foreach (var title in titles)
               Console.WriteLine($"|{title.Key,25}|{title.Value,30}|");

            Console.WriteLine($"[{DateTime.Now,-20:d}] Hour [{DateTime.Now,-10:HH}] [{1063.342,15:N2}] feet");
        }
    }
}
