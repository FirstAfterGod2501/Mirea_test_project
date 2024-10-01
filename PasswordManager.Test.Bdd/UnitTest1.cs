// File: PasswordManager.Specs/Steps/PasswordManagerSteps.cs

using TechTalk.SpecFlow;

namespace PasswordManager.Test.Bdd
{
    [Binding]
    public class PasswordManagerSteps
    {
        private App.PasswordManager _passwordManager = null!;
        private string _retrievedPassword = null!;

        [Given("I have a password manager")]
        public void GivenIHaveAPasswordManager()
        {
            _passwordManager = new App.PasswordManager();
        }

        [When(@"I add a password ""(.*)"" for ""(.*)""")]
        public void WhenIAddAPasswordFor(string password, string site)
        {
            _passwordManager.AddPassword(site, password);
        }

        [Then(@"I should be able to retrieve the password ""(.*)"" for ""(.*)""")]
        public void ThenIShouldBeAbleToRetrieveThePasswordFor(string expectedPassword, string site)
        {
            _retrievedPassword = _passwordManager.GetPassword(site);
            Assert.That(_retrievedPassword, Is.EqualTo(expectedPassword));
        }
    }
}