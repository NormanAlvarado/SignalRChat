using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

public class ChatHub : Hub
{
    public async Task SendMessage(string user, string message)
    {
        // Enviar el mensaje a todos los clientes conectados
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}
