using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using HealthCareModel.ControlHandler;

namespace HealthCareWCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AlarmPublisherService" in both code and config file together.
    public class AlarmPublisherService : IAlarmPublisherService
    {
        private static readonly System.Object obj1 = new System.Object();
        private static readonly System.Object obj2 = new System.Object();
        private static readonly System.Object obj3 = new System.Object();
        private static readonly System.Object obj4 = new System.Object();

        public void createAlarmPublisher(string pacientName, string condition, string location, string password)
        {
            if (System.Threading.Monitor.TryEnter(obj1, 45000))
            {
                try
                {
                    AlarmPublisherControl.createAlarmPublisher(pacientName, condition, location, password);
                }
                catch (NullReferenceException)
                {

                }
                finally
                {
                    System.Threading.Monitor.Exit(obj1);
                }
            }
        }

        public AlarmPublisher getAlarmPublisher(int id)
        {
            AlarmPublisher servicePublisher = new HealthCareWCFServices.AlarmPublisher();
            if (System.Threading.Monitor.TryEnter(obj2, 45000))
            {
                try
                {
                    servicePublisher.Id = id;
                    servicePublisher.PacientName = AlarmPublisherControl.getAlarmPublisher(id).pacient_name;
                    servicePublisher.Location = AlarmPublisherControl.getAlarmPublisher(id).location;
                    servicePublisher.Condition = AlarmPublisherControl.getAlarmPublisher(id).condition;
                    servicePublisher.Password = AlarmPublisherControl.getAlarmPublisher(id).password;
                }
                catch (NullReferenceException)
                {

                }
                finally
                {
                    System.Threading.Monitor.Exit(obj2);
                }
            }
            return servicePublisher;
        }

        public List<AlarmPublisher> getAllAlarmPublishers()
        {
            List<AlarmPublisher> publishers = new List<AlarmPublisher>();

            if (System.Threading.Monitor.TryEnter(obj3, 45000))
            {
                try
                {

                    List<HealthCareModel.Object_Models.AlarmPublisher> returnList = AlarmPublisherControl.getAllAlarmPublishers();

                    if (returnList.Count != 0)
                    {
                        foreach (HealthCareModel.Object_Models.AlarmPublisher hostPublisher in returnList)
                        {
                            AlarmPublisher servicePublisher = new HealthCareWCFServices.AlarmPublisher();

                            servicePublisher.Id = hostPublisher.id;
                            servicePublisher.PacientName = hostPublisher.pacient_name;
                            servicePublisher.Location = hostPublisher.location;
                            servicePublisher.Condition = hostPublisher.condition;
                            servicePublisher.Password = hostPublisher.password;

                            publishers.Add(servicePublisher);
                        }
                    }
                }
                catch (NullReferenceException)
                {
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj3);
                }
            }

            return publishers;
        }

        public void updateAlarmPublisher(int id, string pacientName, string condition, string location, string password)
        {
            if (System.Threading.Monitor.TryEnter(obj4, 45000))
            {
                try
                {
                    AlarmPublisherControl.updateAlarmPublisher(id, pacientName, condition, location, password);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj4);
                }
            }
        }
    }
}
