using Krypton.Toolkit;
using System;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;
using SQLite;
using System.Threading.Tasks;

namespace WhaleTrack
{
    public partial class MainForm : KryptonForm
    {
        private StopwatchForm swForm;

        private NotifyIcon notifyIcon;

        private SQLiteConnection db;

        public MainForm()
        {
            InitializeComponent();
            ConstructNotifyIcon();

            FormClosing += WindowClosing;
            Resize += WindowResize;
            DayChangedNotifier.DayChanged += DayChangedNotifier_DayChanged;

            swForm = new StopwatchForm(this);

            LoadData();
            SelectDate(DateTime.Today);
        }

        private void DayChangedNotifier_DayChanged(object sender, DayChangedEventArgs e)
        {
            taskCalendar.TodayDate = DateTime.Today;
            if (!swForm.unsaved) swForm.UpdateDate(taskCalendar.TodayDate);
        }

        private void ConstructNotifyIcon()
        {
            notifyIcon = new NotifyIcon()
            {
                Text = this.Text,
                Icon = this.Icon,
                Visible = true,
            };
            notifyIcon.DoubleClick += SystemTrayIconDoubleClick;

            var stopwatchItem = new ToolStripMenuItem("Show Stopwatch", null)
            {
                Name = "stopwatchItem",
                CheckOnClick = true
            };
            stopwatchItem.CheckedChanged += StopwatchItem_CheckedChanged;

            notifyIcon.ContextMenuStrip = new ContextMenuStrip()
            {
                Items =
                {
                    stopwatchItem,
                    new ToolStripSeparator(),
                    new ToolStripMenuItem("Exit", null, ContextMenuExit)
                }
            };
        }

        private void LoadData()
        {
            db = new SQLiteConnection("whaletrack.db");
            db.CreateTable<Task>();

            /*var testTask = new Task { Date = DateTime.Today, Description = "hello this is a test", Time = (int)TimeSpan.FromHours(3.1415).TotalSeconds };

            db.Insert(testTask);*/

            ReloadData();
        }

        private void ReloadData()
        {
            dataTable.Clear();
            foreach (var task in db.Table<Task>().ToList())
            {
                task.AddToDataTable(dataTable);
            }
            dataTable.AcceptChanges();
            taskDataGridView.DataSource = dataTable;
            UpdateCalendarView();
            UpdateTotalTime();
        }

        private void StopwatchItem_CheckedChanged(object sender, EventArgs e)
        {
            SetStopwatchVisible(((ToolStripMenuItem)sender).Checked);
        }

        private void stopwatchBtn_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName != "Checked") return;
            SetStopwatchVisible(stopwatchBtn.Checked);
        }

        private void SetStopwatchVisible(bool visible)
        {
            swForm.Visible = stopwatchBtn.Checked = visible;
            if (notifyIcon.ContextMenuStrip == null) return;
            
            var stopwatchItem = notifyIcon.ContextMenuStrip.Items["stopwatchItem"];
            if (stopwatchItem == null) return;

            ((ToolStripMenuItem)stopwatchItem).Checked = visible;
        }

        private void SystemTrayIconDoubleClick(object sender, EventArgs e)
        {
            if (!Visible)
            {
                WindowState = FormWindowState.Minimized;
                Show();
                WindowState = FormWindowState.Normal;
            }
            Activate();
        }

        private void ContextMenuExit(object sender, EventArgs e)
        {
            if (swForm.running)
            {
                var result = KryptonMessageBox.Show(
                "You have a stopwatch running, are you sure you want to exit?",
                "WhaleTrack",
                KryptonMessageBoxButtons.YesNo,
                KryptonMessageBoxIcon.Warning,
                KryptonMessageBoxDefaultButton.Button2);

                if (result != DialogResult.Yes) return;
            }
            if (swForm.unsaved && !swForm.running)
            {
                var result = KryptonMessageBox.Show(
                "You have an unsaved stopwatch time, are you sure you want to exit?",
                "WhaleTrack",
                KryptonMessageBoxButtons.YesNo,
                KryptonMessageBoxIcon.Warning,
                KryptonMessageBoxDefaultButton.Button2);

                if (result != DialogResult.Yes) return;
            }
            notifyIcon.Visible = false;
            Application.Exit();
            Environment.Exit(0);
        }

        private void WindowResize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized) Hide();
        }

        private void WindowClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void SelectDate(DateTime date)
        {
            if (taskCalendar.SelectionStart != date) taskCalendar.SelectionStart = date;

            // filter and update data
            dataTable.DefaultView.RowFilter = $"Date = '{date}'";
            taskDataGridView.DataSource = dataTable;

            // update text
            taskHeaderGroup.ValuesPrimary.Heading = date.ToLongDateString();
            taskHeaderGroup.ValuesSecondary.Heading = $"Daily: {GetTimeForDate(date)}";
        }

        private void UpdateCalendarView()
        {
            var taskDates = new List<DateTime>();

            foreach (DataRow row in dataTable.Rows)
            {
                taskDates.Add((DateTime)row[2]);
            }

            taskCalendar.BoldedDates = taskDates.ToArray();
        }

        private void UpdateTotalTime()
        {
            taskHeaderGroup.ValuesSecondary.Description = $"Total: {GetTotalTime()}";
        }

        private TaskTime GetTimeForDate(DateTime date)
        {
            var time = new TaskTime();
            var timeSum = dataTable.Compute("Sum(Time)", $"Date = '{date}'");

            if (!Convert.IsDBNull(timeSum) && timeSum != null) time = (TaskTime)(TimeSpan)timeSum;

            return time;
        }

        private TaskTime GetTotalTime()
        {
            var time = new TaskTime();
            var timeSum = dataTable.Compute("Sum(Time)", "");

            if (!Convert.IsDBNull(timeSum) && timeSum != null) time = (TaskTime)(TimeSpan)timeSum;

            return time;
        }

        private void SelectedDateChanged(object sender, DateRangeEventArgs e)
        {
            SelectDate(e.Start);
        }

        private void kryptonRibbonGroupButton1_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void addTaskBtn_Click(object sender, EventArgs e)
        {
            using (var addTaskDlg = new AddTask(taskCalendar.SelectionStart))
            {
                if (addTaskDlg.ShowDialog(this) == DialogResult.OK)
                {
                    AddTaskToDB(addTaskDlg.task);
                }
            }
        }

        private void editTaskBtn_Click(object sender, EventArgs e)
        {
            KryptonMessageBox.Show("bruh", "bruh", buttons: KryptonMessageBoxButtons.OKCancel);
        }

        public void AddTaskToDB(Task task)
        {
            db.Insert(task);
            ReloadData();
        }

        private void deleteTaskBtn_Click(object sender, EventArgs e)
        {
            var taskRow = ((DataRowView)taskDataGridView.SelectedRows[0].DataBoundItem).Row;

            var result = KryptonMessageBox.Show(
                $"Are you sure you want to delete this task?\n\n\"{taskRow[3]}\"", 
                "Delete Task", 
                KryptonMessageBoxButtons.YesNo,
                KryptonMessageBoxIcon.Warning,
                KryptonMessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                db.Delete<Task>(taskRow[0]);
                ReloadData();
            }
        }
    }
}
