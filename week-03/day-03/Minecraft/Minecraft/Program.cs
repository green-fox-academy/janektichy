using System;
using System.Collections.Generic;

namespace Minecraft
{
    class Program
    {
        static void Main(string[] args)
        {
            Wall wall = new Wall();
            Air air = new Air();
            Brick brick = new Brick("dark gray");
            Door door = new Door(2, "Mordor", "black", 60, true);
            Glass glass = new Glass();
            Glowstone glowstone = new Glowstone();
            Window window1 = new Window(1, "Liliput", "white", 70, true );
            Window window2 = new Window(2, "Asgard", "light gray", 90, true);
            Mud mud = new Mud();
            Gold gold = new Gold(50);
            Lava lava = new Lava();
            Glowstone glowstone2 = new Glowstone();
            Ice ice = new Ice();
            Lava lava2 = new Lava();
            Gold gold2 = new Gold(30);
            Ice ice2 = new Ice();


            wall.AddFirstBlock(air);
            wall.AddBlock(brick);
            wall.AddBlock(door);
            wall.AddBlock(glass);
            wall.AddBlock(glowstone);
            wall.AddBlock(window1);
            wall.AddBlock(window2);
            wall.AddBlock(mud);
            wall.AddBlock(gold);
            wall.AddBlock(lava);
            wall.AddBlock(glowstone2);
            wall.AddBlock(ice);
            wall.AddBlock(lava2);
            wall.AddBlock(gold2);
            wall.AddBlock(ice2);

            wall.CountWallLight();
            Console.WriteLine();
            wall.PrintWallStatus();
        }
    }
}
