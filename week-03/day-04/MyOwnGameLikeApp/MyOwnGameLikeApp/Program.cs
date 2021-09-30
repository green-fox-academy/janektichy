using System;

namespace MyOwnGameLikeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to my strategy fighting game");
            Console.WriteLine("You can pick your hero for the fight, then you will pick your opponent. You also can choose weapons for both of you, \nevery weapon and character has different qualities which may affect the result of the fight!");
            Console.WriteLine("Don't worry, I will tell you more in a second, just press 'enter', when you are ready");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("First, pick the name for your warrior (just type it below)");
            string myHeroName = Console.ReadLine();
            if (myHeroName == "")
            {
                myHeroName = "Unknown Hero";
            }
            Console.Clear();
            Console.WriteLine("Now pick the type of your warrior");
            Console.WriteLine("There are three different warrior types to choose from:");
            Console.WriteLine();
            Console.WriteLine("First one is an Ork");
            Console.WriteLine();
            Console.WriteLine("Orks are really strong, but also really stupid and slow. If you pick him, You will have 150 health and 13 power, but \nalso just 70% chance to hit your enemy and 0% chance to dodge their hit");
            Console.ReadLine();
            Console.WriteLine("Your next option is an elf");
            Console.WriteLine();
            Console.WriteLine("Elfs are not that strong, but they are fast, with elf, your health will be 100 and your power 7, but you will have \n80% chance to give a hit and 40% chance to dodge one");
            Console.ReadLine();
            Console.WriteLine("Your last option is a Dwarf");
            Console.WriteLine();
            Console.WriteLine("Dwarfs are superb in fighting, if you pick him, you will have 90% chance to give a hit with power 10!\nThey are sadly small and slow, so your chance to dodge will be just 20% and you will have only 80 health");
            Console.ReadLine();
            Console.WriteLine("What do you choose? Type in ork, dwarf or elf");
            string input = Console.ReadLine();
            while (input != "dwarf" && input != "ork" && input != "elf")
            {
                Console.WriteLine("That is not an option, type in one of the warriors please.");
                input = Console.ReadLine();
            }
            Console.WriteLine($"{input} is a good choice!");
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("Now is the time to pick your weapon");
            Console.ReadLine();
            Console.WriteLine("The first weapon you can choose is an axe");
            Console.WriteLine();
            Console.WriteLine("Axe is a heavy weapon, so it decrases your chance to dodge a hit by 5%, but also it has a wide swing, so your chance to \nhit your enemy increases by 15%. The last + of that weapon is, that it makes your power bigger by 1");
            Console.ReadLine();
            Console.WriteLine("Your second option is to pick a hammer");
            Console.WriteLine();
            Console.WriteLine("Hammer is super heavy, so it decreases your chance to dodge a hit by 15%, but it also increases your chance to give a hit by 5% and your power by 3!");
            Console.ReadLine();
            Console.WriteLine("The last option is to pick a sword");
            Console.WriteLine();
            Console.WriteLine("Sword is a simple weapon, it doesn't change anything of your warriors skills, you can pick it if you trust your warrior");
            Console.ReadLine();
            Console.WriteLine("So what will you pick? Type in the name of the weapon please (sword | hammer | axe)");
            string input2 = Console.ReadLine();
            while (input2 != "axe" && input2 != "sword" && input2 != "hammer")
            {
                Console.WriteLine("That is not an option, type in one of the weapons please.");
                input2 = Console.ReadLine();
            }
            Console.WriteLine($"Nice job to pick a {input2}, your warrior is going to be strong");
            Console.ReadLine();
            Gun myHeroWeapon;
            if (input2 == "axe")
            {
                myHeroWeapon = new Axe();
            }

            else if (input2 == "sword")
            {
                myHeroWeapon = new Sword();
            }

            else
            {
                myHeroWeapon = new Hammer();
            }


            Fighter myHero;
            if (input == "dwarf")
            {
                myHero = new Dwarf(myHeroWeapon, myHeroName);
            }
            else if (input == "ork")
            {
                myHero = new Ork(myHeroWeapon, myHeroName);
            }
            else
            {
                myHero = new Elf(myHeroWeapon, myHeroName);
            }
            Console.WriteLine("Your warrior stats look like this now:");
            myHero.ShowSkills();
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Now pick again for your opponent please, start with the name");
            string enemyName = Console.ReadLine();
            if (enemyName == "")
            {
                enemyName = "Unknown Enemy";
            }
            Console.WriteLine();
            Console.WriteLine("Now pick their warrior (ork | dwarf | elf)");
            string input3 = Console.ReadLine();
            while (input3 != "dwarf" && input3 != "ork" && input3 != "elf")
            {
                Console.WriteLine("That is not an option, type in one of the warriors please.");
                input3 = Console.ReadLine();
            }
            Console.WriteLine("Now pick the weapon for him (axe | sword | hammer)");
            string input4 = Console.ReadLine();
            while (input4 != "axe" && input4 != "sword" && input4 != "hammer")
            {
                Console.WriteLine("That is not an option, type in one of the weapons please.");
                input4 = Console.ReadLine();
            }

            Gun enemyGun;
            if (input4 == "axe")
            {
                enemyGun = new Axe();
            }

            else if (input4 == "sword")
            {
                enemyGun = new Sword();
            }

            else
            {
                enemyGun = new Hammer();
            }

            Fighter myEnemy;
            if (input == "dwarf")
            {
                myEnemy = new Dwarf(enemyGun, enemyName);
            }
            else if (input == "ork")
            {
                myEnemy = new Ork(enemyGun, enemyName);
            }
            else
            {
                myEnemy = new Elf(enemyGun, enemyName);
            }

            Console.WriteLine("Great! Your opponent stats:");
            myEnemy.ShowSkills();
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Now the fight is ready, press enter to see the result");
            Console.ReadLine();

            myHero.Fight(myEnemy);
            Console.ReadLine();
        }
       
    }
}
