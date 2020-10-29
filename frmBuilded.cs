/*
 * Program:     DynamicShow
 * Author:      Haroon Awan
 * Code:        frmBuilded.cs
 * 
 * Purpose:     This program receives selection from first form.
 *              Builds dynamically depending upon the selection.
 *              Sets a Code to myData string upon exit in frmFirst.
 
 */

 using System;
using System.Windows.Forms;

namespace DynamicShow
{
    public partial class frmBuilded : Form
    {
        int selection;

        //declare fields to be used for dynamic creation of each selection
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblErr;
        private System.Windows.Forms.TextBox textData;
        private System.Windows.Forms.Button btnDone;

        private System.Windows.Forms.GroupBox grpBox; //for Jobs
        private System.Windows.Forms.ListBox lbM;    //for Movies

        public frmBuilded(int n)
        {
            this.selection = n;
            InitializeComponent();

            switch (selection)
            {
                case 1:
                    {   // build Movies
                        lblShowOption.Text = "Movies Selected";

                        //create Controls
                        this.lbM = new System.Windows.Forms.ListBox();
                        this.lblErr = new System.Windows.Forms.Label();
                        this.btnDone = new System.Windows.Forms.Button();
                        this.SuspendLayout();
                        this.ResumeLayout(false);

                        //set controls' properties
                        lbM.Items.Add("Shawshank Redemption");
                        lbM.Items.Add("The Godfather");
                        lbM.Items.Add("Inception");
                        lbM.Items.Add("The Dark Knight");
                        lbM.Items.Add("Lord of the Rings");
                        lbM.Width = 200;
                        lbM.Location = new System.Drawing.Point(50, 25);
                        btnDone.Location = new System.Drawing.Point(270, 100);
                        btnDone.Text = "Done";
                        lblErr.Location = new System.Drawing.Point(20, 120);
                        lblErr.Visible = false;

                        //add controls to the form
                        this.Controls.Add(this.lbM);
                        this.Controls.Add(this.btnDone);
                        this.Controls.Add(this.lblErr);

                        //create an event
                        btnDone.Click += new EventHandler(btnDone_Movies);

                        break;
                    }

                case 2:
                    {   // build Jobs
                        lblShowOption.Text = "Jobs Selected";

                        this.lbl1 = new System.Windows.Forms.Label();
                        this.lblErr = new System.Windows.Forms.Label();
                        this.textData = new System.Windows.Forms.TextBox();
                        this.btnDone = new System.Windows.Forms.Button();
                        this.grpBox = new System.Windows.Forms.GroupBox();

                        this.SuspendLayout();
                        this.ResumeLayout(false);
                        lbl1.Text = "Enter the number of jobs";
                        textData.Name = "textData";
                        textData.Width = 200;
                        textData.Height = 200;
                        textData.Location = new System.Drawing.Point(50, 50);

                        textData.Visible = true;
                        lbl1.Location = new System.Drawing.Point(50, 25);
                        lbl1.Width = 150;
                        btnDone.Text = "Create";
                        btnDone.Visible = true;
                        btnDone.Location = new System.Drawing.Point(170, 80);
                        lblErr.Location = new System.Drawing.Point(50, 110);
                        lblErr.Width = 250;
                        lblErr.Visible = false;

                        grpBox.Text = "Jobs";
                        grpBox.Location = new System.Drawing.Point(300, 20);
                        grpBox.Height = 230;
                        
                        this.Controls.Add(this.lbl1);
                        this.Controls.Add(this.lblErr);
                        this.Controls.Add(this.textData);
                        this.Controls.Add(this.btnDone);
                        this.Controls.Add(this.grpBox);
                        btnDone.Click += new EventHandler(creaNewGroup);

                        break;

                    }

                default:
                    {   // build Empty
                        lblShowOption.Text = "Empty Selected";

                        this.lbl1 = new System.Windows.Forms.Label();
                        this.lblErr = new System.Windows.Forms.Label();
                        this.textData = new System.Windows.Forms.TextBox();
                        this.btnDone = new System.Windows.Forms.Button();

                        this.SuspendLayout();
                        this.ResumeLayout(false);
                        lbl1.Text = "Enter your data:";
                        textData.Name = "textData";
                        textData.Width = 200;
                        textData.Height = 200;
                        textData.Location = new System.Drawing.Point(50, 50);
                        textData.Visible = true;
                        lbl1.Location = new System.Drawing.Point(50, 25);
                        btnDone.Text = "Done";
                        btnDone.Visible = true;
                        btnDone.Location = new System.Drawing.Point(170, 80);
                        lblErr.Location = new System.Drawing.Point(50, 100);
                        lblErr.Text = "Enter data first";
                        lblErr.Visible = false;

                        this.Controls.Add(this.lbl1);
                        this.Controls.Add(this.lblErr);
                        this.Controls.Add(this.textData);
                        this.Controls.Add(this.btnDone);
                        btnDone.Click += new EventHandler(btnDone_Empty);

                        break;
                    }
            }
        }

        void creaNewGroup(object sender, EventArgs e)
        {
            int n;
            string s = textData.Text;
            bool b = int.TryParse(s, out n);

            if (n < 1 || n > 10)
            {
                lblErr.Text = "Make sure it is a number between 1 and 10";
                lblErr.Visible = true;
                lblErr.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblErr.Visible = false;
                creaNewRadio(n);
                frmFirst.myData = "30" + (n-1).ToString();
            }

        }

        //Create Radio Button using parameter and add them to grpBox
        void creaNewRadio(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                RadioButton Radio = new RadioButton();
                Radio.Text = "JOB # " + i + " - for this user";
                Radio.Width = 180;
                Radio.Location = new System.Drawing.Point(5, 20 * i);
                grpBox.Controls.Add(Radio);
            }
        }

        //Closes the form and returns the selectedindex to frmFirst for exitCode display
        void btnDone_Movies(object sender, EventArgs e)
        {
            if (lbM.SelectedIndex < 0)
            {
                lblErr.Text = "Make a Selection first";
                lblErr.ForeColor = System.Drawing.Color.Red;
                lblErr.Visible = true;
            }

            else
            {
                frmFirst.myData = "20" + lbM.SelectedIndex.ToString();
                this.Close();
            }
        }

        //Empty form btnDone click event method
        void btnDone_Empty(object sender, EventArgs e)
        {
            Button btnDone = sender as Button;
            if (textData.Text == "")
            {
                lblErr.ForeColor = System.Drawing.Color.Red;
                lblErr.Visible = true;
            }
            else
            {
                this.Close();
                frmFirst.myData = "100";
            }
        }

        //close the form
        void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
