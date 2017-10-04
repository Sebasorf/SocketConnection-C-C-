#include <sys/socket.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <sys/types.h> 
#include <netinet/in.h>
#include <fcntl.h>
#include <unistd.h>
#include <arpa/inet.h>

void error(const char *);

int main(int argc, char *argv[])
{
    //Variables de aplicacion
    int socket_fd, server_length, connection, msg_sent;
    struct sockaddr_in server_addr;
    char msg[350];
    if ( sizeof msg > strlen("hola sj3 kakel2") )
        strncpy(msg, "holaaaa paochita, ahora hice la inversa. Levante un servidor en C# quien va a leer todo lo que le envie desde el linux con el script del cliente en C. El tema es que al ser c# un lenguaje de alto nivel, le puedo mandar todo lo que quiera sin que el chabon sepa cuanto voy a enviarle y lo va a manejar bien de todas formas sin buffer overflow. Bueno.. chuchis jeje", sizeof msg);

    //Socket();
    socket_fd = socket(AF_INET, SOCK_STREAM, 0);
    if(socket_fd == -1) error("Hubo un error al abrir el socket\n");

    //Configuro server_addr
    server_addr.sin_family = AF_INET;
    server_addr.sin_addr.s_addr = inet_addr("192.168.0.62");
    //server_addr.sin_addr.s_addr = inet_addr("127.0.0.1"); //or =INADDR_ANY
    //server_addr.sin_addr.s_addr = inet_addr("192.168.0.21");
    server_addr.sin_port = htons(8000);

    //Configuro server length
    server_length = sizeof(server_addr);

    //Connect()
    connection = connect(socket_fd, (struct sockaddr *)&server_addr, server_length);
    if (connection == -1) error("Hubo un error al intentar conectarse al server\n");
    else
    {
        printf("Salio todo re bien \n");
        
        //Enviar un mensaje al servidor
        msg_sent = send(socket_fd, msg, strlen(msg), 0);
	    if(msg_sent == -1) error("Hubo un error al enviar el mensaje al servidor\n"); 
        printf("Se envio el mensaje al servidor correctamente\n");
        printf("Me desconecto\n");
        close(socket_fd);
    }
    return 0;

}

void error(const char *msg)
{
    perror(msg);
    exit(0);
}

