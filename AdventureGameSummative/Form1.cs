using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureGameSummative
{
    public partial class Form1 : Form
    {
        int arrowChance = 10;
        int freezeChance = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            playButton.Text = "";
        }
    }
}
