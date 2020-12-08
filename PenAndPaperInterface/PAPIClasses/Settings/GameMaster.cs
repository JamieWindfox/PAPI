using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using PAPI.Exception;
using System.Text.Json.Serialization;

namespace PAPI.Settings
{
    public class GameMaster : Player
    {
        public string m_ipAdress { get; private set; }

        [JsonConstructor]
        public GameMaster(string name) : base(name)
        {
            m_ipAdress = GetLocalIPAddress();
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new NetworkException("No network adapters with an IPv4 address in the system!");
        }

    }
}
