using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1GillGurpartap
{
    public partial class formPlay : Form
    {
        public formPlay()
        {
            InitializeComponent();
        }

        //array storing the team names
        private string[] teams;

        //array  storing the name of all the labels that display team names
        private Label[] arrayTeamLabels;

        //array  storing the name of all the labels that display team scores
        private Label[] arrayScoreLabels;

        //for creating random numbers
        private Random random = new Random();

        private void formPlay_Load(object sender, EventArgs e)
        {
            //adding teams int othe array and then into the listbox
            teams = new string[]{"Arsenal","Barcelona","Bayern","Chelsea","Juventus","Manchester",
                                "PSG","Madrid"};
            listTeams.Items.AddRange(teams);

            //disabling all the buttons on load of the form
            btnQuarter1Play1.Enabled = false;
            btnQuarter1Play2.Enabled = false;
            btnQuarter2Play1.Enabled = false;
            btnQuarter2Play2.Enabled = false;
            btnSemi1Play.Enabled = false;
            btnSemi2Play.Enabled = false;
            btnFinalPlay.Enabled = false;

            //initializing the arrayTeamLabels
            arrayTeamLabels = new Label[] { lblTeam1, lblTeam2, lblTeam3, lblTeam4, lblTeam5, lblTeam6, lblTeam7, lblTeam8, lblTeam9, lblTeam10, lblTeam11, lblTeam12, lblTeam13, lblTeam14 };

            //initializing the arrayScoreLabels
            arrayScoreLabels = new Label[] { lblScore1, lblScore2, lblScore3, lblScore4, lblScore5, lblScore6, lblScore7, lblScore8, lblScore9, lblScore10, lblScore11, lblScore12, lblScore13, lblScore14 };
        }

        private void btnDrawTeams_Click(object sender, EventArgs e)
        {
            //this method will shuffle the positions of the items in the array named teams
            ShuffleArray(teams);

            //loop for assigning the text of the teamLabels 
            for (int i = 0; i <= teams.Length - 1; i++)
            {
                arrayTeamLabels[i].Text = teams[i];
            }

            btnDrawTeams.Enabled = false;
            btnQuarter1Play1.Enabled = true;
        }

        private void btnQuarter1Play1_Click(object sender, EventArgs e)
        {
            //generating and assigning the random score to the respective labels
            AssignScore(arrayScoreLabels, 0);

            btnQuarter1Play1.Enabled = false;
            btnQuarter1Play2.Enabled = true;

            //comparision of scores and changing label properties as required
            if (Int32.Parse(lblScore1.Text) > Int32.Parse(lblScore2.Text))
            {
                lblTeam1.ForeColor = Color.Green;
                lblTeam2.ForeColor = Color.Red;
                lblTeam9.Text = lblTeam1.Text;
            }
            else
            {
                lblTeam1.ForeColor = Color.Red;
                lblTeam2.ForeColor = Color.Green;
                lblTeam9.Text = lblTeam2.Text;
            }

        }

        private void btnQuarter1Play2_Click(object sender, EventArgs e)
        {
            //generating and assigning the random score to the respective labels
            AssignScore(arrayScoreLabels, 2);

            btnQuarter1Play2.Enabled = false;
            btnQuarter2Play1.Enabled = true;

            //comparision of scores and changing label properties as required
            if (Int32.Parse(lblScore3.Text) > Int32.Parse(lblScore4.Text))
            {
                lblTeam3.ForeColor = Color.Green;
                lblTeam4.ForeColor = Color.Red;
                lblTeam10.Text = lblTeam3.Text;
            }
            else
            {
                lblTeam3.ForeColor = Color.Red;
                lblTeam4.ForeColor = Color.Green;
                lblTeam10.Text = lblTeam4.Text;
            }
        }

        private void btnQuarter2Play1_Click(object sender, EventArgs e)
        {
            //generating and assigning the random score to the respective labels
            AssignScore(arrayScoreLabels, 4);

            btnQuarter2Play1.Enabled = false;
            btnQuarter2Play2.Enabled = true;

            //comparision of scores and changing label properties as required
            if (Int32.Parse(lblScore5.Text) > Int32.Parse(lblScore6.Text))
            {
                lblTeam5.ForeColor = Color.Green;
                lblTeam6.ForeColor = Color.Red;
                lblTeam11.Text = lblTeam5.Text;
            }
            else
            {
                lblTeam5.ForeColor = Color.Red;
                lblTeam6.ForeColor = Color.Green;
                lblTeam11.Text = lblTeam6.Text;
            }
        }

        private void btnQuarter2Play2_Click(object sender, EventArgs e)
        {
            //generating and assigning the random score to the respective labels
            AssignScore(arrayScoreLabels, 6);

            btnQuarter2Play2.Enabled = false;
            btnSemi1Play.Enabled = true;

            //comparision of scores and changing label properties as required
            if (Int32.Parse(lblScore7.Text) > Int32.Parse(lblScore8.Text))
            {
                lblTeam7.ForeColor = Color.Green;
                lblTeam8.ForeColor = Color.Red;
                lblTeam12.Text = lblTeam7.Text;
            }
            else
            {
                lblTeam7.ForeColor = Color.Red;
                lblTeam8.ForeColor = Color.Green;
                lblTeam12.Text = lblTeam8.Text;
            }
        }

        private void btnSemi1Play_Click(object sender, EventArgs e)
        {
            //generating and assigning the random score to the respective labels
            AssignScore(arrayScoreLabels, 8);

            btnSemi1Play.Enabled = false;
            btnSemi2Play.Enabled = true;

            //comparision of scores and changing label properties as required
            if (Int32.Parse(lblScore9.Text) > Int32.Parse(lblScore10.Text))
            {
                lblTeam9.ForeColor = Color.Green;
                lblTeam10.ForeColor = Color.Red;
                lblTeam13.Text = lblTeam9.Text;
            }
            else
            {
                lblTeam9.ForeColor = Color.Red;
                lblTeam10.ForeColor = Color.Green;
                lblTeam13.Text = lblTeam10.Text;
            }
        }

        private void btnSemi2Play_Click(object sender, EventArgs e)
        {
            //generating and assigning the random score to the respective labels
            AssignScore(arrayScoreLabels, 10);

            btnSemi2Play.Enabled = false;
            btnFinalPlay.Enabled = true;

            //comparision of scores and changing label properties as required
            if (Int32.Parse(lblScore11.Text) > Int32.Parse(lblScore12.Text))
            {
                lblTeam11.ForeColor = Color.Green;
                lblTeam12.ForeColor = Color.Red;
                lblTeam14.Text = lblTeam11.Text;
            }
            else
            {
                lblTeam11.ForeColor = Color.Red;
                lblTeam12.ForeColor = Color.Green;
                lblTeam14.Text = lblTeam12.Text;
            }
        }

        private void btnFinalPlay_Click(object sender, EventArgs e)
        {
            //generating and assigning the random score to the respective labels
            AssignScore(arrayScoreLabels, 12);

            btnSemi2Play.Enabled = false;
            btnFinalPlay.Enabled = false;

            //comparision of scores and changing label properties as required
            if (Int32.Parse(lblScore13.Text) > Int32.Parse(lblScore14.Text))
            {
                lblTeam13.ForeColor = Color.Green;
                lblTeam14.ForeColor = Color.Red;
            }
            else
            {
                lblTeam13.ForeColor = Color.Red;
                lblTeam14.ForeColor = Color.Green;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //resetting all the group boxes to default
            Reset(grpQuarter1);
            Reset(grpQuarter2);
            Reset(grpSemi1);
            Reset(grpSemi2);
            Reset(grpFinal);

            btnDrawTeams.Enabled = true;
        }

        //Method to shuffle the indexes of an array
        private void ShuffleArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                string temp = array[i];
                int num = random.Next(i, array.Length);
                array[i] = array[num];
                array[num] = temp;
            }
        }

        //Method to generate random scores and chnage the text of the score label accordingly
        private void AssignScore(Label[] array, int index)
        {
            int num, temp;
            do
            {
                num = random.Next(0, 5);
                array[index].Text = num.ToString();
                temp = random.Next(0, 5);
                array[index + 1].Text = temp.ToString(); //[index+1] because all the score and team                                           labels work in pairs i.e. first match uses                                        label1 and label2 and so on..
            }
            while (num == temp);
        }

        //Method to check the controls present in the group boxes and change their properties to defualt
        private void Reset(GroupBox gb)
        {
            foreach (Control control in gb.Controls)
            {
                if (control is Label)
                {
                    Label label = (Label)control;
                    label.Text = " ";
                    label.ForeColor = Color.Black;
                }
                if (control is Button)
                {
                    Button btn = (Button)control;
                    btn.Enabled = false;
                }
            }
        }
    }
}
