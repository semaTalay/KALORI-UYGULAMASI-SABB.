namespace SABB.UI.AdminChildForms
{
    partial class DietitianPanel
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
            button1 = new Button();
            ıconButton1 = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(734, 12);
            button1.Name = "button1";
            button1.Size = new Size(161, 34);
            button1.TabIndex = 7;
            button1.Text = "Active / Passive";
            button1.UseVisualStyleBackColor = true;
            // 
            // ıconButton1
            // 
            ıconButton1.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            ıconButton1.IconColor = Color.Black;
            ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton1.IconSize = 30;
            ıconButton1.Location = new Point(24, 12);
            ıconButton1.Name = "ıconButton1";
            ıconButton1.Size = new Size(36, 32);
            ıconButton1.TabIndex = 6;
            ıconButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(66, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 30);
            textBox1.TabIndex = 5;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(23, 66);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(872, 364);
            listBox1.TabIndex = 4;
            // 
            // Dietitian
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 472);
            Controls.Add(button1);
            Controls.Add(ıconButton1);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dietitian";
            Text = "Dietitian";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private TextBox textBox1;
        private ListBox listBox1;
    }
}