using System;

namespace OOP2
{
	public class Enemy : IAttributes
	{

        public string name { get; private set; }
        public string description { get; private set;}
        public int difficulty { get; private set; }
        public int bounty {get; private set; }
		public Attribute attackDamage { get; private set; }
        public Attribute defence { get; private set;}
        public Attribute critChance { get; private set; }
        public Attribute critDamage { get; private set; } 
        public Attribute healthPoints { get; private set; } 


		public Enemy(int difficulty){

            name = GenerateName();
            bounty = 80 * ((difficulty / 2) + 1);
            this.difficulty = difficulty;
            description = "A spooky creature from Transylvania!";


            attackDamage = new Attribute(80 * ((difficulty / 2) + 1));
            defence = new Attribute(20 * ((difficulty / 2) + 1));
            critChance = new Attribute(0.1);
            critDamage = new Attribute(0.1);
            healthPoints = new Attribute(700 * ((difficulty / 2) + 1));

            
        
		}

        private string GenerateName()
        {
            string[] name = {"Spok", "Murloc", "Wolf", "Centaur", "Goolem", "Troll", "Dragon", "Ghust"};
            Random rnd = new Random();
            return name[rnd.Next(0, name.Length - 1)];

        }


	}
}