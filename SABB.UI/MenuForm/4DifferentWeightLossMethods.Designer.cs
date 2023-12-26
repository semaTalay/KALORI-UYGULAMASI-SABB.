namespace SABB.UI.MenuForm
{
    partial class _4DifferentWeightLossMethods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_4DifferentWeightLossMethods));
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
            btnExit.Location = new Point(552, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(33, 28);
            btnExit.TabIndex = 33;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(14, 316);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(571, 391);
            richTextBox1.TabIndex = 32;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 21F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(56, 236);
            label1.Name = "label1";
            label1.Size = new Size(481, 39);
            label1.TabIndex = 31;
            label1.Text = "4 Different Weight Loss Methods";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pexels_annushka_ahuja_79919101;
            pictureBox1.Location = new Point(151, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(295, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // _4DifferentWeightLossMethods
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 711);
            Controls.Add(btnExit);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "_4DifferentWeightLossMethods";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "_4DifferentWeightLossMethods";
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