using ExtendControl;
using System.Windows.Forms;
using System.Collections.Generic;

namespace App
{
    public partial class TasksForm : Form
    {        
        private TaskCollection tasks;
        private List<TaskControl> controls;

        public TasksForm(TaskCollection tasks)
        {
            InitializeComponent();
            Init(tasks);
        }

        private void Init(TaskCollection tasks)
        {
            BackColor = ExtendColor.Gray;
            panel.BackColor = ExtendColor.Gray;

            this.controls = new List<TaskControl>();
            this.tasks = tasks;
            for (int i = 0; i < tasks.Count + 1; i++)
            {
                TaskControl control = new TaskControl();
                control.Index = i;
                if (i < tasks.Count)
                {
                    control.Text = tasks[i].Content;
                    control.Clicked += Control_Clicked;
                    control.DoubleClicked += Control_DoubleClicked;
                }
                else
                { 
                    control.Text = "...";
                    control.Clicked += Add;                
                }
                controls.Add(control);
                panel.Controls.Add(control);
            }
        }
        private void Add(int index)
        {
            TaskAddForm add = new TaskAddForm();
            add.TaskAdd += (content, complete) =>
            {                
                //add into tasks
                tasks.Add(new Task(content));

                //remove control                
                controls.RemoveAt(index);
                panel.Controls.RemoveAt(index);

                //add control into controls
                TaskControl control = new TaskControl();
                control.Index = index;
                control.Text = content;
                control.Clicked += Control_Clicked;
                control.DoubleClicked += Control_DoubleClicked;
                controls.Add(control);
                panel.Controls.Add(control);
                
                control = new TaskControl();
                control.Index = index + 1;
                control.Text = "...";
                control.Clicked += Add;                
                controls.Add(control);
                panel.Controls.Add(control);
            };
            add.ShowDialog();
        }

        private void Control_DoubleClicked(int index)
        {
            TaskOptionForm option = new TaskOptionForm(tasks[index].Content);
            option.OptionChange += (content, complete) => {
                if (complete)
                {
                    tasks.Complete(index);
                    controls.RemoveAt(index);
                    panel.Controls.RemoveAt(index);

                    for (int i = index; i < controls.Count; i++)
                        controls[i].Index -= 1;
                }
                else
                {
                    tasks.Change(index, content);
                    controls[index].Text = content;                    
                }
                panel.Invalidate();
            };
            option.ShowDialog();
        }

        private void Control_Clicked(int index)
        {
            tasks.WorkOn(index);

            for (int i = 0; i < controls.Count; i++)
            {
                if (i == index)
                {
                    controls[i].TextColor = ExtendColor.White;
                    controls[i].BrushColor = ExtendColor.Pink;                    
                }
                else
                {
                    controls[i].TextColor = ExtendColor.Black;
                    controls[i].BrushColor = ExtendColor.White;
                }
                controls[i].Invalidate();
            }
        }

        private void timeBtn_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }
    }
}
