namespace DynamicShow
{
    partial class frmFirst
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBuild = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.cmbBBB = new System.Windows.Forms.ComboBox();
            this.lblTransfer = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnBuild
            // 
            this.btnBuild.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuild.Location = new System.Drawing.Point(453, 360);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(117, 35);
            this.btnBuild.TabIndex = 0;
            this.btnBuild.Text = "Build";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Visible = false;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(641, 360);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 35);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(94, 59);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(253, 46);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome to Dynamic Form Builder.\nSelect an option from the menu";
            // 
            // cmbBBB
            // 
            this.cmbBBB.FormattingEnabled = true;
            this.cmbBBB.Location = new System.Drawing.Point(417, 59);
            this.cmbBBB.Name = "cmbBBB";
            this.cmbBBB.Size = new System.Drawing.Size(121, 24);
            this.cmbBBB.TabIndex = 3;
            this.cmbBBB.SelectedIndexChanged += new System.EventHandler(this.cmbBBB_SelectedIndexChanged);
            // 
            // lblTransfer
            // 
            this.lblTransfer.AutoSize = true;
            this.lblTransfer.Location = new System.Drawing.Point(97, 241);
            this.lblTransfer.Name = "lblTransfer";
            this.lblTransfer.Size = new System.Drawing.Size(46, 17);
            this.lblTransfer.TabIndex = 4;
            this.lblTransfer.Text = "label1";
            this.lblTransfer.Visible = false;
            // 
            // frmFirst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTransfer);
            this.Controls.Add(this.cmbBBB);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBuild);
            this.Name = "frmFirst";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ComboBox cmbBBB;
        private System.Windows.Forms.Label lblTransfer;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

