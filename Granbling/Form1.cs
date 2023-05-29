using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Granbling
{
    public partial class Form1 : Form
    {
        // grandma basics/shared values
        int[] granCoords = {0, 0}; // we BALL. [Todo: The entire movement code] [sidenote, got alot of help with learning these from https://www.w3schools.com/cs/cs_arrays.php]
        int granCash = 1000; //  starting sum of cash given to Grandma. Deplets over time, and through the usage of slots/blackjack. [Todo: gain access to the trello board so i can see the right amount]
        int energy = 50; // unused right now, will be used for the amount of actions Grandma can do each day. [TODO: movement code]
        bool canGrandmaMove = false; // unused, will be for grandma movement

        // slot variables 

        // blackjack variables, all of these have a default value just for sake of squashing potential bugs before they show up (foreshadowing)
        // also, some of the const ints aren't there (bj is heavily based off of the demo code) because its just easier for me to type out "9" or "21" then "blablabla" and i don't really see a point asides from "look at me!" energy.
        int[] bjPlayerCards = { 0, 0, 0, 0, 0 };
        int[] bjDealerCards = { 0, 0, 0 };
        int bjPlayerTotal = 0;
        int bjPlayerDrawCount = 0;
        bool bjGameInProgress = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSlots_Click(object sender, EventArgs e) // Most of this code is just taken from the slot machine test...thing....smth? either way, it's used here.
        {
            canGrandmaMove = false;
        }

        private void btnBlackjack_Click(object sender, EventArgs e) // heavily uses code/layout of the demo! Will be fixed/improved!
        {
            pnlBlackjack.Visible = true;
            canGrandmaMove = false;
        }

        private void btnBJ_Hit_Click(object sender, EventArgs e)
        {

            //gives a random card between 1 and 9.
            Random rand = new Random();
            if (bjPlayerCards[0] == 0)
            { //draws 2 random cards, displays them, and sets the draw count to 0.
                bjGameInProgress = true;
                bjPlayerCards[0] = rand.Next(1, 9);
                bjPlayerCards[1] = rand.Next(1, 9);
                lblBJ_PlayerCards.Text = "Your cards:" + bjPlayerCards[0] + ", " + bjPlayerCards[1] + ".";
                bjPlayerDrawCount = 0;
                bjPlayerTotal = bjPlayerCards[0] + bjPlayerCards[1];
            }
            else if (bjPlayerCards[2] == 0 && bjPlayerTotal <= 20) // i dont even know whats goin on i can NOT help you. all you need to know is this is just blackjack going on.
            {
                bjPlayerCards[2] = rand.Next(1, 9);
                bjPlayerDrawCount = 1; // theres no reason why it'd need to be += because in any circumstance it should be 1.
                bjPlayerTotal = bjPlayerCards[0] + bjPlayerCards[1] + bjPlayerCards[2];
                if (bjPlayerTotal == 21)
                {
                    lblBJ_PlayerCards.Text = "You won! Your cards were: " + bjPlayerCards[0] + ", " + bjPlayerCards[1] + ", and " + bjPlayerCards[2] + ". totalling up to 21!";
                    bjGameInProgress = false;
                }
                else if (bjPlayerTotal > 21)
                {
                    lblBJ_PlayerCards.Text = "Bust! Your cards were: " + bjPlayerCards[0] + ", " + bjPlayerCards[1] + ", and " + bjPlayerCards[2] + ", Good luck next time!";
                    bjGameInProgress = false;
                }
                else
                {
                    lblBJ_PlayerCards.Text = "Your cards:" + bjPlayerCards[0] + ", " + bjPlayerCards[1] + ", " + bjPlayerCards[2] + ".";
                }

            }
            else if (bjPlayerCards[3] == 0 && bjPlayerTotal <= 20)
            { // copied the previous lol...
                bjPlayerCards[3] = rand.Next(1, 9);
                bjPlayerDrawCount = 2;
                bjPlayerTotal = bjPlayerCards[0] + bjPlayerCards[1] + bjPlayerCards[2] + bjPlayerCards[3];
                if (bjPlayerTotal == 21)
                {
                    lblBJ_PlayerCards.Text = "You won! Your cards were: " + bjPlayerCards[0] + ", " + bjPlayerCards[1] + ", " + bjPlayerCards[2] + ", and " + bjPlayerCards[3] + ". totalling up to 21!";
                    bjGameInProgress = false;
                }
                else if (bjPlayerTotal > 21)
                {
                    lblBJ_PlayerCards.Text = "Bust! Your cards were: " + bjPlayerCards[0] + ", " + bjPlayerCards[1] + ", " + bjPlayerCards[2] + ", and " + bjPlayerCards[3] + ", Good luck next time!";
                    bjGameInProgress = false;
                }
                else
                {
                    lblBJ_PlayerCards.Text = "Your cards:" + bjPlayerCards[0] + ", " + bjPlayerCards[1] + ", " + bjPlayerCards[2] + ", " + bjPlayerCards[3] + ".";
                }

            }
            else if (bjPlayerCards[4] == 0 && bjPlayerTotal <= 20)
            {
                bjPlayerCards[4] = rand.Next(1, 9);
                bjPlayerDrawCount = 3;
                bjPlayerTotal = bjPlayerCards[0] + bjPlayerCards[1] + bjPlayerCards[2] + bjPlayerCards[3] + bjPlayerCards[4];
                if (bjPlayerTotal == 21)
                {
                    lblBJ_PlayerCards.Text = "You won! Your cards were: " + bjPlayerCards[0] + ", " + bjPlayerCards[1] + ", " + bjPlayerCards[2] + ", " + bjPlayerCards[3] + ", and " + bjPlayerCards[4] + ", totalling up to 21!";
                }
                else if (bjPlayerTotal > 21)
                {
                    lblBJ_PlayerCards.Text = "Bust! Your cards were: " + bjPlayerCards[0] + ", " + bjPlayerCards[1] + ", " + bjPlayerCards[2] + ", " + bjPlayerCards[3] + ", and " + bjPlayerCards[4] + ", Good luck next time!";
                }
                else
                {
                    lblBJ_PlayerCards.Text = "Your cards:" + bjPlayerCards[0] + ", " + bjPlayerCards[1] + ", " + bjPlayerCards[2] + ", " + bjPlayerCards[3] + ", " + bjPlayerCards[4] + ".";
                }
                btnBJ_Hit.Enabled = false;
            }
            else
            {
                btnBJ_Hit.Enabled = false;
            }
        }

        private void btnBJ_Stay_Click(object sender, EventArgs e)
        {

        }
    }
}
