namespace WhaleTrack
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonManager = new Krypton.Toolkit.KryptonManager(this.components);
            this.appRibbon = new Krypton.Ribbon.KryptonRibbon();
            this.buttonSpecAppMenu1 = new Krypton.Ribbon.ButtonSpecAppMenu();
            this.mainTab = new Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup1 = new Krypton.Ribbon.KryptonRibbonGroup();
            this.tasksRibbonGroup1 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.addTaskBtn = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.editTaskBtn = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.deleteTaskBtn = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.toolsGroup = new Krypton.Ribbon.KryptonRibbonGroup();
            this.toolsRibbonGroup1 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.stopwatchBtn = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupButton1 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.taskDataSet = new System.Data.DataSet();
            this.dataTable = new System.Data.DataTable();
            this.idColumn = new System.Data.DataColumn();
            this.typeColumn = new System.Data.DataColumn();
            this.dateColumn = new System.Data.DataColumn();
            this.taskColumn = new System.Data.DataColumn();
            this.timeColumn = new System.Data.DataColumn();
            this.kryptonDataGridViewTextBoxColumn1 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.kryptonDataGridViewTextBoxColumn2 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.kryptonSplitContainer1 = new Krypton.Toolkit.KryptonSplitContainer();
            this.taskCalendar = new Krypton.Toolkit.KryptonMonthCalendar();
            this.taskHeaderGroup = new Krypton.Toolkit.KryptonHeaderGroup();
            this.taskDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonDataGridViewTextBoxColumn3 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.kryptonDataGridViewTextBoxColumn4 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.appRibbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.Panel2.SuspendLayout();
            this.kryptonSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskHeaderGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskHeaderGroup.Panel)).BeginInit();
            this.taskHeaderGroup.Panel.SuspendLayout();
            this.taskHeaderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonManager
            // 
            this.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2010Black;
            // 
            // appRibbon
            // 
            this.appRibbon.AllowMinimizedChange = false;
            this.appRibbon.InDesignHelperMode = false;
            this.appRibbon.Name = "appRibbon";
            this.appRibbon.QATLocation = Krypton.Ribbon.QATLocation.Hidden;
            this.appRibbon.QATUserChange = false;
            this.appRibbon.RibbonFileAppButton.AppButtonSpecs.Add(this.buttonSpecAppMenu1);
            this.appRibbon.RibbonFileAppButton.FormCloseBoxVisible = true;
            this.appRibbon.RibbonTabs.AddRange(new Krypton.Ribbon.KryptonRibbonTab[] {
            this.mainTab});
            this.appRibbon.SelectedTab = this.mainTab;
            this.appRibbon.ShowMinimizeButton = false;
            this.appRibbon.Size = new System.Drawing.Size(784, 115);
            this.appRibbon.StateCommon.RibbonAppButton.BackColor1 = System.Drawing.Color.White;
            this.appRibbon.StateCommon.RibbonAppButton.BackColor2 = System.Drawing.Color.Empty;
            this.appRibbon.StateCommon.RibbonAppButton.BackColor3 = System.Drawing.Color.Empty;
            this.appRibbon.StateCommon.RibbonAppButton.BackColor4 = System.Drawing.Color.Empty;
            this.appRibbon.StateCommon.RibbonAppButton.BackColor5 = System.Drawing.Color.Empty;
            this.appRibbon.StateCommon.RibbonFileAppTab.RibbonFileAppTabBottomColor = System.Drawing.Color.MidnightBlue;
            this.appRibbon.StateCommon.RibbonFileAppTab.RibbonFileAppTabTopColor = System.Drawing.Color.RoyalBlue;
            this.appRibbon.TabIndex = 1;
            // 
            // buttonSpecAppMenu1
            // 
            this.buttonSpecAppMenu1.ColorMap = System.Drawing.Color.Green;
            this.buttonSpecAppMenu1.UniqueName = "57f9a242f4124d7cbba38c2b8c9c9372";
            // 
            // mainTab
            // 
            this.mainTab.Groups.AddRange(new Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup1,
            this.toolsGroup});
            this.mainTab.Text = "Main";
            // 
            // kryptonRibbonGroup1
            // 
            this.kryptonRibbonGroup1.DialogBoxLauncher = false;
            this.kryptonRibbonGroup1.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.tasksRibbonGroup1});
            this.kryptonRibbonGroup1.KeyTipGroup = "T";
            this.kryptonRibbonGroup1.TextLine1 = "Tasks";
            // 
            // tasksRibbonGroup1
            // 
            this.tasksRibbonGroup1.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.addTaskBtn,
            this.editTaskBtn,
            this.deleteTaskBtn});
            // 
            // addTaskBtn
            // 
            this.addTaskBtn.TextLine1 = "Add";
            this.addTaskBtn.TextLine2 = "Task";
            this.addTaskBtn.Click += new System.EventHandler(this.addTaskBtn_Click);
            // 
            // editTaskBtn
            // 
            this.editTaskBtn.TextLine1 = "Edit";
            this.editTaskBtn.TextLine2 = "Task";
            this.editTaskBtn.Click += new System.EventHandler(this.editTaskBtn_Click);
            // 
            // deleteTaskBtn
            // 
            this.deleteTaskBtn.TextLine1 = "Delete";
            this.deleteTaskBtn.TextLine2 = "Task";
            this.deleteTaskBtn.Click += new System.EventHandler(this.deleteTaskBtn_Click);
            // 
            // toolsGroup
            // 
            this.toolsGroup.DialogBoxLauncher = false;
            this.toolsGroup.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.toolsRibbonGroup1});
            this.toolsGroup.KeyTipGroup = "O";
            this.toolsGroup.TextLine1 = "Tools";
            // 
            // toolsRibbonGroup1
            // 
            this.toolsRibbonGroup1.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.stopwatchBtn,
            this.kryptonRibbonGroupButton1});
            // 
            // stopwatchBtn
            // 
            this.stopwatchBtn.ButtonType = Krypton.Ribbon.GroupButtonType.Check;
            this.stopwatchBtn.KeyTip = "S";
            this.stopwatchBtn.TextLine1 = "Stop";
            this.stopwatchBtn.TextLine2 = "Watch";
            this.stopwatchBtn.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(this.stopwatchBtn_PropertyChanged);
            // 
            // kryptonRibbonGroupButton1
            // 
            this.kryptonRibbonGroupButton1.Click += new System.EventHandler(this.kryptonRibbonGroupButton1_Click);
            // 
            // taskDataSet
            // 
            this.taskDataSet.DataSetName = "Task Data Set";
            this.taskDataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable});
            // 
            // dataTable
            // 
            this.dataTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.idColumn,
            this.typeColumn,
            this.dateColumn,
            this.taskColumn,
            this.timeColumn});
            this.dataTable.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "ID"}, true)});
            this.dataTable.PrimaryKey = new System.Data.DataColumn[] {
        this.idColumn};
            this.dataTable.TableName = "Task Table";
            // 
            // idColumn
            // 
            this.idColumn.AllowDBNull = false;
            this.idColumn.AutoIncrement = true;
            this.idColumn.ColumnName = "ID";
            this.idColumn.DataType = typeof(int);
            // 
            // typeColumn
            // 
            this.typeColumn.AllowDBNull = false;
            this.typeColumn.ColumnName = "Type";
            this.typeColumn.DataType = typeof(WhaleTrack.TaskType);
            // 
            // dateColumn
            // 
            this.dateColumn.AllowDBNull = false;
            this.dateColumn.ColumnName = "Date";
            this.dateColumn.DataType = typeof(System.DateTime);
            this.dateColumn.DateTimeMode = System.Data.DataSetDateTime.Local;
            // 
            // taskColumn
            // 
            this.taskColumn.AllowDBNull = false;
            this.taskColumn.ColumnName = "Task";
            // 
            // timeColumn
            // 
            this.timeColumn.AllowDBNull = false;
            this.timeColumn.ColumnName = "Time";
            this.timeColumn.DataType = typeof(System.TimeSpan);
            // 
            // kryptonDataGridViewTextBoxColumn1
            // 
            this.kryptonDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kryptonDataGridViewTextBoxColumn1.DataPropertyName = "Task";
            this.kryptonDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.kryptonDataGridViewTextBoxColumn1.HeaderText = "Task";
            this.kryptonDataGridViewTextBoxColumn1.Name = "kryptonDataGridViewTextBoxColumn1";
            this.kryptonDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.kryptonDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.kryptonDataGridViewTextBoxColumn1.Width = 440;
            // 
            // kryptonDataGridViewTextBoxColumn2
            // 
            this.kryptonDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kryptonDataGridViewTextBoxColumn2.DataPropertyName = "Time";
            this.kryptonDataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.kryptonDataGridViewTextBoxColumn2.HeaderText = "Time";
            this.kryptonDataGridViewTextBoxColumn2.MinimumWidth = 100;
            this.kryptonDataGridViewTextBoxColumn2.Name = "kryptonDataGridViewTextBoxColumn2";
            this.kryptonDataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.kryptonDataGridViewTextBoxColumn2.Width = 100;
            // 
            // kryptonSplitContainer1
            // 
            this.kryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.kryptonSplitContainer1.IsSplitterFixed = true;
            this.kryptonSplitContainer1.Location = new System.Drawing.Point(0, 115);
            this.kryptonSplitContainer1.Name = "kryptonSplitContainer1";
            // 
            // kryptonSplitContainer1.Panel1
            // 
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.taskCalendar);
            this.kryptonSplitContainer1.Panel1MinSize = 236;
            // 
            // kryptonSplitContainer1.Panel2
            // 
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.taskHeaderGroup);
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(784, 344);
            this.kryptonSplitContainer1.SplitterDistance = 236;
            this.kryptonSplitContainer1.TabIndex = 2;
            // 
            // taskCalendar
            // 
            this.taskCalendar.BoldedDates = new System.DateTime[] {
        new System.DateTime(2024, 10, 22, 0, 0, 0, 0),
        new System.DateTime(2024, 10, 15, 0, 0, 0, 0),
        new System.DateTime(2024, 10, 21, 0, 0, 0, 0),
        new System.DateTime(2024, 10, 14, 0, 0, 0, 0)};
            this.taskCalendar.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.taskCalendar.Location = new System.Drawing.Point(3, 3);
            this.taskCalendar.MaxSelectionCount = 1;
            this.taskCalendar.Name = "taskCalendar";
            this.taskCalendar.OverrideBolded.Day.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.taskCalendar.OverrideBolded.Day.Back.Color2 = System.Drawing.Color.DarkBlue;
            this.taskCalendar.OverrideBolded.Day.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.taskCalendar.OverrideBolded.Day.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.taskCalendar.OverrideBolded.Day.Back.Draw = Krypton.Toolkit.InheritBool.True;
            this.taskCalendar.OverrideBolded.Day.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.taskCalendar.OverrideBolded.Day.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.taskCalendar.OverrideFocus.Day.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.taskCalendar.OverrideFocus.Day.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            this.taskCalendar.OverrideFocus.Day.Border.Width = 2;
            this.taskCalendar.OverrideFocus.Day.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.taskCalendar.OverrideToday.Day.Border.Color1 = System.Drawing.Color.Red;
            this.taskCalendar.OverrideToday.Day.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.taskCalendar.OverrideToday.Day.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            this.taskCalendar.SelectionEnd = new System.DateTime(2024, 10, 23, 0, 0, 0, 0);
            this.taskCalendar.SelectionStart = new System.DateTime(2024, 10, 23, 0, 0, 0, 0);
            this.taskCalendar.Size = new System.Drawing.Size(230, 338);
            this.taskCalendar.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.taskCalendar.StateCommon.Day.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.taskCalendar.StateCommon.Day.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            this.taskCalendar.StateCommon.DayOfWeek.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.taskCalendar.StateCommon.DayOfWeek.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            this.taskCalendar.StateCommon.Header.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.taskCalendar.TabIndex = 0;
            this.taskCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.SelectedDateChanged);
            // 
            // taskHeaderGroup
            // 
            this.taskHeaderGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskHeaderGroup.Location = new System.Drawing.Point(0, 0);
            this.taskHeaderGroup.Name = "taskHeaderGroup";
            // 
            // taskHeaderGroup.Panel
            // 
            this.taskHeaderGroup.Panel.Controls.Add(this.taskDataGridView);
            this.taskHeaderGroup.Size = new System.Drawing.Size(543, 344);
            this.taskHeaderGroup.StateCommon.HeaderPrimary.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.taskHeaderGroup.StateCommon.HeaderSecondary.Content.LongText.Color1 = System.Drawing.Color.DarkBlue;
            this.taskHeaderGroup.StateCommon.HeaderSecondary.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskHeaderGroup.TabIndex = 2;
            this.taskHeaderGroup.ValuesPrimary.Heading = "<date goes here>";
            this.taskHeaderGroup.ValuesSecondary.Description = "Total: 00:00:00";
            this.taskHeaderGroup.ValuesSecondary.Heading = "Daily: 00:00:00";
            // 
            // taskDataGridView
            // 
            this.taskDataGridView.AllowUserToAddRows = false;
            this.taskDataGridView.AllowUserToDeleteRows = false;
            this.taskDataGridView.AllowUserToResizeColumns = false;
            this.taskDataGridView.AllowUserToResizeRows = false;
            this.taskDataGridView.AutoGenerateColumns = false;
            this.taskDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.taskDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kryptonDataGridViewTextBoxColumn3,
            this.kryptonDataGridViewTextBoxColumn4});
            this.taskDataGridView.DataMember = "Task Table";
            this.taskDataGridView.DataSource = this.taskDataSet;
            this.taskDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskDataGridView.HideOuterBorders = true;
            this.taskDataGridView.Location = new System.Drawing.Point(0, 0);
            this.taskDataGridView.MultiSelect = false;
            this.taskDataGridView.Name = "taskDataGridView";
            this.taskDataGridView.ReadOnly = true;
            this.taskDataGridView.RowHeadersVisible = false;
            this.taskDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.taskDataGridView.RowTemplate.ReadOnly = true;
            this.taskDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.taskDataGridView.Size = new System.Drawing.Size(541, 291);
            this.taskDataGridView.TabIndex = 1;
            // 
            // kryptonDataGridViewTextBoxColumn3
            // 
            this.kryptonDataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kryptonDataGridViewTextBoxColumn3.DataPropertyName = "Task";
            this.kryptonDataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle3;
            this.kryptonDataGridViewTextBoxColumn3.HeaderText = "Task";
            this.kryptonDataGridViewTextBoxColumn3.Name = "kryptonDataGridViewTextBoxColumn3";
            this.kryptonDataGridViewTextBoxColumn3.ReadOnly = true;
            this.kryptonDataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.kryptonDataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.kryptonDataGridViewTextBoxColumn3.Width = 440;
            // 
            // kryptonDataGridViewTextBoxColumn4
            // 
            this.kryptonDataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kryptonDataGridViewTextBoxColumn4.DataPropertyName = "Time";
            dataGridViewCellStyle4.Format = "hh\\:mm\\:ss";
            dataGridViewCellStyle4.NullValue = null;
            this.kryptonDataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle4;
            this.kryptonDataGridViewTextBoxColumn4.HeaderText = "Time";
            this.kryptonDataGridViewTextBoxColumn4.MinimumWidth = 100;
            this.kryptonDataGridViewTextBoxColumn4.Name = "kryptonDataGridViewTextBoxColumn4";
            this.kryptonDataGridViewTextBoxColumn4.ReadOnly = true;
            this.kryptonDataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.kryptonDataGridViewTextBoxColumn4.Width = 100;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 459);
            this.Controls.Add(this.kryptonSplitContainer1);
            this.Controls.Add(this.appRibbon);
            this.CustomCaptionArea = new System.Drawing.Rectangle(115, 0, 669, 26);
            this.FormTitleAlign = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.MinimumSize = new System.Drawing.Size(650, 498);
            this.Name = "MainForm";
            this.Text = "WhaleTrack";
            ((System.ComponentModel.ISupportInitialize)(this.appRibbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taskHeaderGroup.Panel)).EndInit();
            this.taskHeaderGroup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taskHeaderGroup)).EndInit();
            this.taskHeaderGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taskDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonManager kryptonManager;
        private Krypton.Ribbon.KryptonRibbon appRibbon;
        private Krypton.Ribbon.KryptonRibbonTab mainTab;
        private Krypton.Ribbon.KryptonRibbonGroupTriple toolsRibbonGroup1;
        private Krypton.Ribbon.KryptonRibbonGroupButton stopwatchBtn;
        private Krypton.Ribbon.KryptonRibbonGroup toolsGroup;
        private System.Data.DataSet taskDataSet;
        private System.Data.DataTable dataTable;
        private System.Data.DataColumn taskColumn;
        private System.Data.DataColumn timeColumn;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn1;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn2;
        private Krypton.Ribbon.KryptonRibbonGroupTriple tasksRibbonGroup1;
        private Krypton.Ribbon.KryptonRibbonGroupButton addTaskBtn;
        private Krypton.Ribbon.KryptonRibbonGroupButton editTaskBtn;
        private Krypton.Ribbon.KryptonRibbonGroupButton deleteTaskBtn;
        private Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup1;
        private System.Data.DataColumn idColumn;
        private System.Data.DataColumn dateColumn;
        private Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private Krypton.Toolkit.KryptonMonthCalendar taskCalendar;
        private Krypton.Toolkit.KryptonHeaderGroup taskHeaderGroup;
        private Krypton.Toolkit.KryptonDataGridView taskDataGridView;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn3;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn4;
        private Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton1;
        private System.Data.DataColumn typeColumn;
        private Krypton.Ribbon.ButtonSpecAppMenu buttonSpecAppMenu1;
    }
}
