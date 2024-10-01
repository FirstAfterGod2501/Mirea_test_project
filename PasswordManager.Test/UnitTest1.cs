namespace PasswordManager.Test;

[TestFixture]
public class PasswordManagerTests
{
    private App.PasswordManager _passwordManager = null!;

    [SetUp]
    public void Setup()
    {
        _passwordManager = new App.PasswordManager();
    }

    [Test]
    public void AddPassword_ShouldStorePassword()
    {
        _passwordManager.AddPassword("example.com", "password123");
        var password = _passwordManager.GetPassword("example.com");
        Assert.That(password, Is.EqualTo("password123"));
    }

    [Test]
    public void GetPassword_ShouldReturnNullIfNotFound()
    {
        var password = _passwordManager.GetPassword("nonexistent.com");
        Assert.AreEqual(password, string.Empty);
    }
}