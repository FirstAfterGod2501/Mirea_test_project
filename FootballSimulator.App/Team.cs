namespace FootballSimulator.App
{
    public class Team(string name)
    {
        public string Name { get; } = name;
        public int Score { get; private set; }

        public void ScoreGoal() => Score++;
    }
}