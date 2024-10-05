namespace ZELLE01.Tests.StepDefinitions
{
    [Binding]
    public class ZelleAccountSteps
    {

        [Given(@"I am a (.*) user")]
        public void GivenIAmAUser(string accountType)
        {
            // TODO: Implement GivenIAmAUser
            throw new PendingStepException();
        }

        [When(@"I retrieve Zelle eligibility status (.*)")]
        public void WhenIRetrieveZelleEligibilityStatus(string booleanList)
        {
            // TODO: Implement WhenIRetrieveZelleEligibilityStatus
            throw new PendingStepException();
        }

        [Then(@"I get (.*)")]
        public void ThenIGet(string expectedListOfAccounts)
        {
            // TODO: Implement ThenIGet
            throw new PendingStepException();
        }
    }
}
