using PAPI.Exception;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace PAPI.Settings
{
    public static class CurrentPlayer
    {
        public static Player _player { get; private set; } = new Player("NO VALID NAME", GetLocalIPAddress());
        public static string _localIp { get; private set; } = GetLocalIPAddress();

        // --------------------------------------------------------------------------------------------------------------------------------

        private static string GetLocalIPAddress()
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
