using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCareModel.Object_Models;

namespace HealthCareModel.DBHandler
{
    interface IAlarmAttendanceHandler
    {
        //create alarm attendance
        void createAlarmAttendance(string alarmName, string userName);

        //delete alarm attendance
        void deleteAlarmAttendance(string alarmName, string userName);

        //get the attendants of an alarm
        List<User> getAllarmAttendants(string alarmName);
    }
}
