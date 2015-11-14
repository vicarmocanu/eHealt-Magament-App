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
        public void createAlarmAttendance(int alarmId, int userId)
        {
            using (var db = new HealthModelsDataContext())
            {
                var alarmAttendace = new AlarmAttendance();

                alarmAttendace.userId = userId;
                alarmAttendace.alarmId = alarmId;

                db.AlarmAttendances.InsertOnSubmit(alarmAttendace);
                db.SubmitChanges();
            }
        }

        //delete alarm attendance
        public void deleteAlarmAttendance(int alarmId, int userId)
        {
            using (var db = new HealthModelsDataContext())
            {
                AlarmAttendance alarmAttendace = db.AlarmAttendances.SingleOrDefault(attendance => attendance.alarmId == alarmId && attendance.userId == userId);

                if(alarmAttendace != null)
                {
                    db.AlarmAttendances.DeleteOnSubmit(alarmAttendace);
                    db.SubmitChanges();
                }
            }
        }

        //get the users who attend a particular alarm
        public List<User> getAllarmAttendants(int alarmId)
        {
            List<User> attendants = new List<User>();

            using (var db = new HealthModelsDataContext())
            {
                List<AlarmAttendance> alarmAttendances = new List<AlarmAttendance>();

                var attendancesQuery = db.AlarmAttendances.Where(attendace => attendace.alarmId == alarmId).ToList();
                alarmAttendances = attendancesQuery;

                foreach(AlarmAttendance alarmAttendance in alarmAttendances)
                {
                    User attendant = db.Users.SingleOrDefault(attendantUser => attendantUser.id == alarmAttendance.userId);
                    attendants.Add(attendant);
                }
            }

            return attendants;
        }
    }
}
