﻿namespace Scripting_201910_Parcial1_base.Logic
{
    public abstract class Vehicle
    {
        protected float baseMaxSpeed;

        protected int Level { get; set; }

        protected abstract VehicleType Type { get; }

        protected Part CurrentPart { get; set; }

        public float MaxSpeed
        {
            get
            {
                return 0F;
            }
            set
            {
                MaxSpeed = baseMaxSpeed + CurrentPart.SpeedBonus;
            }
        }

        

        public Vehicle()
        {
        }

        public Vehicle(float _baseMaxSpeed)
        {
            baseMaxSpeed = _baseMaxSpeed;
            Level = 0;
            CurrentPart = null;
        }

        public bool Equip(Part part)
        {
            bool result = false;

            if (Type == part.Type || part.Type == VehicleType.Any)
            {
                CurrentPart = part;
                result = true;

            }

            return result;
        }

        

        public void Upgrade()
        {
            if (Level < 4)
            {
                Level++;

                baseMaxSpeed = baseMaxSpeed + ((baseMaxSpeed / 100) * 5);   
                if(CurrentPart!= null)
                {
                    CurrentPart.Upgrade();
                    
                }
                
            }
        }
    }
}