using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_Velha
{
    public class ConfigurationFeatures
    {
        public static string player1Name { private set; get; }

        public static string player2Name { private set; get; }

        public static string pl2directory { private set; get; }
        public static string pl1directory { private set; get; }

        public static bool setPlayer1Name(string name) {
            if (name != "" && name.Length <= 8) {
                player1Name = name;
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool setPlayer2Name(string name) {
            if (name != "" && name.Length <= 8)
            {
                player2Name = name;
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool setPlayer2Directory(string directory) {
            if (directory != "" && directory.Contains(":")) {
                pl2directory = directory;
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool setPlayer1Directory(string directory)
        {
            if (directory != "" && directory.Contains(":"))
            {
                pl1directory = directory;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
