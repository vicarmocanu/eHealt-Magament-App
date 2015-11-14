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
        void createAlarmAttendance(int alarmId, int userId);

        //delete alarm attendance
        void deleteAlarmAttendance(int alarmId, int userId);

        //get the attendants of an alarm
        List<User> getAllarmAttendants(int alarmId);
    }
}
