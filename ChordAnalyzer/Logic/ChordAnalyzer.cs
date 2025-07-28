using System.Collections.Generic;
using ChordAnalyzer.Models;

namespace ChordAnalyzer.Logic
{
    public static class ChordAnalyzer
    {
        public static Chord Analyze(int[] userFrets, List<Chord> chordLibrary)
        {
            foreach (var chord in chordLibrary)
            {
                if(IsExactMatch(userFrets, chord.Frets))
                return chord;
            }

            return null;
        }

        private static bool IsExactMatch(int[] a, int[] b)
        {
            if(a.Length != b.Length)
            return false;

            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                return false;
            }
            return true;
        }
    }
}