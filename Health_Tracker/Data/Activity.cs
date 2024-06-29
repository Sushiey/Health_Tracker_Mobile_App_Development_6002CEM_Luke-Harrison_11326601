using SQLite;
using System;

namespace Health_Tracker.Data
{
    public class Activity
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int Steps { get; set; }
    }
}

