using PAPI.Character;
using PAPI.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;
using PAPI.Settings;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Jamie");

            byte[] bytes = sendMessage(System.Text.Encoding.Unicode.GetBytes(JsonSerializer.Serialize(player)));

        }

        private static byte[] sendMessage(byte[] messageBytes)
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

                // String to store the response ASCII representation.
                String responseData = String.Empty;

                // Receive the stream of bytes  
                Int32 bytes = stream.Read(messageBytes, 0, messageBytes.Length);
                responseData = System.Text.Encoding.ASCII.GetString(messageBytes, 0, bytes);

                WfLogger.Log("PAPI Client", LogLevel.DEBUG, "Received: " + responseData);

                // Clean up  
                stream.Dispose();
                client.Close();
            }
            catch (Exception e) // Catch exceptions  
            {
                Console.WriteLine(e.Message);
            }

            return messageBytes; // Return response  
        }
    }


}
