using FootballSimulator.App;

namespace FootballSimulator.Tests.Bdd;

public class MatchTests
{
    private Team _teamA = null!;
    private Team _teamB = null!;
    private Match _match = null!;

    [SetUp]
    public void Setup()
    {
        _teamA = new Team("Team A");
        _teamB = new Team("Team B");
        _match = new Match(_teamA, _teamB);
    }

    [Test]
    public void GivenANewMatch_WhenStarted_ThenScoreShouldBeZeroZero()
    {
        // Given
        // Match is initialized in Setup

        // When
        var score = _match.GetScore();

        // Then
        Assert.That(score, Is.EqualTo("Team A 0 - Team B 0"));
    }

    [Test]
    public void GivenATeamScores_WhenChecked_ThenScoreShouldBeUpdated()
    {
        // Given
        _teamA.ScoreGoal();

        // When
        var score = _match.GetScore();

        // Then
        Assert.That(score, Is.EqualTo("Team A 1 - Team B 0"));
    }

    [Test]
    public void GivenBothTeamsScore_WhenChecked_ThenScoreShouldBeUpdated()
    {
        // Given
        _teamA.ScoreGoal();
        _teamB.ScoreGoal();

        // When
        var score = _match.GetScore();

        // Then
        Assert.That(score, Is.EqualTo("Team A 1 - Team B 1"));
    }

    [Test]
    public void GivenAMatch_WhenCheckedForWinner_ThenCorrectWinnerShouldBeReturned()
    {
        // Given
        _teamA.ScoreGoal();
        _teamA.ScoreGoal();
        _teamB.ScoreGoal();

        // When
        var winner = _match.GetWinner();

        // Then
        Assert.That(winner, Is.EqualTo("Team A"));
    }

    [Test]
    public void GivenADrawMatch_WhenCheckedForWinner_ThenDrawShouldBeReturned()
    {
        // Given
        _teamA.ScoreGoal();
        _teamB.ScoreGoal();

        // When
        var winner = _match.GetWinner();

        // Then
        Assert.That(winner, Is.EqualTo("Draw"));
    }
}