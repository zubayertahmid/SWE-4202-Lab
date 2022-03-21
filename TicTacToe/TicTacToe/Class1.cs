using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Board

    {
        public Player player1 = new Player();
        public Player player2 = new Player();

        public int[,] position = new int[3,3];

        public Board(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    position[i, j] = 0;
                }
            }
        }

        public Board()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    position[i, j] = 0;
                }
            }
        }

        public void reset()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    position[i, j] = 0;
                }
            }
        }

        public void setPlayers(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        public bool makeMove(int i, int j, bool player)
        {
            if (player)
            {
                if(position[i, j] == 0)
                {
                    position[i, j] = 1;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if(position[i, j] == 0)
                {
                    position[i, j] = 1;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public bool isDraw()
        {
            for(int i = 0;i < 3; i++)
            {
                for(int j = 0;j < 3; j++)
                {
                    if(position[(i,j)] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool checkWinCondition()
        {
            for(int i = 0; i < 3; i++)
            {
                if(position[i,0]==position[i,1] && position[i,1]==position[i,2] && position[i, 0] != 0)
                {
                    if (position[i, 0] == 1)
                    {
                        return this.player1.isWinner = true;
                    }
                    else
                    {
                        return this.player1.isWinner = true;
                    }
                    return true;
                }
                
            }
        }
    }


    public class Player
    {
        public int score;
        public bool isWinner;

        public Player()
        {
            this.score = 0;
        }
    }
}
