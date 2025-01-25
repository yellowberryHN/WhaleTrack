namespace WhaleTrack
{
    partial class StopwatchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.stopwatchLabel = new Krypton.Toolkit.KryptonLabel();
            this.kryptonSplitContainer1 = new Krypton.Toolkit.KryptonSplitContainer();
            this.dateLabel = new Krypton.Toolkit.KryptonLabel();
            this.pauseBtn = new Krypton.Toolkit.KryptonCheckButton();
            this.startBtn = new Krypton.Toolkit.KryptonCheckButton();
            this.finishTaskBtn = new Krypton.Toolkit.KryptonButton();
            this.startPauseCheckSet = new Krypton.Toolkit.KryptonCheckSet(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.Panel2.SuspendLayout();
            this.kryptonSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startPauseCheckSet)).BeginInit();
            this.SuspendLayout();
            // 
            // stopwatchLabel
            // 
            this.stopwatchLabel.AutoSize = false;
            this.stopwatchLabel.Location = new System.Drawing.Point(12, 12);
            this.stopwatchLabel.Name = "stopwatchLabel";
            this.stopwatchLabel.Size = new System.Drawing.Size(292, 76);
            this.stopwatchLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopwatchLabel.StateCommon.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.stopwatchLabel.TabIndex = 0;
            this.stopwatchLabel.Values.Text = "00:00:00";
            // 
            // kryptonSplitContainer1
            // 
            this.kryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer1.IsSplitterFixed = true;
            this.kryptonSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.kryptonSplitContainer1.Name = "kryptonSplitContainer1";
            this.kryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // kryptonSplitContainer1.Panel1
            // 
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.dateLabel);
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.stopwatchLabel);
            // 
            // kryptonSplitContainer1.Panel2
            // 
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.pauseBtn);
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.startBtn);
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.finishTaskBtn);
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(316, 186);
            this.kryptonSplitContainer1.SplitterDistance = 126;
            this.kryptonSplitContainer1.TabIndex = 1;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = false;
            this.dateLabel.Location = new System.Drawing.Point(12, 93);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(292, 30);
            this.dateLabel.StateCommon.ShortText.Color1 = System.Drawing.SystemColors.ControlDark;
            this.dateLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dateLabel.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Values.Text = "<long date goes here>";
            // 
            // pauseBtn
            // 
            this.pauseBtn.Enabled = false;
            this.pauseBtn.Location = new System.Drawing.Point(61, 12);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(50, 40);
            this.pauseBtn.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.pauseBtn.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.pauseBtn.TabIndex = 5;
            this.pauseBtn.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.pauseBtn.Values.Text = "Pause";
            this.pauseBtn.Click += new System.EventHandler(this.kryptonCheckButton2_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(12, 12);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(50, 40);
            this.startBtn.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.startBtn.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.startBtn.TabIndex = 4;
            this.startBtn.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.startBtn.Values.Text = "Start";
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // finishTaskBtn
            // 
            this.finishTaskBtn.Location = new System.Drawing.Point(204, 12);
            this.finishTaskBtn.Name = "finishTaskBtn";
            this.finishTaskBtn.Size = new System.Drawing.Size(100, 40);
            this.finishTaskBtn.TabIndex = 3;
            this.finishTaskBtn.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.finishTaskBtn.Values.Text = "Finish Task";
            this.finishTaskBtn.Click += new System.EventHandler(this.finishTaskBtn_Click);
            // 
            // startPauseCheckSet
            // 
            this.startPauseCheckSet.CheckButtons.Add(this.startBtn);
            this.startPauseCheckSet.CheckButtons.Add(this.pauseBtn);
            // 
            // StopwatchForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(316, 186);
            this.CloseBox = false;
            this.ControlBox = false;
            this.Controls.Add(this.kryptonSplitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.FormTitleAlign = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StopwatchForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "WhaleTrack Stopwatch";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.startPauseCheckSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonLabel stopwatchLabel;
        private Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private Krypton.Toolkit.KryptonButton finishTaskBtn;
        private Krypton.Toolkit.KryptonCheckSet startPauseCheckSet;
        private Krypton.Toolkit.KryptonCheckButton pauseBtn;
        private Krypton.Toolkit.KryptonCheckButton startBtn;
        private Krypton.Toolkit.KryptonLabel dateLabel;
    }
}