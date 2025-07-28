using System.Collections.Generic;
using ChordAnalyzer.Models;

namespace ChordAnalyzer.Logic
{
    public static class PracticeRecommender
    {
        public static List<Chord> SuggestNextChords(string level)
        {
            var all = ChordLibrary.GetAllChords();
            List<Chord> recommended = new List<Chord>();

            switch (level)
            {
                case "beginner":
                {
                    recommended.Add(all.Find(c => c.Name == "C Major"));
                    recommended.Add(all.Find(c => c.Name == "G Major"));
                    recommended.Add(all.Find(c => c.Name == "E Minor"));
                    break;
                }

                case "intermediate":
                {
                    recommended.Add(all.Find(c => c.Name == "A Minor"));
                    recommended.Add(all.Find(c => c.Name == "F Major"));
                    break;
                }

                case "advanced":
                {
                    recommended.Add(new Chord("B Minor", new int[] { 2, 2, 4, 4, 3, 2 }));
                    recommended.Add(new Chord("Gmaj7", new int[] { 3, 2, 0, 0, 0, 2 }));
                    break;
                }

                default:
                break;
            }

            return recommended;
        }
    }
}
