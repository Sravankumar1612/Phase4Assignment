using Assignment1;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly User login;
        private string result;
       
        public CalculatorStepDefinitions(User login)
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