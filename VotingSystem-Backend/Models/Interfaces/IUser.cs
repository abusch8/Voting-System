﻿namespace VotingSystem.Model
{
    public interface IUser
    {
        public string SerialNumber { get; }
        public string Username { get; }
        public string Password { get; }
        public string Email { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public bool IsAdmin { get; }
    }
}
