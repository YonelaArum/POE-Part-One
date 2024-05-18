namespace The_Turn_Player_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            // THIS CHECKS WHETHER THE PLAYERS BLOCK
            bool firstPlayerBlock = false;
            bool secondPlayerBlock = false;

            // BLOCK
            private void Block()
        {   //FROM PLAYER 1'S VIEW
            if (currentPlayer == firstplayer)
                {
                    player1Blocking = true;
                }
            //FROM PLAYER 2'S VIEW
            else if (currentPlayer == secondplayer)
                {
                    player2Blocking = true;
                }
            }

            // ATTACK
            private void Atk()
            {   //FROM PLAYER 1'S VIEW
                if (currentPlayer == firstPlayer)
                {
                    if (!opponentBlock)
                    {
                    //IF PLAYER 1 PRESSED ATTACK
                    Console.WriteLine(firstPlayer + " has dealt damage");
                }
                    else
                    {
                    //IF PLAYER 2 BLOCKS THE ATTACK
                    Console.WriteLine(secondPlayer + " blocked so no damage was done");
                }
                }
                //FROM PLAYER 2'S VIEW
                else if (currentPlayer == secondPlayer)
                {
                    if (!player1Block)
                    {
                    //IF PLAYER 2 PRESSED ATTACK
                    Console.WriteLine(secondPlayer + " has dealt damage");
                }
                    else
                    {
                    //IF PLAYER 1 BLOCKS THE ATTACK
                    Console.WriteLine(firstPlayer + " blocked so no damage was done");
                }
                }
                // SWITCHES TO OTHER PLAYER
                SwitchTrn();
            }

            // SPECIAL ATTACK
            private void SpAttack()
            {   //FROM PLAYER 1'S VIEW
            if (currentPlayer == firstPlayer)
                {
                    if (!secondPlayerBlock)
                    {
                    //IF PLAYER 1 PRESSED SPECIAL ATTACK
                    Console.WriteLine( firstplayer + " has dealt massive damage!"),
                    }
                    else
                    {
                    //IF PLAYER 2 BLOCKS THE ATTACK
                    Console.WriteLine(secondPlayer + " blocked,no damage was done");
                    }
                }
                else if (currentPlayer == secondPlayer)
            {//FROM PLAYER 2'S VIEW
                if (!firstPlayerBlock)
                    {
                    //IF PLAYER 2 PRESSED SPECIAL ATTACK
                    Console.WriteLine(secondplayer + " has dealt massive damage!"),
                    }
                    else
                    {
                    //IF PLAYER 1 BLOCKS THE ATTACK
                    Console.WriteLine(firstPlayer + " blocked,no damage was done");
                }
                }
                //SWITCHES TO THE NEXT PLAYER
                SwitchTrn();
            }

            // THIS METHOD SWICTHES BETWEEN BOTH PLAYERS
            private void SwitchTrn()
            {
                currentPlayer = (currentPlayer == firstplayer) ? 2 : 1;
            }
        }
    }
}
