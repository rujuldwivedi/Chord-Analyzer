using System.Collections.Generic;

namespace ChordAnalyzer.Models
{
    public static class ChordLibrary
    {
        public static List<Chord> GetAllChords()
        {
            return new List<Chord>
            {
                new Chord("C Major", new int[] { 0, 3, 2, 0, 1, 0 }),
                new Chord("G Major", new int[] { 3, 2, 0, 0, 0, 3 }),
                new Chord("D Major", new int[] { -1, -1, 0, 2, 3, 2 }),
                new Chord("E Minor", new int[] { 0, 2, 2, 0, 0, 0 }),
                new Chord("A Minor", new int[] { -1, 0, 2, 2, 1, 0 }),
                new Chord("F Major", new int[] { 1, 3, 3, 2, 1, 1 })
            };
        }
    }
}