using System;

namespace rpgchars
{
    public class Human
    {
        public string name;
        //The { get; set; } format creates accessor methods for the field specified
        //This is done to allow flexibility
        public int health { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }
        public Human(string person)
        {
            name = person;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }
        public void DisplayStats()
        {
            Console.WriteLine($"Name: {name}, Strength: {strength}, Intelligence: {intelligence}, Dexterity: {dexterity}, Health: {health}");
        }
        public Human(string person, int str, int intel, int dex, int hp)
        {
            name = person;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = hp;
        }
        public void attack(object obj)
        {
            Human enemy = obj as Human;
            if(enemy == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                enemy.health -= strength * 5;
            }
        }
    }
    
    
    public class Wizard : Human 
    {
        public void Thundaga(Human enemy)
        {
            Random rand = new Random();
            if (enemy == null)
            {
                Console.WriteLine("Thundaga missed!");
            }
            else 
            {
                int damage = rand.Next(40, 60);
                Console.WriteLine($"...Casting Thundaga on {enemy.name}...");
                Console.WriteLine($"Dealt {damage} damage!");
                enemy.health -= damage;
            }
        }
         public void Heal()
        {
            health += 10 * intelligence;
        }
        public void FireBall(Human enemy)
        {
            Random rand = new Random();
            if (enemy == null)
            {
                Console.WriteLine("Fire Ball Failed");
            }
            else 
            {
                int damage = rand.Next(20, 50);
                Console.WriteLine($"...Casting Fire Ball on {enemy.name}...");
                Console.WriteLine($"Dealt {damage} damage!");
                enemy.health -= damage;
            }
        }
        public Wizard(string name, int str = 1, int dex = 3) : base(name, str, 25, dex, 50)
        {
        }   
    }
    public class Ninja : Human
    {
        public void BackStab(Human enemy)
        {
            Random rand = new Random();
            if (enemy == null)
            {
                Console.WriteLine("BackStab missed!");
            }
            else 
            {
                int damage = rand.Next(40, 60);
                Console.WriteLine($"...Sneaking up with BackStab on {enemy.name}...");
                Console.WriteLine($"Dealt {damage} damage!");
                enemy.health -= damage;
            }
        }
        public void Steal(Human enemy)
        {
            attack(enemy);
            health += 10;

        }
        public void Retreat()
        {
            health -= 15;
        }
        public Ninja(string name, int str = 3, int intl = 3, int hlth = 100) : base(name, str, intl, 175, hlth)
        {
        }
    }
    public class Samurai : Human 
    {
        public void MoonlightSlash(Human enemy)
        {
            Random rand = new Random();
            if (enemy == null)
            {
                Console.WriteLine("Missed with Moonlight Slash!");
            }
            else 
            {
                int damage = rand.Next(80, 100);
                Console.WriteLine($"...Readying for Moonlight Slash on {enemy.name}...");
                Console.WriteLine($"Dealt {damage} damage!");
                enemy.health -= damage;
            }
        }
        public void DeathBlow(Human enemy)
        {
            if (enemy == null)
            {
                Console.WriteLine("Death Blow failed!");
            }
            else if (enemy != null && enemy.health >= 50)
            {
                attack(enemy);
            }
            else if (enemy != null && enemy.health < 50)
            {
                enemy.health = 0;
                Console.WriteLine($"You have slayed {enemy.name}");
            }
        }
        public void Meditate()
        {
            if (health < 200)
            {
                Console.WriteLine("...Meditating...");
                health = 200;
                Console.WriteLine("Health restored!");
            }
            else 
            {
                Console.WriteLine("Meditation failed!");
            }
        }
        public Samurai(string name, int intl = 3, int dex = 3) : base(name, 6, intl, dex, 200)
        {
        }
    }
}