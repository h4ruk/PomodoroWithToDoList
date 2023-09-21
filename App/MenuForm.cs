using System;
using System.Drawing;
using System.Windows.Forms;

namespace App
{
    public partial class MenuForm : Form
    {
        private string saveFilePath;
        private TaskCollection tasks;

        public MenuForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            saveFilePath = "unfinishTasks.txt";
            tasks = new TaskCollection();
            tasks.Load(saveFilePath);

            if (tasks.Count <= 0)
            {
                continueBtn.Visible = false;
                newBtn.Location = new Point((Width - newBtn.Width)/2, (Height - newBtn.Height)/2);                
            }            
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            tasks.Clear();
            OpenPomodoro();
        }
        private void continueBtn_Click(object sender, EventArgs e)
        {
            OpenPomodoro();
        } 

        private void OpenPomodoro()
        {
            PomodoroForm pomodoroForm = new PomodoroForm(tasks);
            pomodoroForm.Show();
            pomodoroForm.FormClosed += (obj, args) => {
                tasks.Save(saveFilePath);
                this.Close(); 
            };
            this.Hide();
        }
    }
}
