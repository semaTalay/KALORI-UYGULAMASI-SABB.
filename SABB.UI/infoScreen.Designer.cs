namespace SABB.UI
{
    partial class infoScreen
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnTurnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 24);
            label1.Name = "label1";
            label1.Size = new Size(115, 18);
            label1.TabIndex = 0;
            label1.Text = "Hello SABB user! ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(34, 52);
            label2.Name = "label2";
            label2.Size = new Size(465, 18);
            label2.TabIndex = 1;
            label2.Text = " We're delighted to be a part of your journey towards a healthier lifestyle.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 76);
            label3.Name = "label3";
            label3.Size = new Size(445, 18);
            label3.TabIndex = 2;
            label3.Text = "SABB is here to provide you with a personalized weight loss experience ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(34, 138);
            label4.Name = "label4";
            label4.Size = new Size(454, 18);
            label4.TabIndex = 3;
            label4.Text = "After logging in, you will step into a world that creates your personalized";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(24, 173);
            label5.Name = "label5";
            label5.Size = new Size(512, 18);
            label5.TabIndex = 4;
            label5.Text = "nutrition and exercise plan, tracks your progress, and provides you with motivation.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(24, 201);
            label6.Name = "label6";
            label6.Size = new Size(558, 18);
            label6.TabIndex = 5;
            label6.Text = "Remember, healthy changes start with small steps. We're here to help you reach your goals!";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(24, 261);
            label8.Name = "label8";
            label8.Size = new Size(205, 18);
            label8.TabIndex = 7;
            label8.Text = "Wishing you healthy days ahead,";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(24, 288);
            label9.Name = "label9";
            label9.Size = new Size(78, 18);
            label9.TabIndex = 8;
            label9.Text = "SABB Team";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(24, 103);
            label10.Name = "label10";
            label10.Size = new Size(188, 18);
            label10.TabIndex = 9;
            label10.Text = "tailored to your unique needs.";
            // 
            // btnTurnBack
            // 
            btnTurnBack.BackgroundImage = Properties.Resources.turn_back_35858961;
            btnTurnBack.BackgroundImageLayout = ImageLayout.Zoom;
            btnTurnBack.Location = new Point(549, 12);
            btnTurnBack.Name = "btnTurnBack";
            btnTurnBack.Size = new Size(33, 25);
            btnTurnBack.TabIndex = 22;
            btnTurnBack.UseVisualStyleBackColor = true;
            btnTurnBack.Click += btnTurnBack_Click;
            // 
            // infoScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(601, 327);
            Controls.Add(btnTurnBack);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "infoScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "infoScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnTurnBack;
    }
}