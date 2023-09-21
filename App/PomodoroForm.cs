using System;
using ExtendControl;
using System.Drawing;
using System.Windows.Forms;

namespace App
{
    public partial class PomodoroForm : Form
    {
        private Pomodoro pomodoro;
        private TaskCollection tasks;
        private TasksForm tasksForm;
        private TimeOptionForm timeForm;

        public PomodoroForm(TaskCollection tasks)
        {
            InitializeComponent();
            Init(tasks);
        }

        private void Init(TaskCollection tasks)
        {
            pomodoro = new Pomodoro();
            pomodoro.Begin += OnPomodoroBegin;
            pomodoro.Count += OnPomodoroCount;
            pomodoro.Finish += OnPomodoroDone;

            this.tasks = tasks;
            tasks.CurrentTaskChanged += (obj, arg) => {
                UpdateTaskLabel();
            };
            
            tasksForm = new TasksForm(tasks);
            tasksForm.VisibleChanged += (obj, arg) => {
                if (!tasksForm.Visible) this.Show();
                else this.Hide();
            };
            tasksForm.FormClosed += (a, b) =>
            {
                this.Close();
            };
        }

        private void Pomodoro_Load(object sender, EventArgs e)
        {
            BackColor = ExtendColor.Green;
            settings.BackColor = BackColor;
            
            timeLabel.Text = pomodoro.Time();
            UpdateTaskLabel();
            taskLabel.ForeColor = timeLabel.ForeColor = ExtendColor.Black;
            taskLabel.BackColor = timeLabel.BackColor = ExtendColor.Green;

            taskBtn.ForeColor = ExtendColor.Black;
            taskBtn.BackColor = ExtendColor.White;

            startBtn.ForeColor = ExtendColor.White;
            startBtn.BackColor = ExtendColor.BlueBerry;
            startBtn.FlatStyle = FlatStyle.Flat;
            startBtn.FlatAppearance.BorderSize = 0;
            startBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void startBtn_Click(object sender, EventArgs e) => pomodoro.Start();                    
        private void OnPomodoroBegin(object obj, EventArgs args)
        {
            startBtn.Visible = false;
            UpdateTaskLabel();
            taskLabel.ForeColor = timeLabel.ForeColor = ExtendColor.White;
            BackColor = taskLabel.BackColor = timeLabel.BackColor = pomodoro.IsWorkState ? ExtendColor.Pink : ExtendColor.Blue;
            settings.BackColor = BackColor;
        }
        private void OnPomodoroCount(object obj, EventArgs args)
        {
            timeLabel.Text = pomodoro.Time();
        }    
        private void OnPomodoroDone(object sender, EventArgs e)
        {
            startBtn.Visible = true;            
            UpdateTaskLabel();
            timeLabel.Text = pomodoro.Time();
            taskLabel.ForeColor = timeLabel.ForeColor = ExtendColor.Black;
            BackColor = taskLabel.BackColor = timeLabel.BackColor = ExtendColor.Green;
            settings.BackColor = BackColor;
        }

        private void taskBtn_Click(object sender, EventArgs e)
        {            
            tasksForm.Show();                   
        }

        private void UpdateTaskLabel()
        {
            string content = "";
            if (pomodoro.IsWorkState)
            {
                if (tasks.CurrentTask().Content.Length > 0)
                    content = tasks.CurrentTask().Content;
                else
                    content = "Task?";
            }
            else content = "Break Timer!";
            taskLabel.Text = content;
        }

        private void settings_Click(object sender, EventArgs e)
        {
            timeForm = new TimeOptionForm();
            timeForm.PomodoroSetting += (work, rest) =>
            {
                pomodoro.Reset(work, rest);
            };
            timeForm.ShowDialog();
        }
    }
}
