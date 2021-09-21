using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftCarrier
{
    class Aircraft
    {
        public int currentAmmo;
        public int maxAmmo;
        public int baseDamage;
        public string type;
        public Aircraft()
        {
            this.currentAmmo = 0;
        }
        public int Fight()
        {
            int damageGiven = this.currentAmmo * this.baseDamage;
            this.currentAmmo = 0;
            return damageGiven;
        }
        public int RefillAmmo(int ammoComing)
        {
            int giveBack = 0;
            this.currentAmmo += ammoComing;
            if (this.currentAmmo > this.maxAmmo)
            {
                giveBack = this.currentAmmo - this.maxAmmo;
                this.currentAmmo -= giveBack;
            }
            return giveBack;
        }
        public string GetType()
        {
            return this.type;
        }
        public void GetStatus()
        {
            Console.WriteLine($"Type: {this.type}, Ammo: {this.currentAmmo}, Base Damage: {this.baseDamage}, All Damage {this.baseDamage * this.maxAmmo}");
        }
        public bool IsPriority()
        {
            return (this.type == "F35");
        }

    }
}
