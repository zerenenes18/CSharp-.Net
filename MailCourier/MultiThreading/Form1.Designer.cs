namespace MultiThreading
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            lbLogs = new ListBox();
            btnListMailTasks = new Button();
            dataGridView1 = new DataGridView();
            taskIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isRunningDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            isStartedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            secondDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nextRunningDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mailTaskBindingSource = new BindingSource(components);
            btnStart = new Button();
            btnStop = new Button();
            btnRun = new Button();
            radioGOOGLE = new RadioButton();
            radioALL = new RadioButton();
            radioSMTP = new RadioButton();
            countofmails = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mailTaskBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countofmails).BeginInit();
            SuspendLayout();
            // 
            // lbLogs
            // 
            lbLogs.BackColor = SystemColors.InactiveCaption;
            lbLogs.Dock = DockStyle.Bottom;
            lbLogs.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbLogs.FormattingEnabled = true;
            lbLogs.ItemHeight = 20;
            lbLogs.Location = new Point(0, 428);
            lbLogs.Name = "lbLogs";
            lbLogs.Size = new Size(1027, 224);
            lbLogs.TabIndex = 0;
            lbLogs.SelectedIndexChanged += lbLogs_SelectedIndexChanged;
            // 
            // btnListMailTasks
            // 
            btnListMailTasks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnListMailTasks.Location = new Point(0, 6);
            btnListMailTasks.Name = "btnListMailTasks";
            btnListMailTasks.Size = new Size(1027, 96);
            btnListMailTasks.TabIndex = 1;
            btnListMailTasks.Text = "List Mail Tasks";
            btnListMailTasks.UseVisualStyleBackColor = true;
            btnListMailTasks.Click += btnListMailTasks_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { taskIdDataGridViewTextBoxColumn, isRunningDataGridViewCheckBoxColumn, isStartedDataGridViewCheckBoxColumn, secondDataGridViewTextBoxColumn, nextRunningDataGridViewTextBoxColumn });
            dataGridView1.DataSource = mailTaskBindingSource;
            dataGridView1.Location = new Point(0, 289);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1027, 144);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // taskIdDataGridViewTextBoxColumn
            // 
            taskIdDataGridViewTextBoxColumn.DataPropertyName = "TaskId";
            taskIdDataGridViewTextBoxColumn.HeaderText = "TaskId";
            taskIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            taskIdDataGridViewTextBoxColumn.Name = "taskIdDataGridViewTextBoxColumn";
            taskIdDataGridViewTextBoxColumn.ReadOnly = true;
            taskIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // isRunningDataGridViewCheckBoxColumn
            // 
            isRunningDataGridViewCheckBoxColumn.DataPropertyName = "IsRunning";
            isRunningDataGridViewCheckBoxColumn.HeaderText = "IsRunning";
            isRunningDataGridViewCheckBoxColumn.MinimumWidth = 6;
            isRunningDataGridViewCheckBoxColumn.Name = "isRunningDataGridViewCheckBoxColumn";
            isRunningDataGridViewCheckBoxColumn.ReadOnly = true;
            isRunningDataGridViewCheckBoxColumn.Width = 125;
            // 
            // isStartedDataGridViewCheckBoxColumn
            // 
            isStartedDataGridViewCheckBoxColumn.DataPropertyName = "IsStarted";
            isStartedDataGridViewCheckBoxColumn.HeaderText = "IsStarted";
            isStartedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            isStartedDataGridViewCheckBoxColumn.Name = "isStartedDataGridViewCheckBoxColumn";
            isStartedDataGridViewCheckBoxColumn.ReadOnly = true;
            isStartedDataGridViewCheckBoxColumn.Width = 125;
            // 
            // secondDataGridViewTextBoxColumn
            // 
            secondDataGridViewTextBoxColumn.DataPropertyName = "Second";
            secondDataGridViewTextBoxColumn.HeaderText = "Second";
            secondDataGridViewTextBoxColumn.MinimumWidth = 6;
            secondDataGridViewTextBoxColumn.Name = "secondDataGridViewTextBoxColumn";
            secondDataGridViewTextBoxColumn.ReadOnly = true;
            secondDataGridViewTextBoxColumn.Width = 125;
            // 
            // nextRunningDataGridViewTextBoxColumn
            // 
            nextRunningDataGridViewTextBoxColumn.DataPropertyName = "NextRunning";
            nextRunningDataGridViewTextBoxColumn.HeaderText = "NextRunning";
            nextRunningDataGridViewTextBoxColumn.MinimumWidth = 6;
            nextRunningDataGridViewTextBoxColumn.Name = "nextRunningDataGridViewTextBoxColumn";
            nextRunningDataGridViewTextBoxColumn.ReadOnly = true;
            nextRunningDataGridViewTextBoxColumn.Width = 125;
            // 
            // mailTaskBindingSource
            // 
            mailTaskBindingSource.AllowNew = false;
            mailTaskBindingSource.DataSource = typeof(MailTask);
            mailTaskBindingSource.CurrentChanged += mailTaskBindingSource_CurrentChanged_1;
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnStart.BackColor = SystemColors.GradientActiveCaption;
            btnStart.Enabled = false;
            btnStart.Location = new Point(0, 225);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(153, 58);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnStop.BackColor = SystemColors.WindowFrame;
            btnStop.Enabled = false;
            btnStop.Location = new Point(159, 225);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(158, 58);
            btnStop.TabIndex = 4;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // btnRun
            // 
            btnRun.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRun.Enabled = false;
            btnRun.Location = new Point(792, 199);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(223, 84);
            btnRun.TabIndex = 5;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += button3_Click;
            // 
            // radioGOOGLE
            // 
            radioGOOGLE.AutoSize = true;
            radioGOOGLE.Location = new Point(398, 227);
            radioGOOGLE.Name = "radioGOOGLE";
            radioGOOGLE.Size = new Size(87, 24);
            radioGOOGLE.TabIndex = 6;
            radioGOOGLE.TabStop = true;
            radioGOOGLE.Text = "GOOGLE";
            radioGOOGLE.UseVisualStyleBackColor = true;
            // 
            // radioALL
            // 
            radioALL.AutoSize = true;
            radioALL.Checked = true;
            radioALL.Location = new Point(398, 257);
            radioALL.Name = "radioALL";
            radioALL.Size = new Size(54, 24);
            radioALL.TabIndex = 7;
            radioALL.TabStop = true;
            radioALL.Text = "ALL";
            radioALL.UseVisualStyleBackColor = true;
            radioALL.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioSMTP
            // 
            radioSMTP.AutoSize = true;
            radioSMTP.Location = new Point(398, 199);
            radioSMTP.Name = "radioSMTP";
            radioSMTP.Size = new Size(67, 24);
            radioSMTP.TabIndex = 8;
            radioSMTP.TabStop = true;
            radioSMTP.Text = "SMTP";
            radioSMTP.UseVisualStyleBackColor = true;
            // 
            // countofmails
            // 
            countofmails.Location = new Point(541, 229);
            countofmails.Name = "countofmails";
            countofmails.Size = new Size(150, 27);
            countofmails.TabIndex = 9;
            countofmails.ValueChanged += countofmails_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1027, 652);
            Controls.Add(countofmails);
            Controls.Add(radioSMTP);
            Controls.Add(radioALL);
            Controls.Add(radioGOOGLE);
            Controls.Add(btnRun);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(dataGridView1);
            Controls.Add(btnListMailTasks);
            Controls.Add(lbLogs);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mailTaskBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)countofmails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox lbLogs;
        private Button btnListMailTasks;
        private DataGridView dataGridView1;
        private BindingSource mailTaskBindingSource;
        private DataGridViewTextBoxColumn taskIdDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isRunningDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isStartedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn secondDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nextRunningDataGridViewTextBoxColumn;
        private Button btnStart;
        private Button btnStop;
        private Button btnRun;
        private RadioButton radioGOOGLE;
        private RadioButton radioALL;
        private RadioButton radioSMTP;
        private NumericUpDown countofmails;
    }
}