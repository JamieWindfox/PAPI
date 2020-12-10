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
using PAPI.Network;
using PAPI.Client;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Raine", CurrentPlayer.GetLocalIPAddress());
            PlayerJoinRequest request = new PlayerJoinRequest("PlayerJoinRequest", player);
            byte[] bytes = PAPIClient.SendMessage(System.Text.Encoding.Unicode.GetBytes(JsonSerializer.Serialize(request)));

        }
    }
}
