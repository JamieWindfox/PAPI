using PAPI.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPIClient.Server
{
    public static class PendingMessages
    {
        public static List<Player> waitingPlayers { get; set; } = new List<Player>();

    }
}
