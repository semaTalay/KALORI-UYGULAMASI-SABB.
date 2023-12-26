using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace SABB.UI
{
    partial class MainMenu
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
            components = new System.ComponentModel.Container();
            panelMenu = new Panel();
            ıbtnContsctUs = new FontAwesome.Sharp.IconButton();
            ıbtnUserInformation = new FontAwesome.Sharp.IconButton();
            ıbtnDietitian = new FontAwesome.Sharp.IconButton();
            ıbtnCalculateCalories = new FontAwesome.Sharp.IconButton();
            ıbtnRecipes = new FontAwesome.Sharp.IconButton();
            ıbtnMeals = new FontAwesome.Sharp.IconButton();
            ıbtnMainMenu = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            btnHome = new PictureBox();
            panelTitleBar = new Panel();
            lblUserName = new Label();
            pictureBox2 = new PictureBox();
            btnMinimalize = new FontAwesome.Sharp.IconButton();
            btnExit = new FontAwesome.Sharp.IconButton();
            btnMaximize = new FontAwesome.Sharp.IconButton();
            lblTitleChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelShadow = new Panel();
            panelDesktop = new Panel();
            lblCallender = new Label();
            lblWatch = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(31, 30, 68);
            panelMenu.Controls.Add(ıbtnContsctUs);
            panelMenu.Controls.Add(ıbtnUserInformation);
            panelMenu.Controls.Add(ıbtnDietitian);
            panelMenu.Controls.Add(ıbtnCalculateCalories);
            panelMenu.Controls.Add(ıbtnRecipes);
            panelMenu.Controls.Add(ıbtnMeals);
            panelMenu.Controls.Add(ıbtnMainMenu);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(251, 1173);
            panelMenu.TabIndex = 0;
            // 
            // ıbtnContsctUs
            // 
            ıbtnContsctUs.Dock = DockStyle.Top;
            ıbtnContsctUs.FlatAppearance.BorderSize = 0;
            ıbtnContsctUs.FlatStyle = FlatStyle.Flat;
            ıbtnContsctUs.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ıbtnContsctUs.ForeColor = Color.White;
            ıbtnContsctUs.IconChar = FontAwesome.Sharp.IconChar.EnvelopeCircleCheck;
            ıbtnContsctUs.IconColor = Color.Gainsboro;
            ıbtnContsctUs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıbtnContsctUs.IconSize = 30;
            ıbtnContsctUs.ImageAlign = ContentAlignment.MiddleLeft;
            ıbtnContsctUs.Location = new Point(0, 679);
            ıbtnContsctUs.Margin = new Padding(3, 4, 3, 4);
            ıbtnContsctUs.Name = "ıbtnContsctUs";
            ıbtnContsctUs.Padding = new Padding(11, 0, 23, 0);
            ıbtnContsctUs.Size = new Size(251, 80);
            ıbtnContsctUs.TabIndex = 14;
            ıbtnContsctUs.Text = "CONTACT US";
            ıbtnContsctUs.TextAlign = ContentAlignment.MiddleLeft;
            ıbtnContsctUs.TextImageRelation = TextImageRelation.ImageBeforeText;
            ıbtnContsctUs.UseVisualStyleBackColor = true;
            ıbtnContsctUs.Click += ıbtnContsctUs_Click;
            // 
            // ıbtnUserInformation
            // 
            ıbtnUserInformation.Dock = DockStyle.Top;
            ıbtnUserInformation.FlatAppearance.BorderSize = 0;
            ıbtnUserInformation.FlatStyle = FlatStyle.Flat;
            ıbtnUserInformation.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ıbtnUserInformation.ForeColor = Color.White;
            ıbtnUserInformation.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            ıbtnUserInformation.IconColor = Color.Gainsboro;
            ıbtnUserInformation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıbtnUserInformation.IconSize = 30;
            ıbtnUserInformation.ImageAlign = ContentAlignment.MiddleLeft;
            ıbtnUserInformation.Location = new Point(0, 599);
            ıbtnUserInformation.Margin = new Padding(3, 4, 3, 4);
            ıbtnUserInformation.Name = "ıbtnUserInformation";
            ıbtnUserInformation.Padding = new Padding(11, 0, 23, 0);
            ıbtnUserInformation.Size = new Size(251, 80);
            ıbtnUserInformation.TabIndex = 13;
            ıbtnUserInformation.Text = "USER INFORMATION";
            ıbtnUserInformation.TextAlign = ContentAlignment.MiddleLeft;
            ıbtnUserInformation.TextImageRelation = TextImageRelation.ImageBeforeText;
            ıbtnUserInformation.UseVisualStyleBackColor = true;
            ıbtnUserInformation.Click += ıbtnUserInformation_Click;
            // 
            // ıbtnDietitian
            // 
            ıbtnDietitian.Dock = DockStyle.Top;
            ıbtnDietitian.FlatAppearance.BorderSize = 0;
            ıbtnDietitian.FlatStyle = FlatStyle.Flat;
            ıbtnDietitian.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ıbtnDietitian.ForeColor = Color.White;
            ıbtnDietitian.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            ıbtnDietitian.IconColor = Color.Gainsboro;
            ıbtnDietitian.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıbtnDietitian.IconSize = 30;
            ıbtnDietitian.ImageAlign = ContentAlignment.MiddleLeft;
            ıbtnDietitian.Location = new Point(0, 519);
            ıbtnDietitian.Margin = new Padding(3, 4, 3, 4);
            ıbtnDietitian.Name = "ıbtnDietitian";
            ıbtnDietitian.Padding = new Padding(11, 0, 23, 0);
            ıbtnDietitian.Size = new Size(251, 80);
            ıbtnDietitian.TabIndex = 12;
            ıbtnDietitian.Text = "DIETITIANS";
            ıbtnDietitian.TextAlign = ContentAlignment.MiddleLeft;
            ıbtnDietitian.TextImageRelation = TextImageRelation.ImageBeforeText;
            ıbtnDietitian.UseVisualStyleBackColor = true;
            ıbtnDietitian.Click += ıbtnDietitian_Click;
            // 
            // ıbtnCalculateCalories
            // 
            ıbtnCalculateCalories.Dock = DockStyle.Top;
            ıbtnCalculateCalories.FlatAppearance.BorderSize = 0;
            ıbtnCalculateCalories.FlatStyle = FlatStyle.Flat;
            ıbtnCalculateCalories.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ıbtnCalculateCalories.ForeColor = Color.White;
            ıbtnCalculateCalories.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            ıbtnCalculateCalories.IconColor = Color.Gainsboro;
            ıbtnCalculateCalories.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıbtnCalculateCalories.IconSize = 30;
            ıbtnCalculateCalories.ImageAlign = ContentAlignment.MiddleLeft;
            ıbtnCalculateCalories.Location = new Point(0, 439);
            ıbtnCalculateCalories.Margin = new Padding(3, 4, 3, 4);
            ıbtnCalculateCalories.Name = "ıbtnCalculateCalories";
            ıbtnCalculateCalories.Padding = new Padding(11, 0, 23, 0);
            ıbtnCalculateCalories.Size = new Size(251, 80);
            ıbtnCalculateCalories.TabIndex = 9;
            ıbtnCalculateCalories.Text = "ANALYZES";
            ıbtnCalculateCalories.TextAlign = ContentAlignment.MiddleLeft;
            ıbtnCalculateCalories.TextImageRelation = TextImageRelation.ImageBeforeText;
            ıbtnCalculateCalories.UseVisualStyleBackColor = true;
            ıbtnCalculateCalories.Click += ıbtnCalculateCalories_Click;
            // 
            // ıbtnRecipes
            // 
            ıbtnRecipes.Dock = DockStyle.Top;
            ıbtnRecipes.FlatAppearance.BorderSize = 0;
            ıbtnRecipes.FlatStyle = FlatStyle.Flat;
            ıbtnRecipes.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ıbtnRecipes.ForeColor = Color.White;
            ıbtnRecipes.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            ıbtnRecipes.IconColor = Color.Gainsboro;
            ıbtnRecipes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıbtnRecipes.IconSize = 30;
            ıbtnRecipes.ImageAlign = ContentAlignment.MiddleLeft;
            ıbtnRecipes.Location = new Point(0, 359);
            ıbtnRecipes.Margin = new Padding(3, 4, 3, 4);
            ıbtnRecipes.Name = "ıbtnRecipes";
            ıbtnRecipes.Padding = new Padding(11, 0, 23, 0);
            ıbtnRecipes.Size = new Size(251, 80);
            ıbtnRecipes.TabIndex = 5;
            ıbtnRecipes.Text = "RECIPES";
            ıbtnRecipes.TextAlign = ContentAlignment.MiddleLeft;
            ıbtnRecipes.TextImageRelation = TextImageRelation.ImageBeforeText;
            ıbtnRecipes.UseVisualStyleBackColor = true;
            ıbtnRecipes.Click += ıbtnRecipes_Click;
            // 
            // ıbtnMeals
            // 
            ıbtnMeals.Dock = DockStyle.Top;
            ıbtnMeals.FlatAppearance.BorderSize = 0;
            ıbtnMeals.FlatStyle = FlatStyle.Flat;
            ıbtnMeals.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ıbtnMeals.ForeColor = Color.White;
            ıbtnMeals.IconChar = FontAwesome.Sharp.IconChar.BellConcierge;
            ıbtnMeals.IconColor = Color.Gainsboro;
            ıbtnMeals.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıbtnMeals.IconSize = 30;
            ıbtnMeals.ImageAlign = ContentAlignment.MiddleLeft;
            ıbtnMeals.Location = new Point(0, 279);
            ıbtnMeals.Margin = new Padding(3, 4, 3, 4);
            ıbtnMeals.Name = "ıbtnMeals";
            ıbtnMeals.Padding = new Padding(11, 0, 23, 0);
            ıbtnMeals.Size = new Size(251, 80);
            ıbtnMeals.TabIndex = 4;
            ıbtnMeals.Text = "MEALS";
            ıbtnMeals.TextAlign = ContentAlignment.MiddleLeft;
            ıbtnMeals.TextImageRelation = TextImageRelation.ImageBeforeText;
            ıbtnMeals.UseVisualStyleBackColor = true;
            ıbtnMeals.Click += ıbtnMeals_Click;
            // 
            // ıbtnMainMenu
            // 
            ıbtnMainMenu.Dock = DockStyle.Top;
            ıbtnMainMenu.FlatAppearance.BorderSize = 0;
            ıbtnMainMenu.FlatStyle = FlatStyle.Flat;
            ıbtnMainMenu.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ıbtnMainMenu.ForeColor = Color.White;
            ıbtnMainMenu.IconChar = FontAwesome.Sharp.IconChar.House;
            ıbtnMainMenu.IconColor = Color.Gainsboro;
            ıbtnMainMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıbtnMainMenu.IconSize = 30;
            ıbtnMainMenu.ImageAlign = ContentAlignment.MiddleLeft;
            ıbtnMainMenu.Location = new Point(0, 199);
            ıbtnMainMenu.Margin = new Padding(3, 4, 3, 4);
            ıbtnMainMenu.Name = "ıbtnMainMenu";
            ıbtnMainMenu.Padding = new Padding(11, 0, 23, 0);
            ıbtnMainMenu.Size = new Size(251, 80);
            ıbtnMainMenu.TabIndex = 1;
            ıbtnMainMenu.Text = "MAIN MENU";
            ıbtnMainMenu.TextAlign = ContentAlignment.MiddleLeft;
            ıbtnMainMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            ıbtnMainMenu.UseVisualStyleBackColor = true;
            ıbtnMainMenu.Click += ıbtnMainMenu_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackgroundImageLayout = ImageLayout.Stretch;
            panelLogo.Controls.Add(btnHome);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 4, 3, 4);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(251, 199);
            panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Image = Properties.Resources.SAAB;
            btnHome.Location = new Point(14, 4);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(225, 187);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 0;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click_1;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(26, 25, 62);
            panelTitleBar.Controls.Add(lblUserName);
            panelTitleBar.Controls.Add(pictureBox2);
            panelTitleBar.Controls.Add(btnMinimalize);
            panelTitleBar.Controls.Add(btnExit);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(lblTitleChildForm);
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(251, 0);
            panelTitleBar.Margin = new Padding(3, 4, 3, 4);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1136, 107);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.ForeColor = Color.OrangeRed;
            lblUserName.Location = new Point(901, 37);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(97, 25);
            lblUserName.TabIndex = 8;
            lblUserName.Text = "UserName";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Location = new Point(813, 16);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(71, 76);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // btnMinimalize
            // 
            btnMinimalize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimalize.BackColor = Color.Transparent;
            btnMinimalize.BackgroundImageLayout = ImageLayout.None;
            btnMinimalize.FlatAppearance.BorderSize = 0;
            btnMinimalize.FlatStyle = FlatStyle.Flat;
            btnMinimalize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimalize.IconColor = Color.OrangeRed;
            btnMinimalize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimalize.IconSize = 20;
            btnMinimalize.Location = new Point(1016, 16);
            btnMinimalize.Margin = new Padding(3, 4, 3, 4);
            btnMinimalize.Name = "btnMinimalize";
            btnMinimalize.Size = new Size(31, 33);
            btnMinimalize.TabIndex = 4;
            btnMinimalize.UseVisualStyleBackColor = false;
            btnMinimalize.Click += btnMinimalize_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.Transparent;
            btnExit.BackgroundImageLayout = ImageLayout.None;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnExit.IconColor = Color.OrangeRed;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.IconSize = 25;
            btnExit.Location = new Point(1091, 16);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(31, 33);
            btnExit.TabIndex = 3;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click_1;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.Transparent;
            btnMaximize.BackgroundImageLayout = ImageLayout.None;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Maximize;
            btnMaximize.IconColor = Color.OrangeRed;
            btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximize.IconSize = 20;
            btnMaximize.Location = new Point(1054, 16);
            btnMaximize.Margin = new Padding(3, 4, 3, 4);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(31, 33);
            btnMaximize.TabIndex = 2;
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click_1;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleChildForm.ForeColor = Color.White;
            lblTitleChildForm.Location = new Point(66, 37);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(57, 25);
            lblTitleChildForm.TabIndex = 1;
            lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.Transparent;
            iconCurrentChildForm.ForeColor = Color.Gainsboro;
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            iconCurrentChildForm.IconColor = Color.Gainsboro;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.IconSize = 37;
            iconCurrentChildForm.Location = new Point(24, 29);
            iconCurrentChildForm.Margin = new Padding(3, 4, 3, 4);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(37, 43);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            panelShadow.BackColor = Color.FromArgb(26, 25, 62);
            panelShadow.Dock = DockStyle.Top;
            panelShadow.Location = new Point(251, 107);
            panelShadow.Margin = new Padding(3, 4, 3, 4);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(1136, 12);
            panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(34, 33, 70);
            panelDesktop.Controls.Add(lblCallender);
            panelDesktop.Controls.Add(lblWatch);
            panelDesktop.Controls.Add(pictureBox1);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.ForeColor = Color.White;
            panelDesktop.Location = new Point(251, 119);
            panelDesktop.Margin = new Padding(3, 4, 3, 4);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1136, 1054);
            panelDesktop.TabIndex = 3;
            // 
            // lblCallender
            // 
            lblCallender.Anchor = AnchorStyles.None;
            lblCallender.AutoSize = true;
            lblCallender.BackColor = Color.Transparent;
            lblCallender.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblCallender.ForeColor = Color.White;
            lblCallender.Location = new Point(400, 576);
            lblCallender.Name = "lblCallender";
            lblCallender.Size = new Size(88, 41);
            lblCallender.TabIndex = 3;
            lblCallender.Text = "Date";
            // 
            // lblWatch
            // 
            lblWatch.Anchor = AnchorStyles.None;
            lblWatch.AutoSize = true;
            lblWatch.BackColor = Color.Transparent;
            lblWatch.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblWatch.ForeColor = Color.White;
            lblWatch.Location = new Point(507, 519);
            lblWatch.Name = "lblWatch";
            lblWatch.Size = new Size(152, 41);
            lblWatch.TabIndex = 2;
            lblWatch.Text = "00:00:00";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.SAABLogo1;
            pictureBox1.Location = new Point(411, 425);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(323, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1387, 1173);
            Controls.Add(panelDesktop);
            Controls.Add(panelShadow);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenu";
            Load += MainMenu_Load;
            Resize += FormMainMenu_Resize;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            panelDesktop.ResumeLayout(false);
            panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton ıbtnMainMenu;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton ıbtnRecipes;
        private FontAwesome.Sharp.IconButton ıbtnMeals;
        private FontAwesome.Sharp.IconButton ıbtnCalculateCalories;
        private FontAwesome.Sharp.IconButton ıbtnContsctUs;
        private FontAwesome.Sharp.IconButton ıbtnUserInformation;
        private FontAwesome.Sharp.IconButton ıbtnDietitian;
        private PictureBox btnHome;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Label lblTitleChildForm;
        private Panel panelShadow;
        private Panel panelDesktop;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnMinimalize;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private Label lblWatch;
        private System.Windows.Forms.Timer timer1;
        private Label lblCallender;
        private Label lblUserName;
        private PictureBox pictureBox2;
    }
}