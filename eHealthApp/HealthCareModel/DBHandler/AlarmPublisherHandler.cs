using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCareModel.Object_Models;

namespace HealthCareModel.DBHandler
{
    class AlarmPublisherHandler : IAlarmPublisherHandler
    {
        public void createAlarmPublisher(string pacientName, string condition, string location, string password)
        {
            using (var db = new HealthModelsDataContext())
            {
                var publisher = new AlarmPublisher();

                publisher.pacient_name = pacientName;
                publisher.condition = condition;
                publisher.location = location;
                publisher.password = password;

                db.AlarmPublishers.InsertOnSubmit(publisher);
                db.SubmitChanges();
            }
        }

        public AlarmPublisher getAlarmPublisher(int id)
        {
            var publisher = new AlarmPublisher();

            using (var db = new HealthModelsDataContext())
            {
                var query = db.AlarmPublishers.SingleOrDefault(targetPublisher => targetPublisher.id == id);
                publisher = query;
            }

            return publisher;
        }

        public List<AlarmPublisher> getAllAlarmPublishers()
        {
            List<AlarmPublisher> publishers = new List<AlarmPublisher>();

            using (var db = new HealthModelsDataContext())
            {
                var query = db.AlarmPublishers.ToList();
                publishers = query;
            }

            return publishers;
        }

        public void updateAlarmPublisher(int id, string pacientName, string condition, string location, string password)
        {
            var publisher = new AlarmPublisher();

            using (var db = new HealthModelsDataContext())
            {
                publisher = db.AlarmPublishers.SingleOrDefault(targetPublisher => targetPublisher.id == id);

                if (publisher != null)
                {
                    publisher.pacient_name = pacientName;
                    publisher.condition = condition;
                    publisher.location = location;
                    publisher.password = password;

                    db.SubmitChanges();
                }
            }
        }
    }
}
