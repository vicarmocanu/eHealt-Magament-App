using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCareModel.DBHandler;
using HealthCareModel.Object_Models;

namespace HealthCareModel.ControlHandler
{
    public static class AlarmPublisherControl
    {
        private static IAlarmPublisherHandler publisherHandler = new AlarmPublisherHandler();

        public static void createAlarmPublisher(string pacientName, string condition, string location, string password)
        {
            publisherHandler.createAlarmPublisher(pacientName, condition, location, password);
        }

        public static void updateAlarmPublisher(int id, string pacientName, string condition, string location, string password)
        {
            publisherHandler.updateAlarmPublisher(id, pacientName, condition, location, password);
        }

        public static AlarmPublisher getAlarmPublisher(int id)
        {
            return publisherHandler.getAlarmPublisher(id);
        }

        public static List<AlarmPublisher> getAllAlarmPublishers()
        {
            return publisherHandler.getAllAlarmPublishers();
        }


    }
}
