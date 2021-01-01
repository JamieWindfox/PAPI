using PAPI.Character;
using PAPI.Character.CharacterTypes;
using PAPI.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PAPI.Settings
{
    public class Game
    {
        public GenreEnum _genre { get; private set; }
        public Player _gameMaster { get; private set; }
        public Dictionary<Player, PlayerCharacter> _playerParty { get; private set; }
        public DateTime _dateOfCreation { get; private set; }
        public DateTime _dateOfLastSession { get; private set; }
        public List<UniqueRival> _npcs { get; private set; }
        
        // TODOs: Vehicles, Buildings, Maps

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// the json ctor must contain all traits of a game
        /// </summary>
        /// <param name="_genre">the genre of the game, if not valid, the whole game is not valid</param>
        /// <param name="_gameMaster">if invalid, the whole game is invalid</param>
        /// <param name="_playerParty">a dictionary of the players and their characters</param>
        /// <param name="_dateOfCreation">the date, when the game was first created, if null, this is set to current time</param>
        /// <param name="_dateOfLastSession">the date when the last session was saved, if null, this is set to current time</param>
        /// <param name="_npcs">a list of all unique npcs, the game master wanted to save, if null, the list is empty</param>
        [JsonConstructor]
        public Game(GenreEnum _genre, Player _gameMaster, Dictionary<Player, PlayerCharacter> _playerParty, DateTime _dateOfCreation, DateTime _dateOfLastSession,
            List<UniqueRival> _npcs)
        {
            if(_gameMaster == null || _genre == GenreEnum.NOT_VALID)
            {
                this._genre = GenreEnum.NOT_VALID;
                this._gameMaster = null;
                this._playerParty = new Dictionary<Player, PlayerCharacter>();
                this._npcs = new List<UniqueRival>();

            }
            else
            {
                this._genre = _genre;
                this._gameMaster = _gameMaster;
                this._playerParty = (_playerParty == null) ? new Dictionary<Player, PlayerCharacter>() : _playerParty;
                this._npcs = (_npcs == null) ? new List<UniqueRival>() : _npcs;
            }
            this._dateOfCreation = (_dateOfCreation == null) ? DateTime.Now : _dateOfCreation;
            this._dateOfLastSession = (_dateOfLastSession == null) ? DateTime.Now : _dateOfLastSession;
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        public void AddPlayer(Player player)
        {
            if(_playerParty.ContainsKey(player))
            {
                WfLogger.Log(this.GetType() + ".AddPlayer(Player)", LogLevel.WARNING, "Couldn't add player, because they already are in this game");
                return;
            }
            _playerParty.Add(player, null);
            WfLogger.Log(this.GetType() + ".AddPlayer(Player)", LogLevel.DEBUG, "Added Player '" + player._name + "' to Party");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        public void AddPlayerCharacter(Player player, PlayerCharacter playerCharacter)
        {
            if (!_playerParty.ContainsKey(player))
            {
                WfLogger.Log(this.GetType() + ".AddPlayerCharacter(Player, Character)", LogLevel.WARNING, 
                    "Couldn't add playerCharacter, because they already have a character in this game");
                return;
            }
            _playerParty[player] = playerCharacter;
        }
    }
}
