using System;
using System.Windows.Forms;

namespace TODO
{
    public partial class Form1 : Form
    {
        private TaskTable _table;
        public Form1()
        {
            InitializeComponent();
            _table = new TaskTable();
            _table.Tasks.Add(new Task(DateTime.Now, "코딩 1시간하기"));
            treeView1.Nodes.Add("오늘");
            InitListView();
        }

        private void InitListView()
        {
            listView1.Items.Clear();

            foreach(var t in _table.Tasks)
            {
                ListViewItem item = new ListViewItem(t.What)
                {
                    Checked = t.Done,
                    Tag = t
                };
                listView1.Items.Add(item);
            }
        }

        private void SetListviewColumnSize()
        {

        }

        private void Form1_Resize(object sender, System.EventArgs e)
        {
            SetListviewColumnSize();
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            SetListviewColumnSize();
        }
    }
}
