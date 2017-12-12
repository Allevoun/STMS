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
using Student_time_management_system.Win_stock;

namespace Student_time_management_system.Page_stock
{
    /// <summary>
    /// Логика взаимодействия для To_do_list.xaml
    /// </summary>
    public partial class To_do_list : Page
    {
        public To_do_list()
        {
            

            InitializeComponent();

            //this.Width = Chains.MainWindow.Page_1.Width;
            //this.Height = Chains.MainWindow.Page_1.Height;


        }

        private void BTN_Add(object sender, RoutedEventArgs e)
        {
            if (Task_TX!=null)
            {
                Tasks_LB.Items.Add(Task_TX.Text);
            }

            TaskSettingsWindow _tasksettingswindow = new TaskSettingsWindow();

            _tasksettingswindow.Task_TBk.Text = Task_TX.Text;
            _tasksettingswindow.Show();
            
        }

        private void BTN_Start(object sender, RoutedEventArgs e)
        {

        }
    }
}
