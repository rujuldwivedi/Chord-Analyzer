namespace ChordAnalyzer.Models
{
    public class Chord
    {
        public string Name { get; set; }
        public int[] Frets { get; set; }  // E A D G B e

        public Chord(string name, int[] frets)
        {
            Name = name;
            Frets = frets;
        }

        public override string ToString()
        {
            return $"{Name} - Frets: [{string.Join(", ", Frets)}]";
        }
    }
}