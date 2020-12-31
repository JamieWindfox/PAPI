using System;
using System.Collections.Generic;
using System.Text;

namespace PAPI.Settings
{
    public static class RunningGame
    {
        public static Game game { get; private set; }
        public static Player _gameMaster { get; private set; }
        
        public static void StartGame(Game newGame)
        {
            game = newGame;
        }

        public static void ClearGame()
        {
            game = null;
        }
    }
}
