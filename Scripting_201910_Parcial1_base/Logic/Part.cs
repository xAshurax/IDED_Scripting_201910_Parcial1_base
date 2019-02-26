using System;

namespace Scripting_201910_Parcial1_base.Logic
{
    public abstract class Part
    {
        protected float speedBonus;

        public float durability;
      

        public int Level { get; protected set; }
        public abstract VehicleType Type { get; }

        public float SpeedBonus
        {
            get { return 0F; }
            protected set { speedBonus = value; }
        }

        public Part()
        {
        }

        public Part(float speedBonus)
        {
        }

        public Part(float speedBonus, float _durability)
        {
            if(_durability>=0)  {

                if(_durability<= 1)
                {
                    durability = _durability;

                    speedBonus = speedBonus * durability;
                }
            } else
            {
                Console.WriteLine("Durabilidad no valida");
            }
        }



        public void Upgrade()
        { 
            if(Level<3)
            {
                Level++;
                speedBonus = speedBonus + ((speedBonus / 100) * 3); 
            }
        }
    }
}