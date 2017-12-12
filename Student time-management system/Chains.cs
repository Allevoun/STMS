using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_time_management_system.Page_stock;

namespace Student_time_management_system
{
    static class Chains
    {
        private static MainWindow _mainwindow = new MainWindow();
        private static To_do_list _to_do_list = new To_do_list();

        public static MainWindow MainWindow
        {
            get
            {
                return _mainwindow;
            }
        }

        public static To_do_list To_do_list
        {
            get
            {
                return _to_do_list;
            }
        }
    }
}
