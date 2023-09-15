using Assignment1;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.StepDefinitions
{
    [Binding]
    public sealed class LoginStepDeinitions
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        private readonly User login;
        private string result;

        public LoginStepDeinitions(User login)
        {
            this.login = login;
        }

        [Given("the username is \"(.*)\"")]
        public void GivenTheUserNameIs(string username)
        {
            login.Username = username == "null" ? null : username;
        }

        [Given("the password is \"(.*)\"")]
        public void GivenThePasswordIs(string password)
        {
            login.Password = password == "null" ? null : password;
        }

        [When("I try to login")]
        public void WhenITryToLogin()
        {
            result = login.Login();
        }

        [Then("the message should be \"(.*)\"")]
        public void ThenTheMessageShouldBe(string res)
        {
            result.Should().Be(res);
        }
    }
}