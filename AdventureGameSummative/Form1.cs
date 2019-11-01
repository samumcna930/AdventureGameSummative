using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AdventureGameSummative
{
    public partial class Form1 : Form
    {
        bool hasRifle = false;
        bool hasFishing = false;
        bool hasKey = false;
        int key = 0;
        int scene = 1;
        int bulletChance = 35;
        int scene35Rng;
        public Form1()
        {
            InitializeComponent();
            pictureBoxB.Visible = false;
            pictureBoxM.Visible = false;
            pictureBoxN.Visible = false;
            Random randGen = new Random();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            gameTitle.Text = "";
            Thread.Sleep(800);
            playButton.Enabled = false;

            this.Focus();
            outputLabel.Text = "It is winter, there is a man eating grizzly that is lurking about in the winter wood." +
                      "You have to hunt it and kill it. However there are supplies around that may help your hunt.";
            optionLabel1.Text = "Abandoned cabin";
            optionLabel2.Text = "Along riverbed";
            optionLabel3.Text = "Head North";
            pictureBoxB.Visible = true;
            pictureBoxM.Visible = true;
            pictureBoxN.Visible = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 3; }
                else if (scene == 3) { scene = 4; hasFishing = true; }
                else if (scene == 4) { scene = 0; }
                else if (scene == 5) { scene = 0; }
                else if (scene == 35)
                {
                    if (hasKey)
                    {
                        Random randGen = new Random();
                        scene35Rng = randGen.Next(1, 11);
                        if (scene35Rng == 1) { scene = 7; }
                        else { scene = 6; }
                    }

                    else { scene = 4; }
                }

                else if (scene == 9)
                {
                    if (hasFishing) { scene = 12; }
                    else { scene = 13; }
                }

                else if (scene == 11) { scene = 9; }
                else if (scene ==  12) { scene = 0; }
              
        
                

         
            }

            else if (e.KeyCode == Keys.B)
            {
                if (scene == 1) { scene = 9; }
                else if (scene == 2) { scene = 3; }
                else if (scene == 3) { scene = 1; }
                else if (scene == 4) { scene = 5; }
                else if (scene == 5) { scene = 4; }

                else if (scene == 35) { scene = 6; }


                else if (scene == 9) { scene = 10;}
                else if (scene == 10) { scene = 11;}
                else if (scene == 11) { scene = 1; }
                else if (scene == 12) { scene = 9; }
             
            }

                else if (e.KeyCode == Keys.N)
                {
                if (scene == 1) { scene = 14; }
                }


            switch (scene)
            {
                case 0: 
                    break;
                case 1:
                    outputLabel.Text = "It is winter, there is a man eating grizzly that is lurking about in the winter wood." +
                        "You have to hunt it and kill it. However there are supplies around that may help your hunt. + " +
                        "Head North when you are ready to challenge the grizzly";
                    optionLabel1.Text = "Abandoned cabin";
                    optionLabel2.Text = "Along riverbed";
                    optionLabel3.Text = "Head North";
                    break;
                case 2:
                    outputLabel.Text = "There is no food to be found here, however you find a fishing rod.";
                    optionLabel1.Text = "Take the rod";
                    optionLabel2.Text = "Leave it";
                    break;
                case 3:
                    outputLabel.Text = "There are more things to explore in the cabin.";
                    optionLabel1.Text = "Keep searching";
                    optionLabel2.Text = "Don't search";
                    break;
                case 4:
                    outputLabel.Text = "You find 3 rifle bullets";
                    optionLabel1.Text = "Keep searching";
                    optionLabel2.Text = "Go back to hut";
                    break;
                case 5:
                    outputLabel.Text = "You find a locked chest.";
                    if (hasKey) { scene = 35; }
                    else { scene = 4; }
                    break;
                case 6:
                    outputLabel.Text = "You find a hunting rifle inside the chest";
                    hasRifle = true;
                    break;
                case 7:
                    outputLabel.Text = "The key has broken";
                    break;
                case 8:
                    outputLabel.Text = "With nothing left to find at the cabin you return to your hut";
                    break;
                case 9:
                    outputLabel.Text = "You come along to the river shore and can see many trout in swimming with the current.";
                    optionLabel1.Text = "catch the fishes";
                    optionLabel2.Text = "keep going";
                    break;
                case 10:
                    outputLabel.Text = "You come across a cold dead body of a man. It looks he was killed by the grizzly.";
                    optionLabel1.Text = "loot the body";
                    optionLabel2.Text = "Don't loot the body";
                    break;
                case 11:
                    outputLabel.Text = "You loot the dead man and find a rusty key.You also find a hunting knife.";
                    optionLabel1.Text = "go back to riverbed";
                    optionLabel2.Text = "go back to hut";
                    break;
                case 12:
                    outputLabel.Text = "You are successful in catching some trout. ";
                    optionLabel1.Text = "Go back to hut";
                    optionLabel2.Text = "Don't go back to the hut";
                    break;
                case 13:
                    outputLabel.Text = " You try to catch fish with your bare hands however the water gives you hypothermia and you freeze to death  ";
                    break;
                case 14:
                    outputLabel.Text = "You are entering the grizzly's territory";
                    optionLabel1.Text = "fight it";
                    optionLabel2.Text = "retreat";
                    break;
                case 15:
                    outputLabel.Text = "You are confident with your resources in hand that you may overcome the grizzly. ";
                    optionLabel1.Text = "beat the bear with hands";
                    optionLabel2.Text = "Snipe the bear";
                    break;
                case 16:
                    outputLabel.Text = "The grizzly is coming! ";
                    optionLabel1.Text = "Fight";
                    optionLabel2.Text = "Flight";
                    break;
                case 17:
                    outputLabel.Text = "You wait for the grizzly in cover for many hours. Finally you spot the beast.";
                    optionLabel1.Text = "Fight";
                    optionLabel2.Text = "Flight";
                    break;
                case 18:
                    outputLabel.Text = "The grizzly sees you running and catches up and murders you";
                    break;
                case 19:
                    outputLabel.Text = "The bullet pierces the grizzly and dies.";
                    break;
                case 20:
                    outputLabel.Text = "The bullet misses, and the bear charges at you";
                    optionLabel1.Text = "shoot again";
                    optionLabel2.Text = "Climb a tree";
                    break;
                case 21:
                    outputLabel.Text = "The bear is closing in on you";
                    optionLabel1.Text = "Take another shot";
                    optionLabel2.Text = "Run";
                    break;
                case 22:
                    outputLabel.Text = "You try to outrun the grizzly however it catches up to you and kills you";
                    break;
                case 23:
                    outputLabel.Text = "The bullet pierces the grizzly and it dies";
                    break;
                case 24:
                    outputLabel.Text = "You missed";
                    optionLabel1.Text = "Take another shot";
                    optionLabel2.Text = "Run";
                    break;
                case 25:
                    outputLabel.Text = "You ran out of bullets. The grizzly kills you.";
                    break;
                case 26:
                    outputLabel.Text = "The grizzly is quick to catch up and makes fast work of you.";
                    break;
                case 27:
                    outputLabel.Text = "The bullet pierces the grizzly and it dies.";
                    break;
                case 28:
                    outputLabel.Text = "You climb up a tree and the bear is close behind. ";
                    optionLabel1.Text = "Shoot";
                    optionLabel2.Text = "Throw fish";
                    optionLabel3.Text = "Climb higher";
                    break;
                case 29:
                    outputLabel.Text = "You shoot the grizzly in the face at point blank range.";
                    break;
                case 30:
                    outputLabel.Text = "Your hands slip and you fall to your death.";                   
                    break;
                case 31:
                    outputLabel.Text = "The grizzly whilst climbing the tree tries to catch the fish midair, slips and falls to it's death.";
                    break;
                case 32:
                    outputLabel.Text = "The grizzly is quick to catch up, and effortlessly eats you up.";
                    break;
                case 33:
                    outputLabel.Text = "Fighting the bear with only a hunting knife proved to be foolish because the bear killed you with one swing of it's paw.";
                    break;
                case 34:
                    outputLabel.Text = "You bear stands up, and you immediately plunge the knife into the bears eyeball, the bear falls over dead. ";
                    break;
                case 35:
                    outputLabel.Text = "The key matches the chest.";
                    optionLabel1.Text = "Use the rusty key";
                    optionLabel2.Text = "Return to hut";
                    break;
                case 96:
                    outputLabel.Text = "You have died and unsuccessfully killed the bear.";
                    break;
                case 97:
                     outputLabel.Text = "Would you like to try again?";
                     optionLabel1.Text = "Yes";
                     optionLabel2.Text = "No";
                    break;
                case 98:
                     outputLabel.Text = "You have died and unsuccessfully killed the bear.";
                    break;
                 case 99:
                     outputLabel.Text = "Would you like to try again?";
                     optionLabel1.Text = "Yes";
                     optionLabel2.Text = "No";
                    break;
                    














































                }
        }
    }
   
}
