using System;                       //AdventureGameSummative by Ben and Sammy 2019/11/06
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media; 

namespace AdventureGameSummative
{
    public partial class Form1 : Form
    {
        //Globals
        bool hasKnife = false;
        bool hasRifle = false;
        bool hasFishing = false;
        bool hasKey = false;
        int scene = 0;
        int scene35Rng;
        int scene17Rng;
        int scene20Rng;
        int scene21Rng;
        int scene15Rng;
        public Form1()
        {
            InitializeComponent();
            //Options are initially hidden for title screen
            pictureBoxB.Visible = false;
            pictureBoxM.Visible = false;
            pictureBoxN.Visible = false;

            letterBLabel.Text = "";
            letterMLabel.Text = "";
            letterNLabel.Text = "";

            //if (scene == 1 || scene == 15 || scene == 28) { pictureBoxN.Visible = true; letterNLabel.Text = "N"; optionLabel3.Visible = true; }
            //else { pictureBoxN.Visible = false;  letterNLabel.Text = ""; optionLabel3.Visible = false; }


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            gameTitle.Text = "";
            Thread.Sleep(800);
            playButton.Visible = false;

            this.Focus();

            outputLabel.Text = "It is winter, there is a man-eating grizzly that is lurking about in the winter wood." +
                        "You have to hunt it and kill it. There are supplies around that may help you defeat it." +
                        "Head North when you are ready to challenge the grizzly";
            optionLabel1.Text = "Abandoned cabin";
            optionLabel2.Text = "Along riverbed";
            optionLabel3.Text = "Head North";

            Thread.Sleep(1000);
            pictureBoxB.Visible = true;
            letterBLabel.Text = "B";
            Thread.Sleep(1000);
            pictureBoxM.Visible = true;
            letterMLabel.Text = "M";

            Thread.Sleep(1000);
            pictureBoxN.Visible = true;
            letterNLabel.Text = "N";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Adding in variables for sounds I will use
            SoundPlayer deathMusic = new SoundPlayer(Properties.Resources.deathmusic);
            SoundPlayer grizzlyGrowl = new SoundPlayer(Properties.Resources.grizzly);
            SoundPlayer gunShot = new SoundPlayer(Properties.Resources.gunshot);
            SoundPlayer key = new SoundPlayer(Properties.Resources.keybroke);
            SoundPlayer lootBullet = new SoundPlayer(Properties.Resources.lootbullet);
            SoundPlayer reload = new SoundPlayer(Properties.Resources.reload);
            SoundPlayer scream = new SoundPlayer(Properties.Resources.scream);
            SoundPlayer waterSplash = new SoundPlayer(Properties.Resources.watersplash);
            SoundPlayer chest = new SoundPlayer(Properties.Resources.chestopen__1_);
            SoundPlayer walk = new SoundPlayer(Properties.Resources.walking);
            SoundPlayer lootKnife = new SoundPlayer(Properties.Resources.lootknife);
            SoundPlayer punch = new SoundPlayer(Properties.Resources.punch);

            if (e.KeyCode == Keys.M)       
            {
                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 3; hasFishing = true; }
                else if (scene == 3) { scene = 4; }
                else if (scene == 4) { scene = 1; }
                else if (scene == 5)
                {
                    if (hasKey) { scene = 35; }
                    else { scene = 5; }
                }
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
                else if (scene == 10) { scene = 11; }
                else if (scene == 11) { scene = 9; }
                else if (scene == 12) { scene = 0; }
                else if (scene == 14) { scene = 15; }
                else if (scene == 15)
                {
                    if (hasRifle) { scene = 17; }
                    else outputLabel.Text = "You need to find the rifle to access this option.";
                }
                else if (scene == 17)
                {
                    Random randGen = new Random();
                    scene17Rng = randGen.Next(1, 11);
                    if (scene17Rng == 1 || scene17Rng == 2 || scene17Rng == 3)
                    { scene = 19; }
                    else { scene = 20; }
                }
                else if (scene == 20)
                {
                    Random randGen = new Random();
                    scene20Rng = randGen.Next(1, 11);
                    if (scene20Rng == 1|| scene20Rng == 2 || scene20Rng == 3 || scene20Rng == 4)
                    { scene = 27; }
                    else { scene = 21; }
                }
                else if (scene == 21)
                {
                    Random randGen = new Random();
                    scene21Rng = randGen.Next(1, 11);
                    if (scene21Rng == 1 || scene21Rng == 2 || scene21Rng == 3 || scene21Rng == 4 ||
                        scene21Rng == 5 || scene21Rng == 6) { scene = 23; }
                    else { scene = 24; }
                }
                else if (scene == 24) { scene = 25; }
                else if (scene == 28) { if (hasFishing) { pictureBoxN.Visible = true; } }
            }

