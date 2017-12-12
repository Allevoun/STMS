using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_time_management_system
{
    public class Settings
    {
        public static int ST_Panel_maxWidth { get; set; }
        public static int ST_Panel_minWidth { get; set; }
        public static int ST_Panel_maxHeight { get; set; }

        public Settings()
        {
            ST_Panel_maxWidth = 110;
            ST_Panel_minWidth = 30;
        }
    }
}
