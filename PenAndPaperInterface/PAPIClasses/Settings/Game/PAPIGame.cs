using PAPI.Character;
using PAPI.Character.CharacterTypes;
using PAPI.Logging;
using PAPI.Settings.Game;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PAPI.Settings
{
    public class PAPIGame
    {
        public GenreEnum _genre { get; private set; }
        public Player _gameMaster { get; private set; }
        public Dictionary<Player, PlayerCharacter> _playerParty { get; private set; }
        public DateTime _dateOfCreation { get; private set; }
        public DateTime _dateOfLastSession { get; private set; }
        public List<UniqueRival> _knownNPCs { get; private set; }
        
        // TODOs: Vehicles, Buildings, Maps

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// the json ctor must contain all traits of a game
        /// </summary>
        /// <param name="_genre"></param>
        /// <param name="_gameMaster">if null, it is set to the current player</param>
        /// <param name="_playerParty">a dictionary of the players and their characters, if null there are no players yet</param>
        /// <param name="_dateOfCreation">the date, when the game was first created, if null, this is set to current time</param>
        /// <param name="_dateOfLastSession">the date when the last session was saved, if null, this is set to current time</param>
        /// <param name="_knownNPCs">a list of all unique npcs, the game master wanted to save, if null, the list is empty</param>
        [JsonConstructor]
        public PAPIGame(GenreEnum _genre, Player _gameMaster, Dictionary<Player, PlayerCharacter> _playerParty, DateTime _dateOfCreation, DateTime _dateOfLastSession,
            List<UniqueRival> _knownNPCs)
        {
            this._gameMaster = (_gameMaster == null) ? PAPIApplication._currentPlayer : _gameMaster;
            this._genre = _genre;
            this._playerParty = (_playerParty == null) ? new Dictionary<Player, PlayerCharacter>() : _playerParty;
            this._dateOfCreation = (_dateOfCreation == null) ? DateTime.Now : _dateOfCreation;
            this._dateOfLastSession = (_dateOfLastSession == null) ? DateTime.Now : _dateOfLastSession;
            this._knownNPCs = (_knownNPCs == null) ? new List<UniqueRival>() : _knownNPCs;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Game (GameMaster " + _gameMaster._name + ", Ganre " + _genre + ")");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates a default game with the current player as game master
        /// </summary>
        public PAPIGame() : this(GenreEnum.NOT_VALID, null, null, DateTime.Now, DateTime.Now, null)
        {
            WfLogger.Log(this, LogLevel.DETAILED, "Created new default Game");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates a default game with the current player as game master
        /// </summary>
        /// <param name="other"></param>
        public PAPIGame(PAPIGame other) : this()
        {
            if (other == null) return;

            _gameMaster = other._gameMaster;
            _genre = other._genre;
            _playerParty = new Dictionary<Player, PlayerCharacter>(other._playerParty);
            _dateOfCreation = other._dateOfCreation;
            _dateOfLastSession = other._dateOfLastSession;
            _knownNPCs = new List<UniqueRival>(other._knownNPCs);

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Game from another");
        }


        // --------------------------------------------------------------------------------------------------------------------------------
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

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Sets all game values to default
        /// </summary>
        public void ClearGame()
        {
            _gameMaster = null;
            _genre = GenreEnum.NOT_VALID;
            _dateOfCreation = DateTime.Now;
            _dateOfLastSession = DateTime.Now;
            _playerParty = null;
            _knownNPCs = null;

            WfLogger.Log(this, LogLevel.INFO, "Cleared all mambers of the game");
        }


    }
}
