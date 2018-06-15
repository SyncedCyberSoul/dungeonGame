using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthanChristinaProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //character type info

            //heros

            //Warrior
            Heros Warrior = new Heros();
            Warrior.heroType = 1;
            Warrior.heroName = "Warrior";
            Warrior.heroHealth = 125;
            Warrior.heroAttack = 60;
            Warrior.heroSpeed = 40;
            Warrior.heroRange = 0;
            //Archer
            Heros Archer = new Heros();
            Archer.heroType = 2;
            Archer.heroName = "Archer";
            Archer.heroHealth = 110;
            Archer.heroAttack = 20;
            Archer.heroSpeed = 55;
            Archer.heroRange = 60;
            Archer.experience = 0;
            //Mage
            Heros Mage = new Heros();
            Mage.heroType = 3;
            Mage.heroName = "Mage";
            Mage.heroHealth = 100;
            Mage.heroAttack = 30;
            Mage.heroSpeed = 50;
            Mage.heroRange = 40;
            Mage.experience = 0;
            //Assassin
            Heros Assassin = new Heros();
            Assassin.heroType = 4;
            Assassin.heroName = "Assassin";
            Assassin.heroHealth = 95;
            Assassin.heroAttack = 40;
            Assassin.heroSpeed = 60;
            Assassin.heroRange = 30;
            Assassin.experience = 0;

            //monsters

            //AngryTree
            DungeonMonsters AngryTree = new DungeonMonsters();
            AngryTree.monsterType = 1;
            AngryTree.monsterName = "Angry Tree";
            AngryTree.monsterHealth = 50;
            AngryTree.monsterAttack = 25;
            AngryTree.monsterSpeed = 34;
            AngryTree.monsterRange = 5;
            AngryTree.experience = 150;
            //RangeRoot
            DungeonMonsters RageRoot = new DungeonMonsters();
            RageRoot.monsterType = 2;
            RageRoot.monsterName = "Rage Root";
            RageRoot.monsterHealth = 30;
            RageRoot.monsterAttack = 10;
            RageRoot.monsterSpeed = 30;
            RageRoot.monsterRange = 30;
            RageRoot.experience = 150;
            //SlingDemon
            DungeonMonsters SlingDemon = new DungeonMonsters();
            SlingDemon.monsterType = 3;
            SlingDemon.monsterName = "Sling Demon";
            SlingDemon.monsterHealth = 85;
            SlingDemon.monsterAttack = 10;
            SlingDemon.monsterSpeed = 35;
            SlingDemon.monsterRange = 15;
            SlingDemon.experience = 75;
            //Goblin
            DungeonMonsters Goblin = new DungeonMonsters();
            Goblin.monsterType = 4;
            Goblin.monsterName = "Goblin";
            Goblin.monsterHealth = 100;
            Goblin.monsterAttack = 30;
            Goblin.monsterSpeed = 25;
            Goblin.monsterRange = 0;
            Goblin.experience = 75;
            //game start screen
            Console.WriteLine("________                                             _________                      .__                ");
            Console.WriteLine("\\______ \\  __ __  ____    ____   ____  ____   ____   \\_   ___ \\____________ __  _  _|  |   ___________ ");
            Console.WriteLine("|    |  \\|  |  \\/    \\  / ___\\_/ __ \\/  _ \\ /    \\  /    \\  \\/\\_  __ \\__  \\ \\/ \\/ /  | _/ __ \\_  __ \\ ");
            Console.WriteLine("|    `   \\  |  /   |  \\/ /_/  >  ___(  <_> )   |  \\ \\     \\____|  | \\// __ \\     /|  |_\\  ___/|  | \\/");
            Console.WriteLine("/_______  /____/|___|  /\\___  / \\___  >____/|___|  /  \\______  /|__|  (____  /\\/\\_/ |____/\\___  >__|   ");
            Console.WriteLine("        \\/           \\//_____/      \\/           \\/          \\/            \\/                 \\/       ");
            Console.Read();
            //hero selection

            //monster array
            string[] DungeonMonsters = new stringArray[4] {AngryTree, SlingDemon, Goblin, RageRoot   };

            
            //xp
        }
    }
}
