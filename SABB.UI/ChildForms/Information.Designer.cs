namespace SABB.UI.ChildForms
{
    partial class Information
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lblUser = new Label();
            label4 = new Label();
            lblFirstName = new Label();
            label6 = new Label();
            lblLastName = new Label();
            label8 = new Label();
            llEditProfile = new LinkLabel();
            lblEmail = new Label();
            panel1 = new Panel();
            LinkEditPass = new LinkLabel();
            txtCurrentPassword = new TextBox();
            label13 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            label3 = new Label();
            txtUUserName = new TextBox();
            txtUPasswordConfirm = new TextBox();
            txtUPassword = new TextBox();
            txtUEmail = new TextBox();
            label5 = new Label();
            label7 = new Label();
            txtULastName = new TextBox();
            txtUFirstName = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngwing_com__6_;
            pictureBox1.Location = new Point(68, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(68, 27);
            label1.Name = "label1";
            label1.Size = new Size(208, 51);
            label1.TabIndex = 1;
            label1.Text = "My Profile";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(314, 104);
            label2.Name = "label2";
            label2.Size = new Size(91, 19);
            label2.TabIndex = 2;
            label2.Text = "User Name :";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.Location = new Point(326, 131);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(35, 19);
            lblUser.TabIndex = 3;
            lblUser.Text = "user";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(314, 162);
            label4.Name = "label4";
            label4.Size = new Size(92, 19);
            label4.TabIndex = 4;
            label4.Text = "First Name :";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFirstName.Location = new Point(326, 190);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(52, 19);
            lblFirstName.TabIndex = 5;
            lblFirstName.Text = "FName";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(314, 220);
            label6.Name = "label6";
            label6.Size = new Size(88, 19);
            label6.TabIndex = 6;
            label6.Text = "Last Name :";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblLastName.Location = new Point(326, 249);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(51, 19);
            lblLastName.TabIndex = 7;
            lblLastName.Text = "LName";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(314, 278);
            label8.Name = "label8";
            label8.Size = new Size(54, 19);
            label8.TabIndex = 8;
            label8.Text = "Email :";
            // 
            // llEditProfile
            // 
            llEditProfile.AutoSize = true;
            llEditProfile.LinkColor = Color.Teal;
            llEditProfile.Location = new Point(232, 308);
            llEditProfile.Name = "llEditProfile";
            llEditProfile.Size = new Size(64, 15);
            llEditProfile.TabIndex = 9;
            llEditProfile.TabStop = true;
            llEditProfile.Text = "Edit Profile";
            llEditProfile.LinkClicked += linkEdit_LinkClicked;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(325, 308);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(34, 19);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "mail";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(LinkEditPass);
            panel1.Controls.Add(txtCurrentPassword);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtUUserName);
            panel1.Controls.Add(txtUPasswordConfirm);
            panel1.Controls.Add(txtUPassword);
            panel1.Controls.Add(txtUEmail);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtULastName);
            panel1.Controls.Add(txtUFirstName);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label12);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(508, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(497, 791);
            panel1.TabIndex = 11;
            panel1.Visible = false;
            // 
            // LinkEditPass
            // 
            LinkEditPass.AutoSize = true;
            LinkEditPass.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LinkEditPass.Location = new Point(192, 448);
            LinkEditPass.Name = "LinkEditPass";
            LinkEditPass.Size = new Size(30, 17);
            LinkEditPass.TabIndex = 12;
            LinkEditPass.TabStop = true;
            LinkEditPass.Text = "Edit";
            LinkEditPass.LinkClicked += LinkEditPass_LinkClicked;
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCurrentPassword.Location = new Point(46, 567);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(363, 26);
            txtCurrentPassword.TabIndex = 32;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(47, 532);
            label13.Name = "label13";
            label13.Size = new Size(110, 19);
            label13.TabIndex = 31;
            label13.Text = "New Password :";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.RoyalBlue;
            btnSave.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(253, 701);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 50);
            btnSave.TabIndex = 30;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            btnSave.MouseEnter += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gray;
            btnCancel.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(85, 701);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(137, 50);
            btnCancel.TabIndex = 29;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(48, 55);
            label3.Name = "label3";
            label3.Size = new Size(170, 35);
            label3.TabIndex = 27;
            label3.Text = "Edit My Data";
            // 
            // txtUUserName
            // 
            txtUUserName.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUUserName.Location = new Point(48, 149);
            txtUUserName.Name = "txtUUserName";
            txtUUserName.Size = new Size(363, 26);
            txtUUserName.TabIndex = 26;
            // 
            // txtUPasswordConfirm
            // 
            txtUPasswordConfirm.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUPasswordConfirm.Location = new Point(48, 646);
            txtUPasswordConfirm.Name = "txtUPasswordConfirm";
            txtUPasswordConfirm.Size = new Size(363, 26);
            txtUPasswordConfirm.TabIndex = 25;
            // 
            // txtUPassword
            // 
            txtUPassword.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUPassword.Location = new Point(48, 477);
            txtUPassword.Name = "txtUPassword";
            txtUPassword.Size = new Size(363, 26);
            txtUPassword.TabIndex = 24;
            // 
            // txtUEmail
            // 
            txtUEmail.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUEmail.Location = new Point(48, 395);
            txtUEmail.Name = "txtUEmail";
            txtUEmail.Size = new Size(363, 26);
            txtUEmail.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(48, 612);
            label5.Name = "label5";
            label5.Size = new Size(199, 19);
            label5.TabIndex = 22;
            label5.Text = "Confirm Your New Password :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(47, 118);
            label7.Name = "label7";
            label7.Size = new Size(91, 19);
            label7.TabIndex = 21;
            label7.Text = "User Name :";
            // 
            // txtULastName
            // 
            txtULastName.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtULastName.Location = new Point(48, 313);
            txtULastName.Name = "txtULastName";
            txtULastName.Size = new Size(363, 26);
            txtULastName.TabIndex = 20;
            // 
            // txtUFirstName
            // 
            txtUFirstName.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUFirstName.Location = new Point(48, 231);
            txtUFirstName.Name = "txtUFirstName";
            txtUFirstName.Size = new Size(363, 26);
            txtUFirstName.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(46, 446);
            label9.Name = "label9";
            label9.Size = new Size(130, 19);
            label9.TabIndex = 18;
            label9.Text = "Current Password :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(46, 364);
            label10.Name = "label10";
            label10.Size = new Size(54, 19);
            label10.TabIndex = 17;
            label10.Text = "Email :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(46, 282);
            label11.Name = "label11";
            label11.Size = new Size(88, 19);
            label11.TabIndex = 16;
            label11.Text = "Last Name :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(46, 200);
            label12.Name = "label12";
            label12.Size = new Size(92, 19);
            label12.TabIndex = 15;
            label12.Text = "First Name :";
            // 
            // Information
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 250);
            ClientSize = new Size(994, 788);
            Controls.Add(panel1);
            Controls.Add(lblEmail);
            Controls.Add(llEditProfile);
            Controls.Add(label8);
            Controls.Add(lblLastName);
            Controls.Add(label6);
            Controls.Add(lblFirstName);
            Controls.Add(label4);
            Controls.Add(lblUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Information";
            Text = "Information";
            Load += Information_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label lblUser;
        private Label label4;
        private Label lblFirstName;
        private Label label6;
        private Label lblLastName;
        private Label label8;
        private LinkLabel llEditProfile;
        private Label lblEmail;
        private Panel panel1;
        private Label label3;
        private TextBox txtUUserName;
        private TextBox txtUPasswordConfirm;
        private TextBox txtUPassword;
        private TextBox txtUEmail;
        private Label label5;
        private Label label7;
        private TextBox txtULastName;
        private TextBox txtUFirstName;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtCurrentPassword;
        private Label label13;
        private LinkLabel LinkEditPass;
    }
}