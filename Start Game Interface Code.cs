using POE_Task;
using System.Reflection;
using System.Xml.Linq;

namespace POE_Task
{
    public partial class Form1 : Form
    {
        //DRAGON STATS

        //Ice Dragon
        const string drgnType2 = "Ice Dragon";
        const int ice_Drgn_Hp = 30;
        const int ice_Drgn_Atk = 4;
        const int ice_Drgn_SpAtk = 9;
        const int ice_Drgn_Block = 4;

        //Fire Dragon
        const string drgnType1 = "Fire Dragon";
        const int fire_Drgn_Hp = 20;
        const int fire_Drgn_Atk = 5;
        const int fire_Drgn_SpAtk = 12;
        const int fire_Drgn_Block = 5;

        //Earth Dragon
        const string drgnType3 = "Earth Dragon";
        const int earth_Drgn_Hp = 50;
        const int earth_Drgn_Atk = 2;
        const int earth_Drgn_SpAtk = 5;
        const int earth_Drgn_Block = 6;

        //Wind Dragon
        const string drgnType4 = "Wind Dragon";
        const int wind_Drgn_Hp = 40;
        const int wind_Drgn_Atk = 3;
        const int wind_Drgn_SpAtk = 7;
        const int wind_Drgn_Block = 5;

        //Player Name
        string firstPlayer;
        string secondPlayer;

        //Dragon Name
        string drgnName1;
        string drgnName2;

        //Save Data
        string playerOneDrgn;
        string playerTwoDrgn;

        //ARRAYS USED FOR LATER
        string[] P1data = new string[4];
        string[] P2data = new string[4];
        int[] P1values = new int[4];
        int[] P2values = new int[4];

        public Form1()
        {
            InitializeComponent();
        }

        public void saveValues(string firstPlayer, string drgnName1, int[] drgnStats)
        {
            if (firstPlayer == PlayerNameOne.Text)
            {
                P1data[0] = PlayerNameOne.Text;
                P1data[1] = DragonNameOne.Text;
                P1values = drgnStats;
                SaveOne.Enabled = false;
            }
            else if (secondPlayer == PlayerNameTwo.Text)
            {
                P2data[0] = PlayerNameTwo.Text;
                P2data[1] = DragonNameTwo.Text;
                P2values = drgnStats;
                SaveTwo.Enabled = false;
            }

            if (!SaveOne.Enabled && !SaveTwo.Enabled)
                StartBtn.Enabled = true;
        }
        public int[] DragonStats(string firstplayer, string secondplayer)
        {
            int[] drgnStats = new int[4];
            if (firstplayer == PlayerNameOne.Text)
            {
                if (FireDragonOne.Checked)
                {
                    drgnStats[0] = fire_Drgn_Hp;
                    drgnStats[1] = fire_Drgn_Atk;
                    drgnStats[2] = fire_Drgn_SpAtk;
                    drgnStats[3] = fire_Drgn_Block;
                }
                else if (IceDragonOne.Checked)
                {
                    drgnStats[0] = ice_Drgn_Hp;
                    drgnStats[1] = ice_Drgn_Atk;
                    drgnStats[2] = ice_Drgn_SpAtk;
                    drgnStats[3] = ice_Drgn_Block;
                }
                else if (EarthDragonOne.Checked)
                {
                    drgnStats[0] = earth_Drgn_Hp;
                    drgnStats[1] = earth_Drgn_Atk;
                    drgnStats[2] = earth_Drgn_SpAtk;
                    drgnStats[3] = earth_Drgn_Block;
                }
                else if (WindDragonOne.Checked)
                {
                    drgnStats[0] = wind_Drgn_Hp;
                    drgnStats[1] = wind_Drgn_Atk;
                    drgnStats[2] = wind_Drgn_SpAtk;
                    drgnStats[3] = wind_Drgn_Block;
                }
            }
            else if (secondplayer == PlayerNameTwo.Text)
            {
                // Same logic as above, but with different group box names
                if (FireDragonTwo.Checked)
                {
                    drgnStats[0] = fire_Drgn_Hp;
                    drgnStats[1] = fire_Drgn_Atk;
                    drgnStats[2] = fire_Drgn_SpAtk;
                    drgnStats[3] = fire_Drgn_Block;
                }
                else if (IceDragonTwo.Checked)
                {
                    drgnStats[0] = ice_Drgn_Hp;
                    drgnStats[1] = ice_Drgn_Atk;
                    drgnStats[2] = ice_Drgn_SpAtk;
                    drgnStats[3] = ice_Drgn_Block;
                }
                else if (EarthDragonTwo.Checked)
                {
                    drgnStats[0] = earth_Drgn_Hp;
                    drgnStats[1] = earth_Drgn_Atk;
                    drgnStats[2] = earth_Drgn_SpAtk;
                    drgnStats[3] = earth_Drgn_Block;
                }
                else if (WindDragonTwo.Checked)
                {
                    drgnStats[0] = wind_Drgn_Hp;
                    drgnStats[1] = wind_Drgn_Atk;
                    drgnStats[2] = wind_Drgn_SpAtk;
                    drgnStats[3] = wind_Drgn_Block;
                }
            }
            return drgnStats;
        }
            return null; //IF NO RADIOBUTTON IS SELECTED
                         
