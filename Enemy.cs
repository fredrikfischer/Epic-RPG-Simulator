using System;

namespace OOP2
{
	class Enemy 
	{

        public string name { get; private set; }
        public string description { get; private set;}
        
		public Attribute attackDamage { get; private set; }
        public Attribute defence { get; private set;}
        public Attribute critChance { get; private set; }
        public Attribute critDamage { get; private set; } 
        public Attribute healthPower { get; private set; } 


		public Enemy(){
			name = "Spok";
            description = "Spok is a spooky creature from Transylvania!";
            //this.classType = classType;
            //this.raceType = raceType; 

            attackDamage = new Attribute(80);
            defence = new Attribute(20);
            critChance = new Attribute(0.1);
            critDamage = new Attribute(0.1);
            healthPower = new Attribute(100);


		}

		/* Level level;



		public Monster(Level level)
		{
			this.level = level;
			
		}*/
	}
}