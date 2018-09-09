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
using System.Windows.Shapes;

namespace ProjectP
{
    /// <summary>
    /// Interaction logic for addTaskTodayDialog.xaml
    /// </summary>
    public partial class addTaskTodayDialog : Window
    {
        public addTaskTodayDialog()
        {
            InitializeComponent();
        }

        private void addTaskClick(object sender, RoutedEventArgs e)
        {
            string desc = descBox.GetLineText(0);
            string time = timeBox.GetLineText(0);

            Task task = new Task(desc,
                DateTime.Now,
                true,
                false,
                int.Parse(time));
            var win = (MainWindow)Application.Current.MainWindow;
            win.addTaskToList(task);
        }

    }
}
