using PAPI.Character;
using PAPI.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace PAPI.Settings
{
    public class Game
    {
        public GenreEnum m_genre { get; private set; }
        public GameMaster m_gameMaster { get; private set; }
        public Dictionary<Player, PlayerCharacter> m_party { get; private set; }
        public DateTime m_dateOfCreation { get; private set; }
        public DateTime m_lastSession { get; private set; }

        public Game(GenreEnum genre)
        {
            m_genre = genre;
            m_party = new Dictionary<Player, PlayerCharacter>();
            m_dateOfCreation = DateTime.Now;
            m_lastSession = DateTime.Now;
            m_gameMaster = GameSettings.GetGm();
        }

        public Game()
        {
            m_genre = GenreEnum.NOT_VALID;
            m_party = new Dictionary<Player, PlayerCharacter>();
            m_dateOfCreation = DateTime.Now;
            m_lastSession = DateTime.Now;
            m_gameMaster = GameSettings.GetGm();
        }

        public string partyToString()
        {
            string output = "";
            bool first = true;
            foreach(KeyValuePair<Player, PlayerCharacter> player in m_party)
            {
                if (!first) output += ", ";
                else first = false;
                output += player.Key.m_name + "(" + player.Value.GetName() + ")";
            }
            return output;
        }

        public void AddPlayer(Player player)
        {
            if(m_party.ContainsKey(player))
            {
                WfLogger.Log(this.GetType() + ".AddPlayer(Player)", LogLevel.WARNING, "Couldn't add player, because they already are in this game");
                return;
            }
            m_party.Add(player, new PlayerCharacter());
            WfLogger.Log(this.GetType() + ".AddPlayer(Player)", LogLevel.DEBUG, "Added Player '" + player.m_name + "' to Party");
        }
    }
}
