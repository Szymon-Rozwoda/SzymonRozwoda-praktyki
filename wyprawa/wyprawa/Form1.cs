using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace wyprawa
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random;
        private bool isPotionNeeded = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57,420, 155));
            game.NewLevel(random);
            UpdateCharacters();
            SetTheLevel();
            
        }

        //przyciski
        private void IN_sword_Click(object sender, EventArgs e)
        {
            SelectInventoryItem(sword, "Miecz", "Weapon");
            UpdateCharacters();
        }

        private void IN_bow_Click(object sender, EventArgs e)
        {
            SelectInventoryItem(bow, "Łuk", "Weapon");
            UpdateCharacters();
        }

        private void IN_mace_Click(object sender, EventArgs e)
        {
            SelectInventoryItem(mace, "Maca", "Weapon");
            UpdateCharacters();
        }

        private void IN_blue_potion_Click(object sender, EventArgs e)
        {
            SelectInventoryItem(blue_potion, "Blue Potion", "Potion");
            UpdateCharacters();
        }

        private void IN_red_potion_Click(object sender, EventArgs e)
        {
            SelectInventoryItem(red_potion, "Red Potion", "Potion");
            UpdateCharacters();
        }


        private void r_UP_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void r_RIGHT_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void r_DOWN_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void r_LEFT_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }


        private void a_UP_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private void a_RIGHT_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }

        private void a_DOWN_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }

        private void a_LEFT_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }



        private void UpdateCharacters()
        {
            playerHitPoints.Text = game.PlayerHitPoints.ToString();
            player.Location = game.PlayerLocation;
            int enemiesShown = 0;
            enemiesShown = CountEnemies();

            Control weaponControl = null;
            SetPictureBoxVisibility();
            weaponControl = SetVisibilityToWeaponInRoom(weaponControl);
            weaponControl.Visible = true;
            CheckPlayerInventory();
            weaponControl.Location = game.WeaponInRoom.Location;

            if (game.WeaponInRoom.PickedUp)
                weaponControl.Visible = false;
            else
            {
                weaponControl.Visible = true;
                weaponControl.Location = game.WeaponInRoom.Location;
            }

            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("You died", "System...");
                Application.Exit();
            }

            if (enemiesShown < 1)
            {
                MessageBox.Show("You have defeated the enemies on this level");
                game.NewLevel(random);
                UpdateCharacters();
            }
        }
        
        
        private void SelectInventoryItem(PictureBox item, string itemName, string weaponType)
        {
            if (game.CheckPlayerInventory(itemName))
            {
                game.Equip(itemName);
                RemoveInventoryBorders();
                item.BorderStyle = BorderStyle.FixedSingle;
                SetupAttackButtons(weaponType);
                RemoveInventoryBorders();
            }
        }
        private void RemoveInventoryBorders()
        {
            IN_sword.BorderStyle = BorderStyle.None;
            IN_bow.BorderStyle = BorderStyle.None;
            IN_mace.BorderStyle = BorderStyle.None;
            IN_blue_potion.BorderStyle = BorderStyle.None;
            IN_red_potion.BorderStyle = BorderStyle.None;
        }
        private void SetupAttackButtons(string weaponType)
        {
            if ("potion".Equals(weaponType.ToLower()))
            {
                a_UP.Text = "Drink";
                a_DOWN.Visible = false;
                a_RIGHT.Visible = false;
                a_LEFT.Visible = false;
            }
            if ("weapon".Equals(weaponType.ToLower()))
            {
                a_UP.Text = "^";
                a_DOWN.Visible = true;
                a_RIGHT.Visible = true;
                a_LEFT.Visible = true;
            }
        }
        private void SetPictureBoxVisibility()
        {
            sword.Visible = false;
            bow.Visible = false;
            mace.Visible = false;
            blue_potion.Visible = false;
            red_potion.Visible = false;
        }
        private void CheckPlayerInventory()
        {
            CheckPlayerWeapon("Sword", "Weapon", IN_sword);
            CheckPlayerWeapon("Bow", "Weapon", IN_bow);
            CheckPlayerWeapon("Mace", "Weapon", IN_mace);

            CheckPlayerPotion("Blue Potion", "potion", IN_blue_potion);
            CheckPlayerPotion("Red Potion", "potion", IN_red_potion);
        }

        private void CheckPlayerWeapon(string weaponName, string weaponTyp, PictureBox weaponPictureBox)
        {
            weaponPictureBox.BorderStyle = BorderStyle.None;
            if (game.CheckPlayerInventory(weaponName))
            {
                weaponPictureBox.Visible = true;
                if (game.IsWeaponEquipped(weaponName))
                {
                    weaponPictureBox.BorderStyle = BorderStyle.FixedSingle;
                    SetupAttackButtons(weaponTyp);
                }
            }
        }

        private void CheckPlayerPotion(string potionName, string weaponTyp, PictureBox weaponPictureBox)
        {
            weaponPictureBox.BorderStyle = BorderStyle.None;
            if (game.CheckPlayerInventory(potionName))
            {
                if (!game.CheckPotionUsed(potionName))
                {
                    weaponPictureBox.Visible = true;
                    if (game.IsWeaponEquipped(potionName))
                    {
                        weaponPictureBox.BorderStyle = BorderStyle.FixedSingle;
                        SetupAttackButtons(weaponTyp);
                        isPotionNeeded = true;
                    }
                }
                else
                {
                    weaponPictureBox.BorderStyle = BorderStyle.None;
                    weaponPictureBox.Visible = false;
                    if (isPotionNeeded)
                    {
                        game.Equip("Sword");
                        CheckPlayerWeapon("Sword", "Weapon", IN_sword);
                        SetupAttackButtons("weapon");
                        isPotionNeeded = false;
                    }
                }
            }

        }
        private bool UpdateEnemy(Enemy enemy, PictureBox pictureBoxEnemy, Label labelEnemyHitPoints)
        {
            bool isEnemyUpdated = false;

            labelEnemyHitPoints.Text = enemy.HitPoints.ToString();
            labelEnemyHitPoints.Visible = true;
            if (enemy.HitPoints > 0)
            {
                pictureBoxEnemy.Location = enemy.Location;
                pictureBoxEnemy.Visible = true;
                isEnemyUpdated = true;
            }
            else
            {
                pictureBoxEnemy.Visible = false;
                labelEnemyHitPoints.Visible = false;
            }

            return isEnemyUpdated;
        }
        private int CountEnemies()
        {
            int enemiesShown = 0;

            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    if (UpdateEnemy(enemy, bat, batHitPoints))
                        enemiesShown++;
                }
                if (enemy is Ghost)
                {
                    if (UpdateEnemy(enemy, ghost, ghostHitPoints))
                        enemiesShown++;
                }
                if (enemy is Ghoul)
                {
                    if (UpdateEnemy(enemy, ghoul, ghoulHitPoints))
                        enemiesShown++;
                }
            }
            return enemiesShown;
        }
        private Control SetVisibilityToWeaponInRoom(Control weaponControl)
        {
            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = sword;
                    break;
                case "Bow":
                    weaponControl = bow;
                    break;
                case "Mace":
                    weaponControl = mace;
                    break;
                case "Red Potion":
                    weaponControl = red_potion;
                    break;
                case "Blue Potion":
                    weaponControl = blue_potion;
                    break;
            }
            return weaponControl;
        }
        private void SetTheLevel()
        {
            player.BringToFront();
            bat.SendToBack();
            ghost.SendToBack();
            ghoul.SendToBack();
            bow.SendToBack();
            mace.SendToBack();
            sword.SendToBack();
            blue_potion.SendToBack();
            red_potion.SendToBack();
        }

        
    }
}
