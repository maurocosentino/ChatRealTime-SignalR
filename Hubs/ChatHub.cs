using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;
using System.Threading.Tasks;

public class ChatHub : Hub
{
    // Diccionario para asociar ID de conexión con nombre de usuario
    private static Dictionary<string, string> UsuariosConectados = new Dictionary<string, string>();

    public async Task EnviarMensaje(string usuario, string mensaje)
    {
        await Clients.All.SendAsync("RecibirMensaje", usuario, mensaje);
    }

    public async Task UnirseAlChat(string usuario)
    {
        // Asocia el ID de conexión con el nombre del usuario
        if (!UsuariosConectados.ContainsKey(Context.ConnectionId))
        {
            UsuariosConectados[Context.ConnectionId] = usuario;
            // Notifica a todos que alguien se unió y envía la lista actualizada
            await Clients.All.SendAsync("UsuarioUnido", usuario, ObtenerListaUsuarios());
        }
    }

    public override async Task OnDisconnectedAsync(Exception exception)
    {
        // Cuando alguien se desconecta, remueve su ID y actualiza la lista
        if (UsuariosConectados.TryGetValue(Context.ConnectionId, out var usuario))
        {
            UsuariosConectados.Remove(Context.ConnectionId);
            // Envía la lista actualizada a todos
            await Clients.All.SendAsync("UsuarioDesconectado", usuario, ObtenerListaUsuarios());
        }
        await base.OnDisconnectedAsync(exception);
    }

    // Método helper para obtener la lista de nombres de usuarios
    private List<string> ObtenerListaUsuarios()
    {
        return new List<string>(UsuariosConectados.Values);
    }
}