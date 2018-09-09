using System;
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

namespace ProjectP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<Task> tasksToday = new List<Task>();

        public MainWindow()
        {
            InitializeComponent();
            todayList.ItemsSource = tasksToday;
        }

        private void addTaskToday(object sender, RoutedEventArgs e) { //Event handler for the 'Toevoegen' button
            addTaskTodayDialog window = new addTaskTodayDialog();
            window.Show();
        }

        public void addTaskToList(Task task) {
            tasksToday.Add(task);
            todayList.ItemsSource = tasksToday;
            Console.WriteLine(tasksToday.Count);
        }


        

    }
}
