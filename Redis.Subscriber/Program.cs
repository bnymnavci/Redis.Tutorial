using StackExchange.Redis;



ConnectionMultiplexer connection = await ConnectionMultiplexer.ConnectAsync("localhost:2727");
ISubscriber subscriber = connection.GetSubscriber();

subscriber.SubscribeAsync("mychannel", (channel, message) =>
{
    Console.WriteLine(message);
});

Console.Read();