            else if (e.KeyCode == Keys.B)
            {
                if (scene == 1) { scene = 9; }
                else if (scene == 2) { scene = 3; }
                else if (scene == 3) { scene = 1; }
                else if (scene == 4) { scene = 5; }
                else if (scene == 5) { scene = 1; }
                else if (scene == 35) { scene = 6; }
                else if (scene == 9) { scene = 10; }
                else if (scene == 10) { scene = 9; }
                else if (scene == 11) { scene = 1; }
                else if (scene == 12) { scene = 9; }
                else if (scene == 14) { scene = 1; }
                else if (scene == 15)
                {
                    if (hasKnife) { scene = 16; }
                    else outputLabel.Text = "You need to have the hunting knife to acess this option"; 
                }
                else if (scene == 17) { scene = 18; }
                else if (scene == 20) { scene = 28; }
                else if (scene == 28) { scene = 29; }
                else if (scene == 99) 
                {   //player hits play again and all the items reset aswell as the rng numbers
                    scene = 1;
                    bool hasKnife = false;
                    bool hasRifle = false;
                    bool hasFishing = false;
                    bool hasKey = false;
                    int scene35Rng = 0;
                    int scene17Rng = 0;
                    int scene20Rng = 0;
                    int scene21Rng = 0;
                    int scene15Rng = 0;
                }

             
            }

