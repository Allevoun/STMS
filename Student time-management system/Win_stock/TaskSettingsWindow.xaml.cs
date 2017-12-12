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

namespace Student_time_management_system.Win_stock
{
    /// <summary>
    /// Логика взаимодействия для TaskSettingsWindow.xaml
    /// </summary>
    public partial class TaskSettingsWindow : Window
    {
        public TaskSettingsWindow()
        {
            InitializeComponent();

            //Task_TBk.Text = Chains.To_do_list.Task_TX.Text;
            for (int i = 0; i <= 10; i++)
            {
                Prior_CB.Items.Add(i);
                Want_CB.Items.Add(i);
            }
            
            
        }

        private void BTN_Cansel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
