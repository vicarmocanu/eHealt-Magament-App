using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCareModel.Object_Models;

namespace HealthCareModel.DBHandler
{
    class AlarmAttendanceHandler : IAlarmAttendanceHandler
    {
        //create alarm attendance
        public void createAlarmAttendance(string alarmName, string userName)
        {
            using (var db = new HealthModelsDataContext())
            {
                Alarm alarm = db.Alarms.SingleOrDefault(targetAlarm => targetAlarm.name.Equals(alarmName));
                User user = db.Users.SingleOrDefault(targetUser => targetUser.userName.Equals(userName));

                if (alarm != null && user != null)
                {
                    var alarmAttendace = new AlarmAttendance();

                    alarmAttendace.userId = user.id;
                    alarmAttendace.alarmId = alarm.id;

                    db.AlarmAttendances.InsertOnSubmit(alarmAttendace);
                    db.SubmitChanges();
                }
            }
        }

        //delete alarm attendance
        public void deleteAlarmAttendance(string alarmName, string userName)
        {
            using (var db = new HealthModelsDataContext())
            {
                Alarm alarm = db.Alarms.SingleOrDefault(targetAlarm => targetAlarm.name.Equals(alarmName));
                User user = db.Users.SingleOrDefault(targetUser => targetUser.userName.Equals(userName));

                if (alarm != null && user != null)
                {
                    AlarmAttendance alarmAttendace = db.AlarmAttendances.SingleOrDefault(attendance => attendance.alarmId == alarm.id && attendance.userId == user.id);

                    if (alarmAttendace != null)
                    {
                        db.AlarmAttendances.DeleteOnSubmit(alarmAttendace);
                        db.SubmitChanges();
                    }
                }
            }
        }

        //get the users who attend a particular alarm
        public List<User> getAllarmAttendants(string alarmName)
        {
            List<User> attendants = new List<User>();

            using (var db = new HealthModelsDataContext())
            {
                Alarm alarm = db.Alarms.SingleOrDefault(targetAlarm => targetAlarm.name.Equals(alarmName));

                if (alarm != null)
                {
                    List<AlarmAttendance> alarmAttendances = new List<AlarmAttendance>();

                    var attendancesQuery = db.AlarmAttendances.Where(attendace => attendace.alarmId == alarm.id).ToList();
                    alarmAttendances = attendancesQuery;

                    foreach (AlarmAttendance alarmAttendance in alarmAttendances)
                    {
                        User attendant = db.Users.SingleOrDefault(attendantUser => attendantUser.id == alarmAttendance.userId);
                        attendants.Add(attendant);
                    }
                }                
            }

            return attendants;
        }
    }
}