        //RANDOM NUMBER METHOD
        public int rndmRoll()
        {
            Random rnd = new Random();
            return rnd.Next(1, 7);
        }
        //THE SAVE BUTTON FOR PLAYER ONE,WHICH SAVES THEIR DATA
        private void button1_Click(object sender, EventArgs e)
        {
        string firstPlayer = PlayerNameOne.Text;
        string drgnName1 = DragonNameOne.Text;
        int[] drgnStats = DragonStats(groupBox1);
        saveValues(firstPlayer, drgnName1, drgnStats);
        }
        //TEXTBOX FOR PLAYER ONE'S NAME
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            firstPlayer = PlayerNameOne.Text;
        }

    //START GAME,WHICH OPENS THE TURN PLAYER INTERFACE AND CLOSES THE CURRENT INTERFACE
    private void button3_Click(object sender, EventArgs e)
    {
          int initiative = TakeInitiative();
          TurnPlayerInterface turnPlayerInterfaceForm = new TurnPlayerInterface(P1data, P2data, P1values, P2values, initiative);
          this.Hide();
          turnPlayerInterfaceForm.ShowDialog();
          this.Close();
    }
        private void DragonNameOne_TextChanged(object sender, EventArgs e)
    {
        drgnName1 = DragonNameOne.Text;
    }
    //TEXTBOX FOR PLAYER TWO'S NAME
    private void PlayerNameTwo_TextChanged(object sender, EventArgs e)
    {
        string secondPlayer = PlayerNameTwo.Text;
    }

    //TEXTBOX FOR DRAGON ONE'S NAME
    private void DragonName3_TextChanged(object sender, EventArgs e)
    {
        string drgnName2 = DragonNameTwo.Text;
    }
    //THE SAVE BUTTON FOR PLAYER TWO
    private void SaveTwo_Click(object sender, EventArgs e)
    {
        string secondplayer = PlayerNameTwo.Text;
        string drgnName2 = DragonNameTwo.Text;
        int[] drgnStats = DragonStats(groupBox2);
        saveValues(secondplayer, drgnName2, drgnStats);
    }
        public int RandomRoll()
        {
           Random rndm = new Random();
           return rndm.Next(1, 7); // Generates a random number between 1 and 6
        }
        private int TakeInitiative()
        {
           int firstPlayerRoll, secondPlayerRoll;
            do
            {
                firstPlayerRoll = RandomRoll();
                secondPlayerRoll = RandomRoll();
            }
            while (firstPlayerRoll == secondPlayerRoll);

            // Determine the player with the higher roll
            return Math.Max(firstPlayerRoll, secondPlayerRoll);
        }
     
    }
}
