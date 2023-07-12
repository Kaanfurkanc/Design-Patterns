using StrategyPattern;
using StrategyPattern.Concretes;

string value = "İstanbul";


// Using Kafka

var queueManager = new QueueManager(new Kafka());
queueManager.SendToQueue(value);

// Using RabbitMq

queueManager = new QueueManager(new RabbitMQ());
queueManager.SendToQueue(value);