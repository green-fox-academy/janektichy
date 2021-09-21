using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftCarrier
{
    class AircraftCarrier
    {
        public List<Aircraft> arsenal;
        public int ammoStored;
        public int health;
        public AircraftCarrier(int ammoStored, int health)
        {
            this.arsenal = new List<Aircraft>();
            this.ammoStored = ammoStored;
            this.health = health;
        }
        public void Add(Aircraft aircraft)
        {
            this.arsenal.Add(aircraft);
        }
        public void fill()
        {
            if (this.ammoStored == 0)
            {
                Exception noAmmo = new Exception("There is no ammo in the storage");
                throw noAmmo;
            }
            else
            {
                foreach (var gun in this.arsenal)
                {
                    this.ammoStored = gun.RefillAmmo(this.ammoStored);
                }
            }
        }
        public void Fight(AircraftCarrier enemy)
        {
            int allDamage = 0;
            foreach (var gun in this.arsenal)
            {
                allDamage += gun.Fight();
            }
            enemy.health -= allDamage;
        }
        public void GetStatus()
        {
            if (this.health <= 0)
            {
                Console.WriteLine("It's dead Jim :(");
            }
            else
            {
                int totalDamage = 0;
                foreach (var gun in this.arsenal)
                {
                    totalDamage = gun.currentAmmo * gun.baseDamage;
                }
                Console.WriteLine($"HP: {this.health}, Aircraft Count {this.arsenal.Count}, Ammo Storage: {this.ammoStored}, Total Damage: {totalDamage} ");
                Console.WriteLine("Aircrafts:");
                foreach (var gun in this.arsenal)
                {
                    gun.GetStatus();
                }
            }
        }
    }
}
