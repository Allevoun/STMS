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
using Student_time_management_system.Page_stock;
using Student_time_management_system.Win_stock;
using System.Globalization;

namespace Student_time_management_system
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    To_do_list TDL = new To_do_list();
        //    Page_1.Content = TDL;
        //}

        //# FFDFD991

        To_do_list TDL = new To_do_list();
        Shedule_page SP = new Shedule_page();

        private void BTN_TDList(object sender, RoutedEventArgs e)
        {
            TDL.Width = Page_1.Width; 
            TDL.Height = Page_1.Height;
            Page_1.Content = TDL;

            //# FFEB31D8   
            //# FFF696E2
            BTN_TDList_N.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xF6, 0x96, 0xE2)); //РЕАЛИЗОВАТЬ ЧЕРЕЗ SETTINGS

        }

        private void BTN_Shdl(object sender, RoutedEventArgs e)
        {
            Page_1.Content = SP;

        }

        private void BTN_NLrn(object sender, RoutedEventArgs e)
        {

        }

        private void ST_Panel_MouseL(object sender, MouseEventArgs e) //MOUSE ENTER
        {

            ST_Panel_1.Width = 110; // СДЕЛАТЬ РЕАЛИЗАЦИЮ ЧЕРЕЗ КЛАСС SETTINGS

            StartLine.X1 = 110;
            StartLine.X2 = 110;


            BTN_TDList_N.Content = "To-do list";
            BTN_Shdl_N.Content = "Shedule";
            BTN_NLrn_N.Content = "New-learning";
        }

        private void ST_Panel_MouseE(object sender, MouseEventArgs e) //MOUSE LEAVE
        {
            ST_Panel_1.Width = 30;
            StartLine.X1 = 30;
            StartLine.X2 = 30;

            BTN_TDList_N.Content = "T";
            BTN_Shdl_N.Content = "S";
            BTN_NLrn_N.Content = "N";
        }

       
    }
}
