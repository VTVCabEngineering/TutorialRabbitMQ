using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;

namespace Sender
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo kết nối tới server RabbitMQ bao gồm tên server
            var factory = new ConnectionFactory()
            {
                HostName = "localhost",
                UserName = "yourUsername",
                Password = "yourPassword",
                VirtualHost = "yourVirtualHost"
            };


            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                // Khai báo queue có tên newMesage
                channel.QueueDeclare(queue: "hello",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                string message = "Hello World!";
                var body = Encoding.UTF8.GetBytes(message);
                // Gửi thông báo tới exchange mặc định như mình có lưu ý trong bài viết, và gửi tới queue có tên là newMesage vừa được khai báo
                channel.BasicPublish(exchange: "",
                                     routingKey: "hello",
                                     basicProperties: null,
                                     body: body);
                Console.WriteLine(" [x] Sent {0}", message);
            }

            Console.WriteLine(" Press [enter] to exit.");
            Console.ReadLine();
        }
    }
}
