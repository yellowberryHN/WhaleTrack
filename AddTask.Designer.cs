namespace WhaleTrack
{
    partial class AddTask
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
            this.cancelBtn = new Krypton.Toolkit.KryptonButton();
            this.okBtn = new Krypton.Toolkit.KryptonButton();
            this.btnPanel = new Krypton.Toolkit.KryptonPanel();
            this.kryptonBorderEdge = new Krypton.Toolkit.KryptonBorderEdge();
            this.dialogPanel = new Krypton.Toolkit.KryptonPanel();
            this.kryptonGroupBox2 = new Krypton.Toolkit.KryptonGroupBox();
            this.timeTextBox = new Krypton.Toolkit.KryptonMaskedTextBox();
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.taskDescTextBox = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnPanel)).BeginInit();
            this.btnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dialogPanel)).BeginInit();
            this.dialogPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(182, 9);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(90, 25);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Values.Text = "Cance&l";
            // 
            // okBtn
            // 
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.Enabled = false;
            this.okBtn.Location = new System.Drawing.Point(86, 9);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(90, 25);
            this.okBtn.TabIndex = 0;
            this.okBtn.Values.Text = "O&K";
            // 
            // btnPanel
            // 
            this.btnPanel.Controls.Add(this.kryptonBorderEdge);
            this.btnPanel.Controls.Add(this.okBtn);
            this.btnPanel.Controls.Add(this.cancelBtn);
            this.btnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPanel.Location = new System.Drawing.Point(0, 216);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate;
            this.btnPanel.Size = new System.Drawing.Size(284, 44);
            this.btnPanel.TabIndex = 2;
            // 
            // kryptonBorderEdge
            // 
            this.kryptonBorderEdge.Location = new System.Drawing.Point(0, 0);
            this.kryptonBorderEdge.Name = "kryptonBorderEdge";
            this.kryptonBorderEdge.Size = new System.Drawing.Size(284, 1);
            this.kryptonBorderEdge.Text = "kryptonBorderEdge";
            // 
            // dialogPanel
            // 
            this.dialogPanel.Controls.Add(this.kryptonGroupBox2);
            this.dialogPanel.Controls.Add(this.kryptonGroupBox1);
            this.dialogPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dialogPanel.Location = new System.Drawing.Point(0, 0);
            this.dialogPanel.Name = "dialogPanel";
            this.dialogPanel.Size = new System.Drawing.Size(284, 216);
            this.dialogPanel.TabIndex = 4;
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Location = new System.Drawing.Point(12, 154);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.timeTextBox);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(260, 53);
            this.kryptonGroupBox2.TabIndex = 2;
            this.kryptonGroupBox2.Values.Heading = "Time Taken";
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(3, 3);
            this.timeTextBox.Mask = "00:00:00";
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(250, 23);
            this.timeTextBox.TabIndex = 0;
            this.timeTextBox.Text = "  :  :";
            this.timeTextBox.TextChanged += new System.EventHandler(this.TimeValidate);
            this.timeTextBox.Enter += new System.EventHandler(this.TimeEntered);
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(12, 3);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.taskDescTextBox);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(260, 145);
            this.kryptonGroupBox1.TabIndex = 1;
            this.kryptonGroupBox1.Values.Heading = "Task Description";
            // 
            // taskDescTextBox
            // 
            this.taskDescTextBox.Location = new System.Drawing.Point(3, 3);
            this.taskDescTextBox.Multiline = true;
            this.taskDescTextBox.Name = "taskDescTextBox";
            this.taskDescTextBox.Size = new System.Drawing.Size(250, 115);
            this.taskDescTextBox.TabIndex = 0;
            this.taskDescTextBox.TextChanged += new System.EventHandler(this.TaskChanged);
            // 
            // AddTask
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(284, 260);
            this.Controls.Add(this.dialogPanel);
            this.Controls.Add(this.btnPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Task";
            ((System.ComponentModel.ISupportInitialize)(this.btnPanel)).EndInit();
            this.btnPanel.ResumeLayout(false);
            this.btnPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dialogPanel)).EndInit();
            this.dialogPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonButton cancelBtn;
        private Krypton.Toolkit.KryptonButton okBtn;
        private Krypton.Toolkit.KryptonPanel btnPanel;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge;
        private Krypton.Toolkit.KryptonPanel dialogPanel;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonTextBox taskDescTextBox;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private Krypton.Toolkit.KryptonMaskedTextBox timeTextBox;
    }
}