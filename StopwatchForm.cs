using Krypton.Toolkit;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WhaleTrack
{
    public partial class StopwatchForm : KryptonForm
    {
        Stopwatch sw;
        Timer timer;
        MainForm main;

        DateTime dateStarted;

        public bool running { get => sw.IsRunning; }
        public bool unsaved { get => sw.ElapsedMilliseconds > 0; }

        public StopwatchForm(MainForm main)
        {
            this.main = main;
            Rectangle workingArea = Screen.GetWorkingArea(this);
            InitializeComponent();
            this.Location = new Point(workingArea.Right - Size.Width - 8,
                                      workingArea.Bottom - Size.Height - 8);

            timer = new Timer();

            timer.Interval = 100;
            timer.Tick += RefreshTime;
            timer.Start();

            sw = new Stopwatch();

            Deactivate += (s1, e1) => UpdatePanelColor();
            Activated += (s1, e1) => UpdatePanelColor();

            UpdateDate(DateTime.Today);
        }

        private void RefreshTime(object sender, EventArgs e)
        {
            stopwatchLabel.Text = sw.Elapsed.ToString("hh\\:mm\\:ss");
            stopwatchLabel.Refresh();
        }

        private TimeSpan NormalizeTimeSpan(TimeSpan time)
        {
            return time.Subtract(TimeSpan.FromMilliseconds(time.Milliseconds));
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            pauseBtn.Enabled = true;
            sw.Start();
            timer.Start();
        }

        private void kryptonCheckButton2_Click(object sender, EventArgs e)
        {
            sw.Stop();
            timer.Stop();
        }

        private void finishTaskBtn_Click(object sender, EventArgs e)
        {
            sw.Stop();
            timer.Stop();
            startPauseCheckSet.CheckedIndex = 1;
            using (var addTaskDlg = new AddTask(dateStarted, sw.Elapsed))
            {
                if (addTaskDlg.ShowDialog(main) == DialogResult.OK)
                {
                    main.AddTaskToDB(addTaskDlg.task);
                    startPauseCheckSet.CheckedIndex = -1;
                    pauseBtn.Enabled = false;
                    sw.Reset();
                    RefreshTime(sender, e);
                    UpdateDate(DateTime.Today);
                }
            }
        }

        // TODO: make this change the panel color
        private void UpdatePanelColor()
        {
            //kryptonSplitContainer1.BackColor;
        }

        public void UpdateDate(DateTime date)
        {
            dateStarted = date;
            dateLabel.Text = date.ToLongDateString();
        }
    }
}
