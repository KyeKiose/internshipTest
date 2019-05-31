namespace InternshipTest
{
    public class Knowledge
    {
        int levelOfKnowledge;
        public Knowledge(int level)
        {
            LevelOfKnowledge = level;
        }
        public int LevelOfKnowledge
        {
            get
            {
                return levelOfKnowledge;
            }
            set
            {
                if (value >= 0 && value <= 100)
                    levelOfKnowledge = value;
            }
        }
    }
}
