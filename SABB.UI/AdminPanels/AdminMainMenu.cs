using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SABB.UI.AdminPanels
{
    public partial class AdminMainMenu : Form
    {
        public AdminMainMenu()
        {
            InitializeComponent();
        }

        //Fields
        
        private Size formSize;

        private void AdminMainMenu_Load(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
        }

        private Form currentChildForm;

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminChildForms.UserPanel());
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminChildForms.Meals());
        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminChildForms.Information());
        }

        private void ıconButton4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminChildForms.UserMessage());
        }

        private void ıconButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ıconButton9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminChildForms.DietitianPanel());
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

        //Remove transparent border in maximized state
        private void FormMainMenu_Resize(object sender, EventArgs e)
        {
                FormBorderStyle = FormBorderStyle.None;
        }

        private void ıconButton6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ıconButton8_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void ıconButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
