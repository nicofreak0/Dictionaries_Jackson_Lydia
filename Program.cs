using System;
// generic collection namespace for dictionary
using System.Collections.Generic;
// non generic collection namespace for hashtable
using System.Collections;

namespace Dictionaries_Jackson_Lydia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creates a dictionary to store top games and their ranks
            Dictionary<int, string> topGames = new Dictionary<int, string>();

            // adds key value pairs to the dictionary where key is rank and value is the games
            topGames.Add(1, "The Stanley Parable");
            topGames.Add(2, "Animal Crossing");
            topGames.Add(3, "Cult Of The Lamb");
            topGames.Add(4, "Gone Home");
            topGames.Add(5, "Sims 4");
            topGames.Add(6, "Borderlands 2");
            topGames.Add(7, "Never Alone");
            topGames.Add(8, "The Last Campfire");
            topGames.Add(9, "Killer Frequency");
            topGames.Add(10, "Limbo");


            // goes through each key value pair in the dictionary and prints it
            foreach (KeyValuePair<int, string> kvp in topGames)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // checks if the dictionary contains the key 1 and prints that value
            if(topGames.ContainsKey(1))
            {
                Console.WriteLine($"My Favorite Game is: {topGames[1]}.");
            }

            // try to get the value for key 11 and handle the case when the key doesnt exist
            string result = "";

            topGames.TryGetValue(11, out result);

            if (result != "")
            {
                // print the result if key 11 exists
                Console.WriteLine(result); 
            }
            else
            {
                // print to console that key 11 doesnt exist
                Console.WriteLine("There is No Game in the Eleventh Position.");
            }

            // update the value for key 5 if it exists
            if(topGames.ContainsKey(5))
            {
                topGames[5] = "Metamorphosis";
            }

            // print the updated value for key 5
            Console.WriteLine(topGames[5]);

            // convert the dictionary into a hashtable
            Hashtable hashTable = new Hashtable(topGames);

            // retrieve and print the favorite game from the hashtable using key 1
            string favGame = (string)hashTable[1];

            Console.WriteLine($"Favorite Game: {favGame}");

            // creates a hashtable with state capitals
            Hashtable capitals = new Hashtable() {
                { "Oklahoma", "Oklahoma City" },
                { "New York", "Albany" },
                { "Texas", "Austin" },
                { "Ohio", "Colombus" }
            
            };

            // goes through each key value pair in the hashtable and print it to console
            foreach (DictionaryEntry kvp in capitals)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // clear all entries in the hashtable
            capitals.Clear();
        }
    }
}