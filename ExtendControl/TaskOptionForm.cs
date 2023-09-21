using System.Windows.Forms;

namespace ExtendControl
{
    public delegate void OptionHandler(string content, bool complete);

    public partial class TaskOptionForm : Form
    {
        private string oldContent;
        public event OptionHandler OptionChange;

        public TaskOptionForm(string content)
        {
            InitializeComponent();
            Init(content);
        }

        private void Init(string content)
        {         
            oldContent = content;
            contentTb.Text = content;            
            BackColor = ExtendColor.White;            
        }

        private void changeBtn_Click(object sender, System.EventArgs e)
        {
            if (contentTb.Text.Length <= 0) 
                OptionChange?.Invoke(oldContent, false);
            else
                OptionChange?.Invoke(contentTb.Text, false);
            this.Close();
        }

        private void completeBtn_Click(object sender, System.EventArgs e)
        {            
            OptionChange?.Invoke(oldContent, true);            
            this.Close();
        }

        private void backBtn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
