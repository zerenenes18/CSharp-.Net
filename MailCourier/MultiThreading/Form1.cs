using MultiThreading.Models;
using System.Diagnostics.Eventing.Reader;

namespace MultiThreading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LogManager.Default.OnLogAdded += (s, e) =>
            {
                AddLog(e);

            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void AddLog(string LogMessage)
        {

            if (lbLogs.InvokeRequired)
            {
                lbLogs.Invoke(new Action(() => AddLog(LogMessage)));
                return;
            }

            LogMessage = $"[{DateTime.Now:dd.MM.yyyy HH:mm:ss:fff} - {LogMessage}]";

            lbLogs.Items.Add(LogMessage);
            lbLogs.SelectedIndex = lbLogs.Items.Count - 1;
        }

        private void btnListMailTasks_Click(object sender, EventArgs e)
        {
            var smtpMailTask = new MailTask(MailProviderType.Smtp)
            {
                Second = 30
            };
            var googleMailTask = new MailTask(MailProviderType.Google)
            {

                Second = 30
            };

            mailTaskBindingSource.Clear();
            mailTaskBindingSource.Add(smtpMailTask);
            mailTaskBindingSource.Add(googleMailTask);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }


        private void mailTaskBindingSource_CurrentChanged_1(object sender, EventArgs e)
        {
            var mailTask = mailTaskBindingSource.Current as MailTask;
            if (mailTask == null) return;

            //btnStart.Enabled = !mailTask.IsStarted;
            //btnStop.Enabled = mailTask.IsRunning;
            //btnRun.Enabled = mailTask.IsStarted && !mailTask.IsRunning;

            btnStart.Enabled = true;
            btnStop.Enabled = true;
            btnRun.Enabled = true;


        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var mailTask = mailTaskBindingSource.Current as MailTask;

            var number = (int)countofmails.Value;

            await mailTask.Run(number);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var mailTask = mailTaskBindingSource.Current as MailTask;

            mailTask.Start();

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            var mailTask = mailTaskBindingSource.Current as MailTask;

            mailTask.Stop();
        }

        private void lbLogs_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mailTask = mailTaskBindingSource.Current as MailTask;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void countofmails_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}