using Microsoft.AspNetCore.SignalR.Client;

namespace MainSignalClient
{
    public class MainClient
    {
        public static async Task ExecuteAsync()
        {
            try
            {
                var uri = "http://localhost:5001/current-time";

                await using var connection = new HubConnectionBuilder().WithUrl(uri).Build();
                await connection.StartAsync();

                await foreach (var date in connection.StreamAsync<DateTime>("Streaming"))
                {
                    Console.WriteLine(date);
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
