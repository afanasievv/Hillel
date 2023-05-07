using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SecondLesson
{
    public class Mortar : FireArm
    {   
        public int Weight
        { get; set; }
        public Mortar()
        {
            Weight = 50;
        }
        public override void Reload()
        {
            
            Console.WriteLine("Заряджено!");
            isLoaded = true;

        }
        public override void Shoot()
        {
            if (isLoaded)
            {
                Console.WriteLine("Стрiляю!");
                isLoaded = false;
            }
            else Reload();
            
        }
        public void Aiming(int directionAngle)
        {
            Console.WriteLine(directionAngle);
        }


        public void Aiming(int directionalAngle, int windSpeed)
        {
            Console.WriteLine(directionalAngle.ToString(), windSpeed.ToString());
        }
        public override void FireArmClean()
        {
            base.FireArmClean();
            Console.WriteLine("Чищу мiномет");
        }
    }
}
