# SocketConnection/C-CSharp

In this repository, I have programmed some examples of Socket Connections between C - C# clients and servers. There are 4 ways of executing them:
- C client && C server
- C client && C# server
- C# client && C server (*)
- C# client && C# server

(*) This is the main connection, because we have a .net-written interface with buttons that represent a controller. While pressing this buttons, you send a command to C server that receives these below characters and made some processing. 
- UP -> 'U'
- DOWN -> 'D'
- RIGHT -> 'R'
- LEFT -> 'L'
- PUSH -> 'H'
- PULL -> 'P'
- TURNLEFT -> ??
- TURNRIGHT -> ??

In client UI, you must set an IP / PORT for the server you want to connect. Server must be listening before client runs.

Remember that you must run C# code on Windows, and C part on linux.

Some definitions:
- Yaw: girar sobre el eje Y para izquierda o derecha - 2 sentidos
- Roll: ir hacia adelante, hacia atras, izquierda o derecha sin cambiar sentido a donde apunta - 4 sentidos
- Pitch: subir o bajar - 2 sentidos

Total: se requieren 8 inputs para cubrir la totalidad del movimiento de un drone.
