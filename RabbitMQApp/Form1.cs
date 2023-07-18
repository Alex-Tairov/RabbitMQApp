using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabbitMQApp
{
    public partial class Form1 : Form
    {
        private IConnection _rabbitMqConnection;
        public Form1()
        {
            InitializeComponent();
        }

     
        private void btnConnectRabbitMq_Click(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["RabbitMqConnection"].ConnectionString;
            var connectionFactory = new ConnectionFactory();
            connectionFactory.Uri = new Uri(connectionString);
            connectionFactory.AutomaticRecoveryEnabled = true;
            connectionFactory.DispatchConsumersAsync = true;
            _rabbitMqConnection = connectionFactory.CreateConnection("DemoAppClient");
        }

        private void btnCreateExchange_Click(object sender, EventArgs e)
        {
            using (var channel = _rabbitMqConnection.CreateModel())
            {
                channel.ExchangeDeclare("CustomerNotification", ExchangeType.Direct, true, false);
            }
        }

        private void btnCreateQueues_Click(object sender, EventArgs e)
        {
            using (var channel = _rabbitMqConnection.CreateModel())
            {
                channel.QueueDeclare("Email", true, false, false);
                channel.QueueDeclare("Sms", true, false, false);
            }
        }
    }
}
