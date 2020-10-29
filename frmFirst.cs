/*
 * Program:     DynamicShow
 * Author:      Haroon Awan
 * Code:		frmFirst.cs
 * Purpose:     This program will create a list of drop down
 *              for the user to choose from.
 *              Set the index of selected option as parameter
 *              of formBuilded.
 *              Displays a ExitCode upon exit from frmBuilded.
 
 */

using System;
using System.Windows.Forms;

namespace DynamicShow
{
    public partial class frmFirst : Form
    {
        internal static string myData;

        public frmFirst()
        {
            InitializeComponent();
            cmbBBB.Items.Add("Empty");
            cmbBBB.Items.Add("Movies");
            cmbBBB.Items.Add("Jobs");
        }

        private void cmbBBB_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnBuild.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {

            int n = cmbBBB.SelectedIndex;

            frmBuilded f2 = new frmBuilded(n);
            f2.ShowDialog();

            lblTransfer.Text = "ExitCode: " + myData;
            lblTransfer.Visible = true;
        }
    }
}

