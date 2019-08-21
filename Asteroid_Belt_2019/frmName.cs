using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Asteroid_Belt_2019
{
    public partial class frmName : Form
    {
        string playerName;

        public frmName()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            playerName = txtName.Text;

            if (Regex.IsMatch(playerName, @"^[a-zA-Z]+$"))//checks playerName for letters
            {
                //if playerName valid (only letters)
                Form1 form = new Form1(txtName.Text);
                form.Show();
                Hide();
            }
            else
            {
                //invalid playerName, clear txtName and focus on it to try again
                MessageBox.Show("Please enter a name using letters only!");
                txtName.Clear();
                txtName.Focus();
            }
        }

        private void frmName_Load(object sender, EventArgs e) //when the form loads, display instructions first
        {
            MessageBox.Show("Please enter your name first \n Use the W, A, S, D to move the spaceship. \n Use the left mouse button to fire a projectile (Press it again to reload). \n Don't get hit by the asteroids! \n Every asteroid that gets past score a point. \n If an asteroid hits the spaceship a life is lost! \n Escape the asteroid belt to view your highscore! \n \n Press Start to begin \n Try to escape the asteroid belt!", "Game Instructions");
        }
    }
}
