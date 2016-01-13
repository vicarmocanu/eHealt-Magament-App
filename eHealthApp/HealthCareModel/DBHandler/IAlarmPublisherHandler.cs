using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCareModel.Object_Models;

namespace HealthCareModel.DBHandler
{
    interface IAlarmPublisherHandler
    {
        //create 
        void createAlarmPublisher(string pacientName, string condition, string location, string password);

        //update
        void updateAlarmPublisher(int id, string pacientName, string condition, string location, string password);

        //get
        AlarmPublisher getAlarmPublisher(int id);

        //getAll
        List<AlarmPublisher> getAllAlarmPublishers();
    }
}
