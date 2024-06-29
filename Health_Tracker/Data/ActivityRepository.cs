using SQLite;
using System;
using System.Threading.Tasks;

namespace Health_Tracker.Data
{
    public class ActivityRepository
    {
        private readonly SQLiteAsyncConnection _database;

        public ActivityRepository(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Activity>().Wait();
        }

        public Task<Activity> GetActivityByDateAsync(DateTime date)
        {
            return _database.Table<Activity>().FirstOrDefaultAsync(a => a.Date == date);
        }

        public Task SaveActivityAsync(Activity activity)
        {
            if (activity.Id != 0)
            {
                return _database.UpdateAsync(activity);
            }
            else
            {
                return _database.InsertAsync(activity);
            }
        }

    }
}
