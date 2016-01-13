using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RabbitMQ.Client;
using System.Text;

namespace AlarmPublisher
{
    public class PanicButton
    {         
        public static void SendAlarmIdMQ(int id)
        {
            string message = Convert.ToString(id);            

            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "alarm",
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);

                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish(exchange: "",
                                 routingKey: "alarm",
                                 basicProperties: null,
                                 body: body);
            }
        }
    }
}