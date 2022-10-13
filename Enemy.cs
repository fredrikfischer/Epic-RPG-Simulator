using System;

namespace OOP2
{
	class Enemy 
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
            description = "";
            bounty = 50 * difficulty;
            this.difficulty = difficulty;


            attackDamage = new Attribute(80 * difficulty);
            defence = new Attribute(20 * difficulty);
            critChance = new Attribute(0.1 * difficulty);
            critDamage = new Attribute(0.1 * difficulty);
            healthPoints = new Attribute(100 * difficulty);

			//name = "Spok";
            //description = "Spok is a spooky creature from Transylvania!";
            
        
            /* attackDamage = new Attribute(80);
            defence = new Attribute(20);
            critChance = new Attribute(0.1);
            critDamage = new Attribute(0.1);
            healthPoints = new Attribute(100); */


		}

        private string GenerateName()
        {
            string[] name = {"Spok", "Murloc", "Wolf", "Centaur", "Golem", "Troll", "Dragon", "Ghost"};
            Random rnd = new Random();
            return name[rnd.Next(0, name.Length - 1)];

        }



		/* Level level;



		public Monster(Level level)
		{
			this.level = level;
			
		}*/
	}
}