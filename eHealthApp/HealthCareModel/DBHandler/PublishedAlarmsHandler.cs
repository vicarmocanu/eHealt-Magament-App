using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCareModel.Object_Models;

namespace HealthCareModel.DBHandler
{
    class PublishedAlarmsHandler : IPublishedAlarms
    {
        public void createPublishedAlarm(int alarmId, int publisherId)
        {
            using (var db = new HealthModelsDataContext())
            {
                var publishedAlarm = new PublishedAlarm();

                publishedAlarm.alarmId = alarmId;
                publishedAlarm.publisherId = publisherId;

                db.PublishedAlarms.InsertOnSubmit(publishedAlarm);
                db.SubmitChanges();
            }
        }
        
        public int getPublisherId(int alarmId)
        {
            int publisherId = 0;

            using (var db = new HealthModelsDataContext())
            {
                var query = db.PublishedAlarms.SingleOrDefault(targetPublished => targetPublished.alarmId == alarmId);
                var publishedAlarm = new PublishedAlarm();
                publishedAlarm = query;
                publisherId = publishedAlarm.publisherId;
            }

            return publisherId;
        }
    }
}
