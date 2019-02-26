namespace Scripting_201910_Parcial1_base.Logic
{
    public class Nitro : Part
    {
        public Nitro() : base()
        {
        }

        public Nitro(float speedBonus) : base(speedBonus)
        {
            SpeedBonus = speedBonus + (speedBonus * Level);
           
        }

        public override VehicleType Type
        {
            get
            {
                return VehicleType.Car;
            }
        }
    }
}