using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCareModel.Object_Models;

namespace HealthCareModel.DBHandler
{
    class AlarmHandler : IAlarmHandler
    {
        //create Alarm
        public void createAlarm(string name, string type, string time, string location, string status)
        {
            using (var db = new HealthModelsDataContext())
            {
                var alarm = new Alarm();

                alarm.name = name;
                alarm.type = type;
                alarm.time = DateTime.Now;
                alarm.location = location;
                alarm.status = status;
            }
        }

        //get Alarm
        public Alarm getAlarm(string name)
        {
            var alarm = new Alarm();

            using (var db = new HealthModelsDataContext())
            {
                var query = db.Alarms.SingleOrDefault(targetAlarm => targetAlarm.name.Equals(name));
                alarm = query;
            }

            return alarm;
        }

        //get Alarms
        public List<Alarm> getAlarms()
        {
            List<Alarm> alarms = new List<Alarm>();

            using (var db = new HealthModelsDataContext())
            {
                var query = db.Alarms.ToList();
                alarms = query;
            }

            return alarms;
        }

        //update Alarm
        public void updateAlarm(string name, string type, string time, string location, string status)
        {
            var alarm = new Alarm();

            using (var db = new HealthModelsDataContext())
            {
                alarm = db.Alarms.SingleOrDefault(targetAlarm => targetAlarm.name.Equals(name));

                if (alarm!=null)
                {
                    alarm.name = name;
                    alarm.type = type;
                    alarm.time = DateTime.Now;
                    alarm.location = location;
                    alarm.status = status;

                    db.SubmitChanges();
                }
            }
        }

        //delete alarm
        public void deleteAlarm(string name)
        {
            using (var db = new HealthModelsDataContext())
            {
                var alarm = new Alarm();

                alarm = db.Alarms.SingleOrDefault(targetAlarm => targetAlarm.name.Equals(name));

                if(alarm!=null)
                {
                    db.Alarms.DeleteOnSubmit(alarm);
                    db.SubmitChanges();
                }
            }
        }
    }
}
