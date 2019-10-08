using System;
using System.ComponentModel.DataAnnotations;

namespace Dojodachi.Models
{
    public class Dachi
    {
        [Required]
        public int Fullness {get;set;} = 20;
        [Required]
        public int Happiness {get;set;} = 20;
        [Required]
        public int Meals {get;set;} = 3;
        [Required]
        public int Energy {get;set;} = 50;
        public string Message {get;set;} = "Play with me!";
        Random rand = new Random();

        public void Feed()
        {
            int chance = rand.Next(1,5);
            if(Meals > 0)
            {
                Meals -= 1;
                if(chance != 1)
                {
                    int meal = rand.Next(5,11);
                    Fullness += meal;
                    Message = "You have used one meal and gained " + meal + " in fullness!";
                }
                else
                {
                    Message = "Your Dojodachi does not want to eat! You have lost one meal.";
                }
            }
            return;
        }

        public void Play()
        {
            int chance = rand.Next(1,5);
            if(Energy >= 5)
            {
                Energy -= 5;
                if(chance != 1)
                {
                    int play = rand.Next(5,11);
                    Happiness += play;
                    Message = "You have used 5 energy and gained " + play +" happiness from playing with your Dojodachi!";
                }
                else
                {
                    Message = "Your Dojodachi was not in the mood to play, you have lost 5 energy...";
                }
            }
            return;
        }

        public void Work()
        {
            if(Energy >= 5)
            {
                Energy -= 5;
                int earnMeals = rand.Next(1,4);
                Meals += earnMeals;
                Message = "You have spent 5 energy and earned " + earnMeals + " meals!";
            }
            return;
        }

        public void Sleep()
        {
            if(Fullness >= 5 && Happiness >= 5)
            {
                Energy += 15;
                Fullness -= 5;
                Happiness -= 5;
                Message = "You wake up from a nap and have gained 15 energy, but have lost 5 fullness and happiness.";
            }
            else
            {
                Fullness = 0;
                Happiness = 0;
            }
            return;
        }
    }
}