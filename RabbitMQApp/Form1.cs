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

        private void button1_Click(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["RabbitMqConnection"].ConnectionString;
            var connectionFactory = new ConnectionFactory();
            connectionFactory.Uri = new Uri(connectionString);
            connectionFactory.AutomaticRecoveryEnabled = true;
            connectionFactory.DispatchConsumersAsync = true;
            _rabbitMqConnection = connectionFactory.CreateConnection("DemoAppClient");
        }
    }
}
