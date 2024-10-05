namespace ZELLE04.SRC.Main
{
    public interface IZelleAccountService
    {
        string GetZelleAccounts(string accountType, bool isEligible);
    }
}
