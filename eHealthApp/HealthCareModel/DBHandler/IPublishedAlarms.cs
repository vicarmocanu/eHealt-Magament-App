using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareModel.DBHandler
{
    interface IPublishedAlarms
    {
        //create
        void createPublishedAlarm(int alarmId, int publisherId);

        //get publisherId
        int getPublisherId(int alarmId);
    }
}
