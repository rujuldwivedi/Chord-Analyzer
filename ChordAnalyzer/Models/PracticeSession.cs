namespace ChordAnalyzer.Models
{
    public class PracticeSession
    {
        public string SkillLevel
        {
            get;
            set;
        }

        public PracticeSession(string level)
        {
            SkillLevel = level;
        }
    }
}