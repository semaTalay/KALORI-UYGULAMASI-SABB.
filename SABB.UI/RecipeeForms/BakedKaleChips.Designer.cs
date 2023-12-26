namespace SABB.UI.RecipeeForms
{
    partial class BakedKaleChips
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BakedKaleChips));
            btnExit = new Button();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackgroundImage = Properties.Resources.pngwing_com__1_;
            btnExit.BackgroundImageLayout = ImageLayout.Zoom;
            btnExit.Location = new Point(563, 24);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(33, 28);
            btnExit.TabIndex = 25;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(25, 336);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(571, 391);
            richTextBox1.TabIndex = 24;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(172, 262);
            label1.Name = "label1";
            label1.Size = new Size(257, 40);
            label1.TabIndex = 23;
            label1.Text = "Baked Kale Chips";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.BakedKaleChips1;
            pictureBox1.Location = new Point(162, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(295, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // BakedKaleChips
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(620, 750);
            Controls.Add(btnExit);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BakedKaleChips";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BakedKaleChips";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private RichTextBox richTextBox1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}