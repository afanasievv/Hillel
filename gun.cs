using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLesson
{
    public class Gun : FireArm

    {
        private int magazineCapacity;
        private int magazineCurrentAmount;
        private int weight;
        private int firingRange = 50;

        public int Weight
        {
            get { return weight; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Вага має бути більша за 0");
                else
                    weight = value;
            }
        }

        public int FiringRange
        {
            get { return firingRange; }
        }

        public Gun()
        { }
        public Gun(int magazineCapacity)
        {
            this.magazineCapacity = magazineCapacity;
        }

        public void MagazineAddCartriges(int count)
        {

            if ((count + magazineCurrentAmount) <= magazineCapacity && count > 0)

            {
                magazineCurrentAmount += count;
                Console.WriteLine($"Магазин споряджено! Кiлькiсть набоїв: {magazineCurrentAmount}");
            }
            else
            {
                Console.WriteLine($"Магазин споряджено! Кiлькiсть набоїв: {magazineCapacity}");
                Console.WriteLine($"Залишилось {(count + magazineCurrentAmount) - magazineCapacity} зайвих набоїв");
                magazineCurrentAmount = magazineCapacity;

            }
        }

        public override void Reload()
        {
            if (magazineCurrentAmount >= 1)
            {
                Console.WriteLine("Заряджаю...");
                isLoaded = true;
                Shoot();
            }
            else Console.WriteLine("Закiнчились набої");

        }

        public override void Shoot()
        {
            if (isLoaded)
            {
                Console.WriteLine("Стрiляю!");
                isLoaded = false;
                magazineCurrentAmount -= 1;
                Console.WriteLine($"Залишилось {magazineCurrentAmount} патронiв"); ;

            }
            else Reload();

        }

    }
}
