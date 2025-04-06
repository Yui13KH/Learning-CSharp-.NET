using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieShop
{
    public partial class Form1 : Form
    {
        private Dictionary<string, decimal> itemPrices = new Dictionary<string, decimal>
        {
            { "Dryad", 30.00m },
            { "Android", 50.00m },
            { "Elf", 40.00m },
            { "Vampire", 60.00m },
            { "Human", 20.00m },
            { "Staff", 25.00m },
            { "Fists", 10.00m },
            { "Gun", 70.00m },
            { "Sword", 55.00m },
            { "Hero Costume", 50.00m },
            { "Space Suit", 75.00m },
            { "Ninja", 60.00m },
            { "Uniform", 30.00m },
            { "Armor", 90.00m },
            { "Casual", 25.00m },
            { "Hero", 100.00m},
            { "Villain", 120.00m}
        }; // dictionaries are nice I am not going to make variables , an array could work but too overcomplication

        public Form1()
        {
            InitializeComponent();
            InitializeSummary();
            SetupEventHandlers();
        }
        private void InitializeSummary()
        {
            string summary = "Character Summary:\n";
            summary += "Species: No selection\n";
            summary += "Weapon: No selection\n";
            summary += "Outfit: No selection\n";
            summary += "Character Type: No selection\n";
            summary += "Total Price: $0.00";
            lblSumarry.Text = summary;
        } // no selections 

        private void SetupEventHandlers()
        {
            rbDryad.CheckedChanged += new EventHandler(UpdateSummary);
            rbAndroid.CheckedChanged += new EventHandler(UpdateSummary);
            rbElf.CheckedChanged += new EventHandler(UpdateSummary);
            rbVampire.CheckedChanged += new EventHandler(UpdateSummary);
            rbHuman.CheckedChanged += new EventHandler(UpdateSummary);

            rbStaff.CheckedChanged += new EventHandler(UpdateSummary);
            rbFists.CheckedChanged += new EventHandler(UpdateSummary);
            rbGun.CheckedChanged += new EventHandler(UpdateSummary);
            rbSword.CheckedChanged += new EventHandler(UpdateSummary);

            chkHeroCustome.CheckedChanged += new EventHandler(UpdateSummary);
            chkSpace.CheckedChanged += new EventHandler(UpdateSummary);
            chkNinja.CheckedChanged += new EventHandler(UpdateSummary);
            chkUniform.CheckedChanged += new EventHandler(UpdateSummary);
            chkArmor.CheckedChanged += new EventHandler(UpdateSummary);
            chkCasual.CheckedChanged += new EventHandler(UpdateSummary);

            rbHero.CheckedChanged += new EventHandler(UpdateSummary);
            rbVillain.CheckedChanged += new EventHandler(UpdateSummary);

            btnReset.Click += new EventHandler(ResetForm);
        } // i am not going to manually click on each controller :D

        private void UpdateSummary(object sender, EventArgs e)
        {
            string summary = "Character Summary:\n";
            decimal totalPrice = 0.00m;

            if (rbDryad.Checked)
            {
                summary += "Species: Dryad\n";
                totalPrice += itemPrices["Dryad"];
            }
            else if (rbAndroid.Checked)
            {
                summary += "Species: Android\n";
                totalPrice += itemPrices["Android"];
            }
            else if (rbElf.Checked)
            {
                summary += "Species: Elf\n";
                totalPrice += itemPrices["Elf"];
            }
            else if (rbVampire.Checked)
            {
                summary += "Species: Vampire\n";
                totalPrice += itemPrices["Vampire"];
            }
            else if (rbHuman.Checked)
            {
                summary += "Species: Human\n";
                totalPrice += itemPrices["Human"];
            }
            else
                summary += "Species: No selection\n";

            summary += "Weapon: ";
            if (rbStaff.Checked) { summary += "Staff\n"; totalPrice += itemPrices["Staff"]; }
            if (rbFists.Checked) { summary += "Fists\n"; totalPrice += itemPrices["Fists"]; }
            if (rbGun.Checked) { summary += "Gun\n"; totalPrice += itemPrices["Gun"]; }
            if (rbSword.Checked) { summary += "Sword\n"; totalPrice += itemPrices["Sword"]; }
            if (summary.EndsWith("Weapon: ")) summary += "No selection\n";

            summary += "Outfit:\n";
            bool outfitSelected = false;
            if (chkHeroCustome.Checked) { summary += "- Hero Costume\n"; outfitSelected = true; totalPrice += itemPrices["Hero Costume"]; }
            if (chkSpace.Checked) { summary += "- Space Suit\n"; outfitSelected = true; totalPrice += itemPrices["Space Suit"]; }
            if (chkNinja.Checked) { summary += "- Ninja\n"; outfitSelected = true; totalPrice += itemPrices["Ninja"]; }
            if (chkUniform.Checked) { summary += "- Uniform\n"; outfitSelected = true; totalPrice += itemPrices["Uniform"]; }
            if (chkArmor.Checked) { summary += "- Armor\n"; outfitSelected = true; totalPrice += itemPrices["Armor"]; }
            if (chkCasual.Checked) { summary += "- Casual\n"; outfitSelected = true; totalPrice += itemPrices["Casual"]; }
            if (!outfitSelected) summary += "- No selection\n";

            if (rbHero.Checked)
            {
                summary += "Character Type: Hero\n";
                totalPrice += itemPrices["Hero"];
            }
            else if (rbVillain.Checked)
            {
                summary += "Character Type: Villain\n";
                totalPrice += itemPrices["Villain"];
            }
            else
                summary += "Character Type: No selection\n";

            summary += $"Total Price: ${totalPrice:F2}";
            lblSumarry.Text = summary;
        }

        private void ResetForm(object sender, EventArgs e)
        {
            rbDryad.Checked = false;
            rbAndroid.Checked = false;
            rbElf.Checked = false;
            rbVampire.Checked = false;
            rbHuman.Checked = false;

            rbStaff.Checked = false;
            rbFists.Checked = false;
            rbGun.Checked = false;
            rbSword.Checked = false;

            rbHero.Checked = false;
            rbVillain.Checked = false;

            chkHeroCustome.Checked = false;
            chkSpace.Checked = false;
            chkNinja.Checked = false;
            chkUniform.Checked = false;
            chkArmor.Checked = false;
            chkCasual.Checked = false;

            CharType.Enabled = true;
            weaponType.Enabled = true;
            outfits.Enabled = true;
            species.Enabled = true;

            InitializeSummary();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to place this order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Disable GroupBoxes
                CharType.Enabled = false;
                weaponType.Enabled = false;
                outfits.Enabled = false;
                species.Enabled = false;

                MessageBox.Show("Order placed successfully!", "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
// also yeah i wrote this in vscode then switched to visual studio , hotkeys are wierd in visual studio you could probably remap them
// but nah