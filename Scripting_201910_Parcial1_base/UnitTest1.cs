using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scripting_201910_Parcial1_base.Logic;

namespace Scripting_201910_Parcial1_base
{
    [TestClass]
    public class UnitTest1
    {
        private Car c1 = new Car(500F);
        private Car c2 = new Car(350F);
        private Car c3 = new Car(50F);
        private Car c4 = new Car();

        private Bike b1 = new Bike(420F);
        private Bike b2 = new Bike(112F);
        private Bike b3 = new Bike(2000F);
        private Bike b4 = new Bike();

        private Nitro n1 = new Nitro();
        private Nitro n2 = new Nitro(0.65F);

        private Muffler m1 = new Muffler();
        private Muffler m2 = new Muffler(0.02F);

        private Turbo t1 = new Turbo();
        private Turbo t2 = new Turbo(1F);

        [TestMethod()]
        public void TestPartParams()
        {
            Assert.AreEqual(t1.SpeedBonus, 0F);
            Assert.AreEqual(t2.SpeedBonus, 0.5F);

            Nitro tempN1 = n1;
            tempN1.Upgrade();

            Assert.AreEqual(tempN1.SpeedBonus, 0F);

            Muffler tempM2 = m2;
            tempM2.Upgrade();
            tempM2.Upgrade();

            Assert.AreEqual(m2.SpeedBonus, 0.0212F);
        }

        [TestMethod()]
        public void TestVehicleParams()
        {
            Bike tempB1 = b1;
            Nitro tempN2 = n2;

            tempB1.Equip(tempN2);
            Assert.AreEqual(tempB1.MaxSpeed, 420F);

            tempB1.Upgrade();
            Assert.AreEqual(tempB1.MaxSpeed, 441F);

            tempB1.Equip(m2);
            Assert.AreEqual(tempB1.MaxSpeed, 449.82F);

            Car tempC1 = c1;

            tempC1.Equip(m1);
            Assert.AreEqual(tempC1.MaxSpeed, 500F);

            tempC1.Equip(tempN2);
            Assert.AreEqual(tempC1.MaxSpeed, 750F);

            tempC1.Upgrade();
            Assert.AreEqual(tempC1.MaxSpeed, 795.375F);
        }

        [TestMethod()]
        public void TestPartEquipment()
        {
            Assert.AreEqual(b1.Equip(t1), true);
            Assert.AreEqual(b1.Equip(m1), true);
            Assert.AreEqual(b1.Equip(n1), false);

            Assert.AreEqual(c1.Equip(t2), true);
            Assert.AreEqual(c1.Equip(m1), false);
            Assert.AreEqual(c1.Equip(n2), true);
        }
    }
}