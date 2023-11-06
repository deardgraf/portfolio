using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP_KDO
{
    class GameStats
    {
        string _player1;
        string _player2;
        string _gameScore;
        int _score1;
        int _score2;

        public GameStats() { }
        public GameStats(string player1, string player2, string gameScore, int score1, int score2)
        {
            Player1 = player1;
            Player2 = player2;
            GameScore = gameScore;
            Score1 = score1;
            Score2 = score2;
        }

        #region Properties
        public string Player1
        {
            get { return _player1; }
            set { _player1 = value; }
        }
        public string Player2
        {
            get { return _player2; }
            set { _player2 = value; }
        }
        public string GameScore
        {
            get { return _gameScore; }
            set { _gameScore = value; }
        }
        public int Score1
        {
            get { return _score1; }
            set { _score1 = value; }
        }
        public int Score2
        {
            get { return _score2; }
            set { _score2 = value; }
        }
        #endregion

        public override int GetHashCode() => ToString().GetHashCode();
        public override bool Equals(object obj) => ToString().Equals(obj);
        public override string ToString() => $"{Player1} {Player2} {GameScore} {Score1} {Score2}";
    }
}