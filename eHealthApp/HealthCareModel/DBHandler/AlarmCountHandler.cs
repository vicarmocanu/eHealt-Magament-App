using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCareModel.Object_Models;

namespace HealthCareModel.DBHandler
{
    class AlarmCountHandler : IAlarmCountHandler
    {
        //create
        public void createAlarmCount(string alarmName)
        {
            using (var db = new HealthModelsDataContext())
            {
                Alarm alarm = db.Alarms.SingleOrDefault(targetAlarm => targetAlarm.name.Equals(alarmName));
                if(alarm!=null)
                {
                    var alarmCount = new AlarmCount();

                    alarmCount.alarmId = alarm.id;
                    alarmCount.count = 0;

                    db.AlarmCounts.InsertOnSubmit(alarmCount);
                    db.SubmitChanges();
                }
            }

        }

        //delete
        public void deleteAlarmCount(int alarmId)
        {
            using (var db = new HealthModelsDataContext())
            {
                AlarmCount alarmCount = db.AlarmCounts.SingleOrDefault(targetAlarmCount => targetAlarmCount.alarmId == alarmId);
                if(alarmCount != null)
                {
                    db.AlarmCounts.DeleteOnSubmit(alarmCount);
                    db.SubmitChanges();
                }
            }
        }

        //get
        public AlarmCount getAlarmCount(int alarmId)
        {
            var alarmCount = new AlarmCount();

            using (var db = new HealthModelsDataContext())
            {
                var query = db.AlarmCounts.SingleOrDefault(targetAlarmCount => targetAlarmCount.alarmId == alarmId);
                alarmCount = query;
            }

            return alarmCount;
        }

        //increment the count whenever a new user decides to attend a nearby alarm
        public void incrementAlarmCount(int alarmId)
        {
            using (var db = new HealthModelsDataContext())
            {
                AlarmCount alarmCount = db.AlarmCounts.SingleOrDefault(targetAlarmCount => targetAlarmCount.alarmId == alarmId);
                if(alarmCount != null)
                {
                    alarmCount.count += 1;

                    db.SubmitChanges();
                }
            }
        }
    }
}
