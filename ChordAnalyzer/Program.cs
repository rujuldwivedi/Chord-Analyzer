using System;
using System.Collections.Generic;
using ChordAnalyzer.Models;
using ChordAnalyzer.Logic;

namespace ChordAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to the Guitar Chord Analyzer! ");

            Console.WriteLine("\nEnter frets for E A D G B e strings (use -1 for muted):");
            int[] userFrets = new int[6];

            string[] strings = { "E", "A", "D", "G", "B", "e" };

            for (int i = 0; i < 6; i++)
            {
                Console.Write($"{strings[i]}: ");
                userFrets[i] = int.Parse(Console.ReadLine());
            }

            var matched = ChordAnalyzer.Logic.ChordAnalyzer.Analyze(userFrets, ChordLibrary.GetAllChords());

            if(matched != null)
            {
                Console.WriteLine($"\nYou played: {matched}");

                Console.Write("\nEnter your skill level (beginner/intermediate/advanced): ");

                string level = Console.ReadLine().Trim().ToLower();

                var suggestions = PracticeRecommender.SuggestNextChords(level);

                Console.WriteLine("\n Recommended Chords to Practice:");

                suggestions.ForEach(c => Console.WriteLine("- " + c));
            }
            else
            Console.WriteLine("No matching chord found.");
        }
    }
}
