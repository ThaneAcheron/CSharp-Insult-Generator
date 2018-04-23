using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace CTIExerciseOne
{

    public partial class Form1 : Form
    {
        //Collections: 
         //Each Arraylist is used for thier respective combobox 
        ArrayList Targets = new ArrayList();
        ArrayList PunchLines = new ArrayList();
        ArrayList Insults = new ArrayList();
 
        #region Initialize 

        public Form1()
        {
            InitializeComponent();
        }
        #endregion 

        #region Insult Selection

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialize Arraylists 


            //Store values in the Defualt values in the arraylist 
            ArrayLists set = new ArrayLists(Targets, Insults ,PunchLines, cbTarget , cbInsult , cbPunchLine);

            //Set the combobox values, ArrayLists(Arraylist,Combobox) 
            ArrayLists target = new ArrayLists(Targets, cbTarget);
            ArrayLists Punch = new ArrayLists(PunchLines, cbPunchLine);
            ArrayLists insult = new ArrayLists(Insults, cbInsult); 

            //Menu defaults 
            lblMain.Text = "";
            rdbHeadDumb.Checked = true;
            rdbUpperDumb.Checked = true;
            rdbLowerDumb.Checked = true; 
        }

        private void btnInsult_Click(object sender, EventArgs e)
        {
            string Target = cbTarget.Text;
            string Insult = cbInsult.Text;
            string PunchLine = cbPunchLine.Text;

            if (PunchLine == "" | Target == "" | Insult == "")
            {
                MessageBox.Show("Please make sure that a selection has been made for Target, Punch Line and Insult");
            }
            else
            {
                lblMain.Text = String.Join(Insult + ", ", Target + "is " , PunchLine + "." );
            }
            
        }
        #endregion 
        #region Insult Editor 

        private void btnNewTargetAdd_Click(object sender, EventArgs e)
        {
            string Newtext = txtbNewTarget.Text + " ";

            if (txtbNewTarget.Text == "")
            {
                MessageBox.Show("You can't add nothing!");
            }
            else
            { 
                if (Targets.Contains(Newtext))
                {
                    MessageBox.Show("That target already exists!");
                } 
                else 
                {
                    Targets.Add(Newtext);
                    cbTarget.Items.Add(Newtext);
                    txtbNewTarget.Text = "";
                }
            }

        }

        private void btnNewInsultAdd_Click(object sender, EventArgs e)
        {
            string Newtext = txtbNewInsult.Text + " ";

            if (txtbNewInsult.Text == "")
            {
                MessageBox.Show("You can't add nothing!");
            }
            else
            {
                if (Insults.Contains(Newtext))
                {
                    MessageBox.Show("That insult already exists!");
                }
                else
                {
                    Insults.Add(Newtext);
                    cbInsult.Items.Add(Newtext);
                    txtbNewInsult.Text = "";
                }
            }
        }

        private void btnNewPunchLineAdd_Click(object sender, EventArgs e)
        {
            string Newtext = txtbNewPunchLine.Text + " ";

            if (txtbNewPunchLine.Text == "")
            {
                MessageBox.Show("You can't add nothing!");
            }
            else
            {
                if (PunchLines.Contains(Newtext))
                {
                    MessageBox.Show("That PunchLine already exists!");
                }
                else
                {
                    PunchLines.Add(Newtext);
                    cbPunchLine.Items.Add(Newtext);
                    txtbNewPunchLine.Text = "";
                }
            }
        }
        #endregion 
        #region Picture Editor 
        private void rdbHeadFat_CheckedChanged(object sender, EventArgs e)
        {
            pbHead.Image = Image.FromFile("C:/Users/Craig/documents/visual studio 2010/Projects/CTIExerciseOne/CTIExerciseOne/Resources/fatHead.jpg");
        }

        private void rdbHeadDumb_CheckedChanged(object sender, EventArgs e)
        {
            pbHead.Image = Image.FromFile("C:/Users/Craig/documents/visual studio 2010/Projects/CTIExerciseOne/CTIExerciseOne/Resources/dumbHead.jpg");
        }

        private void rdbHeadUgly_CheckedChanged(object sender, EventArgs e)
        {
            pbHead.Image = Image.FromFile("C:/Users/Craig/documents/visual studio 2010/Projects/CTIExerciseOne/CTIExerciseOne/Resources/uglyHead.jpg");
        }

        private void rdbUpperDumb_CheckedChanged(object sender, EventArgs e)
        {
            pbUpper.Image = Image.FromFile("C:/Users/Craig/documents/visual studio 2010/Projects/CTIExerciseOne/CTIExerciseOne/Resources/dumbUpper.jpg"); 
        }

        private void rdbUpperFat_CheckedChanged(object sender, EventArgs e)
        {
            pbUpper.Image = Image.FromFile("C:/Users/Craig/documents/visual studio 2010/Projects/CTIExerciseOne/CTIExerciseOne/Resources/fatUpper.jpg"); 
        }

        private void rdbUpperUgly_CheckedChanged(object sender, EventArgs e)
        {
            pbUpper.Image = Image.FromFile("C:/Users/Craig/documents/visual studio 2010/Projects/CTIExerciseOne/CTIExerciseOne/Resources/uglyUpper.jpg");
        }

        private void rdbLowerDumb_CheckedChanged(object sender, EventArgs e)
        {
            pbLower.Image = Image.FromFile("C:/Users/Craig/documents/visual studio 2010/Projects/CTIExerciseOne/CTIExerciseOne/Resources/dumbLower.jpg"); 
        }

        private void rdbLowerFat_CheckedChanged(object sender, EventArgs e)
        {
            pbLower.Image = Image.FromFile("C:/Users/Craig/documents/visual studio 2010/Projects/CTIExerciseOne/CTIExerciseOne/Resources/fatLower.jpg");
        }

        private void rdbLowerUgly_CheckedChanged(object sender, EventArgs e)
        {
            pbLower.Image = Image.FromFile("C:/Users/Craig/documents/visual studio 2010/Projects/CTIExerciseOne/CTIExerciseOne/Resources/uglyLower.jpg");
        }
#endregion 

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Author: CraigTurner" + " Date: 2014/10/31" , "Info");
        }

    }
}
