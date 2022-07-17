using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public static class Extension
    {
        public static bool CheckNotRobotCode(this string RobotCode)
        {
            if(RobotCode.Length < 5 && RobotCode.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
