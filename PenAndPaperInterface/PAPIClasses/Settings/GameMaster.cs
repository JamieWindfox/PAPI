using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace PAPI.Settings
{
    public class GameMaster : Player
    {
        public string m_ipAdress { get; private set; }

        public GameMaster(string name) : base(name)
        {
            m_ipAdress = Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
        }
    }
}
