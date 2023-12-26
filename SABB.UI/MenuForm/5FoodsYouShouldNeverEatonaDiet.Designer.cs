namespace SABB.UI.MenuForm
{
    partial class _5FoodsYouShouldNeverEatonaDiet
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
            btnExit.TabIndex = 29;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(25, 336);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(571, 391);
            richTextBox1.TabIndex = 28;
            richTextBox1.Text = "1. French fries\n\n2. Pastries\n\n3. Sugary drinks\n\n4. Chips\n\n5. Processed meats such as salami, soudjouk and sausages";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 21F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 259);
            label1.Name = "label1";
            label1.Size = new Size(577, 39);
            label1.TabIndex = 27;
            label1.Text = "5 Foods You Should Never Eat on a Diet";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pexels_narco_pertama_6602821;
            pictureBox1.Location = new Point(162, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(295, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // _5FoodsYouShouldNeverEatonaDiet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 750);
            Controls.Add(btnExit);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "_5FoodsYouShouldNeverEatonaDiet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "_5FoodsYouShouldNeverEatonaDiet";
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