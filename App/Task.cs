namespace App
{
    public class Task
    {
        private bool isComplete;
        public bool IsComplete { get => isComplete; set => isComplete = value; }

        private bool isWorkOn;
        public bool IsWorkOn { get => isWorkOn; set => isWorkOn = value; }

        private string content;
        public string Content { get => content; set => content = value;}        

        public Task()
        {
            content = "Task?";
            isComplete = false;
            isWorkOn = false;            
        }

        public Task(string content) : this()
        {
            this.content = content;
        }
    }
}
