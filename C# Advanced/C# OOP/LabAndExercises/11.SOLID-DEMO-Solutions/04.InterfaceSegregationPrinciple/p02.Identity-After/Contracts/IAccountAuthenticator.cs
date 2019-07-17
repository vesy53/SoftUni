﻿namespace p02.Identity_After.Contracts
{
    public interface IAccountAuthenticator
    {
        void Register(string username, string password);

        void Login(string username, string password);
    }
}
