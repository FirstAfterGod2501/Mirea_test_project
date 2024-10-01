namespace FootballSimulator.App;

public class Match
{
    private Team TeamA { get; }
    private Team TeamB { get; }

    public Match(Team teamA, Team teamB)
    {
        TeamA = teamA;
        TeamB = teamB;
    }

    public string GetScore()
    {
        return $"{TeamA.Name} {TeamA.Score} - {TeamB.Name} {TeamB.Score}";
    }

    public string GetWinner() => TeamA.Score > TeamB.Score ? TeamA.Name : TeamB.Score > TeamA.Score ? TeamB.Name : "Draw";
}