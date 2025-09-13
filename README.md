Aplicación de Chat Instantáneo usando SignalR y ASP.NET Core

![Captura de pantalla del chat](images/Sala.png)\

## Descripción

Este proyecto es una **aplicación de chat en tiempo real** construida con **ASP.NET Core** y **SignalR**. Permite que múltiples usuarios envíen mensajes instantáneamente, se unan al chat, y vean una lista dinámica de usuarios conectados que se actualiza automáticamente cuando alguien se conecta o desconecta. Es un proyecto para aprender sobre aplicaciones web interactivas usando WebSockets.

Desarrollado como parte de mi portfolio, este chat uso SignalR para conexiones en tiempo real, broadcasting de mensajes y gestión de usuarios en vivo. Probar abriendo varias pestañas del navegador y chatea en tiempo real.

## Tecnologías Usadas

- **Backend**: .NET Core 8 (o superior) con ASP.NET Core
- **Tiempo Real**: SignalR (para hubs y conexiones en vivo)
- **Frontend**: HTML5, JavaScript (cliente SignalR), Tailwind CSS (para diseño moderno y responsive)
- **Herramientas**: VS Code, .NET CLI

## Requisitos Previos

- .NET SDK 8 o superior instalado.
- Un editor de código (recomiendo Visual Studio Code con extensión C#).
- Navegador web moderno (Chrome, Firefox, etc.).

## Instalación

1. Clona el repositorio:

   ```
   git clone https://github.com/tu-usuario/ChatRealTimePortfolio.git
   cd ChatRealTimePortfolio
   ```

2. Restaura las dependencias:

   ```
   dotnet restore
   ```

3. Instala el paquete de SignalR si no está incluido (opcional, ya que lo agregamos manualmente):

   ```
   dotnet add package Microsoft.AspNetCore.SignalR
   ```

## Uso

1. Ejecuta el proyecto:

   ```
   dotnet run
   ```

2. Abre tu navegador y ve a `https://localhost:5001/index.html` (o el puerto que muestre la consola; usa HTTP si no hay HTTPS).

3. En la página:

   - Ingresa tu nombre en el campo "Tu nombre".
   - Escribe un mensaje y haz clic en "Enviar".
   - Abre otra pestaña para simular otro usuario: ¡Verás los mensajes y la lista de usuarios en tiempo real!

El chat se conecta automáticamente al Hub de SignalR en `/chatHub`.

## Características

- **Mensajes en Tiempo Real**: Envía y recibe mensajes instantáneamente usando SignalR.
- **Gestión Dinámica de Usuarios**: Muestra una lista de usuarios conectados, actualizada al unirse o desconectarse.
- **Diseño Moderno**: Interfaz responsive con Tailwind CSS, auto-scroll en mensajes y validación básica.
- **Escalable**: Código listo para expandir con nuevas funcionalidades como autenticación o grupos.

## Estructura del Proyecto

```
ChatRealTimePortfolio/
├── Hubs/
│   └── ChatHub.cs          # Lógica del chat (EnviarMensaje, UnirseAlChat, OnDisconnectedAsync)
├── wwwroot/
│   └── index.html          # Frontend con HTML, JS y Tailwind CSS
├── Program.cs              # Configuración de SignalR (AddSignalR y MapHub)
├── ChatRealTimePortfolio.csproj  # Dependencias del proyecto
└── README.md               # Este archivo
```

## Pruebas

1. Ejecuta `dotnet run`.
2. Abre dos pestañas en `localhost:5001/index.html`.
3. En la primera: Ingresa "Usuario1", envía un mensaje.
4. En la segunda: Ingresa "Usuario2" – verás la lista de usuarios actualizada y el mensaje de Usuario1.
5. Cierra la primera pestaña: La segunda mostrará "¡Usuario1 se desconectó!" y la lista actualizada.

Si algo falla, revisa la consola del navegador o el output de `dotnet run` para errores.

## Mejoras Futuras

- Agregar autenticación con ASP.NET Identity para usuarios registrados.
- Soporte para salas de chat privadas (grupos).
- Persistencia de mensajes en una base de datos (SQLite o SQL Server).
- Notificaciones.
- Indicador de "está escribiendo..." con SignalR.

## Contribuciones

¡Si quieres contribuir, abre un issue o pull request! Estoy abierto a ideas para mejorar el chat.

## Licencia

Este proyecto está bajo la licencia MIT. Ver LICENSE para detalles.

## Autor

Desarrollado por \[Mauro Cosentino\] – \[mauroxcosentino@gmail.com\]\
\[\https://github.com/maurocosentino\]

---

*Inspirado en tutoriales de Microsoft Learn sobre SignalR. Creado para aprender y compartir.*