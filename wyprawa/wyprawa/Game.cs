﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wyprawa
{
    class Game
    {
        //public IEnumerable<Enemy>Enemies {  get; private set; }
        public List<Enemy> Enemies;
        public Weapon WeaponInRoom { get; private set; }

        private Player player;
        public Point PlayerLocation { get { return player.Location; } }
        public int PlayerHitPoints { get{ return player.HitPoints; } }
        public IEnumerable<string> PlayerWeapons { get { return player.Weapons; } }
        private int level = 0;
        public int Level { get { return level; }  }

        private Rectangle boundaries;
        public Rectangle Boundaries { get { return boundaries;} }

        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            player = new Player(this, new Point(boundaries.Left+10, boundaries.Top+70));
        }
        public void Move(Direction direction, Random random)
        {
            player.Move(direction);
            foreach(Enemy enemy in Enemies)
            {
                enemy.Move(random);
            }
        }
        public bool CheckPotionUsed(string potionName)
        {
            return player.CheckPotionUsed(potionName);
        }
        public bool IsWeaponEquipped(string weaponName)
        {
            return player.IsWeaponEquipped(weaponName);
        }
        public void Equip(string weaponName)
        {
            player.Equip(weaponName);
        }
        public bool CheckPlayerInventory(string weaponName)
        {
            return player.Weapons.Contains(weaponName);
        }
        public void HitPlayer(int maxDamage,Random random)
        {
            player.Hit(maxDamage, random);
        }
        public void IncreasePlayerHealth(int health, Random random)
        {
            player.IncreaseHealth(health,random);
        }
        public void Attack(Direction direction, Random random)
        {
            player.Attack(direction,random);
            foreach(Enemy enemy in Enemies)
            {
                enemy.Move(random);
            }
        }
        private Point GetRandomLocation(Random random)
        {
            //int x= 30;
            //int y = 50;

            int x = boundaries.Left + random.Next(+boundaries.Right / 10 - boundaries.Left / 10) * 10;
            int y = boundaries.Top + random.Next(boundaries.Bottom / 10 - boundaries.Top / 10) * 10;
            return new Point(x, y);


            /*
            return new Point(
                boundaries.Left + random.Next(boundaries.Right / 10 - boundaries.Left / 10) * 10,
                boundaries.Top + random.Next(boundaries.Bottom / 10 - boundaries.Top / 10) * 10);
            */
        }

        public void NewLevel(Random random)
        {
            level++;
            switch(level)
            {
                case 1:
                    Enemies = new List<Enemy>() { new Bat(this, GetRandomLocation(random)) };
                    WeaponInRoom = new Sword(this, GetRandomLocation(random));
                    break;
                case 2:
                    Enemies.Clear();
                    Enemies = new List<Enemy>() { new Ghost(this, GetRandomLocation(random)) };
                    WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                    break;
                case 3:
                    Enemies.Clear();
                    Enemies = new List<Enemy>() { new Ghoul(this, GetRandomLocation(random)) };
                    WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    break;
                case 4:
                    Enemies.Clear();
                    Enemies = new List<Enemy>() { new Bat(this, GetRandomLocation(random)), new Ghost(this, GetRandomLocation(random)) };
                    if (CheckPlayerInventory("Łuk"))
                    {
                        if(!CheckPlayerInventory("Blue potion") || (CheckPlayerInventory("Blue potion") && player.CheckPotionUsed("Blue potion")))
                        {
                            WeaponInRoom = new BluePotion(this,GetRandomLocation(random));
                        }
                    }
                    else
                    {
                        WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    }
                    
                    break;
                case 5:
                    Enemies.Clear();
                    Enemies = new List<Enemy>() { new Bat(this, GetRandomLocation(random)), new Ghoul(this, GetRandomLocation(random)) };
                    WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                    break;
                case 6:
                    Enemies.Clear();
                    Enemies = new List<Enemy>() { new Ghost(this, GetRandomLocation(random)), new Ghoul(this, GetRandomLocation(random)) };
                    WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    break;
                case 7:
                    Enemies.Clear();
                    Enemies = new List<Enemy>() { new Bat(this, GetRandomLocation(random)), new Ghost(this, GetRandomLocation(random)), new Ghoul(this, GetRandomLocation(random)) };
                    if (CheckPlayerInventory("Maca"))
                    {
                        if (!CheckPlayerInventory("Red potion") || (CheckPlayerInventory("Red potion") && player.CheckPotionUsed("Red potion")))
                        {
                            WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                        }
                    }
                    else
                    {
                        WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    }
                    break;
            }
        }
        

    }
}
