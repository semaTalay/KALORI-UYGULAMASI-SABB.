namespace SABB.UI.AdminChildForms
{
    partial class UserPanel
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
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            ıconButton1 = new FontAwesome.Sharp.IconButton();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(29, 85);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(996, 484);
            listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(74, 19);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 35);
            textBox1.TabIndex = 1;
            // 
            // ıconButton1
            // 
            ıconButton1.IconChar = FontAwesome.Sharp.IconChar.UserClock;
            ıconButton1.IconColor = Color.Black;
            ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton1.IconSize = 30;
            ıconButton1.Location = new Point(26, 19);
            ıconButton1.Margin = new Padding(3, 4, 3, 4);
            ıconButton1.Name = "ıconButton1";
            ıconButton1.Size = new Size(41, 43);
            ıconButton1.TabIndex = 2;
            ıconButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(841, 13);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(184, 45);
            button1.TabIndex = 3;
            button1.Text = "Active / Passive";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UserPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 629);
            Controls.Add(button1);
            Controls.Add(ıconButton1);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserPanel";
            Text = "User";
            Load += UserPanel_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private Button button1;
    }
}