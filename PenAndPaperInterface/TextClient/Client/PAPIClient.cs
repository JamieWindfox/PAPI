using PAPI.Logging;
using PAPI.Network;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

namespace PAPI.Client
{
    public static class PAPIClient
    {
        public static byte[] SendMessage(byte[] messageBytes)
        {
            const int bytesize = 1024 * 1024;
            try // Try connecting and send the message bytes  
            {
                System.Net.Sockets.TcpClient client = new System.Net.Sockets.TcpClient("127.0.0.1", 1234); // Create a new connection  
                NetworkStream stream = client.GetStream();

                stream.Write(messageBytes, 0, messageBytes.Length); // Write the bytes  
                Console.WriteLine("================================");
                Console.WriteLine("=   Connected to the server    =");
                Console.WriteLine("================================");
                Console.WriteLine("Waiting for response...");

                messageBytes = new byte[bytesize]; // Clear the message   

                // Receive the stream of bytes  
                Int32 bytes = stream.Read(messageBytes, 0, messageBytes.Length);
                HandleResponse(ref messageBytes, bytes);

                // Clean up  
                stream.Dispose();
                client.Close();
            }
            catch (SocketException e) // Catch exceptions  
            {
                Console.WriteLine(e.Message);
            }

            return messageBytes; // Return response  
        }

        private static void HandleResponse(ref byte[] messageBytes, int bytes)
        {
            string responseData = System.Text.Encoding.Unicode.GetString(messageBytes, 0, bytes);
            WfLogger.Log("PAPI Client", LogLevel.DEBUG, "Received Response: " + responseData + " from Server");

            if (responseData.Contains("PlayerJoinResponse"))
            {
                PlayerJoinResponse response = JsonSerializer.Deserialize<PlayerJoinResponse>(responseData);
                Console.WriteLine("Added to Party: " + response.addedPlayerName);
            }
            else
            {
                // TODO
            }
        }
    }
}
