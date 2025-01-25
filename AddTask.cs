using System;
using System.Windows.Forms;
using Krypton.Toolkit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WhaleTrack
{
    public partial class AddTask : KryptonForm
    {
        // The added/edited task, should only be added 
        public Task task;

        public AddTask()
        {
            task = new Task();
            InitializeComponent();
        }

        public AddTask(DateTime date) : this()
        {
            task.Date = date.Date;
        }

        public AddTask(DateTime date, TimeSpan time) : this(date)
        {
            task.Time = (int)time.TotalSeconds;
            timeTextBox.Text = $"{(TaskTime)time}";
            timeTextBox.Enabled = false;
        }

        public AddTask(Task task)
        {
            this.task = task;
            InitializeComponent();

            timeTextBox.Text = $"{TaskTime.FromSeconds(task.Time)}";
            taskDescTextBox.Text = task.Description;

            this.Text = "Edit Task";
        }

        private void TimeEntered(object sender, EventArgs e)
        {
            BeginInvoke((MethodInvoker)delegate (){timeTextBox.Select(0, 0);});
        }

        private void TimeValidate(object sender, EventArgs e)
        {
            TimeSpan taskTime;
            if(okBtn.Enabled = TimeSpan.TryParse(timeTextBox.Text, out taskTime))
            {
                task.Time = (int)taskTime.TotalSeconds;
            }
        }

        private void TaskChanged(object sender, EventArgs e)
        {
            task.Description = taskDescTextBox.Text;
        }
    }
}
