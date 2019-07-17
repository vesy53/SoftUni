namespace p02.Identity_After.Contracts
{
    public interface IAccountManager
    {
        void ChangePassword(string oldPass, string newPass);
    }
}
