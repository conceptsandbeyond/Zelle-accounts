using Moq;
using NUnit.Framework;
using ZELLE04.SRC.Main;

namespace ZELLE04.Tests.StepDefinitions
{
    [Binding]
    public class ZelleAccountSteps
    {
        private string _accountType;
        private bool _booleanList;
        private string _listOfAccounts;

        // Moq object to simulate the ZelleAccountService
        private Mock<IZelleAccountService> _zelleAccountServiceMock;

        public ZelleAccountSteps()
        {
            _zelleAccountServiceMock = new Mock<IZelleAccountService>();
        }

        [Given(@"I am a (.*) user")]
        public void GivenIAmAUser(string accountType)
        {
            // Set the account type as per the scenario
            _accountType = accountType;
        }

        [When(@"I retrieve Zelle eligibility status (.*)")]
        public void WhenIRetrieveZelleEligibilityStatus(string booleanList)
        {
            // Convert boolean_list from "T"/"F" to a boolean value
            _booleanList = booleanList == "T";

            // Set up Moq to simulate different results based on account type and eligibility
            _zelleAccountServiceMock
                .Setup(service => service.GetZelleAccounts(_accountType, _booleanList))
                .Returns((string accountType, bool isEligible) =>
                {
                    if (accountType == "Retail")
                        return "Retail Zelle";
                    if (accountType == "Business")
                        return "Business Zelle";
                    if (accountType == "No accounts/not eligible")
                        return "False";
                    if (accountType == "Mixed Retail/Business")
                        return isEligible ? "Based on user choice" : "No Zelle accounts";

                    return "Invalid account type";
                });

            // Use the mock service to get the list of accounts
            _listOfAccounts = _zelleAccountServiceMock.Object.GetZelleAccounts(_accountType, _booleanList);
        }

        [Then(@"I get (.*)")]
        public void ThenIGet(string expectedListOfAccounts)
        {
            // Verify that the expected list matches the result
            Assert.AreEqual(expectedListOfAccounts, _listOfAccounts);

            // Verify that the mock service method was called exactly once with the right parameters
            _zelleAccountServiceMock.Verify(service => service.GetZelleAccounts(_accountType, _booleanList), Times.Once);
        }
    }
}
