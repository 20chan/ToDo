using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TodoWPF
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
    }

    public class TaskView
    {
        private ObservableCollection<TodoTask> _tasks;
        public ObservableCollection<TodoTask> TaskCollection => _tasks;

        public TaskView()
        {
            _tasks = new ObservableCollection<TodoTask>();
            _tasks.Add(new TodoTask(DateTime.Now, "10시간 코딩해라"));
        }
    }
}