                else if (e.KeyCode == Keys.N)
                {
                if (scene == 1) { scene = 14; }
                else if (scene == 15)
                {
                    Random randGen = new Random();
                    scene15Rng = randGen.Next(1, 11);
                    if (scene15Rng == 1) { scene = 37; }
                    else { scene = 36; }
                }

                else if (scene == 28) { scene = 30; }
                }
            switch (scene)
            {

                case 0: 
                    break;
                case 1:
                    backgroundPicture.Image = null;
                    pictureBoxN.Visible = true; letterNLabel.Text = "N"; optionLabel3.Visible = true;
                    outputLabel.Text = "It is winter, there is a man-eating grizzly that is lurking about in the winter wood." +
                        "You have to hunt it and kill it. There are supplies around that may help you defeat it." +
                        "Head North when you are ready to challenge the grizzly";
                    optionLabel1.Text = "Abandoned cabin";
                    optionLabel2.Text = "Along riverbed";
                    optionLabel3.Text = "Head North";
                    break;
                case 2:
                    backgroundPicture.BackgroundImageLayout = ImageLayout.Zoom;
                    backgroundPicture.Image = Properties.Resources.insidecabin;
                    pictureBoxN.Visible = false; letterNLabel.Text = ""; optionLabel3.Visible = false;
                    if (hasFishing)
                    { 
                        outputLabel.Text = "You have already found a fishing rod";
                        Thread.Sleep(1200);
                        scene = 3;
                    }
                    outputLabel.Text = "You find a fishing rod.";
                    optionLabel1.Text = "Take the rod";
                    optionLabel2.Text = "Leave it";
                    break;
                case 3:
                    lootBullet.PlaySync();
                    outputLabel.Text = "There are more things to explore in the cabin.";
                    optionLabel1.Text = "Keep searching";
                    optionLabel2.Text = "Don't search";
                    break;
                case 4:
                    if (hasRifle)
                    {
                        outputLabel.Text = "You already found 3 rifle bullets";
                        optionLabel1.Text = "Keep searching";
                        optionLabel2.Text = "Go back to hut";
                    }
                    else
                    {
                        lootBullet.PlaySync();
                        outputLabel.Text = "You find 3 rifle bullets";
                        optionLabel1.Text = "Keep searching";
                        optionLabel2.Text = "Go back to hut";
                    }
                    break;
                case 5:
                    chest.PlaySync();
                    outputLabel.Text = "You find a locked chest.";
                    break;
                case 6:
                    reload.PlaySync();
                    outputLabel.Text = "You find a hunting rifle inside the chest";
                    hasRifle = true;
                    break;
                case 7:
                    key.PlaySync();
                    outputLabel.Text = "The key has broken";
                    break;
                case 8:
                    walk.PlaySync();
                    outputLabel.Text = "With nothing left to find at the cabin you return to your hut";
                    break;
                case 9:
                    backgroundPicture.BackgroundImageLayout = ImageLayout.Zoom;
                    backgroundPicture.Image = Properties.Resources.fishing;
                    pictureBoxN.Visible = false; letterNLabel.Text = ""; optionLabel3.Visible = false;
                    outputLabel.Text = "You come along to the river shore and can see many trout in swimming with the current.";
                    optionLabel1.Text = "Catch the fish";
                    optionLabel2.Text = "keep going";
                    break;
                case 10:
                    backgroundPicture.BackgroundImageLayout = ImageLayout.Zoom;
                    backgroundPicture.Image = Properties.Resources.deadbody;
                    outputLabel.Text = "You come across a cold dead body of a man. It looks he was killed by the grizzly.";
                    optionLabel1.Text = "loot the body";
                    optionLabel2.Text = "Don't loot the body";
                    break;
                case 11:
                    lootKnife.Play();
                    outputLabel.Text = "You loot the dead man and find a rusty key.You also find a hunting knife.";
                    optionLabel1.Text = "go back to riverbed";
                    optionLabel2.Text = "go back to hut";
                    break;
                case 12:
                    waterSplash.PlaySync();
                    outputLabel.Text = "You are successful in catching some trout. ";
                    optionLabel1.Text = "Go back to hut";
                    optionLabel2.Text = "Don't go back to the hut";
                    break;
                case 13:
                    backgroundPicture.BackgroundImageLayout = ImageLayout.Zoom;
                    backgroundPicture.Image = Properties.Resources.guyfreezing;
                    outputLabel.Text = " You try to catch fish with your bare hands however the water gives you hypothermia and you freeze to death";
                    Thread.Sleep(2000);
                    scene = 99;
                    break;
                case 14:
                    backgroundPicture.BackgroundImageLayout = ImageLayout.Zoom;
                    backgroundPicture.Image = Properties.Resources.grizzly1;
                    pictureBoxN.Visible = false; letterNLabel.Text = ""; optionLabel3.Visible = false;
                    outputLabel.Text = "You are entering the grizzly's territory";
                    optionLabel1.Text = "I am ready";
                    optionLabel2.Text = "I need more time";
                    break;
                case 15:
                    reload.Play();
                    outputLabel.Text = "You are confident with your resources in hand that you may overcome the grizzly. ";
                    optionLabel1.Text = "Beat the grizzly";
                    optionLabel2.Text = "Snipe the grizzly";
                    optionLabel3.Text = "Stab the grizzly";
                    break;
                case 16:
                    backgroundPicture.BackgroundImageLayout = ImageLayout.Zoom;
                    backgroundPicture.Image = Properties.Resources.bearcharge;
                    outputLabel.Text = "The grizzly is coming! ";
                    optionLabel1.Text = "Fight";
                    optionLabel2.Text = "Flight";
                    break;
                case 17:
                    grizzlyGrowl.PlaySync();
                    outputLabel.Text = "You wait for the grizzly in cover for many hours. Finally you spot the killer.";
                    optionLabel1.Text = "Fight";
                    optionLabel2.Text = "Flight";
                    break;
                case 18:
                    backgroundPicture.BackgroundImageLayout = ImageLayout.Zoom;
                    backgroundPicture.Image = Properties.Resources.bearattack;
                    outputLabel.Text = "The grizzly sees you running and catches up, and finally murders you";
                    Thread.Sleep(2000);
                    scene = 99;
                    break;
                case 19:
                    gunShot.Play();
                    grizzlyGrowl.PlaySync();
                    outputLabel.Text = "The bullet pierces the grizzly and dies.";
                    Thread.Sleep(2000);
                    scene = 98;
                    break;
                case 20:
                    gunShot.Play();
                    reload.PlaySync();
                    backgroundPicture.BackgroundImageLayout = ImageLayout.Zoom;
                    backgroundPicture.Image = Properties.Resources.bearcharge;
                    outputLabel.Text = "The bullet misses, and the bear charges at you";
                    optionLabel1.Text = "shoot again";
                    optionLabel2.Text = "Climb a tree";
                    break;
                case 21:
                    gunShot.Play();
                    reload.PlaySync();
                    backgroundPicture.BackgroundImageLayout = ImageLayout.Zoom;
                    backgroundPicture.Image = Properties.Resources.bearcharge;
                    outputLabel.Text = "The grizzly is closing in on you";
                    optionLabel1.Text = "Take another shot";
                    optionLabel2.Text = "Run";
                    break;
                case 22:
                    grizzlyGrowl.Play();
                    scream.PlaySync();
                    backgroundPicture.BackgroundImageLayout = ImageLayout.Zoom;
                    backgroundPicture.Image = Properties.Resources.bearattack;
                    outputLabel.Text = "You try to outrun the grizzly however it catches up to you and kills you";
                    Thread.Sleep(2000);
                    scene = 99;
                    break;
                case 23:
                    gunShot.PlaySync();
                    outputLabel.Text = "The bullet pierces the grizzly and it dies";
                    Thread.Sleep(2000);
                    scene = 98;
                    break;
                case 24:
                    gunShot.Play();
                    backgroundPicture.BackgroundImageLayout = ImageLayout.Zoom;
                    backgroundPicture.Image = Properties.Resources.bearcharge;
                    outputLabel.Text = "You missed";
                    optionLabel1.Text = "Take another shot";
                    optionLabel2.Text = "Run";
                    break;
                case 25:
                    grizzlyGrowl.Play();
                    scream.PlaySync();
                    backgroundPicture.BackgroundImageLayout = ImageLayout.Zoom;
                    backgroundPicture.Image = Properties.Resources.bearattack;
                    outputLabel.Text = "You ran out of bullets. The grizzly kills you.";
                    Thread.Sleep(2000);
                    scene = 99;
                    break;
                case 26:
                    grizzlyGrowl.Play();
                    scream.PlaySync();
                    backgroundPicture.Image = Properties.Resources.bearattack;
                    outputLabel.Text = "The grizzly is quick to catch up and makes fast work of you.";
                    Thread.Sleep(2000);
                    scene = 99;
                    break;
                case 27:
                    outputLabel.Text = "The bullet pierces the grizzly and it dies.";
                    Thread.Sleep(2000);
                    scene = 98;
                    break;
                case 28:
                    outputLabel.Text = "You climb up a tree and the bear is close behind. ";
                    optionLabel1.Text = "Shoot";
                    optionLabel2.Text = "Throw fish";
                    optionLabel3.Text = "Climb higher";
                    break;
                case 29:
                    outputLabel.Text = "You shoot the grizzly in the face at point blank range.";
                    Thread.Sleep(2000);
                    scene = 98;
                    break;
                case 30:
                    scream.PlaySync();
                    outputLabel.Text = "Your hands slip and you fall to your death.";
                    Thread.Sleep(2000);
                    scene = 99;
                    break;
                case 31:
                    grizzlyGrowl.PlaySync();
                    outputLabel.Text = "The grizzly whilst climbing the tree tries to catch the fish midair, slips and falls to it's death.";
                    Thread.Sleep(2000);
                    scene = 98;
                    break;
                case 32:
                    grizzlyGrowl.Play();
                    scream.PlaySync();
                    backgroundPicture.BackgroundImageLayout = ImageLayout.Zoom;
                    backgroundPicture.Image = Properties.Resources.bearattack;
                    outputLabel.Text = "The grizzly is quick to catch up, and effortlessly eats you up.";
                    break;
                case 33:
                    grizzlyGrowl.Play();
                    scream.PlaySync();
                    backgroundPicture.BackgroundImageLayout = ImageLayout.Zoom;
                    backgroundPicture.Image = Properties.Resources.bearattack;
                    outputLabel.Text = "Fighting the bear with only a hunting knife proved to be foolish because the bear killed you with one swing of it's paw.";
                    Thread.Sleep(2000);
                    scene = 99;
                    break;
                case 34:
                    grizzlyGrowl.Play();
                    outputLabel.Text = "The grizzly stands up, and you immediately plunge the knife into the grizzly's eyeball, the grizzly falls over dead.";
                    Thread.Sleep(2000);
                    scene = 98;
                    break;
                case 35:
                    backgroundPicture.Image = Properties.Resources.insidecabin;
                    outputLabel.Text = "The key matches the chest.";
                    optionLabel1.Text = "Use the rusty key";
                    optionLabel2.Text = "Return to hut";
                    break;
                case 36:
                    grizzlyGrowl.Play();
                    scream.PlaySync();
                    backgroundPicture.Image = Properties.Resources.bearattack;
                    outputLabel.Text = "Your speed was no match for the grizzly, his sharp claws ripped you open and you died";
                    Thread.Sleep(2000);
                    scene = 99;
                    break;
                case 37:
                    punch.Play();
                    grizzlyGrowl.PlaySync();
                    outputLabel.Text = "You summoned your inner Bruce Lee, and beat the life out of the grizzly";
                    Thread.Sleep(2000);
                    scene = 98;
                    break;
                case 98:
                    backgroundPicture.Image = Properties.Resources.victory;
                    outputLabel.Text = "You have survived and successfully killed the grizzly. Congradulations!";
                    optionLabel1.Text = "";
                    optionLabel2.Text = "";
                    optionLabel3.Text = "";
                    Thread.Sleep(1000);
                    outputLabel.Text = "Would you like to try again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;
                case 99:
                    backgroundPicture.Image = Properties.Resources.death;
                    deathMusic.Play();
                    outputLabel.Text = "You did not survive and failed to kill the grizzly.";
                    optionLabel1.Text = "";
                    optionLabel2.Text = "";
                    optionLabel3.Text = "";
                    Thread.Sleep(1000);
                    outputLabel.Text = "Would you like to try again?";
                     optionLabel1.Text = "Yes";
                     optionLabel2.Text = "No";
                    break;
                   
                }
        }

    }
   
}
