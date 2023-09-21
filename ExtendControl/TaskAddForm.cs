using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtendControl
{
    public partial class TaskAddForm : Form
    {
        public event OptionHandler TaskAdd;

        public TaskAddForm()
        {
            InitializeComponent();
            BackColor = ExtendColor.White;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (contentTb.Text.Length > 0)
                TaskAdd?.Invoke(contentTb.Text, false);
            this.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
