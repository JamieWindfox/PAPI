using PAPI.Character;
using PAPI.Character.CharacterTypes;
using PAPI.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace PAPI.Settings
{
    public class Game
    {
        public GenreEnum genre { get; private set; }
        public Player gameMaster { get; private set; }
        public Dictionary<Player, PlayerCharacter> playerParty { get; private set; }
        public DateTime dateOfCreation { get; private set; }
        public DateTime lastSession { get; private set; }

        public Game(GenreEnum genre)
        {
            this.genre = genre;
            playerParty = new Dictionary<Player, PlayerCharacter>();
            dateOfCreation = DateTime.Now;
            lastSession = DateTime.Now;
            gameMaster = CurrentPlayer.player;
        }

        public Game()
        {
            genre = GenreEnum.NOT_VALID;
            playerParty = new Dictionary<Player, PlayerCharacter>();
            dateOfCreation = DateTime.Now;
            lastSession = DateTime.Now;
            gameMaster = CurrentPlayer.player;
        }

        public string partyToString()
        {
            string output = "";
            bool first = true;
            foreach(KeyValuePair<Player, PlayerCharacter> player in playerParty)
            {
                if (!first) output += ", ";
                else first = false;
                output += player.Key._name + "(" + player.Value._name + ")";
            }
            return output;
        }

        public void AddPlayer(Player player)
        {
            if(playerParty.ContainsKey(player))
            {
                WfLogger.Log(this.GetType() + ".AddPlayer(Player)", LogLevel.WARNING, "Couldn't add player, because they already are in this game");
                return;
            }
            playerParty.Add(player, new PlayerCharacter(null, null, null, null, null, null, null, null, null, null, null, null, null));
            WfLogger.Log(this.GetType() + ".AddPlayer(Player)", LogLevel.DEBUG, "Added Player '" + player._name + "' to Party");
        }
    }
}
