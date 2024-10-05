namespace ZELLE03.SRC.Main
{
    public class ZelleAccountService
    {
        public string GetZelleAccounts(string accountType, bool isEligible)
        {
            if (accountType == "Retail")
            {
                return "Retail Zelle";
            }
            else if (accountType == "Business")
            {
                return "Business Zelle";
            }
            else if (accountType == "No accounts/not eligible")
            {
                return "False";
            }
            else if (accountType == "Mixed Retail/Business")
            {
                return isEligible ? "Based on user choice" : "No Zelle accounts";
            }

            return "Invalid account type";
        }
    }
}
