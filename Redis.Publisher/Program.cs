using StackExchange.Redis;







ConnectionMultiplexer connection = await ConnectionMultiplexer.ConnectAsync("localhost:2727");
ISubscriber subscriber = connection.GetSubscriber();

while (true)
{
    Console.WriteLine("Message: ");
    string message = Console.ReadLine();
    await subscriber.PublishAsync("mychannel", message);
}
