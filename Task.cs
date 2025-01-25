using SQLite;
using System;
using System.Data;

namespace WhaleTrack
{
    [Table("tasks")]
    public class Task
    {
        [PrimaryKey, AutoIncrement, Column("id")]
        public int Id { get; set; }
        [Column("type")]
        public TaskType Type { get; set; } = TaskType.Standard;
        [Column("date")]
        public DateTime Date { get; set; } = DateTime.Today;
        [Column("description")]
        public string Description { get; set; }
        // Time, in whole seconds
        [Column("time")]
        public int Time { get; set; }

        public void AddToDataTable(DataTable dt)
        {
            dt.Rows.Add(new object[] { Id, Type, Date, Description, TimeSpan.FromSeconds(Time) });
        }
    }

    public enum TaskType
    {
        Standard,
        Water
    }

    public class TaskTime
    {
        private TimeSpan span;

        public int TotalSeconds => (int)span.TotalSeconds;

        public static implicit operator TimeSpan(TaskTime self)
        {
            return self.span;
        }

        public static explicit operator TaskTime(TimeSpan v)
        {
            return new TaskTime { span = v };
        }

        public static TaskTime FromSeconds(int time)
        {
            return new TaskTime { span = TimeSpan.FromSeconds(time) };
        }

        public override string ToString()
        {
            return $"{((int)span.TotalHours):D2}:{span.ToString("mm\\:ss")}";
        }

        public static TaskTime operator +(TaskTime a, TaskTime b)
        {
            return new TaskTime { span = TimeSpan.FromSeconds(a.TotalSeconds + b.TotalSeconds) };
        }
    }
}
