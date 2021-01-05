namespace WindowsFormsApplication8
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEnteringRoom = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnClosingTime = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblpatientname = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblNextPatient = new System.Windows.Forms.Label();
            this.lblInRoom = new System.Windows.Forms.Label();
            this.patientnametxt = new System.Windows.Forms.TextBox();
            this.nextpatienttxt = new System.Windows.Forms.TextBox();
            this.inroomtxt = new System.Windows.Forms.TextBox();
            this.btnEarnings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAdd.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(12, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(158, 71);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Patient";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEnteringRoom
            // 
            this.btnEnteringRoom.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEnteringRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnteringRoom.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.btnEnteringRoom.Location = new System.Drawing.Point(12, 85);
            this.btnEnteringRoom.Name = "btnEnteringRoom";
            this.btnEnteringRoom.Size = new System.Drawing.Size(158, 73);
            this.btnEnteringRoom.TabIndex = 1;
            this.btnEnteringRoom.Text = "Entering Room";
            this.btnEnteringRoom.UseVisualStyleBackColor = false;
            this.btnEnteringRoom.Click += new System.EventHandler(this.btnEnteringRoom_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAll.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.btnShowAll.Location = new System.Drawing.Point(12, 164);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(160, 72);
            this.btnShowAll.TabIndex = 2;
            this.btnShowAll.Text = "ShowAll Patient";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnClosingTime
            // 
            this.btnClosingTime.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClosingTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosingTime.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.btnClosingTime.Location = new System.Drawing.Point(12, 315);
            this.btnClosingTime.Name = "btnClosingTime";
            this.btnClosingTime.Size = new System.Drawing.Size(160, 70);
            this.btnClosingTime.TabIndex = 3;
            this.btnClosingTime.Text = "Closing Time";
            this.btnClosingTime.UseVisualStyleBackColor = false;
            this.btnClosingTime.Click += new System.EventHandler(this.btnClosingTime_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.btnExit.Location = new System.Drawing.Point(12, 391);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(158, 67);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblpatientname
            // 
            this.lblpatientname.AutoSize = true;
            this.lblpatientname.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpatientname.Location = new System.Drawing.Point(235, 85);
            this.lblpatientname.Name = "lblpatientname";
            this.lblpatientname.Size = new System.Drawing.Size(149, 24);
            this.lblpatientname.TabIndex = 5;
            this.lblpatientname.Text = "Patient Name";
            this.lblpatientname.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(505, 152);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(121, 60);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblNextPatient
            // 
            this.lblNextPatient.AutoSize = true;
            this.lblNextPatient.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextPatient.ImageKey = "(none)";
            this.lblNextPatient.Location = new System.Drawing.Point(235, 315);
            this.lblNextPatient.Name = "lblNextPatient";
            this.lblNextPatient.Size = new System.Drawing.Size(143, 22);
            this.lblNextPatient.TabIndex = 7;
            this.lblNextPatient.Text = "Next Patient : ";
            // 
            // lblInRoom
            // 
            this.lblInRoom.AutoSize = true;
            this.lblInRoom.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInRoom.Location = new System.Drawing.Point(454, 315);
            this.lblInRoom.Name = "lblInRoom";
            this.lblInRoom.Size = new System.Drawing.Size(106, 22);
            this.lblInRoom.TabIndex = 8;
            this.lblInRoom.Text = "In Room : ";
            // 
            // patientnametxt
            // 
            this.patientnametxt.Font = new System.Drawing.Font("Lucida Sans", 15.75F);
            this.patientnametxt.Location = new System.Drawing.Point(404, 85);
            this.patientnametxt.Multiline = true;
            this.patientnametxt.Name = "patientnametxt";
            this.patientnametxt.Size = new System.Drawing.Size(222, 38);
            this.patientnametxt.TabIndex = 9;
            this.patientnametxt.Visible = false;
            // 
            // nextpatienttxt
            // 
            this.nextpatienttxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nextpatienttxt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextpatienttxt.Location = new System.Drawing.Point(239, 367);
            this.nextpatienttxt.Multiline = true;
            this.nextpatienttxt.Name = "nextpatienttxt";
            this.nextpatienttxt.ReadOnly = true;
            this.nextpatienttxt.Size = new System.Drawing.Size(179, 70);
            this.nextpatienttxt.TabIndex = 10;
            // 
            // inroomtxt
            // 
            this.inroomtxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inroomtxt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inroomtxt.Location = new System.Drawing.Point(444, 367);
            this.inroomtxt.Multiline = true;
            this.inroomtxt.Name = "inroomtxt";
            this.inroomtxt.ReadOnly = true;
            this.inroomtxt.Size = new System.Drawing.Size(182, 70);
            this.inroomtxt.TabIndex = 11;
            // 
            // btnEarnings
            // 
            this.btnEarnings.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEarnings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEarnings.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.btnEarnings.Location = new System.Drawing.Point(12, 242);
            this.btnEarnings.Name = "btnEarnings";
            this.btnEarnings.Size = new System.Drawing.Size(160, 67);
            this.btnEarnings.TabIndex = 12;
            this.btnEarnings.Text = "Total Earnings";
            this.btnEarnings.UseVisualStyleBackColor = false;
            this.btnEarnings.Click += new System.EventHandler(this.btnEarnings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(807, 470);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClosingTime);
            this.Controls.Add(this.btnEarnings);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnEnteringRoom);
            this.Controls.Add(this.inroomtxt);
            this.Controls.Add(this.nextpatienttxt);
            this.Controls.Add(this.patientnametxt);
            this.Controls.Add(this.lblInRoom);
            this.Controls.Add(this.lblNextPatient);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblpatientname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Doctor\'s Waiting List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEnteringRoom;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnClosingTime;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblpatientname;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblNextPatient;
        private System.Windows.Forms.Label lblInRoom;
        private System.Windows.Forms.TextBox patientnametxt;
        private System.Windows.Forms.TextBox nextpatienttxt;
        private System.Windows.Forms.TextBox inroomtxt;
        private System.Windows.Forms.Button btnEarnings;
    }
}

