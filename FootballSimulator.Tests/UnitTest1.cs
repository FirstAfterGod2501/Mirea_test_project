using FootballSimulator.App;

namespace FootballSimulator.Tests;

[TestFixture]
public class MatchTests
{
    [Test]
    public void GetScore_ReturnsCorrectScore()
    {
        var teamA = new Team("Team A");
        var teamB = new Team("Team B");
        teamA.ScoreGoal();
        teamB.ScoreGoal();
        teamB.ScoreGoal();

        var match = new Match(teamA, teamB);
        var score = match.GetScore();

        Assert.That(score, Is.EqualTo("Team A 1 - Team B 2"));
    }

    [Test]
    public void GetWinner_ReturnsCorrectWinner()
    {
        var teamA = new Team("Team A");
        var teamB = new Team("Team B");
        teamA.ScoreGoal();
        teamB.ScoreGoal();
        teamB.ScoreGoal();

        var match = new Match(teamA, teamB);
        var winner = match.GetWinner();

        Assert.That(winner, Is.EqualTo("Team B"));
    }

    [Test]
    public void GetWinner_ReturnsDrawWhenScoresAreEqual()
    {
        var teamA = new Team("Team A");
        var teamB = new Team("Team B");
        teamA.ScoreGoal();
        teamB.ScoreGoal();

        var match = new Match(teamA, teamB);
        var winner = match.GetWinner();

        Assert.That(winner, Is.EqualTo("Draw"));
    }
}

[TestFixture]
public class TeamTests
{
    [Test]
    public void ScoreGoal_IncreasesScoreByOne()
    {
        var team = new Team("Team A");
        team.ScoreGoal();

        Assert.That(team.Score, Is.EqualTo(1));
    }

    [Test]
    public void Constructor_SetsNameCorrectly()
    {
        var team = new Team("Team A");

        Assert.That(team.Name, Is.EqualTo("Team A"));
    }
}