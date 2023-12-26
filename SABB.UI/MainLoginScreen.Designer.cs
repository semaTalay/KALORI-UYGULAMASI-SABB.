namespace SABB.UI
{
    partial class MainLoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLoginScreen));
            pictureBox1 = new PictureBox();
            btnUserLogin = new Button();
            btnDietitianLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(313, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 401);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnUserLogin
            // 
            btnUserLogin.BackColor = Color.FromArgb(1, 21, 30);
            btnUserLogin.BackgroundImage = (Image)resources.GetObject("btnUserLogin.BackgroundImage");
            btnUserLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnUserLogin.FlatAppearance.BorderSize = 0;
            btnUserLogin.FlatStyle = FlatStyle.Flat;
            btnUserLogin.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUserLogin.ForeColor = Color.White;
            btnUserLogin.Location = new Point(445, 1);
            btnUserLogin.Name = "btnUserLogin";
            btnUserLogin.Size = new Size(305, 401);
            btnUserLogin.TabIndex = 5;
            btnUserLogin.Text = "User Log in";
            btnUserLogin.UseVisualStyleBackColor = false;
            btnUserLogin.Click += btnUserLogin_Click;
            // 
            // btnDietitianLogin
            // 
            btnDietitianLogin.BackColor = Color.FromArgb(1, 21, 30);
            btnDietitianLogin.BackgroundImage = (Image)resources.GetObject("btnDietitianLogin.BackgroundImage");
            btnDietitianLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnDietitianLogin.FlatAppearance.BorderSize = 0;
            btnDietitianLogin.FlatStyle = FlatStyle.Flat;
            btnDietitianLogin.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDietitianLogin.ForeColor = Color.White;
            btnDietitianLogin.Location = new Point(-1, 1);
            btnDietitianLogin.Name = "btnDietitianLogin";
            btnDietitianLogin.Size = new Size(308, 401);
            btnDietitianLogin.TabIndex = 1;
            btnDietitianLogin.Text = "Dietitian Log in";
            btnDietitianLogin.UseVisualStyleBackColor = false;
            btnDietitianLogin.Click += btnDietitianLogin_Click;
            // 
            // MainLoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(1, 21, 30);
            ClientSize = new Size(750, 400);
            Controls.Add(btnUserLogin);
            Controls.Add(btnDietitianLogin);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainLoginScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainLoginScreen";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Button btnUserLogin;
        private Button btnDietitianLogin;
    }
}