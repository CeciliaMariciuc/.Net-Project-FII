﻿namespace Autentification.Model
{
    public class UserDatabaseSettings : IUsersDatabaseSettings
    {
        public string UserCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IUsersDatabaseSettings
    {
        string UserCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
