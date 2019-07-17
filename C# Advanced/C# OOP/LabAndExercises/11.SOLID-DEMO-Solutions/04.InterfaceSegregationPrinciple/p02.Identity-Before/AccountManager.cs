namespace p02.Identity_Before
{
    using System;
    using System.Collections.Generic;

    using Contracts;

    public class AccountManager : IAccount
    {
        public bool RequireUniqueEmail { get; set; }

        public int MinRequiredPasswordLength { get; set; }

        public int MaxRequiredPasswordLength { get; set; }

        public void Register(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void ChangePassword(string oldPass, string newPass)
        {
            // change password
        }

        public IEnumerable<IUser> GetAllUsersOnline()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IUser> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public IUser GetUserByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
