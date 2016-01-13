using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace AlarmReceiver
{
    public  class AttendAlarm
    {
        public int GetMQAlarmID()
        {
            int alarmID = 0;

            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: "alarm",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                    var consumer = new QueueingBasicConsumer(channel);

                    channel.BasicConsume(queue: "alarm",
                                    noAck: true,
                                    consumer: consumer);

                   
                    var ea = (BasicDeliverEventArgs)consumer.Queue.Dequeue();

                    var body = ea.Body;
                    var message = Encoding.UTF8.GetString(body);
                    alarmID = Convert.ToInt32(message);
                }
            }
            return alarmID;
        }

        public static void DeleteAlarmQueue()
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDelete("alarm");
            }
        }
    }
}