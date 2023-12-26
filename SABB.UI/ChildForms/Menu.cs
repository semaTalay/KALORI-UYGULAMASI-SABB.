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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm._5FoodsYouShouldNeverEatonaDiet _5FoodsYouShouldNeverEatonaDiet = new MenuForm._5FoodsYouShouldNeverEatonaDiet();
            _5FoodsYouShouldNeverEatonaDiet.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuForm._5GoldenRulesofDieting _5GoldenRulesofDieting = new MenuForm._5GoldenRulesofDieting();
            _5GoldenRulesofDieting.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuForm._5tipsforeconomicalshopping _5Tipsforeconomicalshopping = new MenuForm._5tipsforeconomicalshopping();
            _5Tipsforeconomicalshopping.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MenuForm._4DifferentWeightLossMethods _4DifferentWeightLossMethods = new MenuForm._4DifferentWeightLossMethods();
            _4DifferentWeightLossMethods.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MenuForm.HealthBenefitsofDarkChocolate healthBenefitsofDarkChocolate = new MenuForm.HealthBenefitsofDarkChocolate();
            healthBenefitsofDarkChocolate.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MenuForm._5benefitsofcoffeethatyoushoulddefinitelyknow _5Benefitsofcoffeethatyoushoulddefinitelyknow = new MenuForm._5benefitsofcoffeethatyoushoulddefinitelyknow();
            _5Benefitsofcoffeethatyoushoulddefinitelyknow.ShowDialog();
        }
    }
}
