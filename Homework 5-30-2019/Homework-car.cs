using System;

namespace HW_car
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EXTREMESPEED: KART TIME!");
            cars Myracecar1 = new cars(" Coral and sky blue with stripes",  1000, "Tesla");
            Myracecar1.SuperRaceCarsName("TESS TESSA");



            Console.WriteLine("Dun dun dun~ Mario kart time!");
            cars MarioCart = new cars("Teal and Pink with polka dots", 1111, "Toyota with wings that can soar all the way too space!!");
            MarioCart.SuperRaceCarsName("PEACHES");



            Console.WriteLine("Dun dun dun dun....another round of mario kart. This time with Princess Peach!! So prepare for something different!");
            cars PrincessPeachKart = new cars("Goldenrod with shades of pink", 5000, "Flying Cart");
            PrincessPeachKart.SuperRaceCarsName("FLYING PEACHES!"); 


            
        }
    }
    public class cars
    {
        public static string _colors { set; get; }

        public static int _speed { set; get; }

        public static string  _brands { set; get; }

        public cars (string colors, int speed, string brands)
        {

            _colors = colors;
            _speed = speed;
            _brands = brands;

            Console.WriteLine("Hello user this is your new race car!");
            Console.WriteLine("This is your current car color {0}", colors);
            Console.WriteLine("The speed of your car is gonna be {0} and your brand is {1} ", speed, brands); 

            

        }
        public void SuperRaceCarsName (string SRC)
        {
            Console.WriteLine("This will be the new name for your super race car!! {0}", SRC); 

        }




    }
}
