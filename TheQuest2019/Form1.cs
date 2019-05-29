using System;
using System.Drawing;
using System.Windows.Forms;

namespace TheQuest2019
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 420, 155));
            game.NewLevel(random);
            UpdateCharacters();
        }

        private void UpdateCharacters()
        {
            player.Location = game.PlayerLocation;
            playerHitpoints.Text = game.PlayerHitPoints.ToString();
            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;

            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    bat.Location = enemy.Location;
                    batHitpoints.Text = enemy.Hitpoints.ToString();
                    if (enemy.Hitpoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }
                else if (enemy is Ghost)
                {
                    ghost.Location = enemy.Location;
                    ghostHitpoints.Text = enemy.Hitpoints.ToString();
                    if (enemy.Hitpoints > 0)
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                }
                else if (enemy is Ghoul)
                {
                    ghoul.Location = enemy.Location;
                    ghoulHitpoints.Text = enemy.Hitpoints.ToString();
                    if (enemy.Hitpoints > 0)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                }
            }

            if (showBat == false)
                bat.Visible = false;
            if (showGhost == false)
                ghost.Visible = false;
            if (showGhoul == false)
                ghoul.Visible = false;

            sword.Visible = false;
            bow.Visible = false;
            mace.Visible = false;
            bluePotion.Visible = false;
            redPotion.Visible = false;
            Control weaponControl = null;
            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = sword; break;
                case "Bow":
                    weaponControl = bow; break;
                case "Mace":
                    weaponControl = mace; break;
                case "Blue Potion":
                    weaponControl = bluePotion; break;
                case "Red Potion":
                    weaponControl = redPotion; break;
            }
            weaponControl.Visible = true;

            if (game.CheckPlayerInventory("Sword"))
                pictureBoxSwordInventory.Visible = true;
            if (game.CheckPlayerInventory("Bow"))
                pictureBoxBowInventory.Visible = true;
            if (game.CheckPlayerInventory("Mace"))
                pictureBoxMaceInventory.Visible = true;
            if (game.CheckPlayerInventory("Blue Potion"))
                pictureBoxBluePotionInventory.Visible = true;
            if (game.CheckPlayerInventory("Red Potion"))
                pictureBoxRedPotionInventory.Visible = true;

            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
                weaponControl.Visible = false;
            else
                weaponControl.Visible = true;

            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("You died");
                Application.Exit();
            }

            if (enemiesShown < 1)
            {
                MessageBox.Show("You defeated the enemies on this level");
                game.NewLevel(random);
                UpdateCharacters();
            }
        }
        #region inventory
        private void pictureBoxSwordInventory_Click(object sender, EventArgs e)
        {
            string sword = "Sword";
            if (game.CheckPlayerInventory(sword))
            {
                game.Equip(sword);
                updateAttackButtons(sword);
                removeBoxFromInventoryIcons();
                pictureBoxSwordInventory.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void updateAttackButtons(string equippedWeapon)
        {
            foreach (string weapon in new string[] {"Sword", "Mace", "Bow" })
            {
                if (weapon == equippedWeapon)
                {
                    attackLeft.Visible = true;
                    attackUp.Text = "↑";
                    attackUp.Visible = true;
                    attackRight.Visible = true;
                    attackDown.Visible = true;
                }
                else
                {
                    attackLeft.Visible = false;
                    attackUp.Text = "Drink";
                    attackUp.Visible = true;
                    attackRight.Visible = false;
                    attackDown.Visible = false;
                }
            }
        }

        private void pictureBoxBowInventory_Click(object sender, EventArgs e)
        {
            string bow = "Bow";
            if (game.CheckPlayerInventory(bow))
            {
                game.Equip(bow);
                updateAttackButtons(bow);
                removeBoxFromInventoryIcons();
                pictureBoxBowInventory.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void pictureBoxMaceInventory_Click(object sender, EventArgs e)
        {
            string mace = "Mace";
            if (game.CheckPlayerInventory(mace))
            {
                game.Equip(mace);
                updateAttackButtons(mace);
                removeBoxFromInventoryIcons();
                pictureBoxMaceInventory.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void pictureBoxBluePotionInventory_Click(object sender, EventArgs e)
        {
            string bluePotion = "BluePotion";
            if (game.CheckPlayerInventory(bluePotion))
            {
                game.Equip(bluePotion);
                updateAttackButtons(bluePotion);
                removeBoxFromInventoryIcons();
                pictureBoxBluePotionInventory.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void pictureBoxRedPotionInventory_Click(object sender, EventArgs e)
        {
            string redPotion = "RedPotion";
            if (game.CheckPlayerInventory(redPotion))
            {
                game.Equip(redPotion);
                updateAttackButtons(redPotion);
                removeBoxFromInventoryIcons();
                pictureBoxRedPotionInventory.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void removeBoxFromInventoryIcons()
        {
            pictureBoxSwordInventory.BorderStyle = BorderStyle.None;
            pictureBoxBowInventory.BorderStyle = BorderStyle.None;
            pictureBoxMaceInventory.BorderStyle = BorderStyle.None;
            pictureBoxBluePotionInventory.BorderStyle = BorderStyle.None;
            pictureBoxRedPotionInventory.BorderStyle = BorderStyle.None;
        }
        #endregion

        #region movement
        private void moveLeft_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void moveUp_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void moveRight_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void moveDown_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }
        #endregion

        #region attack
        private void attackLeft_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }

        private void attackUp_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private void attackRight_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }

        private void attackDown_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }
        #endregion
    }
}
