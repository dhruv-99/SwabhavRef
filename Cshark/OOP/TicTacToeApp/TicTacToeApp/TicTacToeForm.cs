using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using TicTacToeLib;

namespace TicTacToeApp
{
    class TicTacToeForm : Form
    {
        private Game game;
        private Board board;
        private Player[] players;
        private List<Button> _buttons;
        private Label statusChangeLabel;
        private Label playerTurn;

        public TicTacToeForm()
        {
            _buttons = new List<Button>();
            Initialize();

            Label player_Label1 = new Label();
            player_Label1.Text = "Player 1 : "+ players[0].Name.ToString()+"  "+players[0].MarK;
            player_Label1.Width = 150;
            player_Label1.Location = new Point(700, 15);

            Label player_Label2 = new Label();
            player_Label2.Text = "Player 2 : "+ players[1].Name + "  " + players[1].MarK; ;
            player_Label2.Width = 150;
            player_Label2.Location = new Point(700, 40);

            Label gameStatus_Label = new Label();
            gameStatus_Label.Text = "Game Status : ";
            gameStatus_Label.Width = 80;
            gameStatus_Label.Location = new Point(680, 70);

            statusChangeLabel = new Label();
            statusChangeLabel.Width = 50;
            statusChangeLabel.Text = "";
            statusChangeLabel.Location = new Point(800, 70);

            playerTurn = new Label();
            playerTurn.Text = game.PlayerName + "'s turn..";
            playerTurn.Width = 100;
            playerTurn.Location = new Point(410,270);

            Button restart_Button = new Button();
            restart_Button.Text = "Start";
            restart_Button.Width = 100;
            restart_Button.Height = 50;
            restart_Button.Location = new Point(400,200);
            restart_Button.Click += Restart_Click;

            this.Controls.Add(player_Label1);
            this.Controls.Add(player_Label2);
            this.Controls.Add(gameStatus_Label);
            this.Controls.Add(statusChangeLabel);
            this.Controls.Add(playerTurn);
            this.Controls.Add(restart_Button);

            this.Text = "TicTacToe Game";
            this.Height = 768;
            this.Width = 1024;
            this.BackColor = Color.Blue;
            AddButton();
        }

        public void Initialize()
        {
            board = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            players = new Player[2];
            players[0] = new Player("Akash", Mark.X);
            players[1] = new Player("Dhruv", Mark.O);
            game = new Game(players, board, analyzer);
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            Button start = (Button)sender;
            if (start.Text.Equals("Start"))
            {
                start.Enabled = true;
                start.Text = "Restart";
            }
            Initialize();
            int buttonText = 0;
            foreach(Button enableButton in _buttons)
            {
                enableButton.Enabled = true;
                enableButton.Text = buttonText++.ToString();
            }
            statusChangeLabel.Text = "";
            playerTurn.Text = game.PlayerName + "'s turn..";
        }

        public void AddButton()
        {
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button button = new Button();
                    button.Text = count.ToString();
                    count++;
                    button.Height = 100;
                    button.Width = 100;
                    button.BackColor = Color.AntiqueWhite;
                    button.Font = new Font(button.Font.FontFamily, 20);
                    button.Location = new Point((j + 3) * 100, (i + 3) * 100);
                    button.Click += Button_Click;
                    button.Enabled = false; 
                    _buttons.Add(button);
                    this.Controls.Add(button);
                }
            }
        }

        public void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int pos = (Convert.ToInt32(b.Text));
            game.Play(pos);
            playerTurn.Text = game.PlayerName + "'s turn..";
            b.Text = board.GetMark(pos).ToString();
            if (game.Status() == Results.WIN)
            {
                statusChangeLabel.Text = game.PlayerNameWin + " wins";
                playerTurn.Text = "";
                foreach (Button disableButton in _buttons)
                    disableButton.Enabled = false;
            }
            if (game.Status() == Results.DRAW)
            {
                statusChangeLabel.Text ="Match draw";
                playerTurn.Text = "";
                foreach (Button disableButton in _buttons)
                    disableButton.Enabled = false;
            }
            if (game.Status() == Results.PROGRESS)
                statusChangeLabel.Text = "Match in Progress";
        }
    }
}
