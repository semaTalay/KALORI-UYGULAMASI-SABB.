using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using FontAwesome.Sharp;
using Microsoft.VisualBasic.ApplicationServices;
using SABB.Domain.Concrete;
using User = SABB.Domain.Concrete.User;

namespace SABB.UI
{
    public partial class MainMenu : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;


        //Constructor
        public MainMenu()
        {
            InitializeComponent();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        User user;
        public MainMenu(User user) : this()
        {
            this.user = user;
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(100, 200, 251);
        }


        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;

            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }

        //Events
        //Reset
        private void btnHome_Click_1(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }


        //Menu Button_Clicks
        private void ıbtnMainMenu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            panelShadow.BackColor = RGBColors.color1;
            lblTitleChildForm.ForeColor = RGBColors.color1;
            OpenChildForm(new ChildForms.Menu());
        }

        private void ıbtnMeals_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            panelShadow.BackColor = RGBColors.color2;
            lblTitleChildForm.ForeColor = RGBColors.color2;
            OpenChildForm(new ChildForms.Meals(this.user));
        }

        private void ıbtnRecipes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            panelShadow.BackColor = RGBColors.color3;
            lblTitleChildForm.ForeColor = RGBColors.color3;
            OpenChildForm(new ChildForms.Recipes());
        }

        private void ıbtnCalculateCalories_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            panelShadow.BackColor = RGBColors.color4;
            lblTitleChildForm.ForeColor = RGBColors.color4;
            OpenChildForm(new ChildForms.Calculator());
        }

        private void ıbtnDietitian_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            panelShadow.BackColor = RGBColors.color5;
            lblTitleChildForm.ForeColor = RGBColors.color5;
            OpenChildForm(new ChildForms.Dietitians());
        }

        private void ıbtnUserInformation_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            panelShadow.BackColor = RGBColors.color6;
            lblTitleChildForm.ForeColor = RGBColors.color6;
            OpenChildForm(new ChildForms.Information(this.user));
        }

        private void ıbtnContsctUs_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            panelShadow.BackColor = RGBColors.color7;
            lblTitleChildForm.ForeColor = RGBColors.color7;
            OpenChildForm(new ChildForms.Contact());
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblWatch.Text = DateTime.Now.ToString("hh:mm:ss");
            lblCallender.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblWatch.Text = DateTime.Now.ToString("hh:mm:ss");
            timer1.Start();
        }


        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        //Close-Maximize-Minimize
        private void btnMinimalize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Remove transparent border in maximized state
        private void FormMainMenu_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }
    }
}
