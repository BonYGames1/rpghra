using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Character player = null;
            int option;
            Random r = new Random();
            HealPotion healingPotion = new HealPotion("Healing Potion", 40, 1);
            DamagePotion damagePotion = new DamagePotion("Damage Potion", 40, 1);
            bool chosen = false;
            while (chosen == false)
            {
                option = Menu();
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("*░░░░░░░░░░░░░░░░▒░░░░░░░░░░░░░░░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░░░░░░█░▓▓▓▒░░░░░░░░░░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░░░░▒█▒▓▓▓▓▓░░░░░░░░░░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░░▒▓█▒░█▓▒▓█▓░░░░░░░░░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░▓██▒▒███▓▓▓▒▒░░▒░░▒░░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░▓████▓████▓▒▒▒▓▒▒▒▒▓▒▒░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░▒▓██▓▓▓▓▓█▓▓▓▓▒▓▓█▓██▓░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░████▓▓▒▓▓▓▒▓▓▓▓▓████▓░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░█▓███▓▓█▓▓▓██▓█▓▓██▓▒░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░█████▓▓████████████▓█░░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░▓████▓▒████▓████████▓▓▒▒░░░░░░░░*");
                        Console.WriteLine("*░░░▒▒▓░▒██▓░░▒▓▓▓▓▓▓▓▓▓█████▓██▒░░░░░░░░*");
                        Console.WriteLine("*░░░▒█▓▒███▒░░▓██████▓▓▓████████▓░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░▒▒▒▓▓███▓█▓▓█▓▓▓▓████▓█░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░▒▓███▓████▓▓▓▓████▓▓█▒▒░░░░░░*");
                        Console.WriteLine("*░░░░░░░░▒▒▓███████▓████▓▓█████████░▒░░░░*");
                        Console.WriteLine("*░░░░░░░░▒▒▓███████████▓▓██████████▓█▒░░░*");
                        Console.WriteLine("*░░░░░░░░░▒▒▓███████████▓▓█████████████▒░*");
                        Console.WriteLine("*░░░░░░░░░░▒▓██████████▓▓▓███████████████*");
                        Console.WriteLine("*░░░░░░░░░░▓████████████▓█████▒░▓████████*");
                        Console.WriteLine("*░░░░░░░░░░██░████▓░███████████▒▓▓▓▓▓▓▒▒░*");
                        Console.WriteLine("*░░░░░░░░░▒▓█░████▒▒████████░░░░░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░▒░███▓░░▒█▓▒███▓░░░░░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░░▒███▒░░░▒░░░██▓░░░░░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░▒████░░░░░░░░███▒░░░░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░▓▓▓▓▓▒▒░░░░░░░░▓██▒░░░░░░░░░░░░*");
                        Console.WriteLine("You have chosen the path of the Solo as your destiny!");
                        player = new Warrior(100, 100, 15, ChoosePlayer(), "Solo", 50);
                        chosen = true;
                        Console.Clear();
                        Console.WriteLine("Your Chosen one!");
                        player.ShowStats();
                        player.Inventory.Add(healingPotion);
                        player.Inventory.Add(healingPotion);
                        player.Inventory.Add(damagePotion);
                        player.Inventory.Add(damagePotion);
                        Console.ReadKey();
                        break;
                
                    case 2:
                        Console.Clear();
                        Console.WriteLine("*░░░░░░░░▒▓▒▒▒▓██▓░░░░░░░░░░░░░░░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░▒▓▓█▓▓▒░░░░░░░▒▓▓░░░░░░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░▒▓░░░░░░░▒▒▓▓▓▓▒░░░░░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░▒▓░░░░░░▓▓▓█▓▓▓▓▒▒░░░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░▒▓░░░░░░░░▓█▓▓██▒░░░░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░░▓░░░░░░░▓▓▓▒▓▓██▓░░░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░░▓░░░░░▓▓▒░▒▒▓▓▓▓▓▓░░░▒▒▒░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░░▓░░░░▓▓▒░░▒▒▒▓▓▓▓▓▓▒▓▓░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░▒▓▒▓▓▒▓▓▓▒▒▒▒▓▓▓██▓▓▒▓░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░▒▓▓░░▒███▓▒▒▓▓▓███▓▓▓░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░░▓░░░▒███▓▓▓▓▓▓███▓▓▓░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░░▒░░░▓███▓▓▓▓▓████▓▓▓▒░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░░▒░░░▓█████▓▓▓████▓▓▓▒░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░░▒░░░▓██▓▓████▓████▓▓▒░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░░▒░░░▓█▓▓▓▓██▓▓▓▓▓█▓▓▓░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░░▒░░░▓███████▓▓▓██▓██▓░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░░▒░░░▓▓████▒▓████████▓░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░░▒░░░▓████▓░▓██████▓█▓░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░▒▒░░░█████▒░▓██████▓▒▓▒░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░▒▒░░▒█████░░▓███████▒█▓░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░▒▒░░▓████▓░░▓███████░▓▓░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░▒▒░░▓████▒░░████████▒░▓░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░▒▒░░█████░░░████████▓░▒░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░▒▒░░▓███▓░░▒▓██▓████▓░▒▒░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░▓▒░░░█▓▓▓░░▒▒▒▒▒▒░▒█▓░▒▒░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░▓▓░░▒█▒░░░░░░░░░░░░▒█▒▒▒░░░░░*");
                        Console.WriteLine("You have chosen the path of the Techie as your destiny!");
                        player = new Mage(110, 110, 20, ChoosePlayer(), "Techie");
                        chosen = true;
                        Console.Clear();
                        Console.WriteLine("Your Chosen one!");
                        player.ShowStats();
                        player.Inventory.Add(healingPotion);
                        player.Inventory.Add(healingPotion);
                        player.Inventory.Add(damagePotion);
                        player.Inventory.Add(damagePotion);
                        Console.ReadKey();
                        break;
                
                    case 3:
                        Console.Clear();
                        Console.WriteLine("*░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░░░░░░░░░░░░░░▒░░░░░░░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░░░░░░░░░░░░░▒▒░░░░░░░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░░░░░░░▒▒▒▒░░▒░░░░░░░░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░░░░░░░▓██▒▒▒░░▒▒░░░░░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░▒▒▒▒▒▒▒▒░█▓█▓▓▓▒░░░░░░░░░░░░░░░░*");
                        Console.WriteLine("*░░░░░▒▓▒▓█▓▓▓▓█▓██▒▒▓▓▓█▓░░░░░░░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░░▒▓▓▓▒▒▓▓░▒▓▓▓▒░░░░░░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░░░░▒▒▓▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░░░░░▒██████▓▓▒▒░░░░░░░░▒▒░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░░░░░░▓███████▒░░░░░░▒▓▒░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░░░░░▒█▓▓████▓▓▒░▒▒▓▓▒░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░░░░▓██▓███████▓▒▒░░░░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░░░▒▓██▓██▓█▓▓█▓░░░░░░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░▒▓▓██████▓████▓░░░░░░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░▓█████▓█▓▓████▓░░░░░░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░▓██▓███████████▓▒░░░░░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░▓██░░███▒▒███████▓░░░░░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░▒██░░░▓██░░████████▓░░░░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░██▓░░░░█▓░░▒█▓██████▓░░░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░█▓░░░░░▒▓░░░▓░░▒▓▓███░░░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░▒▓░░░░░░░░░░░░░░░░░░▓█▓░░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░█▓░░░░░░░░░░░░░░░░░░░▓█▒░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░▓▓░░░░░░░░░░░░░░░░░░░░░▓█░░░░░░░░░*");
                        Console.WriteLine("*░░░░░░▒░░░░░░░░░░░░░░░░░░░░░░░▒▓░░░░░░░░*");
                        Console.WriteLine("*░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█▒░░░░░░░*");
                        Console.WriteLine("You have chosen the path of the Netrunner as your destiny!");
                        player = new Assassin(80, 80, 25, ChoosePlayer(), "Netrunner");
                        chosen = true;
                        Console.Clear();
                        Console.WriteLine("Your Chosen one!");
                        player.ShowStats();
                        player.Inventory.Add(healingPotion);
                        player.Inventory.Add(healingPotion);
                        player.Inventory.Add(damagePotion);
                        player.Inventory.Add(damagePotion);
                        Console.ReadKey();
                        break;
                
                    default:
                        Console.Clear();
                        Console.WriteLine("                                               Try to type 1 or 2 or 3!");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            }

            Console.WriteLine("Your Journey is about to start!");
            Console.ReadKey();
            Console.WriteLine("You have woken up after 53 years of cryo sleep.");
            Console.ReadKey();
            Console.WriteLine("It is now the year 2177");
            Console.ReadKey();
            Console.WriteLine("You look around and see other cryopods.");
            Console.ReadKey();
            Console.WriteLine("They are unopened...");
            Console.ReadKey();
            Console.WriteLine("");
            int y = 0;
            while (y == 0)
            {
                Console.WriteLine("Would you like to open them?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                try
                {
                    y = int.Parse(Console.ReadLine());
                }
                catch (FormatException) { Console.WriteLine("Try to type 1 or 2!"); }
                Console.Clear();
            }
            bool enemyDefeated = false;
            switch (y)
            {
                case 1://*****************************************************************************************************************************open the cryopod
                    Console.WriteLine("You approach the first console panel.");
                    Console.ReadKey();
                    Console.WriteLine("And place your hand on the sensor.");
                    Console.ReadKey();
                    Console.WriteLine("Smoke comes from the machine.");
                    Console.ReadKey();
                    Console.WriteLine("And you see a strange body coming towards you!");
                    Console.ReadKey();
                    Console.WriteLine("");
                    y = 0;
                    while (y == 0)
                    {
                        Console.WriteLine("What do you want to do?");
                        Console.WriteLine("1. Attack the creature");
                        Console.WriteLine("2. Run away!");
                        try
                        {
                            y = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException) { Console.WriteLine("Try to type 1 or 2!"); }
                        Console.Clear();
                    }
                    switch (y)
                    {
                        case 1://*****************************************************************************************************************************attack
                            Console.WriteLine("You have decided to attack the creature");
                            Console.ReadKey();
                            Console.WriteLine("It doesn't seem to be life threatening after the smoke has worn off.");
                            Console.WriteLine("");
                            AttackFunc(player, new Character(80, 80, r.Next(10,20), "Strange Creature", "Human"), 10, 20);
                            Console.Clear();
                            player.Inventory.Add(healingPotion);
                            player.Inventory.Add(damagePotion);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You have received 1 Healing Potion and 1 Damage Potion!");
                            Console.ResetColor();
                            Console.ReadKey();
                            Console.WriteLine("You see a HoloChip on the creatures head.");
                            Console.ReadKey();
                            Console.Write("You have equipped it, saying ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("+15 damage");
                            player.Damage += 15;
                            Console.ResetColor();
                            Console.ReadKey();
                            enemyDefeated = true;
                            break;
                        case 2://*****************************************************************************************************************************run away
                            Console.WriteLine("What a foolish decision to run away from the creature!");
                            Console.ReadKey();
                            Console.WriteLine("Unfortunately for you, there is only one way from this room.");
                            Console.ReadKey();
                            Console.WriteLine("Which is currently locked...");
                            Console.ReadKey();
                            Console.WriteLine("You don't have another option than to attack it.");
                            Console.WriteLine("");
                            AttackFunc(player, new Character(100, 100, r.Next(20, 30), "Strange Creature", "Human"), 20, 30);
                            Console.Clear();
                            player.Inventory.Add(healingPotion);
                            player.Inventory.Add(damagePotion);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You have received 1 Healing Potion and 1 Damage Potion!");
                            Console.ResetColor();
                            Console.ReadKey();
                            Console.WriteLine("You see a HoloChip on the creatures head.");
                            Console.ReadKey();
                            Console.Write("You have equipped it, saying ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("+10 damage");
                            player.Damage += 10;
                            Console.ResetColor();
                            Console.ReadKey();
                            enemyDefeated = true;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Try to type 1 or 2!");
                            Console.ReadKey();
                            break;
                    }
                    break;
                case 2://*****************************************************************************************************************************not open the cryopod
                    Console.WriteLine("You decided to not open the cryopod.");
                    Console.ReadKey();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Try to type 1 or 2!");
                    Console.ReadKey();
                    break;
            }
            Console.Clear();
            if (enemyDefeated == true)
            {
                Console.WriteLine("This was a rather strange encounter!");
                Console.ReadKey();
                Console.WriteLine("But you were able to defeat it and retrieve a new HoloChip upgrade!");
                Console.ReadKey();
                Console.WriteLine("You don't want to open any other cryopods.");
                Console.ReadKey();
            }
            Console.WriteLine("Instead you go to check the locked door.");
            Console.ReadKey();
            Console.WriteLine("You see a card reader as an opening mechanism.");
            Console.ReadKey();
            Console.WriteLine("You have to look around for some kind of keycard.");
            Console.ReadKey();
            Console.WriteLine("");
            bool boxes = false;
            bool meds = false;
            bool vent = false;
            bool desk = false;
            int i = 0;
            while (i != 4 || (boxes == false && meds == false && vent == false && desk == false))
            {
                y = 0;
                while (y == 0)
                {
                    Console.WriteLine("Which part of the room do you want to check?");
                    Console.WriteLine("1. Pile of metal boxes.");
                    Console.WriteLine("2. Medical cabinet.");
                    Console.WriteLine("3. Half broken vent shaft.");
                    Console.WriteLine("4. Some sort of office desk.");
                    try
                    {
                        y = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException) { Console.WriteLine("Try to type 1,2,3 or 4!"); }
                    Console.Clear();
                }
                switch (y)
                {
                    case 1://*****************************************************************************************************************************METAL BOXES
                        if (boxes == false)
                        {
                            Console.WriteLine("You went to check the contents of those metal boxes.");
                            Console.ReadKey();
                            Console.WriteLine("You really can't see anything useful in there.");
                            Console.ReadKey();
                            Console.WriteLine("Suddenly a whole bunch of Robotic Bugs jumps on your face.");
                            Console.ReadKey();
                            Console.WriteLine("They are trying to hack into your HoloChip!");
                            Console.ReadKey();
                            Console.WriteLine("");
                            y = 0;
                            while (y == 0)
                            {
                                Console.WriteLine("You have to do something!");
                                Console.WriteLine("1. Wipe them of off your face.");
                                Console.WriteLine("2. Find a control point and try to hack yourself in.");
                                Console.WriteLine("3. Smash them into the ground.");
                                try
                                {
                                    y = int.Parse(Console.ReadLine());
                                }
                                catch (FormatException) { Console.WriteLine("Try to type 1,2 or 3!"); }
                                Console.Clear();
                            }
                            switch (y)
                            {
                                case 1://*****************************************************************************************************************************WIPE THE BUGS
                                    Console.WriteLine("You tried to wipe them off, but they are actually quite strong.");
                                    Console.ReadKey();
                                    Console.WriteLine("You have to apply force!");
                                    Console.ReadKey();
                                    Console.WriteLine("");
                                    AttackFunc(player, new Character(200, 200, r.Next(20, 40), "Horde of Robotic Bugs", "Nanobots"), 20, 40);
                                    player.Inventory.Add(healingPotion);
                                    player.Inventory.Add(damagePotion);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("You have received 1 Healing Potion and 1 Damage Potion!");
                                    Console.ResetColor();
                                    Console.ReadKey();
                                    if (player.ClassName == "Solo")
                                    {
                                        Console.WriteLine("As a Solo you were able to salvage some parts from them.");
                                        Console.ReadKey();
                                        Console.Write("You have upgraded your HoloChip for ");
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write("+20 damage ");
                                        Console.ResetColor();
                                        Console.Write("and ");
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("10HP");
                                        Console.ResetColor();
                                        player.Damage += 20;
                                        player.Health += 10;
                                        Console.ReadKey();
                                    }
                                    Console.Clear();
                                    break;
                                case 2://*****************************************************************************************************************************HACK THEM
                                    Console.WriteLine("You tried to hack and reprogram them to your side.");
                                    Console.ReadKey();
                                    if (player.ClassName == "Netrunner")
                                    {
                                        Console.WriteLine("You had enough knowledge to do so!");
                                        Console.ReadKey();
                                        Console.Write("They account as another ");
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write("+15 damage ");
                                        Console.ResetColor();
                                        Console.Write("and ");
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("20HP");
                                        Console.ResetColor();
                                        player.Damage += 15;
                                        player.Health += 20;
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        Console.WriteLine("You don't have the necessary Netrunner knowledge to do so.");
                                        Console.ReadKey();
                                        Console.WriteLine("The only choice left for you is to attack them.");
                                        Console.ReadKey();
                                        Console.WriteLine("");
                                        AttackFunc(player, new Character(200, 200, r.Next(20, 40), "Horde of Robotic Bugs", "Nanobots"), 20, 40);
                                        player.Inventory.Add(healingPotion);
                                        player.Inventory.Add(damagePotion);
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("You have received 1 Healing Potion and 1 Damage Potion!");
                                        Console.ResetColor();
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    break;
                                case 3://*****************************************************************************************************************************SMASH THEM
                                    Console.WriteLine("You chose to stomp them into the ground.");
                                    Console.ReadKey();
                                    Console.WriteLine("But they resisted.");
                                    Console.ReadKey();
                                    Console.WriteLine("You need to fight!");
                                    Console.ReadKey();
                                    Console.WriteLine("");
                                    AttackFunc(player, new Character(200, 200, r.Next(20, 40), "Horde of Robotic Bugs", "Nanobots"), 20, 40);
                                    player.Inventory.Add(healingPotion);
                                    player.Inventory.Add(damagePotion);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("You have received 1 Healing Potion and 1 Damage Potion!");
                                    Console.ResetColor();
                                    Console.ReadKey();
                                    if (player.ClassName == "Techie")
                                    {
                                        Console.WriteLine("As a Techie you were able to salvage some parts from them.");
                                        Console.ReadKey();
                                        Console.Write("You have upgraded your HoloChip for ");
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write("+10 damage ");
                                        Console.ResetColor();
                                        Console.Write("and ");
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("25HP");
                                        Console.ResetColor();
                                        player.Damage += 10;
                                        player.Health += 25;
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    Console.Clear();
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("Try to type 1,2 or 3!");
                                    Console.ReadKey();
                                    break;
                            }
                            boxes = true;
                            i++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You have already been there.");
                            Console.ResetColor();
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 2://*****************************************************************************************************************************MEDICAL CABINET
                        if (meds == false)
                        {
                            Console.WriteLine("You opened the cabinet.");
                            Console.ReadKey();
                            Console.WriteLine("There is a bunch of different meds lying everywhere.");
                            Console.ReadKey();
                            player.Inventory.Add(healingPotion);
                            player.Inventory.Add(healingPotion);
                            player.MaxHealth += 50;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You have received 2 Healing Potions!");
                            Console.ResetColor();
                            Console.ReadKey();
                            Console.WriteLine("But you heard some disturbing noise behind you.");
                            Console.ReadKey();
                            Console.WriteLine("You slowly turn around.");
                            Console.ReadKey();
                            Console.WriteLine("And see a tall black creature with metal head and glowing red eyes.");
                            Console.ReadKey();
                            Console.WriteLine("There isn't any other option then to face it.");
                            Console.ReadKey();
                            Console.WriteLine("");
                            AttackFunc(player, new Character(280, 280, r.Next(50, 80), "Metal Creature with glowing eyes", "Metal Humans"), 50, 80);
                            player.Inventory.Add(damagePotion);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You see a Damage Potion in his pocket!");
                            Console.ResetColor();
                            Console.ReadKey();
                            Console.Clear();
                            meds = true;
                            i++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You have already been there.");
                            Console.ResetColor();
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Try to type 1,2,3 or 4!");
                        Console.ReadKey();
                        break;
                    case 3://*****************************************************************************************************************************VENT SHAFT
                        if (vent == false)
                        {
                            Console.WriteLine("You decided to check the vent shaft system.");
                            Console.ReadKey();
                            Console.WriteLine("It has sustained severe damage.");
                            Console.ReadKey();
                            Console.WriteLine("You can partialy see the contents inside the vent.");
                            Console.ReadKey();
                            Console.WriteLine("There seem to be some red object of some sort.");
                            Console.ReadKey();
                            if (player.ClassName == "Techie")
                            {
                                Console.WriteLine("You have enough technical skills to force your way inside.");
                                Console.ReadKey();
                                Console.WriteLine("You have encountered a Big Sus Amogus.");
                                Console.ReadKey();
                                Console.WriteLine("");
                                AttackFunc(player, new Character(350, 350, r.Next(100, 120), "Big Sus Amogus", "Unidentified Impostors"), 100, 120);
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("But you are not able to get to it, maybe if you had some technical skills, you could force your way in.");
                                Console.ReadKey();
                                Console.WriteLine("You haven't found the keycard here.");
                                Console.Clear();
                            }
                            vent = true;
                            i++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You have already been there.");
                            Console.ResetColor();
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 4://*****************************************************************************************************************************OFFICE DESK
                        if (desk == false)
                        {
                            Console.WriteLine("You went to search through the office desk.");
                            Console.ReadKey();
                            Console.WriteLine("There seem to be a bunch of drawers.");
                            Console.ReadKey();
                            Console.WriteLine("But one is slightly opened.");
                            Console.ReadKey();
                            Console.WriteLine("");
                            y = 0;
                            while (y == 0)
                            {
                                Console.WriteLine("Are you sure you want to check the contents of it?");
                                Console.WriteLine("1. Yes, what could probably happen?");
                                Console.WriteLine("2. No, I am scared of drawers.");
                                Console.WriteLine("3. Slowly peek inside.");
                                try
                                {
                                    y = int.Parse(Console.ReadLine());
                                }
                                catch (FormatException) { Console.WriteLine("Try to type 1,2 or 3!"); }
                                Console.Clear();
                            }
                            switch (y)
                            {
                                case 1://*****************************************************************************************************************************OPEN DRAWER
                                    Console.WriteLine("You open the drawer without thinking.");
                                    Console.ReadKey();
                                    Console.WriteLine("You see the keycard just lying there.");
                                    Console.ReadKey();
                                    Console.WriteLine("But an but unbelievably loud alarm sets itself on.");
                                    Console.ReadKey();
                                    Console.WriteLine("Instantly closing all windows, and shuting all lights out.");
                                    Console.ReadKey();
                                    Console.WriteLine("Only a red alarm light is blinking, iluminating the whole room every two seconds.");
                                    Console.ReadKey();
                                    break;
                                case 2://*****************************************************************************************************************************DON'T OPEN DRAWER
                                    y = 0;
                                    while (y == 0)
                                    {
                                        Console.WriteLine("Don't be a coward, are you really that scared of drawers?");
                                        Console.WriteLine("1. Yes, I am.");
                                        Console.WriteLine("2. No, I will open it.");
                                        try
                                        {
                                            y = int.Parse(Console.ReadLine());
                                        }
                                        catch (FormatException) { Console.WriteLine("Try to type 1 or 2!"); }
                                        Console.Clear();
                                    }
                                    switch (y)
                                    {
                                        case 1://*****************************************************************************************************************************COWARD
                                            y = 0;
                                            while (y == 0)
                                            {
                                                Console.WriteLine("OPEN THE DAMNED DRAWER!");
                                                Console.WriteLine("1. Okay");
                                                Console.WriteLine("2. Okay");
                                                Console.WriteLine("3. Okay");
                                                try
                                                {
                                                    y = int.Parse(Console.ReadLine());
                                                }
                                                catch (FormatException) { Console.WriteLine("Try to type 1,2 or 3!"); }
                                                Console.Clear();
                                            }
                                            switch (y)
                                            {
                                                case 1:
                                                    Console.WriteLine("Good job, you opened the drawer!");
                                                    Console.ReadKey();
                                                    Console.WriteLine("But an but unbelievably loud alarm sets itself on.");
                                                    Console.ReadKey();
                                                    Console.WriteLine("Instantly closing all windows, and shuting all lights out.");
                                                    Console.ReadKey();
                                                    Console.WriteLine("Only a red alarm light is blinking, iluminating the whole room every two seconds.");
                                                    Console.ReadKey();
                                                    Console.WriteLine("What a foolish decision to trust me.");
                                                    Console.ReadKey();
                                                    break;
                                                case 2:
                                                    Console.WriteLine("Good job, you opened the drawer!");
                                                    Console.ReadKey();
                                                    Console.WriteLine("But an but unbelievably loud alarm sets itself on.");
                                                    Console.ReadKey();
                                                    Console.WriteLine("Instantly closing all windows, and shuting all lights out.");
                                                    Console.ReadKey();
                                                    Console.WriteLine("Only a red alarm light is blinking, iluminating the whole room every two seconds.");
                                                    Console.ReadKey();
                                                    Console.WriteLine("What a foolish decision to trust me.");
                                                    Console.ReadKey();
                                                    break;
                                                case 3:
                                                    Console.WriteLine("Good job, you opened the drawer!");
                                                    Console.ReadKey();
                                                    Console.WriteLine("But an but unbelievably loud alarm sets itself on.");
                                                    Console.ReadKey();
                                                    Console.WriteLine("Instantly closing all windows, and shuting all lights out.");
                                                    Console.ReadKey();
                                                    Console.WriteLine("Only a red alarm light is blinking, iluminating the whole room every two seconds.");
                                                    Console.ReadKey();
                                                    Console.WriteLine("What a foolish decision to trust me.");
                                                    Console.ReadKey();
                                                    break;
                                                default:
                                                    Console.Clear();
                                                    Console.WriteLine("Try to type 1,2 or 3!");
                                                    Console.ReadKey();
                                                    break;
                                            }
                                            break;
                                        case 2://*****************************************************************************************************************************OPEN
                                            Console.WriteLine("You opened the drawer!");
                                            Console.ReadKey();
                                            Console.WriteLine("But an but unbelievably loud alarm sets itself on.");
                                            Console.ReadKey();
                                            Console.WriteLine("Instantly closing all windows, and shuting all lights out.");
                                            Console.ReadKey();
                                            Console.WriteLine("Only a red alarm light is blinking, iluminating the whole room every two seconds.");
                                            Console.ReadKey();
                                            break;
                                        default:
                                            break;
                                    }

                                    break;
                                case 3://*****************************************************************************************************************************PEEK INSIDE DRAWER
                                    Console.WriteLine("You peek inside the drawer.");
                                    Console.ReadKey();
                                    Console.WriteLine("There lies the keycard.");
                                    Console.ReadKey();
                                    Console.WriteLine("But you notice there is a cable connected to some sort of device.");
                                    Console.ReadKey();
                                    Console.WriteLine("You use your HoloChip and realize that it is an alarm fuse.");
                                    Console.ReadKey();
                                    if (player.ClassName == "Netrunner")
                                    {
                                        Console.WriteLine("As an Netrunner, you are able to set it off and take the keycard");
                                    }
                                    else
                                    {
                                        Console.WriteLine("You can kind of see where the trigger is.");
                                        Console.ReadKey();
                                        Console.WriteLine("So you slowly place your hand inside the drawer.");
                                        Console.ReadKey();
                                        Console.WriteLine("And pick up the keycard.");
                                        Console.ReadKey();
                                        Console.WriteLine("But you accidentally touched the cable.");
                                        Console.ReadKey();
                                        Console.WriteLine("And unbelievably loud alarm sets itself on.");
                                        Console.ReadKey();
                                        Console.WriteLine("Instantly closing all windows, and shuting all lights out.");
                                        Console.ReadKey();
                                        Console.WriteLine("Only a red alarm light is blinking, iluminating the whole room every two seconds.");
                                        Console.ReadKey();
                                    }
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("Try to type 1,2 or 3!");
                                    Console.ReadKey();
                                    break;
                            }
                            desk = true;
                            i++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You have already been there.");
                            Console.ResetColor();
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                } 
            }
            if (player.ClassName == "Netrunner")
            {
                Console.Clear();
                Console.WriteLine("Since you haven't raised any alarm, you are able to silently open the door and leave.");
                Console.ReadKey();
                Console.WriteLine("Good job, you have finished the game as an Netrunner!");
                Console.ReadKey();
                Console.WriteLine("Successfully avoiding the final boss!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Are you ready for a bossfight?");
                Console.ReadKey();
                Console.WriteLine("I believe you are!");
                Console.ReadKey();
                Console.WriteLine("Since the alarm has been raised, reinforcements have arrived with Petr Lelovski as their leader.");
                Console.ReadKey();
                Console.WriteLine("You need to defeat them!");
                Console.ReadKey();
                Console.WriteLine("Defeat the first trooper!");
                Console.ReadKey();
                AttackFunc(player, new Character(150, 150, r.Next(80, 100), "Troop Number #0641", "Police Reinforcement"), 80, 100);
                player.Inventory.Add(healingPotion);
                player.Inventory.Add(damagePotion);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You have received 1 Healing Potion and 1 Damage Potion!");
                Console.ResetColor();
                Console.ReadKey();
                Console.WriteLine("Defeat the second trooper!");
                Console.ReadKey();
                AttackFunc(player, new Character(150, 150, r.Next(85, 110), "Troop Number #1601", "Police Reinforcement"), 85, 110);
                Console.WriteLine("Defeat the third trooper!");
                Console.ReadKey();
                AttackFunc(player, new Character(150, 150, r.Next(90, 120), "Troop Number #0047", "Police Reinforcement"), 90, 120);
                player.Inventory.Add(healingPotion);
                player.Inventory.Add(damagePotion);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You have received 1 Healing Potion and 1 Damage Potion!");
                Console.ResetColor();
                Console.ReadKey();
                Console.WriteLine("And now on the leader himself!");
                Console.ReadKey();
                AttackFunc(player, new Character(500, 500, r.Next(120, 140), "Petr Lelovski", "Human"), 120, 140);
                Console.WriteLine("Good job, you have successfully beaten the final boss!");
                Console.ReadKey();
                Console.WriteLine("You can now explore the whole city of HoloDome!");
                Console.ReadKey();
                Console.WriteLine("You have to know how did you get into the cryopod.");
                Console.ReadKey();
                Console.WriteLine("But that's only up to you now!");
                Console.ReadKey();
                Console.Clear();
                Environment.Exit(0);
            }
        }
        static int Menu()
        {
            int option = 0;
            Console.WriteLine("                                               SELECT YOUR CLASS!");
            Console.WriteLine("");
            Console.WriteLine("           1. Solo                                2. Techie                         3. Netrunner");
            Console.WriteLine("************************************************************************************************************");
            Console.WriteLine("░░░░░░░░░░░░░░▒░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▓▒▒▒▓██▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░░░░░░░░█░▓▓▓▒░░░░░░░░░░░░░░░░░░░░░░░▒▓▓█▓▓▒░░░░░░░▒▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░░░░░░▒█▒▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░▒▓░░░░░░░▒▒▓▓▓▓▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░░░░▒▓█▒░█▓▒▓█▓░░░░░░░░░░░░░░░░░░░░░░░░▒▓░░░░░░▓▓▓█▓▓▓▓▒▒░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒░░▒░░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░░░▓██▒▒███▓▓▓▒▒░░▒░░▒░░░░░░░░░░░░░░░░░▒▓░░░░░░░░▓█▓▓██▒░░░░░░░░░░░░░░░░░░░░░░░░░░▓██▒▒▒░░▒▒░░░░░░░░░░");
            Console.WriteLine("░░░░░░░░▓████▓████▓▒▒▒▓▒▒▒▒▓▒▒░░░░░░░░░░░░░░░░▓░░░░░░░▓▓▓▒▓▓██▓░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒░█▓█▓▓▓▒░░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░▒▓██▓▓▓▓▓█▓▓▓▓▒▓▓█▓██▓░░░░░░░░░░░░░░░░░▓░░░░░▓▓▒░▒▒▓▓▓▓▓▓░░░▒▒▒░░░░░░▒▓▒▓█▓▓▓▓█▓██▒▒▓▓▓█▓░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░░████▓▓▒▓▓▓▒▓▓▓▓▓████▓░░░░░░░░░░░░░░░░░▓░░░░▓▓▒░░▒▒▒▓▓▓▓▓▓▒▓▓░░░░░░░░░░░░░░░▒▓▓▓▒▒▓▓░▒▓▓▓▒░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░░█▓███▓▓█▓▓▓██▓█▓▓██▓▒░░░░░░░░░░░░░░░░▒▓▒▓▓▒▓▓▓▒▒▒▒▓▓▓██▓▓▒▓░░░░░░░░░░░░░░░░░░▒▒▓▓▓▓▓▓▓▓▓░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░█████▓▓████████████▓█░░░░░░░░░░░░░░░░░▒▓▓░░▒███▓▒▒▓▓▓███▓▓▓░░░░░░░░░░░░░░░░░░░░▒██████▓▓▒▒░░░░░░░░▒▒░");
            Console.WriteLine("░░░░░░▓████▓▒████▓████████▓▓▒▒░░░░░░░░░░░░░░░░▓░░░▒███▓▓▓▓▓▓███▓▓▓░░░░░░░░░░░░░░░░░░░░░▓███████▒░░░░░░▒▓▒░░░");
            Console.WriteLine("░▒▒▓░▒██▓░░▒▓▓▓▓▓▓▓▓▓█████▓██▒░░░░░░░░░░░░░░░░▒░░░▓███▓▓▓▓▓████▓▓▓▒░░░░░░░░░░░░░░░░░░░▒█▓▓████▓▓▒░▒▒▓▓▒░░░░░");
            Console.WriteLine("░▒█▓▒███▒░░▓██████▓▓▓████████▓░░░░░░░░░░░░░░░░▒░░░▓█████▓▓▓████▓▓▓▒░░░░░░░░░░░░░░░░░░▓██▓███████▓▒▒░░░░░░░░░");
            Console.WriteLine("░░░░░░▒▒▒▓▓███▓█▓▓█▓▓▓▓████▓█░░░░░░░░░░░░░░░░░▒░░░▓██▓▓████▓████▓▓▒░░░░░░░░░░░░░░░░░▒▓██▓██▓█▓▓█▓░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░░░▒▓███▓████▓▓▓▓████▓▓█▒▒░░░░░░░░░░░░░░▒░░░▓█▓▓▓▓██▓▓▓▓▓█▓▓▓░░░░░░░░░░░░░░░▒▓▓██████▓████▓░░░░░░░░░░░");
            Console.WriteLine("░░░░░░▒▒▓███████▓████▓▓█████████░▒░░░░░░░░░░░░▒░░░▓███████▓▓▓██▓██▓░░░░░░░░░░░░░░░▓█████▓█▓▓████▓░░░░░░░░░░░");
            Console.WriteLine("░░░░░░▒▒▓███████████▓▓██████████▓█▒░░░░░░░░░░░▒░░░▓▓████▒▓████████▓░░░░░░░░░░░░░░▓██▓███████████▓▒░░░░░░░░░░");
            Console.WriteLine("░░░░░░░▒▒▓███████████▓▓█████████████▒░░░░░░░░░▒░░░▓████▓░▓██████▓█▓░░░░░░░░░░░░░▓██░░███▒▒███████▓░░░░░░░░░░");
            Console.WriteLine("░░░░░░░░▒▓██████████▓▓▓███████████████░░░░░░░▒▒░░░█████▒░▓██████▓▒▓▒░░░░░░░░░░░▒██░░░▓██░░████████▓░░░░░░░░░");
            Console.WriteLine("░░░░░░░░▓████████████▓█████▒░▓████████░░░░░░░▒▒░░▒█████░░▓███████▒█▓░░░░░░░░░░░██▓░░░░█▓░░▒█▓██████▓░░░░░░░░");
            Console.WriteLine("░░░░░░░░██░████▓░███████████▒▓▓▓▓▓▓▒▒░░░░░░░░▒▒░░▓████▓░░▓███████░▓▓░░░░░░░░░░░█▓░░░░░▒▓░░░▓░░▒▓▓███░░░░░░░░");
            Console.WriteLine("░░░░░░░▒▓█░████▒▒████████░░░░░░░░░░░░░░░░░░░░▒▒░░▓████▒░░████████▒░▓░░░░░░░░░░▒▓░░░░░░░░░░░░░░░░░░▓█▓░░░░░░░");
            Console.WriteLine("░░░░░░░░░▒░███▓░░▒█▓▒███▓░░░░░░░░░░░░░░░░░░░░▒▒░░█████░░░████████▓░▒░░░░░░░░░░█▓░░░░░░░░░░░░░░░░░░░▓█▒░░░░░░");
            Console.WriteLine("░░░░░░░░░░▒███▒░░░▒░░░██▓░░░░░░░░░░░░░░░░░░░░▒▒░░▓███▓░░▒▓██▓████▓░▒▒░░░░░░░░▓▓░░░░░░░░░░░░░░░░░░░░░▓█░░░░░░");
            Console.WriteLine("░░░░░░░░░▒████░░░░░░░░███▒░░░░░░░░░░░░░░░░░░░▓▒░░░█▓▓▓░░▒▒▒▒▒▒░▒█▓░▒▒░░░░░░░░▒░░░░░░░░░░░░░░░░░░░░░░░▒▓░░░░░");
            Console.WriteLine("░░░░░░░▓▓▓▓▓▒▒░░░░░░░░▓██▒░░░░░░░░░░░░░░░░░░░▓▓░░▒█▒░░░░░░░░░░░░▒█▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█▒░░░░");
            Console.WriteLine("************************************************************************************************************");
            Console.Write("                                               Type your selection: ");
            try
            {
                option = int.Parse(Console.ReadLine());
                return option;
            }
            catch(FormatException){}
            return option;
        }
        static int AttackMenu()
        {
            int x = 0;
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Use Item");
            Console.WriteLine("3. Use Special Ability");
            Console.WriteLine("4. Show your stats");
            Console.WriteLine("5. Show enemy stats");
            try
            {
                x = int.Parse(Console.ReadLine());
                return x;
            }
            catch (FormatException) { }
            return x;
        }
        static void AttackFunc(Character player, Character enemy, int min, int max)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You have encountered " + enemy.Name);
            Console.ResetColor();
            Random r = new Random();
            bool killed = false;
            bool special = false;
            while (killed == false)
            {
                switch (AttackMenu())
                {
                    case 1:
                        if (player.Health > 0)
                        {
                            player.Attack(enemy);
                            Console.Write("You have dealt ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("{0} damage", player.Damage);
                            Console.ResetColor();
                            Console.Write(", ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("{0} ", enemy.Name);
                            Console.ResetColor();
                            Console.Write("has ");
                            if (enemy.Health <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("0HP ", enemy.Health);
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("{0}HP ", enemy.Health);
                                Console.ResetColor();
                            }
                            Console.WriteLine("left ");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You have been slain by {0}", enemy.Name);
                            Console.ResetColor();
                            if (special == true)
                            {
                                player.ResetAbility();
                            }
                            killed = true;
                            Console.ReadKey();
                            Console.WriteLine("You are really bad.");
                            Console.ReadKey();
                            Console.WriteLine("lol");
                            Console.ReadKey();
                            Console.WriteLine("noob");
                            Console.ReadKey();
                            Console.WriteLine("ඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞ");
                            Console.ReadKey();
                            Console.WriteLine("ඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞ");
                            Console.ReadKey();
                            Console.WriteLine("ඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞ");
                            Console.ReadKey();
                            Console.WriteLine("ඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞ");
                            Console.ReadKey();
                            Console.WriteLine("ඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞ");
                            Console.ReadKey();
                            Console.WriteLine("ඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞ");
                            Console.ReadKey();
                            Console.WriteLine("ඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞ");
                            Console.ReadKey();
                            Console.WriteLine("ඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞ");
                            Console.ReadKey();
                            Console.WriteLine("ඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞ");
                            Console.ReadKey();
                            Console.WriteLine("ඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞ");
                            Console.ReadKey();
                            Console.WriteLine("ඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞ");
                            Console.ReadKey();
                            Console.WriteLine("ඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞ");
                            Console.ReadKey();
                            Console.WriteLine("ඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞ");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        if (enemy.Health > 0)
                        {
                            enemy.Damage = r.Next(min, max);
                            enemy.Attack(player);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("{0} ", enemy.Name);
                            Console.ResetColor();
                            Console.Write("has dealt ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("{0} damage ", enemy.Damage);
                            Console.ResetColor();
                            Console.Write(" to you, you now have ");
                            if (player.Health <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("0HP");
                                Console.ResetColor();
                                killed = true;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("{0}HP", player.Health);
                                Console.ResetColor();
                            }
                            Console.WriteLine(" left");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You have defeated {0}", enemy.Name);
                            Console.ResetColor();
                            if (special == true)
                            {
                                player.ResetAbility();
                            }
                            killed = true;
                            Console.ReadKey();
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        int y = 0;
                        while (y == 0)
                        {
                            Console.WriteLine("Your Inventory:");
                            if (player.Inventory.FindAll(item => item.Name == "Healing Potion").Count == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You don't have any other healing potions left!");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine("1. Healing potions: Amount = " + player.Inventory.FindAll(item => item.Name == "Healing Potion").Count);
                            }
                            if (player.Inventory.FindAll(item => item.Name == "Damage Potion").Count == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You don't have any other damage potions left!");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine("2. Damage potions: Amount = " + player.Inventory.FindAll(item => item.Name == "Damage Potion").Count);
                            }
                            Console.WriteLine("3. Back");
                            try
                            {
                                y = int.Parse(Console.ReadLine());
                            }
                            catch (FormatException) { Console.WriteLine("Try to type 1 or 2!"); }
                            Console.Clear();
                        }
                        switch (y)
                        {
                            case 1:
                                if (player.Inventory.FindAll(item => item.Name == "Healing Potion").Count > 0)
                                {
                                    Item pot = player.Inventory.Find(item => item.Name == "Healing Potion");
                                    pot.HealPot(player);
                                    Console.WriteLine("You have used Healing Potion!");
                                    player.Inventory.Remove(pot);
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                break;
                            case 2:
                                if (player.Inventory.FindAll(item => item.Name == "Damage Potion").Count > 0)
                                {
                                    Item pot = player.Inventory.Find(item => item.Name == "Damage Potion");
                                    pot.DamagePot(player);
                                    Console.WriteLine("You have used Damage Potion!");
                                    player.Inventory.Remove(pot);
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                break;
                            case 3:
                                break;
                            default:
                                break;
                        }
                        break;
                    case 3:
                        Console.Clear();
                        player.Special();
                        special = true;
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        player.ShowStats();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        enemy.ShowStats();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }

        static string ChoosePlayer()
        {
            Console.WriteLine("How should the Gods call you?");
            Console.Write(": ");
            string name = Console.ReadLine();
            return name;
        }
    }
    class Character
    {
        public float Health { get; set; }
        public float MaxHealth { get; set; }
        public float Damage { get; set; }
        public string Name { get; private set; }
        public string ClassName { get; private set; }
        public List<Item> Inventory { get; set; }
        public Character(float health, float maxHealth, float damage, string name, string className)
        {
            Health = health;
            MaxHealth = maxHealth;
            Damage = damage;
            Name = name;
            ClassName = className;
            Inventory = new List<Item>();
        }

        public virtual void Attack(Character enemy)
        {
            enemy.Health -= this.Damage;
        }

        public virtual void ShowStats()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Class: " + this.ClassName);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Name: " + this.Name);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Health: " + this.Health);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Damage: " + this.Damage);
            Console.ResetColor();
        }
        public virtual void Special()
        {
        }
        public virtual void ResetAbility()
        {
        }
    }
    class Warrior:Character
    {
        public float Armor { get; private set; }
        int specialCooldown = 0;

        public Warrior(float health, float maxHealth, float damage, string name, string className, float armor) : base(health, maxHealth, damage, name, className)
        {
            Armor = armor;
            Health = health + armor;
        }

        public override void ShowStats()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Class: " + this.ClassName);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Name: " + this.Name);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Health: " + this.Health);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Damage: " + this.Damage);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Armor: " + this.Armor);
            Console.ResetColor();
        }
        public override void Special()
        {
            if (specialCooldown == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You have used the DeathBringer!");
                Console.WriteLine("That means double damage!");
                Console.ResetColor();
                this.Damage += this.Damage;
                specialCooldown = 1;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You have already used this Ability");
                Console.ResetColor();
            }
        }
        public override void ResetAbility()
        {
            specialCooldown = 0;
            this.Damage = this.Damage/2;
        }
    }
    class Mage : Character
    {
        int specialCooldown = 0;
        public Mage(float health, float maxHealth, float damage, string name, string className) : base(health, maxHealth, damage, name, className)
        {
        }

        public override void Special()
        {
            if (specialCooldown == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You have healed yourself!");
                Console.ResetColor();
                this.Health = this.MaxHealth;
                specialCooldown = 1;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You have already used this Ability");
                Console.ResetColor();
            }
        }
        public override void ResetAbility()
        {
            specialCooldown = 0;
        }
    }
    class Assassin : Character
    {
        int specialCooldown = 0;
        public Assassin(float health, float maxHealth, float damage, string name, string className) : base(health, maxHealth, damage, name, className)
        {
        }

        public override void Special()
        {
            if (specialCooldown == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You are able to oneshot any enemy!");
                Console.ResetColor();
                this.Damage = 1000;
                specialCooldown = 1;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You have already used this Ability");
                Console.ResetColor();
            }
        }
        public override void ResetAbility()
        {
            specialCooldown = 0;
            this.Damage -= 1000;
        }
    }
    class Item
    {
        public string Name { get; private set; }
        public float Value { get; set; }
        public int Amount { get; set; }

        public Item(string name, float value, int amount)
        {
            Name = name;
            Value = value;
            Amount = amount;
        }
        public virtual void HealPot(Character player)
        {
            player.Health += 40;
        }
        public virtual void DamagePot(Character player)
        {
            player.Damage += 40;
        }
    }
    class HealPotion : Item
    {
        public HealPotion(string name, float value, int amount) : base(name, value, amount)
        {
        }

        public override void HealPot(Character player)
        {
            player.Health += Value;
        }
    }
    class DamagePotion : Item
    {
        public DamagePotion(string name, float value, int amount) : base(name, value, amount)
        {
        }

        public override void DamagePot(Character player)
        {
            player.Damage += Value;
        }
    }
}