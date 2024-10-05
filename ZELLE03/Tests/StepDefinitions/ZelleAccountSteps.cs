using NUnit.Framework;
using TechTalk.SpecFlow;
using ZELLE03.SRC.Main;
namespace ZELLE03.Tests.StepDefinitions
{
    [Binding]
    public class ZelleAccountSteps
    {
        private string _accountType;
        private bool _booleanList;
        private string _listOfAccounts;
        private ZelleAccountService _zelleAccountService;

        public ZelleAccountSteps()
        {
            _zelleAccountService = new ZelleAccountService();
        }

        [Given(@"I am a (.*) user")]
        public void GivenIAmAUser(string accountType)
        {
            _accountType = accountType;
        }

        [When(@"I retrieve Zelle eligibility status (.*)")]
        public void WhenIRetrieveZelleEligibilityStatus(string booleanList)
        {
            _booleanList = booleanList == "T"; // Convert T to True, F to False
            _listOfAccounts = _zelleAccountService.GetZelleAccounts(_accountType, _booleanList);
        }

        [Then(@"I get (.*)")]
        public void ThenIGet(string expectedListOfAccounts)
        {
            Assert.AreEqual(expectedListOfAccounts, _listOfAccounts);
        }
    }
}
