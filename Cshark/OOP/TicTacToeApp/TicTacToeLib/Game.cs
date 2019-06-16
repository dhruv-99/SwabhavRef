using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToeLib
{
   public class Game
    {
        private Player[] _player;
        private Board _board;
        private ResultAnalyzer _analyzer;
        private int _switching;
        private Results _status;
        public Game(Player[] player, Board board, ResultAnalyzer analyzer)
        {
            _player = player;
            _board = board;
            _analyzer = analyzer;
        }
        public Results Status()
        {
            return _status;
                    
        }
        public void Play(int choice)
        {
            if (_switching == 0)
            {
                _board.SetPosition(choice, _player[_switching].MarK);
                _switching = 1;
                _status = _analyzer.GetResult();
                return;
            }
            _board.SetPosition(choice,_player[_switching].MarK);
            _switching = 0;
            _status = _analyzer.GetResult();
        }
    }
}
