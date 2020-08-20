using System;
using System.Collections.Generic;

namespace Planets_and_Spaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            // In the Main mtho, place the following code:
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            Console.WriteLine($"Planets so far: {string.Join(", ", planetList)}");

            // 1. `Add()` Jupiter and Saturn at the end of the list.
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            Console.WriteLine($"Add Jupiter and Saturn: {string.Join(", ", planetList)}");

            // 2.Create another `List` that contains that last two planet of our solar system.
            List<string> lastTwoPlanets = new List<string>() { "Uranus", "Neptune" };

            // 3.Combine the two lists by using `AddRange()`.
            planetList.AddRange(lastTwoPlanets);
            Console.WriteLine($"Add the last two planets: {string.Join(", ", planetList)}");

            // 4.Use `Insert()` to add Earth, and Venus in the correct order.
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            Console.WriteLine($"Add Venus and Earth: {string.Join(", ", planetList)}");

            // 5.Use `Add()` again to add Pluto to the end of the list.
            planetList.Add("Pluto");
            Console.WriteLine($"Add Pluto: {string.Join(", ", planetList)}");

            // 6.Now that all the planets are in the list, slice the list using `GetRange()` in order to extract the rocky planets into a new list called `rockyPlanets`.
            var rockyPlanets = planetList.GetRange(0, 4);
            Console.WriteLine($"Rocky planets only: {string.Join(", ", rockyPlanets)}");

            // 7.Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the `Remove()` method to eliminate it from the end of `planetList`.
            planetList.Remove("Pluto");
            Console.WriteLine($"Remove Pluto: {string.Join(", ", planetList)}");
        }
    }
}
