using PAPI.Character;
using PAPI.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using PAPI.Settings;
using System.Runtime.Serialization;
using GameMasterPAPI.Views;

namespace GameMasterPAPI.Server
{
    class PAPIServer
    {
        private static TcpListener listener;

        public static void Start()
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Loopback, 1234); // Address  
            listener = new TcpListener(ep); // Instantiate the object  
            listener.Start(); // Start listening...  
            WfLogger.Log("GameMasterPAPI.Server.PAPIServer", LogLevel.DEBUG, "PAPI Server started. Listening for requests on " + ep.Address + ":" + ep.Port +  " ...");

            ListenForRequests();
        }

        private static void ListenForRequests()
        {
            var thread = new Thread(() =>
            {
                while (true)
                {
                    const int bytesize = 1024 * 1024;

                    string message = null;
                    byte[] buffer = new byte[bytesize];

                    var sender = listener.AcceptTcpClient();
                    sender.GetStream().Read(buffer, 0, bytesize);

                    // Read the message and perform different actions  
                    message = CleanMessage(buffer);

                    WfLogger.Log("GameMasterPAPI.Server.PAPIServer", LogLevel.DEBUG, "Received a TCP connection from " + sender.GetType() + " (Message = " + message + ")");

                    // Save the data sent by the client;  
                    Player player = JsonSerializer.Deserialize<Player>(message); // Deserialize  

                    byte[] bytes = System.Text.Encoding.Unicode.GetBytes("Added Player " + player.name + " to game");
                    sender.GetStream().Write(bytes, 0, bytes.Length); // Send the response  

                    WfLogger.Log("GameMasterPAPI.Server.PAPIServer", LogLevel.DEBUG, "Received Player: " + player.name);
                    PlayerSearchPopup playerPopup = new PlayerSearchPopup();
                    playerPopup.Popup(null);
                }
            });
            thread.Start();
        }

        // Pass byte array as parameter  
        private static string CleanMessage(byte[] bytes)
        {
            // Get the string of the message from bytes  
            string message = System.Text.Encoding.Unicode.GetString(bytes);

            string messageToPrint = null;
            // Loop through each character in that message  
            foreach (var nullChar in message)
            {
                // Only store the characters, that are not null character  
                if (nullChar != '\0')
                {
                    messageToPrint += nullChar;
                }
            }

            // Return the message without null characters.   
            return messageToPrint;
        }

        // Sends the message string using the bytes provided and TCP client connected  
        private static void sendMessage(byte[] bytes, TcpClient client)
        {
            // Client must be connected to   
            client.GetStream() // Get the stream and write the bytes to it  
                  .Write(bytes, 0,
                  bytes.Length); // Send the stream  
        }
    }
}
