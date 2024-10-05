using NUnit.Framework;
using TechTalk.SpecFlow;

namespace ZELLO2.Tests.StepDefinitions
{
    [Binding]
    public class ZelleAccountSteps
    {
        private string _accountType;
        private bool _booleanList;
        private string _listOfAccounts;

        [Given(@"I am a (.*) user")]
        public void GivenIAmAUser(string accountType)
        {
            // Set the account type based on the input in the scenario
            _accountType = accountType;
        }

        [When(@"I retrieve Zelle eligibility status (.*)")]
        public void WhenIRetrieveZelleEligibilityStatus(string booleanList)
        {
            // Convert the string "T" or "F" into a boolean for use in the logic
            _booleanList = booleanList == "T";

            // Implement the logic to determine which Zelle accounts are available
            if (_accountType == "Retail")
            {
                _listOfAccounts = "Retail Zelle";
            }
            else if (_accountType == "Business")
            {
                _listOfAccounts = "Business Zelle";
            }
            else if (_accountType == "No accounts/not eligible")
            {
                _listOfAccounts = "False";
            }
            else if (_accountType == "Mixed Retail/Business")
            {
                // If the user is eligible (booleanList is true), give user choice, otherwise no Zelle accounts
                _listOfAccounts = _booleanList ? "Based on user choice" : "No Zelle accounts";
            }
            else
            {
                _listOfAccounts = "Invalid account type";
            }
        }

        [Then(@"I get (.*)")]
        public void ThenIGet(string expectedListOfAccounts)
        {
            // Assert that the calculated list of accounts matches the expected outcome from the scenario
            Assert.AreEqual(expectedListOfAccounts, _listOfAccounts);
        }
    }
}
