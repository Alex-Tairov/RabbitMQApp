# RabbitMQApp

## Описание функционала.
- Connect RabbitMQ создание соединения  с локальным сервером RabbitMQ.
- Create Exchange создает обменник(тип Direct).
- Create Queues создание очередей.
- Bind Queues привязка очередей к обменнику.
- Subscribe Email Queue подключение пользователя (routingKey:Email).
- Subscribe SMS Queue подключение пользователя (routingKey:SMS).
- Publish Email  отправка сообщений в очередь EmailNotification.
- Publish SMS отправка сообщений в очередь SMSNotification.
