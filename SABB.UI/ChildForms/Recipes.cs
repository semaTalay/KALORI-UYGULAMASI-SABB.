using SABB.UI.RecipeeForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SABB.UI.ChildForms
{
    public partial class Recipes : Form
    {
        public Recipes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RecipeeForms.JuicyRoastedChicken juicyRoastedChicken = new JuicyRoastedChicken();
            juicyRoastedChicken.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RecipeeForms.CherryTomatoSoup cherryTomatoSoup = new CherryTomatoSoup();
            cherryTomatoSoup.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RecipeeForms.Sushi sushi = new Sushi();
            sushi.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            RecipeeForms.EasyKeyLimePie easyKeyLimePie = new EasyKeyLimePie();
            easyKeyLimePie.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RecipeeForms.BakedKaleChips bakedKaleChips = new BakedKaleChips();
            bakedKaleChips.ShowDialog();
        }
    }
}
