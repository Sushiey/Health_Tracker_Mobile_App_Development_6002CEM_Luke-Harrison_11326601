using SQLite;
using System;
using System.IO;

namespace Health_Tracker.Data
{
    public class AppDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public AppDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Activity>().Wait();
        }

        public SQLiteAsyncConnection GetConnection()
        {
            return _database;
        }

        public static string GetDbPath()
        {
            string dbFileName = "HealthTracker.db3";
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), dbFileName);
        }
    }
}
